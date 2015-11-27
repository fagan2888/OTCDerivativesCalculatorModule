// PeriodicPayment.hpp 
#ifndef FpmlSerialized_PeriodicPayment_hpp
#define FpmlSerialized_PeriodicPayment_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-enum-5-4/RollConventionEnum.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-cd-5-4/FixedAmountCalculation.hpp>
#include <fpml-cd-5-4/AdjustedPaymentDates.hpp>

namespace FpmlSerialized {

class PeriodicPayment : public PaymentBase { 
   public: 
       PeriodicPayment(TiXmlNode* xmlNode);

       bool isPaymentFrequency(){return this->paymentFrequencyIsNull_;}
       boost::shared_ptr<Period> getPaymentFrequency();
      std::string getPaymentFrequencyIDRef(){return paymentFrequencyIDRef_;}

       bool isFirstPeriodStartDate(){return this->firstPeriodStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFirstPeriodStartDate();
      std::string getFirstPeriodStartDateIDRef(){return firstPeriodStartDateIDRef_;}

       bool isFirstPaymentDate(){return this->firstPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFirstPaymentDate();
      std::string getFirstPaymentDateIDRef(){return firstPaymentDateIDRef_;}

       bool isLastRegularPaymentDate(){return this->lastRegularPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getLastRegularPaymentDate();
      std::string getLastRegularPaymentDateIDRef(){return lastRegularPaymentDateIDRef_;}

       bool isRollConvention(){return this->rollConventionIsNull_;}
       boost::shared_ptr<RollConventionEnum> getRollConvention();
      std::string getRollConventionIDRef(){return rollConventionIDRef_;}

       bool isFixedAmount(){return this->fixedAmountIsNull_;}
       boost::shared_ptr<Money> getFixedAmount();
      std::string getFixedAmountIDRef(){return fixedAmountIDRef_;}

       bool isFixedAmountCalculation(){return this->fixedAmountCalculationIsNull_;}
       boost::shared_ptr<FixedAmountCalculation> getFixedAmountCalculation();
      std::string getFixedAmountCalculationIDRef(){return fixedAmountCalculationIDRef_;}

       bool isAdjustedPaymentDates(){return this->adjustedPaymentDatesIsNull_;}
       std::vector<boost::shared_ptr<AdjustedPaymentDates>> getAdjustedPaymentDates();
      std::string getAdjustedPaymentDatesIDRef(){return adjustedPaymentDatesIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!fixedAmountIsNull_){
                count += 1;
                str = "fixedAmount" ;
           }
           if(!fixedAmountCalculationIsNull_){
                count += 1;
                str = "fixedAmountCalculation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<Period> paymentFrequency_;
       std::string paymentFrequencyIDRef_;
       bool paymentFrequencyIsNull_;
       boost::shared_ptr<XsdTypeDate> firstPeriodStartDate_;
       std::string firstPeriodStartDateIDRef_;
       bool firstPeriodStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> firstPaymentDate_;
       std::string firstPaymentDateIDRef_;
       bool firstPaymentDateIsNull_;
       boost::shared_ptr<XsdTypeDate> lastRegularPaymentDate_;
       std::string lastRegularPaymentDateIDRef_;
       bool lastRegularPaymentDateIsNull_;
       boost::shared_ptr<RollConventionEnum> rollConvention_;
       std::string rollConventionIDRef_;
       bool rollConventionIsNull_;
         boost::shared_ptr<Money> fixedAmount_;     //choice
       std::string fixedAmountIDRef_;
       bool fixedAmountIsNull_;
         boost::shared_ptr<FixedAmountCalculation> fixedAmountCalculation_;     //choice
       std::string fixedAmountCalculationIDRef_;
       bool fixedAmountCalculationIsNull_;
       std::vector<boost::shared_ptr<AdjustedPaymentDates>> adjustedPaymentDates_;
       std::string adjustedPaymentDatesIDRef_;
       bool adjustedPaymentDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

