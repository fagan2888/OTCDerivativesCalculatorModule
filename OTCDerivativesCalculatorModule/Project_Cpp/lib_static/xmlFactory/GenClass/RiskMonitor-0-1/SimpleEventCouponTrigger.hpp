// SimpleEventCouponTrigger.hpp 
#ifndef FpmlSerialized_SimpleEventCouponTrigger_hpp
#define FpmlSerialized_SimpleEventCouponTrigger_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventCalculationInfo.hpp>
#include <RiskMonitor-0-1/ReturnCalculationInfo.hpp>
#include <RiskMonitor-0-1/ComplementReturnCalculation.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class SimpleEventCouponTrigger : public ISerialized { 
   public: 
       SimpleEventCouponTrigger(TiXmlNode* xmlNode);

       bool isEventCalculationInfo(){return this->eventCalculationInfoIsNull_;}
       boost::shared_ptr<EventCalculationInfo> getEventCalculationInfo();


       bool isReturnCalculationInfo(){return this->returnCalculationInfoIsNull_;}
       boost::shared_ptr<ReturnCalculationInfo> getReturnCalculationInfo();


       bool isComplementReturnCalculation(){return this->complementReturnCalculationIsNull_;}
       boost::shared_ptr<ComplementReturnCalculation> getComplementReturnCalculation();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isIsExpired(){return this->isExpiredIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsExpired();


   protected: 
       boost::shared_ptr<EventCalculationInfo> eventCalculationInfo_;
       
       bool eventCalculationInfoIsNull_;
       boost::shared_ptr<ReturnCalculationInfo> returnCalculationInfo_;
       
       bool returnCalculationInfoIsNull_;
       boost::shared_ptr<ComplementReturnCalculation> complementReturnCalculation_;
       
       bool complementReturnCalculationIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeBoolean> isExpired_;
       
       bool isExpiredIsNull_;

};

} //namespaceFpmlSerialized end
#endif

