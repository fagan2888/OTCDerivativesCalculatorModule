// FxSwap.hpp 
#ifndef FpmlSerialized_FxSwap_hpp
#define FpmlSerialized_FxSwap_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-fx-5-4/FxSwapLeg.hpp>

namespace FpmlSerialized {

class FxSwap : public Product { 
   public: 
       FxSwap(TiXmlNode* xmlNode);

       bool isNearLeg(){return this->nearLegIsNull_;}
       boost::shared_ptr<FxSwapLeg> getNearLeg();
      std::string getNearLegIDRef(){return nearLegIDRef_;}

       bool isFarLeg(){return this->farLegIsNull_;}
       boost::shared_ptr<FxSwapLeg> getFarLeg();
      std::string getFarLegIDRef(){return farLegIDRef_;}

   protected: 
       boost::shared_ptr<FxSwapLeg> nearLeg_;
       std::string nearLegIDRef_;
       bool nearLegIsNull_;
       boost::shared_ptr<FxSwapLeg> farLeg_;
       std::string farLegIDRef_;
       bool farLegIsNull_;

};

} //namespaceFpmlSerialized end
#endif

