// BarrierWithConstRebatePutOption.hpp 
#ifndef FpmlSerialized_BarrierWithConstRebatePutOption_hpp
#define FpmlSerialized_BarrierWithConstRebatePutOption_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <RiskMonitor-0-1/BarrierInfo.hpp>

namespace FpmlSerialized {

class BarrierWithConstRebatePutOption : public ISerialized { 
   public: 
       BarrierWithConstRebatePutOption(TiXmlNode* xmlNode);

       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isParticipateRate(){return this->participateRateIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getParticipateRate();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


       bool isBarrierInfo(){return this->barrierInfoIsNull_;}
       boost::shared_ptr<BarrierInfo> getBarrierInfo();


       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getStrike();


       bool isLowerBound(){return this->lowerBoundIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getLowerBound();


       bool isRebateRate(){return this->rebateRateIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getRebateRate();


   protected: 
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeDouble> participateRate_;
       
       bool participateRateIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       boost::shared_ptr<BarrierInfo> barrierInfo_;
       
       bool barrierInfoIsNull_;
       boost::shared_ptr<XsdTypeDouble> strike_;
       
       bool strikeIsNull_;
       boost::shared_ptr<XsdTypeDouble> lowerBound_;
       
       bool lowerBoundIsNull_;
       boost::shared_ptr<XsdTypeDouble> rebateRate_;
       
       bool rebateRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

