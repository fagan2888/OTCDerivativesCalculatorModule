// RedemptionInfo.cpp 
#include "RedemptionInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RedemptionInfo::RedemptionInfo(TiXmlNode* xmlNode)
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

   //autoCallRedemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoCallRedemNode = xmlNode->FirstChildElement("autoCallRedem");

   if(autoCallRedemNode){autoCallRedemIsNull_ = false;}
   else{autoCallRedemIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoCallRedemNode , address : " << autoCallRedemNode << std::endl;
   #endif
   if(autoCallRedemNode)
   {
       autoCallRedem_ = boost::shared_ptr<AutoCallRedem>(new AutoCallRedem(autoCallRedemNode));
   }

   //monthlyAutoCallRedemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* monthlyAutoCallRedemNode = xmlNode->FirstChildElement("monthlyAutoCallRedem");

   if(monthlyAutoCallRedemNode){monthlyAutoCallRedemIsNull_ = false;}
   else{monthlyAutoCallRedemIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- monthlyAutoCallRedemNode , address : " << monthlyAutoCallRedemNode << std::endl;
   #endif
   if(monthlyAutoCallRedemNode)
   {
       monthlyAutoCallRedem_ = boost::shared_ptr<MonthlyAutoCallRedem>(new MonthlyAutoCallRedem(monthlyAutoCallRedemNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> RedemptionInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<AutoCallRedem> RedemptionInfo::getAutoCallRedem()
{
   if(!this->autoCallRedemIsNull_){
        return this->autoCallRedem_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AutoCallRedem>();
   }
}
boost::shared_ptr<MonthlyAutoCallRedem> RedemptionInfo::getMonthlyAutoCallRedem()
{
   if(!this->monthlyAutoCallRedemIsNull_){
        return this->monthlyAutoCallRedem_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MonthlyAutoCallRedem>();
   }
}
}

