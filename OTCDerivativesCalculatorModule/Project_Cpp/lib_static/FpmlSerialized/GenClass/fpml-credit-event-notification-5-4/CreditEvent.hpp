// CreditEvent.hpp 
#ifndef FpmlSerialized_CreditEvent_hpp
#define FpmlSerialized_CreditEvent_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class CreditEvent : public ISerialized { 
   public: 
       CreditEvent(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

