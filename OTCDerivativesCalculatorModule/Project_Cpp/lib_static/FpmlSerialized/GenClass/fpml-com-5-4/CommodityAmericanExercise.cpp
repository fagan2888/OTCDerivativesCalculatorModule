// CommodityAmericanExercise.cpp 
#include "CommodityAmericanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityAmericanExercise::CommodityAmericanExercise(TiXmlNode* xmlNode)
: Exercise(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //exercisePeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exercisePeriodNode = xmlNode->FirstChildElement("exercisePeriod");

   if(exercisePeriodNode){exercisePeriodIsNull_ = false;}
   else{exercisePeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exercisePeriodNode , address : " << exercisePeriodNode << std::endl;
   #endif
   if(exercisePeriodNode)
   {
      if(exercisePeriodNode->Attribute("href") || exercisePeriodNode->Attribute("id"))
      {
          if(exercisePeriodNode->Attribute("id"))
          {
             exercisePeriodIDRef_ = exercisePeriodNode->Attribute("id");
             exercisePeriod_ = boost::shared_ptr<CommodityExercisePeriods>(new CommodityExercisePeriods(exercisePeriodNode));
             exercisePeriod_->setID(exercisePeriodIDRef_);
             IDManager::instance().setID(exercisePeriodIDRef_,exercisePeriod_);
          }
          else if(exercisePeriodNode->Attribute("href")) { exercisePeriodIDRef_ = exercisePeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exercisePeriod_ = boost::shared_ptr<CommodityExercisePeriods>(new CommodityExercisePeriods(exercisePeriodNode));}
   }

   //exerciseFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseFrequencyNode = xmlNode->FirstChildElement("exerciseFrequency");

   if(exerciseFrequencyNode){exerciseFrequencyIsNull_ = false;}
   else{exerciseFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseFrequencyNode , address : " << exerciseFrequencyNode << std::endl;
   #endif
   if(exerciseFrequencyNode)
   {
      if(exerciseFrequencyNode->Attribute("href") || exerciseFrequencyNode->Attribute("id"))
      {
          if(exerciseFrequencyNode->Attribute("id"))
          {
             exerciseFrequencyIDRef_ = exerciseFrequencyNode->Attribute("id");
             exerciseFrequency_ = boost::shared_ptr<Frequency>(new Frequency(exerciseFrequencyNode));
             exerciseFrequency_->setID(exerciseFrequencyIDRef_);
             IDManager::instance().setID(exerciseFrequencyIDRef_,exerciseFrequency_);
          }
          else if(exerciseFrequencyNode->Attribute("href")) { exerciseFrequencyIDRef_ = exerciseFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseFrequency_ = boost::shared_ptr<Frequency>(new Frequency(exerciseFrequencyNode));}
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
             multipleExercise_ = boost::shared_ptr<CommodityMultipleExercise>(new CommodityMultipleExercise(multipleExerciseNode));
             multipleExercise_->setID(multipleExerciseIDRef_);
             IDManager::instance().setID(multipleExerciseIDRef_,multipleExercise_);
          }
          else if(multipleExerciseNode->Attribute("href")) { multipleExerciseIDRef_ = multipleExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleExercise_ = boost::shared_ptr<CommodityMultipleExercise>(new CommodityMultipleExercise(multipleExerciseNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityExercisePeriods> CommodityAmericanExercise::getExercisePeriod()
{
   if(!this->exercisePeriodIsNull_){
        if(exercisePeriodIDRef_ != ""){
             return boost::shared_static_cast<CommodityExercisePeriods>(IDManager::instance().getID(exercisePeriodIDRef_));
        }else{
             return this->exercisePeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityExercisePeriods>();
   }
}
boost::shared_ptr<Frequency> CommodityAmericanExercise::getExerciseFrequency()
{
   if(!this->exerciseFrequencyIsNull_){
        if(exerciseFrequencyIDRef_ != ""){
             return boost::shared_static_cast<Frequency>(IDManager::instance().getID(exerciseFrequencyIDRef_));
        }else{
             return this->exerciseFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Frequency>();
   }
}
boost::shared_ptr<BusinessCenterTime> CommodityAmericanExercise::getLatestExerciseTime()
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
boost::shared_ptr<DeterminationMethod> CommodityAmericanExercise::getLatestExerciseTimeDetermination()
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
boost::shared_ptr<BusinessCenterTime> CommodityAmericanExercise::getExpirationTime()
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
boost::shared_ptr<CommodityMultipleExercise> CommodityAmericanExercise::getMultipleExercise()
{
   if(!this->multipleExerciseIsNull_){
        if(multipleExerciseIDRef_ != ""){
             return boost::shared_static_cast<CommodityMultipleExercise>(IDManager::instance().getID(multipleExerciseIDRef_));
        }else{
             return this->multipleExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityMultipleExercise>();
   }
}
}

