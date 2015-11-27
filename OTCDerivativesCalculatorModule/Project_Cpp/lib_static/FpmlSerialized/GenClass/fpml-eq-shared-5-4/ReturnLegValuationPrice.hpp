// ReturnLegValuationPrice.hpp 
#ifndef FpmlSerialized_ReturnLegValuationPrice_hpp
#define FpmlSerialized_ReturnLegValuationPrice_hpp

#include <fpml-asset-5-4/Price.hpp>
#include <fpml-eq-shared-5-4/EquityValuation.hpp>

namespace FpmlSerialized {

class ReturnLegValuationPrice : public Price { 
   public: 
       ReturnLegValuationPrice(TiXmlNode* xmlNode);

       bool isValuationRules(){return this->valuationRulesIsNull_;}
       boost::shared_ptr<EquityValuation> getValuationRules();
      std::string getValuationRulesIDRef(){return valuationRulesIDRef_;}

   protected: 
       boost::shared_ptr<EquityValuation> valuationRules_;
       std::string valuationRulesIDRef_;
       bool valuationRulesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

