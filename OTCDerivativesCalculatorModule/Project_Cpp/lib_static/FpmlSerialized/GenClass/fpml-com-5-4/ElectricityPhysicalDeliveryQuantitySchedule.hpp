// ElectricityPhysicalDeliveryQuantitySchedule.hpp 
#ifndef FpmlSerialized_ElectricityPhysicalDeliveryQuantitySchedule_hpp
#define FpmlSerialized_ElectricityPhysicalDeliveryQuantitySchedule_hpp

#include <fpml-com-5-4/CommodityPhysicalQuantitySchedule.hpp>
#include <fpml-com-5-4/SettlementPeriodsReference.hpp>

namespace FpmlSerialized {

class ElectricityPhysicalDeliveryQuantitySchedule : public CommodityPhysicalQuantitySchedule { 
   public: 
       ElectricityPhysicalDeliveryQuantitySchedule(TiXmlNode* xmlNode);

       bool isSettlementPeriodsReference(){return this->settlementPeriodsReferenceIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> getSettlementPeriodsReference();
      std::string getSettlementPeriodsReferenceIDRef(){return settlementPeriodsReferenceIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> settlementPeriodsReference_;
       std::string settlementPeriodsReferenceIDRef_;
       bool settlementPeriodsReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

