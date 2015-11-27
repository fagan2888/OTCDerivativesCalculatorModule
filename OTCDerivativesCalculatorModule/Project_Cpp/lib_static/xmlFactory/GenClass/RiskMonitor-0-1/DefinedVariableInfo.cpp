// DefinedVariableInfo.cpp 
#include "DefinedVariableInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DefinedVariableInfo::DefinedVariableInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //refInstanceNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refInstanceNameNode = xmlNode->FirstChildElement("refInstanceName");

   if(refInstanceNameNode){refInstanceNameIsNull_ = false;}
   else{refInstanceNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refInstanceNameNode , address : " << refInstanceNameNode << std::endl;
   #endif
   if(refInstanceNameNode)
   {
       refInstanceName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refInstanceNameNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> DefinedVariableInfo::getRefInstanceName()
{
   if(!this->refInstanceNameIsNull_){
        return this->refInstanceName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

