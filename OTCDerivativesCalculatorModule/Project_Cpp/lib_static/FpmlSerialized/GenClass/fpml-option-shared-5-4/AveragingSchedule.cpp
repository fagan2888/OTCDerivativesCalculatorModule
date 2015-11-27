// AveragingSchedule.cpp 
#include "AveragingSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AveragingSchedule::AveragingSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //startDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* startDateNode = xmlNode->FirstChildElement("startDate");

   if(startDateNode){startDateIsNull_ = false;}
   else{startDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- startDateNode , address : " << startDateNode << std::endl;
   #endif
   if(startDateNode)
   {
      if(startDateNode->Attribute("href") || startDateNode->Attribute("id"))
      {
          if(startDateNode->Attribute("id"))
          {
             startDateIDRef_ = startDateNode->Attribute("id");
             startDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(startDateNode));
             startDate_->setID(startDateIDRef_);
             IDManager::instance().setID(startDateIDRef_,startDate_);
          }
          else if(startDateNode->Attribute("href")) { startDateIDRef_ = startDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { startDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(startDateNode));}
   }

   //endDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* endDateNode = xmlNode->FirstChildElement("endDate");

   if(endDateNode){endDateIsNull_ = false;}
   else{endDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- endDateNode , address : " << endDateNode << std::endl;
   #endif
   if(endDateNode)
   {
      if(endDateNode->Attribute("href") || endDateNode->Attribute("id"))
      {
          if(endDateNode->Attribute("id"))
          {
             endDateIDRef_ = endDateNode->Attribute("id");
             endDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(endDateNode));
             endDate_->setID(endDateIDRef_);
             IDManager::instance().setID(endDateIDRef_,endDate_);
          }
          else if(endDateNode->Attribute("href")) { endDateIDRef_ = endDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { endDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(endDateNode));}
   }

   //averagingPeriodFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingPeriodFrequencyNode = xmlNode->FirstChildElement("averagingPeriodFrequency");

   if(averagingPeriodFrequencyNode){averagingPeriodFrequencyIsNull_ = false;}
   else{averagingPeriodFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingPeriodFrequencyNode , address : " << averagingPeriodFrequencyNode << std::endl;
   #endif
   if(averagingPeriodFrequencyNode)
   {
      if(averagingPeriodFrequencyNode->Attribute("href") || averagingPeriodFrequencyNode->Attribute("id"))
      {
          if(averagingPeriodFrequencyNode->Attribute("id"))
          {
             averagingPeriodFrequencyIDRef_ = averagingPeriodFrequencyNode->Attribute("id");
             averagingPeriodFrequency_ = boost::shared_ptr<CalculationPeriodFrequency>(new CalculationPeriodFrequency(averagingPeriodFrequencyNode));
             averagingPeriodFrequency_->setID(averagingPeriodFrequencyIDRef_);
             IDManager::instance().setID(averagingPeriodFrequencyIDRef_,averagingPeriodFrequency_);
          }
          else if(averagingPeriodFrequencyNode->Attribute("href")) { averagingPeriodFrequencyIDRef_ = averagingPeriodFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingPeriodFrequency_ = boost::shared_ptr<CalculationPeriodFrequency>(new CalculationPeriodFrequency(averagingPeriodFrequencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> AveragingSchedule::getStartDate()
{
   if(!this->startDateIsNull_){
        if(startDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(startDateIDRef_));
        }else{
             return this->startDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> AveragingSchedule::getEndDate()
{
   if(!this->endDateIsNull_){
        if(endDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(endDateIDRef_));
        }else{
             return this->endDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<CalculationPeriodFrequency> AveragingSchedule::getAveragingPeriodFrequency()
{
   if(!this->averagingPeriodFrequencyIsNull_){
        if(averagingPeriodFrequencyIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodFrequency>(IDManager::instance().getID(averagingPeriodFrequencyIDRef_));
        }else{
             return this->averagingPeriodFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodFrequency>();
   }
}
}

