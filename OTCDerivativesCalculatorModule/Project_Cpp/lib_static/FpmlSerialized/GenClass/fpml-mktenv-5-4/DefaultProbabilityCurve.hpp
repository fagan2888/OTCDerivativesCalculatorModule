// DefaultProbabilityCurve.hpp 
#ifndef FpmlSerialized_DefaultProbabilityCurve_hpp
#define FpmlSerialized_DefaultProbabilityCurve_hpp

#include <fpml-riskdef-5-4/PricingStructureValuation.hpp>
#include <fpml-shared-5-4/PricingStructureReference.hpp>
#include <fpml-mktenv-5-4/TermCurve.hpp>

namespace FpmlSerialized {

class DefaultProbabilityCurve : public PricingStructureValuation { 
   public: 
       DefaultProbabilityCurve(TiXmlNode* xmlNode);

       bool isBaseYieldCurve(){return this->baseYieldCurveIsNull_;}
       boost::shared_ptr<PricingStructureReference> getBaseYieldCurve();
      std::string getBaseYieldCurveIDRef(){return baseYieldCurveIDRef_;}

       bool isDefaultProbabilities(){return this->defaultProbabilitiesIsNull_;}
       boost::shared_ptr<TermCurve> getDefaultProbabilities();
      std::string getDefaultProbabilitiesIDRef(){return defaultProbabilitiesIDRef_;}

   protected: 
       boost::shared_ptr<PricingStructureReference> baseYieldCurve_;
       std::string baseYieldCurveIDRef_;
       bool baseYieldCurveIsNull_;
       boost::shared_ptr<TermCurve> defaultProbabilities_;
       std::string defaultProbabilitiesIDRef_;
       bool defaultProbabilitiesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

