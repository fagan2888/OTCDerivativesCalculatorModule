// EventCheckNormal.cpp 
#include "EventCheckNormal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventCheckNormal::EventCheckNormal(TiXmlNode* xmlNode)
: EventCheckBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDateNode = xmlNode->FirstChildElement("eventDate");

   if(eventDateNode){eventDateIsNull_ = false;}
   else{eventDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDateNode , address : " << eventDateNode << std::endl;
   #endif
   if(eventDateNode)
   {
      if(eventDateNode->Attribute("href") || eventDateNode->Attribute("id"))
      {
          if(eventDateNode->Attribute("id"))
          {
             eventDateIDRef_ = eventDateNode->Attribute("id");
             eventDate_ = boost::shared_ptr<EventDate>(new EventDate(eventDateNode));
             eventDate_->setID(eventDateIDRef_);
             IDManager::instance().setID(eventDateIDRef_,eventDate_);
          }
          else if(eventDateNode->Attribute("href")) { eventDateIDRef_ = eventDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventDate_ = boost::shared_ptr<EventDate>(new EventDate(eventDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventDate> EventCheckNormal::getEventDate()
{
   if(!this->eventDateIsNull_){
        if(eventDateIDRef_ != ""){
             return boost::shared_static_cast<EventDate>(IDManager::instance().getID(eventDateIDRef_));
        }else{
             return this->eventDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventDate>();
   }
}
}

