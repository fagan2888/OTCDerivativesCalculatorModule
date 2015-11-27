// GridCalculation.cpp 
#include "GridCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GridCalculation::GridCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //inst_codeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inst_codeNode = xmlNode->FirstChildElement("inst_code");

   if(inst_codeNode){inst_codeIsNull_ = false;}
   else{inst_codeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inst_codeNode , address : " << inst_codeNode << std::endl;
   #endif
   if(inst_codeNode)
   {
       inst_code_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(inst_codeNode));
   }

   //inst_nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inst_nameNode = xmlNode->FirstChildElement("inst_name");

   if(inst_nameNode){inst_nameIsNull_ = false;}
   else{inst_nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inst_nameNode , address : " << inst_nameNode << std::endl;
   #endif
   if(inst_nameNode)
   {
       inst_name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(inst_nameNode));
   }

   //inst_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inst_typeNode = xmlNode->FirstChildElement("inst_type");

   if(inst_typeNode){inst_typeIsNull_ = false;}
   else{inst_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inst_typeNode , address : " << inst_typeNode << std::endl;
   #endif
   if(inst_typeNode)
   {
       inst_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(inst_typeNode));
   }

   //para_refDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* para_refDateNode = xmlNode->FirstChildElement("para_refDate");

   if(para_refDateNode){para_refDateIsNull_ = false;}
   else{para_refDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- para_refDateNode , address : " << para_refDateNode << std::endl;
   #endif
   if(para_refDateNode)
   {
       para_refDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(para_refDateNode));
   }

   //productInnerXmlNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productInnerXmlNode = xmlNode->FirstChildElement("productInnerXml");

   if(productInnerXmlNode){productInnerXmlIsNull_ = false;}
   else{productInnerXmlIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productInnerXmlNode , address : " << productInnerXmlNode << std::endl;
   #endif
   if(productInnerXmlNode)
   {
       productInnerXml_ = boost::shared_ptr<ProductInnerXml>(new ProductInnerXml(productInnerXmlNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> GridCalculation::getInst_code()
{
   if(!this->inst_codeIsNull_){
        return this->inst_code_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> GridCalculation::getInst_name()
{
   if(!this->inst_nameIsNull_){
        return this->inst_name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> GridCalculation::getInst_type()
{
   if(!this->inst_typeIsNull_){
        return this->inst_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> GridCalculation::getPara_refDate()
{
   if(!this->para_refDateIsNull_){
        return this->para_refDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<ProductInnerXml> GridCalculation::getProductInnerXml()
{
   if(!this->productInnerXmlIsNull_){
        return this->productInnerXml_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProductInnerXml>();
   }
}
}

