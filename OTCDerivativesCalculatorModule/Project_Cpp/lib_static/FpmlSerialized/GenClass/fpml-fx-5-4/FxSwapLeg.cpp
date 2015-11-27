// FxSwapLeg.cpp 
#include "FxSwapLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxSwapLeg::FxSwapLeg(TiXmlNode* xmlNode)
: Leg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeIdentifierReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdentifierReferenceNode = xmlNode->FirstChildElement("tradeIdentifierReference");

   if(tradeIdentifierReferenceNode){tradeIdentifierReferenceIsNull_ = false;}
   else{tradeIdentifierReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierReferenceNode , address : " << tradeIdentifierReferenceNode << std::endl;
   #endif
   if(tradeIdentifierReferenceNode)
   {
      if(tradeIdentifierReferenceNode->Attribute("href") || tradeIdentifierReferenceNode->Attribute("id"))
      {
          if(tradeIdentifierReferenceNode->Attribute("id"))
          {
             tradeIdentifierReferenceIDRef_ = tradeIdentifierReferenceNode->Attribute("id");
             tradeIdentifierReference_ = boost::shared_ptr<PartyTradeIdentifierReference>(new PartyTradeIdentifierReference(tradeIdentifierReferenceNode));
             tradeIdentifierReference_->setID(tradeIdentifierReferenceIDRef_);
             IDManager::instance().setID(tradeIdentifierReferenceIDRef_,tradeIdentifierReference_);
          }
          else if(tradeIdentifierReferenceNode->Attribute("href")) { tradeIdentifierReferenceIDRef_ = tradeIdentifierReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeIdentifierReference_ = boost::shared_ptr<PartyTradeIdentifierReference>(new PartyTradeIdentifierReference(tradeIdentifierReferenceNode));}
   }

   //exchangedCurrency1Node ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangedCurrency1Node = xmlNode->FirstChildElement("exchangedCurrency1");

   if(exchangedCurrency1Node){exchangedCurrency1IsNull_ = false;}
   else{exchangedCurrency1IsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangedCurrency1Node , address : " << exchangedCurrency1Node << std::endl;
   #endif
   if(exchangedCurrency1Node)
   {
      if(exchangedCurrency1Node->Attribute("href") || exchangedCurrency1Node->Attribute("id"))
      {
          if(exchangedCurrency1Node->Attribute("id"))
          {
             exchangedCurrency1IDRef_ = exchangedCurrency1Node->Attribute("id");
             exchangedCurrency1_ = boost::shared_ptr<Payment>(new Payment(exchangedCurrency1Node));
             exchangedCurrency1_->setID(exchangedCurrency1IDRef_);
             IDManager::instance().setID(exchangedCurrency1IDRef_,exchangedCurrency1_);
          }
          else if(exchangedCurrency1Node->Attribute("href")) { exchangedCurrency1IDRef_ = exchangedCurrency1Node->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangedCurrency1_ = boost::shared_ptr<Payment>(new Payment(exchangedCurrency1Node));}
   }

   //exchangedCurrency2Node ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangedCurrency2Node = xmlNode->FirstChildElement("exchangedCurrency2");

   if(exchangedCurrency2Node){exchangedCurrency2IsNull_ = false;}
   else{exchangedCurrency2IsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangedCurrency2Node , address : " << exchangedCurrency2Node << std::endl;
   #endif
   if(exchangedCurrency2Node)
   {
      if(exchangedCurrency2Node->Attribute("href") || exchangedCurrency2Node->Attribute("id"))
      {
          if(exchangedCurrency2Node->Attribute("id"))
          {
             exchangedCurrency2IDRef_ = exchangedCurrency2Node->Attribute("id");
             exchangedCurrency2_ = boost::shared_ptr<Payment>(new Payment(exchangedCurrency2Node));
             exchangedCurrency2_->setID(exchangedCurrency2IDRef_);
             IDManager::instance().setID(exchangedCurrency2IDRef_,exchangedCurrency2_);
          }
          else if(exchangedCurrency2Node->Attribute("href")) { exchangedCurrency2IDRef_ = exchangedCurrency2Node->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangedCurrency2_ = boost::shared_ptr<Payment>(new Payment(exchangedCurrency2Node));}
   }

   //dealtCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dealtCurrencyNode = xmlNode->FirstChildElement("dealtCurrency");

   if(dealtCurrencyNode){dealtCurrencyIsNull_ = false;}
   else{dealtCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dealtCurrencyNode , address : " << dealtCurrencyNode << std::endl;
   #endif
   if(dealtCurrencyNode)
   {
      if(dealtCurrencyNode->Attribute("href") || dealtCurrencyNode->Attribute("id"))
      {
          if(dealtCurrencyNode->Attribute("id"))
          {
             dealtCurrencyIDRef_ = dealtCurrencyNode->Attribute("id");
             dealtCurrency_ = boost::shared_ptr<DealtCurrencyEnum>(new DealtCurrencyEnum(dealtCurrencyNode));
             dealtCurrency_->setID(dealtCurrencyIDRef_);
             IDManager::instance().setID(dealtCurrencyIDRef_,dealtCurrency_);
          }
          else if(dealtCurrencyNode->Attribute("href")) { dealtCurrencyIDRef_ = dealtCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dealtCurrency_ = boost::shared_ptr<DealtCurrencyEnum>(new DealtCurrencyEnum(dealtCurrencyNode));}
   }

   //tenorNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNameNode = xmlNode->FirstChildElement("tenorName");

   if(tenorNameNode){tenorNameIsNull_ = false;}
   else{tenorNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNameNode , address : " << tenorNameNode << std::endl;
   #endif
   if(tenorNameNode)
   {
      if(tenorNameNode->Attribute("href") || tenorNameNode->Attribute("id"))
      {
          if(tenorNameNode->Attribute("id"))
          {
             tenorNameIDRef_ = tenorNameNode->Attribute("id");
             tenorName_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(tenorNameNode));
             tenorName_->setID(tenorNameIDRef_);
             IDManager::instance().setID(tenorNameIDRef_,tenorName_);
          }
          else if(tenorNameNode->Attribute("href")) { tenorNameIDRef_ = tenorNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tenorName_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(tenorNameNode));}
   }

   //tenorPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorPeriodNode = xmlNode->FirstChildElement("tenorPeriod");

   if(tenorPeriodNode){tenorPeriodIsNull_ = false;}
   else{tenorPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorPeriodNode , address : " << tenorPeriodNode << std::endl;
   #endif
   if(tenorPeriodNode)
   {
      if(tenorPeriodNode->Attribute("href") || tenorPeriodNode->Attribute("id"))
      {
          if(tenorPeriodNode->Attribute("id"))
          {
             tenorPeriodIDRef_ = tenorPeriodNode->Attribute("id");
             tenorPeriod_ = boost::shared_ptr<Period>(new Period(tenorPeriodNode));
             tenorPeriod_->setID(tenorPeriodIDRef_);
             IDManager::instance().setID(tenorPeriodIDRef_,tenorPeriod_);
          }
          else if(tenorPeriodNode->Attribute("href")) { tenorPeriodIDRef_ = tenorPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tenorPeriod_ = boost::shared_ptr<Period>(new Period(tenorPeriodNode));}
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

   //currency1ValueDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currency1ValueDateNode = xmlNode->FirstChildElement("currency1ValueDate");

   if(currency1ValueDateNode){currency1ValueDateIsNull_ = false;}
   else{currency1ValueDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currency1ValueDateNode , address : " << currency1ValueDateNode << std::endl;
   #endif
   if(currency1ValueDateNode)
   {
      if(currency1ValueDateNode->Attribute("href") || currency1ValueDateNode->Attribute("id"))
      {
          if(currency1ValueDateNode->Attribute("id"))
          {
             currency1ValueDateIDRef_ = currency1ValueDateNode->Attribute("id");
             currency1ValueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(currency1ValueDateNode));
             currency1ValueDate_->setID(currency1ValueDateIDRef_);
             IDManager::instance().setID(currency1ValueDateIDRef_,currency1ValueDate_);
          }
          else if(currency1ValueDateNode->Attribute("href")) { currency1ValueDateIDRef_ = currency1ValueDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency1ValueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(currency1ValueDateNode));}
   }

   //currency2ValueDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currency2ValueDateNode = xmlNode->FirstChildElement("currency2ValueDate");

   if(currency2ValueDateNode){currency2ValueDateIsNull_ = false;}
   else{currency2ValueDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currency2ValueDateNode , address : " << currency2ValueDateNode << std::endl;
   #endif
   if(currency2ValueDateNode)
   {
      if(currency2ValueDateNode->Attribute("href") || currency2ValueDateNode->Attribute("id"))
      {
          if(currency2ValueDateNode->Attribute("id"))
          {
             currency2ValueDateIDRef_ = currency2ValueDateNode->Attribute("id");
             currency2ValueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(currency2ValueDateNode));
             currency2ValueDate_->setID(currency2ValueDateIDRef_);
             IDManager::instance().setID(currency2ValueDateIDRef_,currency2ValueDate_);
          }
          else if(currency2ValueDateNode->Attribute("href")) { currency2ValueDateIDRef_ = currency2ValueDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency2ValueDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(currency2ValueDateNode));}
   }

   //exchangeRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeRateNode = xmlNode->FirstChildElement("exchangeRate");

   if(exchangeRateNode){exchangeRateIsNull_ = false;}
   else{exchangeRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeRateNode , address : " << exchangeRateNode << std::endl;
   #endif
   if(exchangeRateNode)
   {
      if(exchangeRateNode->Attribute("href") || exchangeRateNode->Attribute("id"))
      {
          if(exchangeRateNode->Attribute("id"))
          {
             exchangeRateIDRef_ = exchangeRateNode->Attribute("id");
             exchangeRate_ = boost::shared_ptr<ExchangeRate>(new ExchangeRate(exchangeRateNode));
             exchangeRate_->setID(exchangeRateIDRef_);
             IDManager::instance().setID(exchangeRateIDRef_,exchangeRate_);
          }
          else if(exchangeRateNode->Attribute("href")) { exchangeRateIDRef_ = exchangeRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeRate_ = boost::shared_ptr<ExchangeRate>(new ExchangeRate(exchangeRateNode));}
   }

   //nonDeliverableSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonDeliverableSettlementNode = xmlNode->FirstChildElement("nonDeliverableSettlement");

   if(nonDeliverableSettlementNode){nonDeliverableSettlementIsNull_ = false;}
   else{nonDeliverableSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonDeliverableSettlementNode , address : " << nonDeliverableSettlementNode << std::endl;
   #endif
   if(nonDeliverableSettlementNode)
   {
      if(nonDeliverableSettlementNode->Attribute("href") || nonDeliverableSettlementNode->Attribute("id"))
      {
          if(nonDeliverableSettlementNode->Attribute("id"))
          {
             nonDeliverableSettlementIDRef_ = nonDeliverableSettlementNode->Attribute("id");
             nonDeliverableSettlement_ = boost::shared_ptr<FxCashSettlement>(new FxCashSettlement(nonDeliverableSettlementNode));
             nonDeliverableSettlement_->setID(nonDeliverableSettlementIDRef_);
             IDManager::instance().setID(nonDeliverableSettlementIDRef_,nonDeliverableSettlement_);
          }
          else if(nonDeliverableSettlementNode->Attribute("href")) { nonDeliverableSettlementIDRef_ = nonDeliverableSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonDeliverableSettlement_ = boost::shared_ptr<FxCashSettlement>(new FxCashSettlement(nonDeliverableSettlementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyTradeIdentifierReference> FxSwapLeg::getTradeIdentifierReference()
{
   if(!this->tradeIdentifierReferenceIsNull_){
        if(tradeIdentifierReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyTradeIdentifierReference>(IDManager::instance().getID(tradeIdentifierReferenceIDRef_));
        }else{
             return this->tradeIdentifierReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyTradeIdentifierReference>();
   }
}
boost::shared_ptr<Payment> FxSwapLeg::getExchangedCurrency1()
{
   if(!this->exchangedCurrency1IsNull_){
        if(exchangedCurrency1IDRef_ != ""){
             return boost::shared_static_cast<Payment>(IDManager::instance().getID(exchangedCurrency1IDRef_));
        }else{
             return this->exchangedCurrency1_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Payment>();
   }
}
boost::shared_ptr<Payment> FxSwapLeg::getExchangedCurrency2()
{
   if(!this->exchangedCurrency2IsNull_){
        if(exchangedCurrency2IDRef_ != ""){
             return boost::shared_static_cast<Payment>(IDManager::instance().getID(exchangedCurrency2IDRef_));
        }else{
             return this->exchangedCurrency2_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Payment>();
   }
}
boost::shared_ptr<DealtCurrencyEnum> FxSwapLeg::getDealtCurrency()
{
   if(!this->dealtCurrencyIsNull_){
        if(dealtCurrencyIDRef_ != ""){
             return boost::shared_static_cast<DealtCurrencyEnum>(IDManager::instance().getID(dealtCurrencyIDRef_));
        }else{
             return this->dealtCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DealtCurrencyEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> FxSwapLeg::getTenorName()
{
   if(!this->tenorNameIsNull_){
        if(tenorNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(tenorNameIDRef_));
        }else{
             return this->tenorName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Period> FxSwapLeg::getTenorPeriod()
{
   if(!this->tenorPeriodIsNull_){
        if(tenorPeriodIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(tenorPeriodIDRef_));
        }else{
             return this->tenorPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<XsdTypeDate> FxSwapLeg::getValueDate()
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
boost::shared_ptr<XsdTypeDate> FxSwapLeg::getCurrency1ValueDate()
{
   if(!this->currency1ValueDateIsNull_){
        if(currency1ValueDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(currency1ValueDateIDRef_));
        }else{
             return this->currency1ValueDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> FxSwapLeg::getCurrency2ValueDate()
{
   if(!this->currency2ValueDateIsNull_){
        if(currency2ValueDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(currency2ValueDateIDRef_));
        }else{
             return this->currency2ValueDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<ExchangeRate> FxSwapLeg::getExchangeRate()
{
   if(!this->exchangeRateIsNull_){
        if(exchangeRateIDRef_ != ""){
             return boost::shared_static_cast<ExchangeRate>(IDManager::instance().getID(exchangeRateIDRef_));
        }else{
             return this->exchangeRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExchangeRate>();
   }
}
boost::shared_ptr<FxCashSettlement> FxSwapLeg::getNonDeliverableSettlement()
{
   if(!this->nonDeliverableSettlementIsNull_){
        if(nonDeliverableSettlementIDRef_ != ""){
             return boost::shared_static_cast<FxCashSettlement>(IDManager::instance().getID(nonDeliverableSettlementIDRef_));
        }else{
             return this->nonDeliverableSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxCashSettlement>();
   }
}
}

