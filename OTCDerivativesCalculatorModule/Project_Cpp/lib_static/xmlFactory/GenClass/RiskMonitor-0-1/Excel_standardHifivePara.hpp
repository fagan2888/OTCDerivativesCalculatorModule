// Excel_standardHifivePara.hpp 
#ifndef FpmlSerialized_Excel_standardHifivePara_hpp
#define FpmlSerialized_Excel_standardHifivePara_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcInfo_para.hpp>
#include <RiskMonitor-0-1/Excel_discountCurve_para.hpp>

namespace FpmlSerialized {

class Excel_standardHifivePara : public ISerialized { 
   public: 
       Excel_standardHifivePara(TiXmlNode* xmlNode);

       bool isReferenceDate(){return this->referenceDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReferenceDate();


       bool isSimulationNum(){return this->simulationNumIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSimulationNum();


       bool isExcel_underlyingCalcInfo_para(){return this->excel_underlyingCalcInfo_paraIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcInfo_para> getExcel_underlyingCalcInfo_para();


       bool isExcel_discountCurve_para(){return this->excel_discountCurve_paraIsNull_;}
       boost::shared_ptr<Excel_discountCurve_para> getExcel_discountCurve_para();


   protected: 
       boost::shared_ptr<XsdTypeToken> referenceDate_;
       
       bool referenceDateIsNull_;
       boost::shared_ptr<XsdTypeToken> simulationNum_;
       
       bool simulationNumIsNull_;
       boost::shared_ptr<Excel_underlyingCalcInfo_para> excel_underlyingCalcInfo_para_;
       
       bool excel_underlyingCalcInfo_paraIsNull_;
       boost::shared_ptr<Excel_discountCurve_para> excel_discountCurve_para_;
       
       bool excel_discountCurve_paraIsNull_;

};

} //namespaceFpmlSerialized end
#endif

