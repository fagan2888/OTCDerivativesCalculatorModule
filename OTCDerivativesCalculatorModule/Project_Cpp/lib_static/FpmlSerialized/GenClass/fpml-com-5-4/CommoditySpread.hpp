// CommoditySpread.hpp 
#ifndef FpmlSerialized_CommoditySpread_hpp
#define FpmlSerialized_CommoditySpread_hpp

#include <fpml-shared-5-4/Money.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/QuantityUnit.hpp>

namespace FpmlSerialized {

class CommoditySpread : public Money { 
   public: 
       CommoditySpread(TiXmlNode* xmlNode);

       bool isSpreadConversionFactor(){return this->spreadConversionFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getSpreadConversionFactor();
      std::string getSpreadConversionFactorIDRef(){return spreadConversionFactorIDRef_;}

       bool isSpreadUnit(){return this->spreadUnitIsNull_;}
       boost::shared_ptr<QuantityUnit> getSpreadUnit();
      std::string getSpreadUnitIDRef(){return spreadUnitIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> spreadConversionFactor_;
       std::string spreadConversionFactorIDRef_;
       bool spreadConversionFactorIsNull_;
       boost::shared_ptr<QuantityUnit> spreadUnit_;
       std::string spreadUnitIDRef_;
       bool spreadUnitIsNull_;

};

} //namespaceFpmlSerialized end
#endif

