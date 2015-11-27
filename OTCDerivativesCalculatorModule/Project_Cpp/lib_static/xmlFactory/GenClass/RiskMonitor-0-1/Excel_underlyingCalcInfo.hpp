// Excel_underlyingCalcInfo.hpp 
#ifndef FpmlSerialized_Excel_underlyingCalcInfo_hpp
#define FpmlSerialized_Excel_underlyingCalcInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_underlyingInfo.hpp>

namespace FpmlSerialized {

class Excel_underlyingCalcInfo : public ISerialized { 
   public: 
       Excel_underlyingCalcInfo(TiXmlNode* xmlNode);

       bool isExcel_underlyingInfo(){return this->excel_underlyingInfoIsNull_;}
       std::vector<boost::shared_ptr<Excel_underlyingInfo>> getExcel_underlyingInfo();


   protected: 
       std::vector<boost::shared_ptr<Excel_underlyingInfo>> excel_underlyingInfo_;
       
       bool excel_underlyingInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

