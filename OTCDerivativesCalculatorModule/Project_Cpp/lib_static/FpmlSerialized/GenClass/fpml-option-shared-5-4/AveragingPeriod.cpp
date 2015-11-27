// AveragingPeriod.cpp 
#include "AveragingPeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AveragingPeriod::AveragingPeriod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //scheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* scheduleNode = xmlNode->FirstChildElement("schedule");

   if(scheduleNode){scheduleIsNull_ = false;}
   else{scheduleIsNull_ = true;}

   if(scheduleNode)
   {
      for(scheduleNode; scheduleNode; scheduleNode = scheduleNode->NextSiblingElement("schedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduleNode , address : " << scheduleNode << std::endl;
          #endif
          if(scheduleNode->Attribute("href") || scheduleNode->Attribute("id"))
          {
              if(scheduleNode->Attribute("id"))
              {
                  scheduleIDRef_ = scheduleNode->Attribute("id");
                  schedule_.push_back(boost::shared_ptr<AveragingSchedule>(new AveragingSchedule(scheduleNode)));
                  schedule_.back()->setID(scheduleIDRef_);
                  IDManager::instance().setID(scheduleIDRef_, schedule_.back());
              }
              else if(scheduleNode->Attribute("href")) { scheduleIDRef_ = scheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { schedule_.push_back(boost::shared_ptr<AveragingSchedule>(new AveragingSchedule(scheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduleNode , address : " << scheduleNode << std::endl;
       #endif
   }

   //averagingDateTimesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingDateTimesNode = xmlNode->FirstChildElement("averagingDateTimes");

   if(averagingDateTimesNode){averagingDateTimesIsNull_ = false;}
   else{averagingDateTimesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingDateTimesNode , address : " << averagingDateTimesNode << std::endl;
   #endif
   if(averagingDateTimesNode)
   {
      if(averagingDateTimesNode->Attribute("href") || averagingDateTimesNode->Attribute("id"))
      {
          if(averagingDateTimesNode->Attribute("id"))
          {
             averagingDateTimesIDRef_ = averagingDateTimesNode->Attribute("id");
             averagingDateTimes_ = boost::shared_ptr<DateTimeList>(new DateTimeList(averagingDateTimesNode));
             averagingDateTimes_->setID(averagingDateTimesIDRef_);
             IDManager::instance().setID(averagingDateTimesIDRef_,averagingDateTimes_);
          }
          else if(averagingDateTimesNode->Attribute("href")) { averagingDateTimesIDRef_ = averagingDateTimesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingDateTimes_ = boost::shared_ptr<DateTimeList>(new DateTimeList(averagingDateTimesNode));}
   }

   //averagingObservationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingObservationsNode = xmlNode->FirstChildElement("averagingObservations");

   if(averagingObservationsNode){averagingObservationsIsNull_ = false;}
   else{averagingObservationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingObservationsNode , address : " << averagingObservationsNode << std::endl;
   #endif
   if(averagingObservationsNode)
   {
      if(averagingObservationsNode->Attribute("href") || averagingObservationsNode->Attribute("id"))
      {
          if(averagingObservationsNode->Attribute("id"))
          {
             averagingObservationsIDRef_ = averagingObservationsNode->Attribute("id");
             averagingObservations_ = boost::shared_ptr<AveragingObservationList>(new AveragingObservationList(averagingObservationsNode));
             averagingObservations_->setID(averagingObservationsIDRef_);
             IDManager::instance().setID(averagingObservationsIDRef_,averagingObservations_);
          }
          else if(averagingObservationsNode->Attribute("href")) { averagingObservationsIDRef_ = averagingObservationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingObservations_ = boost::shared_ptr<AveragingObservationList>(new AveragingObservationList(averagingObservationsNode));}
   }

   //marketDisruptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* marketDisruptionNode = xmlNode->FirstChildElement("marketDisruption");

   if(marketDisruptionNode){marketDisruptionIsNull_ = false;}
   else{marketDisruptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketDisruptionNode , address : " << marketDisruptionNode << std::endl;
   #endif
   if(marketDisruptionNode)
   {
      if(marketDisruptionNode->Attribute("href") || marketDisruptionNode->Attribute("id"))
      {
          if(marketDisruptionNode->Attribute("id"))
          {
             marketDisruptionIDRef_ = marketDisruptionNode->Attribute("id");
             marketDisruption_ = boost::shared_ptr<MarketDisruption>(new MarketDisruption(marketDisruptionNode));
             marketDisruption_->setID(marketDisruptionIDRef_);
             IDManager::instance().setID(marketDisruptionIDRef_,marketDisruption_);
          }
          else if(marketDisruptionNode->Attribute("href")) { marketDisruptionIDRef_ = marketDisruptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { marketDisruption_ = boost::shared_ptr<MarketDisruption>(new MarketDisruption(marketDisruptionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<AveragingSchedule>> AveragingPeriod::getSchedule()
{
   if(!this->scheduleIsNull_){
        if(scheduleIDRef_ != ""){
             return this->schedule_;
        }else{
             return this->schedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AveragingSchedule>>();
   }
}
boost::shared_ptr<DateTimeList> AveragingPeriod::getAveragingDateTimes()
{
   if(!this->averagingDateTimesIsNull_){
        if(averagingDateTimesIDRef_ != ""){
             return boost::shared_static_cast<DateTimeList>(IDManager::instance().getID(averagingDateTimesIDRef_));
        }else{
             return this->averagingDateTimes_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateTimeList>();
   }
}
boost::shared_ptr<AveragingObservationList> AveragingPeriod::getAveragingObservations()
{
   if(!this->averagingObservationsIsNull_){
        if(averagingObservationsIDRef_ != ""){
             return boost::shared_static_cast<AveragingObservationList>(IDManager::instance().getID(averagingObservationsIDRef_));
        }else{
             return this->averagingObservations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AveragingObservationList>();
   }
}
boost::shared_ptr<MarketDisruption> AveragingPeriod::getMarketDisruption()
{
   if(!this->marketDisruptionIsNull_){
        if(marketDisruptionIDRef_ != ""){
             return boost::shared_static_cast<MarketDisruption>(IDManager::instance().getID(marketDisruptionIDRef_));
        }else{
             return this->marketDisruption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MarketDisruption>();
   }
}
}

