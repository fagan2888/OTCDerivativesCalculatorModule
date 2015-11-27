// NotionalReference.hpp 
#ifndef FpmlSerialized_NotionalReference_hpp
#define FpmlSerialized_NotionalReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class NotionalReference : public Reference { 
   public: 
       NotionalReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

