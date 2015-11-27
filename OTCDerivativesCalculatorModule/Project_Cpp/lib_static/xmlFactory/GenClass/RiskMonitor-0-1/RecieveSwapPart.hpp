// RecieveSwapPart.hpp 
#ifndef FpmlSerialized_RecieveSwapPart_hpp
#define FpmlSerialized_RecieveSwapPart_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PayoffInfo.hpp>

namespace FpmlSerialized {

class RecieveSwapPart : public ISerialized { 
   public: 
       RecieveSwapPart(TiXmlNode* xmlNode);

       bool isPayoffInfo(){return this->payoffInfoIsNull_;}
       boost::shared_ptr<PayoffInfo> getPayoffInfo();


   protected: 
       boost::shared_ptr<PayoffInfo> payoffInfo_;
       
       bool payoffInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

