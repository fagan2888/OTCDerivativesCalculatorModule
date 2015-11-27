// Excel_standardCreditPara.hpp 
#ifndef FpmlSerialized_Excel_standardCreditPara_hpp
#define FpmlSerialized_Excel_standardCreditPara_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcInfo_para.hpp>
#include <RiskMonitor-0-1/Excel_referenceCalcInfo_para.hpp>
#include <RiskMonitor-0-1/Excel_discountCurve_para.hpp>
#include <RiskMonitor-0-1/Excel_defaultCurve_para.hpp>

namespace FpmlSerialized {

class Excel_standardCreditPara : public ISerialized { 
   public: 
       Excel_standardCreditPara(TiXmlNode* xmlNode);

       bool isReferenceDate(){return this->referenceDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReferenceDate();


       bool isSimulationNum(){return this->simulationNumIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSimulationNum();


       bool isExcel_underlyingCalcInfo_para(){return this->excel_underlyingCalcInfo_paraIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcInfo_para> getExcel_underlyingCalcInfo_para();


       bool isExcel_referenceCalcInfo_para(){return this->excel_referenceCalcInfo_paraIsNull_;}
       boost::shared_ptr<Excel_referenceCalcInfo_para> getExcel_referenceCalcInfo_para();


       bool isExcel_discountCurve_para(){return this->excel_discountCurve_paraIsNull_;}
       boost::shared_ptr<Excel_discountCurve_para> getExcel_discountCurve_para();


       bool isExcel_defaultCurve_para(){return this->excel_defaultCurve_paraIsNull_;}
       boost::shared_ptr<Excel_defaultCurve_para> getExcel_defaultCurve_para();


   protected: 
       boost::shared_ptr<XsdTypeToken> referenceDate_;
       
       bool referenceDateIsNull_;
       boost::shared_ptr<XsdTypeToken> simulationNum_;
       
       bool simulationNumIsNull_;
       boost::shared_ptr<Excel_underlyingCalcInfo_para> excel_underlyingCalcInfo_para_;
       
       bool excel_underlyingCalcInfo_paraIsNull_;
       boost::shared_ptr<Excel_referenceCalcInfo_para> excel_referenceCalcInfo_para_;
       
       bool excel_referenceCalcInfo_paraIsNull_;
       boost::shared_ptr<Excel_discountCurve_para> excel_discountCurve_para_;
       
       bool excel_discountCurve_paraIsNull_;
       boost::shared_ptr<Excel_defaultCurve_para> excel_defaultCurve_para_;
       
       bool excel_defaultCurve_paraIsNull_;

};

} //namespaceFpmlSerialized end
#endif

