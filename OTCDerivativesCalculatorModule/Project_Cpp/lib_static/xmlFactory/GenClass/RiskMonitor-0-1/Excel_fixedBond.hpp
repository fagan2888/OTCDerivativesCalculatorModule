// Excel_fixedBond.hpp 
#ifndef FpmlSerialized_Excel_fixedBond_hpp
#define FpmlSerialized_Excel_fixedBond_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Excel_fixedCouponScheduleList.hpp>
#include <RiskMonitor-0-1/Excel_fixedBond_subtype.hpp>

namespace FpmlSerialized {

class Excel_fixedBond : public ISerialized { 
   public: 
       Excel_fixedBond(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isExcel_fixedCouponScheduleList(){return this->excel_fixedCouponScheduleListIsNull_;}
       boost::shared_ptr<Excel_fixedCouponScheduleList> getExcel_fixedCouponScheduleList();


       bool isExcel_fixedBond_subtype(){return this->excel_fixedBond_subtypeIsNull_;}
       boost::shared_ptr<Excel_fixedBond_subtype> getExcel_fixedBond_subtype();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       boost::shared_ptr<Excel_fixedCouponScheduleList> excel_fixedCouponScheduleList_;
       
       bool excel_fixedCouponScheduleListIsNull_;
       boost::shared_ptr<Excel_fixedBond_subtype> excel_fixedBond_subtype_;
       
       bool excel_fixedBond_subtypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

