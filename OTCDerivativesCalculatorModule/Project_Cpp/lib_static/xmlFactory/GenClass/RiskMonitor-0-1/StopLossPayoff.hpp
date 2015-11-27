// StopLossPayoff.hpp 
#ifndef FpmlSerialized_StopLossPayoff_hpp
#define FpmlSerialized_StopLossPayoff_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventTriggerList.hpp>
#include <RiskMonitor-0-1/BarrierInfo.hpp>
#include <RiskMonitor-0-1/ReturnCalculation.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>

namespace FpmlSerialized {

class StopLossPayoff : public ISerialized { 
   public: 
       StopLossPayoff(TiXmlNode* xmlNode);

       bool isEventTriggerList(){return this->eventTriggerListIsNull_;}
       boost::shared_ptr<EventTriggerList> getEventTriggerList();


       bool isBarrierInfo(){return this->barrierInfoIsNull_;}
       boost::shared_ptr<BarrierInfo> getBarrierInfo();


       bool isReturnCalculation(){return this->returnCalculationIsNull_;}
       boost::shared_ptr<ReturnCalculation> getReturnCalculation();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


   protected: 
       boost::shared_ptr<EventTriggerList> eventTriggerList_;
       
       bool eventTriggerListIsNull_;
       boost::shared_ptr<BarrierInfo> barrierInfo_;
       
       bool barrierInfoIsNull_;
       boost::shared_ptr<ReturnCalculation> returnCalculation_;
       
       bool returnCalculationIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

