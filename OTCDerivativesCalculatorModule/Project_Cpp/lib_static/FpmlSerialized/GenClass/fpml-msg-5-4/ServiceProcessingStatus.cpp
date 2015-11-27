// ServiceProcessingStatus.cpp 
#include "ServiceProcessingStatus.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ServiceProcessingStatus::ServiceProcessingStatus(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //cycleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cycleNode = xmlNode->FirstChildElement("cycle");

   if(cycleNode){cycleIsNull_ = false;}
   else{cycleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cycleNode , address : " << cycleNode << std::endl;
   #endif
   if(cycleNode)
   {
      if(cycleNode->Attribute("href") || cycleNode->Attribute("id"))
      {
          if(cycleNode->Attribute("id"))
          {
             cycleIDRef_ = cycleNode->Attribute("id");
             cycle_ = boost::shared_ptr<ServiceProcessingCycle>(new ServiceProcessingCycle(cycleNode));
             cycle_->setID(cycleIDRef_);
             IDManager::instance().setID(cycleIDRef_,cycle_);
          }
          else if(cycleNode->Attribute("href")) { cycleIDRef_ = cycleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cycle_ = boost::shared_ptr<ServiceProcessingCycle>(new ServiceProcessingCycle(cycleNode));}
   }

   //stepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stepNode = xmlNode->FirstChildElement("step");

   if(stepNode){stepIsNull_ = false;}
   else{stepIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepNode , address : " << stepNode << std::endl;
   #endif
   if(stepNode)
   {
      if(stepNode->Attribute("href") || stepNode->Attribute("id"))
      {
          if(stepNode->Attribute("id"))
          {
             stepIDRef_ = stepNode->Attribute("id");
             step_ = boost::shared_ptr<ServiceProcessingStep>(new ServiceProcessingStep(stepNode));
             step_->setID(stepIDRef_);
             IDManager::instance().setID(stepIDRef_,step_);
          }
          else if(stepNode->Attribute("href")) { stepIDRef_ = stepNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { step_ = boost::shared_ptr<ServiceProcessingStep>(new ServiceProcessingStep(stepNode));}
   }

   //eventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventNode = xmlNode->FirstChildElement("event");

   if(eventNode){eventIsNull_ = false;}
   else{eventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventNode , address : " << eventNode << std::endl;
   #endif
   if(eventNode)
   {
      if(eventNode->Attribute("href") || eventNode->Attribute("id"))
      {
          if(eventNode->Attribute("id"))
          {
             eventIDRef_ = eventNode->Attribute("id");
             event_ = boost::shared_ptr<ServiceProcessingEvent>(new ServiceProcessingEvent(eventNode));
             event_->setID(eventIDRef_);
             IDManager::instance().setID(eventIDRef_,event_);
          }
          else if(eventNode->Attribute("href")) { eventIDRef_ = eventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { event_ = boost::shared_ptr<ServiceProcessingEvent>(new ServiceProcessingEvent(eventNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ServiceProcessingCycle> ServiceProcessingStatus::getCycle()
{
   if(!this->cycleIsNull_){
        if(cycleIDRef_ != ""){
             return boost::shared_static_cast<ServiceProcessingCycle>(IDManager::instance().getID(cycleIDRef_));
        }else{
             return this->cycle_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ServiceProcessingCycle>();
   }
}
boost::shared_ptr<ServiceProcessingStep> ServiceProcessingStatus::getStep()
{
   if(!this->stepIsNull_){
        if(stepIDRef_ != ""){
             return boost::shared_static_cast<ServiceProcessingStep>(IDManager::instance().getID(stepIDRef_));
        }else{
             return this->step_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ServiceProcessingStep>();
   }
}
boost::shared_ptr<ServiceProcessingEvent> ServiceProcessingStatus::getEvent()
{
   if(!this->eventIsNull_){
        if(eventIDRef_ != ""){
             return boost::shared_static_cast<ServiceProcessingEvent>(IDManager::instance().getID(eventIDRef_));
        }else{
             return this->event_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ServiceProcessingEvent>();
   }
}
}

