// OilPhysicalLeg.hpp 
#ifndef FpmlSerialized_OilPhysicalLeg_hpp
#define FpmlSerialized_OilPhysicalLeg_hpp

#include <fpml-com-5-4/PhysicalSwapLeg.hpp>
#include <fpml-com-5-4/CommodityDeliveryPeriods.hpp>
#include <fpml-com-5-4/OilProduct.hpp>
#include <fpml-com-5-4/OilDelivery.hpp>
#include <fpml-com-5-4/CommodityPhysicalQuantity.hpp>

namespace FpmlSerialized {

class OilPhysicalLeg : public PhysicalSwapLeg { 
   public: 
       OilPhysicalLeg(TiXmlNode* xmlNode);

       bool isDeliveryPeriods(){return this->deliveryPeriodsIsNull_;}
       boost::shared_ptr<CommodityDeliveryPeriods> getDeliveryPeriods();
      std::string getDeliveryPeriodsIDRef(){return deliveryPeriodsIDRef_;}

       bool isOil(){return this->oilIsNull_;}
       boost::shared_ptr<OilProduct> getOil();
      std::string getOilIDRef(){return oilIDRef_;}

       bool isDeliveryConditions(){return this->deliveryConditionsIsNull_;}
       boost::shared_ptr<OilDelivery> getDeliveryConditions();
      std::string getDeliveryConditionsIDRef(){return deliveryConditionsIDRef_;}

       bool isDeliveryQuantity(){return this->deliveryQuantityIsNull_;}
       boost::shared_ptr<CommodityPhysicalQuantity> getDeliveryQuantity();
      std::string getDeliveryQuantityIDRef(){return deliveryQuantityIDRef_;}

   protected: 
       boost::shared_ptr<CommodityDeliveryPeriods> deliveryPeriods_;
       std::string deliveryPeriodsIDRef_;
       bool deliveryPeriodsIsNull_;
       boost::shared_ptr<OilProduct> oil_;
       std::string oilIDRef_;
       bool oilIsNull_;
       boost::shared_ptr<OilDelivery> deliveryConditions_;
       std::string deliveryConditionsIDRef_;
       bool deliveryConditionsIsNull_;
       boost::shared_ptr<CommodityPhysicalQuantity> deliveryQuantity_;
       std::string deliveryQuantityIDRef_;
       bool deliveryQuantityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

