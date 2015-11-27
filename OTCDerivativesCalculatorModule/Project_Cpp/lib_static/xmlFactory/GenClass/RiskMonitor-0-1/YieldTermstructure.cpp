// YieldTermstructure.cpp 
#include "YieldTermstructure.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

YieldTermstructure::YieldTermstructure(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //curveTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* curveTypeNode = xmlNode->FirstChildElement("curveType");

   if(curveTypeNode){curveTypeIsNull_ = false;}
   else{curveTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- curveTypeNode , address : " << curveTypeNode << std::endl;
   #endif
   if(curveTypeNode)
   {
       curveType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(curveTypeNode));
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> YieldTermstructure::getCurveType()
{
   if(!this->curveTypeIsNull_){
        return this->curveType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> YieldTermstructure::getInterpolation()
{
   if(!this->interpolationIsNull_){
        return this->interpolation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> YieldTermstructure::getDaycounter()
{
   if(!this->daycounterIsNull_){
        return this->daycounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> YieldTermstructure::getCalendar()
{
   if(!this->calendarIsNull_){
        return this->calendar_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> YieldTermstructure::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        return this->businessDayConvention_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<RateData>> YieldTermstructure::getRateData()
{
   if(!this->rateDataIsNull_){
        return this->rateData_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RateData>>();
   }
}
}

