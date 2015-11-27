// IssuerId.hpp 
#ifndef FpmlSerialized_IssuerId_hpp
#define FpmlSerialized_IssuerId_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class IssuerId : public Scheme { 
   public: 
       IssuerId(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

