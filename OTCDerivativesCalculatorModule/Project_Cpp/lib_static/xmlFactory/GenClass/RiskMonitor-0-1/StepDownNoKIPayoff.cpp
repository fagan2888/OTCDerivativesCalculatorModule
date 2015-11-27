// StepDownNoKIPayoff.cpp 
#include "StepDownNoKIPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StepDownNoKIPayoff::StepDownNoKIPayoff(TiXmlNode* xmlNode)
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

   //noAutoCallReturnTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* noAutoCallReturnTriggerNode = xmlNode->FirstChildElement("noAutoCallReturnTrigger");

   if(noAutoCallReturnTriggerNode){noAutoCallReturnTriggerIsNull_ = false;}
   else{noAutoCallReturnTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- noAutoCallReturnTriggerNode , address : " << noAutoCallReturnTriggerNode << std::endl;
   #endif
   if(noAutoCallReturnTriggerNode)
   {
       noAutoCallReturnTrigger_ = boost::shared_ptr<NoAutoCallReturnTrigger>(new NoAutoCallReturnTrigger(noAutoCallReturnTriggerNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventTriggerList> StepDownNoKIPayoff::getEventTriggerList()
{
   if(!this->eventTriggerListIsNull_){
        return this->eventTriggerList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventTriggerList>();
   }
}
boost::shared_ptr<NoAutoCallReturnTrigger> StepDownNoKIPayoff::getNoAutoCallReturnTrigger()
{
   if(!this->noAutoCallReturnTriggerIsNull_){
        return this->noAutoCallReturnTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NoAutoCallReturnTrigger>();
   }
}
}

