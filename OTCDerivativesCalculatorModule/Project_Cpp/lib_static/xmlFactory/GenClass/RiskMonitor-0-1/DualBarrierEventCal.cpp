// DualBarrierEventCal.cpp 
#include "DualBarrierEventCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DualBarrierEventCal::DualBarrierEventCal(TiXmlNode* xmlNode)
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

   //lowerTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerTriggerNode = xmlNode->FirstChildElement("lowerTrigger");

   if(lowerTriggerNode){lowerTriggerIsNull_ = false;}
   else{lowerTriggerIsNull_ = true;}

   if(lowerTriggerNode)
   {
      for(lowerTriggerNode; lowerTriggerNode; lowerTriggerNode = lowerTriggerNode->NextSiblingElement("lowerTrigger")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerTriggerNode , address : " << lowerTriggerNode << std::endl;
          #endif
          lowerTrigger_.push_back(boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(lowerTriggerNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerTriggerNode , address : " << lowerTriggerNode << std::endl;
       #endif
   }

   //referenceCalculationInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCalculationInfoNode = xmlNode->FirstChildElement("referenceCalculationInfo");

   if(referenceCalculationInfoNode){referenceCalculationInfoIsNull_ = false;}
   else{referenceCalculationInfoIsNull_ = true;}

   if(referenceCalculationInfoNode)
   {
      for(referenceCalculationInfoNode; referenceCalculationInfoNode; referenceCalculationInfoNode = referenceCalculationInfoNode->NextSiblingElement("referenceCalculationInfo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCalculationInfoNode , address : " << referenceCalculationInfoNode << std::endl;
          #endif
          referenceCalculationInfo_.push_back(boost::shared_ptr<ReferenceCalculationInfo>(new ReferenceCalculationInfo(referenceCalculationInfoNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCalculationInfoNode , address : " << referenceCalculationInfoNode << std::endl;
       #endif
   }

   //jointSimpleCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointSimpleCalculationNode = xmlNode->FirstChildElement("jointSimpleCalculation");

   if(jointSimpleCalculationNode){jointSimpleCalculationIsNull_ = false;}
   else{jointSimpleCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointSimpleCalculationNode , address : " << jointSimpleCalculationNode << std::endl;
   #endif
   if(jointSimpleCalculationNode)
   {
       jointSimpleCalculation_ = boost::shared_ptr<JointSimpleCalculation>(new JointSimpleCalculation(jointSimpleCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<DateInformation>> DualBarrierEventCal::getDateInformation()
{
   if(!this->dateInformationIsNull_){
        return this->dateInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DateInformation>>();
   }
}
std::vector<boost::shared_ptr<XsdTypeDouble>> DualBarrierEventCal::getUpperTrigger()
{
   if(!this->upperTriggerIsNull_){
        return this->upperTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDouble>>();
   }
}
std::vector<boost::shared_ptr<XsdTypeDouble>> DualBarrierEventCal::getLowerTrigger()
{
   if(!this->lowerTriggerIsNull_){
        return this->lowerTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDouble>>();
   }
}
std::vector<boost::shared_ptr<ReferenceCalculationInfo>> DualBarrierEventCal::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReferenceCalculationInfo>>();
   }
}
boost::shared_ptr<JointSimpleCalculation> DualBarrierEventCal::getJointSimpleCalculation()
{
   if(!this->jointSimpleCalculationIsNull_){
        return this->jointSimpleCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<JointSimpleCalculation>();
   }
}
}

