// FxLinkedNotionalAmount.cpp 
#include "FxLinkedNotionalAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxLinkedNotionalAmount::FxLinkedNotionalAmount(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //resetDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resetDateNode = xmlNode->FirstChildElement("resetDate");

   if(resetDateNode){resetDateIsNull_ = false;}
   else{resetDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resetDateNode , address : " << resetDateNode << std::endl;
   #endif
   if(resetDateNode)
   {
      if(resetDateNode->Attribute("href") || resetDateNode->Attribute("id"))
      {
          if(resetDateNode->Attribute("id"))
          {
             resetDateIDRef_ = resetDateNode->Attribute("id");
             resetDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(resetDateNode));
             resetDate_->setID(resetDateIDRef_);
             IDManager::instance().setID(resetDateIDRef_,resetDate_);
          }
          else if(resetDateNode->Attribute("href")) { resetDateIDRef_ = resetDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resetDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(resetDateNode));}
   }

   //adjustedFxSpotFixingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedFxSpotFixingDateNode = xmlNode->FirstChildElement("adjustedFxSpotFixingDate");

   if(adjustedFxSpotFixingDateNode){adjustedFxSpotFixingDateIsNull_ = false;}
   else{adjustedFxSpotFixingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedFxSpotFixingDateNode , address : " << adjustedFxSpotFixingDateNode << std::endl;
   #endif
   if(adjustedFxSpotFixingDateNode)
   {
      if(adjustedFxSpotFixingDateNode->Attribute("href") || adjustedFxSpotFixingDateNode->Attribute("id"))
      {
          if(adjustedFxSpotFixingDateNode->Attribute("id"))
          {
             adjustedFxSpotFixingDateIDRef_ = adjustedFxSpotFixingDateNode->Attribute("id");
             adjustedFxSpotFixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedFxSpotFixingDateNode));
             adjustedFxSpotFixingDate_->setID(adjustedFxSpotFixingDateIDRef_);
             IDManager::instance().setID(adjustedFxSpotFixingDateIDRef_,adjustedFxSpotFixingDate_);
          }
          else if(adjustedFxSpotFixingDateNode->Attribute("href")) { adjustedFxSpotFixingDateIDRef_ = adjustedFxSpotFixingDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedFxSpotFixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedFxSpotFixingDateNode));}
   }

   //observedFxSpotRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observedFxSpotRateNode = xmlNode->FirstChildElement("observedFxSpotRate");

   if(observedFxSpotRateNode){observedFxSpotRateIsNull_ = false;}
   else{observedFxSpotRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observedFxSpotRateNode , address : " << observedFxSpotRateNode << std::endl;
   #endif
   if(observedFxSpotRateNode)
   {
      if(observedFxSpotRateNode->Attribute("href") || observedFxSpotRateNode->Attribute("id"))
      {
          if(observedFxSpotRateNode->Attribute("id"))
          {
             observedFxSpotRateIDRef_ = observedFxSpotRateNode->Attribute("id");
             observedFxSpotRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(observedFxSpotRateNode));
             observedFxSpotRate_->setID(observedFxSpotRateIDRef_);
             IDManager::instance().setID(observedFxSpotRateIDRef_,observedFxSpotRate_);
          }
          else if(observedFxSpotRateNode->Attribute("href")) { observedFxSpotRateIDRef_ = observedFxSpotRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { observedFxSpotRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(observedFxSpotRateNode));}
   }

   //notionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalAmountNode = xmlNode->FirstChildElement("notionalAmount");

   if(notionalAmountNode){notionalAmountIsNull_ = false;}
   else{notionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalAmountNode , address : " << notionalAmountNode << std::endl;
   #endif
   if(notionalAmountNode)
   {
      if(notionalAmountNode->Attribute("href") || notionalAmountNode->Attribute("id"))
      {
          if(notionalAmountNode->Attribute("id"))
          {
             notionalAmountIDRef_ = notionalAmountNode->Attribute("id");
             notionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalAmountNode));
             notionalAmount_->setID(notionalAmountIDRef_);
             IDManager::instance().setID(notionalAmountIDRef_,notionalAmount_);
          }
          else if(notionalAmountNode->Attribute("href")) { notionalAmountIDRef_ = notionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> FxLinkedNotionalAmount::getResetDate()
{
   if(!this->resetDateIsNull_){
        if(resetDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(resetDateIDRef_));
        }else{
             return this->resetDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> FxLinkedNotionalAmount::getAdjustedFxSpotFixingDate()
{
   if(!this->adjustedFxSpotFixingDateIsNull_){
        if(adjustedFxSpotFixingDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedFxSpotFixingDateIDRef_));
        }else{
             return this->adjustedFxSpotFixingDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FxLinkedNotionalAmount::getObservedFxSpotRate()
{
   if(!this->observedFxSpotRateIsNull_){
        if(observedFxSpotRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(observedFxSpotRateIDRef_));
        }else{
             return this->observedFxSpotRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FxLinkedNotionalAmount::getNotionalAmount()
{
   if(!this->notionalAmountIsNull_){
        if(notionalAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(notionalAmountIDRef_));
        }else{
             return this->notionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

