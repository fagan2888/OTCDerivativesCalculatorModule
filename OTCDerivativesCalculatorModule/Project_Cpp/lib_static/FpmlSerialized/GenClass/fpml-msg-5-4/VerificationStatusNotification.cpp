// VerificationStatusNotification.cpp 
#include "VerificationStatusNotification.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VerificationStatusNotification::VerificationStatusNotification(TiXmlNode* xmlNode)
: NonCorrectableRequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //statusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* statusNode = xmlNode->FirstChildElement("status");

   if(statusNode){statusIsNull_ = false;}
   else{statusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusNode , address : " << statusNode << std::endl;
   #endif
   if(statusNode)
   {
      if(statusNode->Attribute("href") || statusNode->Attribute("id"))
      {
          if(statusNode->Attribute("id"))
          {
             statusIDRef_ = statusNode->Attribute("id");
             status_ = boost::shared_ptr<VerificationStatus>(new VerificationStatus(statusNode));
             status_->setID(statusIDRef_);
             IDManager::instance().setID(statusIDRef_,status_);
          }
          else if(statusNode->Attribute("href")) { statusIDRef_ = statusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { status_ = boost::shared_ptr<VerificationStatus>(new VerificationStatus(statusNode));}
   }

   //reasonNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reasonNode = xmlNode->FirstChildElement("reason");

   if(reasonNode){reasonIsNull_ = false;}
   else{reasonIsNull_ = true;}

   if(reasonNode)
   {
      for(reasonNode; reasonNode; reasonNode = reasonNode->NextSiblingElement("reason")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
          #endif
          if(reasonNode->Attribute("href") || reasonNode->Attribute("id"))
          {
              if(reasonNode->Attribute("id"))
              {
                  reasonIDRef_ = reasonNode->Attribute("id");
                  reason_.push_back(boost::shared_ptr<Reason>(new Reason(reasonNode)));
                  reason_.back()->setID(reasonIDRef_);
                  IDManager::instance().setID(reasonIDRef_, reason_.back());
              }
              else if(reasonNode->Attribute("href")) { reasonIDRef_ = reasonNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { reason_.push_back(boost::shared_ptr<Reason>(new Reason(reasonNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
       #endif
   }

   //partyTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyTradeIdentifierNode = xmlNode->FirstChildElement("partyTradeIdentifier");

   if(partyTradeIdentifierNode){partyTradeIdentifierIsNull_ = false;}
   else{partyTradeIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeIdentifierNode , address : " << partyTradeIdentifierNode << std::endl;
   #endif
   if(partyTradeIdentifierNode)
   {
      if(partyTradeIdentifierNode->Attribute("href") || partyTradeIdentifierNode->Attribute("id"))
      {
          if(partyTradeIdentifierNode->Attribute("id"))
          {
             partyTradeIdentifierIDRef_ = partyTradeIdentifierNode->Attribute("id");
             partyTradeIdentifier_ = boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(partyTradeIdentifierNode));
             partyTradeIdentifier_->setID(partyTradeIdentifierIDRef_);
             IDManager::instance().setID(partyTradeIdentifierIDRef_,partyTradeIdentifier_);
          }
          else if(partyTradeIdentifierNode->Attribute("href")) { partyTradeIdentifierIDRef_ = partyTradeIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyTradeIdentifier_ = boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(partyTradeIdentifierNode));}
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
boost::shared_ptr<VerificationStatus> VerificationStatusNotification::getStatus()
{
   if(!this->statusIsNull_){
        if(statusIDRef_ != ""){
             return boost::shared_static_cast<VerificationStatus>(IDManager::instance().getID(statusIDRef_));
        }else{
             return this->status_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VerificationStatus>();
   }
}
std::vector<boost::shared_ptr<Reason>> VerificationStatusNotification::getReason()
{
   if(!this->reasonIsNull_){
        if(reasonIDRef_ != ""){
             return this->reason_;
        }else{
             return this->reason_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Reason>>();
   }
}
boost::shared_ptr<PartyTradeIdentifier> VerificationStatusNotification::getPartyTradeIdentifier()
{
   if(!this->partyTradeIdentifierIsNull_){
        if(partyTradeIdentifierIDRef_ != ""){
             return boost::shared_static_cast<PartyTradeIdentifier>(IDManager::instance().getID(partyTradeIdentifierIDRef_));
        }else{
             return this->partyTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyTradeIdentifier>();
   }
}
std::vector<boost::shared_ptr<Party>> VerificationStatusNotification::getParty()
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
std::vector<boost::shared_ptr<Account>> VerificationStatusNotification::getAccount()
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

