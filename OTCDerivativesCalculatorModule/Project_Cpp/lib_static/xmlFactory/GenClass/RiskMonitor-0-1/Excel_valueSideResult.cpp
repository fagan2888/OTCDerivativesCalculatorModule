// Excel_valueSideResult.cpp 
#include "Excel_valueSideResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_valueSideResult::Excel_valueSideResult(TiXmlNode* xmlNode)
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

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
       currency_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(currencyNode));
   }

   //dirtyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dirtyNode = xmlNode->FirstChildElement("dirty");

   if(dirtyNode){dirtyIsNull_ = false;}
   else{dirtyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dirtyNode , address : " << dirtyNode << std::endl;
   #endif
   if(dirtyNode)
   {
       dirty_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(dirtyNode));
   }

   //cleanNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cleanNode = xmlNode->FirstChildElement("clean");

   if(cleanNode){cleanIsNull_ = false;}
   else{cleanIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cleanNode , address : " << cleanNode << std::endl;
   #endif
   if(cleanNode)
   {
       clean_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(cleanNode));
   }

   //accrualAmtNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accrualAmtNode = xmlNode->FirstChildElement("accrualAmt");

   if(accrualAmtNode){accrualAmtIsNull_ = false;}
   else{accrualAmtIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accrualAmtNode , address : " << accrualAmtNode << std::endl;
   #endif
   if(accrualAmtNode)
   {
       accrualAmt_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(accrualAmtNode));
   }

   //optionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionNode = xmlNode->FirstChildElement("option");

   if(optionNode){optionIsNull_ = false;}
   else{optionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionNode , address : " << optionNode << std::endl;
   #endif
   if(optionNode)
   {
       option_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(optionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_valueSideResult::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDouble> Excel_valueSideResult::getCurrency()
{
   if(!this->currencyIsNull_){
        return this->currency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> Excel_valueSideResult::getDirty()
{
   if(!this->dirtyIsNull_){
        return this->dirty_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> Excel_valueSideResult::getClean()
{
   if(!this->cleanIsNull_){
        return this->clean_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> Excel_valueSideResult::getAccrualAmt()
{
   if(!this->accrualAmtIsNull_){
        return this->accrualAmt_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> Excel_valueSideResult::getOption()
{
   if(!this->optionIsNull_){
        return this->option_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

