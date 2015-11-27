// FloatingRateCalculation.hpp 
#ifndef FpmlSerialized_FloatingRateCalculation_hpp
#define FpmlSerialized_FloatingRateCalculation_hpp

#include <fpml-shared-5-4/FloatingRate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Rounding.hpp>
#include <fpml-enum-5-4/AveragingMethodEnum.hpp>
#include <fpml-enum-5-4/NegativeInterestRateTreatmentEnum.hpp>

namespace FpmlSerialized {

class FloatingRateCalculation : public FloatingRate { 
   public: 
       FloatingRateCalculation(TiXmlNode* xmlNode);

       bool isInitialRate(){return this->initialRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getInitialRate();
      std::string getInitialRateIDRef(){return initialRateIDRef_;}

       bool isFinalRateRounding(){return this->finalRateRoundingIsNull_;}
       boost::shared_ptr<Rounding> getFinalRateRounding();
      std::string getFinalRateRoundingIDRef(){return finalRateRoundingIDRef_;}

       bool isAveragingMethod(){return this->averagingMethodIsNull_;}
       boost::shared_ptr<AveragingMethodEnum> getAveragingMethod();
      std::string getAveragingMethodIDRef(){return averagingMethodIDRef_;}

       bool isNegativeInterestRateTreatment(){return this->negativeInterestRateTreatmentIsNull_;}
       boost::shared_ptr<NegativeInterestRateTreatmentEnum> getNegativeInterestRateTreatment();
      std::string getNegativeInterestRateTreatmentIDRef(){return negativeInterestRateTreatmentIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> initialRate_;
       std::string initialRateIDRef_;
       bool initialRateIsNull_;
       boost::shared_ptr<Rounding> finalRateRounding_;
       std::string finalRateRoundingIDRef_;
       bool finalRateRoundingIsNull_;
       boost::shared_ptr<AveragingMethodEnum> averagingMethod_;
       std::string averagingMethodIDRef_;
       bool averagingMethodIsNull_;
       boost::shared_ptr<NegativeInterestRateTreatmentEnum> negativeInterestRateTreatment_;
       std::string negativeInterestRateTreatmentIDRef_;
       bool negativeInterestRateTreatmentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

