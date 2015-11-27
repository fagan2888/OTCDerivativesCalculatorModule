// EventStatusItem.hpp 
#ifndef FpmlSerialized_EventStatusItem_hpp
#define FpmlSerialized_EventStatusItem_hpp

#include <ISerialized.hpp>
#include <fpml-msg-5-4/EventIdentifier.hpp>
#include <fpml-msg-5-4/EventStatus.hpp>

namespace FpmlSerialized {

class EventStatusItem : public ISerialized { 
   public: 
       EventStatusItem(TiXmlNode* xmlNode);

       bool isEventIdentifier(){return this->eventIdentifierIsNull_;}
       boost::shared_ptr<EventIdentifier> getEventIdentifier();
      std::string getEventIdentifierIDRef(){return eventIdentifierIDRef_;}

       bool isStatus(){return this->statusIsNull_;}
       boost::shared_ptr<EventStatus> getStatus();
      std::string getStatusIDRef(){return statusIDRef_;}

   protected: 
       boost::shared_ptr<EventIdentifier> eventIdentifier_;
       std::string eventIdentifierIDRef_;
       bool eventIdentifierIsNull_;
       boost::shared_ptr<EventStatus> status_;
       std::string statusIDRef_;
       bool statusIsNull_;

};

} //namespaceFpmlSerialized end
#endif

