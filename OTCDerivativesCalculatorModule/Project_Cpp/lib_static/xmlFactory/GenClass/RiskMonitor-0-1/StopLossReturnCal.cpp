// StopLossReturnCal.cpp 
#include "StopLossReturnCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StopLossReturnCal::StopLossReturnCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //powerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* powerNode = xmlNode->FirstChildElement("power");

   if(powerNode){powerIsNull_ = false;}
   else{powerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- powerNode , address : " << powerNode << std::endl;
   #endif
   if(powerNode)
   {
       power_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(powerNode));
   }

   //lossTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lossTriggerNode = xmlNode->FirstChildElement("lossTrigger");

   if(lossTriggerNode){lossTriggerIsNull_ = false;}
   else{lossTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lossTriggerNode , address : " << lossTriggerNode << std::endl;
   #endif
   if(lossTriggerNode)
   {
       lossTrigger_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(lossTriggerNode));
   }

   //maximumLossNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumLossNode = xmlNode->FirstChildElement("maximumLoss");

   if(maximumLossNode){maximumLossIsNull_ = false;}
   else{maximumLossIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumLossNode , address : " << maximumLossNode << std::endl;
   #endif
   if(maximumLossNode)
   {
       maximumLoss_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(maximumLossNode));
   }

   //referenceCalculationInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCalculationInfoNode = xmlNode->FirstChildElement("referenceCalculationInfo");

   if(referenceCalculationInfoNode){referenceCalculationInfoIsNull_ = false;}
   else{referenceCalculationInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCalculationInfoNode , address : " << referenceCalculationInfoNode << std::endl;
   #endif
   if(referenceCalculationInfoNode)
   {
       referenceCalculationInfo_ = boost::shared_ptr<ReferenceCalculationInfo>(new ReferenceCalculationInfo(referenceCalculationInfoNode));
   }

   //withNotionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* withNotionalNode = xmlNode->FirstChildElement("withNotional");

   if(withNotionalNode){withNotionalIsNull_ = false;}
   else{withNotionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- withNotionalNode , address : " << withNotionalNode << std::endl;
   #endif
   if(withNotionalNode)
   {
       withNotional_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(withNotionalNode));
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
boost::shared_ptr<XsdTypeToken> StopLossReturnCal::getPower()
{
   if(!this->powerIsNull_){
        return this->power_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> StopLossReturnCal::getLossTrigger()
{
   if(!this->lossTriggerIsNull_){
        return this->lossTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> StopLossReturnCal::getMaximumLoss()
{
   if(!this->maximumLossIsNull_){
        return this->maximumLoss_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<ReferenceCalculationInfo> StopLossReturnCal::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
boost::shared_ptr<XsdTypeBoolean> StopLossReturnCal::getWithNotional()
{
   if(!this->withNotionalIsNull_){
        return this->withNotional_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> StopLossReturnCal::getIsExpired()
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

