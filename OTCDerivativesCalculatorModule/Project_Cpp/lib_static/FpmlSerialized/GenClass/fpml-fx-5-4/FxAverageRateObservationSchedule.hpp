// FxAverageRateObservationSchedule.hpp 
#ifndef FpmlSerialized_FxAverageRateObservationSchedule_hpp
#define FpmlSerialized_FxAverageRateObservationSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/CalculationPeriodFrequency.hpp>

namespace FpmlSerialized {

class FxAverageRateObservationSchedule : public ISerialized { 
   public: 
       FxAverageRateObservationSchedule(TiXmlNode* xmlNode);

       bool isStartDate(){return this->startDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getStartDate();
      std::string getStartDateIDRef(){return startDateIDRef_;}

       bool isEndDate(){return this->endDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEndDate();
      std::string getEndDateIDRef(){return endDateIDRef_;}

       bool isCalculationPeriodFrequency(){return this->calculationPeriodFrequencyIsNull_;}
       boost::shared_ptr<CalculationPeriodFrequency> getCalculationPeriodFrequency();
      std::string getCalculationPeriodFrequencyIDRef(){return calculationPeriodFrequencyIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> startDate_;
       std::string startDateIDRef_;
       bool startDateIsNull_;
       boost::shared_ptr<XsdTypeDate> endDate_;
       std::string endDateIDRef_;
       bool endDateIsNull_;
       boost::shared_ptr<CalculationPeriodFrequency> calculationPeriodFrequency_;
       std::string calculationPeriodFrequencyIDRef_;
       bool calculationPeriodFrequencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

