// AdditionVariableInfo.cpp 
#include "AdditionVariableInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdditionVariableInfo::AdditionVariableInfo(TiXmlNode* xmlNode)
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

   //saveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* saveNode = xmlNode->FirstChildElement("save");

   if(saveNode){saveIsNull_ = false;}
   else{saveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- saveNode , address : " << saveNode << std::endl;
   #endif
   if(saveNode)
   {
       save_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(saveNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> AdditionVariableInfo::getUsingRefVarName()
{
   if(!this->usingRefVarNameIsNull_){
        return this->usingRefVarName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> AdditionVariableInfo::getRefInstanceName()
{
   if(!this->refInstanceNameIsNull_){
        return this->refInstanceName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionVariableInfo::getSave()
{
   if(!this->saveIsNull_){
        return this->save_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

