// StandardPayoff_A.hpp 
#ifndef FpmlSerialized_StandardPayoff_A_hpp
#define FpmlSerialized_StandardPayoff_A_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTriggerList_A.hpp>

namespace FpmlSerialized {

class StandardPayoff_A : public ISerialized { 
   public: 
       StandardPayoff_A(TiXmlNode* xmlNode);

       bool isEventTriggerList_A(){return this->eventTriggerList_AIsNull_;}
       boost::shared_ptr<EventTriggerList_A> getEventTriggerList_A();


   protected: 
       boost::shared_ptr<EventTriggerList_A> eventTriggerList_A_;
       
       bool eventTriggerList_AIsNull_;

};

} //namespaceFpmlSerialized end
#endif

