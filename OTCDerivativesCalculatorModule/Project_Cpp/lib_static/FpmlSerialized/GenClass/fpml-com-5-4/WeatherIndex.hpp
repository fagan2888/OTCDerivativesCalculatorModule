// WeatherIndex.hpp 
#ifndef FpmlSerialized_WeatherIndex_hpp
#define FpmlSerialized_WeatherIndex_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/QuantityUnit.hpp>

namespace FpmlSerialized {

class WeatherIndex : public ISerialized { 
   public: 
       WeatherIndex(TiXmlNode* xmlNode);

       bool isQuantity(){return this->quantityIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getQuantity();
      std::string getQuantityIDRef(){return quantityIDRef_;}

       bool isUnit(){return this->unitIsNull_;}
       boost::shared_ptr<QuantityUnit> getUnit();
      std::string getUnitIDRef(){return unitIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> quantity_;
       std::string quantityIDRef_;
       bool quantityIsNull_;
       boost::shared_ptr<QuantityUnit> unit_;
       std::string unitIDRef_;
       bool unitIsNull_;

};

} //namespaceFpmlSerialized end
#endif

