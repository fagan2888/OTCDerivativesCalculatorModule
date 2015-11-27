// Excel_valueResult.hpp 
#ifndef FpmlSerialized_Excel_valueResult_hpp
#define FpmlSerialized_Excel_valueResult_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_valueSideResult.hpp>

namespace FpmlSerialized {

class Excel_valueResult : public ISerialized { 
   public: 
       Excel_valueResult(TiXmlNode* xmlNode);

       bool isExcel_valueSideResult(){return this->excel_valueSideResultIsNull_;}
       std::vector<boost::shared_ptr<Excel_valueSideResult>> getExcel_valueSideResult();


   protected: 
       std::vector<boost::shared_ptr<Excel_valueSideResult>> excel_valueSideResult_;
       
       bool excel_valueSideResultIsNull_;

};

} //namespaceFpmlSerialized end
#endif

