// ForwardRateCurve.hpp 
#ifndef FpmlSerialized_ForwardRateCurve_hpp
#define FpmlSerialized_ForwardRateCurve_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/AssetReference.hpp>
#include <fpml-mktenv-5-4/TermCurve.hpp>

namespace FpmlSerialized {

class ForwardRateCurve : public ISerialized { 
   public: 
       ForwardRateCurve(TiXmlNode* xmlNode);

       bool isAssetReference(){return this->assetReferenceIsNull_;}
       boost::shared_ptr<AssetReference> getAssetReference();
      std::string getAssetReferenceIDRef(){return assetReferenceIDRef_;}

       bool isRateCurve(){return this->rateCurveIsNull_;}
       boost::shared_ptr<TermCurve> getRateCurve();
      std::string getRateCurveIDRef(){return rateCurveIDRef_;}

   protected: 
       boost::shared_ptr<AssetReference> assetReference_;
       std::string assetReferenceIDRef_;
       bool assetReferenceIsNull_;
       boost::shared_ptr<TermCurve> rateCurve_;
       std::string rateCurveIDRef_;
       bool rateCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

