// StepDownNoKIPayoff.hpp 
#ifndef FpmlSerialized_StepDownNoKIPayoff_hpp
#define FpmlSerialized_StepDownNoKIPayoff_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTriggerList.hpp>
#include <RiskMonitor-0-1/NoAutoCallReturnTrigger.hpp>

namespace FpmlSerialized {

class StepDownNoKIPayoff : public ISerialized { 
   public: 
       StepDownNoKIPayoff(TiXmlNode* xmlNode);

       bool isEventTriggerList(){return this->eventTriggerListIsNull_;}
       boost::shared_ptr<EventTriggerList> getEventTriggerList();


       bool isNoAutoCallReturnTrigger(){return this->noAutoCallReturnTriggerIsNull_;}
       boost::shared_ptr<NoAutoCallReturnTrigger> getNoAutoCallReturnTrigger();


   protected: 
       boost::shared_ptr<EventTriggerList> eventTriggerList_;
       
       bool eventTriggerListIsNull_;
       boost::shared_ptr<NoAutoCallReturnTrigger> noAutoCallReturnTrigger_;
       
       bool noAutoCallReturnTriggerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

