// FailureToPayEvent.hpp 
#ifndef FpmlSerialized_FailureToPayEvent_hpp
#define FpmlSerialized_FailureToPayEvent_hpp

#include <fpml-credit-event-notification-5-4/CreditEvent.hpp>

namespace FpmlSerialized {

class FailureToPayEvent : public CreditEvent { 
   public: 
       FailureToPayEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

