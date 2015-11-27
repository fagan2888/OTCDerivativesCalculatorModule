// FxCurveValuation.hpp 
#ifndef FpmlSerialized_FxCurveValuation_hpp
#define FpmlSerialized_FxCurveValuation_hpp

#include <fpml-riskdef-5-4/PricingStructureValuation.hpp>
#include <fpml-shared-5-4/PricingStructureReference.hpp>
#include <fpml-mktenv-5-4/FxRateSet.hpp>
#include <fpml-mktenv-5-4/TermCurve.hpp>

namespace FpmlSerialized {

class FxCurveValuation : public PricingStructureValuation { 
   public: 
       FxCurveValuation(TiXmlNode* xmlNode);

       bool isSettlementCurrencyYieldCurve(){return this->settlementCurrencyYieldCurveIsNull_;}
       boost::shared_ptr<PricingStructureReference> getSettlementCurrencyYieldCurve();
      std::string getSettlementCurrencyYieldCurveIDRef(){return settlementCurrencyYieldCurveIDRef_;}

       bool isForecastCurrencyYieldCurve(){return this->forecastCurrencyYieldCurveIsNull_;}
       boost::shared_ptr<PricingStructureReference> getForecastCurrencyYieldCurve();
      std::string getForecastCurrencyYieldCurveIDRef(){return forecastCurrencyYieldCurveIDRef_;}

       bool isSpotRate(){return this->spotRateIsNull_;}
       boost::shared_ptr<FxRateSet> getSpotRate();
      std::string getSpotRateIDRef(){return spotRateIDRef_;}

       bool isFxForwardCurve(){return this->fxForwardCurveIsNull_;}
       boost::shared_ptr<TermCurve> getFxForwardCurve();
      std::string getFxForwardCurveIDRef(){return fxForwardCurveIDRef_;}

       bool isFxForwardPointsCurve(){return this->fxForwardPointsCurveIsNull_;}
       boost::shared_ptr<TermCurve> getFxForwardPointsCurve();
      std::string getFxForwardPointsCurveIDRef(){return fxForwardPointsCurveIDRef_;}

   protected: 
       boost::shared_ptr<PricingStructureReference> settlementCurrencyYieldCurve_;
       std::string settlementCurrencyYieldCurveIDRef_;
       bool settlementCurrencyYieldCurveIsNull_;
       boost::shared_ptr<PricingStructureReference> forecastCurrencyYieldCurve_;
       std::string forecastCurrencyYieldCurveIDRef_;
       bool forecastCurrencyYieldCurveIsNull_;
       boost::shared_ptr<FxRateSet> spotRate_;
       std::string spotRateIDRef_;
       bool spotRateIsNull_;
       boost::shared_ptr<TermCurve> fxForwardCurve_;
       std::string fxForwardCurveIDRef_;
       bool fxForwardCurveIsNull_;
       boost::shared_ptr<TermCurve> fxForwardPointsCurve_;
       std::string fxForwardPointsCurveIDRef_;
       bool fxForwardPointsCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

