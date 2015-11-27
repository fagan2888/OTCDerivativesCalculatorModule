// ParametricAdjustment.hpp 
#ifndef FpmlSerialized_ParametricAdjustment_hpp
#define FpmlSerialized_ParametricAdjustment_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <fpml-asset-5-4/PriceQuoteUnits.hpp>
#include <fpml-mktenv-5-4/ParametricAdjustmentPoint.hpp>

namespace FpmlSerialized {

class ParametricAdjustment : public ISerialized { 
   public: 
       ParametricAdjustment(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isInputUnits(){return this->inputUnitsIsNull_;}
       boost::shared_ptr<PriceQuoteUnits> getInputUnits();
      std::string getInputUnitsIDRef(){return inputUnitsIDRef_;}

       bool isDatapoint(){return this->datapointIsNull_;}
       std::vector<boost::shared_ptr<ParametricAdjustmentPoint>> getDatapoint();
      std::string getDatapointIDRef(){return datapointIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeNormalizedString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<PriceQuoteUnits> inputUnits_;
       std::string inputUnitsIDRef_;
       bool inputUnitsIsNull_;
       std::vector<boost::shared_ptr<ParametricAdjustmentPoint>> datapoint_;
       std::string datapointIDRef_;
       bool datapointIsNull_;

};

} //namespaceFpmlSerialized end
#endif

