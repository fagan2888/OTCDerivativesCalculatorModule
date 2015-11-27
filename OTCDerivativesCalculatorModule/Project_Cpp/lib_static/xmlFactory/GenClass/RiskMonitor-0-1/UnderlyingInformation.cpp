// UnderlyingInformation.cpp 
#include "UnderlyingInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UnderlyingInformation::UnderlyingInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //indexUnderInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexUnderInfoNode = xmlNode->FirstChildElement("indexUnderInfo");

   if(indexUnderInfoNode){indexUnderInfoIsNull_ = false;}
   else{indexUnderInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexUnderInfoNode , address : " << indexUnderInfoNode << std::endl;
   #endif
   if(indexUnderInfoNode)
   {
       indexUnderInfo_ = boost::shared_ptr<IndexUnderInfo>(new IndexUnderInfo(indexUnderInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> UnderlyingInformation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<IndexUnderInfo> UnderlyingInformation::getIndexUnderInfo()
{
   if(!this->indexUnderInfoIsNull_){
        return this->indexUnderInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexUnderInfo>();
   }
}
}

