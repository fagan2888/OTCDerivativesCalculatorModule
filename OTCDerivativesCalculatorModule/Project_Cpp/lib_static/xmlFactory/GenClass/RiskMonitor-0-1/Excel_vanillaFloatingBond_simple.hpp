// Excel_vanillaFloatingBond_simple.hpp 
#ifndef FpmlSerialized_Excel_vanillaFloatingBond_simple_hpp
#define FpmlSerialized_Excel_vanillaFloatingBond_simple_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_vanillaFloatingBond_subSchedule.hpp>

namespace FpmlSerialized {

class Excel_vanillaFloatingBond_simple : public ISerialized { 
   public: 
       Excel_vanillaFloatingBond_simple(TiXmlNode* xmlNode);

       bool isMaturity(){return this->maturityIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturity();


       bool isMaturityPeriod(){return this->maturityPeriodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturityPeriod();


       bool isCouponTenor(){return this->couponTenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCouponTenor();


       bool isCouponTenorPeriod(){return this->couponTenorPeriodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCouponTenorPeriod();


       bool isExcel_vanillaFloatingBond_subSchedule(){return this->excel_vanillaFloatingBond_subScheduleIsNull_;}
       std::vector<boost::shared_ptr<Excel_vanillaFloatingBond_subSchedule>> getExcel_vanillaFloatingBond_subSchedule();


       bool isGearing(){return this->gearingIsNull_;}
       boost::shared_ptr<XsdTypeToken> getGearing();


       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSpread();


       bool isSettlementDays(){return this->settlementDaysIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSettlementDays();


   protected: 
       boost::shared_ptr<XsdTypeToken> maturity_;
       
       bool maturityIsNull_;
       boost::shared_ptr<XsdTypeToken> maturityPeriod_;
       
       bool maturityPeriodIsNull_;
       boost::shared_ptr<XsdTypeToken> couponTenor_;
       
       bool couponTenorIsNull_;
       boost::shared_ptr<XsdTypeToken> couponTenorPeriod_;
       
       bool couponTenorPeriodIsNull_;
       std::vector<boost::shared_ptr<Excel_vanillaFloatingBond_subSchedule>> excel_vanillaFloatingBond_subSchedule_;
       
       bool excel_vanillaFloatingBond_subScheduleIsNull_;
       boost::shared_ptr<XsdTypeToken> gearing_;
       
       bool gearingIsNull_;
       boost::shared_ptr<XsdTypeToken> spread_;
       
       bool spreadIsNull_;
       boost::shared_ptr<XsdTypeToken> settlementDays_;
       
       bool settlementDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

