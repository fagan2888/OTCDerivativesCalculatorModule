// WeightedPartialDerivative.hpp 
#ifndef FpmlSerialized_WeightedPartialDerivative_hpp
#define FpmlSerialized_WeightedPartialDerivative_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/PricingParameterDerivativeReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class WeightedPartialDerivative : public ISerialized { 
   public: 
       WeightedPartialDerivative(TiXmlNode* xmlNode);

       bool isPartialDerivativeReference(){return this->partialDerivativeReferenceIsNull_;}
       boost::shared_ptr<PricingParameterDerivativeReference> getPartialDerivativeReference();
      std::string getPartialDerivativeReferenceIDRef(){return partialDerivativeReferenceIDRef_;}

       bool isWeight(){return this->weightIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getWeight();
      std::string getWeightIDRef(){return weightIDRef_;}

   protected: 
       boost::shared_ptr<PricingParameterDerivativeReference> partialDerivativeReference_;
       std::string partialDerivativeReferenceIDRef_;
       bool partialDerivativeReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> weight_;
       std::string weightIDRef_;
       bool weightIsNull_;

};

} //namespaceFpmlSerialized end
#endif

