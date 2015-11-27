// ServiceProcessingStatus.hpp 
#ifndef FpmlSerialized_ServiceProcessingStatus_hpp
#define FpmlSerialized_ServiceProcessingStatus_hpp

#include <ISerialized.hpp>
#include <fpml-msg-5-4/ServiceProcessingCycle.hpp>
#include <fpml-msg-5-4/ServiceProcessingStep.hpp>
#include <fpml-msg-5-4/ServiceProcessingEvent.hpp>

namespace FpmlSerialized {

class ServiceProcessingStatus : public ISerialized { 
   public: 
       ServiceProcessingStatus(TiXmlNode* xmlNode);

       bool isCycle(){return this->cycleIsNull_;}
       boost::shared_ptr<ServiceProcessingCycle> getCycle();
      std::string getCycleIDRef(){return cycleIDRef_;}

       bool isStep(){return this->stepIsNull_;}
       boost::shared_ptr<ServiceProcessingStep> getStep();
      std::string getStepIDRef(){return stepIDRef_;}

       bool isEvent(){return this->eventIsNull_;}
       boost::shared_ptr<ServiceProcessingEvent> getEvent();
      std::string getEventIDRef(){return eventIDRef_;}

   protected: 
       boost::shared_ptr<ServiceProcessingCycle> cycle_;
       std::string cycleIDRef_;
       bool cycleIsNull_;
       boost::shared_ptr<ServiceProcessingStep> step_;
       std::string stepIDRef_;
       bool stepIsNull_;
       boost::shared_ptr<ServiceProcessingEvent> event_;
       std::string eventIDRef_;
       bool eventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

