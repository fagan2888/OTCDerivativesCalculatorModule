// VerificationStatusNotification.hpp 
#ifndef FpmlSerialized_VerificationStatusNotification_hpp
#define FpmlSerialized_VerificationStatusNotification_hpp

#include <fpml-msg-5-4/NonCorrectableRequestMessage.hpp>
#include <fpml-msg-5-4/VerificationStatus.hpp>
#include <fpml-msg-5-4/Reason.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class VerificationStatusNotification : public NonCorrectableRequestMessage { 
   public: 
       VerificationStatusNotification(TiXmlNode* xmlNode);

       bool isStatus(){return this->statusIsNull_;}
       boost::shared_ptr<VerificationStatus> getStatus();
      std::string getStatusIDRef(){return statusIDRef_;}

       bool isReason(){return this->reasonIsNull_;}
       std::vector<boost::shared_ptr<Reason>> getReason();
      std::string getReasonIDRef(){return reasonIDRef_;}

       bool isPartyTradeIdentifier(){return this->partyTradeIdentifierIsNull_;}
       boost::shared_ptr<PartyTradeIdentifier> getPartyTradeIdentifier();
      std::string getPartyTradeIdentifierIDRef(){return partyTradeIdentifierIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       boost::shared_ptr<VerificationStatus> status_;
       std::string statusIDRef_;
       bool statusIsNull_;
       std::vector<boost::shared_ptr<Reason>> reason_;
       std::string reasonIDRef_;
       bool reasonIsNull_;
       boost::shared_ptr<PartyTradeIdentifier> partyTradeIdentifier_;
       std::string partyTradeIdentifierIDRef_;
       bool partyTradeIdentifierIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

