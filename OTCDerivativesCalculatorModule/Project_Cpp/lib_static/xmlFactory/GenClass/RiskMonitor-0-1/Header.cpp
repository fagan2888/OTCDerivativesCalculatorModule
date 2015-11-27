// Header.cpp 
#include "Header.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Header::Header(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //productNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productNameNode = xmlNode->FirstChildElement("productName");

   if(productNameNode){productNameIsNull_ = false;}
   else{productNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productNameNode , address : " << productNameNode << std::endl;
   #endif
   if(productNameNode)
   {
       productName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(productNameNode));
   }

   //productTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productTypeNode = xmlNode->FirstChildElement("productType");

   if(productTypeNode){productTypeIsNull_ = false;}
   else{productTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productTypeNode , address : " << productTypeNode << std::endl;
   #endif
   if(productTypeNode)
   {
       productType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(productTypeNode));
   }

   //krCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* krCodeNode = xmlNode->FirstChildElement("krCode");

   if(krCodeNode){krCodeIsNull_ = false;}
   else{krCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- krCodeNode , address : " << krCodeNode << std::endl;
   #endif
   if(krCodeNode)
   {
       krCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(krCodeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Header::getProductName()
{
   if(!this->productNameIsNull_){
        return this->productName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Header::getProductType()
{
   if(!this->productTypeIsNull_){
        return this->productType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Header::getKrCode()
{
   if(!this->krCodeIsNull_){
        return this->krCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

