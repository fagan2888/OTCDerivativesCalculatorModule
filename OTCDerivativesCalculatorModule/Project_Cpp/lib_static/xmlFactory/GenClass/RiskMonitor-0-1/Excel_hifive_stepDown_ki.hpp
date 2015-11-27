// Excel_hifive_stepDown_ki.hpp 
#ifndef FpmlSerialized_Excel_hifive_stepDown_ki_hpp
#define FpmlSerialized_Excel_hifive_stepDown_ki_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_stepDownKI_subSchedule.hpp>

namespace FpmlSerialized {

class Excel_hifive_stepDown_ki : public ISerialized { 
   public: 
       Excel_hifive_stepDown_ki(TiXmlNode* xmlNode);

       bool isUnderlyingCalcType(){return this->underlyingCalcTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderlyingCalcType();


       bool isMaturity(){return this->maturityIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturity();


       bool isMaturityPeriod(){return this->maturityPeriodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturityPeriod();


       bool isCouponTenor(){return this->couponTenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCouponTenor();


       bool isCouponTenorPeriod(){return this->couponTenorPeriodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCouponTenorPeriod();


       bool isExcel_stepDownKI_subSchedule(){return this->excel_stepDownKI_subScheduleIsNull_;}
       std::vector<boost::shared_ptr<Excel_stepDownKI_subSchedule>> getExcel_stepDownKI_subSchedule();


       bool isCoupon(){return this->couponIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCoupon();


       bool isKi(){return this->kiIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKi();


       bool isKiObStartDate(){return this->kiObStartDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKiObStartDate();


       bool isKiObEndDate(){return this->kiObEndDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKiObEndDate();


       bool isSettlementDays(){return this->settlementDaysIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSettlementDays();


   protected: 
       boost::shared_ptr<XsdTypeToken> underlyingCalcType_;
       
       bool underlyingCalcTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> maturity_;
       
       bool maturityIsNull_;
       boost::shared_ptr<XsdTypeToken> maturityPeriod_;
       
       bool maturityPeriodIsNull_;
       boost::shared_ptr<XsdTypeToken> couponTenor_;
       
       bool couponTenorIsNull_;
       boost::shared_ptr<XsdTypeToken> couponTenorPeriod_;
       
       bool couponTenorPeriodIsNull_;
       std::vector<boost::shared_ptr<Excel_stepDownKI_subSchedule>> excel_stepDownKI_subSchedule_;
       
       bool excel_stepDownKI_subScheduleIsNull_;
       boost::shared_ptr<XsdTypeToken> coupon_;
       
       bool couponIsNull_;
       boost::shared_ptr<XsdTypeToken> ki_;
       
       bool kiIsNull_;
       boost::shared_ptr<XsdTypeToken> kiObStartDate_;
       
       bool kiObStartDateIsNull_;
       boost::shared_ptr<XsdTypeToken> kiObEndDate_;
       
       bool kiObEndDateIsNull_;
       boost::shared_ptr<XsdTypeToken> settlementDays_;
       
       bool settlementDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

