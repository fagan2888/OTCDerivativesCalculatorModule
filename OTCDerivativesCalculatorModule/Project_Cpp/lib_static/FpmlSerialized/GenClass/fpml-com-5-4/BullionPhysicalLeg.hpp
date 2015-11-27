// BullionPhysicalLeg.hpp 
#ifndef FpmlSerialized_BullionPhysicalLeg_hpp
#define FpmlSerialized_BullionPhysicalLeg_hpp

#include <fpml-com-5-4/PhysicalForwardLeg.hpp>
#include <fpml-enum-5-4/BullionTypeEnum.hpp>
#include <fpml-com-5-4/BullionDeliveryLocation.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/CommodityPhysicalQuantitySchedule.hpp>
#include <fpml-com-5-4/UnitQuantity.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class BullionPhysicalLeg : public PhysicalForwardLeg { 
   public: 
       BullionPhysicalLeg(TiXmlNode* xmlNode);

       bool isBullionType(){return this->bullionTypeIsNull_;}
       boost::shared_ptr<BullionTypeEnum> getBullionType();
      std::string getBullionTypeIDRef(){return bullionTypeIDRef_;}

       bool isDeliveryLocation(){return this->deliveryLocationIsNull_;}
       boost::shared_ptr<BullionDeliveryLocation> getDeliveryLocation();
      std::string getDeliveryLocationIDRef(){return deliveryLocationIDRef_;}

       bool isPhysicalQuantity(){return this->physicalQuantityIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantity> getPhysicalQuantity();
      std::string getPhysicalQuantityIDRef(){return physicalQuantityIDRef_;}

       bool isPhysicalQuantitySchedule(){return this->physicalQuantityScheduleIsNull_;}
       boost::shared_ptr<CommodityPhysicalQuantitySchedule> getPhysicalQuantitySchedule();
      std::string getPhysicalQuantityScheduleIDRef(){return physicalQuantityScheduleIDRef_;}

       bool isTotalPhysicalQuantity(){return this->totalPhysicalQuantityIsNull_;}
       boost::shared_ptr<UnitQuantity> getTotalPhysicalQuantity();
      std::string getTotalPhysicalQuantityIDRef(){return totalPhysicalQuantityIDRef_;}

       bool isSettlementDate(){return this->settlementDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getSettlementDate();
      std::string getSettlementDateIDRef(){return settlementDateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!physicalQuantityIsNull_){
                count += 1;
                str = "physicalQuantity" ;
           }
           if(!physicalQuantityScheduleIsNull_){
                count += 1;
                str = "physicalQuantitySchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<BullionTypeEnum> bullionType_;
       std::string bullionTypeIDRef_;
       bool bullionTypeIsNull_;
       boost::shared_ptr<BullionDeliveryLocation> deliveryLocation_;
       std::string deliveryLocationIDRef_;
       bool deliveryLocationIsNull_;
         boost::shared_ptr<CommodityNotionalQuantity> physicalQuantity_;     //choice
       std::string physicalQuantityIDRef_;
       bool physicalQuantityIsNull_;
         boost::shared_ptr<CommodityPhysicalQuantitySchedule> physicalQuantitySchedule_;     //choice
       std::string physicalQuantityScheduleIDRef_;
       bool physicalQuantityScheduleIsNull_;
       boost::shared_ptr<UnitQuantity> totalPhysicalQuantity_;
       std::string totalPhysicalQuantityIDRef_;
       bool totalPhysicalQuantityIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> settlementDate_;
       std::string settlementDateIDRef_;
       bool settlementDateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

