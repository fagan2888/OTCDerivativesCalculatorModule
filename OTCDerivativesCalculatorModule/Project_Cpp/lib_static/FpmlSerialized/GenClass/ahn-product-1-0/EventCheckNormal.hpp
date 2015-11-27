// EventCheckNormal.hpp 
#ifndef FpmlSerialized_EventCheckNormal_hpp
#define FpmlSerialized_EventCheckNormal_hpp

#include <ahn-product-1-0/EventCheckBase.hpp>
#include <ahn-product-1-0/EventDate.hpp>

namespace FpmlSerialized {

class EventCheckNormal : public EventCheckBase { 
   public: 
       EventCheckNormal(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<EventDate> getEventDate();
      std::string getEventDateIDRef(){return eventDateIDRef_;}

   protected: 
       boost::shared_ptr<EventDate> eventDate_;
       std::string eventDateIDRef_;
       bool eventDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

