// StandardPayoff_A.cpp 
#include "StandardPayoff_A.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StandardPayoff_A::StandardPayoff_A(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventTriggerList_ANode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventTriggerList_ANode = xmlNode->FirstChildElement("eventTriggerList_A");

   if(eventTriggerList_ANode){eventTriggerList_AIsNull_ = false;}
   else{eventTriggerList_AIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventTriggerList_ANode , address : " << eventTriggerList_ANode << std::endl;
   #endif
   if(eventTriggerList_ANode)
   {
       eventTriggerList_A_ = boost::shared_ptr<EventTriggerList_A>(new EventTriggerList_A(eventTriggerList_ANode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventTriggerList_A> StandardPayoff_A::getEventTriggerList_A()
{
   if(!this->eventTriggerList_AIsNull_){
        return this->eventTriggerList_A_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventTriggerList_A>();
   }
}
}

