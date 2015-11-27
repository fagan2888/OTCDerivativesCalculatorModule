// EquityAmericanExercise.cpp 
#include "EquityAmericanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityAmericanExercise::EquityAmericanExercise(TiXmlNode* xmlNode)
: SharedAmericanExercise(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //latestExerciseTimeTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* latestExerciseTimeTypeNode = xmlNode->FirstChildElement("latestExerciseTimeType");

   if(latestExerciseTimeTypeNode){latestExerciseTimeTypeIsNull_ = false;}
   else{latestExerciseTimeTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- latestExerciseTimeTypeNode , address : " << latestExerciseTimeTypeNode << std::endl;
   #endif
   if(latestExerciseTimeTypeNode)
   {
      if(latestExerciseTimeTypeNode->Attribute("href") || latestExerciseTimeTypeNode->Attribute("id"))
      {
          if(latestExerciseTimeTypeNode->Attribute("id"))
          {
             latestExerciseTimeTypeIDRef_ = latestExerciseTimeTypeNode->Attribute("id");
             latestExerciseTimeType_ = boost::shared_ptr<TimeTypeEnum>(new TimeTypeEnum(latestExerciseTimeTypeNode));
             latestExerciseTimeType_->setID(latestExerciseTimeTypeIDRef_);
             IDManager::instance().setID(latestExerciseTimeTypeIDRef_,latestExerciseTimeType_);
          }
          else if(latestExerciseTimeTypeNode->Attribute("href")) { latestExerciseTimeTypeIDRef_ = latestExerciseTimeTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { latestExerciseTimeType_ = boost::shared_ptr<TimeTypeEnum>(new TimeTypeEnum(latestExerciseTimeTypeNode));}
   }

   //equityExpirationTimeTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityExpirationTimeTypeNode = xmlNode->FirstChildElement("equityExpirationTimeType");

   if(equityExpirationTimeTypeNode){equityExpirationTimeTypeIsNull_ = false;}
   else{equityExpirationTimeTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityExpirationTimeTypeNode , address : " << equityExpirationTimeTypeNode << std::endl;
   #endif
   if(equityExpirationTimeTypeNode)
   {
      if(equityExpirationTimeTypeNode->Attribute("href") || equityExpirationTimeTypeNode->Attribute("id"))
      {
          if(equityExpirationTimeTypeNode->Attribute("id"))
          {
             equityExpirationTimeTypeIDRef_ = equityExpirationTimeTypeNode->Attribute("id");
             equityExpirationTimeType_ = boost::shared_ptr<TimeTypeEnum>(new TimeTypeEnum(equityExpirationTimeTypeNode));
             equityExpirationTimeType_->setID(equityExpirationTimeTypeIDRef_);
             IDManager::instance().setID(equityExpirationTimeTypeIDRef_,equityExpirationTimeType_);
          }
          else if(equityExpirationTimeTypeNode->Attribute("href")) { equityExpirationTimeTypeIDRef_ = equityExpirationTimeTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityExpirationTimeType_ = boost::shared_ptr<TimeTypeEnum>(new TimeTypeEnum(equityExpirationTimeTypeNode));}
   }

   //equityExpirationTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityExpirationTimeNode = xmlNode->FirstChildElement("equityExpirationTime");

   if(equityExpirationTimeNode){equityExpirationTimeIsNull_ = false;}
   else{equityExpirationTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityExpirationTimeNode , address : " << equityExpirationTimeNode << std::endl;
   #endif
   if(equityExpirationTimeNode)
   {
      if(equityExpirationTimeNode->Attribute("href") || equityExpirationTimeNode->Attribute("id"))
      {
          if(equityExpirationTimeNode->Attribute("id"))
          {
             equityExpirationTimeIDRef_ = equityExpirationTimeNode->Attribute("id");
             equityExpirationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(equityExpirationTimeNode));
             equityExpirationTime_->setID(equityExpirationTimeIDRef_);
             IDManager::instance().setID(equityExpirationTimeIDRef_,equityExpirationTime_);
          }
          else if(equityExpirationTimeNode->Attribute("href")) { equityExpirationTimeIDRef_ = equityExpirationTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityExpirationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(equityExpirationTimeNode));}
   }

   //expirationTimeDeterminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationTimeDeterminationNode = xmlNode->FirstChildElement("expirationTimeDetermination");

   if(expirationTimeDeterminationNode){expirationTimeDeterminationIsNull_ = false;}
   else{expirationTimeDeterminationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationTimeDeterminationNode , address : " << expirationTimeDeterminationNode << std::endl;
   #endif
   if(expirationTimeDeterminationNode)
   {
      if(expirationTimeDeterminationNode->Attribute("href") || expirationTimeDeterminationNode->Attribute("id"))
      {
          if(expirationTimeDeterminationNode->Attribute("id"))
          {
             expirationTimeDeterminationIDRef_ = expirationTimeDeterminationNode->Attribute("id");
             expirationTimeDetermination_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(expirationTimeDeterminationNode));
             expirationTimeDetermination_->setID(expirationTimeDeterminationIDRef_);
             IDManager::instance().setID(expirationTimeDeterminationIDRef_,expirationTimeDetermination_);
          }
          else if(expirationTimeDeterminationNode->Attribute("href")) { expirationTimeDeterminationIDRef_ = expirationTimeDeterminationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationTimeDetermination_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(expirationTimeDeterminationNode));}
   }

   //equityMultipleExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityMultipleExerciseNode = xmlNode->FirstChildElement("equityMultipleExercise");

   if(equityMultipleExerciseNode){equityMultipleExerciseIsNull_ = false;}
   else{equityMultipleExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityMultipleExerciseNode , address : " << equityMultipleExerciseNode << std::endl;
   #endif
   if(equityMultipleExerciseNode)
   {
      if(equityMultipleExerciseNode->Attribute("href") || equityMultipleExerciseNode->Attribute("id"))
      {
          if(equityMultipleExerciseNode->Attribute("id"))
          {
             equityMultipleExerciseIDRef_ = equityMultipleExerciseNode->Attribute("id");
             equityMultipleExercise_ = boost::shared_ptr<EquityMultipleExercise>(new EquityMultipleExercise(equityMultipleExerciseNode));
             equityMultipleExercise_->setID(equityMultipleExerciseIDRef_);
             IDManager::instance().setID(equityMultipleExerciseIDRef_,equityMultipleExercise_);
          }
          else if(equityMultipleExerciseNode->Attribute("href")) { equityMultipleExerciseIDRef_ = equityMultipleExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityMultipleExercise_ = boost::shared_ptr<EquityMultipleExercise>(new EquityMultipleExercise(equityMultipleExerciseNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TimeTypeEnum> EquityAmericanExercise::getLatestExerciseTimeType()
{
   if(!this->latestExerciseTimeTypeIsNull_){
        if(latestExerciseTimeTypeIDRef_ != ""){
             return boost::shared_static_cast<TimeTypeEnum>(IDManager::instance().getID(latestExerciseTimeTypeIDRef_));
        }else{
             return this->latestExerciseTimeType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimeTypeEnum>();
   }
}
boost::shared_ptr<TimeTypeEnum> EquityAmericanExercise::getEquityExpirationTimeType()
{
   if(!this->equityExpirationTimeTypeIsNull_){
        if(equityExpirationTimeTypeIDRef_ != ""){
             return boost::shared_static_cast<TimeTypeEnum>(IDManager::instance().getID(equityExpirationTimeTypeIDRef_));
        }else{
             return this->equityExpirationTimeType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimeTypeEnum>();
   }
}
boost::shared_ptr<BusinessCenterTime> EquityAmericanExercise::getEquityExpirationTime()
{
   if(!this->equityExpirationTimeIsNull_){
        if(equityExpirationTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(equityExpirationTimeIDRef_));
        }else{
             return this->equityExpirationTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<DeterminationMethod> EquityAmericanExercise::getExpirationTimeDetermination()
{
   if(!this->expirationTimeDeterminationIsNull_){
        if(expirationTimeDeterminationIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethod>(IDManager::instance().getID(expirationTimeDeterminationIDRef_));
        }else{
             return this->expirationTimeDetermination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethod>();
   }
}
boost::shared_ptr<EquityMultipleExercise> EquityAmericanExercise::getEquityMultipleExercise()
{
   if(!this->equityMultipleExerciseIsNull_){
        if(equityMultipleExerciseIDRef_ != ""){
             return boost::shared_static_cast<EquityMultipleExercise>(IDManager::instance().getID(equityMultipleExerciseIDRef_));
        }else{
             return this->equityMultipleExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityMultipleExercise>();
   }
}
}

