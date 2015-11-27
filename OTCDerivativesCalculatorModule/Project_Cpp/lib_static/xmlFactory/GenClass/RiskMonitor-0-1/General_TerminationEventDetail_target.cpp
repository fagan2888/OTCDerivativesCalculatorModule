// General_TerminationEventDetail_target.cpp 
#include "General_TerminationEventDetail_target.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

General_TerminationEventDetail_target::General_TerminationEventDetail_target(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //targetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* targetNode = xmlNode->FirstChildElement("target");

   if(targetNode){targetIsNull_ = false;}
   else{targetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- targetNode , address : " << targetNode << std::endl;
   #endif
   if(targetNode)
   {
       target_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(targetNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> General_TerminationEventDetail_target::getTarget()
{
   if(!this->targetIsNull_){
        return this->target_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

