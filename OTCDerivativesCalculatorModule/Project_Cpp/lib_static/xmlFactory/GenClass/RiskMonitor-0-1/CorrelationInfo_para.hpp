// CorrelationInfo_para.hpp 
#ifndef FpmlSerialized_CorrelationInfo_para_hpp
#define FpmlSerialized_CorrelationInfo_para_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <RiskMonitor-0-1/Correlation_para.hpp>

namespace FpmlSerialized {

class CorrelationInfo_para : public ISerialized { 
   public: 
       CorrelationInfo_para(TiXmlNode* xmlNode);

       bool isDimension(){return this->dimensionIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getDimension();


       bool isCorrelation_para(){return this->correlation_paraIsNull_;}
       std::vector<boost::shared_ptr<Correlation_para>> getCorrelation_para();


   protected: 
       boost::shared_ptr<XsdTypeInteger> dimension_;
       
       bool dimensionIsNull_;
       std::vector<boost::shared_ptr<Correlation_para>> correlation_para_;
       
       bool correlation_paraIsNull_;

};

} //namespaceFpmlSerialized end
#endif

