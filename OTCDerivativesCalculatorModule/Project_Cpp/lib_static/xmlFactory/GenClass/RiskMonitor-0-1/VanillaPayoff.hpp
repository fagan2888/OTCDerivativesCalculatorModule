// VanillaPayoff.hpp 
#ifndef FpmlSerialized_VanillaPayoff_hpp
#define FpmlSerialized_VanillaPayoff_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class VanillaPayoff : public ISerialized { 
   public: 
       VanillaPayoff(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

