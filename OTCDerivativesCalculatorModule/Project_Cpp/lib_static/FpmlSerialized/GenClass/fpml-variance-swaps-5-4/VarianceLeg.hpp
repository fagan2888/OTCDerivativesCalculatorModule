// VarianceLeg.hpp 
#ifndef FpmlSerialized_VarianceLeg_hpp
#define FpmlSerialized_VarianceLeg_hpp

#include <fpml-eq-shared-5-4/DirectionalLegUnderlyerValuation.hpp>
#include <fpml-variance-swaps-5-4/VarianceAmount.hpp>

namespace FpmlSerialized {

class VarianceLeg : public DirectionalLegUnderlyerValuation { 
   public: 
       VarianceLeg(TiXmlNode* xmlNode);

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<VarianceAmount> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

   protected: 
       boost::shared_ptr<VarianceAmount> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

