// DataDocument.cpp 
#include "DataDocument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DataDocument::DataDocument(TiXmlNode* xmlNode)
: Document(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //validationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* validationNode = xmlNode->FirstChildElement("validation");

   if(validationNode){validationIsNull_ = false;}
   else{validationIsNull_ = true;}

   if(validationNode)
   {
      for(validationNode; validationNode; validationNode = validationNode->NextSiblingElement("validation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- validationNode , address : " << validationNode << std::endl;
          #endif
          if(validationNode->Attribute("href") || validationNode->Attribute("id"))
          {
              if(validationNode->Attribute("id"))
              {
                  validationIDRef_ = validationNode->Attribute("id");
                  validation_.push_back(boost::shared_ptr<Validation>(new Validation(validationNode)));
                  validation_.back()->setID(validationIDRef_);
                  IDManager::instance().setID(validationIDRef_, validation_.back());
              }
              else if(validationNode->Attribute("href")) { validationIDRef_ = validationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { validation_.push_back(boost::shared_ptr<Validation>(new Validation(validationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- validationNode , address : " << validationNode << std::endl;
       #endif
   }

   //onBehalfOfNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* onBehalfOfNode = xmlNode->FirstChildElement("onBehalfOf");

   if(onBehalfOfNode){onBehalfOfIsNull_ = false;}
   else{onBehalfOfIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- onBehalfOfNode , address : " << onBehalfOfNode << std::endl;
   #endif
   if(onBehalfOfNode)
   {
      if(onBehalfOfNode->Attribute("href") || onBehalfOfNode->Attribute("id"))
      {
          if(onBehalfOfNode->Attribute("id"))
          {
             onBehalfOfIDRef_ = onBehalfOfNode->Attribute("id");
             onBehalfOf_ = boost::shared_ptr<OnBehalfOf>(new OnBehalfOf(onBehalfOfNode));
             onBehalfOf_->setID(onBehalfOfIDRef_);
             IDManager::instance().setID(onBehalfOfIDRef_,onBehalfOf_);
          }
          else if(onBehalfOfNode->Attribute("href")) { onBehalfOfIDRef_ = onBehalfOfNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { onBehalfOf_ = boost::shared_ptr<OnBehalfOf>(new OnBehalfOf(onBehalfOfNode));}
   }

   //originatingEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originatingEventNode = xmlNode->FirstChildElement("originatingEvent");

   if(originatingEventNode){originatingEventIsNull_ = false;}
   else{originatingEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingEventNode , address : " << originatingEventNode << std::endl;
   #endif
   if(originatingEventNode)
   {
      if(originatingEventNode->Attribute("href") || originatingEventNode->Attribute("id"))
      {
          if(originatingEventNode->Attribute("id"))
          {
             originatingEventIDRef_ = originatingEventNode->Attribute("id");
             originatingEvent_ = boost::shared_ptr<OriginatingEvent>(new OriginatingEvent(originatingEventNode));
             originatingEvent_->setID(originatingEventIDRef_);
             IDManager::instance().setID(originatingEventIDRef_,originatingEvent_);
          }
          else if(originatingEventNode->Attribute("href")) { originatingEventIDRef_ = originatingEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originatingEvent_ = boost::shared_ptr<OriginatingEvent>(new OriginatingEvent(originatingEventNode));}
   }

   //tradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeNode = xmlNode->FirstChildElement("trade");

   if(tradeNode){tradeIsNull_ = false;}
   else{tradeIsNull_ = true;}

   if(tradeNode)
   {
      for(tradeNode; tradeNode; tradeNode = tradeNode->NextSiblingElement("trade")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeNode , address : " << tradeNode << std::endl;
          #endif
          if(tradeNode->Attribute("href") || tradeNode->Attribute("id"))
          {
              if(tradeNode->Attribute("id"))
              {
                  tradeIDRef_ = tradeNode->Attribute("id");
                  trade_.push_back(boost::shared_ptr<Trade>(new Trade(tradeNode)));
                  trade_.back()->setID(tradeIDRef_);
                  IDManager::instance().setID(tradeIDRef_, trade_.back());
              }
              else if(tradeNode->Attribute("href")) { tradeIDRef_ = tradeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { trade_.push_back(boost::shared_ptr<Trade>(new Trade(tradeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeNode , address : " << tradeNode << std::endl;
       #endif
   }

   //portfolioNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* portfolioNode = xmlNode->FirstChildElement("portfolio");

   if(portfolioNode){portfolioIsNull_ = false;}
   else{portfolioIsNull_ = true;}

   if(portfolioNode)
   {
      for(portfolioNode; portfolioNode; portfolioNode = portfolioNode->NextSiblingElement("portfolio")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioNode , address : " << portfolioNode << std::endl;
          #endif
          if(portfolioNode->Attribute("href") || portfolioNode->Attribute("id"))
          {
              if(portfolioNode->Attribute("id"))
              {
                  portfolioIDRef_ = portfolioNode->Attribute("id");
                  portfolio_.push_back(boost::shared_ptr<Portfolio>(new Portfolio(portfolioNode)));
                  portfolio_.back()->setID(portfolioIDRef_);
                  IDManager::instance().setID(portfolioIDRef_, portfolio_.back());
              }
              else if(portfolioNode->Attribute("href")) { portfolioIDRef_ = portfolioNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { portfolio_.push_back(boost::shared_ptr<Portfolio>(new Portfolio(portfolioNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioNode , address : " << portfolioNode << std::endl;
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
std::vector<boost::shared_ptr<Validation>> DataDocument::getValidation()
{
   if(!this->validationIsNull_){
        if(validationIDRef_ != ""){
             return this->validation_;
        }else{
             return this->validation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Validation>>();
   }
}
boost::shared_ptr<OnBehalfOf> DataDocument::getOnBehalfOf()
{
   if(!this->onBehalfOfIsNull_){
        if(onBehalfOfIDRef_ != ""){
             return boost::shared_static_cast<OnBehalfOf>(IDManager::instance().getID(onBehalfOfIDRef_));
        }else{
             return this->onBehalfOf_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OnBehalfOf>();
   }
}
boost::shared_ptr<OriginatingEvent> DataDocument::getOriginatingEvent()
{
   if(!this->originatingEventIsNull_){
        if(originatingEventIDRef_ != ""){
             return boost::shared_static_cast<OriginatingEvent>(IDManager::instance().getID(originatingEventIDRef_));
        }else{
             return this->originatingEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OriginatingEvent>();
   }
}
std::vector<boost::shared_ptr<Trade>> DataDocument::getTrade()
{
   if(!this->tradeIsNull_){
        if(tradeIDRef_ != ""){
             return this->trade_;
        }else{
             return this->trade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Trade>>();
   }
}
std::vector<boost::shared_ptr<Portfolio>> DataDocument::getPortfolio()
{
   if(!this->portfolioIsNull_){
        if(portfolioIDRef_ != ""){
             return this->portfolio_;
        }else{
             return this->portfolio_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Portfolio>>();
   }
}
std::vector<boost::shared_ptr<Party>> DataDocument::getParty()
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
std::vector<boost::shared_ptr<Account>> DataDocument::getAccount()
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

