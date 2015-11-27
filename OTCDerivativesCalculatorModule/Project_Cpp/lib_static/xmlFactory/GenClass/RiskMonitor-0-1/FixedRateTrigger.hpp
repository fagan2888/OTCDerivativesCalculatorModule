// FixedRateTrigger.hpp 
#ifndef FpmlSerialized_FixedRateTrigger_hpp
#define FpmlSerialized_FixedRateTrigger_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class FixedRateTrigger : public ISerialized { 
   public: 
       FixedRateTrigger(TiXmlNode* xmlNode);

       bool isDayCounter(){return this->dayCounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayCounter();


       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationStartDate();


       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationEndDate();


       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getFixedRate();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isIsExpired(){return this->isExpiredIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsExpired();


   protected: 
       boost::shared_ptr<XsdTypeToken> dayCounter_;
       
       bool dayCounterIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationStartDate_;
       
       bool calculationStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationEndDate_;
       
       bool calculationEndDateIsNull_;
       boost::shared_ptr<XsdTypeDouble> fixedRate_;
       
       bool fixedRateIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<XsdTypeBoolean> isExpired_;
       
       bool isExpiredIsNull_;

};

} //namespaceFpmlSerialized end
#endif

