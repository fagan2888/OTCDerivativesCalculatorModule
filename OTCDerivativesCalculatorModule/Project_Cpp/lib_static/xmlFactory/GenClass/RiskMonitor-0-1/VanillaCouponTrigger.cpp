// VanillaCouponTrigger.cpp 
#include "VanillaCouponTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VanillaCouponTrigger::VanillaCouponTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //gearingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gearingNode = xmlNode->FirstChildElement("gearing");

   if(gearingNode){gearingIsNull_ = false;}
   else{gearingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gearingNode , address : " << gearingNode << std::endl;
   #endif
   if(gearingNode)
   {
       gearing_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(gearingNode));
   }

   //spreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadNode = xmlNode->FirstChildElement("spread");

   if(spreadNode){spreadIsNull_ = false;}
   else{spreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadNode , address : " << spreadNode << std::endl;
   #endif
   if(spreadNode)
   {
       spread_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(spreadNode));
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
boost::shared_ptr<XsdTypeDouble> VanillaCouponTrigger::getGearing()
{
   if(!this->gearingIsNull_){
        return this->gearing_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> VanillaCouponTrigger::getSpread()
{
   if(!this->spreadIsNull_){
        return this->spread_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<ReturnCalculation> VanillaCouponTrigger::getReturnCalculation()
{
   if(!this->returnCalculationIsNull_){
        return this->returnCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnCalculation>();
   }
}
boost::shared_ptr<PayoffDateInfo> VanillaCouponTrigger::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeBoolean> VanillaCouponTrigger::getIsExpired()
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

