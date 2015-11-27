// RequestEventStatus.hpp 
#ifndef FpmlSerialized_RequestEventStatus_hpp
#define FpmlSerialized_RequestEventStatus_hpp

#include <fpml-msg-5-4/NonCorrectableRequestMessage.hpp>
#include <fpml-msg-5-4/BusinessProcess.hpp>
#include <fpml-msg-5-4/EventIdentifier.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class RequestEventStatus : public NonCorrectableRequestMessage { 
   public: 
       RequestEventStatus(TiXmlNode* xmlNode);

       bool isBusinessProcess(){return this->businessProcessIsNull_;}
       boost::shared_ptr<BusinessProcess> getBusinessProcess();
      std::string getBusinessProcessIDRef(){return businessProcessIDRef_;}

       bool isEventIdentifier(){return this->eventIdentifierIsNull_;}
       boost::shared_ptr<EventIdentifier> getEventIdentifier();
      std::string getEventIdentifierIDRef(){return eventIdentifierIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       boost::shared_ptr<BusinessProcess> businessProcess_;
       std::string businessProcessIDRef_;
       bool businessProcessIsNull_;
       boost::shared_ptr<EventIdentifier> eventIdentifier_;
       std::string eventIdentifierIDRef_;
       bool eventIdentifierIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

