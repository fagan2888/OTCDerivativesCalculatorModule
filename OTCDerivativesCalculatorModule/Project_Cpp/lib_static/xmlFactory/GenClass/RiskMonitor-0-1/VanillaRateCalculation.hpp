// VanillaRateCalculation.hpp 
#ifndef FpmlSerialized_VanillaRateCalculation_hpp
#define FpmlSerialized_VanillaRateCalculation_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/RateCouponCalculation.hpp>

namespace FpmlSerialized {

class VanillaRateCalculation : public ISerialized { 
   public: 
       VanillaRateCalculation(TiXmlNode* xmlNode);

       bool isRateCouponCalculation(){return this->rateCouponCalculationIsNull_;}
       boost::shared_ptr<RateCouponCalculation> getRateCouponCalculation();


   protected: 
       boost::shared_ptr<RateCouponCalculation> rateCouponCalculation_;
       
       bool rateCouponCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

