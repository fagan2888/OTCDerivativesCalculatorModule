// TradeChangeBase.cpp 
#include "TradeChangeBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeChangeBase::TradeChangeBase(TiXmlNode* xmlNode)
: AbstractEvent(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdentifierNode = xmlNode->FirstChildElement("tradeIdentifier");

   if(tradeIdentifierNode){tradeIdentifierIsNull_ = false;}
   else{tradeIdentifierIsNull_ = true;}

   if(tradeIdentifierNode)
   {
      for(tradeIdentifierNode; tradeIdentifierNode; tradeIdentifierNode = tradeIdentifierNode->NextSiblingElement("tradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
          #endif
          if(tradeIdentifierNode->Attribute("href") || tradeIdentifierNode->Attribute("id"))
          {
              if(tradeIdentifierNode->Attribute("id"))
              {
                  tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("id");
                  tradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(tradeIdentifierNode)));
                  tradeIdentifier_.back()->setID(tradeIdentifierIDRef_);
                  IDManager::instance().setID(tradeIdentifierIDRef_, tradeIdentifier_.back());
              }
              else if(tradeIdentifierNode->Attribute("href")) { tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { tradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(tradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
       #endif
   }

   //originalTradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originalTradeNode = xmlNode->FirstChildElement("originalTrade");

   if(originalTradeNode){originalTradeIsNull_ = false;}
   else{originalTradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originalTradeNode , address : " << originalTradeNode << std::endl;
   #endif
   if(originalTradeNode)
   {
      if(originalTradeNode->Attribute("href") || originalTradeNode->Attribute("id"))
      {
          if(originalTradeNode->Attribute("id"))
          {
             originalTradeIDRef_ = originalTradeNode->Attribute("id");
             originalTrade_ = boost::shared_ptr<Trade>(new Trade(originalTradeNode));
             originalTrade_->setID(originalTradeIDRef_);
             IDManager::instance().setID(originalTradeIDRef_,originalTrade_);
          }
          else if(originalTradeNode->Attribute("href")) { originalTradeIDRef_ = originalTradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originalTrade_ = boost::shared_ptr<Trade>(new Trade(originalTradeNode));}
   }

   //agreementDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* agreementDateNode = xmlNode->FirstChildElement("agreementDate");

   if(agreementDateNode){agreementDateIsNull_ = false;}
   else{agreementDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- agreementDateNode , address : " << agreementDateNode << std::endl;
   #endif
   if(agreementDateNode)
   {
      if(agreementDateNode->Attribute("href") || agreementDateNode->Attribute("id"))
      {
          if(agreementDateNode->Attribute("id"))
          {
             agreementDateIDRef_ = agreementDateNode->Attribute("id");
             agreementDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(agreementDateNode));
             agreementDate_->setID(agreementDateIDRef_);
             IDManager::instance().setID(agreementDateIDRef_,agreementDate_);
          }
          else if(agreementDateNode->Attribute("href")) { agreementDateIDRef_ = agreementDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { agreementDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(agreementDateNode));}
   }

   //executionDateTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* executionDateTimeNode = xmlNode->FirstChildElement("executionDateTime");

   if(executionDateTimeNode){executionDateTimeIsNull_ = false;}
   else{executionDateTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- executionDateTimeNode , address : " << executionDateTimeNode << std::endl;
   #endif
   if(executionDateTimeNode)
   {
      if(executionDateTimeNode->Attribute("href") || executionDateTimeNode->Attribute("id"))
      {
          if(executionDateTimeNode->Attribute("id"))
          {
             executionDateTimeIDRef_ = executionDateTimeNode->Attribute("id");
             executionDateTime_ = boost::shared_ptr<ExecutionDateTime>(new ExecutionDateTime(executionDateTimeNode));
             executionDateTime_->setID(executionDateTimeIDRef_);
             IDManager::instance().setID(executionDateTimeIDRef_,executionDateTime_);
          }
          else if(executionDateTimeNode->Attribute("href")) { executionDateTimeIDRef_ = executionDateTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { executionDateTime_ = boost::shared_ptr<ExecutionDateTime>(new ExecutionDateTime(executionDateTimeNode));}
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

   //paymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentNode = xmlNode->FirstChildElement("payment");

   if(paymentNode){paymentIsNull_ = false;}
   else{paymentIsNull_ = true;}

   if(paymentNode)
   {
      for(paymentNode; paymentNode; paymentNode = paymentNode->NextSiblingElement("payment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentNode , address : " << paymentNode << std::endl;
          #endif
          if(paymentNode->Attribute("href") || paymentNode->Attribute("id"))
          {
              if(paymentNode->Attribute("id"))
              {
                  paymentIDRef_ = paymentNode->Attribute("id");
                  payment_.push_back(boost::shared_ptr<Payment>(new Payment(paymentNode)));
                  payment_.back()->setID(paymentIDRef_);
                  IDManager::instance().setID(paymentIDRef_, payment_.back());
              }
              else if(paymentNode->Attribute("href")) { paymentIDRef_ = paymentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { payment_.push_back(boost::shared_ptr<Payment>(new Payment(paymentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentNode , address : " << paymentNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> TradeChangeBase::getTradeIdentifier()
{
   if(!this->tradeIdentifierIsNull_){
        if(tradeIdentifierIDRef_ != ""){
             return this->tradeIdentifier_;
        }else{
             return this->tradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
boost::shared_ptr<Trade> TradeChangeBase::getOriginalTrade()
{
   if(!this->originalTradeIsNull_){
        if(originalTradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(originalTradeIDRef_));
        }else{
             return this->originalTrade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
boost::shared_ptr<XsdTypeDate> TradeChangeBase::getAgreementDate()
{
   if(!this->agreementDateIsNull_){
        if(agreementDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(agreementDateIDRef_));
        }else{
             return this->agreementDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<ExecutionDateTime> TradeChangeBase::getExecutionDateTime()
{
   if(!this->executionDateTimeIsNull_){
        if(executionDateTimeIDRef_ != ""){
             return boost::shared_static_cast<ExecutionDateTime>(IDManager::instance().getID(executionDateTimeIDRef_));
        }else{
             return this->executionDateTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExecutionDateTime>();
   }
}
boost::shared_ptr<XsdTypeDate> TradeChangeBase::getEffectiveDate()
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
std::vector<boost::shared_ptr<Payment>> TradeChangeBase::getPayment()
{
   if(!this->paymentIsNull_){
        if(paymentIDRef_ != ""){
             return this->payment_;
        }else{
             return this->payment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Payment>>();
   }
}
}

