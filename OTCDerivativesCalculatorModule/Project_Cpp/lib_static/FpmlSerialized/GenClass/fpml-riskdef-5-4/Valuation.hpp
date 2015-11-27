// Valuation.hpp 
#ifndef FpmlSerialized_Valuation_hpp
#define FpmlSerialized_Valuation_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/AnyAssetReference.hpp>
#include <fpml-riskdef-5-4/ValuationScenarioReference.hpp>

namespace FpmlSerialized {

class Valuation : public ISerialized { 
   public: 
       Valuation(TiXmlNode* xmlNode);

       bool isObjectReference(){return this->objectReferenceIsNull_;}
       boost::shared_ptr<AnyAssetReference> getObjectReference();
      std::string getObjectReferenceIDRef(){return objectReferenceIDRef_;}

       bool isValuationScenarioReference(){return this->valuationScenarioReferenceIsNull_;}
       boost::shared_ptr<ValuationScenarioReference> getValuationScenarioReference();
      std::string getValuationScenarioReferenceIDRef(){return valuationScenarioReferenceIDRef_;}

   protected: 
       boost::shared_ptr<AnyAssetReference> objectReference_;
       std::string objectReferenceIDRef_;
       bool objectReferenceIsNull_;
       boost::shared_ptr<ValuationScenarioReference> valuationScenarioReference_;
       std::string valuationScenarioReferenceIDRef_;
       bool valuationScenarioReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

