// EventSchedule.hpp 
#ifndef FpmlSerialized_EventSchedule_hpp
#define FpmlSerialized_EventSchedule_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/EventCheck.hpp>

namespace FpmlSerialized {

class EventSchedule : public ISerialized { 
   public: 
       EventSchedule(TiXmlNode* xmlNode);

       bool isEventCheck(){return this->eventCheckIsNull_;}
       std::vector<boost::shared_ptr<EventCheck>> getEventCheck();
      std::string getEventCheckIDRef(){return eventCheckIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<EventCheck>> eventCheck_;
       std::string eventCheckIDRef_;
       bool eventCheckIsNull_;

};

} //namespaceFpmlSerialized end
#endif

