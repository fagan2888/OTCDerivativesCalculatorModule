// RefVariable_eventOcc.cpp 
#include "RefVariable_eventOcc.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RefVariable_eventOcc::RefVariable_eventOcc(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //variableEventInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* variableEventInfoNode = xmlNode->FirstChildElement("variableEventInfo");

   if(variableEventInfoNode){variableEventInfoIsNull_ = false;}
   else{variableEventInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- variableEventInfoNode , address : " << variableEventInfoNode << std::endl;
   #endif
   if(variableEventInfoNode)
   {
       variableEventInfo_ = boost::shared_ptr<VariableEventInfo>(new VariableEventInfo(variableEventInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<VariableEventInfo> RefVariable_eventOcc::getVariableEventInfo()
{
   if(!this->variableEventInfoIsNull_){
        return this->variableEventInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VariableEventInfo>();
   }
}
}

