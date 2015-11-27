// DateRef.hpp 
#ifndef FpmlSerialized_DateRef_hpp
#define FpmlSerialized_DateRef_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/EventDate.hpp>
#include <ahn-product-1-0/FixingDays.hpp>

namespace FpmlSerialized {

class DateRef : public ISerialized { 
   public: 
       DateRef(TiXmlNode* xmlNode);

       bool isEventDateRef(){return this->eventDateRefIsNull_;}
       boost::shared_ptr<EventDate> getEventDateRef();
      std::string getEventDateRefIDRef(){return eventDateRefIDRef_;}

       bool isFixingDays(){return this->fixingDaysIsNull_;}
       boost::shared_ptr<FixingDays> getFixingDays();
      std::string getFixingDaysIDRef(){return fixingDaysIDRef_;}

   protected: 
       boost::shared_ptr<EventDate> eventDateRef_;
       std::string eventDateRefIDRef_;
       bool eventDateRefIsNull_;
       boost::shared_ptr<FixingDays> fixingDays_;
       std::string fixingDaysIDRef_;
       bool fixingDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

