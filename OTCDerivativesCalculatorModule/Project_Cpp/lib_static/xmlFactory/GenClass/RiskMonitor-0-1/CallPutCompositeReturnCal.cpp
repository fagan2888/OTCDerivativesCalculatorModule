// CallPutCompositeReturnCal.cpp 
#include "CallPutCompositeReturnCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CallPutCompositeReturnCal::CallPutCompositeReturnCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //weightNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weightNode = xmlNode->FirstChildElement("weight");

   if(weightNode){weightIsNull_ = false;}
   else{weightIsNull_ = true;}

   if(weightNode)
   {
      for(weightNode; weightNode; weightNode = weightNode->NextSiblingElement("weight")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightNode , address : " << weightNode << std::endl;
          #endif
          weight_.push_back(boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(weightNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightNode , address : " << weightNode << std::endl;
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

   //optionPayoffFunctionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionPayoffFunctionNode = xmlNode->FirstChildElement("optionPayoffFunction");

   if(optionPayoffFunctionNode){optionPayoffFunctionIsNull_ = false;}
   else{optionPayoffFunctionIsNull_ = true;}

   if(optionPayoffFunctionNode)
   {
      for(optionPayoffFunctionNode; optionPayoffFunctionNode; optionPayoffFunctionNode = optionPayoffFunctionNode->NextSiblingElement("optionPayoffFunction")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionPayoffFunctionNode , address : " << optionPayoffFunctionNode << std::endl;
          #endif
          optionPayoffFunction_.push_back(boost::shared_ptr<OptionPayoffFunction>(new OptionPayoffFunction(optionPayoffFunctionNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionPayoffFunctionNode , address : " << optionPayoffFunctionNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<XsdTypeDouble>> CallPutCompositeReturnCal::getWeight()
{
   if(!this->weightIsNull_){
        return this->weight_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDouble>>();
   }
}
boost::shared_ptr<ReferenceCalculationInfo> CallPutCompositeReturnCal::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
std::vector<boost::shared_ptr<OptionPayoffFunction>> CallPutCompositeReturnCal::getOptionPayoffFunction()
{
   if(!this->optionPayoffFunctionIsNull_){
        return this->optionPayoffFunction_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<OptionPayoffFunction>>();
   }
}
}

