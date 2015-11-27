// YieldCurveValuation.hpp 
#ifndef FpmlSerialized_YieldCurveValuation_hpp
#define FpmlSerialized_YieldCurveValuation_hpp

#include <fpml-riskdef-5-4/PricingStructureValuation.hpp>
#include <fpml-riskdef-5-4/QuotedAssetSet.hpp>
#include <fpml-mktenv-5-4/ZeroRateCurve.hpp>
#include <fpml-mktenv-5-4/ForwardRateCurve.hpp>
#include <fpml-mktenv-5-4/TermCurve.hpp>

namespace FpmlSerialized {

class YieldCurveValuation : public PricingStructureValuation { 
   public: 
       YieldCurveValuation(TiXmlNode* xmlNode);

       bool isInputs(){return this->inputsIsNull_;}
       boost::shared_ptr<QuotedAssetSet> getInputs();
      std::string getInputsIDRef(){return inputsIDRef_;}

       bool isZeroCurve(){return this->zeroCurveIsNull_;}
       boost::shared_ptr<ZeroRateCurve> getZeroCurve();
      std::string getZeroCurveIDRef(){return zeroCurveIDRef_;}

       bool isForwardCurve(){return this->forwardCurveIsNull_;}
       std::vector<boost::shared_ptr<ForwardRateCurve>> getForwardCurve();
      std::string getForwardCurveIDRef(){return forwardCurveIDRef_;}

       bool isDiscountFactorCurve(){return this->discountFactorCurveIsNull_;}
       boost::shared_ptr<TermCurve> getDiscountFactorCurve();
      std::string getDiscountFactorCurveIDRef(){return discountFactorCurveIDRef_;}

   protected: 
       boost::shared_ptr<QuotedAssetSet> inputs_;
       std::string inputsIDRef_;
       bool inputsIsNull_;
       boost::shared_ptr<ZeroRateCurve> zeroCurve_;
       std::string zeroCurveIDRef_;
       bool zeroCurveIsNull_;
       std::vector<boost::shared_ptr<ForwardRateCurve>> forwardCurve_;
       std::string forwardCurveIDRef_;
       bool forwardCurveIsNull_;
       boost::shared_ptr<TermCurve> discountFactorCurve_;
       std::string discountFactorCurveIDRef_;
       bool discountFactorCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

