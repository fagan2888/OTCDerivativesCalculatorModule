// VanillaPutOption.cpp 
#include "VanillaPutOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VanillaPutOption::VanillaPutOption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //participateRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* participateRateNode = xmlNode->FirstChildElement("participateRate");

   if(participateRateNode){participateRateIsNull_ = false;}
   else{participateRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- participateRateNode , address : " << participateRateNode << std::endl;
   #endif
   if(participateRateNode)
   {
       participateRate_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(participateRateNode));
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

   //strikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeNode = xmlNode->FirstChildElement("strike");

   if(strikeNode){strikeIsNull_ = false;}
   else{strikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
   #endif
   if(strikeNode)
   {
       strike_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(strikeNode));
   }

   //lowerBoundNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerBoundNode = xmlNode->FirstChildElement("lowerBound");

   if(lowerBoundNode){lowerBoundIsNull_ = false;}
   else{lowerBoundIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerBoundNode , address : " << lowerBoundNode << std::endl;
   #endif
   if(lowerBoundNode)
   {
       lowerBound_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(lowerBoundNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PayoffDateInfo> VanillaPutOption::getPayoffDateInfo()
{
   if(!this->payoffDateInfoIsNull_){
        return this->payoffDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffDateInfo>();
   }
}
boost::shared_ptr<XsdTypeDouble> VanillaPutOption::getParticipateRate()
{
   if(!this->participateRateIsNull_){
        return this->participateRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<ReferenceCalculationInfo> VanillaPutOption::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
boost::shared_ptr<XsdTypeDouble> VanillaPutOption::getStrike()
{
   if(!this->strikeIsNull_){
        return this->strike_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> VanillaPutOption::getLowerBound()
{
   if(!this->lowerBoundIsNull_){
        return this->lowerBound_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

