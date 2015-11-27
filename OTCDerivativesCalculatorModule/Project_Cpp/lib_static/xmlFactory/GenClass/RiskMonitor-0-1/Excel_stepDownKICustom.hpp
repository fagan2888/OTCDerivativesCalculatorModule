// Excel_stepDownKICustom.hpp 
#ifndef FpmlSerialized_Excel_stepDownKICustom_hpp
#define FpmlSerialized_Excel_stepDownKICustom_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcInfo.hpp>
#include <RiskMonitor-0-1/Excel_hifive_subtype.hpp>

namespace FpmlSerialized {

class Excel_stepDownKICustom : public ISerialized { 
   public: 
       Excel_stepDownKICustom(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isExcel_underlyingCalcInfo(){return this->excel_underlyingCalcInfoIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcInfo> getExcel_underlyingCalcInfo();


       bool isExcel_hifive_subtype(){return this->excel_hifive_subtypeIsNull_;}
       boost::shared_ptr<Excel_hifive_subtype> getExcel_hifive_subtype();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       boost::shared_ptr<Excel_underlyingCalcInfo> excel_underlyingCalcInfo_;
       
       bool excel_underlyingCalcInfoIsNull_;
       boost::shared_ptr<Excel_hifive_subtype> excel_hifive_subtype_;
       
       bool excel_hifive_subtypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

