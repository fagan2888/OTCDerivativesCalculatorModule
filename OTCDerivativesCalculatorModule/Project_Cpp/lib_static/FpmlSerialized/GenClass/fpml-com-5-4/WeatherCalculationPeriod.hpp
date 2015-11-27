// WeatherCalculationPeriod.hpp 
#ifndef FpmlSerialized_WeatherCalculationPeriod_hpp
#define FpmlSerialized_WeatherCalculationPeriod_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>

namespace FpmlSerialized {

class WeatherCalculationPeriod : public ISerialized { 
   public: 
       WeatherCalculationPeriod(TiXmlNode* xmlNode);

       bool isCalculationPeriodFirstDay(){return this->calculationPeriodFirstDayIsNull_;}
       boost::shared_ptr<IdentifiedDate> getCalculationPeriodFirstDay();
      std::string getCalculationPeriodFirstDayIDRef(){return calculationPeriodFirstDayIDRef_;}

       bool isCalculationPeriodEndDay(){return this->calculationPeriodEndDayIsNull_;}
       boost::shared_ptr<IdentifiedDate> getCalculationPeriodEndDay();
      std::string getCalculationPeriodEndDayIDRef(){return calculationPeriodEndDayIDRef_;}

   protected: 
       boost::shared_ptr<IdentifiedDate> calculationPeriodFirstDay_;
       std::string calculationPeriodFirstDayIDRef_;
       bool calculationPeriodFirstDayIsNull_;
       boost::shared_ptr<IdentifiedDate> calculationPeriodEndDay_;
       std::string calculationPeriodEndDayIDRef_;
       bool calculationPeriodEndDayIsNull_;

};

} //namespaceFpmlSerialized end
#endif

