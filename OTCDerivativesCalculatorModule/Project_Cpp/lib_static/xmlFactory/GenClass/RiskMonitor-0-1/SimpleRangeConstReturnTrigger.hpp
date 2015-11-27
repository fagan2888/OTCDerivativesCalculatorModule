// SimpleRangeConstReturnTrigger.hpp 
#ifndef FpmlSerialized_SimpleRangeConstReturnTrigger_hpp
#define FpmlSerialized_SimpleRangeConstReturnTrigger_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <RiskMonitor-0-1/SimpleRangeEventCal.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class SimpleRangeConstReturnTrigger : public ISerialized { 
   public: 
       SimpleRangeConstReturnTrigger(TiXmlNode* xmlNode);

       bool isDateOrder(){return this->dateOrderIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getDateOrder();


       bool isSimpleRangeEventCal(){return this->simpleRangeEventCalIsNull_;}
       boost::shared_ptr<SimpleRangeEventCal> getSimpleRangeEventCal();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isConstReturn(){return this->constReturnIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getConstReturn();


       bool isAverageDays(){return this->averageDaysIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getAverageDays();


       bool isIsExpired(){return this->isExpiredIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsExpired();


   protected: 
       boost::shared_ptr<XsdTypeInteger> dateOrder_;
       
       bool dateOrderIsNull_;
       boost::shared_ptr<SimpleRangeEventCal> simpleRangeEventCal_;
       
       bool simpleRangeEventCalIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeDouble> constReturn_;
       
       bool constReturnIsNull_;
       boost::shared_ptr<XsdTypeInteger> averageDays_;
       
       bool averageDaysIsNull_;
       boost::shared_ptr<XsdTypeBoolean> isExpired_;
       
       bool isExpiredIsNull_;

};

} //namespaceFpmlSerialized end
#endif

