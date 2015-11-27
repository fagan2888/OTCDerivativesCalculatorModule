// ParametricAdjustmentPoint.hpp 
#ifndef FpmlSerialized_ParametricAdjustmentPoint_hpp
#define FpmlSerialized_ParametricAdjustmentPoint_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class ParametricAdjustmentPoint : public ISerialized { 
   public: 
       ParametricAdjustmentPoint(TiXmlNode* xmlNode);

       bool isParameterValue(){return this->parameterValueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getParameterValue();
      std::string getParameterValueIDRef(){return parameterValueIDRef_;}

       bool isAdjustmentValue(){return this->adjustmentValueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAdjustmentValue();
      std::string getAdjustmentValueIDRef(){return adjustmentValueIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> parameterValue_;
       std::string parameterValueIDRef_;
       bool parameterValueIsNull_;
       boost::shared_ptr<XsdTypeDecimal> adjustmentValue_;
       std::string adjustmentValueIDRef_;
       bool adjustmentValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

