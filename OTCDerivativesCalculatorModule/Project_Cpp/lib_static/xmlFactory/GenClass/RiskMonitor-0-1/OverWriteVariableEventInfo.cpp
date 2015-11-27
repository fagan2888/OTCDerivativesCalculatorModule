// OverWriteVariableEventInfo.cpp 
#include "OverWriteVariableEventInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OverWriteVariableEventInfo::OverWriteVariableEventInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //usingRefVarNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* usingRefVarNameNode = xmlNode->FirstChildElement("usingRefVarName");

   if(usingRefVarNameNode){usingRefVarNameIsNull_ = false;}
   else{usingRefVarNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- usingRefVarNameNode , address : " << usingRefVarNameNode << std::endl;
   #endif
   if(usingRefVarNameNode)
   {
       usingRefVarName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(usingRefVarNameNode));
   }

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

   //initialTFNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialTFNode = xmlNode->FirstChildElement("initialTF");

   if(initialTFNode){initialTFIsNull_ = false;}
   else{initialTFIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialTFNode , address : " << initialTFNode << std::endl;
   #endif
   if(initialTFNode)
   {
       initialTF_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(initialTFNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> OverWriteVariableEventInfo::getUsingRefVarName()
{
   if(!this->usingRefVarNameIsNull_){
        return this->usingRefVarName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> OverWriteVariableEventInfo::getRefInstanceName()
{
   if(!this->refInstanceNameIsNull_){
        return this->refInstanceName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> OverWriteVariableEventInfo::getInitialTF()
{
   if(!this->initialTFIsNull_){
        return this->initialTF_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

