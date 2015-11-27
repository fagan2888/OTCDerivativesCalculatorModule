// KiEventInfo.hpp 
#ifndef FpmlSerialized_KiEventInfo_hpp
#define FpmlSerialized_KiEventInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTrigger.hpp>

namespace FpmlSerialized {

class KiEventInfo : public ISerialized { 
   public: 
       KiEventInfo(TiXmlNode* xmlNode);

       bool isEventTrigger(){return this->eventTriggerIsNull_;}
       boost::shared_ptr<EventTrigger> getEventTrigger();


   protected: 
       boost::shared_ptr<EventTrigger> eventTrigger_;
       
       bool eventTriggerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

