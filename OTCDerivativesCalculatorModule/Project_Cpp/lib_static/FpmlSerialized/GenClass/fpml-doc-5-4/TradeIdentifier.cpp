// TradeIdentifier.cpp 
#include "TradeIdentifier.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeIdentifier::TradeIdentifier(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //issuerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* issuerNode = xmlNode->FirstChildElement("issuer");

   if(issuerNode){issuerIsNull_ = false;}
   else{issuerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- issuerNode , address : " << issuerNode << std::endl;
   #endif
   if(issuerNode)
   {
      if(issuerNode->Attribute("href") || issuerNode->Attribute("id"))
      {
          if(issuerNode->Attribute("id"))
          {
             issuerIDRef_ = issuerNode->Attribute("id");
             issuer_ = boost::shared_ptr<IssuerId>(new IssuerId(issuerNode));
             issuer_->setID(issuerIDRef_);
             IDManager::instance().setID(issuerIDRef_,issuer_);
          }
          else if(issuerNode->Attribute("href")) { issuerIDRef_ = issuerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { issuer_ = boost::shared_ptr<IssuerId>(new IssuerId(issuerNode));}
   }

   //tradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdNode = xmlNode->FirstChildElement("tradeId");

   if(tradeIdNode){tradeIdIsNull_ = false;}
   else{tradeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdNode , address : " << tradeIdNode << std::endl;
   #endif
   if(tradeIdNode)
   {
      if(tradeIdNode->Attribute("href") || tradeIdNode->Attribute("id"))
      {
          if(tradeIdNode->Attribute("id"))
          {
             tradeIdIDRef_ = tradeIdNode->Attribute("id");
             tradeId_ = boost::shared_ptr<TradeId>(new TradeId(tradeIdNode));
             tradeId_->setID(tradeIdIDRef_);
             IDManager::instance().setID(tradeIdIDRef_,tradeId_);
          }
          else if(tradeIdNode->Attribute("href")) { tradeIdIDRef_ = tradeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeId_ = boost::shared_ptr<TradeId>(new TradeId(tradeIdNode));}
   }

   //partyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyReferenceNode = xmlNode->FirstChildElement("partyReference");

   if(partyReferenceNode){partyReferenceIsNull_ = false;}
   else{partyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyReferenceNode , address : " << partyReferenceNode << std::endl;
   #endif
   if(partyReferenceNode)
   {
      if(partyReferenceNode->Attribute("href") || partyReferenceNode->Attribute("id"))
      {
          if(partyReferenceNode->Attribute("id"))
          {
             partyReferenceIDRef_ = partyReferenceNode->Attribute("id");
             partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));
             partyReference_->setID(partyReferenceIDRef_);
             IDManager::instance().setID(partyReferenceIDRef_,partyReference_);
          }
          else if(partyReferenceNode->Attribute("href")) { partyReferenceIDRef_ = partyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));}
   }

   //accountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountReferenceNode = xmlNode->FirstChildElement("accountReference");

   if(accountReferenceNode){accountReferenceIsNull_ = false;}
   else{accountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountReferenceNode , address : " << accountReferenceNode << std::endl;
   #endif
   if(accountReferenceNode)
   {
      if(accountReferenceNode->Attribute("href") || accountReferenceNode->Attribute("id"))
      {
          if(accountReferenceNode->Attribute("id"))
          {
             accountReferenceIDRef_ = accountReferenceNode->Attribute("id");
             accountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(accountReferenceNode));
             accountReference_->setID(accountReferenceIDRef_);
             IDManager::instance().setID(accountReferenceIDRef_,accountReference_);
          }
          else if(accountReferenceNode->Attribute("href")) { accountReferenceIDRef_ = accountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(accountReferenceNode));}
   }

   //versionedTradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* versionedTradeIdNode = xmlNode->FirstChildElement("versionedTradeId");

   if(versionedTradeIdNode){versionedTradeIdIsNull_ = false;}
   else{versionedTradeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- versionedTradeIdNode , address : " << versionedTradeIdNode << std::endl;
   #endif
   if(versionedTradeIdNode)
   {
      if(versionedTradeIdNode->Attribute("href") || versionedTradeIdNode->Attribute("id"))
      {
          if(versionedTradeIdNode->Attribute("id"))
          {
             versionedTradeIdIDRef_ = versionedTradeIdNode->Attribute("id");
             versionedTradeId_ = boost::shared_ptr<VersionedTradeId>(new VersionedTradeId(versionedTradeIdNode));
             versionedTradeId_->setID(versionedTradeIdIDRef_);
             IDManager::instance().setID(versionedTradeIdIDRef_,versionedTradeId_);
          }
          else if(versionedTradeIdNode->Attribute("href")) { versionedTradeIdIDRef_ = versionedTradeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { versionedTradeId_ = boost::shared_ptr<VersionedTradeId>(new VersionedTradeId(versionedTradeIdNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IssuerId> TradeIdentifier::getIssuer()
{
   if(!this->issuerIsNull_){
        if(issuerIDRef_ != ""){
             return boost::shared_static_cast<IssuerId>(IDManager::instance().getID(issuerIDRef_));
        }else{
             return this->issuer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IssuerId>();
   }
}
boost::shared_ptr<TradeId> TradeIdentifier::getTradeId()
{
   if(!this->tradeIdIsNull_){
        if(tradeIdIDRef_ != ""){
             return boost::shared_static_cast<TradeId>(IDManager::instance().getID(tradeIdIDRef_));
        }else{
             return this->tradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeId>();
   }
}
boost::shared_ptr<PartyReference> TradeIdentifier::getPartyReference()
{
   if(!this->partyReferenceIsNull_){
        if(partyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(partyReferenceIDRef_));
        }else{
             return this->partyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> TradeIdentifier::getAccountReference()
{
   if(!this->accountReferenceIsNull_){
        if(accountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(accountReferenceIDRef_));
        }else{
             return this->accountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<VersionedTradeId> TradeIdentifier::getVersionedTradeId()
{
   if(!this->versionedTradeIdIsNull_){
        if(versionedTradeIdIDRef_ != ""){
             return boost::shared_static_cast<VersionedTradeId>(IDManager::instance().getID(versionedTradeIdIDRef_));
        }else{
             return this->versionedTradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VersionedTradeId>();
   }
}
}

