// SimpleRangeReturnTrigger.hpp 
#ifndef FpmlSerialized_SimpleRangeReturnTrigger_hpp
#define FpmlSerialized_SimpleRangeReturnTrigger_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/SimpleRangeEventCal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>

namespace FpmlSerialized {

class SimpleRangeReturnTrigger : public ISerialized { 
   public: 
       SimpleRangeReturnTrigger(TiXmlNode* xmlNode);

       bool isSimpleRangeEventCal(){return this->simpleRangeEventCalIsNull_;}
       boost::shared_ptr<SimpleRangeEventCal> getSimpleRangeEventCal();


       bool isAutoCallFlag(){return this->autoCallFlagIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAutoCallFlag();


       bool isExpired(){return this->expiredIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getExpired();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


   protected: 
       boost::shared_ptr<SimpleRangeEventCal> simpleRangeEventCal_;
       
       bool simpleRangeEventCalIsNull_;
       boost::shared_ptr<XsdTypeBoolean> autoCallFlag_;
       
       bool autoCallFlagIsNull_;
       boost::shared_ptr<XsdTypeBoolean> expired_;
       
       bool expiredIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

