// Excel_creditEventSwapLeg.hpp 
#ifndef FpmlSerialized_Excel_creditEventSwapLeg_hpp
#define FpmlSerialized_Excel_creditEventSwapLeg_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_creditEventInfo.hpp>

namespace FpmlSerialized {

class Excel_creditEventSwapLeg : public ISerialized { 
   public: 
       Excel_creditEventSwapLeg(TiXmlNode* xmlNode);

       bool isExcel_creditEventInfo(){return this->excel_creditEventInfoIsNull_;}
       boost::shared_ptr<Excel_creditEventInfo> getExcel_creditEventInfo();


   protected: 
       boost::shared_ptr<Excel_creditEventInfo> excel_creditEventInfo_;
       
       bool excel_creditEventInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

