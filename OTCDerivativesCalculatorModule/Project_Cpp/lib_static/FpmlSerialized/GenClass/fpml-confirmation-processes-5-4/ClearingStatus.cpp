// ClearingStatus.cpp 
#include "ClearingStatus.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ClearingStatus::ClearingStatus(TiXmlNode* xmlNode)
: NotificationMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //clearingStatusItemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearingStatusItemNode = xmlNode->FirstChildElement("clearingStatusItem");

   if(clearingStatusItemNode){clearingStatusItemIsNull_ = false;}
   else{clearingStatusItemIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearingStatusItemNode , address : " << clearingStatusItemNode << std::endl;
   #endif
   if(clearingStatusItemNode)
   {
      if(clearingStatusItemNode->Attribute("href") || clearingStatusItemNode->Attribute("id"))
      {
          if(clearingStatusItemNode->Attribute("id"))
          {
             clearingStatusItemIDRef_ = clearingStatusItemNode->Attribute("id");
             clearingStatusItem_ = boost::shared_ptr<ClearingStatusItem>(new ClearingStatusItem(clearingStatusItemNode));
             clearingStatusItem_->setID(clearingStatusItemIDRef_);
             IDManager::instance().setID(clearingStatusItemIDRef_,clearingStatusItem_);
          }
          else if(clearingStatusItemNode->Attribute("href")) { clearingStatusItemIDRef_ = clearingStatusItemNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { clearingStatusItem_ = boost::shared_ptr<ClearingStatusItem>(new ClearingStatusItem(clearingStatusItemNode));}
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
boost::shared_ptr<ClearingStatusItem> ClearingStatus::getClearingStatusItem()
{
   if(!this->clearingStatusItemIsNull_){
        if(clearingStatusItemIDRef_ != ""){
             return boost::shared_static_cast<ClearingStatusItem>(IDManager::instance().getID(clearingStatusItemIDRef_));
        }else{
             return this->clearingStatusItem_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ClearingStatusItem>();
   }
}
std::vector<boost::shared_ptr<Party>> ClearingStatus::getParty()
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
std::vector<boost::shared_ptr<Account>> ClearingStatus::getAccount()
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

