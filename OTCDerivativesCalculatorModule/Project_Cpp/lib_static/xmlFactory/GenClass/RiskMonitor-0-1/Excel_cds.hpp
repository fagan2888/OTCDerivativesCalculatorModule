// Excel_cds.hpp 
#ifndef FpmlSerialized_Excel_cds_hpp
#define FpmlSerialized_Excel_cds_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_swapLeg.hpp>
#include <RiskMonitor-0-1/Excel_creditEventSwapLeg.hpp>

namespace FpmlSerialized {

class Excel_cds : public ISerialized { 
   public: 
       Excel_cds(TiXmlNode* xmlNode);

       bool isExcel_swapLeg(){return this->excel_swapLegIsNull_;}
       boost::shared_ptr<Excel_swapLeg> getExcel_swapLeg();


       bool isExcel_creditEventSwapLeg(){return this->excel_creditEventSwapLegIsNull_;}
       boost::shared_ptr<Excel_creditEventSwapLeg> getExcel_creditEventSwapLeg();


   protected: 
       boost::shared_ptr<Excel_swapLeg> excel_swapLeg_;
       
       bool excel_swapLegIsNull_;
       boost::shared_ptr<Excel_creditEventSwapLeg> excel_creditEventSwapLeg_;
       
       bool excel_creditEventSwapLegIsNull_;

};

} //namespaceFpmlSerialized end
#endif

