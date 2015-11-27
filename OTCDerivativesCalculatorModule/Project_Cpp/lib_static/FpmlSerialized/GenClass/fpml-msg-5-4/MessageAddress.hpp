// MessageAddress.hpp 
#ifndef FpmlSerialized_MessageAddress_hpp
#define FpmlSerialized_MessageAddress_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class MessageAddress : public Scheme { 
   public: 
       MessageAddress(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

