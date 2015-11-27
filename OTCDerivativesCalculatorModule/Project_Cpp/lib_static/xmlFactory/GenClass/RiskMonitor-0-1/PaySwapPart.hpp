// PaySwapPart.hpp 
#ifndef FpmlSerialized_PaySwapPart_hpp
#define FpmlSerialized_PaySwapPart_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PayoffInfo.hpp>

namespace FpmlSerialized {

class PaySwapPart : public ISerialized { 
   public: 
       PaySwapPart(TiXmlNode* xmlNode);

       bool isPayoffInfo(){return this->payoffInfoIsNull_;}
       boost::shared_ptr<PayoffInfo> getPayoffInfo();


   protected: 
       boost::shared_ptr<PayoffInfo> payoffInfo_;
       
       bool payoffInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

