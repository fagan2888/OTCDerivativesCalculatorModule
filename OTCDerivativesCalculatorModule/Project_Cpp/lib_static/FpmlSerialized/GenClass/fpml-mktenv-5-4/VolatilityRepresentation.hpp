// VolatilityRepresentation.hpp 
#ifndef FpmlSerialized_VolatilityRepresentation_hpp
#define FpmlSerialized_VolatilityRepresentation_hpp

#include <fpml-shared-5-4/PricingStructure.hpp>
#include <fpml-asset-5-4/AnyAssetReference.hpp>

namespace FpmlSerialized {

class VolatilityRepresentation : public PricingStructure { 
   public: 
       VolatilityRepresentation(TiXmlNode* xmlNode);

       bool isAsset(){return this->assetIsNull_;}
       boost::shared_ptr<AnyAssetReference> getAsset();
      std::string getAssetIDRef(){return assetIDRef_;}

   protected: 
       boost::shared_ptr<AnyAssetReference> asset_;
       std::string assetIDRef_;
       bool assetIsNull_;

};

} //namespaceFpmlSerialized end
#endif

