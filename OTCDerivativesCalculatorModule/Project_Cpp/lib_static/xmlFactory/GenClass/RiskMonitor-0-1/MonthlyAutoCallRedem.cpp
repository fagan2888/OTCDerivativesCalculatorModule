// MonthlyAutoCallRedem.cpp 
#include "MonthlyAutoCallRedem.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MonthlyAutoCallRedem::MonthlyAutoCallRedem(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventTriggerNode = xmlNode->FirstChildElement("eventTrigger");

   if(eventTriggerNode){eventTriggerIsNull_ = false;}
   else{eventTriggerIsNull_ = true;}

   if(eventTriggerNode)
   {
      for(eventTriggerNode; eventTriggerNode; eventTriggerNode = eventTriggerNode->NextSiblingElement("eventTrigger")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventTriggerNode , address : " << eventTriggerNode << std::endl;
          #endif
          eventTrigger_.push_back(boost::shared_ptr<EventTrigger>(new EventTrigger(eventTriggerNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventTriggerNode , address : " << eventTriggerNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<EventTrigger>> MonthlyAutoCallRedem::getEventTrigger()
{
   if(!this->eventTriggerIsNull_){
        return this->eventTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventTrigger>>();
   }
}
}

