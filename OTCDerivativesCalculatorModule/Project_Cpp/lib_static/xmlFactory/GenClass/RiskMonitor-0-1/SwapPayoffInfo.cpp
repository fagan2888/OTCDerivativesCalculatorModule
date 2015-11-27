// SwapPayoffInfo.cpp 
#include "SwapPayoffInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SwapPayoffInfo::SwapPayoffInfo(TiXmlNode* xmlNode)
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

   //vanillaSwapPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaSwapPayoffNode = xmlNode->FirstChildElement("vanillaSwapPayoff");

   if(vanillaSwapPayoffNode){vanillaSwapPayoffIsNull_ = false;}
   else{vanillaSwapPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaSwapPayoffNode , address : " << vanillaSwapPayoffNode << std::endl;
   #endif
   if(vanillaSwapPayoffNode)
   {
       vanillaSwapPayoff_ = boost::shared_ptr<VanillaSwapPayoff>(new VanillaSwapPayoff(vanillaSwapPayoffNode));
   }

   //autoCallableSwapPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoCallableSwapPayoffNode = xmlNode->FirstChildElement("autoCallableSwapPayoff");

   if(autoCallableSwapPayoffNode){autoCallableSwapPayoffIsNull_ = false;}
   else{autoCallableSwapPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoCallableSwapPayoffNode , address : " << autoCallableSwapPayoffNode << std::endl;
   #endif
   if(autoCallableSwapPayoffNode)
   {
       autoCallableSwapPayoff_ = boost::shared_ptr<AutoCallableSwapPayoff>(new AutoCallableSwapPayoff(autoCallableSwapPayoffNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> SwapPayoffInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<VanillaSwapPayoff> SwapPayoffInfo::getVanillaSwapPayoff()
{
   if(!this->vanillaSwapPayoffIsNull_){
        return this->vanillaSwapPayoff_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaSwapPayoff>();
   }
}
boost::shared_ptr<AutoCallableSwapPayoff> SwapPayoffInfo::getAutoCallableSwapPayoff()
{
   if(!this->autoCallableSwapPayoffIsNull_){
        return this->autoCallableSwapPayoff_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AutoCallableSwapPayoff>();
   }
}
}

