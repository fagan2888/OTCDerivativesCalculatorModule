// SimpleRangeRateTrigger.hpp 
#ifndef FpmlSerialized_SimpleRangeRateTrigger_hpp
#define FpmlSerialized_SimpleRangeRateTrigger_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <RiskMonitor-0-1/SimpleRangeEventList.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>

namespace FpmlSerialized {

class SimpleRangeRateTrigger : public ISerialized { 
   public: 
       SimpleRangeRateTrigger(TiXmlNode* xmlNode);

       bool isDayCounter(){return this->dayCounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayCounter();


       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationStartDate();


       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationEndDate();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


       bool isSimpleRangeEventList(){return this->simpleRangeEventListIsNull_;}
       boost::shared_ptr<SimpleRangeEventList> getSimpleRangeEventList();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> dayCounter_;
       
       bool dayCounterIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationStartDate_;
       
       bool calculationStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationEndDate_;
       
       bool calculationEndDateIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       boost::shared_ptr<SimpleRangeEventList> simpleRangeEventList_;
       
       bool simpleRangeEventListIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

