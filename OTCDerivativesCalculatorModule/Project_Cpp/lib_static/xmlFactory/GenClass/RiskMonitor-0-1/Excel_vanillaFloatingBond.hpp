// Excel_vanillaFloatingBond.hpp 
#ifndef FpmlSerialized_Excel_vanillaFloatingBond_hpp
#define FpmlSerialized_Excel_vanillaFloatingBond_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcInfo.hpp>
#include <RiskMonitor-0-1/Excel_vanillaFloatingCouponScheduleList.hpp>
#include <RiskMonitor-0-1/Excel_vanillaFloatingBond_subtype.hpp>

namespace FpmlSerialized {

class Excel_vanillaFloatingBond : public ISerialized { 
   public: 
       Excel_vanillaFloatingBond(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isExcel_underlyingCalcInfo(){return this->excel_underlyingCalcInfoIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcInfo> getExcel_underlyingCalcInfo();


       bool isExcel_vanillaFloatingCouponScheduleList(){return this->excel_vanillaFloatingCouponScheduleListIsNull_;}
       boost::shared_ptr<Excel_vanillaFloatingCouponScheduleList> getExcel_vanillaFloatingCouponScheduleList();


       bool isExcel_vanillaFloatingBond_subtype(){return this->excel_vanillaFloatingBond_subtypeIsNull_;}
       boost::shared_ptr<Excel_vanillaFloatingBond_subtype> getExcel_vanillaFloatingBond_subtype();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       boost::shared_ptr<Excel_underlyingCalcInfo> excel_underlyingCalcInfo_;
       
       bool excel_underlyingCalcInfoIsNull_;
       boost::shared_ptr<Excel_vanillaFloatingCouponScheduleList> excel_vanillaFloatingCouponScheduleList_;
       
       bool excel_vanillaFloatingCouponScheduleListIsNull_;
       boost::shared_ptr<Excel_vanillaFloatingBond_subtype> excel_vanillaFloatingBond_subtype_;
       
       bool excel_vanillaFloatingBond_subtypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

