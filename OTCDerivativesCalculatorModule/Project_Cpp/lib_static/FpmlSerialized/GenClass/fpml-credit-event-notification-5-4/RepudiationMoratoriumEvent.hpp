// RepudiationMoratoriumEvent.hpp 
#ifndef FpmlSerialized_RepudiationMoratoriumEvent_hpp
#define FpmlSerialized_RepudiationMoratoriumEvent_hpp

#include <fpml-credit-event-notification-5-4/CreditEvent.hpp>

namespace FpmlSerialized {

class RepudiationMoratoriumEvent : public CreditEvent { 
   public: 
       RepudiationMoratoriumEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

