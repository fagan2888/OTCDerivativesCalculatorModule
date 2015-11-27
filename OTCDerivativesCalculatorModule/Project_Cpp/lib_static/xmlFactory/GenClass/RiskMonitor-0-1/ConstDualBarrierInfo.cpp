// ConstDualBarrierInfo.cpp 
#include "ConstDualBarrierInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ConstDualBarrierInfo::ConstDualBarrierInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //barrierDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierDateInfoNode = xmlNode->FirstChildElement("barrierDateInfo");

   if(barrierDateInfoNode){barrierDateInfoIsNull_ = false;}
   else{barrierDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierDateInfoNode , address : " << barrierDateInfoNode << std::endl;
   #endif
   if(barrierDateInfoNode)
   {
       barrierDateInfo_ = boost::shared_ptr<BarrierDateInfo>(new BarrierDateInfo(barrierDateInfoNode));
   }

   //upperTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperTriggerNode = xmlNode->FirstChildElement("upperTrigger");

   if(upperTriggerNode){upperTriggerIsNull_ = false;}
   else{upperTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperTriggerNode , address : " << upperTriggerNode << std::endl;
   #endif
   if(upperTriggerNode)
   {
       upperTrigger_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(upperTriggerNode));
   }

   //lowerTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerTriggerNode = xmlNode->FirstChildElement("lowerTrigger");

   if(lowerTriggerNode){lowerTriggerIsNull_ = false;}
   else{lowerTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerTriggerNode , address : " << lowerTriggerNode << std::endl;
   #endif
   if(lowerTriggerNode)
   {
       lowerTrigger_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(lowerTriggerNode));
   }

   //pastEventOccDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pastEventOccDateNode = xmlNode->FirstChildElement("pastEventOccDate");

   if(pastEventOccDateNode){pastEventOccDateIsNull_ = false;}
   else{pastEventOccDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pastEventOccDateNode , address : " << pastEventOccDateNode << std::endl;
   #endif
   if(pastEventOccDateNode)
   {
       pastEventOccDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(pastEventOccDateNode));
   }

   //pastEventOccValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pastEventOccValueNode = xmlNode->FirstChildElement("pastEventOccValue");

   if(pastEventOccValueNode){pastEventOccValueIsNull_ = false;}
   else{pastEventOccValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pastEventOccValueNode , address : " << pastEventOccValueNode << std::endl;
   #endif
   if(pastEventOccValueNode)
   {
       pastEventOccValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(pastEventOccValueNode));
   }

   //refVariableFlag_eventOccDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refVariableFlag_eventOccDateNode = xmlNode->FirstChildElement("refVariableFlag_eventOccDate");

   if(refVariableFlag_eventOccDateNode){refVariableFlag_eventOccDateIsNull_ = false;}
   else{refVariableFlag_eventOccDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refVariableFlag_eventOccDateNode , address : " << refVariableFlag_eventOccDateNode << std::endl;
   #endif
   if(refVariableFlag_eventOccDateNode)
   {
       refVariableFlag_eventOccDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refVariableFlag_eventOccDateNode));
   }

   //refVariableFlag_eventOccValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refVariableFlag_eventOccValueNode = xmlNode->FirstChildElement("refVariableFlag_eventOccValue");

   if(refVariableFlag_eventOccValueNode){refVariableFlag_eventOccValueIsNull_ = false;}
   else{refVariableFlag_eventOccValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refVariableFlag_eventOccValueNode , address : " << refVariableFlag_eventOccValueNode << std::endl;
   #endif
   if(refVariableFlag_eventOccValueNode)
   {
       refVariableFlag_eventOccValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refVariableFlag_eventOccValueNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReferenceCalculationInfo> ConstDualBarrierInfo::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
boost::shared_ptr<BarrierDateInfo> ConstDualBarrierInfo::getBarrierDateInfo()
{
   if(!this->barrierDateInfoIsNull_){
        return this->barrierDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BarrierDateInfo>();
   }
}
boost::shared_ptr<XsdTypeDouble> ConstDualBarrierInfo::getUpperTrigger()
{
   if(!this->upperTriggerIsNull_){
        return this->upperTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> ConstDualBarrierInfo::getLowerTrigger()
{
   if(!this->lowerTriggerIsNull_){
        return this->lowerTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDate> ConstDualBarrierInfo::getPastEventOccDate()
{
   if(!this->pastEventOccDateIsNull_){
        return this->pastEventOccDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDouble> ConstDualBarrierInfo::getPastEventOccValue()
{
   if(!this->pastEventOccValueIsNull_){
        return this->pastEventOccValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeToken> ConstDualBarrierInfo::getRefVariableFlag_eventOccDate()
{
   if(!this->refVariableFlag_eventOccDateIsNull_){
        return this->refVariableFlag_eventOccDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> ConstDualBarrierInfo::getRefVariableFlag_eventOccValue()
{
   if(!this->refVariableFlag_eventOccValueIsNull_){
        return this->refVariableFlag_eventOccValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

