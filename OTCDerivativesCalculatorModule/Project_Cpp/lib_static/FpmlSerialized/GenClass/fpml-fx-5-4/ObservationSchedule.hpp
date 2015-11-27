// ObservationSchedule.hpp 
#ifndef FpmlSerialized_ObservationSchedule_hpp
#define FpmlSerialized_ObservationSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/Frequency.hpp>

namespace FpmlSerialized {

class ObservationSchedule : public ISerialized { 
   public: 
       ObservationSchedule(TiXmlNode* xmlNode);

       bool isStartDate(){return this->startDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getStartDate();
      std::string getStartDateIDRef(){return startDateIDRef_;}

       bool isEndDate(){return this->endDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEndDate();
      std::string getEndDateIDRef(){return endDateIDRef_;}

       bool isObservationPeriodFrequency(){return this->observationPeriodFrequencyIsNull_;}
       boost::shared_ptr<Frequency> getObservationPeriodFrequency();
      std::string getObservationPeriodFrequencyIDRef(){return observationPeriodFrequencyIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> startDate_;
       std::string startDateIDRef_;
       bool startDateIsNull_;
       boost::shared_ptr<XsdTypeDate> endDate_;
       std::string endDateIDRef_;
       bool endDateIsNull_;
       boost::shared_ptr<Frequency> observationPeriodFrequency_;
       std::string observationPeriodFrequencyIDRef_;
       bool observationPeriodFrequencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

