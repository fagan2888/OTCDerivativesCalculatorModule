// AutoCallableSwapPayoff.hpp 
#ifndef FpmlSerialized_AutoCallableSwapPayoff_hpp
#define FpmlSerialized_AutoCallableSwapPayoff_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/RecieveSwapPart.hpp>
#include <RiskMonitor-0-1/PaySwapPart.hpp>

namespace FpmlSerialized {

class AutoCallableSwapPayoff : public ISerialized { 
   public: 
       AutoCallableSwapPayoff(TiXmlNode* xmlNode);

       bool isRecieveSwapPart(){return this->recieveSwapPartIsNull_;}
       boost::shared_ptr<RecieveSwapPart> getRecieveSwapPart();


       bool isPaySwapPart(){return this->paySwapPartIsNull_;}
       boost::shared_ptr<PaySwapPart> getPaySwapPart();


   protected: 
       boost::shared_ptr<RecieveSwapPart> recieveSwapPart_;
       
       bool recieveSwapPartIsNull_;
       boost::shared_ptr<PaySwapPart> paySwapPart_;
       
       bool paySwapPartIsNull_;

};

} //namespaceFpmlSerialized end
#endif

