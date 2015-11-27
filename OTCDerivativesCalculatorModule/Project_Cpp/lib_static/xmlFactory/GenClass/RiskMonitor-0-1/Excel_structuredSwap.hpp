// Excel_structuredSwap.hpp 
#ifndef FpmlSerialized_Excel_structuredSwap_hpp
#define FpmlSerialized_Excel_structuredSwap_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Excel_swapLeg.hpp>

namespace FpmlSerialized {

class Excel_structuredSwap : public ISerialized { 
   public: 
       Excel_structuredSwap(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isExcel_swapLeg(){return this->excel_swapLegIsNull_;}
       std::vector<boost::shared_ptr<Excel_swapLeg>> getExcel_swapLeg();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       std::vector<boost::shared_ptr<Excel_swapLeg>> excel_swapLeg_;
       
       bool excel_swapLegIsNull_;

};

} //namespaceFpmlSerialized end
#endif

