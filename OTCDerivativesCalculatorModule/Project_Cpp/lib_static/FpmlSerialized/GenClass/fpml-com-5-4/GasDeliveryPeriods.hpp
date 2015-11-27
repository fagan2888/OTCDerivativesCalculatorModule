// GasDeliveryPeriods.hpp 
#ifndef FpmlSerialized_GasDeliveryPeriods_hpp
#define FpmlSerialized_GasDeliveryPeriods_hpp

#include <fpml-com-5-4/CommodityDeliveryPeriods.hpp>
#include <fpml-shared-5-4/PrevailingTime.hpp>

namespace FpmlSerialized {

class GasDeliveryPeriods : public CommodityDeliveryPeriods { 
   public: 
       GasDeliveryPeriods(TiXmlNode* xmlNode);

       bool isSupplyStartTime(){return this->supplyStartTimeIsNull_;}
       boost::shared_ptr<PrevailingTime> getSupplyStartTime();
      std::string getSupplyStartTimeIDRef(){return supplyStartTimeIDRef_;}

       bool isSupplyEndTime(){return this->supplyEndTimeIsNull_;}
       boost::shared_ptr<PrevailingTime> getSupplyEndTime();
      std::string getSupplyEndTimeIDRef(){return supplyEndTimeIDRef_;}

   protected: 
       boost::shared_ptr<PrevailingTime> supplyStartTime_;
       std::string supplyStartTimeIDRef_;
       bool supplyStartTimeIsNull_;
       boost::shared_ptr<PrevailingTime> supplyEndTime_;
       std::string supplyEndTimeIDRef_;
       bool supplyEndTimeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

