// ElectricityPhysicalLeg.hpp 
#ifndef FpmlSerialized_ElectricityPhysicalLeg_hpp
#define FpmlSerialized_ElectricityPhysicalLeg_hpp

#include <fpml-com-5-4/PhysicalSwapLeg.hpp>
#include <fpml-com-5-4/CommodityDeliveryPeriods.hpp>
#include <fpml-com-5-4/SettlementPeriods.hpp>
#include <fpml-com-5-4/SettlementPeriodsSchedule.hpp>
#include <fpml-enum-5-4/LoadTypeEnum.hpp>
#include <fpml-com-5-4/ElectricityProduct.hpp>
#include <fpml-com-5-4/ElectricityDelivery.hpp>
#include <fpml-com-5-4/ElectricityPhysicalQuantity.hpp>

namespace FpmlSerialized {

class ElectricityPhysicalLeg : public PhysicalSwapLeg { 
   public: 
       ElectricityPhysicalLeg(TiXmlNode* xmlNode);

       bool isDeliveryPeriods(){return this->deliveryPeriodsIsNull_;}
       boost::shared_ptr<CommodityDeliveryPeriods> getDeliveryPeriods();
      std::string getDeliveryPeriodsIDRef(){return deliveryPeriodsIDRef_;}

       bool isSettlementPeriods(){return this->settlementPeriodsIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriods>> getSettlementPeriods();
      std::string getSettlementPeriodsIDRef(){return settlementPeriodsIDRef_;}

       bool isSettlementPeriodsSchedule(){return this->settlementPeriodsScheduleIsNull_;}
       boost::shared_ptr<SettlementPeriodsSchedule> getSettlementPeriodsSchedule();
      std::string getSettlementPeriodsScheduleIDRef(){return settlementPeriodsScheduleIDRef_;}

       bool isLoadType(){return this->loadTypeIsNull_;}
       boost::shared_ptr<LoadTypeEnum> getLoadType();
      std::string getLoadTypeIDRef(){return loadTypeIDRef_;}

       bool isElectricity(){return this->electricityIsNull_;}
       boost::shared_ptr<ElectricityProduct> getElectricity();
      std::string getElectricityIDRef(){return electricityIDRef_;}

       bool isDeliveryConditions(){return this->deliveryConditionsIsNull_;}
       boost::shared_ptr<ElectricityDelivery> getDeliveryConditions();
      std::string getDeliveryConditionsIDRef(){return deliveryConditionsIDRef_;}

       bool isDeliveryQuantity(){return this->deliveryQuantityIsNull_;}
       boost::shared_ptr<ElectricityPhysicalQuantity> getDeliveryQuantity();
      std::string getDeliveryQuantityIDRef(){return deliveryQuantityIDRef_;}

   protected: 
       boost::shared_ptr<CommodityDeliveryPeriods> deliveryPeriods_;
       std::string deliveryPeriodsIDRef_;
       bool deliveryPeriodsIsNull_;
       std::vector<boost::shared_ptr<SettlementPeriods>> settlementPeriods_;
       std::string settlementPeriodsIDRef_;
       bool settlementPeriodsIsNull_;
       boost::shared_ptr<SettlementPeriodsSchedule> settlementPeriodsSchedule_;
       std::string settlementPeriodsScheduleIDRef_;
       bool settlementPeriodsScheduleIsNull_;
       boost::shared_ptr<LoadTypeEnum> loadType_;
       std::string loadTypeIDRef_;
       bool loadTypeIsNull_;
       boost::shared_ptr<ElectricityProduct> electricity_;
       std::string electricityIDRef_;
       bool electricityIsNull_;
       boost::shared_ptr<ElectricityDelivery> deliveryConditions_;
       std::string deliveryConditionsIDRef_;
       bool deliveryConditionsIsNull_;
       boost::shared_ptr<ElectricityPhysicalQuantity> deliveryQuantity_;
       std::string deliveryQuantityIDRef_;
       bool deliveryQuantityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

