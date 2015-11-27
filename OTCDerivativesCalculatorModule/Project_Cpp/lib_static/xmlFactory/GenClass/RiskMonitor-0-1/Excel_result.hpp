// Excel_result.hpp 
#ifndef FpmlSerialized_Excel_result_hpp
#define FpmlSerialized_Excel_result_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <RiskMonitor-0-1/Excel_valueResult.hpp>
#include <RiskMonitor-0-1/Excel_greekResult.hpp>
#include <RiskMonitor-0-1/Excel_cashFlowsResult.hpp>

namespace FpmlSerialized {

class Excel_result : public ISerialized { 
   public: 
       Excel_result(TiXmlNode* xmlNode);

       bool isCalculationDate(){return this->calculationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationDate();


       bool isExcel_valueResult(){return this->excel_valueResultIsNull_;}
       boost::shared_ptr<Excel_valueResult> getExcel_valueResult();


       bool isExcel_greekResult(){return this->excel_greekResultIsNull_;}
       boost::shared_ptr<Excel_greekResult> getExcel_greekResult();


       bool isExcel_cashFlowsResult(){return this->excel_cashFlowsResultIsNull_;}
       boost::shared_ptr<Excel_cashFlowsResult> getExcel_cashFlowsResult();


   protected: 
       boost::shared_ptr<XsdTypeDate> calculationDate_;
       
       bool calculationDateIsNull_;
       boost::shared_ptr<Excel_valueResult> excel_valueResult_;
       
       bool excel_valueResultIsNull_;
       boost::shared_ptr<Excel_greekResult> excel_greekResult_;
       
       bool excel_greekResultIsNull_;
       boost::shared_ptr<Excel_cashFlowsResult> excel_cashFlowsResult_;
       
       bool excel_cashFlowsResultIsNull_;

};

} //namespaceFpmlSerialized end
#endif

