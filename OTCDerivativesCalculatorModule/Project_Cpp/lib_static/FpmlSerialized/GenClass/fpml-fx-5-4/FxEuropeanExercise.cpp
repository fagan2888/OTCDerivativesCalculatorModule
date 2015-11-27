// FxEuropeanExercise.cpp 
#include "FxEuropeanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxEuropeanExercise::FxEuropeanExercise(TiXmlNode* xmlNode)
: Exercise(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //valueDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueDateNode = xmlNode->FirstChildElement("valueDate");

   if(valueDateNode){valueDateIsNull_ = false;}
   else{valueDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueDateNode , address : " << valueDateNode << std::endl;
   #endif
   if(valueDateNode)
   {
      if(valueDateNode->Attribute("href") || valueDateNode->Attribute("id"))
      {
          if(valueDateNode->Attribute("id"))
          {
             valueDateIDRef_ = valueDateNode->Attribute("id");
             valueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(valueDateNode));
             valueDate_->setID(valueDateIDRef_);
             IDManager::instance().setID(valueDateIDRef_,valueDate_);
          }
          else if(valueDateNode->Attribute("href")) { valueDateIDRef_ = valueDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(valueDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> FxEuropeanExercise::getExpiryDate()
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
boost::shared_ptr<BusinessCenterTime> FxEuropeanExercise::getExpiryTime()
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
boost::shared_ptr<CutName> FxEuropeanExercise::getCutName()
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
boost::shared_ptr<XsdTypeDate> FxEuropeanExercise::getValueDate()
{
   if(!this->valueDateIsNull_){
        if(valueDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(valueDateIDRef_));
        }else{
             return this->valueDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

