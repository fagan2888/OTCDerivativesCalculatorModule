// MarketDisruptionEvent.hpp 
#ifndef FpmlSerialized_MarketDisruptionEvent_hpp
#define FpmlSerialized_MarketDisruptionEvent_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class MarketDisruptionEvent : public Scheme { 
   public: 
       MarketDisruptionEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

