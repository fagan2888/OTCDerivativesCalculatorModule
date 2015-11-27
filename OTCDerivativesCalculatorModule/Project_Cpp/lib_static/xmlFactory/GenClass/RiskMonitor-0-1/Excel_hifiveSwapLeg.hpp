// Excel_hifiveSwapLeg.hpp 
#ifndef FpmlSerialized_Excel_hifiveSwapLeg_hpp
#define FpmlSerialized_Excel_hifiveSwapLeg_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_swapLegInfo.hpp>
#include <RiskMonitor-0-1/Excel_interface.hpp>

namespace FpmlSerialized {

class Excel_hifiveSwapLeg : public ISerialized { 
   public: 
       Excel_hifiveSwapLeg(TiXmlNode* xmlNode);

       bool isExcel_swapLegInfo(){return this->excel_swapLegInfoIsNull_;}
       boost::shared_ptr<Excel_swapLegInfo> getExcel_swapLegInfo();


       bool isExcel_interface(){return this->excel_interfaceIsNull_;}
       boost::shared_ptr<Excel_interface> getExcel_interface();


   protected: 
       boost::shared_ptr<Excel_swapLegInfo> excel_swapLegInfo_;
       
       bool excel_swapLegInfoIsNull_;
       boost::shared_ptr<Excel_interface> excel_interface_;
       
       bool excel_interfaceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

