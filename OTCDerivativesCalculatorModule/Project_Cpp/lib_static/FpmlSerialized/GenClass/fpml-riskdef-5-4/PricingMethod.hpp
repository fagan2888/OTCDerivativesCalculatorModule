// PricingMethod.hpp 
#ifndef FpmlSerialized_PricingMethod_hpp
#define FpmlSerialized_PricingMethod_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/AnyAssetReference.hpp>
#include <fpml-shared-5-4/PricingStructureReference.hpp>

namespace FpmlSerialized {

class PricingMethod : public ISerialized { 
   public: 
       PricingMethod(TiXmlNode* xmlNode);

       bool isAssetReference(){return this->assetReferenceIsNull_;}
       boost::shared_ptr<AnyAssetReference> getAssetReference();
      std::string getAssetReferenceIDRef(){return assetReferenceIDRef_;}

       bool isPricingInputReference(){return this->pricingInputReferenceIsNull_;}
       boost::shared_ptr<PricingStructureReference> getPricingInputReference();
      std::string getPricingInputReferenceIDRef(){return pricingInputReferenceIDRef_;}

   protected: 
       boost::shared_ptr<AnyAssetReference> assetReference_;
       std::string assetReferenceIDRef_;
       bool assetReferenceIsNull_;
       boost::shared_ptr<PricingStructureReference> pricingInputReference_;
       std::string pricingInputReferenceIDRef_;
       bool pricingInputReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

