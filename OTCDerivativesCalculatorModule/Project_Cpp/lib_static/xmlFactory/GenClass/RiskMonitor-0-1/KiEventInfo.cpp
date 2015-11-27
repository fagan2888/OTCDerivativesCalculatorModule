// KiEventInfo.cpp 
#include "KiEventInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

KiEventInfo::KiEventInfo(TiXmlNode* xmlNode)
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

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventTriggerNode , address : " << eventTriggerNode << std::endl;
   #endif
   if(eventTriggerNode)
   {
       eventTrigger_ = boost::shared_ptr<EventTrigger>(new EventTrigger(eventTriggerNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventTrigger> KiEventInfo::getEventTrigger()
{
   if(!this->eventTriggerIsNull_){
        return this->eventTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventTrigger>();
   }
}
}

