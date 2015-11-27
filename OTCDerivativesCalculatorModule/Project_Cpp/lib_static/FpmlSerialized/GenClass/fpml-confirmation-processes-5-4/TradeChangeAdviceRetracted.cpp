// TradeChangeAdviceRetracted.cpp 
#include "TradeChangeAdviceRetracted.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeChangeAdviceRetracted::TradeChangeAdviceRetracted(TiXmlNode* xmlNode)
: NonCorrectableRequestMessage(xmlNode)
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

   //changeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* changeNode = xmlNode->FirstChildElement("change");

   if(changeNode){changeIsNull_ = false;}
   else{changeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- changeNode , address : " << changeNode << std::endl;
   #endif
   if(changeNode)
   {
      if(changeNode->Attribute("href") || changeNode->Attribute("id"))
      {
          if(changeNode->Attribute("id"))
          {
             changeIDRef_ = changeNode->Attribute("id");
             change_ = boost::shared_ptr<TradeChangeContent>(new TradeChangeContent(changeNode));
             change_->setID(changeIDRef_);
             IDManager::instance().setID(changeIDRef_,change_);
          }
          else if(changeNode->Attribute("href")) { changeIDRef_ = changeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { change_ = boost::shared_ptr<TradeChangeContent>(new TradeChangeContent(changeNode));}
   }

   //paymentDetailsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDetailsNode = xmlNode->FirstChildElement("paymentDetails");

   if(paymentDetailsNode){paymentDetailsIsNull_ = false;}
   else{paymentDetailsIsNull_ = true;}

   if(paymentDetailsNode)
   {
      for(paymentDetailsNode; paymentDetailsNode; paymentDetailsNode = paymentDetailsNode->NextSiblingElement("paymentDetails")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDetailsNode , address : " << paymentDetailsNode << std::endl;
          #endif
          if(paymentDetailsNode->Attribute("href") || paymentDetailsNode->Attribute("id"))
          {
              if(paymentDetailsNode->Attribute("id"))
              {
                  paymentDetailsIDRef_ = paymentDetailsNode->Attribute("id");
                  paymentDetails_.push_back(boost::shared_ptr<PaymentDetails>(new PaymentDetails(paymentDetailsNode)));
                  paymentDetails_.back()->setID(paymentDetailsIDRef_);
                  IDManager::instance().setID(paymentDetailsIDRef_, paymentDetails_.back());
              }
              else if(paymentDetailsNode->Attribute("href")) { paymentDetailsIDRef_ = paymentDetailsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { paymentDetails_.push_back(boost::shared_ptr<PaymentDetails>(new PaymentDetails(paymentDetailsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDetailsNode , address : " << paymentDetailsNode << std::endl;
       #endif
   }

   //partyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyNode = xmlNode->FirstChildElement("party");

   if(partyNode){partyIsNull_ = false;}
   else{partyIsNull_ = true;}

   if(partyNode)
   {
      for(partyNode; partyNode; partyNode = partyNode->NextSiblingElement("party")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNode , address : " << partyNode << std::endl;
          #endif
          if(partyNode->Attribute("href") || partyNode->Attribute("id"))
          {
              if(partyNode->Attribute("id"))
              {
                  partyIDRef_ = partyNode->Attribute("id");
                  party_.push_back(boost::shared_ptr<Party>(new Party(partyNode)));
                  party_.back()->setID(partyIDRef_);
                  IDManager::instance().setID(partyIDRef_, party_.back());
              }
              else if(partyNode->Attribute("href")) { partyIDRef_ = partyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { party_.push_back(boost::shared_ptr<Party>(new Party(partyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNode , address : " << partyNode << std::endl;
       #endif
   }

   //accountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountNode = xmlNode->FirstChildElement("account");

   if(accountNode){accountIsNull_ = false;}
   else{accountIsNull_ = true;}

   if(accountNode)
   {
      for(accountNode; accountNode; accountNode = accountNode->NextSiblingElement("account")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountNode , address : " << accountNode << std::endl;
          #endif
          if(accountNode->Attribute("href") || accountNode->Attribute("id"))
          {
              if(accountNode->Attribute("id"))
              {
                  accountIDRef_ = accountNode->Attribute("id");
                  account_.push_back(boost::shared_ptr<Account>(new Account(accountNode)));
                  account_.back()->setID(accountIDRef_);
                  IDManager::instance().setID(accountIDRef_, account_.back());
              }
              else if(accountNode->Attribute("href")) { accountIDRef_ = accountNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { account_.push_back(boost::shared_ptr<Account>(new Account(accountNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountNode , address : " << accountNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> TradeChangeAdviceRetracted::getTradeIdentifier()
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
boost::shared_ptr<TradeChangeContent> TradeChangeAdviceRetracted::getChange()
{
   if(!this->changeIsNull_){
        if(changeIDRef_ != ""){
             return boost::shared_static_cast<TradeChangeContent>(IDManager::instance().getID(changeIDRef_));
        }else{
             return this->change_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeChangeContent>();
   }
}
std::vector<boost::shared_ptr<PaymentDetails>> TradeChangeAdviceRetracted::getPaymentDetails()
{
   if(!this->paymentDetailsIsNull_){
        if(paymentDetailsIDRef_ != ""){
             return this->paymentDetails_;
        }else{
             return this->paymentDetails_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PaymentDetails>>();
   }
}
std::vector<boost::shared_ptr<Party>> TradeChangeAdviceRetracted::getParty()
{
   if(!this->partyIsNull_){
        if(partyIDRef_ != ""){
             return this->party_;
        }else{
             return this->party_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Party>>();
   }
}
std::vector<boost::shared_ptr<Account>> TradeChangeAdviceRetracted::getAccount()
{
   if(!this->accountIsNull_){
        if(accountIDRef_ != ""){
             return this->account_;
        }else{
             return this->account_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Account>>();
   }
}
}

