// CalculationPeriodFrequency.cpp 
#include "CalculationPeriodFrequency.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationPeriodFrequency::CalculationPeriodFrequency(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //periodMultiplierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* periodMultiplierNode = xmlNode->FirstChildElement("periodMultiplier");

   if(periodMultiplierNode){periodMultiplierIsNull_ = false;}
   else{periodMultiplierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- periodMultiplierNode , address : " << periodMultiplierNode << std::endl;
   #endif
   if(periodMultiplierNode)
   {
       periodMultiplier_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(periodMultiplierNode));
   }

   //periodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* periodNode = xmlNode->FirstChildElement("period");

   if(periodNode){periodIsNull_ = false;}
   else{periodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- periodNode , address : " << periodNode << std::endl;
   #endif
   if(periodNode)
   {
       period_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(periodNode));
   }

   //rollConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rollConventionNode = xmlNode->FirstChildElement("rollConvention");

   if(rollConventionNode){rollConventionIsNull_ = false;}
   else{rollConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rollConventionNode , address : " << rollConventionNode << std::endl;
   #endif
   if(rollConventionNode)
   {
       rollConvention_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(rollConventionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeInteger> CalculationPeriodFrequency::getPeriodMultiplier()
{
   if(!this->periodMultiplierIsNull_){
        return this->periodMultiplier_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<XsdTypeToken> CalculationPeriodFrequency::getPeriod()
{
   if(!this->periodIsNull_){
        return this->period_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeInteger> CalculationPeriodFrequency::getRollConvention()
{
   if(!this->rollConventionIsNull_){
        return this->rollConvention_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
}

