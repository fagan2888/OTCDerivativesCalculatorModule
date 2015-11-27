// ValuationScenario.hpp 
#ifndef FpmlSerialized_ValuationScenario_hpp
#define FpmlSerialized_ValuationScenario_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>
#include <fpml-riskdef-5-4/MarketReference.hpp>
#include <fpml-riskdef-5-4/PricingParameterShift.hpp>
#include <fpml-riskdef-5-4/PricingInputReplacement.hpp>

namespace FpmlSerialized {

class ValuationScenario : public ISerialized { 
   public: 
       ValuationScenario(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isValuationDate(){return this->valuationDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getValuationDate();
      std::string getValuationDateIDRef(){return valuationDateIDRef_;}

       bool isMarketReference(){return this->marketReferenceIsNull_;}
       boost::shared_ptr<MarketReference> getMarketReference();
      std::string getMarketReferenceIDRef(){return marketReferenceIDRef_;}

       bool isShift(){return this->shiftIsNull_;}
       std::vector<boost::shared_ptr<PricingParameterShift>> getShift();
      std::string getShiftIDRef(){return shiftIDRef_;}

       bool isReplacement(){return this->replacementIsNull_;}
       std::vector<boost::shared_ptr<PricingInputReplacement>> getReplacement();
      std::string getReplacementIDRef(){return replacementIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<IdentifiedDate> valuationDate_;
       std::string valuationDateIDRef_;
       bool valuationDateIsNull_;
       boost::shared_ptr<MarketReference> marketReference_;
       std::string marketReferenceIDRef_;
       bool marketReferenceIsNull_;
       std::vector<boost::shared_ptr<PricingParameterShift>> shift_;
       std::string shiftIDRef_;
       bool shiftIsNull_;
       std::vector<boost::shared_ptr<PricingInputReplacement>> replacement_;
       std::string replacementIDRef_;
       bool replacementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

