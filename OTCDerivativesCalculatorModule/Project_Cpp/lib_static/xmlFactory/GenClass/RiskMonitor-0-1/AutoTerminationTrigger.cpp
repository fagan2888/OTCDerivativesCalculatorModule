// AutoTerminationTrigger.cpp 
#include "AutoTerminationTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AutoTerminationTrigger::AutoTerminationTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventCalculationInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventCalculationInfoNode = xmlNode->FirstChildElement("eventCalculationInfo");

   if(eventCalculationInfoNode){eventCalculationInfoIsNull_ = false;}
   else{eventCalculationInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCalculationInfoNode , address : " << eventCalculationInfoNode << std::endl;
   #endif
   if(eventCalculationInfoNode)
   {
       eventCalculationInfo_ = boost::shared_ptr<EventCalculationInfo>(new EventCalculationInfo(eventCalculationInfoNode));
   }

   //returnCalculationInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnCalculationInfoNode = xmlNode->FirstChildElement("returnCalculationInfo");

   if(returnCalculationInfoNode){returnCalculationInfoIsNull_ = false;}
   else{returnCalculationInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnCalculationInfoNode , address : " << returnCalculationInfoNode << std::endl;
   #endif
   if(returnCalculationInfoNode)
   {
       returnCalculationInfo_ = boost::shared_ptr<ReturnCalculationInfo>(new ReturnCalculationInfo(returnCalculationInfoNode));
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
boost::shared_ptr<EventCalculationInfo> AutoTerminationTrigger::getEventCalculationInfo()
{
   if(!this->eventCalculationInfoIsNull_){
        return this->eventCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventCalculationInfo>();
   }
}
boost::shared_ptr<ReturnCalculationInfo> AutoTerminationTrigger::getReturnCalculationInfo()
{
   if(!this->returnCalculationInfoIsNull_){
        return this->returnCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnCalculationInfo>();
   }
}
boost::shared_ptr<PayoffDateInfo> AutoTerminationTrigger::getPayoffDateInfo()
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

