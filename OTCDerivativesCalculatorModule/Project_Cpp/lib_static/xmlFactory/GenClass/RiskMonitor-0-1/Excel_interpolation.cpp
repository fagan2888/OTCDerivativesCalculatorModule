// Excel_interpolation.cpp 
#include "Excel_interpolation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_interpolation::Excel_interpolation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_interpolation::getInterpolation()
{
   if(!this->interpolationIsNull_){
        return this->interpolation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_interpolation::getDaycounter()
{
   if(!this->daycounterIsNull_){
        return this->daycounter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_interpolation::getCalendar()
{
   if(!this->calendarIsNull_){
        return this->calendar_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_interpolation::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        return this->businessDayConvention_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

