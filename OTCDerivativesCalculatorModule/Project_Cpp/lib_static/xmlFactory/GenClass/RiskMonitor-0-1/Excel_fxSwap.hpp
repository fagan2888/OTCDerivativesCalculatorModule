// Excel_fxSwap.hpp 
#ifndef FpmlSerialized_Excel_fxSwap_hpp
#define FpmlSerialized_Excel_fxSwap_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Fx_exchangeLeg.hpp>

namespace FpmlSerialized {

class Excel_fxSwap : public ISerialized { 
   public: 
       Excel_fxSwap(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isFx_exchangeLeg(){return this->fx_exchangeLegIsNull_;}
       std::vector<boost::shared_ptr<Fx_exchangeLeg>> getFx_exchangeLeg();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       std::vector<boost::shared_ptr<Fx_exchangeLeg>> fx_exchangeLeg_;
       
       bool fx_exchangeLegIsNull_;

};

} //namespaceFpmlSerialized end
#endif

