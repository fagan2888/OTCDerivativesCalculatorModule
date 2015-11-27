// MaturityNotification.cpp 
#include "MaturityNotification.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MaturityNotification::MaturityNotification(TiXmlNode* xmlNode)
: CorrectableRequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //optionExpiryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionExpiryNode = xmlNode->FirstChildElement("optionExpiry");

   if(optionExpiryNode){optionExpiryIsNull_ = false;}
   else{optionExpiryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionExpiryNode , address : " << optionExpiryNode << std::endl;
   #endif
   if(optionExpiryNode)
   {
      if(optionExpiryNode->Attribute("href") || optionExpiryNode->Attribute("id"))
      {
          if(optionExpiryNode->Attribute("id"))
          {
             optionExpiryIDRef_ = optionExpiryNode->Attribute("id");
             optionExpiry_ = boost::shared_ptr<OptionExpiryBase>(new OptionExpiryBase(optionExpiryNode));
             optionExpiry_->setID(optionExpiryIDRef_);
             IDManager::instance().setID(optionExpiryIDRef_,optionExpiry_);
          }
          else if(optionExpiryNode->Attribute("href")) { optionExpiryIDRef_ = optionExpiryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionExpiry_ = boost::shared_ptr<OptionExpiryBase>(new OptionExpiryBase(optionExpiryNode));}
   }

   //tradeMaturityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeMaturityNode = xmlNode->FirstChildElement("tradeMaturity");

   if(tradeMaturityNode){tradeMaturityIsNull_ = false;}
   else{tradeMaturityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeMaturityNode , address : " << tradeMaturityNode << std::endl;
   #endif
   if(tradeMaturityNode)
   {
      if(tradeMaturityNode->Attribute("href") || tradeMaturityNode->Attribute("id"))
      {
          if(tradeMaturityNode->Attribute("id"))
          {
             tradeMaturityIDRef_ = tradeMaturityNode->Attribute("id");
             tradeMaturity_ = boost::shared_ptr<TradeMaturity>(new TradeMaturity(tradeMaturityNode));
             tradeMaturity_->setID(tradeMaturityIDRef_);
             IDManager::instance().setID(tradeMaturityIDRef_,tradeMaturity_);
          }
          else if(tradeMaturityNode->Attribute("href")) { tradeMaturityIDRef_ = tradeMaturityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeMaturity_ = boost::shared_ptr<TradeMaturity>(new TradeMaturity(tradeMaturityNode));}
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
boost::shared_ptr<OptionExpiryBase> MaturityNotification::getOptionExpiry()
{
   if(!this->optionExpiryIsNull_){
        if(optionExpiryIDRef_ != ""){
             return boost::shared_static_cast<OptionExpiryBase>(IDManager::instance().getID(optionExpiryIDRef_));
        }else{
             return this->optionExpiry_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionExpiryBase>();
   }
}
boost::shared_ptr<TradeMaturity> MaturityNotification::getTradeMaturity()
{
   if(!this->tradeMaturityIsNull_){
        if(tradeMaturityIDRef_ != ""){
             return boost::shared_static_cast<TradeMaturity>(IDManager::instance().getID(tradeMaturityIDRef_));
        }else{
             return this->tradeMaturity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeMaturity>();
   }
}
std::vector<boost::shared_ptr<Party>> MaturityNotification::getParty()
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
std::vector<boost::shared_ptr<Account>> MaturityNotification::getAccount()
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

