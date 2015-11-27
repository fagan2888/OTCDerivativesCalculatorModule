// InterestRateSwapPayoff_A.hpp 
#ifndef FpmlSerialized_InterestRateSwapPayoff_A_hpp
#define FpmlSerialized_InterestRateSwapPayoff_A_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PayoffInfo.hpp>

namespace FpmlSerialized {

class InterestRateSwapPayoff_A : public ISerialized { 
   public: 
       InterestRateSwapPayoff_A(TiXmlNode* xmlNode);

       bool isPayoffInfo(){return this->payoffInfoIsNull_;}
       boost::shared_ptr<PayoffInfo> getPayoffInfo();


   protected: 
       boost::shared_ptr<PayoffInfo> payoffInfo_;
       
       bool payoffInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

