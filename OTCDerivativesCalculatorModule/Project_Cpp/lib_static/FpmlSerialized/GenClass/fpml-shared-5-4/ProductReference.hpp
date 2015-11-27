// ProductReference.hpp 
#ifndef FpmlSerialized_ProductReference_hpp
#define FpmlSerialized_ProductReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class ProductReference : public Reference { 
   public: 
       ProductReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

