// SingleBarrier.hpp 
#ifndef FpmlSerialized_SingleBarrier_hpp
#define FpmlSerialized_SingleBarrier_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/BarrierInfo.hpp>

namespace FpmlSerialized {

class SingleBarrier : public ISerialized { 
   public: 
       SingleBarrier(TiXmlNode* xmlNode);

       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isParticipateRate(){return this->participateRateIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getParticipateRate();


       bool isBarrierInfo(){return this->barrierInfoIsNull_;}
       boost::shared_ptr<BarrierInfo> getBarrierInfo();


       bool isRebate(){return this->rebateIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getRebate();


   protected: 
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeDouble> participateRate_;
       
       bool participateRateIsNull_;
       boost::shared_ptr<BarrierInfo> barrierInfo_;
       
       bool barrierInfoIsNull_;
       boost::shared_ptr<XsdTypeDouble> rebate_;
       
       bool rebateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

