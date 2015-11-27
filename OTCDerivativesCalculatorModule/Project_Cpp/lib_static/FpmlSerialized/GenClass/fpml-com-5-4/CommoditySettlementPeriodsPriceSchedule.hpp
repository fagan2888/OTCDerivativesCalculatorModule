// CommoditySettlementPeriodsPriceSchedule.hpp 
#ifndef FpmlSerialized_CommoditySettlementPeriodsPriceSchedule_hpp
#define FpmlSerialized_CommoditySettlementPeriodsPriceSchedule_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/FixedPrice.hpp>
#include <fpml-com-5-4/SettlementPeriodsReference.hpp>

namespace FpmlSerialized {

class CommoditySettlementPeriodsPriceSchedule : public ISerialized { 
   public: 
       CommoditySettlementPeriodsPriceSchedule(TiXmlNode* xmlNode);

       bool isSettlementPeriodsPriceStep(){return this->settlementPeriodsPriceStepIsNull_;}
       std::vector<boost::shared_ptr<FixedPrice>> getSettlementPeriodsPriceStep();
      std::string getSettlementPeriodsPriceStepIDRef(){return settlementPeriodsPriceStepIDRef_;}

       bool isSettlementPeriodsReference(){return this->settlementPeriodsReferenceIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> getSettlementPeriodsReference();
      std::string getSettlementPeriodsReferenceIDRef(){return settlementPeriodsReferenceIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<FixedPrice>> settlementPeriodsPriceStep_;
       std::string settlementPeriodsPriceStepIDRef_;
       bool settlementPeriodsPriceStepIsNull_;
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> settlementPeriodsReference_;
       std::string settlementPeriodsReferenceIDRef_;
       bool settlementPeriodsReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

