// EventCheck.cpp 
#include "EventCheck.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventCheck::EventCheck(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventCheckNormalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventCheckNormalNode = xmlNode->FirstChildElement("eventCheckNormal");

   if(eventCheckNormalNode){eventCheckNormalIsNull_ = false;}
   else{eventCheckNormalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCheckNormalNode , address : " << eventCheckNormalNode << std::endl;
   #endif
   if(eventCheckNormalNode)
   {
      if(eventCheckNormalNode->Attribute("href") || eventCheckNormalNode->Attribute("id"))
      {
          if(eventCheckNormalNode->Attribute("id"))
          {
             eventCheckNormalIDRef_ = eventCheckNormalNode->Attribute("id");
             eventCheckNormal_ = boost::shared_ptr<EventCheckNormal>(new EventCheckNormal(eventCheckNormalNode));
             eventCheckNormal_->setID(eventCheckNormalIDRef_);
             IDManager::instance().setID(eventCheckNormalIDRef_,eventCheckNormal_);
          }
          else if(eventCheckNormalNode->Attribute("href")) { eventCheckNormalIDRef_ = eventCheckNormalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventCheckNormal_ = boost::shared_ptr<EventCheckNormal>(new EventCheckNormal(eventCheckNormalNode));}
   }

   //eventCheckTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventCheckTimeNode = xmlNode->FirstChildElement("eventCheckTime");

   if(eventCheckTimeNode){eventCheckTimeIsNull_ = false;}
   else{eventCheckTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCheckTimeNode , address : " << eventCheckTimeNode << std::endl;
   #endif
   if(eventCheckTimeNode)
   {
      if(eventCheckTimeNode->Attribute("href") || eventCheckTimeNode->Attribute("id"))
      {
          if(eventCheckTimeNode->Attribute("id"))
          {
             eventCheckTimeIDRef_ = eventCheckTimeNode->Attribute("id");
             eventCheckTime_ = boost::shared_ptr<EventCheckTime>(new EventCheckTime(eventCheckTimeNode));
             eventCheckTime_->setID(eventCheckTimeIDRef_);
             IDManager::instance().setID(eventCheckTimeIDRef_,eventCheckTime_);
          }
          else if(eventCheckTimeNode->Attribute("href")) { eventCheckTimeIDRef_ = eventCheckTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventCheckTime_ = boost::shared_ptr<EventCheckTime>(new EventCheckTime(eventCheckTimeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventCheckNormal> EventCheck::getEventCheckNormal()
{
   if(!this->eventCheckNormalIsNull_){
        if(eventCheckNormalIDRef_ != ""){
             return boost::shared_static_cast<EventCheckNormal>(IDManager::instance().getID(eventCheckNormalIDRef_));
        }else{
             return this->eventCheckNormal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventCheckNormal>();
   }
}
boost::shared_ptr<EventCheckTime> EventCheck::getEventCheckTime()
{
   if(!this->eventCheckTimeIsNull_){
        if(eventCheckTimeIDRef_ != ""){
             return boost::shared_static_cast<EventCheckTime>(IDManager::instance().getID(eventCheckTimeIDRef_));
        }else{
             return this->eventCheckTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventCheckTime>();
   }
}
}

