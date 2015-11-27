// EventTriggerList_A.cpp 
#include "EventTriggerList_A.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventTriggerList_A::EventTriggerList_A(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventTrigger_ANode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventTrigger_ANode = xmlNode->FirstChildElement("eventTrigger_A");

   if(eventTrigger_ANode){eventTrigger_AIsNull_ = false;}
   else{eventTrigger_AIsNull_ = true;}

   if(eventTrigger_ANode)
   {
      for(eventTrigger_ANode; eventTrigger_ANode; eventTrigger_ANode = eventTrigger_ANode->NextSiblingElement("eventTrigger_A")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventTrigger_ANode , address : " << eventTrigger_ANode << std::endl;
          #endif
          eventTrigger_A_.push_back(boost::shared_ptr<EventTrigger_A>(new EventTrigger_A(eventTrigger_ANode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventTrigger_ANode , address : " << eventTrigger_ANode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<EventTrigger_A>> EventTriggerList_A::getEventTrigger_A()
{
   if(!this->eventTrigger_AIsNull_){
        return this->eventTrigger_A_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventTrigger_A>>();
   }
}
}

