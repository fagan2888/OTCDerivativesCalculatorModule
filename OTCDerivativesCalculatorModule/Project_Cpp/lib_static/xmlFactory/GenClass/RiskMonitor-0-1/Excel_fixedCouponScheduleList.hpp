// Excel_fixedCouponScheduleList.hpp 
#ifndef FpmlSerialized_Excel_fixedCouponScheduleList_hpp
#define FpmlSerialized_Excel_fixedCouponScheduleList_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_couponSchedule.hpp>

namespace FpmlSerialized {

class Excel_fixedCouponScheduleList : public ISerialized { 
   public: 
       Excel_fixedCouponScheduleList(TiXmlNode* xmlNode);

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixedRate();


       bool isDayCounter(){return this->dayCounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayCounter();


       bool isExcel_couponSchedule(){return this->excel_couponScheduleIsNull_;}
       std::vector<boost::shared_ptr<Excel_couponSchedule>> getExcel_couponSchedule();


   protected: 
       boost::shared_ptr<XsdTypeToken> fixedRate_;
       
       bool fixedRateIsNull_;
       boost::shared_ptr<XsdTypeToken> dayCounter_;
       
       bool dayCounterIsNull_;
       std::vector<boost::shared_ptr<Excel_couponSchedule>> excel_couponSchedule_;
       
       bool excel_couponScheduleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

