// CoalPhysicalLeg.hpp 
#ifndef FpmlSerialized_CoalPhysicalLeg_hpp
#define FpmlSerialized_CoalPhysicalLeg_hpp

#include <fpml-com-5-4/PhysicalSwapLeg.hpp>
#include <fpml-com-5-4/CommodityDeliveryPeriods.hpp>
#include <fpml-com-5-4/CoalProduct.hpp>
#include <fpml-com-5-4/CoalDelivery.hpp>
#include <fpml-com-5-4/CommodityPhysicalQuantity.hpp>

namespace FpmlSerialized {

class CoalPhysicalLeg : public PhysicalSwapLeg { 
   public: 
       CoalPhysicalLeg(TiXmlNode* xmlNode);

       bool isDeliveryPeriods(){return this->deliveryPeriodsIsNull_;}
       boost::shared_ptr<CommodityDeliveryPeriods> getDeliveryPeriods();
      std::string getDeliveryPeriodsIDRef(){return deliveryPeriodsIDRef_;}

       bool isCoal(){return this->coalIsNull_;}
       boost::shared_ptr<CoalProduct> getCoal();
      std::string getCoalIDRef(){return coalIDRef_;}

       bool isDeliveryConditions(){return this->deliveryConditionsIsNull_;}
       boost::shared_ptr<CoalDelivery> getDeliveryConditions();
      std::string getDeliveryConditionsIDRef(){return deliveryConditionsIDRef_;}

       bool isDeliveryQuantity(){return this->deliveryQuantityIsNull_;}
       boost::shared_ptr<CommodityPhysicalQuantity> getDeliveryQuantity();
      std::string getDeliveryQuantityIDRef(){return deliveryQuantityIDRef_;}

   protected: 
       boost::shared_ptr<CommodityDeliveryPeriods> deliveryPeriods_;
       std::string deliveryPeriodsIDRef_;
       bool deliveryPeriodsIsNull_;
       boost::shared_ptr<CoalProduct> coal_;
       std::string coalIDRef_;
       bool coalIsNull_;
       boost::shared_ptr<CoalDelivery> deliveryConditions_;
       std::string deliveryConditionsIDRef_;
       bool deliveryConditionsIsNull_;
       boost::shared_ptr<CommodityPhysicalQuantity> deliveryQuantity_;
       std::string deliveryQuantityIDRef_;
       bool deliveryQuantityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

