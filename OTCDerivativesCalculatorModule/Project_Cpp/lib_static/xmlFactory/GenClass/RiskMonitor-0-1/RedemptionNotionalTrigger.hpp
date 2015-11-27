// RedemptionNotionalTrigger.hpp 
#ifndef FpmlSerialized_RedemptionNotionalTrigger_hpp
#define FpmlSerialized_RedemptionNotionalTrigger_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class RedemptionNotionalTrigger : public ISerialized { 
   public: 
       RedemptionNotionalTrigger(TiXmlNode* xmlNode);

       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isRedemptionAmount(){return this->redemptionAmountIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getRedemptionAmount();


   protected: 
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeDouble> redemptionAmount_;
       
       bool redemptionAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

