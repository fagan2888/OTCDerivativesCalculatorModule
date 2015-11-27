// RateObservation.hpp 
#ifndef FpmlSerialized_RateObservation_hpp
#define FpmlSerialized_RateObservation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-shared-5-4/RateReference.hpp>

namespace FpmlSerialized {

class RateObservation : public ISerialized { 
   public: 
       RateObservation(TiXmlNode* xmlNode);

       bool isResetDate(){return this->resetDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getResetDate();
      std::string getResetDateIDRef(){return resetDateIDRef_;}

       bool isAdjustedFixingDate(){return this->adjustedFixingDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedFixingDate();
      std::string getAdjustedFixingDateIDRef(){return adjustedFixingDateIDRef_;}

       bool isObservedRate(){return this->observedRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getObservedRate();
      std::string getObservedRateIDRef(){return observedRateIDRef_;}

       bool isTreatedRate(){return this->treatedRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getTreatedRate();
      std::string getTreatedRateIDRef(){return treatedRateIDRef_;}

       bool isObservationWeight(){return this->observationWeightIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getObservationWeight();
      std::string getObservationWeightIDRef(){return observationWeightIDRef_;}

       bool isRateReference(){return this->rateReferenceIsNull_;}
       boost::shared_ptr<RateReference> getRateReference();
      std::string getRateReferenceIDRef(){return rateReferenceIDRef_;}

       bool isForecastRate(){return this->forecastRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getForecastRate();
      std::string getForecastRateIDRef(){return forecastRateIDRef_;}

       bool isTreatedForecastRate(){return this->treatedForecastRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getTreatedForecastRate();
      std::string getTreatedForecastRateIDRef(){return treatedForecastRateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> resetDate_;
       std::string resetDateIDRef_;
       bool resetDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedFixingDate_;
       std::string adjustedFixingDateIDRef_;
       bool adjustedFixingDateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> observedRate_;
       std::string observedRateIDRef_;
       bool observedRateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> treatedRate_;
       std::string treatedRateIDRef_;
       bool treatedRateIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> observationWeight_;
       std::string observationWeightIDRef_;
       bool observationWeightIsNull_;
       boost::shared_ptr<RateReference> rateReference_;
       std::string rateReferenceIDRef_;
       bool rateReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> forecastRate_;
       std::string forecastRateIDRef_;
       bool forecastRateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> treatedForecastRate_;
       std::string treatedForecastRateIDRef_;
       bool treatedForecastRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

