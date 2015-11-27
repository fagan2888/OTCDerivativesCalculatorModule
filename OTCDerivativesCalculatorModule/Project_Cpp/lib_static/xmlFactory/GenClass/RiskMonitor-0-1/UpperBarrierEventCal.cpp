// UpperBarrierEventCal.cpp 
#include "UpperBarrierEventCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UpperBarrierEventCal::UpperBarrierEventCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateInformationNode = xmlNode->FirstChildElement("dateInformation");

   if(dateInformationNode){dateInformationIsNull_ = false;}
   else{dateInformationIsNull_ = true;}

   if(dateInformationNode)
   {
      for(dateInformationNode; dateInformationNode; dateInformationNode = dateInformationNode->NextSiblingElement("dateInformation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateInformationNode , address : " << dateInformationNode << std::endl;
          #endif
          dateInformation_.push_back(boost::shared_ptr<DateInformation>(new DateInformation(dateInformationNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateInformationNode , address : " << dateInformationNode << std::endl;
       #endif
   }

   //upperTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperTriggerNode = xmlNode->FirstChildElement("upperTrigger");

   if(upperTriggerNode){upperTriggerIsNull_ = false;}
   else{upperTriggerIsNull_ = true;}

   if(upperTriggerNode)
   {
      for(upperTriggerNode; upperTriggerNode; upperTriggerNode = upperTriggerNode->NextSiblingElement("upperTrigger")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperTriggerNode , address : " << upperTriggerNode << std::endl;
          #endif
          upperTrigger_.push_back(boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(upperTriggerNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperTriggerNode , address : " << upperTriggerNode << std::endl;
       #endif
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<DateInformation>> UpperBarrierEventCal::getDateInformation()
{
   if(!this->dateInformationIsNull_){
        return this->dateInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DateInformation>>();
   }
}
std::vector<boost::shared_ptr<XsdTypeDouble>> UpperBarrierEventCal::getUpperTrigger()
{
   if(!this->upperTriggerIsNull_){
        return this->upperTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDouble>>();
   }
}
boost::shared_ptr<ReferenceCalculationInfo> UpperBarrierEventCal::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
}

