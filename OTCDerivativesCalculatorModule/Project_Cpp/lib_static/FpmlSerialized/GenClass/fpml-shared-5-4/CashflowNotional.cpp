// CashflowNotional.cpp 
#include "CashflowNotional.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CashflowNotional::CashflowNotional(TiXmlNode* xmlNode)
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

   //unitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unitsNode = xmlNode->FirstChildElement("units");

   if(unitsNode){unitsIsNull_ = false;}
   else{unitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unitsNode , address : " << unitsNode << std::endl;
   #endif
   if(unitsNode)
   {
      if(unitsNode->Attribute("href") || unitsNode->Attribute("id"))
      {
          if(unitsNode->Attribute("id"))
          {
             unitsIDRef_ = unitsNode->Attribute("id");
             units_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(unitsNode));
             units_->setID(unitsIDRef_);
             IDManager::instance().setID(unitsIDRef_,units_);
          }
          else if(unitsNode->Attribute("href")) { unitsIDRef_ = unitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { units_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(unitsNode));}
   }

   //amountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountNode = xmlNode->FirstChildElement("amount");

   if(amountNode){amountIsNull_ = false;}
   else{amountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountNode , address : " << amountNode << std::endl;
   #endif
   if(amountNode)
   {
      if(amountNode->Attribute("href") || amountNode->Attribute("id"))
      {
          if(amountNode->Attribute("id"))
          {
             amountIDRef_ = amountNode->Attribute("id");
             amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));
             amount_->setID(amountIDRef_);
             IDManager::instance().setID(amountIDRef_,amount_);
          }
          else if(amountNode->Attribute("href")) { amountIDRef_ = amountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> CashflowNotional::getCurrency()
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
boost::shared_ptr<XsdTypeNormalizedString> CashflowNotional::getUnits()
{
   if(!this->unitsIsNull_){
        if(unitsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(unitsIDRef_));
        }else{
             return this->units_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CashflowNotional::getAmount()
{
   if(!this->amountIsNull_){
        if(amountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(amountIDRef_));
        }else{
             return this->amount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

