// PaymentCalculationPeriod.hpp 
#ifndef FpmlSerialized_PaymentCalculationPeriod_hpp
#define FpmlSerialized_PaymentCalculationPeriod_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-ird-5-4/CalculationPeriod.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class PaymentCalculationPeriod : public PaymentBase { 
   public: 
       PaymentCalculationPeriod(TiXmlNode* xmlNode);

       bool isUnadjustedPaymentDate(){return this->unadjustedPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getUnadjustedPaymentDate();
      std::string getUnadjustedPaymentDateIDRef(){return unadjustedPaymentDateIDRef_;}

       bool isAdjustedPaymentDate(){return this->adjustedPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedPaymentDate();
      std::string getAdjustedPaymentDateIDRef(){return adjustedPaymentDateIDRef_;}

       bool isCalculationPeriod(){return this->calculationPeriodIsNull_;}
       std::vector<boost::shared_ptr<CalculationPeriod>> getCalculationPeriod();
      std::string getCalculationPeriodIDRef(){return calculationPeriodIDRef_;}

       bool isFixedPaymentAmount(){return this->fixedPaymentAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getFixedPaymentAmount();
      std::string getFixedPaymentAmountIDRef(){return fixedPaymentAmountIDRef_;}

       bool isDiscountFactor(){return this->discountFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getDiscountFactor();
      std::string getDiscountFactorIDRef(){return discountFactorIDRef_;}

       bool isForecastPaymentAmount(){return this->forecastPaymentAmountIsNull_;}
       boost::shared_ptr<Money> getForecastPaymentAmount();
      std::string getForecastPaymentAmountIDRef(){return forecastPaymentAmountIDRef_;}

       bool isPresentValueAmount(){return this->presentValueAmountIsNull_;}
       boost::shared_ptr<Money> getPresentValueAmount();
      std::string getPresentValueAmountIDRef(){return presentValueAmountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!calculationPeriodIsNull_){
                count += 1;
                str = "calculationPeriod" ;
           }
           if(!fixedPaymentAmountIsNull_){
                count += 1;
                str = "fixedPaymentAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeDate> unadjustedPaymentDate_;
       std::string unadjustedPaymentDateIDRef_;
       bool unadjustedPaymentDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedPaymentDate_;
       std::string adjustedPaymentDateIDRef_;
       bool adjustedPaymentDateIsNull_;
         std::vector<boost::shared_ptr<CalculationPeriod>> calculationPeriod_;     //choice
       std::string calculationPeriodIDRef_;
       bool calculationPeriodIsNull_;
         boost::shared_ptr<XsdTypeDecimal> fixedPaymentAmount_;     //choice
       std::string fixedPaymentAmountIDRef_;
       bool fixedPaymentAmountIsNull_;
       boost::shared_ptr<XsdTypeDecimal> discountFactor_;
       std::string discountFactorIDRef_;
       bool discountFactorIsNull_;
       boost::shared_ptr<Money> forecastPaymentAmount_;
       std::string forecastPaymentAmountIDRef_;
       bool forecastPaymentAmountIsNull_;
       boost::shared_ptr<Money> presentValueAmount_;
       std::string presentValueAmountIDRef_;
       bool presentValueAmountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

