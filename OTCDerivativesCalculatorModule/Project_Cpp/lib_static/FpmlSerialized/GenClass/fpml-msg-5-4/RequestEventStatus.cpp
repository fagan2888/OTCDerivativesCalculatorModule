// RequestEventStatus.cpp 
#include "RequestEventStatus.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RequestEventStatus::RequestEventStatus(TiXmlNode* xmlNode)
: NonCorrectableRequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessProcessNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessProcessNode = xmlNode->FirstChildElement("businessProcess");

   if(businessProcessNode){businessProcessIsNull_ = false;}
   else{businessProcessIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessProcessNode , address : " << businessProcessNode << std::endl;
   #endif
   if(businessProcessNode)
   {
      if(businessProcessNode->Attribute("href") || businessProcessNode->Attribute("id"))
      {
          if(businessProcessNode->Attribute("id"))
          {
             businessProcessIDRef_ = businessProcessNode->Attribute("id");
             businessProcess_ = boost::shared_ptr<BusinessProcess>(new BusinessProcess(businessProcessNode));
             businessProcess_->setID(businessProcessIDRef_);
             IDManager::instance().setID(businessProcessIDRef_,businessProcess_);
          }
          else if(businessProcessNode->Attribute("href")) { businessProcessIDRef_ = businessProcessNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessProcess_ = boost::shared_ptr<BusinessProcess>(new BusinessProcess(businessProcessNode));}
   }

   //eventIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventIdentifierNode = xmlNode->FirstChildElement("eventIdentifier");

   if(eventIdentifierNode){eventIdentifierIsNull_ = false;}
   else{eventIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventIdentifierNode , address : " << eventIdentifierNode << std::endl;
   #endif
   if(eventIdentifierNode)
   {
      if(eventIdentifierNode->Attribute("href") || eventIdentifierNode->Attribute("id"))
      {
          if(eventIdentifierNode->Attribute("id"))
          {
             eventIdentifierIDRef_ = eventIdentifierNode->Attribute("id");
             eventIdentifier_ = boost::shared_ptr<EventIdentifier>(new EventIdentifier(eventIdentifierNode));
             eventIdentifier_->setID(eventIdentifierIDRef_);
             IDManager::instance().setID(eventIdentifierIDRef_,eventIdentifier_);
          }
          else if(eventIdentifierNode->Attribute("href")) { eventIdentifierIDRef_ = eventIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventIdentifier_ = boost::shared_ptr<EventIdentifier>(new EventIdentifier(eventIdentifierNode));}
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
boost::shared_ptr<BusinessProcess> RequestEventStatus::getBusinessProcess()
{
   if(!this->businessProcessIsNull_){
        if(businessProcessIDRef_ != ""){
             return boost::shared_static_cast<BusinessProcess>(IDManager::instance().getID(businessProcessIDRef_));
        }else{
             return this->businessProcess_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessProcess>();
   }
}
boost::shared_ptr<EventIdentifier> RequestEventStatus::getEventIdentifier()
{
   if(!this->eventIdentifierIsNull_){
        if(eventIdentifierIDRef_ != ""){
             return boost::shared_static_cast<EventIdentifier>(IDManager::instance().getID(eventIdentifierIDRef_));
        }else{
             return this->eventIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventIdentifier>();
   }
}
std::vector<boost::shared_ptr<Party>> RequestEventStatus::getParty()
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
std::vector<boost::shared_ptr<Account>> RequestEventStatus::getAccount()
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

