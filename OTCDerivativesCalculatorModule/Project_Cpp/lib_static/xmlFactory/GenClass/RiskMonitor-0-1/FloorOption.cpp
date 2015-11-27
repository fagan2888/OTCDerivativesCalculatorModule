// FloorOption.cpp 
#include "FloorOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FloorOption::FloorOption(TiXmlNode* xmlNode)
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

   //floorRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floorRateNode = xmlNode->FirstChildElement("floorRate");

   if(floorRateNode){floorRateIsNull_ = false;}
   else{floorRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floorRateNode , address : " << floorRateNode << std::endl;
   #endif
   if(floorRateNode)
   {
       floorRate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(floorRateNode));
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
boost::shared_ptr<XsdTypeToken> FloorOption::getReferenceStr()
{
   if(!this->referenceStrIsNull_){
        return this->referenceStr_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> FloorOption::getFloorRate()
{
   if(!this->floorRateIsNull_){
        return this->floorRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> FloorOption::getVol()
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

