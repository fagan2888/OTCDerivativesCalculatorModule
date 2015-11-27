// StrategyFeature.cpp 
#include "StrategyFeature.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StrategyFeature::StrategyFeature(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //strikeSpreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeSpreadNode = xmlNode->FirstChildElement("strikeSpread");

   if(strikeSpreadNode){strikeSpreadIsNull_ = false;}
   else{strikeSpreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeSpreadNode , address : " << strikeSpreadNode << std::endl;
   #endif
   if(strikeSpreadNode)
   {
      if(strikeSpreadNode->Attribute("href") || strikeSpreadNode->Attribute("id"))
      {
          if(strikeSpreadNode->Attribute("id"))
          {
             strikeSpreadIDRef_ = strikeSpreadNode->Attribute("id");
             strikeSpread_ = boost::shared_ptr<StrikeSpread>(new StrikeSpread(strikeSpreadNode));
             strikeSpread_->setID(strikeSpreadIDRef_);
             IDManager::instance().setID(strikeSpreadIDRef_,strikeSpread_);
          }
          else if(strikeSpreadNode->Attribute("href")) { strikeSpreadIDRef_ = strikeSpreadNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikeSpread_ = boost::shared_ptr<StrikeSpread>(new StrikeSpread(strikeSpreadNode));}
   }

   //calendarSpreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calendarSpreadNode = xmlNode->FirstChildElement("calendarSpread");

   if(calendarSpreadNode){calendarSpreadIsNull_ = false;}
   else{calendarSpreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calendarSpreadNode , address : " << calendarSpreadNode << std::endl;
   #endif
   if(calendarSpreadNode)
   {
      if(calendarSpreadNode->Attribute("href") || calendarSpreadNode->Attribute("id"))
      {
          if(calendarSpreadNode->Attribute("id"))
          {
             calendarSpreadIDRef_ = calendarSpreadNode->Attribute("id");
             calendarSpread_ = boost::shared_ptr<CalendarSpread>(new CalendarSpread(calendarSpreadNode));
             calendarSpread_->setID(calendarSpreadIDRef_);
             IDManager::instance().setID(calendarSpreadIDRef_,calendarSpread_);
          }
          else if(calendarSpreadNode->Attribute("href")) { calendarSpreadIDRef_ = calendarSpreadNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calendarSpread_ = boost::shared_ptr<CalendarSpread>(new CalendarSpread(calendarSpreadNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<StrikeSpread> StrategyFeature::getStrikeSpread()
{
   if(!this->strikeSpreadIsNull_){
        if(strikeSpreadIDRef_ != ""){
             return boost::shared_static_cast<StrikeSpread>(IDManager::instance().getID(strikeSpreadIDRef_));
        }else{
             return this->strikeSpread_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StrikeSpread>();
   }
}
boost::shared_ptr<CalendarSpread> StrategyFeature::getCalendarSpread()
{
   if(!this->calendarSpreadIsNull_){
        if(calendarSpreadIDRef_ != ""){
             return boost::shared_static_cast<CalendarSpread>(IDManager::instance().getID(calendarSpreadIDRef_));
        }else{
             return this->calendarSpread_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalendarSpread>();
   }
}
}

