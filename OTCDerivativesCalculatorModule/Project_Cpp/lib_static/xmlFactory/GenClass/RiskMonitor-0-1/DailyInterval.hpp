// DailyInterval.hpp 
#ifndef FpmlSerialized_DailyInterval_hpp
#define FpmlSerialized_DailyInterval_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class DailyInterval : public ISerialized { 
   public: 
       DailyInterval(TiXmlNode* xmlNode);

       bool isObservationStartDate(){return this->observationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getObservationStartDate();


       bool isObservationEndDate(){return this->observationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getObservationEndDate();


   protected: 
       boost::shared_ptr<XsdTypeDate> observationStartDate_;
       
       bool observationStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> observationEndDate_;
       
       bool observationEndDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

