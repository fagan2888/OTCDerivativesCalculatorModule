// AllocationApproved.hpp 
#ifndef FpmlSerialized_AllocationApproved_hpp
#define FpmlSerialized_AllocationApproved_hpp

#include <fpml-msg-5-4/ResponseMessage.hpp>
#include <fpml-doc-5-4/TradeIdentifier.hpp>
#include <fpml-doc-5-4/Allocations.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class AllocationApproved : public ResponseMessage { 
   public: 
       AllocationApproved(TiXmlNode* xmlNode);

       bool isBlockTradeIdentifier(){return this->blockTradeIdentifierIsNull_;}
       boost::shared_ptr<TradeIdentifier> getBlockTradeIdentifier();
      std::string getBlockTradeIdentifierIDRef(){return blockTradeIdentifierIDRef_;}

       bool isAllocations(){return this->allocationsIsNull_;}
       boost::shared_ptr<Allocations> getAllocations();
      std::string getAllocationsIDRef(){return allocationsIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       boost::shared_ptr<TradeIdentifier> blockTradeIdentifier_;
       std::string blockTradeIdentifierIDRef_;
       bool blockTradeIdentifierIsNull_;
       boost::shared_ptr<Allocations> allocations_;
       std::string allocationsIDRef_;
       bool allocationsIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

