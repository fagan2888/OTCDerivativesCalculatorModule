// EventCheckBase.hpp 
#ifndef FpmlSerialized_EventCheckBase_hpp
#define FpmlSerialized_EventCheckBase_hpp

#include <ahn-product-1-0/IEventCheck.hpp>
#include <ahn-product-1-0/EventIndexTransformation.hpp>
#include <ahn-product-1-0/FunctionEvents.hpp>
#include <ahn-product-1-0/PayoffBase.hpp>
#include <ahn-product-1-0/SubEvent.hpp>
#include <ahn-product-1-0/JointSubEvent.hpp>
#include <ahn-product-1-0/JointFSubEvent.hpp>

namespace FpmlSerialized {

class EventCheckBase : public IEventCheck { 
   public: 
       EventCheckBase(TiXmlNode* xmlNode);

       bool isEventIndexTransformation(){return this->eventIndexTransformationIsNull_;}
       boost::shared_ptr<EventIndexTransformation> getEventIndexTransformation();
      std::string getEventIndexTransformationIDRef(){return eventIndexTransformationIDRef_;}

       bool isFunctionEvents(){return this->functionEventsIsNull_;}
       boost::shared_ptr<FunctionEvents> getFunctionEvents();
      std::string getFunctionEventsIDRef(){return functionEventsIDRef_;}

       bool isPayoffBase(){return this->payoffBaseIsNull_;}
       boost::shared_ptr<PayoffBase> getPayoffBase();
      std::string getPayoffBaseIDRef(){return payoffBaseIDRef_;}

       bool isSubEvent(){return this->subEventIsNull_;}
       boost::shared_ptr<SubEvent> getSubEvent();
      std::string getSubEventIDRef(){return subEventIDRef_;}

       bool isJointSubEvent(){return this->jointSubEventIsNull_;}
       boost::shared_ptr<JointSubEvent> getJointSubEvent();
      std::string getJointSubEventIDRef(){return jointSubEventIDRef_;}

       bool isJointFSubEvent(){return this->jointFSubEventIsNull_;}
       boost::shared_ptr<JointFSubEvent> getJointFSubEvent();
      std::string getJointFSubEventIDRef(){return jointFSubEventIDRef_;}

   protected: 
       boost::shared_ptr<EventIndexTransformation> eventIndexTransformation_;
       std::string eventIndexTransformationIDRef_;
       bool eventIndexTransformationIsNull_;
       boost::shared_ptr<FunctionEvents> functionEvents_;
       std::string functionEventsIDRef_;
       bool functionEventsIsNull_;
       boost::shared_ptr<PayoffBase> payoffBase_;
       std::string payoffBaseIDRef_;
       bool payoffBaseIsNull_;
       boost::shared_ptr<SubEvent> subEvent_;
       std::string subEventIDRef_;
       bool subEventIsNull_;
       boost::shared_ptr<JointSubEvent> jointSubEvent_;
       std::string jointSubEventIDRef_;
       bool jointSubEventIsNull_;
       boost::shared_ptr<JointFSubEvent> jointFSubEvent_;
       std::string jointFSubEventIDRef_;
       bool jointFSubEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

