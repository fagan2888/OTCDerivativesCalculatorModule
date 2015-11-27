// ElectricityDeliveryPeriods.hpp 
#ifndef FpmlSerialized_ElectricityDeliveryPeriods_hpp
#define FpmlSerialized_ElectricityDeliveryPeriods_hpp

#include <fpml-com-5-4/CommodityDeliveryPeriods.hpp>
#include <fpml-com-5-4/SettlementPeriods.hpp>

namespace FpmlSerialized {

class ElectricityDeliveryPeriods : public CommodityDeliveryPeriods { 
   public: 
       ElectricityDeliveryPeriods(TiXmlNode* xmlNode);

       bool isSettlementPeriods(){return this->settlementPeriodsIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriods>> getSettlementPeriods();
      std::string getSettlementPeriodsIDRef(){return settlementPeriodsIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<SettlementPeriods>> settlementPeriods_;
       std::string settlementPeriodsIDRef_;
       bool settlementPeriodsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

