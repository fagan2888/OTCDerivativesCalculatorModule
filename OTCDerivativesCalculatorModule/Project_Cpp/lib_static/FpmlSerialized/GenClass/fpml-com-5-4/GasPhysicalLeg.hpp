// GasPhysicalLeg.hpp 
#ifndef FpmlSerialized_GasPhysicalLeg_hpp
#define FpmlSerialized_GasPhysicalLeg_hpp

#include <fpml-com-5-4/PhysicalSwapLeg.hpp>
#include <fpml-com-5-4/GasDeliveryPeriods.hpp>
#include <fpml-com-5-4/GasProduct.hpp>
#include <fpml-com-5-4/GasDelivery.hpp>
#include <fpml-com-5-4/GasPhysicalQuantity.hpp>

namespace FpmlSerialized {

class GasPhysicalLeg : public PhysicalSwapLeg { 
   public: 
       GasPhysicalLeg(TiXmlNode* xmlNode);

       bool isDeliveryPeriods(){return this->deliveryPeriodsIsNull_;}
       boost::shared_ptr<GasDeliveryPeriods> getDeliveryPeriods();
      std::string getDeliveryPeriodsIDRef(){return deliveryPeriodsIDRef_;}

       bool isGas(){return this->gasIsNull_;}
       boost::shared_ptr<GasProduct> getGas();
      std::string getGasIDRef(){return gasIDRef_;}

       bool isDeliveryConditions(){return this->deliveryConditionsIsNull_;}
       boost::shared_ptr<GasDelivery> getDeliveryConditions();
      std::string getDeliveryConditionsIDRef(){return deliveryConditionsIDRef_;}

       bool isDeliveryQuantity(){return this->deliveryQuantityIsNull_;}
       boost::shared_ptr<GasPhysicalQuantity> getDeliveryQuantity();
      std::string getDeliveryQuantityIDRef(){return deliveryQuantityIDRef_;}

   protected: 
       boost::shared_ptr<GasDeliveryPeriods> deliveryPeriods_;
       std::string deliveryPeriodsIDRef_;
       bool deliveryPeriodsIsNull_;
       boost::shared_ptr<GasProduct> gas_;
       std::string gasIDRef_;
       bool gasIsNull_;
       boost::shared_ptr<GasDelivery> deliveryConditions_;
       std::string deliveryConditionsIDRef_;
       bool deliveryConditionsIsNull_;
       boost::shared_ptr<GasPhysicalQuantity> deliveryQuantity_;
       std::string deliveryQuantityIDRef_;
       bool deliveryQuantityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

