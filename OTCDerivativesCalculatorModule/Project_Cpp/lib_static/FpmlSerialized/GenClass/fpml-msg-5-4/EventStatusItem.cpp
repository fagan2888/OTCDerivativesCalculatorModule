// EventStatusItem.cpp 
#include "EventStatusItem.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventStatusItem::EventStatusItem(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventIdentifierNode = xmlNode->FirstChildElement("eventIdentifier");

   if(eventIdentifierNode){eventIdentifierIsNull_ = false;}
   else{eventIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventIdentifierNode , address : " << eventIdentifierNode << std::endl;
   #endif
   if(eventIdentifierNode)
   {
      if(eventIdentifierNode->Attribute("href") || eventIdentifierNode->Attribute("id"))
      {
          if(eventIdentifierNode->Attribute("id"))
          {
             eventIdentifierIDRef_ = eventIdentifierNode->Attribute("id");
             eventIdentifier_ = boost::shared_ptr<EventIdentifier>(new EventIdentifier(eventIdentifierNode));
             eventIdentifier_->setID(eventIdentifierIDRef_);
             IDManager::instance().setID(eventIdentifierIDRef_,eventIdentifier_);
          }
          else if(eventIdentifierNode->Attribute("href")) { eventIdentifierIDRef_ = eventIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventIdentifier_ = boost::shared_ptr<EventIdentifier>(new EventIdentifier(eventIdentifierNode));}
   }

   //statusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* statusNode = xmlNode->FirstChildElement("status");

   if(statusNode){statusIsNull_ = false;}
   else{statusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusNode , address : " << statusNode << std::endl;
   #endif
   if(statusNode)
   {
      if(statusNode->Attribute("href") || statusNode->Attribute("id"))
      {
          if(statusNode->Attribute("id"))
          {
             statusIDRef_ = statusNode->Attribute("id");
             status_ = boost::shared_ptr<EventStatus>(new EventStatus(statusNode));
             status_->setID(statusIDRef_);
             IDManager::instance().setID(statusIDRef_,status_);
          }
          else if(statusNode->Attribute("href")) { statusIDRef_ = statusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { status_ = boost::shared_ptr<EventStatus>(new EventStatus(statusNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventIdentifier> EventStatusItem::getEventIdentifier()
{
   if(!this->eventIdentifierIsNull_){
        if(eventIdentifierIDRef_ != ""){
             return boost::shared_static_cast<EventIdentifier>(IDManager::instance().getID(eventIdentifierIDRef_));
        }else{
             return this->eventIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventIdentifier>();
   }
}
boost::shared_ptr<EventStatus> EventStatusItem::getStatus()
{
   if(!this->statusIsNull_){
        if(statusIDRef_ != ""){
             return boost::shared_static_cast<EventStatus>(IDManager::instance().getID(statusIDRef_));
        }else{
             return this->status_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventStatus>();
   }
}
}

