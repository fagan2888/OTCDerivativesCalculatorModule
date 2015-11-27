// PayoffInfo.cpp 
#include "PayoffInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PayoffInfo::PayoffInfo(TiXmlNode* xmlNode)
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

   //preDefinedVariableListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* preDefinedVariableListNode = xmlNode->FirstChildElement("preDefinedVariableList");

   if(preDefinedVariableListNode){preDefinedVariableListIsNull_ = false;}
   else{preDefinedVariableListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- preDefinedVariableListNode , address : " << preDefinedVariableListNode << std::endl;
   #endif
   if(preDefinedVariableListNode)
   {
       preDefinedVariableList_ = boost::shared_ptr<PreDefinedVariableList>(new PreDefinedVariableList(preDefinedVariableListNode));
   }

   //stopLossPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stopLossPayoffNode = xmlNode->FirstChildElement("stopLossPayoff");

   if(stopLossPayoffNode){stopLossPayoffIsNull_ = false;}
   else{stopLossPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stopLossPayoffNode , address : " << stopLossPayoffNode << std::endl;
   #endif
   if(stopLossPayoffNode)
   {
       stopLossPayoff_ = boost::shared_ptr<StopLossPayoff>(new StopLossPayoff(stopLossPayoffNode));
   }

   //vanillaPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaPayoffNode = xmlNode->FirstChildElement("vanillaPayoff");

   if(vanillaPayoffNode){vanillaPayoffIsNull_ = false;}
   else{vanillaPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaPayoffNode , address : " << vanillaPayoffNode << std::endl;
   #endif
   if(vanillaPayoffNode)
   {
       vanillaPayoff_ = boost::shared_ptr<VanillaPayoff>(new VanillaPayoff(vanillaPayoffNode));
   }

   //compositeSumOptionPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compositeSumOptionPayoffNode = xmlNode->FirstChildElement("compositeSumOptionPayoff");

   if(compositeSumOptionPayoffNode){compositeSumOptionPayoffIsNull_ = false;}
   else{compositeSumOptionPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compositeSumOptionPayoffNode , address : " << compositeSumOptionPayoffNode << std::endl;
   #endif
   if(compositeSumOptionPayoffNode)
   {
       compositeSumOptionPayoff_ = boost::shared_ptr<CompositeSumOptionPayoff>(new CompositeSumOptionPayoff(compositeSumOptionPayoffNode));
   }

   //autoCallablePayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoCallablePayoffNode = xmlNode->FirstChildElement("autoCallablePayoff");

   if(autoCallablePayoffNode){autoCallablePayoffIsNull_ = false;}
   else{autoCallablePayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoCallablePayoffNode , address : " << autoCallablePayoffNode << std::endl;
   #endif
   if(autoCallablePayoffNode)
   {
       autoCallablePayoff_ = boost::shared_ptr<AutoCallablePayoff>(new AutoCallablePayoff(autoCallablePayoffNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> PayoffInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<PreDefinedVariableList> PayoffInfo::getPreDefinedVariableList()
{
   if(!this->preDefinedVariableListIsNull_){
        return this->preDefinedVariableList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PreDefinedVariableList>();
   }
}
boost::shared_ptr<StopLossPayoff> PayoffInfo::getStopLossPayoff()
{
   if(!this->stopLossPayoffIsNull_){
        return this->stopLossPayoff_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StopLossPayoff>();
   }
}
boost::shared_ptr<VanillaPayoff> PayoffInfo::getVanillaPayoff()
{
   if(!this->vanillaPayoffIsNull_){
        return this->vanillaPayoff_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaPayoff>();
   }
}
boost::shared_ptr<CompositeSumOptionPayoff> PayoffInfo::getCompositeSumOptionPayoff()
{
   if(!this->compositeSumOptionPayoffIsNull_){
        return this->compositeSumOptionPayoff_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CompositeSumOptionPayoff>();
   }
}
boost::shared_ptr<AutoCallablePayoff> PayoffInfo::getAutoCallablePayoff()
{
   if(!this->autoCallablePayoffIsNull_){
        return this->autoCallablePayoff_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AutoCallablePayoff>();
   }
}
}

