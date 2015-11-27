// EventTriggerList_A.hpp 
#ifndef FpmlSerialized_EventTriggerList_A_hpp
#define FpmlSerialized_EventTriggerList_A_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTrigger_A.hpp>

namespace FpmlSerialized {

class EventTriggerList_A : public ISerialized { 
   public: 
       EventTriggerList_A(TiXmlNode* xmlNode);

       bool isEventTrigger_A(){return this->eventTrigger_AIsNull_;}
       std::vector<boost::shared_ptr<EventTrigger_A>> getEventTrigger_A();


   protected: 
       std::vector<boost::shared_ptr<EventTrigger_A>> eventTrigger_A_;
       
       bool eventTrigger_AIsNull_;

};

} //namespaceFpmlSerialized end
#endif

