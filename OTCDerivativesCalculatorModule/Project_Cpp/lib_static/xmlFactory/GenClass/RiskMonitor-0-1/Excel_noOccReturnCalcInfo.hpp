// Excel_noOccReturnCalcInfo.hpp 
#ifndef FpmlSerialized_Excel_noOccReturnCalcInfo_hpp
#define FpmlSerialized_Excel_noOccReturnCalcInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_returnCalcInfo.hpp>

namespace FpmlSerialized {

class Excel_noOccReturnCalcInfo : public ISerialized { 
   public: 
       Excel_noOccReturnCalcInfo(TiXmlNode* xmlNode);

       bool isExcel_returnCalcInfo(){return this->excel_returnCalcInfoIsNull_;}
       boost::shared_ptr<Excel_returnCalcInfo> getExcel_returnCalcInfo();


   protected: 
       boost::shared_ptr<Excel_returnCalcInfo> excel_returnCalcInfo_;
       
       bool excel_returnCalcInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

