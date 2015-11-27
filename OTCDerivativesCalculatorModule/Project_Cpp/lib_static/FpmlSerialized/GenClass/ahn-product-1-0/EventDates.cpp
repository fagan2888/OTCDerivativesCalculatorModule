// EventDates.cpp 
#include "EventDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventDates::EventDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateListNode = xmlNode->FirstChildElement("dateList");

   if(dateListNode){dateListIsNull_ = false;}
   else{dateListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateListNode , address : " << dateListNode << std::endl;
   #endif
   if(dateListNode)
   {
      if(dateListNode->Attribute("href") || dateListNode->Attribute("id"))
      {
          if(dateListNode->Attribute("id"))
          {
             dateListIDRef_ = dateListNode->Attribute("id");
             dateList_ = boost::shared_ptr<DatesList>(new DatesList(dateListNode));
             dateList_->setID(dateListIDRef_);
             IDManager::instance().setID(dateListIDRef_,dateList_);
          }
          else if(dateListNode->Attribute("href")) { dateListIDRef_ = dateListNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateList_ = boost::shared_ptr<DatesList>(new DatesList(dateListNode));}
   }

   //dateIntervalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateIntervalNode = xmlNode->FirstChildElement("dateInterval");

   if(dateIntervalNode){dateIntervalIsNull_ = false;}
   else{dateIntervalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateIntervalNode , address : " << dateIntervalNode << std::endl;
   #endif
   if(dateIntervalNode)
   {
      if(dateIntervalNode->Attribute("href") || dateIntervalNode->Attribute("id"))
      {
          if(dateIntervalNode->Attribute("id"))
          {
             dateIntervalIDRef_ = dateIntervalNode->Attribute("id");
             dateInterval_ = boost::shared_ptr<DateInterval>(new DateInterval(dateIntervalNode));
             dateInterval_->setID(dateIntervalIDRef_);
             IDManager::instance().setID(dateIntervalIDRef_,dateInterval_);
          }
          else if(dateIntervalNode->Attribute("href")) { dateIntervalIDRef_ = dateIntervalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateInterval_ = boost::shared_ptr<DateInterval>(new DateInterval(dateIntervalNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DatesList> EventDates::getDateList()
{
   if(!this->dateListIsNull_){
        if(dateListIDRef_ != ""){
             return boost::shared_static_cast<DatesList>(IDManager::instance().getID(dateListIDRef_));
        }else{
             return this->dateList_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DatesList>();
   }
}
boost::shared_ptr<DateInterval> EventDates::getDateInterval()
{
   if(!this->dateIntervalIsNull_){
        if(dateIntervalIDRef_ != ""){
             return boost::shared_static_cast<DateInterval>(IDManager::instance().getID(dateIntervalIDRef_));
        }else{
             return this->dateInterval_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateInterval>();
   }
}
}

