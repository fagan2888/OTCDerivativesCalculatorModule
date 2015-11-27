// IndexRef.hpp 
#ifndef FpmlSerialized_IndexRef_hpp
#define FpmlSerialized_IndexRef_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/UnderlyingIndex.hpp>
#include <ahn-product-1-0/EventDate.hpp>
#include <ahn-product-1-0/FixingDays.hpp>

namespace FpmlSerialized {

class IndexRef : public ISerialized { 
   public: 
       IndexRef(TiXmlNode* xmlNode);

       bool isUnderlyingIndexRef(){return this->underlyingIndexRefIsNull_;}
       boost::shared_ptr<UnderlyingIndex> getUnderlyingIndexRef();
      std::string getUnderlyingIndexRefIDRef(){return underlyingIndexRefIDRef_;}

       bool isEventDateRef(){return this->eventDateRefIsNull_;}
       boost::shared_ptr<EventDate> getEventDateRef();
      std::string getEventDateRefIDRef(){return eventDateRefIDRef_;}

       bool isFixingDays(){return this->fixingDaysIsNull_;}
       boost::shared_ptr<FixingDays> getFixingDays();
      std::string getFixingDaysIDRef(){return fixingDaysIDRef_;}

   protected: 
       boost::shared_ptr<UnderlyingIndex> underlyingIndexRef_;
       std::string underlyingIndexRefIDRef_;
       bool underlyingIndexRefIsNull_;
       boost::shared_ptr<EventDate> eventDateRef_;
       std::string eventDateRefIDRef_;
       bool eventDateRefIsNull_;
       boost::shared_ptr<FixingDays> fixingDays_;
       std::string fixingDaysIDRef_;
       bool fixingDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

