// CommodityPhysicalEuropeanExercise.cpp 
#include "CommodityPhysicalEuropeanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityPhysicalEuropeanExercise::CommodityPhysicalEuropeanExercise(TiXmlNode* xmlNode)
: Exercise(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //expirationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationDateNode = xmlNode->FirstChildElement("expirationDate");

   if(expirationDateNode){expirationDateIsNull_ = false;}
   else{expirationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationDateNode , address : " << expirationDateNode << std::endl;
   #endif
   if(expirationDateNode)
   {
      if(expirationDateNode->Attribute("href") || expirationDateNode->Attribute("id"))
      {
          if(expirationDateNode->Attribute("id"))
          {
             expirationDateIDRef_ = expirationDateNode->Attribute("id");
             expirationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(expirationDateNode));
             expirationDate_->setID(expirationDateIDRef_);
             IDManager::instance().setID(expirationDateIDRef_,expirationDate_);
          }
          else if(expirationDateNode->Attribute("href")) { expirationDateIDRef_ = expirationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(expirationDateNode));}
   }

   //expirationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationDatesNode = xmlNode->FirstChildElement("expirationDates");

   if(expirationDatesNode){expirationDatesIsNull_ = false;}
   else{expirationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationDatesNode , address : " << expirationDatesNode << std::endl;
   #endif
   if(expirationDatesNode)
   {
      if(expirationDatesNode->Attribute("href") || expirationDatesNode->Attribute("id"))
      {
          if(expirationDatesNode->Attribute("id"))
          {
             expirationDatesIDRef_ = expirationDatesNode->Attribute("id");
             expirationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>(new AdjustableRelativeOrPeriodicDates2(expirationDatesNode));
             expirationDates_->setID(expirationDatesIDRef_);
             IDManager::instance().setID(expirationDatesIDRef_,expirationDates_);
          }
          else if(expirationDatesNode->Attribute("href")) { expirationDatesIDRef_ = expirationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>(new AdjustableRelativeOrPeriodicDates2(expirationDatesNode));}
   }

   //relativeExpirationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeExpirationDatesNode = xmlNode->FirstChildElement("relativeExpirationDates");

   if(relativeExpirationDatesNode){relativeExpirationDatesIsNull_ = false;}
   else{relativeExpirationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeExpirationDatesNode , address : " << relativeExpirationDatesNode << std::endl;
   #endif
   if(relativeExpirationDatesNode)
   {
      if(relativeExpirationDatesNode->Attribute("href") || relativeExpirationDatesNode->Attribute("id"))
      {
          if(relativeExpirationDatesNode->Attribute("id"))
          {
             relativeExpirationDatesIDRef_ = relativeExpirationDatesNode->Attribute("id");
             relativeExpirationDates_ = boost::shared_ptr<CommodityRelativeExpirationDates>(new CommodityRelativeExpirationDates(relativeExpirationDatesNode));
             relativeExpirationDates_->setID(relativeExpirationDatesIDRef_);
             IDManager::instance().setID(relativeExpirationDatesIDRef_,relativeExpirationDates_);
          }
          else if(relativeExpirationDatesNode->Attribute("href")) { relativeExpirationDatesIDRef_ = relativeExpirationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeExpirationDates_ = boost::shared_ptr<CommodityRelativeExpirationDates>(new CommodityRelativeExpirationDates(relativeExpirationDatesNode));}
   }

   //expirationTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationTimeNode = xmlNode->FirstChildElement("expirationTime");

   if(expirationTimeNode){expirationTimeIsNull_ = false;}
   else{expirationTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationTimeNode , address : " << expirationTimeNode << std::endl;
   #endif
   if(expirationTimeNode)
   {
      if(expirationTimeNode->Attribute("href") || expirationTimeNode->Attribute("id"))
      {
          if(expirationTimeNode->Attribute("id"))
          {
             expirationTimeIDRef_ = expirationTimeNode->Attribute("id");
             expirationTime_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(expirationTimeNode));
             expirationTime_->setID(expirationTimeIDRef_);
             IDManager::instance().setID(expirationTimeIDRef_,expirationTime_);
          }
          else if(expirationTimeNode->Attribute("href")) { expirationTimeIDRef_ = expirationTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationTime_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(expirationTimeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> CommodityPhysicalEuropeanExercise::getExpirationDate()
{
   if(!this->expirationDateIsNull_){
        if(expirationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(expirationDateIDRef_));
        }else{
             return this->expirationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> CommodityPhysicalEuropeanExercise::getExpirationDates()
{
   if(!this->expirationDatesIsNull_){
        if(expirationDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableRelativeOrPeriodicDates2>(IDManager::instance().getID(expirationDatesIDRef_));
        }else{
             return this->expirationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>();
   }
}
boost::shared_ptr<CommodityRelativeExpirationDates> CommodityPhysicalEuropeanExercise::getRelativeExpirationDates()
{
   if(!this->relativeExpirationDatesIsNull_){
        if(relativeExpirationDatesIDRef_ != ""){
             return boost::shared_static_cast<CommodityRelativeExpirationDates>(IDManager::instance().getID(relativeExpirationDatesIDRef_));
        }else{
             return this->relativeExpirationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityRelativeExpirationDates>();
   }
}
boost::shared_ptr<PrevailingTime> CommodityPhysicalEuropeanExercise::getExpirationTime()
{
   if(!this->expirationTimeIsNull_){
        if(expirationTimeIDRef_ != ""){
             return boost::shared_static_cast<PrevailingTime>(IDManager::instance().getID(expirationTimeIDRef_));
        }else{
             return this->expirationTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrevailingTime>();
   }
}
}

