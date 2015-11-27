// StepDownKIPayoff.cpp 
#include "StepDownKIPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StepDownKIPayoff::StepDownKIPayoff(TiXmlNode* xmlNode)
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

   //kiEventInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* kiEventInfoNode = xmlNode->FirstChildElement("kiEventInfo");

   if(kiEventInfoNode){kiEventInfoIsNull_ = false;}
   else{kiEventInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- kiEventInfoNode , address : " << kiEventInfoNode << std::endl;
   #endif
   if(kiEventInfoNode)
   {
       kiEventInfo_ = boost::shared_ptr<KiEventInfo>(new KiEventInfo(kiEventInfoNode));
   }

   //nonKiEventInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonKiEventInfoNode = xmlNode->FirstChildElement("nonKiEventInfo");

   if(nonKiEventInfoNode){nonKiEventInfoIsNull_ = false;}
   else{nonKiEventInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonKiEventInfoNode , address : " << nonKiEventInfoNode << std::endl;
   #endif
   if(nonKiEventInfoNode)
   {
       nonKiEventInfo_ = boost::shared_ptr<NonKiEventInfo>(new NonKiEventInfo(nonKiEventInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventTriggerList> StepDownKIPayoff::getEventTriggerList()
{
   if(!this->eventTriggerListIsNull_){
        return this->eventTriggerList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventTriggerList>();
   }
}
boost::shared_ptr<KiEventInfo> StepDownKIPayoff::getKiEventInfo()
{
   if(!this->kiEventInfoIsNull_){
        return this->kiEventInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<KiEventInfo>();
   }
}
boost::shared_ptr<NonKiEventInfo> StepDownKIPayoff::getNonKiEventInfo()
{
   if(!this->nonKiEventInfoIsNull_){
        return this->nonKiEventInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonKiEventInfo>();
   }
}
}

