// CommonInformation.cpp 
#include "CommonInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommonInformation::CommonInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessDayNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayNode = xmlNode->FirstChildElement("businessDay");

   if(businessDayNode){businessDayIsNull_ = false;}
   else{businessDayIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayNode , address : " << businessDayNode << std::endl;
   #endif
   if(businessDayNode)
   {
      if(businessDayNode->Attribute("href") || businessDayNode->Attribute("id"))
      {
          if(businessDayNode->Attribute("id"))
          {
             businessDayIDRef_ = businessDayNode->Attribute("id");
             businessDay_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(businessDayNode));
             businessDay_->setID(businessDayIDRef_);
             IDManager::instance().setID(businessDayIDRef_,businessDay_);
          }
          else if(businessDayNode->Attribute("href")) { businessDayIDRef_ = businessDayNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDay_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(businessDayNode));}
   }

   //businessDayConvenctionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayConvenctionNode = xmlNode->FirstChildElement("businessDayConvenction");

   if(businessDayConvenctionNode){businessDayConvenctionIsNull_ = false;}
   else{businessDayConvenctionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayConvenctionNode , address : " << businessDayConvenctionNode << std::endl;
   #endif
   if(businessDayConvenctionNode)
   {
      if(businessDayConvenctionNode->Attribute("href") || businessDayConvenctionNode->Attribute("id"))
      {
          if(businessDayConvenctionNode->Attribute("id"))
          {
             businessDayConvenctionIDRef_ = businessDayConvenctionNode->Attribute("id");
             businessDayConvenction_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(businessDayConvenctionNode));
             businessDayConvenction_->setID(businessDayConvenctionIDRef_);
             IDManager::instance().setID(businessDayConvenctionIDRef_,businessDayConvenction_);
          }
          else if(businessDayConvenctionNode->Attribute("href")) { businessDayConvenctionIDRef_ = businessDayConvenctionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDayConvenction_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(businessDayConvenctionNode));}
   }

   //daycounterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* daycounterNode = xmlNode->FirstChildElement("daycounter");

   if(daycounterNode){daycounterIsNull_ = false;}
   else{daycounterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- daycounterNode , address : " << daycounterNode << std::endl;
   #endif
   if(daycounterNode)
   {
      if(daycounterNode->Attribute("href") || daycounterNode->Attribute("id"))
      {
          if(daycounterNode->Attribute("id"))
          {
             daycounterIDRef_ = daycounterNode->Attribute("id");
             daycounter_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(daycounterNode));
             daycounter_->setID(daycounterIDRef_);
             IDManager::instance().setID(daycounterIDRef_,daycounter_);
          }
          else if(daycounterNode->Attribute("href")) { daycounterIDRef_ = daycounterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { daycounter_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(daycounterNode));}
   }

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
      if(currencyNode->Attribute("href") || currencyNode->Attribute("id"))
      {
          if(currencyNode->Attribute("id"))
          {
             currencyIDRef_ = currencyNode->Attribute("id");
             currency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currencyNode));}
   }

   //imbededOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* imbededOptionNode = xmlNode->FirstChildElement("imbededOption");

   if(imbededOptionNode){imbededOptionIsNull_ = false;}
   else{imbededOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- imbededOptionNode , address : " << imbededOptionNode << std::endl;
   #endif
   if(imbededOptionNode)
   {
      if(imbededOptionNode->Attribute("href") || imbededOptionNode->Attribute("id"))
      {
          if(imbededOptionNode->Attribute("id"))
          {
             imbededOptionIDRef_ = imbededOptionNode->Attribute("id");
             imbededOption_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(imbededOptionNode));
             imbededOption_->setID(imbededOptionIDRef_);
             IDManager::instance().setID(imbededOptionIDRef_,imbededOption_);
          }
          else if(imbededOptionNode->Attribute("href")) { imbededOptionIDRef_ = imbededOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { imbededOption_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(imbededOptionNode));}
   }

   //calendarNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calendarNode = xmlNode->FirstChildElement("calendar");

   if(calendarNode){calendarIsNull_ = false;}
   else{calendarIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calendarNode , address : " << calendarNode << std::endl;
   #endif
   if(calendarNode)
   {
      if(calendarNode->Attribute("href") || calendarNode->Attribute("id"))
      {
          if(calendarNode->Attribute("id"))
          {
             calendarIDRef_ = calendarNode->Attribute("id");
             calendar_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calendarNode));
             calendar_->setID(calendarIDRef_);
             IDManager::instance().setID(calendarIDRef_,calendar_);
          }
          else if(calendarNode->Attribute("href")) { calendarIDRef_ = calendarNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calendar_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calendarNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CommonInformation::getBusinessDay()
{
   if(!this->businessDayIsNull_){
        if(businessDayIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(businessDayIDRef_));
        }else{
             return this->businessDay_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CommonInformation::getBusinessDayConvenction()
{
   if(!this->businessDayConvenctionIsNull_){
        if(businessDayConvenctionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(businessDayConvenctionIDRef_));
        }else{
             return this->businessDayConvenction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CommonInformation::getDaycounter()
{
   if(!this->daycounterIsNull_){
        if(daycounterIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(daycounterIDRef_));
        }else{
             return this->daycounter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CommonInformation::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CommonInformation::getImbededOption()
{
   if(!this->imbededOptionIsNull_){
        if(imbededOptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(imbededOptionIDRef_));
        }else{
             return this->imbededOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CommonInformation::getCalendar()
{
   if(!this->calendarIsNull_){
        if(calendarIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(calendarIDRef_));
        }else{
             return this->calendar_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

