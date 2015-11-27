// FxDigitalAmericanExercise.cpp 
#include "FxDigitalAmericanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxDigitalAmericanExercise::FxDigitalAmericanExercise(TiXmlNode* xmlNode)
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

   //expiryDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expiryDateNode = xmlNode->FirstChildElement("expiryDate");

   if(expiryDateNode){expiryDateIsNull_ = false;}
   else{expiryDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expiryDateNode , address : " << expiryDateNode << std::endl;
   #endif
   if(expiryDateNode)
   {
      if(expiryDateNode->Attribute("href") || expiryDateNode->Attribute("id"))
      {
          if(expiryDateNode->Attribute("id"))
          {
             expiryDateIDRef_ = expiryDateNode->Attribute("id");
             expiryDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(expiryDateNode));
             expiryDate_->setID(expiryDateIDRef_);
             IDManager::instance().setID(expiryDateIDRef_,expiryDate_);
          }
          else if(expiryDateNode->Attribute("href")) { expiryDateIDRef_ = expiryDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expiryDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(expiryDateNode));}
   }

   //expiryTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expiryTimeNode = xmlNode->FirstChildElement("expiryTime");

   if(expiryTimeNode){expiryTimeIsNull_ = false;}
   else{expiryTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expiryTimeNode , address : " << expiryTimeNode << std::endl;
   #endif
   if(expiryTimeNode)
   {
      if(expiryTimeNode->Attribute("href") || expiryTimeNode->Attribute("id"))
      {
          if(expiryTimeNode->Attribute("id"))
          {
             expiryTimeIDRef_ = expiryTimeNode->Attribute("id");
             expiryTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(expiryTimeNode));
             expiryTime_->setID(expiryTimeIDRef_);
             IDManager::instance().setID(expiryTimeIDRef_,expiryTime_);
          }
          else if(expiryTimeNode->Attribute("href")) { expiryTimeIDRef_ = expiryTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expiryTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(expiryTimeNode));}
   }

   //cutNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cutNameNode = xmlNode->FirstChildElement("cutName");

   if(cutNameNode){cutNameIsNull_ = false;}
   else{cutNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cutNameNode , address : " << cutNameNode << std::endl;
   #endif
   if(cutNameNode)
   {
      if(cutNameNode->Attribute("href") || cutNameNode->Attribute("id"))
      {
          if(cutNameNode->Attribute("id"))
          {
             cutNameIDRef_ = cutNameNode->Attribute("id");
             cutName_ = boost::shared_ptr<CutName>(new CutName(cutNameNode));
             cutName_->setID(cutNameIDRef_);
             IDManager::instance().setID(cutNameIDRef_,cutName_);
          }
          else if(cutNameNode->Attribute("href")) { cutNameIDRef_ = cutNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cutName_ = boost::shared_ptr<CutName>(new CutName(cutNameNode));}
   }

   //latestValueDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* latestValueDateNode = xmlNode->FirstChildElement("latestValueDate");

   if(latestValueDateNode){latestValueDateIsNull_ = false;}
   else{latestValueDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- latestValueDateNode , address : " << latestValueDateNode << std::endl;
   #endif
   if(latestValueDateNode)
   {
      if(latestValueDateNode->Attribute("href") || latestValueDateNode->Attribute("id"))
      {
          if(latestValueDateNode->Attribute("id"))
          {
             latestValueDateIDRef_ = latestValueDateNode->Attribute("id");
             latestValueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(latestValueDateNode));
             latestValueDate_->setID(latestValueDateIDRef_);
             IDManager::instance().setID(latestValueDateIDRef_,latestValueDate_);
          }
          else if(latestValueDateNode->Attribute("href")) { latestValueDateIDRef_ = latestValueDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { latestValueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(latestValueDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> FxDigitalAmericanExercise::getCommencementDate()
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
boost::shared_ptr<XsdTypeDate> FxDigitalAmericanExercise::getExpiryDate()
{
   if(!this->expiryDateIsNull_){
        if(expiryDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(expiryDateIDRef_));
        }else{
             return this->expiryDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<BusinessCenterTime> FxDigitalAmericanExercise::getExpiryTime()
{
   if(!this->expiryTimeIsNull_){
        if(expiryTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(expiryTimeIDRef_));
        }else{
             return this->expiryTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<CutName> FxDigitalAmericanExercise::getCutName()
{
   if(!this->cutNameIsNull_){
        if(cutNameIDRef_ != ""){
             return boost::shared_static_cast<CutName>(IDManager::instance().getID(cutNameIDRef_));
        }else{
             return this->cutName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CutName>();
   }
}
boost::shared_ptr<XsdTypeDate> FxDigitalAmericanExercise::getLatestValueDate()
{
   if(!this->latestValueDateIsNull_){
        if(latestValueDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(latestValueDateIDRef_));
        }else{
             return this->latestValueDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

