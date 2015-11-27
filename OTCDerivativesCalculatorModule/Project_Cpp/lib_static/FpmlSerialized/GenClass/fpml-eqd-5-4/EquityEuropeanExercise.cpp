// EquityEuropeanExercise.cpp 
#include "EquityEuropeanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityEuropeanExercise::EquityEuropeanExercise(TiXmlNode* xmlNode)
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> EquityEuropeanExercise::getExpirationDate()
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
boost::shared_ptr<TimeTypeEnum> EquityEuropeanExercise::getEquityExpirationTimeType()
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
boost::shared_ptr<BusinessCenterTime> EquityEuropeanExercise::getEquityExpirationTime()
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
boost::shared_ptr<DeterminationMethod> EquityEuropeanExercise::getExpirationTimeDetermination()
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
}

