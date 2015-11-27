// GeneralTerminationEvent.hpp 
#ifndef FpmlSerialized_GeneralTerminationEvent_hpp
#define FpmlSerialized_GeneralTerminationEvent_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/GeneralTerminationEventDetail.hpp>

namespace FpmlSerialized {

class GeneralTerminationEvent : public ISerialized { 
   public: 
       GeneralTerminationEvent(TiXmlNode* xmlNode);

       bool isDetailTerminationType(){return this->detailTerminationTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDetailTerminationType();


       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isGeneralTerminationEventDetail(){return this->generalTerminationEventDetailIsNull_;}
       boost::shared_ptr<GeneralTerminationEventDetail> getGeneralTerminationEventDetail();


   protected: 
       boost::shared_ptr<XsdTypeToken> detailTerminationType_;
       
       bool detailTerminationTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<GeneralTerminationEventDetail> generalTerminationEventDetail_;
       
       bool generalTerminationEventDetailIsNull_;

};

} //namespaceFpmlSerialized end
#endif

