// TradeNovationContent.cpp 
#include "TradeNovationContent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeNovationContent::TradeNovationContent(TiXmlNode* xmlNode)
: AbstractEvent(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //newTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* newTradeIdentifierNode = xmlNode->FirstChildElement("newTradeIdentifier");

   if(newTradeIdentifierNode){newTradeIdentifierIsNull_ = false;}
   else{newTradeIdentifierIsNull_ = true;}

   if(newTradeIdentifierNode)
   {
      for(newTradeIdentifierNode; newTradeIdentifierNode; newTradeIdentifierNode = newTradeIdentifierNode->NextSiblingElement("newTradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- newTradeIdentifierNode , address : " << newTradeIdentifierNode << std::endl;
          #endif
          if(newTradeIdentifierNode->Attribute("href") || newTradeIdentifierNode->Attribute("id"))
          {
              if(newTradeIdentifierNode->Attribute("id"))
              {
                  newTradeIdentifierIDRef_ = newTradeIdentifierNode->Attribute("id");
                  newTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(newTradeIdentifierNode)));
                  newTradeIdentifier_.back()->setID(newTradeIdentifierIDRef_);
                  IDManager::instance().setID(newTradeIdentifierIDRef_, newTradeIdentifier_.back());
              }
              else if(newTradeIdentifierNode->Attribute("href")) { newTradeIdentifierIDRef_ = newTradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { newTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(newTradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- newTradeIdentifierNode , address : " << newTradeIdentifierNode << std::endl;
       #endif
   }

   //newTradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* newTradeNode = xmlNode->FirstChildElement("newTrade");

   if(newTradeNode){newTradeIsNull_ = false;}
   else{newTradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- newTradeNode , address : " << newTradeNode << std::endl;
   #endif
   if(newTradeNode)
   {
      if(newTradeNode->Attribute("href") || newTradeNode->Attribute("id"))
      {
          if(newTradeNode->Attribute("id"))
          {
             newTradeIDRef_ = newTradeNode->Attribute("id");
             newTrade_ = boost::shared_ptr<Trade>(new Trade(newTradeNode));
             newTrade_->setID(newTradeIDRef_);
             IDManager::instance().setID(newTradeIDRef_,newTrade_);
          }
          else if(newTradeNode->Attribute("href")) { newTradeIDRef_ = newTradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { newTrade_ = boost::shared_ptr<Trade>(new Trade(newTradeNode));}
   }

   //oldTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* oldTradeIdentifierNode = xmlNode->FirstChildElement("oldTradeIdentifier");

   if(oldTradeIdentifierNode){oldTradeIdentifierIsNull_ = false;}
   else{oldTradeIdentifierIsNull_ = true;}

   if(oldTradeIdentifierNode)
   {
      for(oldTradeIdentifierNode; oldTradeIdentifierNode; oldTradeIdentifierNode = oldTradeIdentifierNode->NextSiblingElement("oldTradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- oldTradeIdentifierNode , address : " << oldTradeIdentifierNode << std::endl;
          #endif
          if(oldTradeIdentifierNode->Attribute("href") || oldTradeIdentifierNode->Attribute("id"))
          {
              if(oldTradeIdentifierNode->Attribute("id"))
              {
                  oldTradeIdentifierIDRef_ = oldTradeIdentifierNode->Attribute("id");
                  oldTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(oldTradeIdentifierNode)));
                  oldTradeIdentifier_.back()->setID(oldTradeIdentifierIDRef_);
                  IDManager::instance().setID(oldTradeIdentifierIDRef_, oldTradeIdentifier_.back());
              }
              else if(oldTradeIdentifierNode->Attribute("href")) { oldTradeIdentifierIDRef_ = oldTradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { oldTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(oldTradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- oldTradeIdentifierNode , address : " << oldTradeIdentifierNode << std::endl;
       #endif
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

   //feeTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* feeTradeIdentifierNode = xmlNode->FirstChildElement("feeTradeIdentifier");

   if(feeTradeIdentifierNode){feeTradeIdentifierIsNull_ = false;}
   else{feeTradeIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- feeTradeIdentifierNode , address : " << feeTradeIdentifierNode << std::endl;
   #endif
   if(feeTradeIdentifierNode)
   {
      if(feeTradeIdentifierNode->Attribute("href") || feeTradeIdentifierNode->Attribute("id"))
      {
          if(feeTradeIdentifierNode->Attribute("id"))
          {
             feeTradeIdentifierIDRef_ = feeTradeIdentifierNode->Attribute("id");
             feeTradeIdentifier_ = boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(feeTradeIdentifierNode));
             feeTradeIdentifier_->setID(feeTradeIdentifierIDRef_);
             IDManager::instance().setID(feeTradeIdentifierIDRef_,feeTradeIdentifier_);
          }
          else if(feeTradeIdentifierNode->Attribute("href")) { feeTradeIdentifierIDRef_ = feeTradeIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feeTradeIdentifier_ = boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(feeTradeIdentifierNode));}
   }

   //feeTradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* feeTradeNode = xmlNode->FirstChildElement("feeTrade");

   if(feeTradeNode){feeTradeIsNull_ = false;}
   else{feeTradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- feeTradeNode , address : " << feeTradeNode << std::endl;
   #endif
   if(feeTradeNode)
   {
      if(feeTradeNode->Attribute("href") || feeTradeNode->Attribute("id"))
      {
          if(feeTradeNode->Attribute("id"))
          {
             feeTradeIDRef_ = feeTradeNode->Attribute("id");
             feeTrade_ = boost::shared_ptr<Trade>(new Trade(feeTradeNode));
             feeTrade_->setID(feeTradeIDRef_);
             IDManager::instance().setID(feeTradeIDRef_,feeTrade_);
          }
          else if(feeTradeNode->Attribute("href")) { feeTradeIDRef_ = feeTradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feeTrade_ = boost::shared_ptr<Trade>(new Trade(feeTradeNode));}
   }

   //transferorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transferorNode = xmlNode->FirstChildElement("transferor");

   if(transferorNode){transferorIsNull_ = false;}
   else{transferorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transferorNode , address : " << transferorNode << std::endl;
   #endif
   if(transferorNode)
   {
      if(transferorNode->Attribute("href") || transferorNode->Attribute("id"))
      {
          if(transferorNode->Attribute("id"))
          {
             transferorIDRef_ = transferorNode->Attribute("id");
             transferor_ = boost::shared_ptr<PartyReference>(new PartyReference(transferorNode));
             transferor_->setID(transferorIDRef_);
             IDManager::instance().setID(transferorIDRef_,transferor_);
          }
          else if(transferorNode->Attribute("href")) { transferorIDRef_ = transferorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { transferor_ = boost::shared_ptr<PartyReference>(new PartyReference(transferorNode));}
   }

   //transferorAccountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transferorAccountNode = xmlNode->FirstChildElement("transferorAccount");

   if(transferorAccountNode){transferorAccountIsNull_ = false;}
   else{transferorAccountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transferorAccountNode , address : " << transferorAccountNode << std::endl;
   #endif
   if(transferorAccountNode)
   {
      if(transferorAccountNode->Attribute("href") || transferorAccountNode->Attribute("id"))
      {
          if(transferorAccountNode->Attribute("id"))
          {
             transferorAccountIDRef_ = transferorAccountNode->Attribute("id");
             transferorAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(transferorAccountNode));
             transferorAccount_->setID(transferorAccountIDRef_);
             IDManager::instance().setID(transferorAccountIDRef_,transferorAccount_);
          }
          else if(transferorAccountNode->Attribute("href")) { transferorAccountIDRef_ = transferorAccountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { transferorAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(transferorAccountNode));}
   }

   //transfereeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transfereeNode = xmlNode->FirstChildElement("transferee");

   if(transfereeNode){transfereeIsNull_ = false;}
   else{transfereeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transfereeNode , address : " << transfereeNode << std::endl;
   #endif
   if(transfereeNode)
   {
      if(transfereeNode->Attribute("href") || transfereeNode->Attribute("id"))
      {
          if(transfereeNode->Attribute("id"))
          {
             transfereeIDRef_ = transfereeNode->Attribute("id");
             transferee_ = boost::shared_ptr<PartyReference>(new PartyReference(transfereeNode));
             transferee_->setID(transfereeIDRef_);
             IDManager::instance().setID(transfereeIDRef_,transferee_);
          }
          else if(transfereeNode->Attribute("href")) { transfereeIDRef_ = transfereeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { transferee_ = boost::shared_ptr<PartyReference>(new PartyReference(transfereeNode));}
   }

   //otherTransfereeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* otherTransfereeNode = xmlNode->FirstChildElement("otherTransferee");

   if(otherTransfereeNode){otherTransfereeIsNull_ = false;}
   else{otherTransfereeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- otherTransfereeNode , address : " << otherTransfereeNode << std::endl;
   #endif
   if(otherTransfereeNode)
   {
      if(otherTransfereeNode->Attribute("href") || otherTransfereeNode->Attribute("id"))
      {
          if(otherTransfereeNode->Attribute("id"))
          {
             otherTransfereeIDRef_ = otherTransfereeNode->Attribute("id");
             otherTransferee_ = boost::shared_ptr<PartyReference>(new PartyReference(otherTransfereeNode));
             otherTransferee_->setID(otherTransfereeIDRef_);
             IDManager::instance().setID(otherTransfereeIDRef_,otherTransferee_);
          }
          else if(otherTransfereeNode->Attribute("href")) { otherTransfereeIDRef_ = otherTransfereeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { otherTransferee_ = boost::shared_ptr<PartyReference>(new PartyReference(otherTransfereeNode));}
   }

   //transfereeAccountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transfereeAccountNode = xmlNode->FirstChildElement("transfereeAccount");

   if(transfereeAccountNode){transfereeAccountIsNull_ = false;}
   else{transfereeAccountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transfereeAccountNode , address : " << transfereeAccountNode << std::endl;
   #endif
   if(transfereeAccountNode)
   {
      if(transfereeAccountNode->Attribute("href") || transfereeAccountNode->Attribute("id"))
      {
          if(transfereeAccountNode->Attribute("id"))
          {
             transfereeAccountIDRef_ = transfereeAccountNode->Attribute("id");
             transfereeAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(transfereeAccountNode));
             transfereeAccount_->setID(transfereeAccountIDRef_);
             IDManager::instance().setID(transfereeAccountIDRef_,transfereeAccount_);
          }
          else if(transfereeAccountNode->Attribute("href")) { transfereeAccountIDRef_ = transfereeAccountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { transfereeAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(transfereeAccountNode));}
   }

   //otherTransfereeAccountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* otherTransfereeAccountNode = xmlNode->FirstChildElement("otherTransfereeAccount");

   if(otherTransfereeAccountNode){otherTransfereeAccountIsNull_ = false;}
   else{otherTransfereeAccountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- otherTransfereeAccountNode , address : " << otherTransfereeAccountNode << std::endl;
   #endif
   if(otherTransfereeAccountNode)
   {
      if(otherTransfereeAccountNode->Attribute("href") || otherTransfereeAccountNode->Attribute("id"))
      {
          if(otherTransfereeAccountNode->Attribute("id"))
          {
             otherTransfereeAccountIDRef_ = otherTransfereeAccountNode->Attribute("id");
             otherTransfereeAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(otherTransfereeAccountNode));
             otherTransfereeAccount_->setID(otherTransfereeAccountIDRef_);
             IDManager::instance().setID(otherTransfereeAccountIDRef_,otherTransfereeAccount_);
          }
          else if(otherTransfereeAccountNode->Attribute("href")) { otherTransfereeAccountIDRef_ = otherTransfereeAccountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { otherTransfereeAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(otherTransfereeAccountNode));}
   }

   //remainingPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* remainingPartyNode = xmlNode->FirstChildElement("remainingParty");

   if(remainingPartyNode){remainingPartyIsNull_ = false;}
   else{remainingPartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- remainingPartyNode , address : " << remainingPartyNode << std::endl;
   #endif
   if(remainingPartyNode)
   {
      if(remainingPartyNode->Attribute("href") || remainingPartyNode->Attribute("id"))
      {
          if(remainingPartyNode->Attribute("id"))
          {
             remainingPartyIDRef_ = remainingPartyNode->Attribute("id");
             remainingParty_ = boost::shared_ptr<PartyReference>(new PartyReference(remainingPartyNode));
             remainingParty_->setID(remainingPartyIDRef_);
             IDManager::instance().setID(remainingPartyIDRef_,remainingParty_);
          }
          else if(remainingPartyNode->Attribute("href")) { remainingPartyIDRef_ = remainingPartyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { remainingParty_ = boost::shared_ptr<PartyReference>(new PartyReference(remainingPartyNode));}
   }

   //remainingPartyAccountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* remainingPartyAccountNode = xmlNode->FirstChildElement("remainingPartyAccount");

   if(remainingPartyAccountNode){remainingPartyAccountIsNull_ = false;}
   else{remainingPartyAccountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- remainingPartyAccountNode , address : " << remainingPartyAccountNode << std::endl;
   #endif
   if(remainingPartyAccountNode)
   {
      if(remainingPartyAccountNode->Attribute("href") || remainingPartyAccountNode->Attribute("id"))
      {
          if(remainingPartyAccountNode->Attribute("id"))
          {
             remainingPartyAccountIDRef_ = remainingPartyAccountNode->Attribute("id");
             remainingPartyAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(remainingPartyAccountNode));
             remainingPartyAccount_->setID(remainingPartyAccountIDRef_);
             IDManager::instance().setID(remainingPartyAccountIDRef_,remainingPartyAccount_);
          }
          else if(remainingPartyAccountNode->Attribute("href")) { remainingPartyAccountIDRef_ = remainingPartyAccountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { remainingPartyAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(remainingPartyAccountNode));}
   }

   //otherRemainingPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* otherRemainingPartyNode = xmlNode->FirstChildElement("otherRemainingParty");

   if(otherRemainingPartyNode){otherRemainingPartyIsNull_ = false;}
   else{otherRemainingPartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- otherRemainingPartyNode , address : " << otherRemainingPartyNode << std::endl;
   #endif
   if(otherRemainingPartyNode)
   {
      if(otherRemainingPartyNode->Attribute("href") || otherRemainingPartyNode->Attribute("id"))
      {
          if(otherRemainingPartyNode->Attribute("id"))
          {
             otherRemainingPartyIDRef_ = otherRemainingPartyNode->Attribute("id");
             otherRemainingParty_ = boost::shared_ptr<PartyReference>(new PartyReference(otherRemainingPartyNode));
             otherRemainingParty_->setID(otherRemainingPartyIDRef_);
             IDManager::instance().setID(otherRemainingPartyIDRef_,otherRemainingParty_);
          }
          else if(otherRemainingPartyNode->Attribute("href")) { otherRemainingPartyIDRef_ = otherRemainingPartyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { otherRemainingParty_ = boost::shared_ptr<PartyReference>(new PartyReference(otherRemainingPartyNode));}
   }

   //otherRemainingPartyAccountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* otherRemainingPartyAccountNode = xmlNode->FirstChildElement("otherRemainingPartyAccount");

   if(otherRemainingPartyAccountNode){otherRemainingPartyAccountIsNull_ = false;}
   else{otherRemainingPartyAccountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- otherRemainingPartyAccountNode , address : " << otherRemainingPartyAccountNode << std::endl;
   #endif
   if(otherRemainingPartyAccountNode)
   {
      if(otherRemainingPartyAccountNode->Attribute("href") || otherRemainingPartyAccountNode->Attribute("id"))
      {
          if(otherRemainingPartyAccountNode->Attribute("id"))
          {
             otherRemainingPartyAccountIDRef_ = otherRemainingPartyAccountNode->Attribute("id");
             otherRemainingPartyAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(otherRemainingPartyAccountNode));
             otherRemainingPartyAccount_->setID(otherRemainingPartyAccountIDRef_);
             IDManager::instance().setID(otherRemainingPartyAccountIDRef_,otherRemainingPartyAccount_);
          }
          else if(otherRemainingPartyAccountNode->Attribute("href")) { otherRemainingPartyAccountIDRef_ = otherRemainingPartyAccountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { otherRemainingPartyAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(otherRemainingPartyAccountNode));}
   }

   //novationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* novationDateNode = xmlNode->FirstChildElement("novationDate");

   if(novationDateNode){novationDateIsNull_ = false;}
   else{novationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- novationDateNode , address : " << novationDateNode << std::endl;
   #endif
   if(novationDateNode)
   {
      if(novationDateNode->Attribute("href") || novationDateNode->Attribute("id"))
      {
          if(novationDateNode->Attribute("id"))
          {
             novationDateIDRef_ = novationDateNode->Attribute("id");
             novationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(novationDateNode));
             novationDate_->setID(novationDateIDRef_);
             IDManager::instance().setID(novationDateIDRef_,novationDate_);
          }
          else if(novationDateNode->Attribute("href")) { novationDateIDRef_ = novationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { novationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(novationDateNode));}
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

   //novationTradeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* novationTradeDateNode = xmlNode->FirstChildElement("novationTradeDate");

   if(novationTradeDateNode){novationTradeDateIsNull_ = false;}
   else{novationTradeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- novationTradeDateNode , address : " << novationTradeDateNode << std::endl;
   #endif
   if(novationTradeDateNode)
   {
      if(novationTradeDateNode->Attribute("href") || novationTradeDateNode->Attribute("id"))
      {
          if(novationTradeDateNode->Attribute("id"))
          {
             novationTradeDateIDRef_ = novationTradeDateNode->Attribute("id");
             novationTradeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(novationTradeDateNode));
             novationTradeDate_->setID(novationTradeDateIDRef_);
             IDManager::instance().setID(novationTradeDateIDRef_,novationTradeDate_);
          }
          else if(novationTradeDateNode->Attribute("href")) { novationTradeDateIDRef_ = novationTradeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { novationTradeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(novationTradeDateNode));}
   }

   //novatedAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* novatedAmountNode = xmlNode->FirstChildElement("novatedAmount");

   if(novatedAmountNode){novatedAmountIsNull_ = false;}
   else{novatedAmountIsNull_ = true;}

   if(novatedAmountNode)
   {
      for(novatedAmountNode; novatedAmountNode; novatedAmountNode = novatedAmountNode->NextSiblingElement("novatedAmount")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- novatedAmountNode , address : " << novatedAmountNode << std::endl;
          #endif
          if(novatedAmountNode->Attribute("href") || novatedAmountNode->Attribute("id"))
          {
              if(novatedAmountNode->Attribute("id"))
              {
                  novatedAmountIDRef_ = novatedAmountNode->Attribute("id");
                  novatedAmount_.push_back(boost::shared_ptr<Money>(new Money(novatedAmountNode)));
                  novatedAmount_.back()->setID(novatedAmountIDRef_);
                  IDManager::instance().setID(novatedAmountIDRef_, novatedAmount_.back());
              }
              else if(novatedAmountNode->Attribute("href")) { novatedAmountIDRef_ = novatedAmountNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { novatedAmount_.push_back(boost::shared_ptr<Money>(new Money(novatedAmountNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- novatedAmountNode , address : " << novatedAmountNode << std::endl;
       #endif
   }

   //remainingAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* remainingAmountNode = xmlNode->FirstChildElement("remainingAmount");

   if(remainingAmountNode){remainingAmountIsNull_ = false;}
   else{remainingAmountIsNull_ = true;}

   if(remainingAmountNode)
   {
      for(remainingAmountNode; remainingAmountNode; remainingAmountNode = remainingAmountNode->NextSiblingElement("remainingAmount")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- remainingAmountNode , address : " << remainingAmountNode << std::endl;
          #endif
          if(remainingAmountNode->Attribute("href") || remainingAmountNode->Attribute("id"))
          {
              if(remainingAmountNode->Attribute("id"))
              {
                  remainingAmountIDRef_ = remainingAmountNode->Attribute("id");
                  remainingAmount_.push_back(boost::shared_ptr<Money>(new Money(remainingAmountNode)));
                  remainingAmount_.back()->setID(remainingAmountIDRef_);
                  IDManager::instance().setID(remainingAmountIDRef_, remainingAmount_.back());
              }
              else if(remainingAmountNode->Attribute("href")) { remainingAmountIDRef_ = remainingAmountNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { remainingAmount_.push_back(boost::shared_ptr<Money>(new Money(remainingAmountNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- remainingAmountNode , address : " << remainingAmountNode << std::endl;
       #endif
   }

   //novatedNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* novatedNumberOfOptionsNode = xmlNode->FirstChildElement("novatedNumberOfOptions");

   if(novatedNumberOfOptionsNode){novatedNumberOfOptionsIsNull_ = false;}
   else{novatedNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- novatedNumberOfOptionsNode , address : " << novatedNumberOfOptionsNode << std::endl;
   #endif
   if(novatedNumberOfOptionsNode)
   {
      if(novatedNumberOfOptionsNode->Attribute("href") || novatedNumberOfOptionsNode->Attribute("id"))
      {
          if(novatedNumberOfOptionsNode->Attribute("id"))
          {
             novatedNumberOfOptionsIDRef_ = novatedNumberOfOptionsNode->Attribute("id");
             novatedNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(novatedNumberOfOptionsNode));
             novatedNumberOfOptions_->setID(novatedNumberOfOptionsIDRef_);
             IDManager::instance().setID(novatedNumberOfOptionsIDRef_,novatedNumberOfOptions_);
          }
          else if(novatedNumberOfOptionsNode->Attribute("href")) { novatedNumberOfOptionsIDRef_ = novatedNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { novatedNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(novatedNumberOfOptionsNode));}
   }

   //remainingNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* remainingNumberOfOptionsNode = xmlNode->FirstChildElement("remainingNumberOfOptions");

   if(remainingNumberOfOptionsNode){remainingNumberOfOptionsIsNull_ = false;}
   else{remainingNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- remainingNumberOfOptionsNode , address : " << remainingNumberOfOptionsNode << std::endl;
   #endif
   if(remainingNumberOfOptionsNode)
   {
      if(remainingNumberOfOptionsNode->Attribute("href") || remainingNumberOfOptionsNode->Attribute("id"))
      {
          if(remainingNumberOfOptionsNode->Attribute("id"))
          {
             remainingNumberOfOptionsIDRef_ = remainingNumberOfOptionsNode->Attribute("id");
             remainingNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(remainingNumberOfOptionsNode));
             remainingNumberOfOptions_->setID(remainingNumberOfOptionsIDRef_);
             IDManager::instance().setID(remainingNumberOfOptionsIDRef_,remainingNumberOfOptions_);
          }
          else if(remainingNumberOfOptionsNode->Attribute("href")) { remainingNumberOfOptionsIDRef_ = remainingNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { remainingNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(remainingNumberOfOptionsNode));}
   }

   //novatedNumberOfUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* novatedNumberOfUnitsNode = xmlNode->FirstChildElement("novatedNumberOfUnits");

   if(novatedNumberOfUnitsNode){novatedNumberOfUnitsIsNull_ = false;}
   else{novatedNumberOfUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- novatedNumberOfUnitsNode , address : " << novatedNumberOfUnitsNode << std::endl;
   #endif
   if(novatedNumberOfUnitsNode)
   {
      if(novatedNumberOfUnitsNode->Attribute("href") || novatedNumberOfUnitsNode->Attribute("id"))
      {
          if(novatedNumberOfUnitsNode->Attribute("id"))
          {
             novatedNumberOfUnitsIDRef_ = novatedNumberOfUnitsNode->Attribute("id");
             novatedNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(novatedNumberOfUnitsNode));
             novatedNumberOfUnits_->setID(novatedNumberOfUnitsIDRef_);
             IDManager::instance().setID(novatedNumberOfUnitsIDRef_,novatedNumberOfUnits_);
          }
          else if(novatedNumberOfUnitsNode->Attribute("href")) { novatedNumberOfUnitsIDRef_ = novatedNumberOfUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { novatedNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(novatedNumberOfUnitsNode));}
   }

   //remainingNumberOfUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* remainingNumberOfUnitsNode = xmlNode->FirstChildElement("remainingNumberOfUnits");

   if(remainingNumberOfUnitsNode){remainingNumberOfUnitsIsNull_ = false;}
   else{remainingNumberOfUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- remainingNumberOfUnitsNode , address : " << remainingNumberOfUnitsNode << std::endl;
   #endif
   if(remainingNumberOfUnitsNode)
   {
      if(remainingNumberOfUnitsNode->Attribute("href") || remainingNumberOfUnitsNode->Attribute("id"))
      {
          if(remainingNumberOfUnitsNode->Attribute("id"))
          {
             remainingNumberOfUnitsIDRef_ = remainingNumberOfUnitsNode->Attribute("id");
             remainingNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(remainingNumberOfUnitsNode));
             remainingNumberOfUnits_->setID(remainingNumberOfUnitsIDRef_);
             IDManager::instance().setID(remainingNumberOfUnitsIDRef_,remainingNumberOfUnits_);
          }
          else if(remainingNumberOfUnitsNode->Attribute("href")) { remainingNumberOfUnitsIDRef_ = remainingNumberOfUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { remainingNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(remainingNumberOfUnitsNode));}
   }

   //fullFirstCalculationPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fullFirstCalculationPeriodNode = xmlNode->FirstChildElement("fullFirstCalculationPeriod");

   if(fullFirstCalculationPeriodNode){fullFirstCalculationPeriodIsNull_ = false;}
   else{fullFirstCalculationPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fullFirstCalculationPeriodNode , address : " << fullFirstCalculationPeriodNode << std::endl;
   #endif
   if(fullFirstCalculationPeriodNode)
   {
      if(fullFirstCalculationPeriodNode->Attribute("href") || fullFirstCalculationPeriodNode->Attribute("id"))
      {
          if(fullFirstCalculationPeriodNode->Attribute("id"))
          {
             fullFirstCalculationPeriodIDRef_ = fullFirstCalculationPeriodNode->Attribute("id");
             fullFirstCalculationPeriod_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fullFirstCalculationPeriodNode));
             fullFirstCalculationPeriod_->setID(fullFirstCalculationPeriodIDRef_);
             IDManager::instance().setID(fullFirstCalculationPeriodIDRef_,fullFirstCalculationPeriod_);
          }
          else if(fullFirstCalculationPeriodNode->Attribute("href")) { fullFirstCalculationPeriodIDRef_ = fullFirstCalculationPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fullFirstCalculationPeriod_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fullFirstCalculationPeriodNode));}
   }

   //firstPeriodStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstPeriodStartDateNode = xmlNode->FirstChildElement("firstPeriodStartDate");

   if(firstPeriodStartDateNode){firstPeriodStartDateIsNull_ = false;}
   else{firstPeriodStartDateIsNull_ = true;}

   if(firstPeriodStartDateNode)
   {
      for(firstPeriodStartDateNode; firstPeriodStartDateNode; firstPeriodStartDateNode = firstPeriodStartDateNode->NextSiblingElement("firstPeriodStartDate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstPeriodStartDateNode , address : " << firstPeriodStartDateNode << std::endl;
          #endif
          if(firstPeriodStartDateNode->Attribute("href") || firstPeriodStartDateNode->Attribute("id"))
          {
              if(firstPeriodStartDateNode->Attribute("id"))
              {
                  firstPeriodStartDateIDRef_ = firstPeriodStartDateNode->Attribute("id");
                  firstPeriodStartDate_.push_back(boost::shared_ptr<FirstPeriodStartDate>(new FirstPeriodStartDate(firstPeriodStartDateNode)));
                  firstPeriodStartDate_.back()->setID(firstPeriodStartDateIDRef_);
                  IDManager::instance().setID(firstPeriodStartDateIDRef_, firstPeriodStartDate_.back());
              }
              else if(firstPeriodStartDateNode->Attribute("href")) { firstPeriodStartDateIDRef_ = firstPeriodStartDateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { firstPeriodStartDate_.push_back(boost::shared_ptr<FirstPeriodStartDate>(new FirstPeriodStartDate(firstPeriodStartDateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstPeriodStartDateNode , address : " << firstPeriodStartDateNode << std::endl;
       #endif
   }

   //nonRelianceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonRelianceNode = xmlNode->FirstChildElement("nonReliance");

   if(nonRelianceNode){nonRelianceIsNull_ = false;}
   else{nonRelianceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonRelianceNode , address : " << nonRelianceNode << std::endl;
   #endif
   if(nonRelianceNode)
   {
      if(nonRelianceNode->Attribute("href") || nonRelianceNode->Attribute("id"))
      {
          if(nonRelianceNode->Attribute("id"))
          {
             nonRelianceIDRef_ = nonRelianceNode->Attribute("id");
             nonReliance_ = boost::shared_ptr<Empty>(new Empty(nonRelianceNode));
             nonReliance_->setID(nonRelianceIDRef_);
             IDManager::instance().setID(nonRelianceIDRef_,nonReliance_);
          }
          else if(nonRelianceNode->Attribute("href")) { nonRelianceIDRef_ = nonRelianceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonReliance_ = boost::shared_ptr<Empty>(new Empty(nonRelianceNode));}
   }

   //creditDerivativesNoticesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditDerivativesNoticesNode = xmlNode->FirstChildElement("creditDerivativesNotices");

   if(creditDerivativesNoticesNode){creditDerivativesNoticesIsNull_ = false;}
   else{creditDerivativesNoticesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditDerivativesNoticesNode , address : " << creditDerivativesNoticesNode << std::endl;
   #endif
   if(creditDerivativesNoticesNode)
   {
      if(creditDerivativesNoticesNode->Attribute("href") || creditDerivativesNoticesNode->Attribute("id"))
      {
          if(creditDerivativesNoticesNode->Attribute("id"))
          {
             creditDerivativesNoticesIDRef_ = creditDerivativesNoticesNode->Attribute("id");
             creditDerivativesNotices_ = boost::shared_ptr<CreditDerivativesNotices>(new CreditDerivativesNotices(creditDerivativesNoticesNode));
             creditDerivativesNotices_->setID(creditDerivativesNoticesIDRef_);
             IDManager::instance().setID(creditDerivativesNoticesIDRef_,creditDerivativesNotices_);
          }
          else if(creditDerivativesNoticesNode->Attribute("href")) { creditDerivativesNoticesIDRef_ = creditDerivativesNoticesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditDerivativesNotices_ = boost::shared_ptr<CreditDerivativesNotices>(new CreditDerivativesNotices(creditDerivativesNoticesNode));}
   }

   //contractualDefinitionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractualDefinitionsNode = xmlNode->FirstChildElement("contractualDefinitions");

   if(contractualDefinitionsNode){contractualDefinitionsIsNull_ = false;}
   else{contractualDefinitionsIsNull_ = true;}

   if(contractualDefinitionsNode)
   {
      for(contractualDefinitionsNode; contractualDefinitionsNode; contractualDefinitionsNode = contractualDefinitionsNode->NextSiblingElement("contractualDefinitions")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualDefinitionsNode , address : " << contractualDefinitionsNode << std::endl;
          #endif
          if(contractualDefinitionsNode->Attribute("href") || contractualDefinitionsNode->Attribute("id"))
          {
              if(contractualDefinitionsNode->Attribute("id"))
              {
                  contractualDefinitionsIDRef_ = contractualDefinitionsNode->Attribute("id");
                  contractualDefinitions_.push_back(boost::shared_ptr<ContractualDefinitions>(new ContractualDefinitions(contractualDefinitionsNode)));
                  contractualDefinitions_.back()->setID(contractualDefinitionsIDRef_);
                  IDManager::instance().setID(contractualDefinitionsIDRef_, contractualDefinitions_.back());
              }
              else if(contractualDefinitionsNode->Attribute("href")) { contractualDefinitionsIDRef_ = contractualDefinitionsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { contractualDefinitions_.push_back(boost::shared_ptr<ContractualDefinitions>(new ContractualDefinitions(contractualDefinitionsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualDefinitionsNode , address : " << contractualDefinitionsNode << std::endl;
       #endif
   }

   //contractualTermsSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractualTermsSupplementNode = xmlNode->FirstChildElement("contractualTermsSupplement");

   if(contractualTermsSupplementNode){contractualTermsSupplementIsNull_ = false;}
   else{contractualTermsSupplementIsNull_ = true;}

   if(contractualTermsSupplementNode)
   {
      for(contractualTermsSupplementNode; contractualTermsSupplementNode; contractualTermsSupplementNode = contractualTermsSupplementNode->NextSiblingElement("contractualTermsSupplement")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualTermsSupplementNode , address : " << contractualTermsSupplementNode << std::endl;
          #endif
          if(contractualTermsSupplementNode->Attribute("href") || contractualTermsSupplementNode->Attribute("id"))
          {
              if(contractualTermsSupplementNode->Attribute("id"))
              {
                  contractualTermsSupplementIDRef_ = contractualTermsSupplementNode->Attribute("id");
                  contractualTermsSupplement_.push_back(boost::shared_ptr<ContractualTermsSupplement>(new ContractualTermsSupplement(contractualTermsSupplementNode)));
                  contractualTermsSupplement_.back()->setID(contractualTermsSupplementIDRef_);
                  IDManager::instance().setID(contractualTermsSupplementIDRef_, contractualTermsSupplement_.back());
              }
              else if(contractualTermsSupplementNode->Attribute("href")) { contractualTermsSupplementIDRef_ = contractualTermsSupplementNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { contractualTermsSupplement_.push_back(boost::shared_ptr<ContractualTermsSupplement>(new ContractualTermsSupplement(contractualTermsSupplementNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualTermsSupplementNode , address : " << contractualTermsSupplementNode << std::endl;
       #endif
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
std::vector<boost::shared_ptr<PartyTradeIdentifier>> TradeNovationContent::getNewTradeIdentifier()
{
   if(!this->newTradeIdentifierIsNull_){
        if(newTradeIdentifierIDRef_ != ""){
             return this->newTradeIdentifier_;
        }else{
             return this->newTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
boost::shared_ptr<Trade> TradeNovationContent::getNewTrade()
{
   if(!this->newTradeIsNull_){
        if(newTradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(newTradeIDRef_));
        }else{
             return this->newTrade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> TradeNovationContent::getOldTradeIdentifier()
{
   if(!this->oldTradeIdentifierIsNull_){
        if(oldTradeIdentifierIDRef_ != ""){
             return this->oldTradeIdentifier_;
        }else{
             return this->oldTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
boost::shared_ptr<Trade> TradeNovationContent::getOldTrade()
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
boost::shared_ptr<PartyTradeIdentifier> TradeNovationContent::getFeeTradeIdentifier()
{
   if(!this->feeTradeIdentifierIsNull_){
        if(feeTradeIdentifierIDRef_ != ""){
             return boost::shared_static_cast<PartyTradeIdentifier>(IDManager::instance().getID(feeTradeIdentifierIDRef_));
        }else{
             return this->feeTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyTradeIdentifier>();
   }
}
boost::shared_ptr<Trade> TradeNovationContent::getFeeTrade()
{
   if(!this->feeTradeIsNull_){
        if(feeTradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(feeTradeIDRef_));
        }else{
             return this->feeTrade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
boost::shared_ptr<PartyReference> TradeNovationContent::getTransferor()
{
   if(!this->transferorIsNull_){
        if(transferorIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(transferorIDRef_));
        }else{
             return this->transferor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> TradeNovationContent::getTransferorAccount()
{
   if(!this->transferorAccountIsNull_){
        if(transferorAccountIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(transferorAccountIDRef_));
        }else{
             return this->transferorAccount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> TradeNovationContent::getTransferee()
{
   if(!this->transfereeIsNull_){
        if(transfereeIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(transfereeIDRef_));
        }else{
             return this->transferee_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<PartyReference> TradeNovationContent::getOtherTransferee()
{
   if(!this->otherTransfereeIsNull_){
        if(otherTransfereeIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(otherTransfereeIDRef_));
        }else{
             return this->otherTransferee_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> TradeNovationContent::getTransfereeAccount()
{
   if(!this->transfereeAccountIsNull_){
        if(transfereeAccountIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(transfereeAccountIDRef_));
        }else{
             return this->transfereeAccount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<AccountReference> TradeNovationContent::getOtherTransfereeAccount()
{
   if(!this->otherTransfereeAccountIsNull_){
        if(otherTransfereeAccountIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(otherTransfereeAccountIDRef_));
        }else{
             return this->otherTransfereeAccount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> TradeNovationContent::getRemainingParty()
{
   if(!this->remainingPartyIsNull_){
        if(remainingPartyIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(remainingPartyIDRef_));
        }else{
             return this->remainingParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> TradeNovationContent::getRemainingPartyAccount()
{
   if(!this->remainingPartyAccountIsNull_){
        if(remainingPartyAccountIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(remainingPartyAccountIDRef_));
        }else{
             return this->remainingPartyAccount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> TradeNovationContent::getOtherRemainingParty()
{
   if(!this->otherRemainingPartyIsNull_){
        if(otherRemainingPartyIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(otherRemainingPartyIDRef_));
        }else{
             return this->otherRemainingParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> TradeNovationContent::getOtherRemainingPartyAccount()
{
   if(!this->otherRemainingPartyAccountIsNull_){
        if(otherRemainingPartyAccountIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(otherRemainingPartyAccountIDRef_));
        }else{
             return this->otherRemainingPartyAccount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<XsdTypeDate> TradeNovationContent::getNovationDate()
{
   if(!this->novationDateIsNull_){
        if(novationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(novationDateIDRef_));
        }else{
             return this->novationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<ExecutionDateTime> TradeNovationContent::getExecutionDateTime()
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
boost::shared_ptr<XsdTypeDate> TradeNovationContent::getNovationTradeDate()
{
   if(!this->novationTradeDateIsNull_){
        if(novationTradeDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(novationTradeDateIDRef_));
        }else{
             return this->novationTradeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
std::vector<boost::shared_ptr<Money>> TradeNovationContent::getNovatedAmount()
{
   if(!this->novatedAmountIsNull_){
        if(novatedAmountIDRef_ != ""){
             return this->novatedAmount_;
        }else{
             return this->novatedAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Money>>();
   }
}
std::vector<boost::shared_ptr<Money>> TradeNovationContent::getRemainingAmount()
{
   if(!this->remainingAmountIsNull_){
        if(remainingAmountIDRef_ != ""){
             return this->remainingAmount_;
        }else{
             return this->remainingAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Money>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TradeNovationContent::getNovatedNumberOfOptions()
{
   if(!this->novatedNumberOfOptionsIsNull_){
        if(novatedNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(novatedNumberOfOptionsIDRef_));
        }else{
             return this->novatedNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TradeNovationContent::getRemainingNumberOfOptions()
{
   if(!this->remainingNumberOfOptionsIsNull_){
        if(remainingNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(remainingNumberOfOptionsIDRef_));
        }else{
             return this->remainingNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TradeNovationContent::getNovatedNumberOfUnits()
{
   if(!this->novatedNumberOfUnitsIsNull_){
        if(novatedNumberOfUnitsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(novatedNumberOfUnitsIDRef_));
        }else{
             return this->novatedNumberOfUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TradeNovationContent::getRemainingNumberOfUnits()
{
   if(!this->remainingNumberOfUnitsIsNull_){
        if(remainingNumberOfUnitsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(remainingNumberOfUnitsIDRef_));
        }else{
             return this->remainingNumberOfUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> TradeNovationContent::getFullFirstCalculationPeriod()
{
   if(!this->fullFirstCalculationPeriodIsNull_){
        if(fullFirstCalculationPeriodIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(fullFirstCalculationPeriodIDRef_));
        }else{
             return this->fullFirstCalculationPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
std::vector<boost::shared_ptr<FirstPeriodStartDate>> TradeNovationContent::getFirstPeriodStartDate()
{
   if(!this->firstPeriodStartDateIsNull_){
        if(firstPeriodStartDateIDRef_ != ""){
             return this->firstPeriodStartDate_;
        }else{
             return this->firstPeriodStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FirstPeriodStartDate>>();
   }
}
boost::shared_ptr<Empty> TradeNovationContent::getNonReliance()
{
   if(!this->nonRelianceIsNull_){
        if(nonRelianceIDRef_ != ""){
             return boost::shared_static_cast<Empty>(IDManager::instance().getID(nonRelianceIDRef_));
        }else{
             return this->nonReliance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Empty>();
   }
}
boost::shared_ptr<CreditDerivativesNotices> TradeNovationContent::getCreditDerivativesNotices()
{
   if(!this->creditDerivativesNoticesIsNull_){
        if(creditDerivativesNoticesIDRef_ != ""){
             return boost::shared_static_cast<CreditDerivativesNotices>(IDManager::instance().getID(creditDerivativesNoticesIDRef_));
        }else{
             return this->creditDerivativesNotices_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditDerivativesNotices>();
   }
}
std::vector<boost::shared_ptr<ContractualDefinitions>> TradeNovationContent::getContractualDefinitions()
{
   if(!this->contractualDefinitionsIsNull_){
        if(contractualDefinitionsIDRef_ != ""){
             return this->contractualDefinitions_;
        }else{
             return this->contractualDefinitions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ContractualDefinitions>>();
   }
}
std::vector<boost::shared_ptr<ContractualTermsSupplement>> TradeNovationContent::getContractualTermsSupplement()
{
   if(!this->contractualTermsSupplementIsNull_){
        if(contractualTermsSupplementIDRef_ != ""){
             return this->contractualTermsSupplement_;
        }else{
             return this->contractualTermsSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ContractualTermsSupplement>>();
   }
}
boost::shared_ptr<Payment> TradeNovationContent::getPayment()
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

