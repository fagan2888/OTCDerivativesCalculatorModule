// SensitivitySetDefinition.hpp 
#ifndef FpmlSerialized_SensitivitySetDefinition_hpp
#define FpmlSerialized_SensitivitySetDefinition_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-asset-5-4/QuotationCharacteristics.hpp>
#include <fpml-riskdef-5-4/ValuationScenarioReference.hpp>
#include <fpml-riskdef-5-4/PricingInputType.hpp>
#include <fpml-shared-5-4/PricingStructureReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-riskdef-5-4/SensitivityDefinition.hpp>
#include <fpml-riskdef-5-4/DerivativeCalculationProcedure.hpp>

namespace FpmlSerialized {

class SensitivitySetDefinition : public ISerialized { 
   public: 
       SensitivitySetDefinition(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isSensitivityCharacteristics(){return this->sensitivityCharacteristicsIsNull_;}
       boost::shared_ptr<QuotationCharacteristics> getSensitivityCharacteristics();
      std::string getSensitivityCharacteristicsIDRef(){return sensitivityCharacteristicsIDRef_;}

       bool isValuationScenarioReference(){return this->valuationScenarioReferenceIsNull_;}
       boost::shared_ptr<ValuationScenarioReference> getValuationScenarioReference();
      std::string getValuationScenarioReferenceIDRef(){return valuationScenarioReferenceIDRef_;}

       bool isPricingInputType(){return this->pricingInputTypeIsNull_;}
       boost::shared_ptr<PricingInputType> getPricingInputType();
      std::string getPricingInputTypeIDRef(){return pricingInputTypeIDRef_;}

       bool isPricingInputReference(){return this->pricingInputReferenceIsNull_;}
       boost::shared_ptr<PricingStructureReference> getPricingInputReference();
      std::string getPricingInputReferenceIDRef(){return pricingInputReferenceIDRef_;}

       bool isScale(){return this->scaleIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getScale();
      std::string getScaleIDRef(){return scaleIDRef_;}

       bool isSensitivityDefinition(){return this->sensitivityDefinitionIsNull_;}
       std::vector<boost::shared_ptr<SensitivityDefinition>> getSensitivityDefinition();
      std::string getSensitivityDefinitionIDRef(){return sensitivityDefinitionIDRef_;}

       bool isCalculationProcedure(){return this->calculationProcedureIsNull_;}
       boost::shared_ptr<DerivativeCalculationProcedure> getCalculationProcedure();
      std::string getCalculationProcedureIDRef(){return calculationProcedureIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<QuotationCharacteristics> sensitivityCharacteristics_;
       std::string sensitivityCharacteristicsIDRef_;
       bool sensitivityCharacteristicsIsNull_;
       boost::shared_ptr<ValuationScenarioReference> valuationScenarioReference_;
       std::string valuationScenarioReferenceIDRef_;
       bool valuationScenarioReferenceIsNull_;
       boost::shared_ptr<PricingInputType> pricingInputType_;
       std::string pricingInputTypeIDRef_;
       bool pricingInputTypeIsNull_;
       boost::shared_ptr<PricingStructureReference> pricingInputReference_;
       std::string pricingInputReferenceIDRef_;
       bool pricingInputReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> scale_;
       std::string scaleIDRef_;
       bool scaleIsNull_;
       std::vector<boost::shared_ptr<SensitivityDefinition>> sensitivityDefinition_;
       std::string sensitivityDefinitionIDRef_;
       bool sensitivityDefinitionIsNull_;
       boost::shared_ptr<DerivativeCalculationProcedure> calculationProcedure_;
       std::string calculationProcedureIDRef_;
       bool calculationProcedureIsNull_;

};

} //namespaceFpmlSerialized end
#endif

