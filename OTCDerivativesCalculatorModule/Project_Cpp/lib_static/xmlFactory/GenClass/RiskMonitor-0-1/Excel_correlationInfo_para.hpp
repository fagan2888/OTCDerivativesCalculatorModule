// Excel_correlationInfo_para.hpp 
#ifndef FpmlSerialized_Excel_correlationInfo_para_hpp
#define FpmlSerialized_Excel_correlationInfo_para_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <RiskMonitor-0-1/Excel_correlation_para.hpp>

namespace FpmlSerialized {

class Excel_correlationInfo_para : public ISerialized { 
   public: 
       Excel_correlationInfo_para(TiXmlNode* xmlNode);

       bool isDimension(){return this->dimensionIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getDimension();


       bool isExcel_correlation_para(){return this->excel_correlation_paraIsNull_;}
       std::vector<boost::shared_ptr<Excel_correlation_para>> getExcel_correlation_para();


   protected: 
       boost::shared_ptr<XsdTypeInteger> dimension_;
       
       bool dimensionIsNull_;
       std::vector<boost::shared_ptr<Excel_correlation_para>> excel_correlation_para_;
       
       bool excel_correlation_paraIsNull_;

};

} //namespaceFpmlSerialized end
#endif

