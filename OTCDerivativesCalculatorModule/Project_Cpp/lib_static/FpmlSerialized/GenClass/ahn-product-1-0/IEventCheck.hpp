// IEventCheck.hpp 
#ifndef FpmlSerialized_IEventCheck_hpp
#define FpmlSerialized_IEventCheck_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class IEventCheck : public ISerialized { 
   public: 
       IEventCheck(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

