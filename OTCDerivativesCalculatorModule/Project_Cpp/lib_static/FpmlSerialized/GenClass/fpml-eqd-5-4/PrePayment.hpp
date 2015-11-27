// PrePayment.hpp 
#ifndef FpmlSerialized_PrePayment_hpp
#define FpmlSerialized_PrePayment_hpp

#include <fpml-shared-5-4/PaymentBase.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>

namespace FpmlSerialized {

class PrePayment : public PaymentBase { 
   public: 
       PrePayment(TiXmlNode* xmlNode);

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

       bool isPrePayment(){return this->prePaymentIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPrePayment();
      std::string getPrePaymentIDRef(){return prePaymentIDRef_;}

       bool isPrePaymentAmount(){return this->prePaymentAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPrePaymentAmount();
      std::string getPrePaymentAmountIDRef(){return prePaymentAmountIDRef_;}

       bool isPrePaymentDate(){return this->prePaymentDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getPrePaymentDate();
      std::string getPrePaymentDateIDRef(){return prePaymentDateIDRef_;}

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
       boost::shared_ptr<XsdTypeBoolean> prePayment_;
       std::string prePaymentIDRef_;
       bool prePaymentIsNull_;
       boost::shared_ptr<NonNegativeMoney> prePaymentAmount_;
       std::string prePaymentAmountIDRef_;
       bool prePaymentAmountIsNull_;
       boost::shared_ptr<AdjustableDate> prePaymentDate_;
       std::string prePaymentDateIDRef_;
       bool prePaymentDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

