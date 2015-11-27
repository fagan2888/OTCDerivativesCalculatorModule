// Method.cpp 
#include "Method.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Method::Method(TiXmlNode* xmlNode)
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

   //monteNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* monteNode = xmlNode->FirstChildElement("monte");

   if(monteNode){monteIsNull_ = false;}
   else{monteIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- monteNode , address : " << monteNode << std::endl;
   #endif
   if(monteNode)
   {
       monte_ = boost::shared_ptr<Monte>(new Monte(monteNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Method::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Monte> Method::getMonte()
{
   if(!this->monteIsNull_){
        return this->monte_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Monte>();
   }
}
}

