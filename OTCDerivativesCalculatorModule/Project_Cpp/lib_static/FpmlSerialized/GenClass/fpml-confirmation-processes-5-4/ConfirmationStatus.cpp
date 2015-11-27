// ConfirmationStatus.cpp 
#include "ConfirmationStatus.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ConfirmationStatus::ConfirmationStatus(TiXmlNode* xmlNode)
: ResponseMessage(xmlNode)
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
             status_ = boost::shared_ptr<EventStatus>(new EventStatus(statusNode));
             status_->setID(statusIDRef_);
             IDManager::instance().setID(statusIDRef_,status_);
          }
          else if(statusNode->Attribute("href")) { statusIDRef_ = statusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { status_ = boost::shared_ptr<EventStatus>(new EventStatus(statusNode));}
   }

   //assertedEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* assertedEventNode = xmlNode->FirstChildElement("assertedEvent");

   if(assertedEventNode){assertedEventIsNull_ = false;}
   else{assertedEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- assertedEventNode , address : " << assertedEventNode << std::endl;
   #endif
   if(assertedEventNode)
   {
      if(assertedEventNode->Attribute("href") || assertedEventNode->Attribute("id"))
      {
          if(assertedEventNode->Attribute("id"))
          {
             assertedEventIDRef_ = assertedEventNode->Attribute("id");
             assertedEvent_ = boost::shared_ptr<EventsChoice>(new EventsChoice(assertedEventNode));
             assertedEvent_->setID(assertedEventIDRef_);
             IDManager::instance().setID(assertedEventIDRef_,assertedEvent_);
          }
          else if(assertedEventNode->Attribute("href")) { assertedEventIDRef_ = assertedEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { assertedEvent_ = boost::shared_ptr<EventsChoice>(new EventsChoice(assertedEventNode));}
   }

   //proposedMatchNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* proposedMatchNode = xmlNode->FirstChildElement("proposedMatch");

   if(proposedMatchNode){proposedMatchIsNull_ = false;}
   else{proposedMatchIsNull_ = true;}

   if(proposedMatchNode)
   {
      for(proposedMatchNode; proposedMatchNode; proposedMatchNode = proposedMatchNode->NextSiblingElement("proposedMatch")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- proposedMatchNode , address : " << proposedMatchNode << std::endl;
          #endif
          if(proposedMatchNode->Attribute("href") || proposedMatchNode->Attribute("id"))
          {
              if(proposedMatchNode->Attribute("id"))
              {
                  proposedMatchIDRef_ = proposedMatchNode->Attribute("id");
                  proposedMatch_.push_back(boost::shared_ptr<EventProposedMatch>(new EventProposedMatch(proposedMatchNode)));
                  proposedMatch_.back()->setID(proposedMatchIDRef_);
                  IDManager::instance().setID(proposedMatchIDRef_, proposedMatch_.back());
              }
              else if(proposedMatchNode->Attribute("href")) { proposedMatchIDRef_ = proposedMatchNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { proposedMatch_.push_back(boost::shared_ptr<EventProposedMatch>(new EventProposedMatch(proposedMatchNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- proposedMatchNode , address : " << proposedMatchNode << std::endl;
       #endif
   }

   //allegedEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allegedEventNode = xmlNode->FirstChildElement("allegedEvent");

   if(allegedEventNode){allegedEventIsNull_ = false;}
   else{allegedEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allegedEventNode , address : " << allegedEventNode << std::endl;
   #endif
   if(allegedEventNode)
   {
      if(allegedEventNode->Attribute("href") || allegedEventNode->Attribute("id"))
      {
          if(allegedEventNode->Attribute("id"))
          {
             allegedEventIDRef_ = allegedEventNode->Attribute("id");
             allegedEvent_ = boost::shared_ptr<EventsChoice>(new EventsChoice(allegedEventNode));
             allegedEvent_->setID(allegedEventIDRef_);
             IDManager::instance().setID(allegedEventIDRef_,allegedEvent_);
          }
          else if(allegedEventNode->Attribute("href")) { allegedEventIDRef_ = allegedEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allegedEvent_ = boost::shared_ptr<EventsChoice>(new EventsChoice(allegedEventNode));}
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
boost::shared_ptr<EventStatus> ConfirmationStatus::getStatus()
{
   if(!this->statusIsNull_){
        if(statusIDRef_ != ""){
             return boost::shared_static_cast<EventStatus>(IDManager::instance().getID(statusIDRef_));
        }else{
             return this->status_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventStatus>();
   }
}
boost::shared_ptr<EventsChoice> ConfirmationStatus::getAssertedEvent()
{
   if(!this->assertedEventIsNull_){
        if(assertedEventIDRef_ != ""){
             return boost::shared_static_cast<EventsChoice>(IDManager::instance().getID(assertedEventIDRef_));
        }else{
             return this->assertedEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventsChoice>();
   }
}
std::vector<boost::shared_ptr<EventProposedMatch>> ConfirmationStatus::getProposedMatch()
{
   if(!this->proposedMatchIsNull_){
        if(proposedMatchIDRef_ != ""){
             return this->proposedMatch_;
        }else{
             return this->proposedMatch_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventProposedMatch>>();
   }
}
boost::shared_ptr<EventsChoice> ConfirmationStatus::getAllegedEvent()
{
   if(!this->allegedEventIsNull_){
        if(allegedEventIDRef_ != ""){
             return boost::shared_static_cast<EventsChoice>(IDManager::instance().getID(allegedEventIDRef_));
        }else{
             return this->allegedEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventsChoice>();
   }
}
std::vector<boost::shared_ptr<Party>> ConfirmationStatus::getParty()
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
std::vector<boost::shared_ptr<Account>> ConfirmationStatus::getAccount()
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

