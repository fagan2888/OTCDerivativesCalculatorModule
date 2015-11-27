// CommoditySpreadSchedule.hpp 
#ifndef FpmlSerialized_CommoditySpreadSchedule_hpp
#define FpmlSerialized_CommoditySpreadSchedule_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommoditySpread.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>

namespace FpmlSerialized {

class CommoditySpreadSchedule : public ISerialized { 
   public: 
       CommoditySpreadSchedule(TiXmlNode* xmlNode);

       bool isSpreadStep(){return this->spreadStepIsNull_;}
       std::vector<boost::shared_ptr<CommoditySpread>> getSpreadStep();
      std::string getSpreadStepIDRef(){return spreadStepIDRef_;}

       bool isCalculationPeriodsReference(){return this->calculationPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getCalculationPeriodsReference();
      std::string getCalculationPeriodsReferenceIDRef(){return calculationPeriodsReferenceIDRef_;}

       bool isCalculationPeriodsScheduleReference(){return this->calculationPeriodsScheduleReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsScheduleReference> getCalculationPeriodsScheduleReference();
      std::string getCalculationPeriodsScheduleReferenceIDRef(){return calculationPeriodsScheduleReferenceIDRef_;}

       bool isCalculationPeriodsDatesReference(){return this->calculationPeriodsDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsDatesReference> getCalculationPeriodsDatesReference();
      std::string getCalculationPeriodsDatesReferenceIDRef(){return calculationPeriodsDatesReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!calculationPeriodsReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsReference" ;
           }
           if(!calculationPeriodsScheduleReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsScheduleReference" ;
           }
           if(!calculationPeriodsDatesReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsDatesReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       std::vector<boost::shared_ptr<CommoditySpread>> spreadStep_;
       std::string spreadStepIDRef_;
       bool spreadStepIsNull_;
         boost::shared_ptr<CalculationPeriodsReference> calculationPeriodsReference_;     //choice
       std::string calculationPeriodsReferenceIDRef_;
       bool calculationPeriodsReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsScheduleReference> calculationPeriodsScheduleReference_;     //choice
       std::string calculationPeriodsScheduleReferenceIDRef_;
       bool calculationPeriodsScheduleReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsDatesReference> calculationPeriodsDatesReference_;     //choice
       std::string calculationPeriodsDatesReferenceIDRef_;
       bool calculationPeriodsDatesReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

