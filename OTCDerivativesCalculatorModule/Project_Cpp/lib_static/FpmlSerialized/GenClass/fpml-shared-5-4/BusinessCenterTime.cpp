// BusinessCenterTime.cpp 
#include "BusinessCenterTime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BusinessCenterTime::BusinessCenterTime(TiXmlNode* xmlNode)
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

   //businessCenterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCenterNode = xmlNode->FirstChildElement("businessCenter");

   if(businessCenterNode){businessCenterIsNull_ = false;}
   else{businessCenterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCenterNode , address : " << businessCenterNode << std::endl;
   #endif
   if(businessCenterNode)
   {
      if(businessCenterNode->Attribute("href") || businessCenterNode->Attribute("id"))
      {
          if(businessCenterNode->Attribute("id"))
          {
             businessCenterIDRef_ = businessCenterNode->Attribute("id");
             businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));
             businessCenter_->setID(businessCenterIDRef_);
             IDManager::instance().setID(businessCenterIDRef_,businessCenter_);
          }
          else if(businessCenterNode->Attribute("href")) { businessCenterIDRef_ = businessCenterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<HourMinuteTime> BusinessCenterTime::getHourMinuteTime()
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
boost::shared_ptr<BusinessCenter> BusinessCenterTime::getBusinessCenter()
{
   if(!this->businessCenterIsNull_){
        if(businessCenterIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenter>(IDManager::instance().getID(businessCenterIDRef_));
        }else{
             return this->businessCenter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenter>();
   }
}
}

