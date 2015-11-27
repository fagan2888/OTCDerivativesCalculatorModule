// Tenor.cpp 
#include "Tenor.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Tenor::Tenor(TiXmlNode* xmlNode)
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeInteger> Tenor::getPeriodMultiplier()
{
   if(!this->periodMultiplierIsNull_){
        return this->periodMultiplier_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<XsdTypeToken> Tenor::getPeriod()
{
   if(!this->periodIsNull_){
        return this->period_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

