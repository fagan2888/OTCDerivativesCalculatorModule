// Market.hpp 
#ifndef FpmlSerialized_Market_hpp
#define FpmlSerialized_Market_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-riskdef-5-4/QuotedAssetSet.hpp>
#include <fpml-shared-5-4/PricingStructure.hpp>
#include <fpml-mktenv-5-4/CreditCurve.hpp>
#include <fpml-mktenv-5-4/FxCurve.hpp>
#include <fpml-mktenv-5-4/VolatilityRepresentation.hpp>
#include <fpml-mktenv-5-4/YieldCurve.hpp>
#include <fpml-riskdef-5-4/PricingStructureValuation.hpp>
#include <fpml-mktenv-5-4/CreditCurveValuation.hpp>
#include <fpml-mktenv-5-4/FxCurveValuation.hpp>
#include <fpml-mktenv-5-4/VolatilityMatrix.hpp>
#include <fpml-mktenv-5-4/YieldCurveValuation.hpp>
#include <fpml-riskdef-5-4/PricingMethod.hpp>

namespace FpmlSerialized {

class Market : public ISerialized { 
   public: 
       Market(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isBenchmarkQuotes(){return this->benchmarkQuotesIsNull_;}
       boost::shared_ptr<QuotedAssetSet> getBenchmarkQuotes();
      std::string getBenchmarkQuotesIDRef(){return benchmarkQuotesIDRef_;}

       bool isPricingStructure(){return this->pricingStructureIsNull_;}
       boost::shared_ptr<PricingStructure> getPricingStructure();
      std::string getPricingStructureIDRef(){return pricingStructureIDRef_;}

       bool isCreditCurve(){return this->creditCurveIsNull_;}
       boost::shared_ptr<CreditCurve> getCreditCurve();
      std::string getCreditCurveIDRef(){return creditCurveIDRef_;}

       bool isFxCurve(){return this->fxCurveIsNull_;}
       boost::shared_ptr<FxCurve> getFxCurve();
      std::string getFxCurveIDRef(){return fxCurveIDRef_;}

       bool isVolatilityRepresentation(){return this->volatilityRepresentationIsNull_;}
       boost::shared_ptr<VolatilityRepresentation> getVolatilityRepresentation();
      std::string getVolatilityRepresentationIDRef(){return volatilityRepresentationIDRef_;}

       bool isYieldCurve(){return this->yieldCurveIsNull_;}
       boost::shared_ptr<YieldCurve> getYieldCurve();
      std::string getYieldCurveIDRef(){return yieldCurveIDRef_;}

       bool isPricingStructureValuation(){return this->pricingStructureValuationIsNull_;}
       boost::shared_ptr<PricingStructureValuation> getPricingStructureValuation();
      std::string getPricingStructureValuationIDRef(){return pricingStructureValuationIDRef_;}

       bool isCreditCurveValuation(){return this->creditCurveValuationIsNull_;}
       boost::shared_ptr<CreditCurveValuation> getCreditCurveValuation();
      std::string getCreditCurveValuationIDRef(){return creditCurveValuationIDRef_;}

       bool isFxCurveValuation(){return this->fxCurveValuationIsNull_;}
       boost::shared_ptr<FxCurveValuation> getFxCurveValuation();
      std::string getFxCurveValuationIDRef(){return fxCurveValuationIDRef_;}

       bool isVolatilityMatrixValuation(){return this->volatilityMatrixValuationIsNull_;}
       boost::shared_ptr<VolatilityMatrix> getVolatilityMatrixValuation();
      std::string getVolatilityMatrixValuationIDRef(){return volatilityMatrixValuationIDRef_;}

       bool isYieldCurveValuation(){return this->yieldCurveValuationIsNull_;}
       boost::shared_ptr<YieldCurveValuation> getYieldCurveValuation();
      std::string getYieldCurveValuationIDRef(){return yieldCurveValuationIDRef_;}

       bool isBenchmarkPricingMethod(){return this->benchmarkPricingMethodIsNull_;}
       std::vector<boost::shared_ptr<PricingMethod>> getBenchmarkPricingMethod();
      std::string getBenchmarkPricingMethodIDRef(){return benchmarkPricingMethodIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<QuotedAssetSet> benchmarkQuotes_;
       std::string benchmarkQuotesIDRef_;
       bool benchmarkQuotesIsNull_;
       boost::shared_ptr<PricingStructure> pricingStructure_;
       std::string pricingStructureIDRef_;
       bool pricingStructureIsNull_;
       boost::shared_ptr<CreditCurve> creditCurve_;     //substitude 
       std::string creditCurveIDRef_;
       bool creditCurveIsNull_;
       boost::shared_ptr<FxCurve> fxCurve_;     //substitude 
       std::string fxCurveIDRef_;
       bool fxCurveIsNull_;
       boost::shared_ptr<VolatilityRepresentation> volatilityRepresentation_;     //substitude 
       std::string volatilityRepresentationIDRef_;
       bool volatilityRepresentationIsNull_;
       boost::shared_ptr<YieldCurve> yieldCurve_;     //substitude 
       std::string yieldCurveIDRef_;
       bool yieldCurveIsNull_;
       boost::shared_ptr<PricingStructureValuation> pricingStructureValuation_;
       std::string pricingStructureValuationIDRef_;
       bool pricingStructureValuationIsNull_;
       boost::shared_ptr<CreditCurveValuation> creditCurveValuation_;     //substitude 
       std::string creditCurveValuationIDRef_;
       bool creditCurveValuationIsNull_;
       boost::shared_ptr<FxCurveValuation> fxCurveValuation_;     //substitude 
       std::string fxCurveValuationIDRef_;
       bool fxCurveValuationIsNull_;
       boost::shared_ptr<VolatilityMatrix> volatilityMatrixValuation_;     //substitude 
       std::string volatilityMatrixValuationIDRef_;
       bool volatilityMatrixValuationIsNull_;
       boost::shared_ptr<YieldCurveValuation> yieldCurveValuation_;     //substitude 
       std::string yieldCurveValuationIDRef_;
       bool yieldCurveValuationIsNull_;
       std::vector<boost::shared_ptr<PricingMethod>> benchmarkPricingMethod_;
       std::string benchmarkPricingMethodIDRef_;
       bool benchmarkPricingMethodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

