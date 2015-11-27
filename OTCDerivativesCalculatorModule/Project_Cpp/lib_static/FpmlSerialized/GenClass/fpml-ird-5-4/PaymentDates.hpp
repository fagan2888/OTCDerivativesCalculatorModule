// PaymentDates.hpp 
#ifndef FpmlSerialized_PaymentDates_hpp
#define FpmlSerialized_PaymentDates_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/CalculationPeriodDatesReference.hpp>
#include <fpml-ird-5-4/ResetDatesReference.hpp>
#include <fpml-ird-5-4/ValuationDatesReference.hpp>
#include <fpml-shared-5-4/Frequency.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-enum-5-4/PayRelativeToEnum.hpp>
#include <fpml-shared-5-4/Offset.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>

namespace FpmlSerialized {

class PaymentDates : public ISerialized { 
   public: 
       PaymentDates(TiXmlNode* xmlNode);

       bool isCalculationPeriodDatesReference(){return this->calculationPeriodDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodDatesReference> getCalculationPeriodDatesReference();
      std::string getCalculationPeriodDatesReferenceIDRef(){return calculationPeriodDatesReferenceIDRef_;}

       bool isResetDatesReference(){return this->resetDatesReferenceIsNull_;}
       boost::shared_ptr<ResetDatesReference> getResetDatesReference();
      std::string getResetDatesReferenceIDRef(){return resetDatesReferenceIDRef_;}

       bool isValuationDatesReference(){return this->valuationDatesReferenceIsNull_;}
       boost::shared_ptr<ValuationDatesReference> getValuationDatesReference();
      std::string getValuationDatesReferenceIDRef(){return valuationDatesReferenceIDRef_;}

       bool isPaymentFrequency(){return this->paymentFrequencyIsNull_;}
       boost::shared_ptr<Frequency> getPaymentFrequency();
      std::string getPaymentFrequencyIDRef(){return paymentFrequencyIDRef_;}

       bool isFirstPaymentDate(){return this->firstPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFirstPaymentDate();
      std::string getFirstPaymentDateIDRef(){return firstPaymentDateIDRef_;}

       bool isLastRegularPaymentDate(){return this->lastRegularPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getLastRegularPaymentDate();
      std::string getLastRegularPaymentDateIDRef(){return lastRegularPaymentDateIDRef_;}

       bool isPayRelativeTo(){return this->payRelativeToIsNull_;}
       boost::shared_ptr<PayRelativeToEnum> getPayRelativeTo();
      std::string getPayRelativeToIDRef(){return payRelativeToIDRef_;}

       bool isPaymentDaysOffset(){return this->paymentDaysOffsetIsNull_;}
       boost::shared_ptr<Offset> getPaymentDaysOffset();
      std::string getPaymentDaysOffsetIDRef(){return paymentDaysOffsetIDRef_;}

       bool isPaymentDatesAdjustments(){return this->paymentDatesAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getPaymentDatesAdjustments();
      std::string getPaymentDatesAdjustmentsIDRef(){return paymentDatesAdjustmentsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!calculationPeriodDatesReferenceIsNull_){
                count += 1;
                str = "calculationPeriodDatesReference" ;
           }
           if(!resetDatesReferenceIsNull_){
                count += 1;
                str = "resetDatesReference" ;
           }
           if(!valuationDatesReferenceIsNull_){
                count += 1;
                str = "valuationDatesReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference_;     //choice
       std::string calculationPeriodDatesReferenceIDRef_;
       bool calculationPeriodDatesReferenceIsNull_;
         boost::shared_ptr<ResetDatesReference> resetDatesReference_;     //choice
       std::string resetDatesReferenceIDRef_;
       bool resetDatesReferenceIsNull_;
         boost::shared_ptr<ValuationDatesReference> valuationDatesReference_;     //choice
       std::string valuationDatesReferenceIDRef_;
       bool valuationDatesReferenceIsNull_;
       boost::shared_ptr<Frequency> paymentFrequency_;
       std::string paymentFrequencyIDRef_;
       bool paymentFrequencyIsNull_;
       boost::shared_ptr<XsdTypeDate> firstPaymentDate_;
       std::string firstPaymentDateIDRef_;
       bool firstPaymentDateIsNull_;
       boost::shared_ptr<XsdTypeDate> lastRegularPaymentDate_;
       std::string lastRegularPaymentDateIDRef_;
       bool lastRegularPaymentDateIsNull_;
       boost::shared_ptr<PayRelativeToEnum> payRelativeTo_;
       std::string payRelativeToIDRef_;
       bool payRelativeToIsNull_;
       boost::shared_ptr<Offset> paymentDaysOffset_;
       std::string paymentDaysOffsetIDRef_;
       bool paymentDaysOffsetIsNull_;
       boost::shared_ptr<BusinessDayAdjustments> paymentDatesAdjustments_;
       std::string paymentDatesAdjustmentsIDRef_;
       bool paymentDatesAdjustmentsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

