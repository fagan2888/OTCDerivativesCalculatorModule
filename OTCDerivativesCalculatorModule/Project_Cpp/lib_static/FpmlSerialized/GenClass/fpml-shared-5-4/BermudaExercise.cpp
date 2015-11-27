// BermudaExercise.cpp 
#include "BermudaExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BermudaExercise::BermudaExercise(TiXmlNode* xmlNode)
: Exercise(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //bermudaExerciseDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bermudaExerciseDatesNode = xmlNode->FirstChildElement("bermudaExerciseDates");

   if(bermudaExerciseDatesNode){bermudaExerciseDatesIsNull_ = false;}
   else{bermudaExerciseDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bermudaExerciseDatesNode , address : " << bermudaExerciseDatesNode << std::endl;
   #endif
   if(bermudaExerciseDatesNode)
   {
      if(bermudaExerciseDatesNode->Attribute("href") || bermudaExerciseDatesNode->Attribute("id"))
      {
          if(bermudaExerciseDatesNode->Attribute("id"))
          {
             bermudaExerciseDatesIDRef_ = bermudaExerciseDatesNode->Attribute("id");
             bermudaExerciseDates_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(bermudaExerciseDatesNode));
             bermudaExerciseDates_->setID(bermudaExerciseDatesIDRef_);
             IDManager::instance().setID(bermudaExerciseDatesIDRef_,bermudaExerciseDates_);
          }
          else if(bermudaExerciseDatesNode->Attribute("href")) { bermudaExerciseDatesIDRef_ = bermudaExerciseDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bermudaExerciseDates_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(bermudaExerciseDatesNode));}
   }

   //relevantUnderlyingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relevantUnderlyingDateNode = xmlNode->FirstChildElement("relevantUnderlyingDate");

   if(relevantUnderlyingDateNode){relevantUnderlyingDateIsNull_ = false;}
   else{relevantUnderlyingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relevantUnderlyingDateNode , address : " << relevantUnderlyingDateNode << std::endl;
   #endif
   if(relevantUnderlyingDateNode)
   {
      if(relevantUnderlyingDateNode->Attribute("href") || relevantUnderlyingDateNode->Attribute("id"))
      {
          if(relevantUnderlyingDateNode->Attribute("id"))
          {
             relevantUnderlyingDateIDRef_ = relevantUnderlyingDateNode->Attribute("id");
             relevantUnderlyingDate_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(relevantUnderlyingDateNode));
             relevantUnderlyingDate_->setID(relevantUnderlyingDateIDRef_);
             IDManager::instance().setID(relevantUnderlyingDateIDRef_,relevantUnderlyingDate_);
          }
          else if(relevantUnderlyingDateNode->Attribute("href")) { relevantUnderlyingDateIDRef_ = relevantUnderlyingDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relevantUnderlyingDate_ = boost::shared_ptr<AdjustableOrRelativeDates>(new AdjustableOrRelativeDates(relevantUnderlyingDateNode));}
   }

   //earliestExerciseTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* earliestExerciseTimeNode = xmlNode->FirstChildElement("earliestExerciseTime");

   if(earliestExerciseTimeNode){earliestExerciseTimeIsNull_ = false;}
   else{earliestExerciseTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- earliestExerciseTimeNode , address : " << earliestExerciseTimeNode << std::endl;
   #endif
   if(earliestExerciseTimeNode)
   {
      if(earliestExerciseTimeNode->Attribute("href") || earliestExerciseTimeNode->Attribute("id"))
      {
          if(earliestExerciseTimeNode->Attribute("id"))
          {
             earliestExerciseTimeIDRef_ = earliestExerciseTimeNode->Attribute("id");
             earliestExerciseTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(earliestExerciseTimeNode));
             earliestExerciseTime_->setID(earliestExerciseTimeIDRef_);
             IDManager::instance().setID(earliestExerciseTimeIDRef_,earliestExerciseTime_);
          }
          else if(earliestExerciseTimeNode->Attribute("href")) { earliestExerciseTimeIDRef_ = earliestExerciseTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { earliestExerciseTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(earliestExerciseTimeNode));}
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
             latestExerciseTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(latestExerciseTimeNode));
             latestExerciseTime_->setID(latestExerciseTimeIDRef_);
             IDManager::instance().setID(latestExerciseTimeIDRef_,latestExerciseTime_);
          }
          else if(latestExerciseTimeNode->Attribute("href")) { latestExerciseTimeIDRef_ = latestExerciseTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { latestExerciseTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(latestExerciseTimeNode));}
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
             expirationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(expirationTimeNode));
             expirationTime_->setID(expirationTimeIDRef_);
             IDManager::instance().setID(expirationTimeIDRef_,expirationTime_);
          }
          else if(expirationTimeNode->Attribute("href")) { expirationTimeIDRef_ = expirationTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(expirationTimeNode));}
   }

   //multipleExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleExerciseNode = xmlNode->FirstChildElement("multipleExercise");

   if(multipleExerciseNode){multipleExerciseIsNull_ = false;}
   else{multipleExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleExerciseNode , address : " << multipleExerciseNode << std::endl;
   #endif
   if(multipleExerciseNode)
   {
      if(multipleExerciseNode->Attribute("href") || multipleExerciseNode->Attribute("id"))
      {
          if(multipleExerciseNode->Attribute("id"))
          {
             multipleExerciseIDRef_ = multipleExerciseNode->Attribute("id");
             multipleExercise_ = boost::shared_ptr<MultipleExercise>(new MultipleExercise(multipleExerciseNode));
             multipleExercise_->setID(multipleExerciseIDRef_);
             IDManager::instance().setID(multipleExerciseIDRef_,multipleExercise_);
          }
          else if(multipleExerciseNode->Attribute("href")) { multipleExerciseIDRef_ = multipleExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleExercise_ = boost::shared_ptr<MultipleExercise>(new MultipleExercise(multipleExerciseNode));}
   }

   //exerciseFeeScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseFeeScheduleNode = xmlNode->FirstChildElement("exerciseFeeSchedule");

   if(exerciseFeeScheduleNode){exerciseFeeScheduleIsNull_ = false;}
   else{exerciseFeeScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseFeeScheduleNode , address : " << exerciseFeeScheduleNode << std::endl;
   #endif
   if(exerciseFeeScheduleNode)
   {
      if(exerciseFeeScheduleNode->Attribute("href") || exerciseFeeScheduleNode->Attribute("id"))
      {
          if(exerciseFeeScheduleNode->Attribute("id"))
          {
             exerciseFeeScheduleIDRef_ = exerciseFeeScheduleNode->Attribute("id");
             exerciseFeeSchedule_ = boost::shared_ptr<ExerciseFeeSchedule>(new ExerciseFeeSchedule(exerciseFeeScheduleNode));
             exerciseFeeSchedule_->setID(exerciseFeeScheduleIDRef_);
             IDManager::instance().setID(exerciseFeeScheduleIDRef_,exerciseFeeSchedule_);
          }
          else if(exerciseFeeScheduleNode->Attribute("href")) { exerciseFeeScheduleIDRef_ = exerciseFeeScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseFeeSchedule_ = boost::shared_ptr<ExerciseFeeSchedule>(new ExerciseFeeSchedule(exerciseFeeScheduleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDates> BermudaExercise::getBermudaExerciseDates()
{
   if(!this->bermudaExerciseDatesIsNull_){
        if(bermudaExerciseDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDates>(IDManager::instance().getID(bermudaExerciseDatesIDRef_));
        }else{
             return this->bermudaExerciseDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDates>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDates> BermudaExercise::getRelevantUnderlyingDate()
{
   if(!this->relevantUnderlyingDateIsNull_){
        if(relevantUnderlyingDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDates>(IDManager::instance().getID(relevantUnderlyingDateIDRef_));
        }else{
             return this->relevantUnderlyingDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDates>();
   }
}
boost::shared_ptr<BusinessCenterTime> BermudaExercise::getEarliestExerciseTime()
{
   if(!this->earliestExerciseTimeIsNull_){
        if(earliestExerciseTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(earliestExerciseTimeIDRef_));
        }else{
             return this->earliestExerciseTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<BusinessCenterTime> BermudaExercise::getLatestExerciseTime()
{
   if(!this->latestExerciseTimeIsNull_){
        if(latestExerciseTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(latestExerciseTimeIDRef_));
        }else{
             return this->latestExerciseTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<BusinessCenterTime> BermudaExercise::getExpirationTime()
{
   if(!this->expirationTimeIsNull_){
        if(expirationTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(expirationTimeIDRef_));
        }else{
             return this->expirationTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<MultipleExercise> BermudaExercise::getMultipleExercise()
{
   if(!this->multipleExerciseIsNull_){
        if(multipleExerciseIDRef_ != ""){
             return boost::shared_static_cast<MultipleExercise>(IDManager::instance().getID(multipleExerciseIDRef_));
        }else{
             return this->multipleExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MultipleExercise>();
   }
}
boost::shared_ptr<ExerciseFeeSchedule> BermudaExercise::getExerciseFeeSchedule()
{
   if(!this->exerciseFeeScheduleIsNull_){
        if(exerciseFeeScheduleIDRef_ != ""){
             return boost::shared_static_cast<ExerciseFeeSchedule>(IDManager::instance().getID(exerciseFeeScheduleIDRef_));
        }else{
             return this->exerciseFeeSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExerciseFeeSchedule>();
   }
}
}

