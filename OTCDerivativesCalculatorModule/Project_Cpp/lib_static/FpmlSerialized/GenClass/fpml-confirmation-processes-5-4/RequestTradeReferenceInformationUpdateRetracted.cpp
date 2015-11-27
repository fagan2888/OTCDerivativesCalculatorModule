// RequestTradeReferenceInformationUpdateRetracted.cpp 
#include "RequestTradeReferenceInformationUpdateRetracted.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RequestTradeReferenceInformationUpdateRetracted::RequestTradeReferenceInformationUpdateRetracted(TiXmlNode* xmlNode)
: NonCorrectableRequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeReferenceInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeReferenceInformationNode = xmlNode->FirstChildElement("tradeReferenceInformation");

   if(tradeReferenceInformationNode){tradeReferenceInformationIsNull_ = false;}
   else{tradeReferenceInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeReferenceInformationNode , address : " << tradeReferenceInformationNode << std::endl;
   #endif
   if(tradeReferenceInformationNode)
   {
      if(tradeReferenceInformationNode->Attribute("href") || tradeReferenceInformationNode->Attribute("id"))
      {
          if(tradeReferenceInformationNode->Attribute("id"))
          {
             tradeReferenceInformationIDRef_ = tradeReferenceInformationNode->Attribute("id");
             tradeReferenceInformation_ = boost::shared_ptr<TradeReferenceInformation>(new TradeReferenceInformation(tradeReferenceInformationNode));
             tradeReferenceInformation_->setID(tradeReferenceInformationIDRef_);
             IDManager::instance().setID(tradeReferenceInformationIDRef_,tradeReferenceInformation_);
          }
          else if(tradeReferenceInformationNode->Attribute("href")) { tradeReferenceInformationIDRef_ = tradeReferenceInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeReferenceInformation_ = boost::shared_ptr<TradeReferenceInformation>(new TradeReferenceInformation(tradeReferenceInformationNode));}
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
boost::shared_ptr<TradeReferenceInformation> RequestTradeReferenceInformationUpdateRetracted::getTradeReferenceInformation()
{
   if(!this->tradeReferenceInformationIsNull_){
        if(tradeReferenceInformationIDRef_ != ""){
             return boost::shared_static_cast<TradeReferenceInformation>(IDManager::instance().getID(tradeReferenceInformationIDRef_));
        }else{
             return this->tradeReferenceInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeReferenceInformation>();
   }
}
std::vector<boost::shared_ptr<Party>> RequestTradeReferenceInformationUpdateRetracted::getParty()
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
std::vector<boost::shared_ptr<Account>> RequestTradeReferenceInformationUpdateRetracted::getAccount()
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

