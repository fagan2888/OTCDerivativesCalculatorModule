// ScheduledDates.hpp 
#ifndef FpmlSerialized_ScheduledDates_hpp
#define FpmlSerialized_ScheduledDates_hpp

#include <ISerialized.hpp>
#include <fpml-valuation-5-4/ScheduledDate.hpp>

namespace FpmlSerialized {

class ScheduledDates : public ISerialized { 
   public: 
       ScheduledDates(TiXmlNode* xmlNode);

       bool isScheduledDate(){return this->scheduledDateIsNull_;}
       std::vector<boost::shared_ptr<ScheduledDate>> getScheduledDate();
      std::string getScheduledDateIDRef(){return scheduledDateIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ScheduledDate>> scheduledDate_;
       std::string scheduledDateIDRef_;
       bool scheduledDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

