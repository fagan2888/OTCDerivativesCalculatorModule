// SimpleRangeConstReturnTrigger.cpp 
#include "SimpleRangeConstReturnTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleRangeConstReturnTrigger::SimpleRangeConstReturnTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateOrderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateOrderNode = xmlNode->FirstChildElement("dateOrder");

   if(dateOrderNode){dateOrderIsNull_ = false;}
   else{dateOrderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateOrderNode , address : " << dateOrderNode << std::endl;
   #endif
   if(dateOrderNode)
   {
       dateOrder_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(dateOrderNode));
   }

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

   //constReturnNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constReturnNode = xmlNode->FirstChildElement("constReturn");

   if(constReturnNode){constReturnIsNull_ = false;}
   else{constReturnIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constReturnNode , address : " << constReturnNode << std::endl;
   #endif
   if(constReturnNode)
   {
       constReturn_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(constReturnNode));
   }

   //averageDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averageDaysNode = xmlNode->FirstChildElement("averageDays");

   if(averageDaysNode){averageDaysIsNull_ = false;}
   else{averageDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averageDaysNode , address : " << averageDaysNode << std::endl;
   #endif
   if(averageDaysNode)
   {
       averageDays_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(averageDaysNode));
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
boost::shared_ptr<XsdTypeInteger> SimpleRangeConstReturnTrigger::getDateOrder()
{
   if(!this->dateOrderIsNull_){
        return this->dateOrder_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<SimpleRangeEventCal> SimpleRangeConstReturnTrigger::getSimpleRangeEventCal()
{
   if(!this->simpleRangeEventCalIsNull_){
        return this->simpleRangeEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeEventCal>();
   }
}
boost::shared_ptr<PayoffDateInfo> SimpleRangeConstReturnTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeDouble> SimpleRangeConstReturnTrigger::getConstReturn()
{
   if(!this->constReturnIsNull_){
        return this->constReturn_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeInteger> SimpleRangeConstReturnTrigger::getAverageDays()
{
   if(!this->averageDaysIsNull_){
        return this->averageDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<XsdTypeBoolean> SimpleRangeConstReturnTrigger::getIsExpired()
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

