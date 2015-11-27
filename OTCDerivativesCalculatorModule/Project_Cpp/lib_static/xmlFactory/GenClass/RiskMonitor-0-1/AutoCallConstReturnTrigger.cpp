// AutoCallConstReturnTrigger.cpp 
#include "AutoCallConstReturnTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AutoCallConstReturnTrigger::AutoCallConstReturnTrigger(TiXmlNode* xmlNode)
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

   //fixingDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDateInfoNode = xmlNode->FirstChildElement("fixingDateInfo");

   if(fixingDateInfoNode){fixingDateInfoIsNull_ = false;}
   else{fixingDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDateInfoNode , address : " << fixingDateInfoNode << std::endl;
   #endif
   if(fixingDateInfoNode)
   {
       fixingDateInfo_ = boost::shared_ptr<FixingDateInfo>(new FixingDateInfo(fixingDateInfoNode));
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

   //triggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerNode = xmlNode->FirstChildElement("trigger");

   if(triggerNode){triggerIsNull_ = false;}
   else{triggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerNode , address : " << triggerNode << std::endl;
   #endif
   if(triggerNode)
   {
       trigger_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(triggerNode));
   }

   //returnNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnNode = xmlNode->FirstChildElement("return");

   if(returnNode){returnIsNull_ = false;}
   else{returnIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnNode , address : " << returnNode << std::endl;
   #endif
   if(returnNode)
   {
       return_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(returnNode));
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
boost::shared_ptr<XsdTypeInteger> AutoCallConstReturnTrigger::getDateOrder()
{
   if(!this->dateOrderIsNull_){
        return this->dateOrder_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<FixingDateInfo> AutoCallConstReturnTrigger::getFixingDateInfo()
{
   if(!this->fixingDateInfoIsNull_){
        return this->fixingDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingDateInfo>();
   }
}
boost::shared_ptr<PayoffDateInfo> AutoCallConstReturnTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeDouble> AutoCallConstReturnTrigger::getTrigger()
{
   if(!this->triggerIsNull_){
        return this->trigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> AutoCallConstReturnTrigger::getReturn()
{
   if(!this->returnIsNull_){
        return this->return_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeInteger> AutoCallConstReturnTrigger::getAverageDays()
{
   if(!this->averageDaysIsNull_){
        return this->averageDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AutoCallConstReturnTrigger::getIsExpired()
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

