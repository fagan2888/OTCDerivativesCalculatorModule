// EventCalculationInfo.hpp 
#ifndef FpmlSerialized_EventCalculationInfo_hpp
#define FpmlSerialized_EventCalculationInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PreConditionEvent.hpp>
#include <RiskMonitor-0-1/EventCalculation.hpp>
#include <RiskMonitor-0-1/JointSimpleCalculation.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <RiskMonitor-0-1/RefVariable_eventOcc.hpp>

namespace FpmlSerialized {

class EventCalculationInfo : public ISerialized { 
   public: 
       EventCalculationInfo(TiXmlNode* xmlNode);

       bool isPreConditionEvent(){return this->preConditionEventIsNull_;}
       boost::shared_ptr<PreConditionEvent> getPreConditionEvent();


       bool isEventCalculation(){return this->eventCalculationIsNull_;}
       std::vector<boost::shared_ptr<EventCalculation>> getEventCalculation();


       bool isJointSimpleCalculation(){return this->jointSimpleCalculationIsNull_;}
       boost::shared_ptr<JointSimpleCalculation> getJointSimpleCalculation();


       bool isPastEventOcc(){return this->pastEventOccIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPastEventOcc();


       bool isRefVariable_eventOcc(){return this->refVariable_eventOccIsNull_;}
       boost::shared_ptr<RefVariable_eventOcc> getRefVariable_eventOcc();


   protected: 
       boost::shared_ptr<PreConditionEvent> preConditionEvent_;
       
       bool preConditionEventIsNull_;
       std::vector<boost::shared_ptr<EventCalculation>> eventCalculation_;
       
       bool eventCalculationIsNull_;
       boost::shared_ptr<JointSimpleCalculation> jointSimpleCalculation_;
       
       bool jointSimpleCalculationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> pastEventOcc_;
       
       bool pastEventOccIsNull_;
       boost::shared_ptr<RefVariable_eventOcc> refVariable_eventOcc_;
       
       bool refVariable_eventOccIsNull_;

};

} //namespaceFpmlSerialized end
#endif

