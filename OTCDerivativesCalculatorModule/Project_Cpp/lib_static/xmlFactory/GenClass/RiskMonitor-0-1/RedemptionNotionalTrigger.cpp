// RedemptionNotionalTrigger.cpp 
#include "RedemptionNotionalTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RedemptionNotionalTrigger::RedemptionNotionalTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payoffDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateInfoNode = xmlNode->FirstChildElement("payoffDateInfo");

   if(payoffDateInfoNode){payoffDateInfoIsNull_ = false;}
   else{payoffDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateInfoNode , address : " << payoffDateInfoNode << std::endl;
   #endif
   if(payoffDateInfoNode)
   {
       payoffDateInfo_ = boost::shared_ptr<PayoffDateInfo>(new PayoffDateInfo(payoffDateInfoNode));
   }

   //redemptionAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* redemptionAmountNode = xmlNode->FirstChildElement("redemptionAmount");

   if(redemptionAmountNode){redemptionAmountIsNull_ = false;}
   else{redemptionAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- redemptionAmountNode , address : " << redemptionAmountNode << std::endl;
   #endif
   if(redemptionAmountNode)
   {
       redemptionAmount_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(redemptionAmountNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PayoffDateInfo> RedemptionNotionalTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeDouble> RedemptionNotionalTrigger::getRedemptionAmount()
{
   if(!this->redemptionAmountIsNull_){
        return this->redemptionAmount_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

