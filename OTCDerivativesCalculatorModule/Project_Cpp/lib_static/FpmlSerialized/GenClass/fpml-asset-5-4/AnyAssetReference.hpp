// AnyAssetReference.hpp 
#ifndef FpmlSerialized_AnyAssetReference_hpp
#define FpmlSerialized_AnyAssetReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class AnyAssetReference : public Reference { 
   public: 
       AnyAssetReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

