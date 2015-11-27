// SharedAmericanExercise.cpp 
#include "SharedAmericanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SharedAmericanExercise::SharedAmericanExercise(TiXmlNode* xmlNode)
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

   //latestExerciseTimeDeterminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* latestExerciseTimeDeterminationNode = xmlNode->FirstChildElement("latestExerciseTimeDetermination");

   if(latestExerciseTimeDeterminationNode){latestExerciseTimeDeterminationIsNull_ = false;}
   else{latestExerciseTimeDeterminationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- latestExerciseTimeDeterminationNode , address : " << latestExerciseTimeDeterminationNode << std::endl;
   #endif
   if(latestExerciseTimeDeterminationNode)
   {
      if(latestExerciseTimeDeterminationNode->Attribute("href") || latestExerciseTimeDeterminationNode->Attribute("id"))
      {
          if(latestExerciseTimeDeterminationNode->Attribute("id"))
          {
             latestExerciseTimeDeterminationIDRef_ = latestExerciseTimeDeterminationNode->Attribute("id");
             latestExerciseTimeDetermination_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(latestExerciseTimeDeterminationNode));
             latestExerciseTimeDetermination_->setID(latestExerciseTimeDeterminationIDRef_);
             IDManager::instance().setID(latestExerciseTimeDeterminationIDRef_,latestExerciseTimeDetermination_);
          }
          else if(latestExerciseTimeDeterminationNode->Attribute("href")) { latestExerciseTimeDeterminationIDRef_ = latestExerciseTimeDeterminationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { latestExerciseTimeDetermination_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(latestExerciseTimeDeterminationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> SharedAmericanExercise::getCommencementDate()
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
boost::shared_ptr<AdjustableOrRelativeDate> SharedAmericanExercise::getExpirationDate()
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
boost::shared_ptr<BusinessCenterTime> SharedAmericanExercise::getLatestExerciseTime()
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
boost::shared_ptr<DeterminationMethod> SharedAmericanExercise::getLatestExerciseTimeDetermination()
{
   if(!this->latestExerciseTimeDeterminationIsNull_){
        if(latestExerciseTimeDeterminationIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethod>(IDManager::instance().getID(latestExerciseTimeDeterminationIDRef_));
        }else{
             return this->latestExerciseTimeDetermination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethod>();
   }
}
}

