// AutoCallablePayoff.hpp 
#ifndef FpmlSerialized_AutoCallablePayoff_hpp
#define FpmlSerialized_AutoCallablePayoff_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTriggerList.hpp>

namespace FpmlSerialized {

class AutoCallablePayoff : public ISerialized { 
   public: 
       AutoCallablePayoff(TiXmlNode* xmlNode);

       bool isEventTriggerList(){return this->eventTriggerListIsNull_;}
       boost::shared_ptr<EventTriggerList> getEventTriggerList();


   protected: 
       boost::shared_ptr<EventTriggerList> eventTriggerList_;
       
       bool eventTriggerListIsNull_;

};

} //namespaceFpmlSerialized end
#endif

