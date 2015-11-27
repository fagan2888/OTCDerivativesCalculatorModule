// ObligationDefaultEvent.hpp 
#ifndef FpmlSerialized_ObligationDefaultEvent_hpp
#define FpmlSerialized_ObligationDefaultEvent_hpp

#include <fpml-credit-event-notification-5-4/CreditEvent.hpp>

namespace FpmlSerialized {

class ObligationDefaultEvent : public CreditEvent { 
   public: 
       ObligationDefaultEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

