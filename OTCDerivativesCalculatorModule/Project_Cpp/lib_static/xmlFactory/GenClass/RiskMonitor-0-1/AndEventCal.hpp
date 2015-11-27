// AndEventCal.hpp 
#ifndef FpmlSerialized_AndEventCal_hpp
#define FpmlSerialized_AndEventCal_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventCalculationList.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class AndEventCal : public ISerialized { 
   public: 
       AndEventCal(TiXmlNode* xmlNode);

       bool isEventCalculationList(){return this->eventCalculationListIsNull_;}
       boost::shared_ptr<EventCalculationList> getEventCalculationList();


       bool isComplement(){return this->complementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getComplement();


   protected: 
       boost::shared_ptr<EventCalculationList> eventCalculationList_;
       
       bool eventCalculationListIsNull_;
       boost::shared_ptr<XsdTypeBoolean> complement_;
       
       bool complementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

