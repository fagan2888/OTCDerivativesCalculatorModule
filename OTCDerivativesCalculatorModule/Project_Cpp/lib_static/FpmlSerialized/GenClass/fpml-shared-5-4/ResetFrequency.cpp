// ResetFrequency.cpp 
#include "ResetFrequency.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ResetFrequency::ResetFrequency(TiXmlNode* xmlNode)
: Frequency(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //weeklyRollConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weeklyRollConventionNode = xmlNode->FirstChildElement("weeklyRollConvention");

   if(weeklyRollConventionNode){weeklyRollConventionIsNull_ = false;}
   else{weeklyRollConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weeklyRollConventionNode , address : " << weeklyRollConventionNode << std::endl;
   #endif
   if(weeklyRollConventionNode)
   {
      if(weeklyRollConventionNode->Attribute("href") || weeklyRollConventionNode->Attribute("id"))
      {
          if(weeklyRollConventionNode->Attribute("id"))
          {
             weeklyRollConventionIDRef_ = weeklyRollConventionNode->Attribute("id");
             weeklyRollConvention_ = boost::shared_ptr<WeeklyRollConventionEnum>(new WeeklyRollConventionEnum(weeklyRollConventionNode));
             weeklyRollConvention_->setID(weeklyRollConventionIDRef_);
             IDManager::instance().setID(weeklyRollConventionIDRef_,weeklyRollConvention_);
          }
          else if(weeklyRollConventionNode->Attribute("href")) { weeklyRollConventionIDRef_ = weeklyRollConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weeklyRollConvention_ = boost::shared_ptr<WeeklyRollConventionEnum>(new WeeklyRollConventionEnum(weeklyRollConventionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<WeeklyRollConventionEnum> ResetFrequency::getWeeklyRollConvention()
{
   if(!this->weeklyRollConventionIsNull_){
        if(weeklyRollConventionIDRef_ != ""){
             return boost::shared_static_cast<WeeklyRollConventionEnum>(IDManager::instance().getID(weeklyRollConventionIDRef_));
        }else{
             return this->weeklyRollConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeeklyRollConventionEnum>();
   }
}
}

