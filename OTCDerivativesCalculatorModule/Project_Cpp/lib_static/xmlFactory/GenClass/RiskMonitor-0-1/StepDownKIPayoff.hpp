// StepDownKIPayoff.hpp 
#ifndef FpmlSerialized_StepDownKIPayoff_hpp
#define FpmlSerialized_StepDownKIPayoff_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTriggerList.hpp>
#include <RiskMonitor-0-1/KiEventInfo.hpp>
#include <RiskMonitor-0-1/NonKiEventInfo.hpp>

namespace FpmlSerialized {

class StepDownKIPayoff : public ISerialized { 
   public: 
       StepDownKIPayoff(TiXmlNode* xmlNode);

       bool isEventTriggerList(){return this->eventTriggerListIsNull_;}
       boost::shared_ptr<EventTriggerList> getEventTriggerList();


       bool isKiEventInfo(){return this->kiEventInfoIsNull_;}
       boost::shared_ptr<KiEventInfo> getKiEventInfo();


       bool isNonKiEventInfo(){return this->nonKiEventInfoIsNull_;}
       boost::shared_ptr<NonKiEventInfo> getNonKiEventInfo();


   protected: 
       boost::shared_ptr<EventTriggerList> eventTriggerList_;
       
       bool eventTriggerListIsNull_;
       boost::shared_ptr<KiEventInfo> kiEventInfo_;
       
       bool kiEventInfoIsNull_;
       boost::shared_ptr<NonKiEventInfo> nonKiEventInfo_;
       
       bool nonKiEventInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

