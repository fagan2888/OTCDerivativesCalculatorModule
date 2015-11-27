// Acknowledgement.cpp 
#include "Acknowledgement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Acknowledgement::Acknowledgement(TiXmlNode* xmlNode)
: ResponseMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //originalMessageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originalMessageNode = xmlNode->FirstChildElement("originalMessage");

   if(originalMessageNode){originalMessageIsNull_ = false;}
   else{originalMessageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originalMessageNode , address : " << originalMessageNode << std::endl;
   #endif
   if(originalMessageNode)
   {
      if(originalMessageNode->Attribute("href") || originalMessageNode->Attribute("id"))
      {
          if(originalMessageNode->Attribute("id"))
          {
             originalMessageIDRef_ = originalMessageNode->Attribute("id");
             originalMessage_ = boost::shared_ptr<UnprocessedElementWrapper>(new UnprocessedElementWrapper(originalMessageNode));
             originalMessage_->setID(originalMessageIDRef_);
             IDManager::instance().setID(originalMessageIDRef_,originalMessage_);
          }
          else if(originalMessageNode->Attribute("href")) { originalMessageIDRef_ = originalMessageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originalMessage_ = boost::shared_ptr<UnprocessedElementWrapper>(new UnprocessedElementWrapper(originalMessageNode));}
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
boost::shared_ptr<UnprocessedElementWrapper> Acknowledgement::getOriginalMessage()
{
   if(!this->originalMessageIsNull_){
        if(originalMessageIDRef_ != ""){
             return boost::shared_static_cast<UnprocessedElementWrapper>(IDManager::instance().getID(originalMessageIDRef_));
        }else{
             return this->originalMessage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnprocessedElementWrapper>();
   }
}
std::vector<boost::shared_ptr<Party>> Acknowledgement::getParty()
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
std::vector<boost::shared_ptr<Account>> Acknowledgement::getAccount()
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

