// OrEventCal.hpp 
#ifndef FpmlSerialized_OrEventCal_hpp
#define FpmlSerialized_OrEventCal_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventCalculationList.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class OrEventCal : public ISerialized { 
   public: 
       OrEventCal(TiXmlNode* xmlNode);

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

