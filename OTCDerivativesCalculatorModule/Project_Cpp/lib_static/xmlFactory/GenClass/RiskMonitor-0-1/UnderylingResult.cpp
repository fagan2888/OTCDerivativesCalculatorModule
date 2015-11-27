// UnderylingResult.cpp 
#include "UnderylingResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UnderylingResult::UnderylingResult(TiXmlNode* xmlNode)
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

   //gbmGreekInfoResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gbmGreekInfoResultNode = xmlNode->FirstChildElement("gbmGreekInfoResult");

   if(gbmGreekInfoResultNode){gbmGreekInfoResultIsNull_ = false;}
   else{gbmGreekInfoResultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gbmGreekInfoResultNode , address : " << gbmGreekInfoResultNode << std::endl;
   #endif
   if(gbmGreekInfoResultNode)
   {
       gbmGreekInfoResult_ = boost::shared_ptr<GbmGreekInfoResult>(new GbmGreekInfoResult(gbmGreekInfoResultNode));
   }

   //hullWhiteGreekInfoResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hullWhiteGreekInfoResultNode = xmlNode->FirstChildElement("hullWhiteGreekInfoResult");

   if(hullWhiteGreekInfoResultNode){hullWhiteGreekInfoResultIsNull_ = false;}
   else{hullWhiteGreekInfoResultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hullWhiteGreekInfoResultNode , address : " << hullWhiteGreekInfoResultNode << std::endl;
   #endif
   if(hullWhiteGreekInfoResultNode)
   {
       hullWhiteGreekInfoResult_ = boost::shared_ptr<HullWhiteGreekInfoResult>(new HullWhiteGreekInfoResult(hullWhiteGreekInfoResultNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> UnderylingResult::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<GbmGreekInfoResult> UnderylingResult::getGbmGreekInfoResult()
{
   if(!this->gbmGreekInfoResultIsNull_){
        return this->gbmGreekInfoResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GbmGreekInfoResult>();
   }
}
boost::shared_ptr<HullWhiteGreekInfoResult> UnderylingResult::getHullWhiteGreekInfoResult()
{
   if(!this->hullWhiteGreekInfoResultIsNull_){
        return this->hullWhiteGreekInfoResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<HullWhiteGreekInfoResult>();
   }
}
}

