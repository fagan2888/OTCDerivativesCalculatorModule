// PaySwapPart_A.hpp 
#ifndef FpmlSerialized_PaySwapPart_A_hpp
#define FpmlSerialized_PaySwapPart_A_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PayoffInfo.hpp>

namespace FpmlSerialized {

class PaySwapPart_A : public ISerialized { 
   public: 
       PaySwapPart_A(TiXmlNode* xmlNode);

       bool isPayoffInfo(){return this->payoffInfoIsNull_;}
       boost::shared_ptr<PayoffInfo> getPayoffInfo();


   protected: 
       boost::shared_ptr<PayoffInfo> payoffInfo_;
       
       bool payoffInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

