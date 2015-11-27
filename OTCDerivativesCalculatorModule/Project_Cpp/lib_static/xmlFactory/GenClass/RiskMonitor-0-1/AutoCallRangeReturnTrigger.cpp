// AutoCallRangeReturnTrigger.cpp 
#include "AutoCallRangeReturnTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AutoCallRangeReturnTrigger::AutoCallRangeReturnTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //simpleRangeEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeEventCalNode = xmlNode->FirstChildElement("simpleRangeEventCal");

   if(simpleRangeEventCalNode){simpleRangeEventCalIsNull_ = false;}
   else{simpleRangeEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeEventCalNode , address : " << simpleRangeEventCalNode << std::endl;
   #endif
   if(simpleRangeEventCalNode)
   {
       simpleRangeEventCal_ = boost::shared_ptr<SimpleRangeEventCal>(new SimpleRangeEventCal(simpleRangeEventCalNode));
   }

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

   //isExpiredNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* isExpiredNode = xmlNode->FirstChildElement("isExpired");

   if(isExpiredNode){isExpiredIsNull_ = false;}
   else{isExpiredIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- isExpiredNode , address : " << isExpiredNode << std::endl;
   #endif
   if(isExpiredNode)
   {
       isExpired_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(isExpiredNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SimpleRangeEventCal> AutoCallRangeReturnTrigger::getSimpleRangeEventCal()
{
   if(!this->simpleRangeEventCalIsNull_){
        return this->simpleRangeEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeEventCal>();
   }
}
boost::shared_ptr<PayoffDateInfo> AutoCallRangeReturnTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AutoCallRangeReturnTrigger::getIsExpired()
{
   if(!this->isExpiredIsNull_){
        return this->isExpired_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

