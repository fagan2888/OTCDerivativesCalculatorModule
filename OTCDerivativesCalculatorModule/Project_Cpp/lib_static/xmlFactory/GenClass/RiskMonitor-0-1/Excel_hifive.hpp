// Excel_hifive.hpp 
#ifndef FpmlSerialized_Excel_hifive_hpp
#define FpmlSerialized_Excel_hifive_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcInfo.hpp>
#include <RiskMonitor-0-1/Excel_hifive_subtype.hpp>
#include <RiskMonitor-0-1/Excel_scheduleList.hpp>
#include <RiskMonitor-0-1/Excel_kiEventCalculation.hpp>

namespace FpmlSerialized {

class Excel_hifive : public ISerialized { 
   public: 
       Excel_hifive(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isExcel_underlyingCalcInfo(){return this->excel_underlyingCalcInfoIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcInfo> getExcel_underlyingCalcInfo();


       bool isExcel_hifive_subtype(){return this->excel_hifive_subtypeIsNull_;}
       boost::shared_ptr<Excel_hifive_subtype> getExcel_hifive_subtype();


       bool isExcel_scheduleList(){return this->excel_scheduleListIsNull_;}
       boost::shared_ptr<Excel_scheduleList> getExcel_scheduleList();


       bool isExcel_kiEventCalculation(){return this->excel_kiEventCalculationIsNull_;}
       boost::shared_ptr<Excel_kiEventCalculation> getExcel_kiEventCalculation();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       boost::shared_ptr<Excel_underlyingCalcInfo> excel_underlyingCalcInfo_;
       
       bool excel_underlyingCalcInfoIsNull_;
       boost::shared_ptr<Excel_hifive_subtype> excel_hifive_subtype_;
       
       bool excel_hifive_subtypeIsNull_;
       boost::shared_ptr<Excel_scheduleList> excel_scheduleList_;
       
       bool excel_scheduleListIsNull_;
       boost::shared_ptr<Excel_kiEventCalculation> excel_kiEventCalculation_;
       
       bool excel_kiEventCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

