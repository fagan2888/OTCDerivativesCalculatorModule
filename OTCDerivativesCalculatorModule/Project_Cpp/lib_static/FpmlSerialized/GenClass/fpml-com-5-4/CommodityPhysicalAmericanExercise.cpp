// CommodityPhysicalAmericanExercise.cpp 
#include "CommodityPhysicalAmericanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityPhysicalAmericanExercise::CommodityPhysicalAmericanExercise(TiXmlNode* xmlNode)
: Exercise(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //commencementDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commencementDatesNode = xmlNode->FirstChildElement("commencementDates");

   if(commencementDatesNode){commencementDatesIsNull_ = false;}
   else{commencementDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commencementDatesNode , address : " << commencementDatesNode << std::endl;
   #endif
   if(commencementDatesNode)
   {
      if(commencementDatesNode->Attribute("href") || commencementDatesNode->Attribute("id"))
      {
          if(commencementDatesNode->Attribute("id"))
          {
             commencementDatesIDRef_ = commencementDatesNode->Attribute("id");
             commencementDates_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(commencementDatesNode));
             commencementDates_->setID(commencementDatesIDRef_);
             IDManager::instance().setID(commencementDatesIDRef_,commencementDates_);
          }
          else if(commencementDatesNode->Attribute("href")) { commencementDatesIDRef_ = commencementDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commencementDates_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(commencementDatesNode));}
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
             expirationDates_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(expirationDatesNode));
             expirationDates_->setID(expirationDatesIDRef_);
             IDManager::instance().setID(expirationDatesIDRef_,expirationDates_);
          }
          else if(expirationDatesNode->Attribute("href")) { expirationDatesIDRef_ = expirationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationDates_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(expirationDatesNode));}
   }

   //relativeCommencementDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeCommencementDatesNode = xmlNode->FirstChildElement("relativeCommencementDates");

   if(relativeCommencementDatesNode){relativeCommencementDatesIsNull_ = false;}
   else{relativeCommencementDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeCommencementDatesNode , address : " << relativeCommencementDatesNode << std::endl;
   #endif
   if(relativeCommencementDatesNode)
   {
      if(relativeCommencementDatesNode->Attribute("href") || relativeCommencementDatesNode->Attribute("id"))
      {
          if(relativeCommencementDatesNode->Attribute("id"))
          {
             relativeCommencementDatesIDRef_ = relativeCommencementDatesNode->Attribute("id");
             relativeCommencementDates_ = boost::shared_ptr<CommodityRelativeExpirationDates>(new CommodityRelativeExpirationDates(relativeCommencementDatesNode));
             relativeCommencementDates_->setID(relativeCommencementDatesIDRef_);
             IDManager::instance().setID(relativeCommencementDatesIDRef_,relativeCommencementDates_);
          }
          else if(relativeCommencementDatesNode->Attribute("href")) { relativeCommencementDatesIDRef_ = relativeCommencementDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeCommencementDates_ = boost::shared_ptr<CommodityRelativeExpirationDates>(new CommodityRelativeExpirationDates(relativeCommencementDatesNode));}
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

   //latestExerciseTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* latestExerciseTimeNode = xmlNode->FirstChildElement("latestExerciseTime");

   if(latestExerciseTimeNode){latestExerciseTimeIsNull_ = false;}
   else{latestExerciseTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- latestExerciseTimeNode , address : " << latestExerciseTimeNode << std::endl;
   #endif
   if(latestExerciseTimeNode)
   {
      if(latestExerciseTimeNode->Attribute("href") || latestExerciseTimeNode->Attribute("id"))
      {
          if(latestExerciseTimeNode->Attribute("id"))
          {
             latestExerciseTimeIDRef_ = latestExerciseTimeNode->Attribute("id");
             latestExerciseTime_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(latestExerciseTimeNode));
             latestExerciseTime_->setID(latestExerciseTimeIDRef_);
             IDManager::instance().setID(latestExerciseTimeIDRef_,latestExerciseTime_);
          }
          else if(latestExerciseTimeNode->Attribute("href")) { latestExerciseTimeIDRef_ = latestExerciseTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { latestExerciseTime_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(latestExerciseTimeNode));}
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
boost::shared_ptr<AdjustableOrRelativeDates> CommodityPhysicalAmericanExercise::getCommencementDates()
{
   if(!this->commencementDatesIsNull_){
        if(commencementDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDates>(IDManager::instance().getID(commencementDatesIDRef_));
        }else{
             return this->commencementDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDates>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDates> CommodityPhysicalAmericanExercise::getExpirationDates()
{
   if(!this->expirationDatesIsNull_){
        if(expirationDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDates>(IDManager::instance().getID(expirationDatesIDRef_));
        }else{
             return this->expirationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDates>();
   }
}
boost::shared_ptr<CommodityRelativeExpirationDates> CommodityPhysicalAmericanExercise::getRelativeCommencementDates()
{
   if(!this->relativeCommencementDatesIsNull_){
        if(relativeCommencementDatesIDRef_ != ""){
             return boost::shared_static_cast<CommodityRelativeExpirationDates>(IDManager::instance().getID(relativeCommencementDatesIDRef_));
        }else{
             return this->relativeCommencementDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityRelativeExpirationDates>();
   }
}
boost::shared_ptr<CommodityRelativeExpirationDates> CommodityPhysicalAmericanExercise::getRelativeExpirationDates()
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
boost::shared_ptr<PrevailingTime> CommodityPhysicalAmericanExercise::getLatestExerciseTime()
{
   if(!this->latestExerciseTimeIsNull_){
        if(latestExerciseTimeIDRef_ != ""){
             return boost::shared_static_cast<PrevailingTime>(IDManager::instance().getID(latestExerciseTimeIDRef_));
        }else{
             return this->latestExerciseTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrevailingTime>();
   }
}
boost::shared_ptr<PrevailingTime> CommodityPhysicalAmericanExercise::getExpirationTime()
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

