// ClearQueue.cpp 
#include "ClearQueue.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ClearQueue::ClearQueue(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //actionTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* actionTypeNode = xmlNode->FirstChildElement("actionType");

   if(actionTypeNode){actionTypeIsNull_ = false;}
   else{actionTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- actionTypeNode , address : " << actionTypeNode << std::endl;
   #endif
   if(actionTypeNode)
   {
       actionType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(actionTypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ClearQueue::getActionType()
{
   if(!this->actionTypeIsNull_){
        return this->actionType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

