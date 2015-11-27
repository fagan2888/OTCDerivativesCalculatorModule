// CreditPayoffInfo.cpp 
#include "CreditPayoffInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditPayoffInfo::CreditPayoffInfo(TiXmlNode* xmlNode)
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

   //creditDefaultSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditDefaultSwapNode = xmlNode->FirstChildElement("creditDefaultSwap");

   if(creditDefaultSwapNode){creditDefaultSwapIsNull_ = false;}
   else{creditDefaultSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditDefaultSwapNode , address : " << creditDefaultSwapNode << std::endl;
   #endif
   if(creditDefaultSwapNode)
   {
       creditDefaultSwap_ = boost::shared_ptr<CreditDefaultSwap>(new CreditDefaultSwap(creditDefaultSwapNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CreditPayoffInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<CreditDefaultSwap> CreditPayoffInfo::getCreditDefaultSwap()
{
   if(!this->creditDefaultSwapIsNull_){
        return this->creditDefaultSwap_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditDefaultSwap>();
   }
}
}

