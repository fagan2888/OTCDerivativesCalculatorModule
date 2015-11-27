// TermDeposit.hpp 
#ifndef FpmlSerialized_TermDeposit_hpp
#define FpmlSerialized_TermDeposit_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-shared-5-4/PositiveMoney.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>
#include <fpml-fx-5-4/TermDepositFeatures.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-shared-5-4/Payment.hpp>

namespace FpmlSerialized {

class TermDeposit : public Product { 
   public: 
       TermDeposit(TiXmlNode* xmlNode);

       bool isPayerPartyReference(){return this->payerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPayerPartyReference();
      std::string getPayerPartyReferenceIDRef(){return payerPartyReferenceIDRef_;}

       bool isPayerAccountReference(){return this->payerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getPayerAccountReference();
      std::string getPayerAccountReferenceIDRef(){return payerAccountReferenceIDRef_;}

       bool isReceiverPartyReference(){return this->receiverPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getReceiverPartyReference();
      std::string getReceiverPartyReferenceIDRef(){return receiverPartyReferenceIDRef_;}

       bool isReceiverAccountReference(){return this->receiverAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getReceiverAccountReference();
      std::string getReceiverAccountReferenceIDRef(){return receiverAccountReferenceIDRef_;}

       bool isStartDate(){return this->startDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getStartDate();
      std::string getStartDateIDRef(){return startDateIDRef_;}

       bool isMaturityDate(){return this->maturityDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMaturityDate();
      std::string getMaturityDateIDRef(){return maturityDateIDRef_;}

       bool isTenorName(){return this->tenorNameIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getTenorName();
      std::string getTenorNameIDRef(){return tenorNameIDRef_;}

       bool isTenorPeriod(){return this->tenorPeriodIsNull_;}
       boost::shared_ptr<Period> getTenorPeriod();
      std::string getTenorPeriodIDRef(){return tenorPeriodIDRef_;}

       bool isPrincipal(){return this->principalIsNull_;}
       boost::shared_ptr<PositiveMoney> getPrincipal();
      std::string getPrincipalIDRef(){return principalIDRef_;}

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getFixedRate();
      std::string getFixedRateIDRef(){return fixedRateIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

       bool isFeatures(){return this->featuresIsNull_;}
       boost::shared_ptr<TermDepositFeatures> getFeatures();
      std::string getFeaturesIDRef(){return featuresIDRef_;}

       bool isInterest(){return this->interestIsNull_;}
       boost::shared_ptr<Money> getInterest();
      std::string getInterestIDRef(){return interestIDRef_;}

       bool isPayment(){return this->paymentIsNull_;}
       std::vector<boost::shared_ptr<Payment>> getPayment();
      std::string getPaymentIDRef(){return paymentIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!tenorNameIsNull_){
                count += 1;
                str = "tenorName" ;
           }
           if(!tenorPeriodIsNull_){
                count += 1;
                str = "tenorPeriod" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<PartyReference> payerPartyReference_;
       std::string payerPartyReferenceIDRef_;
       bool payerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> payerAccountReference_;
       std::string payerAccountReferenceIDRef_;
       bool payerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> receiverPartyReference_;
       std::string receiverPartyReferenceIDRef_;
       bool receiverPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> receiverAccountReference_;
       std::string receiverAccountReferenceIDRef_;
       bool receiverAccountReferenceIsNull_;
       boost::shared_ptr<XsdTypeDate> startDate_;
       std::string startDateIDRef_;
       bool startDateIsNull_;
       boost::shared_ptr<XsdTypeDate> maturityDate_;
       std::string maturityDateIDRef_;
       bool maturityDateIsNull_;
         boost::shared_ptr<XsdTypeBoolean> tenorName_;     //choice
       std::string tenorNameIDRef_;
       bool tenorNameIsNull_;
         boost::shared_ptr<Period> tenorPeriod_;     //choice
       std::string tenorPeriodIDRef_;
       bool tenorPeriodIsNull_;
       boost::shared_ptr<PositiveMoney> principal_;
       std::string principalIDRef_;
       bool principalIsNull_;
       boost::shared_ptr<PositiveDecimal> fixedRate_;
       std::string fixedRateIDRef_;
       bool fixedRateIsNull_;
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;
       boost::shared_ptr<TermDepositFeatures> features_;
       std::string featuresIDRef_;
       bool featuresIsNull_;
       boost::shared_ptr<Money> interest_;
       std::string interestIDRef_;
       bool interestIsNull_;
       std::vector<boost::shared_ptr<Payment>> payment_;
       std::string paymentIDRef_;
       bool paymentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

