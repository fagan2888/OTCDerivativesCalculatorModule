// CommoditySettlementPeriodsNotionalQuantitySchedule.hpp 
#ifndef FpmlSerialized_CommoditySettlementPeriodsNotionalQuantitySchedule_hpp
#define FpmlSerialized_CommoditySettlementPeriodsNotionalQuantitySchedule_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/SettlementPeriodsReference.hpp>

namespace FpmlSerialized {

class CommoditySettlementPeriodsNotionalQuantitySchedule : public ISerialized { 
   public: 
       CommoditySettlementPeriodsNotionalQuantitySchedule(TiXmlNode* xmlNode);

       bool isSettlementPeriodsNotionalQuantityStep(){return this->settlementPeriodsNotionalQuantityStepIsNull_;}
       std::vector<boost::shared_ptr<CommodityNotionalQuantity>> getSettlementPeriodsNotionalQuantityStep();
      std::string getSettlementPeriodsNotionalQuantityStepIDRef(){return settlementPeriodsNotionalQuantityStepIDRef_;}

       bool isSettlementPeriodsReference(){return this->settlementPeriodsReferenceIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> getSettlementPeriodsReference();
      std::string getSettlementPeriodsReferenceIDRef(){return settlementPeriodsReferenceIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<CommodityNotionalQuantity>> settlementPeriodsNotionalQuantityStep_;
       std::string settlementPeriodsNotionalQuantityStepIDRef_;
       bool settlementPeriodsNotionalQuantityStepIsNull_;
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> settlementPeriodsReference_;
       std::string settlementPeriodsReferenceIDRef_;
       bool settlementPeriodsReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

