// PrincipalExchangeDescriptions.hpp 
#ifndef FpmlSerialized_PrincipalExchangeDescriptions_hpp
#define FpmlSerialized_PrincipalExchangeDescriptions_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-eq-shared-5-4/PrincipalExchangeAmount.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class PrincipalExchangeDescriptions : public ISerialized { 
   public: 
       PrincipalExchangeDescriptions(TiXmlNode* xmlNode);

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

       bool isPrincipalExchangeAmount(){return this->principalExchangeAmountIsNull_;}
       boost::shared_ptr<PrincipalExchangeAmount> getPrincipalExchangeAmount();
      std::string getPrincipalExchangeAmountIDRef(){return principalExchangeAmountIDRef_;}

       bool isPrincipalExchangeDate(){return this->principalExchangeDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getPrincipalExchangeDate();
      std::string getPrincipalExchangeDateIDRef(){return principalExchangeDateIDRef_;}

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
       boost::shared_ptr<PrincipalExchangeAmount> principalExchangeAmount_;
       std::string principalExchangeAmountIDRef_;
       bool principalExchangeAmountIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> principalExchangeDate_;
       std::string principalExchangeDateIDRef_;
       bool principalExchangeDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

