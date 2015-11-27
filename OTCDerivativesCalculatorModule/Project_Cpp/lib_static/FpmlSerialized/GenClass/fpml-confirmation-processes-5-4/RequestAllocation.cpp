// RequestAllocation.cpp 
#include "RequestAllocation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RequestAllocation::RequestAllocation(TiXmlNode* xmlNode)
: CorrectableRequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //relatedPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relatedPartyNode = xmlNode->FirstChildElement("relatedParty");

   if(relatedPartyNode){relatedPartyIsNull_ = false;}
   else{relatedPartyIsNull_ = true;}

   if(relatedPartyNode)
   {
      for(relatedPartyNode; relatedPartyNode; relatedPartyNode = relatedPartyNode->NextSiblingElement("relatedParty")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedPartyNode , address : " << relatedPartyNode << std::endl;
          #endif
          if(relatedPartyNode->Attribute("href") || relatedPartyNode->Attribute("id"))
          {
              if(relatedPartyNode->Attribute("id"))
              {
                  relatedPartyIDRef_ = relatedPartyNode->Attribute("id");
                  relatedParty_.push_back(boost::shared_ptr<RelatedParty>(new RelatedParty(relatedPartyNode)));
                  relatedParty_.back()->setID(relatedPartyIDRef_);
                  IDManager::instance().setID(relatedPartyIDRef_, relatedParty_.back());
              }
              else if(relatedPartyNode->Attribute("href")) { relatedPartyIDRef_ = relatedPartyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { relatedParty_.push_back(boost::shared_ptr<RelatedParty>(new RelatedParty(relatedPartyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedPartyNode , address : " << relatedPartyNode << std::endl;
       #endif
   }

   //blockTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* blockTradeIdentifierNode = xmlNode->FirstChildElement("blockTradeIdentifier");

   if(blockTradeIdentifierNode){blockTradeIdentifierIsNull_ = false;}
   else{blockTradeIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- blockTradeIdentifierNode , address : " << blockTradeIdentifierNode << std::endl;
   #endif
   if(blockTradeIdentifierNode)
   {
      if(blockTradeIdentifierNode->Attribute("href") || blockTradeIdentifierNode->Attribute("id"))
      {
          if(blockTradeIdentifierNode->Attribute("id"))
          {
             blockTradeIdentifierIDRef_ = blockTradeIdentifierNode->Attribute("id");
             blockTradeIdentifier_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(blockTradeIdentifierNode));
             blockTradeIdentifier_->setID(blockTradeIdentifierIDRef_);
             IDManager::instance().setID(blockTradeIdentifierIDRef_,blockTradeIdentifier_);
          }
          else if(blockTradeIdentifierNode->Attribute("href")) { blockTradeIdentifierIDRef_ = blockTradeIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { blockTradeIdentifier_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(blockTradeIdentifierNode));}
   }

   //allocationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationsNode = xmlNode->FirstChildElement("allocations");

   if(allocationsNode){allocationsIsNull_ = false;}
   else{allocationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationsNode , address : " << allocationsNode << std::endl;
   #endif
   if(allocationsNode)
   {
      if(allocationsNode->Attribute("href") || allocationsNode->Attribute("id"))
      {
          if(allocationsNode->Attribute("id"))
          {
             allocationsIDRef_ = allocationsNode->Attribute("id");
             allocations_ = boost::shared_ptr<Allocations>(new Allocations(allocationsNode));
             allocations_->setID(allocationsIDRef_);
             IDManager::instance().setID(allocationsIDRef_,allocations_);
          }
          else if(allocationsNode->Attribute("href")) { allocationsIDRef_ = allocationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocations_ = boost::shared_ptr<Allocations>(new Allocations(allocationsNode));}
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
std::vector<boost::shared_ptr<RelatedParty>> RequestAllocation::getRelatedParty()
{
   if(!this->relatedPartyIsNull_){
        if(relatedPartyIDRef_ != ""){
             return this->relatedParty_;
        }else{
             return this->relatedParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RelatedParty>>();
   }
}
boost::shared_ptr<TradeIdentifier> RequestAllocation::getBlockTradeIdentifier()
{
   if(!this->blockTradeIdentifierIsNull_){
        if(blockTradeIdentifierIDRef_ != ""){
             return boost::shared_static_cast<TradeIdentifier>(IDManager::instance().getID(blockTradeIdentifierIDRef_));
        }else{
             return this->blockTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeIdentifier>();
   }
}
boost::shared_ptr<Allocations> RequestAllocation::getAllocations()
{
   if(!this->allocationsIsNull_){
        if(allocationsIDRef_ != ""){
             return boost::shared_static_cast<Allocations>(IDManager::instance().getID(allocationsIDRef_));
        }else{
             return this->allocations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Allocations>();
   }
}
std::vector<boost::shared_ptr<Party>> RequestAllocation::getParty()
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
std::vector<boost::shared_ptr<Account>> RequestAllocation::getAccount()
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

