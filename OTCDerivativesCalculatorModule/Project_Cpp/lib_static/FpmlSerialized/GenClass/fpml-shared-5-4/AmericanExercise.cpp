// AmericanExercise.cpp 
#include "AmericanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AmericanExercise::AmericanExercise(TiXmlNode* xmlNode)
: Exercise(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //commencementDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commencementDateNode = xmlNode->FirstChildElement("commencementDate");

   if(commencementDateNode){commencementDateIsNull_ = false;}
   else{commencementDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commencementDateNode , address : " << commencementDateNode << std::endl;
   #endif
   if(commencementDateNode)
   {
      if(commencementDateNode->Attribute("href") || commencementDateNode->Attribute("id"))
      {
          if(commencementDateNode->Attribute("id"))
          {
             commencementDateIDRef_ = commencementDateNode->Attribute("id");
             commencementDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(commencementDateNode));
             commencementDate_->setID(commencementDateIDRef_);
             IDManager::instance().setID(commencementDateIDRef_,commencementDate_);
          }
          else if(commencementDateNode->Attribute("href")) { commencementDateIDRef_ = commencementDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commencementDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(commencementDateNode));}
   }

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
boost::shared_ptr<AdjustableOrRelativeDate> AmericanExercise::getCommencementDate()
{
   if(!this->commencementDateIsNull_){
        if(commencementDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(commencementDateIDRef_));
        }else{
             return this->commencementDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> AmericanExercise::getExpirationDate()
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
boost::shared_ptr<AdjustableOrRelativeDates> AmericanExercise::getRelevantUnderlyingDate()
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
boost::shared_ptr<BusinessCenterTime> AmericanExercise::getEarliestExerciseTime()
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
boost::shared_ptr<BusinessCenterTime> AmericanExercise::getLatestExerciseTime()
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
boost::shared_ptr<BusinessCenterTime> AmericanExercise::getExpirationTime()
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
boost::shared_ptr<MultipleExercise> AmericanExercise::getMultipleExercise()
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
boost::shared_ptr<ExerciseFeeSchedule> AmericanExercise::getExerciseFeeSchedule()
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

