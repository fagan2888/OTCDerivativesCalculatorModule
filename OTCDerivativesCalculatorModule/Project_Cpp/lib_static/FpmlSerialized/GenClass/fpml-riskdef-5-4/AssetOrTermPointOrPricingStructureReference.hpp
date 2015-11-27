// AssetOrTermPointOrPricingStructureReference.hpp 
#ifndef FpmlSerialized_AssetOrTermPointOrPricingStructureReference_hpp
#define FpmlSerialized_AssetOrTermPointOrPricingStructureReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class AssetOrTermPointOrPricingStructureReference : public Reference { 
   public: 
       AssetOrTermPointOrPricingStructureReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

