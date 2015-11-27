// Excel_structuredBond.hpp 
#ifndef FpmlSerialized_Excel_structuredBond_hpp
#define FpmlSerialized_Excel_structuredBond_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcInfo.hpp>
#include <RiskMonitor-0-1/Excel_couponScheduleList.hpp>
#include <RiskMonitor-0-1/Excel_structuredBond_subtype.hpp>

namespace FpmlSerialized {

class Excel_structuredBond : public ISerialized { 
   public: 
       Excel_structuredBond(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isExcel_underlyingCalcInfo(){return this->excel_underlyingCalcInfoIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcInfo> getExcel_underlyingCalcInfo();


       bool isExcel_couponScheduleList(){return this->excel_couponScheduleListIsNull_;}
       boost::shared_ptr<Excel_couponScheduleList> getExcel_couponScheduleList();


       bool isExcel_structuredBond_subtype(){return this->excel_structuredBond_subtypeIsNull_;}
       boost::shared_ptr<Excel_structuredBond_subtype> getExcel_structuredBond_subtype();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       boost::shared_ptr<Excel_underlyingCalcInfo> excel_underlyingCalcInfo_;
       
       bool excel_underlyingCalcInfoIsNull_;
       boost::shared_ptr<Excel_couponScheduleList> excel_couponScheduleList_;
       
       bool excel_couponScheduleListIsNull_;
       boost::shared_ptr<Excel_structuredBond_subtype> excel_structuredBond_subtype_;
       
       bool excel_structuredBond_subtypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

