// Excel_referenceCalcInfo_para.hpp 
#ifndef FpmlSerialized_Excel_referenceCalcInfo_para_hpp
#define FpmlSerialized_Excel_referenceCalcInfo_para_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_referenceInfo_para.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_referenceCalcInfo_para : public ISerialized { 
   public: 
       Excel_referenceCalcInfo_para(TiXmlNode* xmlNode);

       bool isExcel_referenceInfo_para(){return this->excel_referenceInfo_paraIsNull_;}
       std::vector<boost::shared_ptr<Excel_referenceInfo_para>> getExcel_referenceInfo_para();


       bool isCoupula_correlation(){return this->coupula_correlationIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCoupula_correlation();


   protected: 
       std::vector<boost::shared_ptr<Excel_referenceInfo_para>> excel_referenceInfo_para_;
       
       bool excel_referenceInfo_paraIsNull_;
       boost::shared_ptr<XsdTypeToken> coupula_correlation_;
       
       bool coupula_correlationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

