// ElectricityPhysicalQuantity.hpp 
#ifndef FpmlSerialized_ElectricityPhysicalQuantity_hpp
#define FpmlSerialized_ElectricityPhysicalQuantity_hpp

#include <fpml-com-5-4/CommodityPhysicalQuantityBase.hpp>
#include <fpml-com-5-4/ElectricityPhysicalDeliveryQuantity.hpp>
#include <fpml-com-5-4/ElectricityPhysicalDeliveryQuantitySchedule.hpp>
#include <fpml-com-5-4/UnitQuantity.hpp>

namespace FpmlSerialized {

class ElectricityPhysicalQuantity : public CommodityPhysicalQuantityBase { 
   public: 
       ElectricityPhysicalQuantity(TiXmlNode* xmlNode);

       bool isPhysicalQuantity(){return this->physicalQuantityIsNull_;}
       std::vector<boost::shared_ptr<ElectricityPhysicalDeliveryQuantity>> getPhysicalQuantity();
      std::string getPhysicalQuantityIDRef(){return physicalQuantityIDRef_;}

       bool isPhysicalQuantitySchedule(){return this->physicalQuantityScheduleIsNull_;}
       std::vector<boost::shared_ptr<ElectricityPhysicalDeliveryQuantitySchedule>> getPhysicalQuantitySchedule();
      std::string getPhysicalQuantityScheduleIDRef(){return physicalQuantityScheduleIDRef_;}

       bool isTotalPhysicalQuantity(){return this->totalPhysicalQuantityIsNull_;}
       boost::shared_ptr<UnitQuantity> getTotalPhysicalQuantity();
      std::string getTotalPhysicalQuantityIDRef(){return totalPhysicalQuantityIDRef_;}

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
         std::vector<boost::shared_ptr<ElectricityPhysicalDeliveryQuantity>> physicalQuantity_;     //choice
       std::string physicalQuantityIDRef_;
       bool physicalQuantityIsNull_;
         std::vector<boost::shared_ptr<ElectricityPhysicalDeliveryQuantitySchedule>> physicalQuantitySchedule_;     //choice
       std::string physicalQuantityScheduleIDRef_;
       bool physicalQuantityScheduleIsNull_;
       boost::shared_ptr<UnitQuantity> totalPhysicalQuantity_;
       std::string totalPhysicalQuantityIDRef_;
       bool totalPhysicalQuantityIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

