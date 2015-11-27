// Payment.hpp 
#ifndef FpmlSerialized_Payment_hpp
#define FpmlSerialized_Payment_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/AdjustableOrAdjustedDate.hpp>
#include <fpml-shared-5-4/PaymentType.hpp>
#include <fpml-shared-5-4/SettlementInformation.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class Payment : public PaymentBase { 
   public: 
       Payment(TiXmlNode* xmlNode);

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

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<AdjustableOrAdjustedDate> getPaymentDate();
      std::string getPaymentDateIDRef(){return paymentDateIDRef_;}

       bool isPaymentType(){return this->paymentTypeIsNull_;}
       boost::shared_ptr<PaymentType> getPaymentType();
      std::string getPaymentTypeIDRef(){return paymentTypeIDRef_;}

       bool isSettlementInformation(){return this->settlementInformationIsNull_;}
       boost::shared_ptr<SettlementInformation> getSettlementInformation();
      std::string getSettlementInformationIDRef(){return settlementInformationIDRef_;}

       bool isDiscountFactor(){return this->discountFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getDiscountFactor();
      std::string getDiscountFactorIDRef(){return discountFactorIDRef_;}

       bool isPresentValueAmount(){return this->presentValueAmountIsNull_;}
       boost::shared_ptr<Money> getPresentValueAmount();
      std::string getPresentValueAmountIDRef(){return presentValueAmountIDRef_;}

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
       boost::shared_ptr<NonNegativeMoney> paymentAmount_;
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;
       boost::shared_ptr<AdjustableOrAdjustedDate> paymentDate_;
       std::string paymentDateIDRef_;
       bool paymentDateIsNull_;
       boost::shared_ptr<PaymentType> paymentType_;
       std::string paymentTypeIDRef_;
       bool paymentTypeIsNull_;
       boost::shared_ptr<SettlementInformation> settlementInformation_;
       std::string settlementInformationIDRef_;
       bool settlementInformationIsNull_;
       boost::shared_ptr<XsdTypeDecimal> discountFactor_;
       std::string discountFactorIDRef_;
       bool discountFactorIsNull_;
       boost::shared_ptr<Money> presentValueAmount_;
       std::string presentValueAmountIDRef_;
       bool presentValueAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

