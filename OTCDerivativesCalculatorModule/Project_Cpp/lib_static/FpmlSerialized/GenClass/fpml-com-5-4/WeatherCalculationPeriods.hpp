// WeatherCalculationPeriods.hpp 
#ifndef FpmlSerialized_WeatherCalculationPeriods_hpp
#define FpmlSerialized_WeatherCalculationPeriods_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/WeatherCalculationPeriod.hpp>

namespace FpmlSerialized {

class WeatherCalculationPeriods : public ISerialized { 
   public: 
       WeatherCalculationPeriods(TiXmlNode* xmlNode);

       bool isCalculationPeriod(){return this->calculationPeriodIsNull_;}
       std::vector<boost::shared_ptr<WeatherCalculationPeriod>> getCalculationPeriod();
      std::string getCalculationPeriodIDRef(){return calculationPeriodIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<WeatherCalculationPeriod>> calculationPeriod_;
       std::string calculationPeriodIDRef_;
       bool calculationPeriodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

