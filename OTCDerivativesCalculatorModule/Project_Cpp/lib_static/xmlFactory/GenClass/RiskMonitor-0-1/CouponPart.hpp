// CouponPart.hpp 
#ifndef FpmlSerialized_CouponPart_hpp
#define FpmlSerialized_CouponPart_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CouponPart : public ISerialized { 
   public: 
       CouponPart(TiXmlNode* xmlNode);

       bool isPayRecieve(){return this->payRecieveIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayRecieve();


   protected: 
       boost::shared_ptr<XsdTypeToken> payRecieve_;
       
       bool payRecieveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

