// DirectionalLegUnderlyerValuation.hpp 
#ifndef FpmlSerialized_DirectionalLegUnderlyerValuation_hpp
#define FpmlSerialized_DirectionalLegUnderlyerValuation_hpp

#include <fpml-eq-shared-5-4/DirectionalLegUnderlyer.hpp>
#include <fpml-eq-shared-5-4/EquityValuation.hpp>

namespace FpmlSerialized {

class DirectionalLegUnderlyerValuation : public DirectionalLegUnderlyer { 
   public: 
       DirectionalLegUnderlyerValuation(TiXmlNode* xmlNode);

       bool isValuation(){return this->valuationIsNull_;}
       boost::shared_ptr<EquityValuation> getValuation();
      std::string getValuationIDRef(){return valuationIDRef_;}

   protected: 
       boost::shared_ptr<EquityValuation> valuation_;
       std::string valuationIDRef_;
       bool valuationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

