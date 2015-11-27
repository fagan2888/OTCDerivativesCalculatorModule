// DenominatorTerm.hpp 
#ifndef FpmlSerialized_DenominatorTerm_hpp
#define FpmlSerialized_DenominatorTerm_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/WeightedPartialDerivative.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class DenominatorTerm : public ISerialized { 
   public: 
       DenominatorTerm(TiXmlNode* xmlNode);

       bool isWeightedPartial(){return this->weightedPartialIsNull_;}
       boost::shared_ptr<WeightedPartialDerivative> getWeightedPartial();
      std::string getWeightedPartialIDRef(){return weightedPartialIDRef_;}

       bool isPower(){return this->powerIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getPower();
      std::string getPowerIDRef(){return powerIDRef_;}

   protected: 
       boost::shared_ptr<WeightedPartialDerivative> weightedPartial_;
       std::string weightedPartialIDRef_;
       bool weightedPartialIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> power_;
       std::string powerIDRef_;
       bool powerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

