// Excel_irs.hpp 
#ifndef FpmlSerialized_Excel_irs_hpp
#define FpmlSerialized_Excel_irs_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_swapLeg.hpp>

namespace FpmlSerialized {

class Excel_irs : public ISerialized { 
   public: 
       Excel_irs(TiXmlNode* xmlNode);

       bool isExcel_swapLeg(){return this->excel_swapLegIsNull_;}
       std::vector<boost::shared_ptr<Excel_swapLeg>> getExcel_swapLeg();


   protected: 
       std::vector<boost::shared_ptr<Excel_swapLeg>> excel_swapLeg_;
       
       bool excel_swapLegIsNull_;

};

} //namespaceFpmlSerialized end
#endif

