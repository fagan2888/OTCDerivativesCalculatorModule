// InstHirachyInfo.cpp 
#include "InstHirachyInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstHirachyInfo::InstHirachyInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //codeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* codeNode = xmlNode->FirstChildElement("code");

   if(codeNode){codeIsNull_ = false;}
   else{codeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- codeNode , address : " << codeNode << std::endl;
   #endif
   if(codeNode)
   {
       code_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(codeNode));
   }

   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //instHirachyInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instHirachyInfoNode = xmlNode->FirstChildElement("instHirachyInfo");

   if(instHirachyInfoNode){instHirachyInfoIsNull_ = false;}
   else{instHirachyInfoIsNull_ = true;}

   if(instHirachyInfoNode)
   {
      for(instHirachyInfoNode; instHirachyInfoNode; instHirachyInfoNode = instHirachyInfoNode->NextSiblingElement("instHirachyInfo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instHirachyInfoNode , address : " << instHirachyInfoNode << std::endl;
          #endif
          instHirachyInfo_.push_back(boost::shared_ptr<InstHirachyInfo>(new InstHirachyInfo(instHirachyInfoNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instHirachyInfoNode , address : " << instHirachyInfoNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> InstHirachyInfo::getCode()
{
   if(!this->codeIsNull_){
        return this->code_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstHirachyInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<InstHirachyInfo>> InstHirachyInfo::getInstHirachyInfo()
{
   if(!this->instHirachyInfoIsNull_){
        return this->instHirachyInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<InstHirachyInfo>>();
   }
}
}

