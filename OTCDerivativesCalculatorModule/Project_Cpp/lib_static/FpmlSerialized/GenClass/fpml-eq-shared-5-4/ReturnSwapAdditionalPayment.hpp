// ReturnSwapAdditionalPayment.hpp 
#ifndef FpmlSerialized_ReturnSwapAdditionalPayment_hpp
#define FpmlSerialized_ReturnSwapAdditionalPayment_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-eq-shared-5-4/AdditionalPaymentAmount.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/PaymentType.hpp>

namespace FpmlSerialized {

class ReturnSwapAdditionalPayment : public PaymentBase { 
   public: 
       ReturnSwapAdditionalPayment(TiXmlNode* xmlNode);

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

       bool isAdditionalPaymentAmount(){return this->additionalPaymentAmountIsNull_;}
       boost::shared_ptr<AdditionalPaymentAmount> getAdditionalPaymentAmount();
      std::string getAdditionalPaymentAmountIDRef(){return additionalPaymentAmountIDRef_;}

       bool isAdditionalPaymentDate(){return this->additionalPaymentDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getAdditionalPaymentDate();
      std::string getAdditionalPaymentDateIDRef(){return additionalPaymentDateIDRef_;}

       bool isPaymentType(){return this->paymentTypeIsNull_;}
       boost::shared_ptr<PaymentType> getPaymentType();
      std::string getPaymentTypeIDRef(){return paymentTypeIDRef_;}

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
       boost::shared_ptr<AdditionalPaymentAmount> additionalPaymentAmount_;
       std::string additionalPaymentAmountIDRef_;
       bool additionalPaymentAmountIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> additionalPaymentDate_;
       std::string additionalPaymentDateIDRef_;
       bool additionalPaymentDateIsNull_;
       boost::shared_ptr<PaymentType> paymentType_;
       std::string paymentTypeIDRef_;
       bool paymentTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

