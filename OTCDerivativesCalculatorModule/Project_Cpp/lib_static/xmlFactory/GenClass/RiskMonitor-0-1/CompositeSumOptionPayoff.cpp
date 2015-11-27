// CompositeSumOptionPayoff.cpp 
#include "CompositeSumOptionPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CompositeSumOptionPayoff::CompositeSumOptionPayoff(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fixingDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDateInfoNode = xmlNode->FirstChildElement("fixingDateInfo");

   if(fixingDateInfoNode){fixingDateInfoIsNull_ = false;}
   else{fixingDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDateInfoNode , address : " << fixingDateInfoNode << std::endl;
   #endif
   if(fixingDateInfoNode)
   {
       fixingDateInfo_ = boost::shared_ptr<FixingDateInfo>(new FixingDateInfo(fixingDateInfoNode));
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

   //standardOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardOptionNode = xmlNode->FirstChildElement("standardOption");

   if(standardOptionNode){standardOptionIsNull_ = false;}
   else{standardOptionIsNull_ = true;}

   if(standardOptionNode)
   {
      for(standardOptionNode; standardOptionNode; standardOptionNode = standardOptionNode->NextSiblingElement("standardOption")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardOptionNode , address : " << standardOptionNode << std::endl;
          #endif
          standardOption_.push_back(boost::shared_ptr<StandardOption>(new StandardOption(standardOptionNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardOptionNode , address : " << standardOptionNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FixingDateInfo> CompositeSumOptionPayoff::getFixingDateInfo()
{
   if(!this->fixingDateInfoIsNull_){
        return this->fixingDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingDateInfo>();
   }
}
boost::shared_ptr<PayoffDateInfo> CompositeSumOptionPayoff::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<ReferenceCalculationInfo> CompositeSumOptionPayoff::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
std::vector<boost::shared_ptr<StandardOption>> CompositeSumOptionPayoff::getStandardOption()
{
   if(!this->standardOptionIsNull_){
        return this->standardOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<StandardOption>>();
   }
}
}

