// Excel_vanillaFloatingCouponScheduleList.hpp 
#ifndef FpmlSerialized_Excel_vanillaFloatingCouponScheduleList_hpp
#define FpmlSerialized_Excel_vanillaFloatingCouponScheduleList_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_vanillaFloatingCouponSchedule.hpp>

namespace FpmlSerialized {

class Excel_vanillaFloatingCouponScheduleList : public ISerialized { 
   public: 
       Excel_vanillaFloatingCouponScheduleList(TiXmlNode* xmlNode);

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixedRate();


       bool isDayCounter(){return this->dayCounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayCounter();


       bool isExcel_vanillaFloatingCouponSchedule(){return this->excel_vanillaFloatingCouponScheduleIsNull_;}
       std::vector<boost::shared_ptr<Excel_vanillaFloatingCouponSchedule>> getExcel_vanillaFloatingCouponSchedule();


   protected: 
       boost::shared_ptr<XsdTypeToken> fixedRate_;
       
       bool fixedRateIsNull_;
       boost::shared_ptr<XsdTypeToken> dayCounter_;
       
       bool dayCounterIsNull_;
       std::vector<boost::shared_ptr<Excel_vanillaFloatingCouponSchedule>> excel_vanillaFloatingCouponSchedule_;
       
       bool excel_vanillaFloatingCouponScheduleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

