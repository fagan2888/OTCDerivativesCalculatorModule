// DualCurrencyFeature.cpp 
#include "DualCurrencyFeature.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DualCurrencyFeature::DualCurrencyFeature(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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
             currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));}
   }

   //fixingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDateNode = xmlNode->FirstChildElement("fixingDate");

   if(fixingDateNode){fixingDateIsNull_ = false;}
   else{fixingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDateNode , address : " << fixingDateNode << std::endl;
   #endif
   if(fixingDateNode)
   {
      if(fixingDateNode->Attribute("href") || fixingDateNode->Attribute("id"))
      {
          if(fixingDateNode->Attribute("id"))
          {
             fixingDateIDRef_ = fixingDateNode->Attribute("id");
             fixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(fixingDateNode));
             fixingDate_->setID(fixingDateIDRef_);
             IDManager::instance().setID(fixingDateIDRef_,fixingDate_);
          }
          else if(fixingDateNode->Attribute("href")) { fixingDateIDRef_ = fixingDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(fixingDateNode));}
   }

   //fixingTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingTimeNode = xmlNode->FirstChildElement("fixingTime");

   if(fixingTimeNode){fixingTimeIsNull_ = false;}
   else{fixingTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingTimeNode , address : " << fixingTimeNode << std::endl;
   #endif
   if(fixingTimeNode)
   {
      if(fixingTimeNode->Attribute("href") || fixingTimeNode->Attribute("id"))
      {
          if(fixingTimeNode->Attribute("id"))
          {
             fixingTimeIDRef_ = fixingTimeNode->Attribute("id");
             fixingTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(fixingTimeNode));
             fixingTime_->setID(fixingTimeIDRef_);
             IDManager::instance().setID(fixingTimeIDRef_,fixingTime_);
          }
          else if(fixingTimeNode->Attribute("href")) { fixingTimeIDRef_ = fixingTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(fixingTimeNode));}
   }

   //strikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeNode = xmlNode->FirstChildElement("strike");

   if(strikeNode){strikeIsNull_ = false;}
   else{strikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
   #endif
   if(strikeNode)
   {
      if(strikeNode->Attribute("href") || strikeNode->Attribute("id"))
      {
          if(strikeNode->Attribute("id"))
          {
             strikeIDRef_ = strikeNode->Attribute("id");
             strike_ = boost::shared_ptr<DualCurrencyStrikePrice>(new DualCurrencyStrikePrice(strikeNode));
             strike_->setID(strikeIDRef_);
             IDManager::instance().setID(strikeIDRef_,strike_);
          }
          else if(strikeNode->Attribute("href")) { strikeIDRef_ = strikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strike_ = boost::shared_ptr<DualCurrencyStrikePrice>(new DualCurrencyStrikePrice(strikeNode));}
   }

   //spotRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spotRateNode = xmlNode->FirstChildElement("spotRate");

   if(spotRateNode){spotRateIsNull_ = false;}
   else{spotRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spotRateNode , address : " << spotRateNode << std::endl;
   #endif
   if(spotRateNode)
   {
      if(spotRateNode->Attribute("href") || spotRateNode->Attribute("id"))
      {
          if(spotRateNode->Attribute("id"))
          {
             spotRateIDRef_ = spotRateNode->Attribute("id");
             spotRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spotRateNode));
             spotRate_->setID(spotRateIDRef_);
             IDManager::instance().setID(spotRateIDRef_,spotRate_);
          }
          else if(spotRateNode->Attribute("href")) { spotRateIDRef_ = spotRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spotRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spotRateNode));}
   }

   //interestAtRiskNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestAtRiskNode = xmlNode->FirstChildElement("interestAtRisk");

   if(interestAtRiskNode){interestAtRiskIsNull_ = false;}
   else{interestAtRiskIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestAtRiskNode , address : " << interestAtRiskNode << std::endl;
   #endif
   if(interestAtRiskNode)
   {
      if(interestAtRiskNode->Attribute("href") || interestAtRiskNode->Attribute("id"))
      {
          if(interestAtRiskNode->Attribute("id"))
          {
             interestAtRiskIDRef_ = interestAtRiskNode->Attribute("id");
             interestAtRisk_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(interestAtRiskNode));
             interestAtRisk_->setID(interestAtRiskIDRef_);
             IDManager::instance().setID(interestAtRiskIDRef_,interestAtRisk_);
          }
          else if(interestAtRiskNode->Attribute("href")) { interestAtRiskIDRef_ = interestAtRiskNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestAtRisk_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(interestAtRiskNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> DualCurrencyFeature::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<XsdTypeDate> DualCurrencyFeature::getFixingDate()
{
   if(!this->fixingDateIsNull_){
        if(fixingDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(fixingDateIDRef_));
        }else{
             return this->fixingDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<BusinessCenterTime> DualCurrencyFeature::getFixingTime()
{
   if(!this->fixingTimeIsNull_){
        if(fixingTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(fixingTimeIDRef_));
        }else{
             return this->fixingTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<DualCurrencyStrikePrice> DualCurrencyFeature::getStrike()
{
   if(!this->strikeIsNull_){
        if(strikeIDRef_ != ""){
             return boost::shared_static_cast<DualCurrencyStrikePrice>(IDManager::instance().getID(strikeIDRef_));
        }else{
             return this->strike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DualCurrencyStrikePrice>();
   }
}
boost::shared_ptr<XsdTypeDecimal> DualCurrencyFeature::getSpotRate()
{
   if(!this->spotRateIsNull_){
        if(spotRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(spotRateIDRef_));
        }else{
             return this->spotRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DualCurrencyFeature::getInterestAtRisk()
{
   if(!this->interestAtRiskIsNull_){
        if(interestAtRiskIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(interestAtRiskIDRef_));
        }else{
             return this->interestAtRisk_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

