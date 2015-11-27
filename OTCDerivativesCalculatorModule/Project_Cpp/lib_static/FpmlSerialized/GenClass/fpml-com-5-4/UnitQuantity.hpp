// UnitQuantity.hpp 
#ifndef FpmlSerialized_UnitQuantity_hpp
#define FpmlSerialized_UnitQuantity_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/QuantityUnit.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>

namespace FpmlSerialized {

class UnitQuantity : public ISerialized { 
   public: 
       UnitQuantity(TiXmlNode* xmlNode);

       bool isQuantityUnit(){return this->quantityUnitIsNull_;}
       boost::shared_ptr<QuantityUnit> getQuantityUnit();
      std::string getQuantityUnitIDRef(){return quantityUnitIDRef_;}

       bool isQuantity(){return this->quantityIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getQuantity();
      std::string getQuantityIDRef(){return quantityIDRef_;}

   protected: 
       boost::shared_ptr<QuantityUnit> quantityUnit_;
       std::string quantityUnitIDRef_;
       bool quantityUnitIsNull_;
       boost::shared_ptr<NonNegativeDecimal> quantity_;
       std::string quantityIDRef_;
       bool quantityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

