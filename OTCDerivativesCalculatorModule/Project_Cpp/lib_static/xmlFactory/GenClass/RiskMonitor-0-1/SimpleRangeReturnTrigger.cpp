// SimpleRangeReturnTrigger.cpp 
#include "SimpleRangeReturnTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleRangeReturnTrigger::SimpleRangeReturnTrigger(TiXmlNode* xmlNode)
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

   //autoCallFlagNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoCallFlagNode = xmlNode->FirstChildElement("autoCallFlag");

   if(autoCallFlagNode){autoCallFlagIsNull_ = false;}
   else{autoCallFlagIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoCallFlagNode , address : " << autoCallFlagNode << std::endl;
   #endif
   if(autoCallFlagNode)
   {
       autoCallFlag_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(autoCallFlagNode));
   }

   //expiredNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expiredNode = xmlNode->FirstChildElement("expired");

   if(expiredNode){expiredIsNull_ = false;}
   else{expiredIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expiredNode , address : " << expiredNode << std::endl;
   #endif
   if(expiredNode)
   {
       expired_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(expiredNode));
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SimpleRangeEventCal> SimpleRangeReturnTrigger::getSimpleRangeEventCal()
{
   if(!this->simpleRangeEventCalIsNull_){
        return this->simpleRangeEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeEventCal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> SimpleRangeReturnTrigger::getAutoCallFlag()
{
   if(!this->autoCallFlagIsNull_){
        return this->autoCallFlag_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> SimpleRangeReturnTrigger::getExpired()
{
   if(!this->expiredIsNull_){
        return this->expired_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<PayoffDateInfo> SimpleRangeReturnTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
}

