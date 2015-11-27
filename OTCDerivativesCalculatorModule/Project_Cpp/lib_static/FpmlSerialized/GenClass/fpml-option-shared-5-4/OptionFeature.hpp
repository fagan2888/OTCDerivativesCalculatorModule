// OptionFeature.hpp 
#ifndef FpmlSerialized_OptionFeature_hpp
#define FpmlSerialized_OptionFeature_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/FxFeature.hpp>
#include <fpml-option-shared-5-4/StrategyFeature.hpp>
#include <fpml-option-shared-5-4/Asian.hpp>
#include <fpml-option-shared-5-4/Barrier.hpp>
#include <fpml-option-shared-5-4/Knock.hpp>
#include <fpml-option-shared-5-4/PassThrough.hpp>

namespace FpmlSerialized {

class OptionFeature : public ISerialized { 
   public: 
       OptionFeature(TiXmlNode* xmlNode);

       bool isFxFeature(){return this->fxFeatureIsNull_;}
       boost::shared_ptr<FxFeature> getFxFeature();
      std::string getFxFeatureIDRef(){return fxFeatureIDRef_;}

       bool isStrategyFeature(){return this->strategyFeatureIsNull_;}
       boost::shared_ptr<StrategyFeature> getStrategyFeature();
      std::string getStrategyFeatureIDRef(){return strategyFeatureIDRef_;}

       bool isAsian(){return this->asianIsNull_;}
       boost::shared_ptr<Asian> getAsian();
      std::string getAsianIDRef(){return asianIDRef_;}

       bool isBarrier(){return this->barrierIsNull_;}
       boost::shared_ptr<Barrier> getBarrier();
      std::string getBarrierIDRef(){return barrierIDRef_;}

       bool isKnock(){return this->knockIsNull_;}
       boost::shared_ptr<Knock> getKnock();
      std::string getKnockIDRef(){return knockIDRef_;}

       bool isPassThrough(){return this->passThroughIsNull_;}
       boost::shared_ptr<PassThrough> getPassThrough();
      std::string getPassThroughIDRef(){return passThroughIDRef_;}

   protected: 
       boost::shared_ptr<FxFeature> fxFeature_;
       std::string fxFeatureIDRef_;
       bool fxFeatureIsNull_;
       boost::shared_ptr<StrategyFeature> strategyFeature_;
       std::string strategyFeatureIDRef_;
       bool strategyFeatureIsNull_;
       boost::shared_ptr<Asian> asian_;
       std::string asianIDRef_;
       bool asianIsNull_;
       boost::shared_ptr<Barrier> barrier_;
       std::string barrierIDRef_;
       bool barrierIsNull_;
       boost::shared_ptr<Knock> knock_;
       std::string knockIDRef_;
       bool knockIsNull_;
       boost::shared_ptr<PassThrough> passThrough_;
       std::string passThroughIDRef_;
       bool passThroughIsNull_;

};

} //namespaceFpmlSerialized end
#endif

