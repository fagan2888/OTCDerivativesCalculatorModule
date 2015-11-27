// CommodityEuropeanExercise.cpp 
#include "CommodityEuropeanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityEuropeanExercise::CommodityEuropeanExercise(TiXmlNode* xmlNode)
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> CommodityEuropeanExercise::getExpirationDate()
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
boost::shared_ptr<Frequency> CommodityEuropeanExercise::getExerciseFrequency()
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
boost::shared_ptr<BusinessCenterTime> CommodityEuropeanExercise::getExpirationTime()
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
}

