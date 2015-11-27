// Excel_counterUnderlyingCalcInfo.hpp 
#ifndef FpmlSerialized_Excel_counterUnderlyingCalcInfo_hpp
#define FpmlSerialized_Excel_counterUnderlyingCalcInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcInfo.hpp>

namespace FpmlSerialized {

class Excel_counterUnderlyingCalcInfo : public ISerialized { 
   public: 
       Excel_counterUnderlyingCalcInfo(TiXmlNode* xmlNode);

       bool isExcel_underlyingCalcInfo(){return this->excel_underlyingCalcInfoIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcInfo> getExcel_underlyingCalcInfo();


   protected: 
       boost::shared_ptr<Excel_underlyingCalcInfo> excel_underlyingCalcInfo_;
       
       bool excel_underlyingCalcInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

