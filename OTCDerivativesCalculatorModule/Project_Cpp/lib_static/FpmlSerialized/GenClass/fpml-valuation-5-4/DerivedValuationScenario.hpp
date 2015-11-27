// DerivedValuationScenario.hpp 
#ifndef FpmlSerialized_DerivedValuationScenario_hpp
#define FpmlSerialized_DerivedValuationScenario_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-riskdef-5-4/ValuationScenarioReference.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>
#include <fpml-riskdef-5-4/MarketReference.hpp>
#include <fpml-riskdef-5-4/PricingParameterShift.hpp>

namespace FpmlSerialized {

class DerivedValuationScenario : public ISerialized { 
   public: 
       DerivedValuationScenario(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isBaseValuationScenario(){return this->baseValuationScenarioIsNull_;}
       boost::shared_ptr<ValuationScenarioReference> getBaseValuationScenario();
      std::string getBaseValuationScenarioIDRef(){return baseValuationScenarioIDRef_;}

       bool isValuationDate(){return this->valuationDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getValuationDate();
      std::string getValuationDateIDRef(){return valuationDateIDRef_;}

       bool isMarketReference(){return this->marketReferenceIsNull_;}
       boost::shared_ptr<MarketReference> getMarketReference();
      std::string getMarketReferenceIDRef(){return marketReferenceIDRef_;}

       bool isShift(){return this->shiftIsNull_;}
       std::vector<boost::shared_ptr<PricingParameterShift>> getShift();
      std::string getShiftIDRef(){return shiftIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<ValuationScenarioReference> baseValuationScenario_;
       std::string baseValuationScenarioIDRef_;
       bool baseValuationScenarioIsNull_;
       boost::shared_ptr<IdentifiedDate> valuationDate_;
       std::string valuationDateIDRef_;
       bool valuationDateIsNull_;
       boost::shared_ptr<MarketReference> marketReference_;
       std::string marketReferenceIDRef_;
       bool marketReferenceIsNull_;
       std::vector<boost::shared_ptr<PricingParameterShift>> shift_;
       std::string shiftIDRef_;
       bool shiftIsNull_;

};

} //namespaceFpmlSerialized end
#endif

