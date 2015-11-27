// MaturityNotification.hpp 
#ifndef FpmlSerialized_MaturityNotification_hpp
#define FpmlSerialized_MaturityNotification_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class MaturityNotification : public ISerialized { 
   public: 
       MaturityNotification(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

