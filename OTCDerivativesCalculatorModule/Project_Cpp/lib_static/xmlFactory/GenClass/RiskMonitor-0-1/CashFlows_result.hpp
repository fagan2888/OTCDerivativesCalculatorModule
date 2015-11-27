// CashFlows_result.hpp 
#ifndef FpmlSerialized_CashFlows_result_hpp
#define FpmlSerialized_CashFlows_result_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/CashFlow_result.hpp>

namespace FpmlSerialized {

class CashFlows_result : public ISerialized { 
   public: 
       CashFlows_result(TiXmlNode* xmlNode);

       bool isCashFlow_result(){return this->cashFlow_resultIsNull_;}
       std::vector<boost::shared_ptr<CashFlow_result>> getCashFlow_result();


   protected: 
       std::vector<boost::shared_ptr<CashFlow_result>> cashFlow_result_;
       
       bool cashFlow_resultIsNull_;

};

} //namespaceFpmlSerialized end
#endif

