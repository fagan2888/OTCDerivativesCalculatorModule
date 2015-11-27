// AssetReference.hpp 
#ifndef FpmlSerialized_AssetReference_hpp
#define FpmlSerialized_AssetReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class AssetReference : public Reference { 
   public: 
       AssetReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

