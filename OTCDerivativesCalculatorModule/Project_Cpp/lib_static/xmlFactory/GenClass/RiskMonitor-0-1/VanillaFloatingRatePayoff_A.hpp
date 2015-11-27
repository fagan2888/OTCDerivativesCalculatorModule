// VanillaFloatingRatePayoff_A.hpp 
#ifndef FpmlSerialized_VanillaFloatingRatePayoff_A_hpp
#define FpmlSerialized_VanillaFloatingRatePayoff_A_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/CapFloorOption.hpp>

namespace FpmlSerialized {

class VanillaFloatingRatePayoff_A : public ISerialized { 
   public: 
       VanillaFloatingRatePayoff_A(TiXmlNode* xmlNode);

       bool isDayCounter(){return this->dayCounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayCounter();


       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationStartDate();


       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCalculationEndDate();


       bool isGearing(){return this->gearingIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getGearing();


       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getSpread();


       bool isReferenceStr(){return this->referenceStrIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReferenceStr();


       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isCapFloorOption(){return this->capFloorOptionIsNull_;}
       boost::shared_ptr<CapFloorOption> getCapFloorOption();


   protected: 
       boost::shared_ptr<XsdTypeToken> dayCounter_;
       
       bool dayCounterIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationStartDate_;
       
       bool calculationStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> calculationEndDate_;
       
       bool calculationEndDateIsNull_;
       boost::shared_ptr<XsdTypeDouble> gearing_;
       
       bool gearingIsNull_;
       boost::shared_ptr<XsdTypeDouble> spread_;
       
       bool spreadIsNull_;
       boost::shared_ptr<XsdTypeToken> referenceStr_;
       
       bool referenceStrIsNull_;
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<CapFloorOption> capFloorOption_;
       
       bool capFloorOptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

