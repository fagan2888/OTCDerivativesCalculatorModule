// CommodityHub.cpp 
#include "CommodityHub.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityHub::CommodityHub(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //hubCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hubCodeNode = xmlNode->FirstChildElement("hubCode");

   if(hubCodeNode){hubCodeIsNull_ = false;}
   else{hubCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hubCodeNode , address : " << hubCodeNode << std::endl;
   #endif
   if(hubCodeNode)
   {
      if(hubCodeNode->Attribute("href") || hubCodeNode->Attribute("id"))
      {
          if(hubCodeNode->Attribute("id"))
          {
             hubCodeIDRef_ = hubCodeNode->Attribute("id");
             hubCode_ = boost::shared_ptr<CommodityHubCode>(new CommodityHubCode(hubCodeNode));
             hubCode_->setID(hubCodeIDRef_);
             IDManager::instance().setID(hubCodeIDRef_,hubCode_);
          }
          else if(hubCodeNode->Attribute("href")) { hubCodeIDRef_ = hubCodeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { hubCode_ = boost::shared_ptr<CommodityHubCode>(new CommodityHubCode(hubCodeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> CommodityHub::getPartyReference()
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
boost::shared_ptr<AccountReference> CommodityHub::getAccountReference()
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
boost::shared_ptr<CommodityHubCode> CommodityHub::getHubCode()
{
   if(!this->hubCodeIsNull_){
        if(hubCodeIDRef_ != ""){
             return boost::shared_static_cast<CommodityHubCode>(IDManager::instance().getID(hubCodeIDRef_));
        }else{
             return this->hubCode_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityHubCode>();
   }
}
}

