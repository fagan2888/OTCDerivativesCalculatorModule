// PrevailingTime.cpp 
#include "PrevailingTime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PrevailingTime::PrevailingTime(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //hourMinuteTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hourMinuteTimeNode = xmlNode->FirstChildElement("hourMinuteTime");

   if(hourMinuteTimeNode){hourMinuteTimeIsNull_ = false;}
   else{hourMinuteTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hourMinuteTimeNode , address : " << hourMinuteTimeNode << std::endl;
   #endif
   if(hourMinuteTimeNode)
   {
      if(hourMinuteTimeNode->Attribute("href") || hourMinuteTimeNode->Attribute("id"))
      {
          if(hourMinuteTimeNode->Attribute("id"))
          {
             hourMinuteTimeIDRef_ = hourMinuteTimeNode->Attribute("id");
             hourMinuteTime_ = boost::shared_ptr<HourMinuteTime>(new HourMinuteTime(hourMinuteTimeNode));
             hourMinuteTime_->setID(hourMinuteTimeIDRef_);
             IDManager::instance().setID(hourMinuteTimeIDRef_,hourMinuteTime_);
          }
          else if(hourMinuteTimeNode->Attribute("href")) { hourMinuteTimeIDRef_ = hourMinuteTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { hourMinuteTime_ = boost::shared_ptr<HourMinuteTime>(new HourMinuteTime(hourMinuteTimeNode));}
   }

   //locationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* locationNode = xmlNode->FirstChildElement("location");

   if(locationNode){locationIsNull_ = false;}
   else{locationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- locationNode , address : " << locationNode << std::endl;
   #endif
   if(locationNode)
   {
      if(locationNode->Attribute("href") || locationNode->Attribute("id"))
      {
          if(locationNode->Attribute("id"))
          {
             locationIDRef_ = locationNode->Attribute("id");
             location_ = boost::shared_ptr<TimezoneLocation>(new TimezoneLocation(locationNode));
             location_->setID(locationIDRef_);
             IDManager::instance().setID(locationIDRef_,location_);
          }
          else if(locationNode->Attribute("href")) { locationIDRef_ = locationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { location_ = boost::shared_ptr<TimezoneLocation>(new TimezoneLocation(locationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<HourMinuteTime> PrevailingTime::getHourMinuteTime()
{
   if(!this->hourMinuteTimeIsNull_){
        if(hourMinuteTimeIDRef_ != ""){
             return boost::shared_static_cast<HourMinuteTime>(IDManager::instance().getID(hourMinuteTimeIDRef_));
        }else{
             return this->hourMinuteTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<HourMinuteTime>();
   }
}
boost::shared_ptr<TimezoneLocation> PrevailingTime::getLocation()
{
   if(!this->locationIsNull_){
        if(locationIDRef_ != ""){
             return boost::shared_static_cast<TimezoneLocation>(IDManager::instance().getID(locationIDRef_));
        }else{
             return this->location_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimezoneLocation>();
   }
}
}

