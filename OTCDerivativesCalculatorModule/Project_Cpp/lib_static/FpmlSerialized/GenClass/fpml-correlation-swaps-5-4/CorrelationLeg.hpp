// CorrelationLeg.hpp 
#ifndef FpmlSerialized_CorrelationLeg_hpp
#define FpmlSerialized_CorrelationLeg_hpp

#include <fpml-eq-shared-5-4/DirectionalLegUnderlyerValuation.hpp>
#include <fpml-correlation-swaps-5-4/CorrelationAmount.hpp>

namespace FpmlSerialized {

class CorrelationLeg : public DirectionalLegUnderlyerValuation { 
   public: 
       CorrelationLeg(TiXmlNode* xmlNode);

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<CorrelationAmount> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

   protected: 
       boost::shared_ptr<CorrelationAmount> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

