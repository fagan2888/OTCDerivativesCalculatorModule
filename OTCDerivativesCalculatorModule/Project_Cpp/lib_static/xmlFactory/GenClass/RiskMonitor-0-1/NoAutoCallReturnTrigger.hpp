// NoAutoCallReturnTrigger.hpp 
#ifndef FpmlSerialized_NoAutoCallReturnTrigger_hpp
#define FpmlSerialized_NoAutoCallReturnTrigger_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <RiskMonitor-0-1/ReturnCalculation.hpp>

namespace FpmlSerialized {

class NoAutoCallReturnTrigger : public ISerialized { 
   public: 
       NoAutoCallReturnTrigger(TiXmlNode* xmlNode);

       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isReturnCalculation(){return this->returnCalculationIsNull_;}
       boost::shared_ptr<ReturnCalculation> getReturnCalculation();


   protected: 
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<ReturnCalculation> returnCalculation_;
       
       bool returnCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

