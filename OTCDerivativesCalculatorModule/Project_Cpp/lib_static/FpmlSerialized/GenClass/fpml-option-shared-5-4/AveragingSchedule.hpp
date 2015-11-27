// AveragingSchedule.hpp 
#ifndef FpmlSerialized_AveragingSchedule_hpp
#define FpmlSerialized_AveragingSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/CalculationPeriodFrequency.hpp>

namespace FpmlSerialized {

class AveragingSchedule : public ISerialized { 
   public: 
       AveragingSchedule(TiXmlNode* xmlNode);

       bool isStartDate(){return this->startDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getStartDate();
      std::string getStartDateIDRef(){return startDateIDRef_;}

       bool isEndDate(){return this->endDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEndDate();
      std::string getEndDateIDRef(){return endDateIDRef_;}

       bool isAveragingPeriodFrequency(){return this->averagingPeriodFrequencyIsNull_;}
       boost::shared_ptr<CalculationPeriodFrequency> getAveragingPeriodFrequency();
      std::string getAveragingPeriodFrequencyIDRef(){return averagingPeriodFrequencyIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> startDate_;
       std::string startDateIDRef_;
       bool startDateIsNull_;
       boost::shared_ptr<XsdTypeDate> endDate_;
       std::string endDateIDRef_;
       bool endDateIsNull_;
       boost::shared_ptr<CalculationPeriodFrequency> averagingPeriodFrequency_;
       std::string averagingPeriodFrequencyIDRef_;
       bool averagingPeriodFrequencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

