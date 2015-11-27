// Excel_fixedBond_constantRate.hpp 
#ifndef FpmlSerialized_Excel_fixedBond_constantRate_hpp
#define FpmlSerialized_Excel_fixedBond_constantRate_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_fixedBond_subSchedule.hpp>

namespace FpmlSerialized {

class Excel_fixedBond_constantRate : public ISerialized { 
   public: 
       Excel_fixedBond_constantRate(TiXmlNode* xmlNode);

       bool isMaturity(){return this->maturityIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturity();


       bool isMaturityPeriod(){return this->maturityPeriodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturityPeriod();


       bool isCouponTenor(){return this->couponTenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCouponTenor();


       bool isCouponTenorPeriod(){return this->couponTenorPeriodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCouponTenorPeriod();


       bool isExcel_fixedBond_subSchedule(){return this->excel_fixedBond_subScheduleIsNull_;}
       std::vector<boost::shared_ptr<Excel_fixedBond_subSchedule>> getExcel_fixedBond_subSchedule();


       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixedRate();


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
       std::vector<boost::shared_ptr<Excel_fixedBond_subSchedule>> excel_fixedBond_subSchedule_;
       
       bool excel_fixedBond_subScheduleIsNull_;
       boost::shared_ptr<XsdTypeToken> fixedRate_;
       
       bool fixedRateIsNull_;
       boost::shared_ptr<XsdTypeToken> settlementDays_;
       
       bool settlementDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

