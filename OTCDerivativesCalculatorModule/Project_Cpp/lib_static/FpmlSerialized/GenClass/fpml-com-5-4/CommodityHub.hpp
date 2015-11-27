// CommodityHub.hpp 
#ifndef FpmlSerialized_CommodityHub_hpp
#define FpmlSerialized_CommodityHub_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-com-5-4/CommodityHubCode.hpp>

namespace FpmlSerialized {

class CommodityHub : public ISerialized { 
   public: 
       CommodityHub(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isAccountReference(){return this->accountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getAccountReference();
      std::string getAccountReferenceIDRef(){return accountReferenceIDRef_;}

       bool isHubCode(){return this->hubCodeIsNull_;}
       boost::shared_ptr<CommodityHubCode> getHubCode();
      std::string getHubCodeIDRef(){return hubCodeIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       boost::shared_ptr<AccountReference> accountReference_;
       std::string accountReferenceIDRef_;
       bool accountReferenceIsNull_;
       boost::shared_ptr<CommodityHubCode> hubCode_;
       std::string hubCodeIDRef_;
       bool hubCodeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

