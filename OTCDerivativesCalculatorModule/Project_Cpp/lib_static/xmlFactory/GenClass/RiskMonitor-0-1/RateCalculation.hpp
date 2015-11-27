// RateCalculation.hpp 
#ifndef FpmlSerialized_RateCalculation_hpp
#define FpmlSerialized_RateCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/CalculationAmount.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <RiskMonitor-0-1/VanillaRateCalculation.hpp>

namespace FpmlSerialized {

class RateCalculation : public ISerialized { 
   public: 
       RateCalculation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isCalculationAmount(){return this->calculationAmountIsNull_;}
       boost::shared_ptr<CalculationAmount> getCalculationAmount();


       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationStartDate();


       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationEndDate();


       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getPaymentDate();


       bool isVanillaRateCalculation(){return this->vanillaRateCalculationIsNull_;}
       boost::shared_ptr<VanillaRateCalculation> getVanillaRateCalculation();


       std::string getChoiceStr_rateCalType(){
           std::string str;
           int count = 0;
           if(!vanillaRateCalculationIsNull_){
                count += 1;
                str = "vanillaRateCalculation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_rateCalType_ = str ;
           return choiceStr_rateCalType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<CalculationAmount> calculationAmount_;
       
       bool calculationAmountIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationStartDate_;
       
       bool calculationStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationEndDate_;
       
       bool calculationEndDateIsNull_;
       boost::shared_ptr<XsdTypeDate> paymentDate_;
       
       bool paymentDateIsNull_;
         boost::shared_ptr<VanillaRateCalculation> vanillaRateCalculation_;     //choice
       
       bool vanillaRateCalculationIsNull_;

       //choiceStr 
       std::string choiceStr_rateCalType_;

};

} //namespaceFpmlSerialized end
#endif

