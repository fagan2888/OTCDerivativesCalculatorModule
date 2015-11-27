// EuropeanExercise.cpp 
#include "EuropeanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EuropeanExercise::EuropeanExercise(TiXmlNode* xmlNode)
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

   //partialExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partialExerciseNode = xmlNode->FirstChildElement("partialExercise");

   if(partialExerciseNode){partialExerciseIsNull_ = false;}
   else{partialExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partialExerciseNode , address : " << partialExerciseNode << std::endl;
   #endif
   if(partialExerciseNode)
   {
      if(partialExerciseNode->Attribute("href") || partialExerciseNode->Attribute("id"))
      {
          if(partialExerciseNode->Attribute("id"))
          {
             partialExerciseIDRef_ = partialExerciseNode->Attribute("id");
             partialExercise_ = boost::shared_ptr<PartialExercise>(new PartialExercise(partialExerciseNode));
             partialExercise_->setID(partialExerciseIDRef_);
             IDManager::instance().setID(partialExerciseIDRef_,partialExercise_);
          }
          else if(partialExerciseNode->Attribute("href")) { partialExerciseIDRef_ = partialExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partialExercise_ = boost::shared_ptr<PartialExercise>(new PartialExercise(partialExerciseNode));}
   }

   //exerciseFeeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseFeeNode = xmlNode->FirstChildElement("exerciseFee");

   if(exerciseFeeNode){exerciseFeeIsNull_ = false;}
   else{exerciseFeeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseFeeNode , address : " << exerciseFeeNode << std::endl;
   #endif
   if(exerciseFeeNode)
   {
      if(exerciseFeeNode->Attribute("href") || exerciseFeeNode->Attribute("id"))
      {
          if(exerciseFeeNode->Attribute("id"))
          {
             exerciseFeeIDRef_ = exerciseFeeNode->Attribute("id");
             exerciseFee_ = boost::shared_ptr<ExerciseFee>(new ExerciseFee(exerciseFeeNode));
             exerciseFee_->setID(exerciseFeeIDRef_);
             IDManager::instance().setID(exerciseFeeIDRef_,exerciseFee_);
          }
          else if(exerciseFeeNode->Attribute("href")) { exerciseFeeIDRef_ = exerciseFeeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseFee_ = boost::shared_ptr<ExerciseFee>(new ExerciseFee(exerciseFeeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> EuropeanExercise::getExpirationDate()
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
boost::shared_ptr<AdjustableOrRelativeDates> EuropeanExercise::getRelevantUnderlyingDate()
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
boost::shared_ptr<BusinessCenterTime> EuropeanExercise::getEarliestExerciseTime()
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
boost::shared_ptr<BusinessCenterTime> EuropeanExercise::getExpirationTime()
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
boost::shared_ptr<PartialExercise> EuropeanExercise::getPartialExercise()
{
   if(!this->partialExerciseIsNull_){
        if(partialExerciseIDRef_ != ""){
             return boost::shared_static_cast<PartialExercise>(IDManager::instance().getID(partialExerciseIDRef_));
        }else{
             return this->partialExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartialExercise>();
   }
}
boost::shared_ptr<ExerciseFee> EuropeanExercise::getExerciseFee()
{
   if(!this->exerciseFeeIsNull_){
        if(exerciseFeeIDRef_ != ""){
             return boost::shared_static_cast<ExerciseFee>(IDManager::instance().getID(exerciseFeeIDRef_));
        }else{
             return this->exerciseFee_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExerciseFee>();
   }
}
}

