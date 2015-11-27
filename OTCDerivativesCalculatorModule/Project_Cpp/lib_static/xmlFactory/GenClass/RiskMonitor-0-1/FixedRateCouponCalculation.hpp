// FixedRateCouponCalculation.hpp 
#ifndef FpmlSerialized_FixedRateCouponCalculation_hpp
#define FpmlSerialized_FixedRateCouponCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class FixedRateCouponCalculation : public ISerialized { 
   public: 
       FixedRateCouponCalculation(TiXmlNode* xmlNode);

       bool isRate(){return this->rateIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getRate();


   protected: 
       boost::shared_ptr<XsdTypeDouble> rate_;
       
       bool rateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

