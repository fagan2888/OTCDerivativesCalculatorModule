// CommodityNotionalQuantity.hpp 
#ifndef FpmlSerialized_CommodityNotionalQuantity_hpp
#define FpmlSerialized_CommodityNotionalQuantity_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/QuantityUnit.hpp>
#include <fpml-com-5-4/CommodityQuantityFrequency.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class CommodityNotionalQuantity : public ISerialized { 
   public: 
       CommodityNotionalQuantity(TiXmlNode* xmlNode);

       bool isQuantityUnit(){return this->quantityUnitIsNull_;}
       boost::shared_ptr<QuantityUnit> getQuantityUnit();
      std::string getQuantityUnitIDRef(){return quantityUnitIDRef_;}

       bool isQuantityFrequency(){return this->quantityFrequencyIsNull_;}
       boost::shared_ptr<CommodityQuantityFrequency> getQuantityFrequency();
      std::string getQuantityFrequencyIDRef(){return quantityFrequencyIDRef_;}

       bool isQuantity(){return this->quantityIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getQuantity();
      std::string getQuantityIDRef(){return quantityIDRef_;}

   protected: 
       boost::shared_ptr<QuantityUnit> quantityUnit_;
       std::string quantityUnitIDRef_;
       bool quantityUnitIsNull_;
       boost::shared_ptr<CommodityQuantityFrequency> quantityFrequency_;
       std::string quantityFrequencyIDRef_;
       bool quantityFrequencyIsNull_;
       boost::shared_ptr<XsdTypeDecimal> quantity_;
       std::string quantityIDRef_;
       bool quantityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

