// PricingParameter.cpp 
#include "PricingParameter.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PricingParameter::PricingParameter(TiXmlNode* xmlNode)
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

   //methodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* methodNode = xmlNode->FirstChildElement("method");

   if(methodNode){methodIsNull_ = false;}
   else{methodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- methodNode , address : " << methodNode << std::endl;
   #endif
   if(methodNode)
   {
       method_ = boost::shared_ptr<Method>(new Method(methodNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> PricingParameter::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Method> PricingParameter::getMethod()
{
   if(!this->methodIsNull_){
        return this->method_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Method>();
   }
}
}

