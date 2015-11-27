// Excel_cashFlowsResult.hpp 
#ifndef FpmlSerialized_Excel_cashFlowsResult_hpp
#define FpmlSerialized_Excel_cashFlowsResult_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_cashFlowResult.hpp>

namespace FpmlSerialized {

class Excel_cashFlowsResult : public ISerialized { 
   public: 
       Excel_cashFlowsResult(TiXmlNode* xmlNode);

       bool isExcel_cashFlowResult(){return this->excel_cashFlowResultIsNull_;}
       std::vector<boost::shared_ptr<Excel_cashFlowResult>> getExcel_cashFlowResult();


   protected: 
       std::vector<boost::shared_ptr<Excel_cashFlowResult>> excel_cashFlowResult_;
       
       bool excel_cashFlowResultIsNull_;

};

} //namespaceFpmlSerialized end
#endif

