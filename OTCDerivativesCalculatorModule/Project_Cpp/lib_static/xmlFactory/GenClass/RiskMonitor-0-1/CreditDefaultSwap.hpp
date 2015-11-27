// CreditDefaultSwap.hpp 
#ifndef FpmlSerialized_CreditDefaultSwap_hpp
#define FpmlSerialized_CreditDefaultSwap_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/ProtectionPart.hpp>
#include <RiskMonitor-0-1/CouponPart.hpp>

namespace FpmlSerialized {

class CreditDefaultSwap : public ISerialized { 
   public: 
       CreditDefaultSwap(TiXmlNode* xmlNode);

       bool isProtectionPart(){return this->protectionPartIsNull_;}
       boost::shared_ptr<ProtectionPart> getProtectionPart();


       bool isCouponPart(){return this->couponPartIsNull_;}
       boost::shared_ptr<CouponPart> getCouponPart();


   protected: 
       boost::shared_ptr<ProtectionPart> protectionPart_;
       
       bool protectionPartIsNull_;
       boost::shared_ptr<CouponPart> couponPart_;
       
       bool couponPartIsNull_;

};

} //namespaceFpmlSerialized end
#endif

