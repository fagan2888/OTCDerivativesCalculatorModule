// StructuredProductPayoff.hpp 
#ifndef FpmlSerialized_StructuredProductPayoff_hpp
#define FpmlSerialized_StructuredProductPayoff_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/BaseInformation.hpp>
#include <ahn-product-1-0/EventSchedule.hpp>

namespace FpmlSerialized {

class StructuredProductPayoff : public ISerialized { 
   public: 
       StructuredProductPayoff(TiXmlNode* xmlNode);

       bool isBaseInformation(){return this->baseInformationIsNull_;}
       boost::shared_ptr<BaseInformation> getBaseInformation();
      std::string getBaseInformationIDRef(){return baseInformationIDRef_;}

       bool isEventSchedule(){return this->eventScheduleIsNull_;}
       boost::shared_ptr<EventSchedule> getEventSchedule();
      std::string getEventScheduleIDRef(){return eventScheduleIDRef_;}

   protected: 
       boost::shared_ptr<BaseInformation> baseInformation_;
       std::string baseInformationIDRef_;
       bool baseInformationIsNull_;
       boost::shared_ptr<EventSchedule> eventSchedule_;
       std::string eventScheduleIDRef_;
       bool eventScheduleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

