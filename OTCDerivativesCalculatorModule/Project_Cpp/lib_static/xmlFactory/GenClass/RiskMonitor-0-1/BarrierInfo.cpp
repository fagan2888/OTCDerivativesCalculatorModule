// BarrierInfo.cpp 
#include "BarrierInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BarrierInfo::BarrierInfo(TiXmlNode* xmlNode)
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

   //constDualBarrierInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constDualBarrierInfoNode = xmlNode->FirstChildElement("constDualBarrierInfo");

   if(constDualBarrierInfoNode){constDualBarrierInfoIsNull_ = false;}
   else{constDualBarrierInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constDualBarrierInfoNode , address : " << constDualBarrierInfoNode << std::endl;
   #endif
   if(constDualBarrierInfoNode)
   {
       constDualBarrierInfo_ = boost::shared_ptr<ConstDualBarrierInfo>(new ConstDualBarrierInfo(constDualBarrierInfoNode));
   }

   //constLowerBarrierInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constLowerBarrierInfoNode = xmlNode->FirstChildElement("constLowerBarrierInfo");

   if(constLowerBarrierInfoNode){constLowerBarrierInfoIsNull_ = false;}
   else{constLowerBarrierInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constLowerBarrierInfoNode , address : " << constLowerBarrierInfoNode << std::endl;
   #endif
   if(constLowerBarrierInfoNode)
   {
       constLowerBarrierInfo_ = boost::shared_ptr<ConstLowerBarrierInfo>(new ConstLowerBarrierInfo(constLowerBarrierInfoNode));
   }

   //constUpperBarrierInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constUpperBarrierInfoNode = xmlNode->FirstChildElement("constUpperBarrierInfo");

   if(constUpperBarrierInfoNode){constUpperBarrierInfoIsNull_ = false;}
   else{constUpperBarrierInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constUpperBarrierInfoNode , address : " << constUpperBarrierInfoNode << std::endl;
   #endif
   if(constUpperBarrierInfoNode)
   {
       constUpperBarrierInfo_ = boost::shared_ptr<ConstUpperBarrierInfo>(new ConstUpperBarrierInfo(constUpperBarrierInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> BarrierInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<ConstDualBarrierInfo> BarrierInfo::getConstDualBarrierInfo()
{
   if(!this->constDualBarrierInfoIsNull_){
        return this->constDualBarrierInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConstDualBarrierInfo>();
   }
}
boost::shared_ptr<ConstLowerBarrierInfo> BarrierInfo::getConstLowerBarrierInfo()
{
   if(!this->constLowerBarrierInfoIsNull_){
        return this->constLowerBarrierInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConstLowerBarrierInfo>();
   }
}
boost::shared_ptr<ConstUpperBarrierInfo> BarrierInfo::getConstUpperBarrierInfo()
{
   if(!this->constUpperBarrierInfoIsNull_){
        return this->constUpperBarrierInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConstUpperBarrierInfo>();
   }
}
}

