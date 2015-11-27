// CapOption.cpp 
#include "CapOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CapOption::CapOption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceStrNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceStrNode = xmlNode->FirstChildElement("referenceStr");

   if(referenceStrNode){referenceStrIsNull_ = false;}
   else{referenceStrIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceStrNode , address : " << referenceStrNode << std::endl;
   #endif
   if(referenceStrNode)
   {
       referenceStr_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(referenceStrNode));
   }

   //capRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* capRateNode = xmlNode->FirstChildElement("capRate");

   if(capRateNode){capRateIsNull_ = false;}
   else{capRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capRateNode , address : " << capRateNode << std::endl;
   #endif
   if(capRateNode)
   {
       capRate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(capRateNode));
   }

   //volNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* volNode = xmlNode->FirstChildElement("vol");

   if(volNode){volIsNull_ = false;}
   else{volIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- volNode , address : " << volNode << std::endl;
   #endif
   if(volNode)
   {
       vol_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(volNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CapOption::getReferenceStr()
{
   if(!this->referenceStrIsNull_){
        return this->referenceStr_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CapOption::getCapRate()
{
   if(!this->capRateIsNull_){
        return this->capRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CapOption::getVol()
{
   if(!this->volIsNull_){
        return this->vol_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

