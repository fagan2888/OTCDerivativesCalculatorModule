// StructuredSwap.hpp 
#ifndef FpmlSerialized_StructuredSwap_hpp
#define FpmlSerialized_StructuredSwap_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class StructuredSwap : public ISerialized { 
   public: 
       StructuredSwap(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

