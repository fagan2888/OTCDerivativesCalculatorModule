// ObligationAccelerationEvent.hpp 
#ifndef FpmlSerialized_ObligationAccelerationEvent_hpp
#define FpmlSerialized_ObligationAccelerationEvent_hpp

#include <fpml-credit-event-notification-5-4/CreditEvent.hpp>

namespace FpmlSerialized {

class ObligationAccelerationEvent : public CreditEvent { 
   public: 
       ObligationAccelerationEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

