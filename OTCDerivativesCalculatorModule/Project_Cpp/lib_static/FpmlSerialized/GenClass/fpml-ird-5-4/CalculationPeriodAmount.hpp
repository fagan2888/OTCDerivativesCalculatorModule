// CalculationPeriodAmount.hpp 
#ifndef FpmlSerialized_CalculationPeriodAmount_hpp
#define FpmlSerialized_CalculationPeriodAmount_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/Calculation.hpp>
#include <fpml-shared-5-4/AmountSchedule.hpp>

namespace FpmlSerialized {

class CalculationPeriodAmount : public ISerialized { 
   public: 
       CalculationPeriodAmount(TiXmlNode* xmlNode);

       bool isCalculation(){return this->calculationIsNull_;}
       boost::shared_ptr<Calculation> getCalculation();
      std::string getCalculationIDRef(){return calculationIDRef_;}

       bool isKnownAmountSchedule(){return this->knownAmountScheduleIsNull_;}
       boost::shared_ptr<AmountSchedule> getKnownAmountSchedule();
      std::string getKnownAmountScheduleIDRef(){return knownAmountScheduleIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!calculationIsNull_){
                count += 1;
                str = "calculation" ;
           }
           if(!knownAmountScheduleIsNull_){
                count += 1;
                str = "knownAmountSchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<Calculation> calculation_;     //choice
       std::string calculationIDRef_;
       bool calculationIsNull_;
         boost::shared_ptr<AmountSchedule> knownAmountSchedule_;     //choice
       std::string knownAmountScheduleIDRef_;
       bool knownAmountScheduleIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

