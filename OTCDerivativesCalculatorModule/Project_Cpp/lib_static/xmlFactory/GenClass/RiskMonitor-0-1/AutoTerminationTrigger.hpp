// AutoTerminationTrigger.hpp 
#ifndef FpmlSerialized_AutoTerminationTrigger_hpp
#define FpmlSerialized_AutoTerminationTrigger_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventCalculationInfo.hpp>
#include <RiskMonitor-0-1/ReturnCalculationInfo.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>

namespace FpmlSerialized {

class AutoTerminationTrigger : public ISerialized { 
   public: 
       AutoTerminationTrigger(TiXmlNode* xmlNode);

       bool isEventCalculationInfo(){return this->eventCalculationInfoIsNull_;}
       boost::shared_ptr<EventCalculationInfo> getEventCalculationInfo();


       bool isReturnCalculationInfo(){return this->returnCalculationInfoIsNull_;}
       boost::shared_ptr<ReturnCalculationInfo> getReturnCalculationInfo();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


   protected: 
       boost::shared_ptr<EventCalculationInfo> eventCalculationInfo_;
       
       bool eventCalculationInfoIsNull_;
       boost::shared_ptr<ReturnCalculationInfo> returnCalculationInfo_;
       
       bool returnCalculationInfoIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

