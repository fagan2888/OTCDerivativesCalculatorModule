// ProtectionTerms.hpp 
#ifndef FpmlSerialized_ProtectionTerms_hpp
#define FpmlSerialized_ProtectionTerms_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/CalculationAmount.hpp>
#include <RiskMonitor-0-1/CreditEvents.hpp>
#include <RiskMonitor-0-1/Obligations.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class ProtectionTerms : public ISerialized { 
   public: 
       ProtectionTerms(TiXmlNode* xmlNode);

       bool isCalculationAmount(){return this->calculationAmountIsNull_;}
       boost::shared_ptr<CalculationAmount> getCalculationAmount();


       bool isCreditEvents(){return this->creditEventsIsNull_;}
       boost::shared_ptr<CreditEvents> getCreditEvents();


       bool isObligations(){return this->obligationsIsNull_;}
       boost::shared_ptr<Obligations> getObligations();


       bool isAccrualCoupon(){return this->accrualCouponIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAccrualCoupon();


   protected: 
       boost::shared_ptr<CalculationAmount> calculationAmount_;
       
       bool calculationAmountIsNull_;
       boost::shared_ptr<CreditEvents> creditEvents_;
       
       bool creditEventsIsNull_;
       boost::shared_ptr<Obligations> obligations_;
       
       bool obligationsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> accrualCoupon_;
       
       bool accrualCouponIsNull_;

};

} //namespaceFpmlSerialized end
#endif

