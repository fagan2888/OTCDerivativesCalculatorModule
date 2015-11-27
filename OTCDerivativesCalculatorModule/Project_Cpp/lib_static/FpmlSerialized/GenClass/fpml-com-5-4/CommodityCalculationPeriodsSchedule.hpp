// CommodityCalculationPeriodsSchedule.hpp 
#ifndef FpmlSerialized_CommodityCalculationPeriodsSchedule_hpp
#define FpmlSerialized_CommodityCalculationPeriodsSchedule_hpp

#include <fpml-shared-5-4/Frequency.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class CommodityCalculationPeriodsSchedule : public Frequency { 
   public: 
       CommodityCalculationPeriodsSchedule(TiXmlNode* xmlNode);

       bool isBalanceOfFirstPeriod(){return this->balanceOfFirstPeriodIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getBalanceOfFirstPeriod();
      std::string getBalanceOfFirstPeriodIDRef(){return balanceOfFirstPeriodIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> balanceOfFirstPeriod_;
       std::string balanceOfFirstPeriodIDRef_;
       bool balanceOfFirstPeriodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

