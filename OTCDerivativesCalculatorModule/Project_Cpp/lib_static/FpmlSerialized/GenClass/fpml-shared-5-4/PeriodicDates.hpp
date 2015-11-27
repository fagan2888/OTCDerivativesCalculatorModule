// PeriodicDates.hpp 
#ifndef FpmlSerialized_PeriodicDates_hpp
#define FpmlSerialized_PeriodicDates_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/CalculationPeriodFrequency.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>

namespace FpmlSerialized {

class PeriodicDates : public ISerialized { 
   public: 
       PeriodicDates(TiXmlNode* xmlNode);

       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getCalculationStartDate();
      std::string getCalculationStartDateIDRef(){return calculationStartDateIDRef_;}

       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getCalculationEndDate();
      std::string getCalculationEndDateIDRef(){return calculationEndDateIDRef_;}

       bool isCalculationPeriodFrequency(){return this->calculationPeriodFrequencyIsNull_;}
       boost::shared_ptr<CalculationPeriodFrequency> getCalculationPeriodFrequency();
      std::string getCalculationPeriodFrequencyIDRef(){return calculationPeriodFrequencyIDRef_;}

       bool isCalculationPeriodDatesAdjustments(){return this->calculationPeriodDatesAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getCalculationPeriodDatesAdjustments();
      std::string getCalculationPeriodDatesAdjustmentsIDRef(){return calculationPeriodDatesAdjustmentsIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> calculationStartDate_;
       std::string calculationStartDateIDRef_;
       bool calculationStartDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> calculationEndDate_;
       std::string calculationEndDateIDRef_;
       bool calculationEndDateIsNull_;
       boost::shared_ptr<CalculationPeriodFrequency> calculationPeriodFrequency_;
       std::string calculationPeriodFrequencyIDRef_;
       bool calculationPeriodFrequencyIsNull_;
       boost::shared_ptr<BusinessDayAdjustments> calculationPeriodDatesAdjustments_;
       std::string calculationPeriodDatesAdjustmentsIDRef_;
       bool calculationPeriodDatesAdjustmentsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

