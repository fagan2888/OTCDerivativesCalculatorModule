// EventStatusResponse.cpp 
#include "EventStatusResponse.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventStatusResponse::EventStatusResponse(TiXmlNode* xmlNode)
: ResponseMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //statusItemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* statusItemNode = xmlNode->FirstChildElement("statusItem");

   if(statusItemNode){statusItemIsNull_ = false;}
   else{statusItemIsNull_ = true;}

   if(statusItemNode)
   {
      for(statusItemNode; statusItemNode; statusItemNode = statusItemNode->NextSiblingElement("statusItem")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusItemNode , address : " << statusItemNode << std::endl;
          #endif
          if(statusItemNode->Attribute("href") || statusItemNode->Attribute("id"))
          {
              if(statusItemNode->Attribute("id"))
              {
                  statusItemIDRef_ = statusItemNode->Attribute("id");
                  statusItem_.push_back(boost::shared_ptr<EventStatusItem>(new EventStatusItem(statusItemNode)));
                  statusItem_.back()->setID(statusItemIDRef_);
                  IDManager::instance().setID(statusItemIDRef_, statusItem_.back());
              }
              else if(statusItemNode->Attribute("href")) { statusItemIDRef_ = statusItemNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { statusItem_.push_back(boost::shared_ptr<EventStatusItem>(new EventStatusItem(statusItemNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusItemNode , address : " << statusItemNode << std::endl;
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
std::vector<boost::shared_ptr<EventStatusItem>> EventStatusResponse::getStatusItem()
{
   if(!this->statusItemIsNull_){
        if(statusItemIDRef_ != ""){
             return this->statusItem_;
        }else{
             return this->statusItem_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventStatusItem>>();
   }
}
std::vector<boost::shared_ptr<Party>> EventStatusResponse::getParty()
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
std::vector<boost::shared_ptr<Account>> EventStatusResponse::getAccount()
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

