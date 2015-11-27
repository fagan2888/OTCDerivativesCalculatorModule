// InterestRateSwapPayoff.hpp 
#ifndef FpmlSerialized_InterestRateSwapPayoff_hpp
#define FpmlSerialized_InterestRateSwapPayoff_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/CouponPart.hpp>

namespace FpmlSerialized {

class InterestRateSwapPayoff : public ISerialized { 
   public: 
       InterestRateSwapPayoff(TiXmlNode* xmlNode);

       bool isCouponPart(){return this->couponPartIsNull_;}
       std::vector<boost::shared_ptr<CouponPart>> getCouponPart();


   protected: 
       std::vector<boost::shared_ptr<CouponPart>> couponPart_;
       
       bool couponPartIsNull_;

};

} //namespaceFpmlSerialized end
#endif

