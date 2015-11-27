// VanillaCouponTrigger.hpp 
#ifndef FpmlSerialized_VanillaCouponTrigger_hpp
#define FpmlSerialized_VanillaCouponTrigger_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/ReturnCalculation.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class VanillaCouponTrigger : public ISerialized { 
   public: 
       VanillaCouponTrigger(TiXmlNode* xmlNode);

       bool isGearing(){return this->gearingIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getGearing();


       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getSpread();


       bool isReturnCalculation(){return this->returnCalculationIsNull_;}
       boost::shared_ptr<ReturnCalculation> getReturnCalculation();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isIsExpired(){return this->isExpiredIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsExpired();


   protected: 
       boost::shared_ptr<XsdTypeDouble> gearing_;
       
       bool gearingIsNull_;
       boost::shared_ptr<XsdTypeDouble> spread_;
       
       bool spreadIsNull_;
       boost::shared_ptr<ReturnCalculation> returnCalculation_;
       
       bool returnCalculationIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeBoolean> isExpired_;
       
       bool isExpiredIsNull_;

};

} //namespaceFpmlSerialized end
#endif

