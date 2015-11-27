// AutoCallRangeReturnTrigger.hpp 
#ifndef FpmlSerialized_AutoCallRangeReturnTrigger_hpp
#define FpmlSerialized_AutoCallRangeReturnTrigger_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/SimpleRangeEventCal.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class AutoCallRangeReturnTrigger : public ISerialized { 
   public: 
       AutoCallRangeReturnTrigger(TiXmlNode* xmlNode);

       bool isSimpleRangeEventCal(){return this->simpleRangeEventCalIsNull_;}
       boost::shared_ptr<SimpleRangeEventCal> getSimpleRangeEventCal();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isIsExpired(){return this->isExpiredIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsExpired();


   protected: 
       boost::shared_ptr<SimpleRangeEventCal> simpleRangeEventCal_;
       
       bool simpleRangeEventCalIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeBoolean> isExpired_;
       
       bool isExpiredIsNull_;

};

} //namespaceFpmlSerialized end
#endif

