// MetalPhysicalLeg.hpp 
#ifndef FpmlSerialized_MetalPhysicalLeg_hpp
#define FpmlSerialized_MetalPhysicalLeg_hpp

#include <fpml-com-5-4/PhysicalForwardLeg.hpp>
#include <fpml-com-5-4/Metal.hpp>
#include <fpml-com-5-4/CommodityDeliveryPeriods.hpp>
#include <fpml-com-5-4/MetalDelivery.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/CommodityPhysicalQuantitySchedule.hpp>
#include <fpml-com-5-4/UnitQuantity.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class MetalPhysicalLeg : public PhysicalForwardLeg { 
   public: 
       MetalPhysicalLeg(TiXmlNode* xmlNode);

       bool isMetal(){return this->metalIsNull_;}
       boost::shared_ptr<Metal> getMetal();
      std::string getMetalIDRef(){return metalIDRef_;}

       bool isDeliveryPeriods(){return this->deliveryPeriodsIsNull_;}
       boost::shared_ptr<CommodityDeliveryPeriods> getDeliveryPeriods();
      std::string getDeliveryPeriodsIDRef(){return deliveryPeriodsIDRef_;}

       bool isDeliveryConditions(){return this->deliveryConditionsIsNull_;}
       boost::shared_ptr<MetalDelivery> getDeliveryConditions();
      std::string getDeliveryConditionsIDRef(){return deliveryConditionsIDRef_;}

       bool isPhysicalQuantity(){return this->physicalQuantityIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantity> getPhysicalQuantity();
      std::string getPhysicalQuantityIDRef(){return physicalQuantityIDRef_;}

       bool isPhysicalQuantitySchedule(){return this->physicalQuantityScheduleIsNull_;}
       boost::shared_ptr<CommodityPhysicalQuantitySchedule> getPhysicalQuantitySchedule();
      std::string getPhysicalQuantityScheduleIDRef(){return physicalQuantityScheduleIDRef_;}

       bool isTotalPhysicalQuantity(){return this->totalPhysicalQuantityIsNull_;}
       boost::shared_ptr<UnitQuantity> getTotalPhysicalQuantity();
      std::string getTotalPhysicalQuantityIDRef(){return totalPhysicalQuantityIDRef_;}

       bool isConversionFactor(){return this->conversionFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getConversionFactor();
      std::string getConversionFactorIDRef(){return conversionFactorIDRef_;}

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
       boost::shared_ptr<Metal> metal_;
       std::string metalIDRef_;
       bool metalIsNull_;
       boost::shared_ptr<CommodityDeliveryPeriods> deliveryPeriods_;
       std::string deliveryPeriodsIDRef_;
       bool deliveryPeriodsIsNull_;
       boost::shared_ptr<MetalDelivery> deliveryConditions_;
       std::string deliveryConditionsIDRef_;
       bool deliveryConditionsIsNull_;
         boost::shared_ptr<CommodityNotionalQuantity> physicalQuantity_;     //choice
       std::string physicalQuantityIDRef_;
       bool physicalQuantityIsNull_;
         boost::shared_ptr<CommodityPhysicalQuantitySchedule> physicalQuantitySchedule_;     //choice
       std::string physicalQuantityScheduleIDRef_;
       bool physicalQuantityScheduleIsNull_;
       boost::shared_ptr<UnitQuantity> totalPhysicalQuantity_;
       std::string totalPhysicalQuantityIDRef_;
       bool totalPhysicalQuantityIsNull_;
       boost::shared_ptr<XsdTypeDecimal> conversionFactor_;
       std::string conversionFactorIDRef_;
       bool conversionFactorIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

