// InflationRateCalculation.hpp 
#ifndef FpmlSerialized_InflationRateCalculation_hpp
#define FpmlSerialized_InflationRateCalculation_hpp

#include <fpml-shared-5-4/FloatingRateCalculation.hpp>
#include <fpml-shared-5-4/Offset.hpp>
#include <fpml-shared-5-4/RateSourcePage.hpp>
#include <fpml-shared-5-4/MainPublication.hpp>
#include <fpml-shared-5-4/InterpolationMethod.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class InflationRateCalculation : public FloatingRateCalculation { 
   public: 
       InflationRateCalculation(TiXmlNode* xmlNode);

       bool isInflationLag(){return this->inflationLagIsNull_;}
       boost::shared_ptr<Offset> getInflationLag();
      std::string getInflationLagIDRef(){return inflationLagIDRef_;}

       bool isIndexSource(){return this->indexSourceIsNull_;}
       boost::shared_ptr<RateSourcePage> getIndexSource();
      std::string getIndexSourceIDRef(){return indexSourceIDRef_;}

       bool isMainPublication(){return this->mainPublicationIsNull_;}
       boost::shared_ptr<MainPublication> getMainPublication();
      std::string getMainPublicationIDRef(){return mainPublicationIDRef_;}

       bool isInterpolationMethod(){return this->interpolationMethodIsNull_;}
       boost::shared_ptr<InterpolationMethod> getInterpolationMethod();
      std::string getInterpolationMethodIDRef(){return interpolationMethodIDRef_;}

       bool isInitialIndexLevel(){return this->initialIndexLevelIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getInitialIndexLevel();
      std::string getInitialIndexLevelIDRef(){return initialIndexLevelIDRef_;}

       bool isFallbackBondApplicable(){return this->fallbackBondApplicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFallbackBondApplicable();
      std::string getFallbackBondApplicableIDRef(){return fallbackBondApplicableIDRef_;}

   protected: 
       boost::shared_ptr<Offset> inflationLag_;
       std::string inflationLagIDRef_;
       bool inflationLagIsNull_;
       boost::shared_ptr<RateSourcePage> indexSource_;
       std::string indexSourceIDRef_;
       bool indexSourceIsNull_;
       boost::shared_ptr<MainPublication> mainPublication_;
       std::string mainPublicationIDRef_;
       bool mainPublicationIsNull_;
       boost::shared_ptr<InterpolationMethod> interpolationMethod_;
       std::string interpolationMethodIDRef_;
       bool interpolationMethodIsNull_;
       boost::shared_ptr<XsdTypeDecimal> initialIndexLevel_;
       std::string initialIndexLevelIDRef_;
       bool initialIndexLevelIsNull_;
       boost::shared_ptr<XsdTypeBoolean> fallbackBondApplicable_;
       std::string fallbackBondApplicableIDRef_;
       bool fallbackBondApplicableIsNull_;

};

} //namespaceFpmlSerialized end
#endif

