// BusinessEventIdentifier.hpp 
#ifndef FpmlSerialized_BusinessEventIdentifier_hpp
#define FpmlSerialized_BusinessEventIdentifier_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-business-events-5-4/EventId.hpp>

namespace FpmlSerialized {

class BusinessEventIdentifier : public ISerialized { 
   public: 
       BusinessEventIdentifier(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isAccountReference(){return this->accountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getAccountReference();
      std::string getAccountReferenceIDRef(){return accountReferenceIDRef_;}

       bool isEventId(){return this->eventIdIsNull_;}
       boost::shared_ptr<EventId> getEventId();
      std::string getEventIdIDRef(){return eventIdIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       boost::shared_ptr<AccountReference> accountReference_;
       std::string accountReferenceIDRef_;
       bool accountReferenceIsNull_;
       boost::shared_ptr<EventId> eventId_;
       std::string eventIdIDRef_;
       bool eventIdIsNull_;

};

} //namespaceFpmlSerialized end
#endif

