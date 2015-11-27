// Routing.hpp 
#ifndef FpmlSerialized_Routing_hpp
#define FpmlSerialized_Routing_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Routing : public ISerialized { 
   public: 
       Routing(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

