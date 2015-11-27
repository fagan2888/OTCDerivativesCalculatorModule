// AutoCallRedem.hpp 
#ifndef FpmlSerialized_AutoCallRedem_hpp
#define FpmlSerialized_AutoCallRedem_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTrigger.hpp>

namespace FpmlSerialized {

class AutoCallRedem : public ISerialized { 
   public: 
       AutoCallRedem(TiXmlNode* xmlNode);

       bool isEventTrigger(){return this->eventTriggerIsNull_;}
       std::vector<boost::shared_ptr<EventTrigger>> getEventTrigger();


   protected: 
       std::vector<boost::shared_ptr<EventTrigger>> eventTrigger_;
       
       bool eventTriggerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

