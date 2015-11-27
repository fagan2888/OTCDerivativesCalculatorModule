// General_scheduleDetail_fixedCoupon.hpp 
#ifndef FpmlSerialized_General_scheduleDetail_fixedCoupon_hpp
#define FpmlSerialized_General_scheduleDetail_fixedCoupon_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class General_scheduleDetail_fixedCoupon : public ISerialized { 
   public: 
       General_scheduleDetail_fixedCoupon(TiXmlNode* xmlNode);

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixedRate();


   protected: 
       boost::shared_ptr<XsdTypeToken> fixedRate_;
       
       bool fixedRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

