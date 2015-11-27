// CdsSpreadTermstructure.cpp 
#include "CdsSpreadTermstructure.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CdsSpreadTermstructure::CdsSpreadTermstructure(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //interpolationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interpolationNode = xmlNode->FirstChildElement("interpolation");

   if(interpolationNode){interpolationIsNull_ = false;}
   else{interpolationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interpolationNode , address : " << interpolationNode << std::endl;
   #endif
   if(interpolationNode)
   {
       interpolation_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(interpolationNode));
   }

   //daycounterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* daycounterNode = xmlNode->FirstChildElement("daycounter");

   if(daycounterNode){daycounterIsNull_ = false;}
   else{daycounterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- daycounterNode , address : " << daycounterNode << std::endl;
   #endif
   if(daycounterNode)
   {
       daycounter_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(daycounterNode));
   }

   //calendarNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calendarNode = xmlNode->FirstChildElement("calendar");

   if(calendarNode){calendarIsNull_ = false;}
   else{calendarIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calendarNode , address : " << calendarNode << std::endl;
   #endif
   if(calendarNode)
   {
       calendar_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calendarNode));
   }

   //businessDayConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayConventionNode = xmlNode->FirstChildElement("businessDayConvention");

   if(businessDayConventionNode){businessDayConventionIsNull_ = false;}
   else{businessDayConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayConventionNode , address : " << businessDayConventionNode << std::endl;
   #endif
   if(businessDayConventionNode)
   {
       businessDayConvention_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(businessDayConventionNode));
   }

   //rateDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateDataNode = xmlNode->FirstChildElement("rateData");

   if(rateDataNode){rateDataIsNull_ = false;}
   else{rateDataIsNull_ = true;}

   if(rateDataNode)
   {
      for(rateDataNode; rateDataNode; rateDataNode = rateDataNode->NextSiblingElement("rateData")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateDataNode , address : " << rateDataNode << std::endl;
          #endif
          rateData_.push_back(boost::shared_ptr<RateData>(new RateData(rateDataNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateDataNode , address : " << rateDataNode << std::endl;
       #endif
   }

   //dateGenerationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateGenerationNode = xmlNode->FirstChildElement("dateGeneration");

   if(dateGenerationNode){dateGenerationIsNull_ = false;}
   else{dateGenerationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateGenerationNode , address : " << dateGenerationNode << std::endl;
   #endif
   if(dateGenerationNode)
   {
       dateGeneration_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dateGenerationNode));
   }

   //recoveryRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* recoveryRateNode = xmlNode->FirstChildElement("recoveryRate");

   if(recoveryRateNode){recoveryRateIsNull_ = false;}
   else{recoveryRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- recoveryRateNode , address : " << recoveryRateNode << std::endl;
   #endif
   if(recoveryRateNode)
   {
       recoveryRate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(recoveryRateNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CdsSpreadTermstructure::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CdsSpreadTermstructure::getInterpolation()
{
   if(!this->interpolationIsNull_){
        return this->interpolation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CdsSpreadTermstructure::getDaycounter()
{
   if(!this->daycounterIsNull_){
        return this->daycounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CdsSpreadTermstructure::getCalendar()
{
   if(!this->calendarIsNull_){
        return this->calendar_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CdsSpreadTermstructure::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        return this->businessDayConvention_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<RateData>> CdsSpreadTermstructure::getRateData()
{
   if(!this->rateDataIsNull_){
        return this->rateData_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RateData>>();
   }
}
boost::shared_ptr<XsdTypeToken> CdsSpreadTermstructure::getDateGeneration()
{
   if(!this->dateGenerationIsNull_){
        return this->dateGeneration_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CdsSpreadTermstructure::getRecoveryRate()
{
   if(!this->recoveryRateIsNull_){
        return this->recoveryRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

