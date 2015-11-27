// EventSchedule.cpp 
#include "EventSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventSchedule::EventSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventCheckNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventCheckNode = xmlNode->FirstChildElement("eventCheck");

   if(eventCheckNode){eventCheckIsNull_ = false;}
   else{eventCheckIsNull_ = true;}

   if(eventCheckNode)
   {
      for(eventCheckNode; eventCheckNode; eventCheckNode = eventCheckNode->NextSiblingElement("eventCheck")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCheckNode , address : " << eventCheckNode << std::endl;
          #endif
          if(eventCheckNode->Attribute("href") || eventCheckNode->Attribute("id"))
          {
              if(eventCheckNode->Attribute("id"))
              {
                  eventCheckIDRef_ = eventCheckNode->Attribute("id");
                  eventCheck_.push_back(boost::shared_ptr<EventCheck>(new EventCheck(eventCheckNode)));
                  eventCheck_.back()->setID(eventCheckIDRef_);
                  IDManager::instance().setID(eventCheckIDRef_, eventCheck_.back());
              }
              else if(eventCheckNode->Attribute("href")) { eventCheckIDRef_ = eventCheckNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { eventCheck_.push_back(boost::shared_ptr<EventCheck>(new EventCheck(eventCheckNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCheckNode , address : " << eventCheckNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<EventCheck>> EventSchedule::getEventCheck()
{
   if(!this->eventCheckIsNull_){
        if(eventCheckIDRef_ != ""){
             return this->eventCheck_;
        }else{
             return this->eventCheck_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventCheck>>();
   }
}
}

