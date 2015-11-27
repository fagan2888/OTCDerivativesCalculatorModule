// InterestCalculation.hpp 
#ifndef FpmlSerialized_InterestCalculation_hpp
#define FpmlSerialized_InterestCalculation_hpp

#include <fpml-shared-5-4/InterestAccrualsMethod.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>
#include <fpml-eq-shared-5-4/Compounding.hpp>
#include <fpml-shared-5-4/InterpolationMethod.hpp>
#include <fpml-enum-5-4/InterpolationPeriodEnum.hpp>

namespace FpmlSerialized {

class InterestCalculation : public InterestAccrualsMethod { 
   public: 
       InterestCalculation(TiXmlNode* xmlNode);

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

       bool isCompounding(){return this->compoundingIsNull_;}
       boost::shared_ptr<Compounding> getCompounding();
      std::string getCompoundingIDRef(){return compoundingIDRef_;}

       bool isInterpolationMethod(){return this->interpolationMethodIsNull_;}
       boost::shared_ptr<InterpolationMethod> getInterpolationMethod();
      std::string getInterpolationMethodIDRef(){return interpolationMethodIDRef_;}

       bool isInterpolationPeriod(){return this->interpolationPeriodIsNull_;}
       boost::shared_ptr<InterpolationPeriodEnum> getInterpolationPeriod();
      std::string getInterpolationPeriodIDRef(){return interpolationPeriodIDRef_;}

   protected: 
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;
       boost::shared_ptr<Compounding> compounding_;
       std::string compoundingIDRef_;
       bool compoundingIsNull_;
       boost::shared_ptr<InterpolationMethod> interpolationMethod_;
       std::string interpolationMethodIDRef_;
       bool interpolationMethodIsNull_;
       boost::shared_ptr<InterpolationPeriodEnum> interpolationPeriod_;
       std::string interpolationPeriodIDRef_;
       bool interpolationPeriodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

