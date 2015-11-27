// NonKiEventInfo.hpp 
#ifndef FpmlSerialized_NonKiEventInfo_hpp
#define FpmlSerialized_NonKiEventInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTrigger.hpp>

namespace FpmlSerialized {

class NonKiEventInfo : public ISerialized { 
   public: 
       NonKiEventInfo(TiXmlNode* xmlNode);

       bool isEventTrigger(){return this->eventTriggerIsNull_;}
       boost::shared_ptr<EventTrigger> getEventTrigger();


   protected: 
       boost::shared_ptr<EventTrigger> eventTrigger_;
       
       bool eventTriggerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

