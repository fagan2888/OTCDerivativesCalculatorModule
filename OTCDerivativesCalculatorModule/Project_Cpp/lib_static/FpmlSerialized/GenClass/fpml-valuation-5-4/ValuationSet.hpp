// ValuationSet.hpp 
#ifndef FpmlSerialized_ValuationSet_hpp
#define FpmlSerialized_ValuationSet_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-riskdef-5-4/ValuationScenario.hpp>
#include <fpml-riskdef-5-4/ValuationScenarioReference.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-asset-5-4/QuotationCharacteristics.hpp>
#include <fpml-riskdef-5-4/SensitivitySetDefinition.hpp>
#include <fpml-valuation-5-4/ValuationSetDetail.hpp>
#include <fpml-valuation-5-4/AssetValuation.hpp>

namespace FpmlSerialized {

class ValuationSet : public ISerialized { 
   public: 
       ValuationSet(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isValuationScenario(){return this->valuationScenarioIsNull_;}
       std::vector<boost::shared_ptr<ValuationScenario>> getValuationScenario();
      std::string getValuationScenarioIDRef(){return valuationScenarioIDRef_;}

       bool isValuationScenarioReference(){return this->valuationScenarioReferenceIsNull_;}
       std::vector<boost::shared_ptr<ValuationScenarioReference>> getValuationScenarioReference();
      std::string getValuationScenarioReferenceIDRef(){return valuationScenarioReferenceIDRef_;}

       bool isBaseParty(){return this->basePartyIsNull_;}
       boost::shared_ptr<PartyReference> getBaseParty();
      std::string getBasePartyIDRef(){return basePartyIDRef_;}

       bool isQuotationCharacteristics(){return this->quotationCharacteristicsIsNull_;}
       std::vector<boost::shared_ptr<QuotationCharacteristics>> getQuotationCharacteristics();
      std::string getQuotationCharacteristicsIDRef(){return quotationCharacteristicsIDRef_;}

       bool isSensitivitySetDefinition(){return this->sensitivitySetDefinitionIsNull_;}
       std::vector<boost::shared_ptr<SensitivitySetDefinition>> getSensitivitySetDefinition();
      std::string getSensitivitySetDefinitionIDRef(){return sensitivitySetDefinitionIDRef_;}

       bool isDetail(){return this->detailIsNull_;}
       boost::shared_ptr<ValuationSetDetail> getDetail();
      std::string getDetailIDRef(){return detailIDRef_;}

       bool isAssetValuation(){return this->assetValuationIsNull_;}
       std::vector<boost::shared_ptr<AssetValuation>> getAssetValuation();
      std::string getAssetValuationIDRef(){return assetValuationIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       std::vector<boost::shared_ptr<ValuationScenario>> valuationScenario_;
       std::string valuationScenarioIDRef_;
       bool valuationScenarioIsNull_;
       std::vector<boost::shared_ptr<ValuationScenarioReference>> valuationScenarioReference_;
       std::string valuationScenarioReferenceIDRef_;
       bool valuationScenarioReferenceIsNull_;
       boost::shared_ptr<PartyReference> baseParty_;
       std::string basePartyIDRef_;
       bool basePartyIsNull_;
       std::vector<boost::shared_ptr<QuotationCharacteristics>> quotationCharacteristics_;
       std::string quotationCharacteristicsIDRef_;
       bool quotationCharacteristicsIsNull_;
       std::vector<boost::shared_ptr<SensitivitySetDefinition>> sensitivitySetDefinition_;
       std::string sensitivitySetDefinitionIDRef_;
       bool sensitivitySetDefinitionIsNull_;
       boost::shared_ptr<ValuationSetDetail> detail_;
       std::string detailIDRef_;
       bool detailIsNull_;
       std::vector<boost::shared_ptr<AssetValuation>> assetValuation_;
       std::string assetValuationIDRef_;
       bool assetValuationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

