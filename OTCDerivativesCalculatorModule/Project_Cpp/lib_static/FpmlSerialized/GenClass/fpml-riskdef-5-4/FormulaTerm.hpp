// FormulaTerm.hpp 
#ifndef FpmlSerialized_FormulaTerm_hpp
#define FpmlSerialized_FormulaTerm_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-riskdef-5-4/PricingParameterDerivativeReference.hpp>

namespace FpmlSerialized {

class FormulaTerm : public ISerialized { 
   public: 
       FormulaTerm(TiXmlNode* xmlNode);

       bool isCoefficient(){return this->coefficientIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getCoefficient();
      std::string getCoefficientIDRef(){return coefficientIDRef_;}

       bool isPartialDerivativeReference(){return this->partialDerivativeReferenceIsNull_;}
       std::vector<boost::shared_ptr<PricingParameterDerivativeReference>> getPartialDerivativeReference();
      std::string getPartialDerivativeReferenceIDRef(){return partialDerivativeReferenceIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> coefficient_;
       std::string coefficientIDRef_;
       bool coefficientIsNull_;
       std::vector<boost::shared_ptr<PricingParameterDerivativeReference>> partialDerivativeReference_;
       std::string partialDerivativeReferenceIDRef_;
       bool partialDerivativeReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

