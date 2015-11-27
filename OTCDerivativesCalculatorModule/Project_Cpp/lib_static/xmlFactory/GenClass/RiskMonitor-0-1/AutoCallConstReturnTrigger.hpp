// AutoCallConstReturnTrigger.hpp 
#ifndef FpmlSerialized_AutoCallConstReturnTrigger_hpp
#define FpmlSerialized_AutoCallConstReturnTrigger_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <RiskMonitor-0-1/FixingDateInfo.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class AutoCallConstReturnTrigger : public ISerialized { 
   public: 
       AutoCallConstReturnTrigger(TiXmlNode* xmlNode);

       bool isDateOrder(){return this->dateOrderIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getDateOrder();


       bool isFixingDateInfo(){return this->fixingDateInfoIsNull_;}
       boost::shared_ptr<FixingDateInfo> getFixingDateInfo();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isTrigger(){return this->triggerIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getTrigger();


       bool isReturn(){return this->returnIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getReturn();


       bool isAverageDays(){return this->averageDaysIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getAverageDays();


       bool isIsExpired(){return this->isExpiredIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsExpired();


   protected: 
       boost::shared_ptr<XsdTypeInteger> dateOrder_;
       
       bool dateOrderIsNull_;
       boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
       
       bool fixingDateInfoIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeDouble> trigger_;
       
       bool triggerIsNull_;
       boost::shared_ptr<XsdTypeDouble> return_;
       
       bool returnIsNull_;
       boost::shared_ptr<XsdTypeInteger> averageDays_;
       
       bool averageDaysIsNull_;
       boost::shared_ptr<XsdTypeBoolean> isExpired_;
       
       bool isExpiredIsNull_;

};

} //namespaceFpmlSerialized end
#endif

