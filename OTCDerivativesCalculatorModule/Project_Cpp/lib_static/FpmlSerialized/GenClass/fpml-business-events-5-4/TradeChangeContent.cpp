// TradeChangeContent.cpp 
#include "TradeChangeContent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeChangeContent::TradeChangeContent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //oldTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* oldTradeIdentifierNode = xmlNode->FirstChildElement("oldTradeIdentifier");

   if(oldTradeIdentifierNode){oldTradeIdentifierIsNull_ = false;}
   else{oldTradeIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- oldTradeIdentifierNode , address : " << oldTradeIdentifierNode << std::endl;
   #endif
   if(oldTradeIdentifierNode)
   {
      if(oldTradeIdentifierNode->Attribute("href") || oldTradeIdentifierNode->Attribute("id"))
      {
          if(oldTradeIdentifierNode->Attribute("id"))
          {
             oldTradeIdentifierIDRef_ = oldTradeIdentifierNode->Attribute("id");
             oldTradeIdentifier_ = boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(oldTradeIdentifierNode));
             oldTradeIdentifier_->setID(oldTradeIdentifierIDRef_);
             IDManager::instance().setID(oldTradeIdentifierIDRef_,oldTradeIdentifier_);
          }
          else if(oldTradeIdentifierNode->Attribute("href")) { oldTradeIdentifierIDRef_ = oldTradeIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { oldTradeIdentifier_ = boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(oldTradeIdentifierNode));}
   }

   //oldTradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* oldTradeNode = xmlNode->FirstChildElement("oldTrade");

   if(oldTradeNode){oldTradeIsNull_ = false;}
   else{oldTradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- oldTradeNode , address : " << oldTradeNode << std::endl;
   #endif
   if(oldTradeNode)
   {
      if(oldTradeNode->Attribute("href") || oldTradeNode->Attribute("id"))
      {
          if(oldTradeNode->Attribute("id"))
          {
             oldTradeIDRef_ = oldTradeNode->Attribute("id");
             oldTrade_ = boost::shared_ptr<Trade>(new Trade(oldTradeNode));
             oldTrade_->setID(oldTradeIDRef_);
             IDManager::instance().setID(oldTradeIDRef_,oldTrade_);
          }
          else if(oldTradeNode->Attribute("href")) { oldTradeIDRef_ = oldTradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { oldTrade_ = boost::shared_ptr<Trade>(new Trade(oldTradeNode));}
   }

   //tradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeNode = xmlNode->FirstChildElement("trade");

   if(tradeNode){tradeIsNull_ = false;}
   else{tradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeNode , address : " << tradeNode << std::endl;
   #endif
   if(tradeNode)
   {
      if(tradeNode->Attribute("href") || tradeNode->Attribute("id"))
      {
          if(tradeNode->Attribute("id"))
          {
             tradeIDRef_ = tradeNode->Attribute("id");
             trade_ = boost::shared_ptr<Trade>(new Trade(tradeNode));
             trade_->setID(tradeIDRef_);
             IDManager::instance().setID(tradeIDRef_,trade_);
          }
          else if(tradeNode->Attribute("href")) { tradeIDRef_ = tradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { trade_ = boost::shared_ptr<Trade>(new Trade(tradeNode));}
   }

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));}
   }

   //changeEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* changeEventNode = xmlNode->FirstChildElement("changeEvent");

   if(changeEventNode){changeEventIsNull_ = false;}
   else{changeEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- changeEventNode , address : " << changeEventNode << std::endl;
   #endif
   if(changeEventNode)
   {
      if(changeEventNode->Attribute("href") || changeEventNode->Attribute("id"))
      {
          if(changeEventNode->Attribute("id"))
          {
             changeEventIDRef_ = changeEventNode->Attribute("id");
             changeEvent_ = boost::shared_ptr<ChangeEvent>(new ChangeEvent(changeEventNode));
             changeEvent_->setID(changeEventIDRef_);
             IDManager::instance().setID(changeEventIDRef_,changeEvent_);
          }
          else if(changeEventNode->Attribute("href")) { changeEventIDRef_ = changeEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { changeEvent_ = boost::shared_ptr<ChangeEvent>(new ChangeEvent(changeEventNode));}
   }

   //indexChangeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexChangeNode = xmlNode->FirstChildElement("indexChange");

   if(indexChangeNode){indexChangeIsNull_ = false;}
   else{indexChangeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexChangeNode , address : " << indexChangeNode << std::endl;
   #endif
   if(indexChangeNode)
   {
      if(indexChangeNode->Attribute("href") || indexChangeNode->Attribute("id"))
      {
          if(indexChangeNode->Attribute("id"))
          {
             indexChangeIDRef_ = indexChangeNode->Attribute("id");
             indexChange_ = boost::shared_ptr<IndexChange>(new IndexChange(indexChangeNode));
             indexChange_->setID(indexChangeIDRef_);
             IDManager::instance().setID(indexChangeIDRef_,indexChange_);
          }
          else if(indexChangeNode->Attribute("href")) { indexChangeIDRef_ = indexChangeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexChange_ = boost::shared_ptr<IndexChange>(new IndexChange(indexChangeNode));}
   }

   //paymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentNode = xmlNode->FirstChildElement("payment");

   if(paymentNode){paymentIsNull_ = false;}
   else{paymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentNode , address : " << paymentNode << std::endl;
   #endif
   if(paymentNode)
   {
      if(paymentNode->Attribute("href") || paymentNode->Attribute("id"))
      {
          if(paymentNode->Attribute("id"))
          {
             paymentIDRef_ = paymentNode->Attribute("id");
             payment_ = boost::shared_ptr<Payment>(new Payment(paymentNode));
             payment_->setID(paymentIDRef_);
             IDManager::instance().setID(paymentIDRef_,payment_);
          }
          else if(paymentNode->Attribute("href")) { paymentIDRef_ = paymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payment_ = boost::shared_ptr<Payment>(new Payment(paymentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyTradeIdentifier> TradeChangeContent::getOldTradeIdentifier()
{
   if(!this->oldTradeIdentifierIsNull_){
        if(oldTradeIdentifierIDRef_ != ""){
             return boost::shared_static_cast<PartyTradeIdentifier>(IDManager::instance().getID(oldTradeIdentifierIDRef_));
        }else{
             return this->oldTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyTradeIdentifier>();
   }
}
boost::shared_ptr<Trade> TradeChangeContent::getOldTrade()
{
   if(!this->oldTradeIsNull_){
        if(oldTradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(oldTradeIDRef_));
        }else{
             return this->oldTrade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
boost::shared_ptr<Trade> TradeChangeContent::getTrade()
{
   if(!this->tradeIsNull_){
        if(tradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(tradeIDRef_));
        }else{
             return this->trade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
boost::shared_ptr<XsdTypeDate> TradeChangeContent::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<ChangeEvent> TradeChangeContent::getChangeEvent()
{
   if(!this->changeEventIsNull_){
        if(changeEventIDRef_ != ""){
             return boost::shared_static_cast<ChangeEvent>(IDManager::instance().getID(changeEventIDRef_));
        }else{
             return this->changeEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ChangeEvent>();
   }
}
boost::shared_ptr<IndexChange> TradeChangeContent::getIndexChange()
{
   if(!this->indexChangeIsNull_){
        if(indexChangeIDRef_ != ""){
             return boost::shared_static_cast<IndexChange>(IDManager::instance().getID(indexChangeIDRef_));
        }else{
             return this->indexChange_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexChange>();
   }
}
boost::shared_ptr<Payment> TradeChangeContent::getPayment()
{
   if(!this->paymentIsNull_){
        if(paymentIDRef_ != ""){
             return boost::shared_static_cast<Payment>(IDManager::instance().getID(paymentIDRef_));
        }else{
             return this->payment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Payment>();
   }
}
}

