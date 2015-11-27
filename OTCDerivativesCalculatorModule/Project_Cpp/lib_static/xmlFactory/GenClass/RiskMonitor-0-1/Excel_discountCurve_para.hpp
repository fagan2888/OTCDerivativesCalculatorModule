// Excel_discountCurve_para.hpp 
#ifndef FpmlSerialized_Excel_discountCurve_para_hpp
#define FpmlSerialized_Excel_discountCurve_para_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_yieldCurve.hpp>

namespace FpmlSerialized {

class Excel_discountCurve_para : public ISerialized { 
   public: 
       Excel_discountCurve_para(TiXmlNode* xmlNode);

       bool isExcel_yieldCurve(){return this->excel_yieldCurveIsNull_;}
       std::vector<boost::shared_ptr<Excel_yieldCurve>> getExcel_yieldCurve();


   protected: 
       std::vector<boost::shared_ptr<Excel_yieldCurve>> excel_yieldCurve_;
       
       bool excel_yieldCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

