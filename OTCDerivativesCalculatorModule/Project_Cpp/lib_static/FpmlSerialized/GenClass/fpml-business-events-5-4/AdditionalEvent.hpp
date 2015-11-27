// AdditionalEvent.hpp 
#ifndef FpmlSerialized_AdditionalEvent_hpp
#define FpmlSerialized_AdditionalEvent_hpp

#include <fpml-business-events-5-4/AbstractEvent.hpp>

namespace FpmlSerialized {

class AdditionalEvent : public AbstractEvent { 
   public: 
       AdditionalEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

