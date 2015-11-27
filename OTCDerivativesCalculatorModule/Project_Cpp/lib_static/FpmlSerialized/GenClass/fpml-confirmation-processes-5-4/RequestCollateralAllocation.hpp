// RequestCollateralAllocation.hpp 
#ifndef FpmlSerialized_RequestCollateralAllocation_hpp
#define FpmlSerialized_RequestCollateralAllocation_hpp

#include <fpml-msg-5-4/CorrectableRequestMessage.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/ProposedCollateralAllocation.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class RequestCollateralAllocation : public CorrectableRequestMessage { 
   public: 
       RequestCollateralAllocation(TiXmlNode* xmlNode);

       bool isServiceName(){return this->serviceNameIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getServiceName();
      std::string getServiceNameIDRef(){return serviceNameIDRef_;}

       bool isCollateralGiverPartyReference(){return this->collateralGiverPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getCollateralGiverPartyReference();
      std::string getCollateralGiverPartyReferenceIDRef(){return collateralGiverPartyReferenceIDRef_;}

       bool isCollateralAllocation(){return this->collateralAllocationIsNull_;}
       std::vector<boost::shared_ptr<ProposedCollateralAllocation>> getCollateralAllocation();
      std::string getCollateralAllocationIDRef(){return collateralAllocationIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeNormalizedString> serviceName_;
       std::string serviceNameIDRef_;
       bool serviceNameIsNull_;
       boost::shared_ptr<PartyReference> collateralGiverPartyReference_;
       std::string collateralGiverPartyReferenceIDRef_;
       bool collateralGiverPartyReferenceIsNull_;
       std::vector<boost::shared_ptr<ProposedCollateralAllocation>> collateralAllocation_;
       std::string collateralAllocationIDRef_;
       bool collateralAllocationIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

