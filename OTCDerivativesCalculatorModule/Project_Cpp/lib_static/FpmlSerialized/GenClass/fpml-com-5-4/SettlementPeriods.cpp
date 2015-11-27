// SettlementPeriods.cpp 
#include "SettlementPeriods.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettlementPeriods::SettlementPeriods(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //durationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* durationNode = xmlNode->FirstChildElement("duration");

   if(durationNode){durationIsNull_ = false;}
   else{durationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- durationNode , address : " << durationNode << std::endl;
   #endif
   if(durationNode)
   {
      if(durationNode->Attribute("href") || durationNode->Attribute("id"))
      {
          if(durationNode->Attribute("id"))
          {
             durationIDRef_ = durationNode->Attribute("id");
             duration_ = boost::shared_ptr<SettlementPeriodDurationEnum>(new SettlementPeriodDurationEnum(durationNode));
             duration_->setID(durationIDRef_);
             IDManager::instance().setID(durationIDRef_,duration_);
          }
          else if(durationNode->Attribute("href")) { durationIDRef_ = durationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { duration_ = boost::shared_ptr<SettlementPeriodDurationEnum>(new SettlementPeriodDurationEnum(durationNode));}
   }

   //applicableDayNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* applicableDayNode = xmlNode->FirstChildElement("applicableDay");

   if(applicableDayNode){applicableDayIsNull_ = false;}
   else{applicableDayIsNull_ = true;}

   if(applicableDayNode)
   {
      for(applicableDayNode; applicableDayNode; applicableDayNode = applicableDayNode->NextSiblingElement("applicableDay")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- applicableDayNode , address : " << applicableDayNode << std::endl;
          #endif
          if(applicableDayNode->Attribute("href") || applicableDayNode->Attribute("id"))
          {
              if(applicableDayNode->Attribute("id"))
              {
                  applicableDayIDRef_ = applicableDayNode->Attribute("id");
                  applicableDay_.push_back(boost::shared_ptr<DayOfWeekEnum>(new DayOfWeekEnum(applicableDayNode)));
                  applicableDay_.back()->setID(applicableDayIDRef_);
                  IDManager::instance().setID(applicableDayIDRef_, applicableDay_.back());
              }
              else if(applicableDayNode->Attribute("href")) { applicableDayIDRef_ = applicableDayNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { applicableDay_.push_back(boost::shared_ptr<DayOfWeekEnum>(new DayOfWeekEnum(applicableDayNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- applicableDayNode , address : " << applicableDayNode << std::endl;
       #endif
   }

   //startTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* startTimeNode = xmlNode->FirstChildElement("startTime");

   if(startTimeNode){startTimeIsNull_ = false;}
   else{startTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- startTimeNode , address : " << startTimeNode << std::endl;
   #endif
   if(startTimeNode)
   {
      if(startTimeNode->Attribute("href") || startTimeNode->Attribute("id"))
      {
          if(startTimeNode->Attribute("id"))
          {
             startTimeIDRef_ = startTimeNode->Attribute("id");
             startTime_ = boost::shared_ptr<OffsetPrevailingTime>(new OffsetPrevailingTime(startTimeNode));
             startTime_->setID(startTimeIDRef_);
             IDManager::instance().setID(startTimeIDRef_,startTime_);
          }
          else if(startTimeNode->Attribute("href")) { startTimeIDRef_ = startTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { startTime_ = boost::shared_ptr<OffsetPrevailingTime>(new OffsetPrevailingTime(startTimeNode));}
   }

   //endTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* endTimeNode = xmlNode->FirstChildElement("endTime");

   if(endTimeNode){endTimeIsNull_ = false;}
   else{endTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- endTimeNode , address : " << endTimeNode << std::endl;
   #endif
   if(endTimeNode)
   {
      if(endTimeNode->Attribute("href") || endTimeNode->Attribute("id"))
      {
          if(endTimeNode->Attribute("id"))
          {
             endTimeIDRef_ = endTimeNode->Attribute("id");
             endTime_ = boost::shared_ptr<OffsetPrevailingTime>(new OffsetPrevailingTime(endTimeNode));
             endTime_->setID(endTimeIDRef_);
             IDManager::instance().setID(endTimeIDRef_,endTime_);
          }
          else if(endTimeNode->Attribute("href")) { endTimeIDRef_ = endTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { endTime_ = boost::shared_ptr<OffsetPrevailingTime>(new OffsetPrevailingTime(endTimeNode));}
   }

   //excludeHolidaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excludeHolidaysNode = xmlNode->FirstChildElement("excludeHolidays");

   if(excludeHolidaysNode){excludeHolidaysIsNull_ = false;}
   else{excludeHolidaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excludeHolidaysNode , address : " << excludeHolidaysNode << std::endl;
   #endif
   if(excludeHolidaysNode)
   {
      if(excludeHolidaysNode->Attribute("href") || excludeHolidaysNode->Attribute("id"))
      {
          if(excludeHolidaysNode->Attribute("id"))
          {
             excludeHolidaysIDRef_ = excludeHolidaysNode->Attribute("id");
             excludeHolidays_ = boost::shared_ptr<CommodityBusinessCalendar>(new CommodityBusinessCalendar(excludeHolidaysNode));
             excludeHolidays_->setID(excludeHolidaysIDRef_);
             IDManager::instance().setID(excludeHolidaysIDRef_,excludeHolidays_);
          }
          else if(excludeHolidaysNode->Attribute("href")) { excludeHolidaysIDRef_ = excludeHolidaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { excludeHolidays_ = boost::shared_ptr<CommodityBusinessCalendar>(new CommodityBusinessCalendar(excludeHolidaysNode));}
   }

   //includeHolidaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* includeHolidaysNode = xmlNode->FirstChildElement("includeHolidays");

   if(includeHolidaysNode){includeHolidaysIsNull_ = false;}
   else{includeHolidaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- includeHolidaysNode , address : " << includeHolidaysNode << std::endl;
   #endif
   if(includeHolidaysNode)
   {
      if(includeHolidaysNode->Attribute("href") || includeHolidaysNode->Attribute("id"))
      {
          if(includeHolidaysNode->Attribute("id"))
          {
             includeHolidaysIDRef_ = includeHolidaysNode->Attribute("id");
             includeHolidays_ = boost::shared_ptr<CommodityBusinessCalendar>(new CommodityBusinessCalendar(includeHolidaysNode));
             includeHolidays_->setID(includeHolidaysIDRef_);
             IDManager::instance().setID(includeHolidaysIDRef_,includeHolidays_);
          }
          else if(includeHolidaysNode->Attribute("href")) { includeHolidaysIDRef_ = includeHolidaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { includeHolidays_ = boost::shared_ptr<CommodityBusinessCalendar>(new CommodityBusinessCalendar(includeHolidaysNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SettlementPeriodDurationEnum> SettlementPeriods::getDuration()
{
   if(!this->durationIsNull_){
        if(durationIDRef_ != ""){
             return boost::shared_static_cast<SettlementPeriodDurationEnum>(IDManager::instance().getID(durationIDRef_));
        }else{
             return this->duration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementPeriodDurationEnum>();
   }
}
std::vector<boost::shared_ptr<DayOfWeekEnum>> SettlementPeriods::getApplicableDay()
{
   if(!this->applicableDayIsNull_){
        if(applicableDayIDRef_ != ""){
             return this->applicableDay_;
        }else{
             return this->applicableDay_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DayOfWeekEnum>>();
   }
}
boost::shared_ptr<OffsetPrevailingTime> SettlementPeriods::getStartTime()
{
   if(!this->startTimeIsNull_){
        if(startTimeIDRef_ != ""){
             return boost::shared_static_cast<OffsetPrevailingTime>(IDManager::instance().getID(startTimeIDRef_));
        }else{
             return this->startTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OffsetPrevailingTime>();
   }
}
boost::shared_ptr<OffsetPrevailingTime> SettlementPeriods::getEndTime()
{
   if(!this->endTimeIsNull_){
        if(endTimeIDRef_ != ""){
             return boost::shared_static_cast<OffsetPrevailingTime>(IDManager::instance().getID(endTimeIDRef_));
        }else{
             return this->endTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OffsetPrevailingTime>();
   }
}
boost::shared_ptr<CommodityBusinessCalendar> SettlementPeriods::getExcludeHolidays()
{
   if(!this->excludeHolidaysIsNull_){
        if(excludeHolidaysIDRef_ != ""){
             return boost::shared_static_cast<CommodityBusinessCalendar>(IDManager::instance().getID(excludeHolidaysIDRef_));
        }else{
             return this->excludeHolidays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityBusinessCalendar>();
   }
}
boost::shared_ptr<CommodityBusinessCalendar> SettlementPeriods::getIncludeHolidays()
{
   if(!this->includeHolidaysIsNull_){
        if(includeHolidaysIDRef_ != ""){
             return boost::shared_static_cast<CommodityBusinessCalendar>(IDManager::instance().getID(includeHolidaysIDRef_));
        }else{
             return this->includeHolidays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityBusinessCalendar>();
   }
}
}

