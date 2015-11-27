// AutoCallablePayoff.cpp 
#include "AutoCallablePayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AutoCallablePayoff::AutoCallablePayoff(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventTriggerListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventTriggerListNode = xmlNode->FirstChildElement("eventTriggerList");

   if(eventTriggerListNode){eventTriggerListIsNull_ = false;}
   else{eventTriggerListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventTriggerListNode , address : " << eventTriggerListNode << std::endl;
   #endif
   if(eventTriggerListNode)
   {
       eventTriggerList_ = boost::shared_ptr<EventTriggerList>(new EventTriggerList(eventTriggerListNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventTriggerList> AutoCallablePayoff::getEventTriggerList()
{
   if(!this->eventTriggerListIsNull_){
        return this->eventTriggerList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventTriggerList>();
   }
}
}

