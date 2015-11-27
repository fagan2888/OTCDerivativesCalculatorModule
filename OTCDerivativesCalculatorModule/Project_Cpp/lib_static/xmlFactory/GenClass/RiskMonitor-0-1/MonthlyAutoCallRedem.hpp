// MonthlyAutoCallRedem.hpp 
#ifndef FpmlSerialized_MonthlyAutoCallRedem_hpp
#define FpmlSerialized_MonthlyAutoCallRedem_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTrigger.hpp>

namespace FpmlSerialized {

class MonthlyAutoCallRedem : public ISerialized { 
   public: 
       MonthlyAutoCallRedem(TiXmlNode* xmlNode);

       bool isEventTrigger(){return this->eventTriggerIsNull_;}
       std::vector<boost::shared_ptr<EventTrigger>> getEventTrigger();


   protected: 
       std::vector<boost::shared_ptr<EventTrigger>> eventTrigger_;
       
       bool eventTriggerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

