// PassThroughItem.hpp 
#ifndef FpmlSerialized_PassThroughItem_hpp
#define FpmlSerialized_PassThroughItem_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-asset-5-4/AssetReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class PassThroughItem : public ISerialized { 
   public: 
       PassThroughItem(TiXmlNode* xmlNode);

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

       bool isUnderlyerReference(){return this->underlyerReferenceIsNull_;}
       boost::shared_ptr<AssetReference> getUnderlyerReference();
      std::string getUnderlyerReferenceIDRef(){return underlyerReferenceIDRef_;}

       bool isPassThroughPercentage(){return this->passThroughPercentageIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPassThroughPercentage();
      std::string getPassThroughPercentageIDRef(){return passThroughPercentageIDRef_;}

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
       boost::shared_ptr<AssetReference> underlyerReference_;
       std::string underlyerReferenceIDRef_;
       bool underlyerReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> passThroughPercentage_;
       std::string passThroughPercentageIDRef_;
       bool passThroughPercentageIsNull_;

};

} //namespaceFpmlSerialized end
#endif

