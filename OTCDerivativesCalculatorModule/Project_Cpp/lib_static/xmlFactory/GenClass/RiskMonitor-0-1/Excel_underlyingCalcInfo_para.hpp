// Excel_underlyingCalcInfo_para.hpp 
#ifndef FpmlSerialized_Excel_underlyingCalcInfo_para_hpp
#define FpmlSerialized_Excel_underlyingCalcInfo_para_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_underlyingInfo_para.hpp>
#include <RiskMonitor-0-1/Excel_correlationInfo_para.hpp>

namespace FpmlSerialized {

class Excel_underlyingCalcInfo_para : public ISerialized { 
   public: 
       Excel_underlyingCalcInfo_para(TiXmlNode* xmlNode);

       bool isExcel_underlyingInfo_para(){return this->excel_underlyingInfo_paraIsNull_;}
       std::vector<boost::shared_ptr<Excel_underlyingInfo_para>> getExcel_underlyingInfo_para();


       bool isExcel_correlationInfo_para(){return this->excel_correlationInfo_paraIsNull_;}
       boost::shared_ptr<Excel_correlationInfo_para> getExcel_correlationInfo_para();


   protected: 
       std::vector<boost::shared_ptr<Excel_underlyingInfo_para>> excel_underlyingInfo_para_;
       
       bool excel_underlyingInfo_paraIsNull_;
       boost::shared_ptr<Excel_correlationInfo_para> excel_correlationInfo_para_;
       
       bool excel_correlationInfo_paraIsNull_;

};

} //namespaceFpmlSerialized end
#endif

