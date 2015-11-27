// EventCheckTime.cpp 
#include "EventCheckTime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventCheckTime::EventCheckTime(TiXmlNode* xmlNode)
: EventCheckBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDatesNode = xmlNode->FirstChildElement("eventDates");

   if(eventDatesNode){eventDatesIsNull_ = false;}
   else{eventDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDatesNode , address : " << eventDatesNode << std::endl;
   #endif
   if(eventDatesNode)
   {
      if(eventDatesNode->Attribute("href") || eventDatesNode->Attribute("id"))
      {
          if(eventDatesNode->Attribute("id"))
          {
             eventDatesIDRef_ = eventDatesNode->Attribute("id");
             eventDates_ = boost::shared_ptr<EventDates>(new EventDates(eventDatesNode));
             eventDates_->setID(eventDatesIDRef_);
             IDManager::instance().setID(eventDatesIDRef_,eventDates_);
          }
          else if(eventDatesNode->Attribute("href")) { eventDatesIDRef_ = eventDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventDates_ = boost::shared_ptr<EventDates>(new EventDates(eventDatesNode));}
   }

   //jointTimeEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointTimeEventNode = xmlNode->FirstChildElement("jointTimeEvent");

   if(jointTimeEventNode){jointTimeEventIsNull_ = false;}
   else{jointTimeEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointTimeEventNode , address : " << jointTimeEventNode << std::endl;
   #endif
   if(jointTimeEventNode)
   {
      if(jointTimeEventNode->Attribute("href") || jointTimeEventNode->Attribute("id"))
      {
          if(jointTimeEventNode->Attribute("id"))
          {
             jointTimeEventIDRef_ = jointTimeEventNode->Attribute("id");
             jointTimeEvent_ = boost::shared_ptr<JointTimeEvent>(new JointTimeEvent(jointTimeEventNode));
             jointTimeEvent_->setID(jointTimeEventIDRef_);
             IDManager::instance().setID(jointTimeEventIDRef_,jointTimeEvent_);
          }
          else if(jointTimeEventNode->Attribute("href")) { jointTimeEventIDRef_ = jointTimeEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { jointTimeEvent_ = boost::shared_ptr<JointTimeEvent>(new JointTimeEvent(jointTimeEventNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventDates> EventCheckTime::getEventDates()
{
   if(!this->eventDatesIsNull_){
        if(eventDatesIDRef_ != ""){
             return boost::shared_static_cast<EventDates>(IDManager::instance().getID(eventDatesIDRef_));
        }else{
             return this->eventDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventDates>();
   }
}
boost::shared_ptr<JointTimeEvent> EventCheckTime::getJointTimeEvent()
{
   if(!this->jointTimeEventIsNull_){
        if(jointTimeEventIDRef_ != ""){
             return boost::shared_static_cast<JointTimeEvent>(IDManager::instance().getID(jointTimeEventIDRef_));
        }else{
             return this->jointTimeEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<JointTimeEvent>();
   }
}
}

