// ReferenceCalculationInfo.cpp 
#include "ReferenceCalculationInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceCalculationInfo::ReferenceCalculationInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fixingInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingInformationNode = xmlNode->FirstChildElement("fixingInformation");

   if(fixingInformationNode){fixingInformationIsNull_ = false;}
   else{fixingInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingInformationNode , address : " << fixingInformationNode << std::endl;
   #endif
   if(fixingInformationNode)
   {
       fixingInformation_ = boost::shared_ptr<FixingInformation>(new FixingInformation(fixingInformationNode));
   }

   //referenceCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCalculationNode = xmlNode->FirstChildElement("referenceCalculation");

   if(referenceCalculationNode){referenceCalculationIsNull_ = false;}
   else{referenceCalculationIsNull_ = true;}

   if(referenceCalculationNode)
   {
      for(referenceCalculationNode; referenceCalculationNode; referenceCalculationNode = referenceCalculationNode->NextSiblingElement("referenceCalculation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCalculationNode , address : " << referenceCalculationNode << std::endl;
          #endif
          referenceCalculation_.push_back(boost::shared_ptr<ReferenceCalculation>(new ReferenceCalculation(referenceCalculationNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCalculationNode , address : " << referenceCalculationNode << std::endl;
       #endif
   }

   //operatorNDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* operatorNDNode = xmlNode->FirstChildElement("operatorND");

   if(operatorNDNode){operatorNDIsNull_ = false;}
   else{operatorNDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- operatorNDNode , address : " << operatorNDNode << std::endl;
   #endif
   if(operatorNDNode)
   {
       operatorND_ = boost::shared_ptr<OperatorND>(new OperatorND(operatorNDNode));
   }

   //postCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* postCalculationNode = xmlNode->FirstChildElement("postCalculation");

   if(postCalculationNode){postCalculationIsNull_ = false;}
   else{postCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- postCalculationNode , address : " << postCalculationNode << std::endl;
   #endif
   if(postCalculationNode)
   {
       postCalculation_ = boost::shared_ptr<PostCalculation>(new PostCalculation(postCalculationNode));
   }

   //refVariable_referenceValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refVariable_referenceValueNode = xmlNode->FirstChildElement("refVariable_referenceValue");

   if(refVariable_referenceValueNode){refVariable_referenceValueIsNull_ = false;}
   else{refVariable_referenceValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refVariable_referenceValueNode , address : " << refVariable_referenceValueNode << std::endl;
   #endif
   if(refVariable_referenceValueNode)
   {
       refVariable_referenceValue_ = boost::shared_ptr<RefVariable_referenceValue>(new RefVariable_referenceValue(refVariable_referenceValueNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FixingInformation> ReferenceCalculationInfo::getFixingInformation()
{
   if(!this->fixingInformationIsNull_){
        return this->fixingInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingInformation>();
   }
}
std::vector<boost::shared_ptr<ReferenceCalculation>> ReferenceCalculationInfo::getReferenceCalculation()
{
   if(!this->referenceCalculationIsNull_){
        return this->referenceCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReferenceCalculation>>();
   }
}
boost::shared_ptr<OperatorND> ReferenceCalculationInfo::getOperatorND()
{
   if(!this->operatorNDIsNull_){
        return this->operatorND_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OperatorND>();
   }
}
boost::shared_ptr<PostCalculation> ReferenceCalculationInfo::getPostCalculation()
{
   if(!this->postCalculationIsNull_){
        return this->postCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PostCalculation>();
   }
}
boost::shared_ptr<RefVariable_referenceValue> ReferenceCalculationInfo::getRefVariable_referenceValue()
{
   if(!this->refVariable_referenceValueIsNull_){
        return this->refVariable_referenceValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RefVariable_referenceValue>();
   }
}
}

