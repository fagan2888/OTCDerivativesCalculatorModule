// YieldCurve.hpp 
#ifndef FpmlSerialized_YieldCurve_hpp
#define FpmlSerialized_YieldCurve_hpp

#include <fpml-shared-5-4/PricingStructure.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/ForecastRateIndex.hpp>

namespace FpmlSerialized {

class YieldCurve : public PricingStructure { 
   public: 
       YieldCurve(TiXmlNode* xmlNode);

       bool isAlgorithm(){return this->algorithmIsNull_;}
       boost::shared_ptr<XsdTypeString> getAlgorithm();
      std::string getAlgorithmIDRef(){return algorithmIDRef_;}

       bool isForecastRateIndex(){return this->forecastRateIndexIsNull_;}
       boost::shared_ptr<ForecastRateIndex> getForecastRateIndex();
      std::string getForecastRateIndexIDRef(){return forecastRateIndexIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> algorithm_;
       std::string algorithmIDRef_;
       bool algorithmIsNull_;
       boost::shared_ptr<ForecastRateIndex> forecastRateIndex_;
       std::string forecastRateIndexIDRef_;
       bool forecastRateIndexIsNull_;

};

} //namespaceFpmlSerialized end
#endif

