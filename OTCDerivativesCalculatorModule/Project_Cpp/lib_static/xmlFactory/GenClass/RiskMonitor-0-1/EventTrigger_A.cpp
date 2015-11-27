// EventTrigger_A.cpp 
#include "EventTrigger_A.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventTrigger_A::EventTrigger_A(TiXmlNode* xmlNode)
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

   //fixedRatePayoff_ANode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRatePayoff_ANode = xmlNode->FirstChildElement("fixedRatePayoff_A");

   if(fixedRatePayoff_ANode){fixedRatePayoff_AIsNull_ = false;}
   else{fixedRatePayoff_AIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRatePayoff_ANode , address : " << fixedRatePayoff_ANode << std::endl;
   #endif
   if(fixedRatePayoff_ANode)
   {
       fixedRatePayoff_A_ = boost::shared_ptr<FixedRatePayoff_A>(new FixedRatePayoff_A(fixedRatePayoff_ANode));
   }

   //vanillaFloatingRatePayoff_ANode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaFloatingRatePayoff_ANode = xmlNode->FirstChildElement("vanillaFloatingRatePayoff_A");

   if(vanillaFloatingRatePayoff_ANode){vanillaFloatingRatePayoff_AIsNull_ = false;}
   else{vanillaFloatingRatePayoff_AIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaFloatingRatePayoff_ANode , address : " << vanillaFloatingRatePayoff_ANode << std::endl;
   #endif
   if(vanillaFloatingRatePayoff_ANode)
   {
       vanillaFloatingRatePayoff_A_ = boost::shared_ptr<VanillaFloatingRatePayoff_A>(new VanillaFloatingRatePayoff_A(vanillaFloatingRatePayoff_ANode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> EventTrigger_A::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<FixedRatePayoff_A> EventTrigger_A::getFixedRatePayoff_A()
{
   if(!this->fixedRatePayoff_AIsNull_){
        return this->fixedRatePayoff_A_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedRatePayoff_A>();
   }
}
boost::shared_ptr<VanillaFloatingRatePayoff_A> EventTrigger_A::getVanillaFloatingRatePayoff_A()
{
   if(!this->vanillaFloatingRatePayoff_AIsNull_){
        return this->vanillaFloatingRatePayoff_A_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaFloatingRatePayoff_A>();
   }
}
}

