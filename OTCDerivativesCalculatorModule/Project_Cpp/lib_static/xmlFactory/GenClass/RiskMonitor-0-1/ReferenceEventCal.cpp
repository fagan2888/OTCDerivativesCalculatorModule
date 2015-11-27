// ReferenceEventCal.cpp 
#include "ReferenceEventCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceEventCal::ReferenceEventCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //refNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refNameNode = xmlNode->FirstChildElement("refName");

   if(refNameNode){refNameIsNull_ = false;}
   else{refNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refNameNode , address : " << refNameNode << std::endl;
   #endif
   if(refNameNode)
   {
       refName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refNameNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ReferenceEventCal::getRefName()
{
   if(!this->refNameIsNull_){
        return this->refName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

