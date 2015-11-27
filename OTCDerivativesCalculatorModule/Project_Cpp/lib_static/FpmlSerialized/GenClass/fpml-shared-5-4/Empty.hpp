// Empty.hpp 
#ifndef FpmlSerialized_Empty_hpp
#define FpmlSerialized_Empty_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Empty : public ISerialized { 
   public: 
       Empty(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

