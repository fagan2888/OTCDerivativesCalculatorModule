// StopLossPayoff.cpp 
#include "StopLossPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StopLossPayoff::StopLossPayoff(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventTriggerListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventTriggerListNode = xmlNode->FirstChildElement("eventTriggerList");

   if(eventTriggerListNode){eventTriggerListIsNull_ = false;}
   else{eventTriggerListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventTriggerListNode , address : " << eventTriggerListNode << std::endl;
   #endif
   if(eventTriggerListNode)
   {
       eventTriggerList_ = boost::shared_ptr<EventTriggerList>(new EventTriggerList(eventTriggerListNode));
   }

   //barrierInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierInfoNode = xmlNode->FirstChildElement("barrierInfo");

   if(barrierInfoNode){barrierInfoIsNull_ = false;}
   else{barrierInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierInfoNode , address : " << barrierInfoNode << std::endl;
   #endif
   if(barrierInfoNode)
   {
       barrierInfo_ = boost::shared_ptr<BarrierInfo>(new BarrierInfo(barrierInfoNode));
   }

   //returnCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnCalculationNode = xmlNode->FirstChildElement("returnCalculation");

   if(returnCalculationNode){returnCalculationIsNull_ = false;}
   else{returnCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnCalculationNode , address : " << returnCalculationNode << std::endl;
   #endif
   if(returnCalculationNode)
   {
       returnCalculation_ = boost::shared_ptr<ReturnCalculation>(new ReturnCalculation(returnCalculationNode));
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
boost::shared_ptr<EventTriggerList> StopLossPayoff::getEventTriggerList()
{
   if(!this->eventTriggerListIsNull_){
        return this->eventTriggerList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventTriggerList>();
   }
}
boost::shared_ptr<BarrierInfo> StopLossPayoff::getBarrierInfo()
{
   if(!this->barrierInfoIsNull_){
        return this->barrierInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BarrierInfo>();
   }
}
boost::shared_ptr<ReturnCalculation> StopLossPayoff::getReturnCalculation()
{
   if(!this->returnCalculationIsNull_){
        return this->returnCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnCalculation>();
   }
}
boost::shared_ptr<PayoffDateInfo> StopLossPayoff::getPayoffDateInfo()
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

