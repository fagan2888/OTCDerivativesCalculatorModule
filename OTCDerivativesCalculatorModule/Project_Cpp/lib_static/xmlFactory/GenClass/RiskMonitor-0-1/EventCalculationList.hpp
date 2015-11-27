// EventCalculationList.hpp 
#ifndef FpmlSerialized_EventCalculationList_hpp
#define FpmlSerialized_EventCalculationList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/EventCalculation.hpp>

namespace FpmlSerialized {

class EventCalculationList : public ISerialized { 
   public: 
       EventCalculationList(TiXmlNode* xmlNode);

       bool isEventCalculation(){return this->eventCalculationIsNull_;}
       std::vector<boost::shared_ptr<EventCalculation>> getEventCalculation();


   protected: 
       std::vector<boost::shared_ptr<EventCalculation>> eventCalculation_;
       
       bool eventCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

