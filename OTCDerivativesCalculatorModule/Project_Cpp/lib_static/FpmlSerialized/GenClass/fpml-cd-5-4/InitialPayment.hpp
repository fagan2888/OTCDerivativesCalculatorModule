// InitialPayment.hpp 
#ifndef FpmlSerialized_InitialPayment_hpp
#define FpmlSerialized_InitialPayment_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class InitialPayment : public PaymentBase { 
   public: 
       InitialPayment(TiXmlNode* xmlNode);

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

       bool isAdjustablePaymentDate(){return this->adjustablePaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustablePaymentDate();
      std::string getAdjustablePaymentDateIDRef(){return adjustablePaymentDateIDRef_;}

       bool isAdjustedPaymentDate(){return this->adjustedPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedPaymentDate();
      std::string getAdjustedPaymentDateIDRef(){return adjustedPaymentDateIDRef_;}

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<Money> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

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
       boost::shared_ptr<XsdTypeDate> adjustablePaymentDate_;
       std::string adjustablePaymentDateIDRef_;
       bool adjustablePaymentDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedPaymentDate_;
       std::string adjustedPaymentDateIDRef_;
       bool adjustedPaymentDateIsNull_;
       boost::shared_ptr<Money> paymentAmount_;
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

