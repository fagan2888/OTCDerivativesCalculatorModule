// Excel_eventCalcInfo_Call.hpp 
#ifndef FpmlSerialized_Excel_eventCalcInfo_Call_hpp
#define FpmlSerialized_Excel_eventCalcInfo_Call_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_eventCalcInfo.hpp>

namespace FpmlSerialized {

class Excel_eventCalcInfo_Call : public ISerialized { 
   public: 
       Excel_eventCalcInfo_Call(TiXmlNode* xmlNode);

       bool isExcel_eventCalcInfo(){return this->excel_eventCalcInfoIsNull_;}
       boost::shared_ptr<Excel_eventCalcInfo> getExcel_eventCalcInfo();


   protected: 
       boost::shared_ptr<Excel_eventCalcInfo> excel_eventCalcInfo_;
       
       bool excel_eventCalcInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

