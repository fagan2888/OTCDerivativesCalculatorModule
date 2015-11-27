// VarianceAmount.hpp 
#ifndef FpmlSerialized_VarianceAmount_hpp
#define FpmlSerialized_VarianceAmount_hpp

#include <fpml-eq-shared-5-4/CalculatedAmount.hpp>
#include <fpml-eq-shared-5-4/Variance.hpp>

namespace FpmlSerialized {

class VarianceAmount : public CalculatedAmount { 
   public: 
       VarianceAmount(TiXmlNode* xmlNode);

       bool isVariance(){return this->varianceIsNull_;}
       boost::shared_ptr<Variance> getVariance();
      std::string getVarianceIDRef(){return varianceIDRef_;}

   protected: 
       boost::shared_ptr<Variance> variance_;
       std::string varianceIDRef_;
       bool varianceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

