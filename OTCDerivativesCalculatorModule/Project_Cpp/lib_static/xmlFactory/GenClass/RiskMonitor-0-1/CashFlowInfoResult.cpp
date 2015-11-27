// CashFlowInfoResult.cpp 
#include "CashFlowInfoResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CashFlowInfoResult::CashFlowInfoResult(TiXmlNode* xmlNode)
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

   //simpleCashFlowResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleCashFlowResultNode = xmlNode->FirstChildElement("simpleCashFlowResult");

   if(simpleCashFlowResultNode){simpleCashFlowResultIsNull_ = false;}
   else{simpleCashFlowResultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleCashFlowResultNode , address : " << simpleCashFlowResultNode << std::endl;
   #endif
   if(simpleCashFlowResultNode)
   {
       simpleCashFlowResult_ = boost::shared_ptr<SimpleCashFlowResult>(new SimpleCashFlowResult(simpleCashFlowResultNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CashFlowInfoResult::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<SimpleCashFlowResult> CashFlowInfoResult::getSimpleCashFlowResult()
{
   if(!this->simpleCashFlowResultIsNull_){
        return this->simpleCashFlowResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleCashFlowResult>();
   }
}
}

