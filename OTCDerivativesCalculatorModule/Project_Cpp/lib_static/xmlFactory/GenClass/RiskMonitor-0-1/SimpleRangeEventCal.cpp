// SimpleRangeEventCal.cpp 
#include "SimpleRangeEventCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleRangeEventCal::SimpleRangeEventCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //range1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* range1DNode = xmlNode->FirstChildElement("range1D");

   if(range1DNode){range1DIsNull_ = false;}
   else{range1DIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- range1DNode , address : " << range1DNode << std::endl;
   #endif
   if(range1DNode)
   {
       range1D_ = boost::shared_ptr<Range1D>(new Range1D(range1DNode));
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

   //dateInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateInformationNode = xmlNode->FirstChildElement("dateInformation");

   if(dateInformationNode){dateInformationIsNull_ = false;}
   else{dateInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateInformationNode , address : " << dateInformationNode << std::endl;
   #endif
   if(dateInformationNode)
   {
       dateInformation_ = boost::shared_ptr<DateInformation>(new DateInformation(dateInformationNode));
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
boost::shared_ptr<Range1D> SimpleRangeEventCal::getRange1D()
{
   if(!this->range1DIsNull_){
        return this->range1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Range1D>();
   }
}
boost::shared_ptr<ReferenceCalculationInfo> SimpleRangeEventCal::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
boost::shared_ptr<DateInformation> SimpleRangeEventCal::getDateInformation()
{
   if(!this->dateInformationIsNull_){
        return this->dateInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateInformation>();
   }
}
boost::shared_ptr<JointSimpleCalculation> SimpleRangeEventCal::getJointSimpleCalculation()
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

