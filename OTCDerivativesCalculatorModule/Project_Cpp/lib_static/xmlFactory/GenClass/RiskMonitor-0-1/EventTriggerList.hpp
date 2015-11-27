// EventTriggerList.hpp 
#ifndef FpmlSerialized_EventTriggerList_hpp
#define FpmlSerialized_EventTriggerList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTrigger.hpp>

namespace FpmlSerialized {

class EventTriggerList : public ISerialized { 
   public: 
       EventTriggerList(TiXmlNode* xmlNode);

       bool isEventTrigger(){return this->eventTriggerIsNull_;}
       std::vector<boost::shared_ptr<EventTrigger>> getEventTrigger();


   protected: 
       std::vector<boost::shared_ptr<EventTrigger>> eventTrigger_;
       
       bool eventTriggerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

