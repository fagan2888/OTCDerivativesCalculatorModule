// PricingParameterShift.hpp 
#ifndef FpmlSerialized_PricingParameterShift_hpp
#define FpmlSerialized_PricingParameterShift_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/AssetOrTermPointOrPricingStructureReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/PriceQuoteUnits.hpp>

namespace FpmlSerialized {

class PricingParameterShift : public ISerialized { 
   public: 
       PricingParameterShift(TiXmlNode* xmlNode);

       bool isParameterReference(){return this->parameterReferenceIsNull_;}
       boost::shared_ptr<AssetOrTermPointOrPricingStructureReference> getParameterReference();
      std::string getParameterReferenceIDRef(){return parameterReferenceIDRef_;}

       bool isShift(){return this->shiftIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getShift();
      std::string getShiftIDRef(){return shiftIDRef_;}

       bool isShiftUnits(){return this->shiftUnitsIsNull_;}
       boost::shared_ptr<PriceQuoteUnits> getShiftUnits();
      std::string getShiftUnitsIDRef(){return shiftUnitsIDRef_;}

   protected: 
       boost::shared_ptr<AssetOrTermPointOrPricingStructureReference> parameterReference_;
       std::string parameterReferenceIDRef_;
       bool parameterReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> shift_;
       std::string shiftIDRef_;
       bool shiftIsNull_;
       boost::shared_ptr<PriceQuoteUnits> shiftUnits_;
       std::string shiftUnitsIDRef_;
       bool shiftUnitsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

