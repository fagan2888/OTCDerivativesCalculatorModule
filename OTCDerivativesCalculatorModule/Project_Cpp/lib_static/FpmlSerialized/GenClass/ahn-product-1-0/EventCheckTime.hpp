// EventCheckTime.hpp 
#ifndef FpmlSerialized_EventCheckTime_hpp
#define FpmlSerialized_EventCheckTime_hpp

#include <ahn-product-1-0/EventCheckBase.hpp>
#include <ahn-product-1-0/EventDates.hpp>
#include <ahn-product-1-0/JointTimeEvent.hpp>

namespace FpmlSerialized {

class EventCheckTime : public EventCheckBase { 
   public: 
       EventCheckTime(TiXmlNode* xmlNode);

       bool isEventDates(){return this->eventDatesIsNull_;}
       boost::shared_ptr<EventDates> getEventDates();
      std::string getEventDatesIDRef(){return eventDatesIDRef_;}

       bool isJointTimeEvent(){return this->jointTimeEventIsNull_;}
       boost::shared_ptr<JointTimeEvent> getJointTimeEvent();
      std::string getJointTimeEventIDRef(){return jointTimeEventIDRef_;}

   protected: 
       boost::shared_ptr<EventDates> eventDates_;
       std::string eventDatesIDRef_;
       bool eventDatesIsNull_;
       boost::shared_ptr<JointTimeEvent> jointTimeEvent_;
       std::string jointTimeEventIDRef_;
       bool jointTimeEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

