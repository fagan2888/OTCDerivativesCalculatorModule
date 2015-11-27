// UnderlyingInfo_para.hpp 
#ifndef FpmlSerialized_UnderlyingInfo_para_hpp
#define FpmlSerialized_UnderlyingInfo_para_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Underlying_para.hpp>
#include <RiskMonitor-0-1/CorrelationInfo_para.hpp>

namespace FpmlSerialized {

class UnderlyingInfo_para : public ISerialized { 
   public: 
       UnderlyingInfo_para(TiXmlNode* xmlNode);

       bool isUnderlying_para(){return this->underlying_paraIsNull_;}
       std::vector<boost::shared_ptr<Underlying_para>> getUnderlying_para();


       bool isCorrelationInfo_para(){return this->correlationInfo_paraIsNull_;}
       boost::shared_ptr<CorrelationInfo_para> getCorrelationInfo_para();


   protected: 
       std::vector<boost::shared_ptr<Underlying_para>> underlying_para_;
       
       bool underlying_paraIsNull_;
       boost::shared_ptr<CorrelationInfo_para> correlationInfo_para_;
       
       bool correlationInfo_paraIsNull_;

};

} //namespaceFpmlSerialized end
#endif

