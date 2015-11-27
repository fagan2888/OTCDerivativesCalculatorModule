// Pricing.hpp 
#ifndef FpmlSerialized_Pricing_hpp
#define FpmlSerialized_Pricing_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <RiskMonitor-0-1/Excel_parameter.hpp>

namespace FpmlSerialized {

class Pricing : public ISerialized { 
   public: 
       Pricing(TiXmlNode* xmlNode);

       bool isEvaluationTime(){return this->evaluationTimeIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEvaluationTime();


       bool isExcel_parameter(){return this->excel_parameterIsNull_;}
       boost::shared_ptr<Excel_parameter> getExcel_parameter();


   protected: 
       boost::shared_ptr<XsdTypeDate> evaluationTime_;
       
       bool evaluationTimeIsNull_;
       boost::shared_ptr<Excel_parameter> excel_parameter_;
       
       bool excel_parameterIsNull_;

};

} //namespaceFpmlSerialized end
#endif

