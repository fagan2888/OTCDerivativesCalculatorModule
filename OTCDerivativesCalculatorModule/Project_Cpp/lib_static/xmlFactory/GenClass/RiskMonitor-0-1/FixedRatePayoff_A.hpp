// FixedRatePayoff_A.hpp 
#ifndef FpmlSerialized_FixedRatePayoff_A_hpp
#define FpmlSerialized_FixedRatePayoff_A_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class FixedRatePayoff_A : public ISerialized { 
   public: 
       FixedRatePayoff_A(TiXmlNode* xmlNode);

       bool isDayCounter(){return this->dayCounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayCounter();


       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationStartDate();


       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationEndDate();


       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixedRate();


       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


   protected: 
       boost::shared_ptr<XsdTypeToken> dayCounter_;
       
       bool dayCounterIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationStartDate_;
       
       bool calculationStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationEndDate_;
       
       bool calculationEndDateIsNull_;
       boost::shared_ptr<XsdTypeToken> fixedRate_;
       
       bool fixedRateIsNull_;
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

