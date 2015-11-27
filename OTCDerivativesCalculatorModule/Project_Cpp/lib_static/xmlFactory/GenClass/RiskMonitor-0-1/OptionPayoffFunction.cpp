// OptionPayoffFunction.cpp 
#include "OptionPayoffFunction.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionPayoffFunction::OptionPayoffFunction(TiXmlNode* xmlNode)
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

   //vanillaCallFunctionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaCallFunctionNode = xmlNode->FirstChildElement("vanillaCallFunction");

   if(vanillaCallFunctionNode){vanillaCallFunctionIsNull_ = false;}
   else{vanillaCallFunctionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaCallFunctionNode , address : " << vanillaCallFunctionNode << std::endl;
   #endif
   if(vanillaCallFunctionNode)
   {
       vanillaCallFunction_ = boost::shared_ptr<VanillaCallFunction>(new VanillaCallFunction(vanillaCallFunctionNode));
   }

   //vanillaPutFunctionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaPutFunctionNode = xmlNode->FirstChildElement("vanillaPutFunction");

   if(vanillaPutFunctionNode){vanillaPutFunctionIsNull_ = false;}
   else{vanillaPutFunctionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaPutFunctionNode , address : " << vanillaPutFunctionNode << std::endl;
   #endif
   if(vanillaPutFunctionNode)
   {
       vanillaPutFunction_ = boost::shared_ptr<VanillaPutFunction>(new VanillaPutFunction(vanillaPutFunctionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> OptionPayoffFunction::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<VanillaCallFunction> OptionPayoffFunction::getVanillaCallFunction()
{
   if(!this->vanillaCallFunctionIsNull_){
        return this->vanillaCallFunction_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaCallFunction>();
   }
}
boost::shared_ptr<VanillaPutFunction> OptionPayoffFunction::getVanillaPutFunction()
{
   if(!this->vanillaPutFunctionIsNull_){
        return this->vanillaPutFunction_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaPutFunction>();
   }
}
}

