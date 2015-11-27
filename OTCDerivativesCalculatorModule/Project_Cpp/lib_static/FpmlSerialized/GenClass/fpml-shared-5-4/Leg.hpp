// Leg.hpp 
#ifndef FpmlSerialized_Leg_hpp
#define FpmlSerialized_Leg_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Leg : public ISerialized { 
   public: 
       Leg(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

