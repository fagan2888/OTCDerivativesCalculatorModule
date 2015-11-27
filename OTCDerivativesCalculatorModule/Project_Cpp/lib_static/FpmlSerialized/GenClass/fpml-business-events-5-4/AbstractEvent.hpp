// AbstractEvent.hpp 
#ifndef FpmlSerialized_AbstractEvent_hpp
#define FpmlSerialized_AbstractEvent_hpp

#include <ISerialized.hpp>
#include <fpml-business-events-5-4/BusinessEventIdentifier.hpp>

namespace FpmlSerialized {

class AbstractEvent : public ISerialized { 
   public: 
       AbstractEvent(TiXmlNode* xmlNode);

       bool isEventIdentifier(){return this->eventIdentifierIsNull_;}
       std::vector<boost::shared_ptr<BusinessEventIdentifier>> getEventIdentifier();
      std::string getEventIdentifierIDRef(){return eventIdentifierIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<BusinessEventIdentifier>> eventIdentifier_;
       std::string eventIdentifierIDRef_;
       bool eventIdentifierIsNull_;

};

} //namespaceFpmlSerialized end
#endif

