// Excel_defaultCurve_para.hpp 
#ifndef FpmlSerialized_Excel_defaultCurve_para_hpp
#define FpmlSerialized_Excel_defaultCurve_para_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_defaultCurve.hpp>

namespace FpmlSerialized {

class Excel_defaultCurve_para : public ISerialized { 
   public: 
       Excel_defaultCurve_para(TiXmlNode* xmlNode);

       bool isExcel_defaultCurve(){return this->excel_defaultCurveIsNull_;}
       std::vector<boost::shared_ptr<Excel_defaultCurve>> getExcel_defaultCurve();


   protected: 
       std::vector<boost::shared_ptr<Excel_defaultCurve>> excel_defaultCurve_;
       
       bool excel_defaultCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

