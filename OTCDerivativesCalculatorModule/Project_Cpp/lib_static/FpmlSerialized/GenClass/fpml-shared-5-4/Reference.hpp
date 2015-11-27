// Reference.hpp 
#ifndef FpmlSerialized_Reference_hpp
#define FpmlSerialized_Reference_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Reference : public ISerialized { 
   public: 
       Reference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

