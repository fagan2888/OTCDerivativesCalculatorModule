// SimpleEventCouponTrigger.cpp 
#include "SimpleEventCouponTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleEventCouponTrigger::SimpleEventCouponTrigger(TiXmlNode* xmlNode)
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

   //complementReturnCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* complementReturnCalculationNode = xmlNode->FirstChildElement("complementReturnCalculation");

   if(complementReturnCalculationNode){complementReturnCalculationIsNull_ = false;}
   else{complementReturnCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- complementReturnCalculationNode , address : " << complementReturnCalculationNode << std::endl;
   #endif
   if(complementReturnCalculationNode)
   {
       complementReturnCalculation_ = boost::shared_ptr<ComplementReturnCalculation>(new ComplementReturnCalculation(complementReturnCalculationNode));
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
boost::shared_ptr<EventCalculationInfo> SimpleEventCouponTrigger::getEventCalculationInfo()
{
   if(!this->eventCalculationInfoIsNull_){
        return this->eventCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventCalculationInfo>();
   }
}
boost::shared_ptr<ReturnCalculationInfo> SimpleEventCouponTrigger::getReturnCalculationInfo()
{
   if(!this->returnCalculationInfoIsNull_){
        return this->returnCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnCalculationInfo>();
   }
}
boost::shared_ptr<ComplementReturnCalculation> SimpleEventCouponTrigger::getComplementReturnCalculation()
{
   if(!this->complementReturnCalculationIsNull_){
        return this->complementReturnCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ComplementReturnCalculation>();
   }
}
boost::shared_ptr<PayoffDateInfo> SimpleEventCouponTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeBoolean> SimpleEventCouponTrigger::getIsExpired()
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

