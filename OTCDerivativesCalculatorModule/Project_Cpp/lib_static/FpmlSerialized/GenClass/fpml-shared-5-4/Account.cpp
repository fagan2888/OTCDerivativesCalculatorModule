// Account.cpp 
#include "Account.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Account::Account(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //accountIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountIdNode = xmlNode->FirstChildElement("accountId");

   if(accountIdNode){accountIdIsNull_ = false;}
   else{accountIdIsNull_ = true;}

   if(accountIdNode)
   {
      for(accountIdNode; accountIdNode; accountIdNode = accountIdNode->NextSiblingElement("accountId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountIdNode , address : " << accountIdNode << std::endl;
          #endif
          if(accountIdNode->Attribute("href") || accountIdNode->Attribute("id"))
          {
              if(accountIdNode->Attribute("id"))
              {
                  accountIdIDRef_ = accountIdNode->Attribute("id");
                  accountId_.push_back(boost::shared_ptr<AccountId>(new AccountId(accountIdNode)));
                  accountId_.back()->setID(accountIdIDRef_);
                  IDManager::instance().setID(accountIdIDRef_, accountId_.back());
              }
              else if(accountIdNode->Attribute("href")) { accountIdIDRef_ = accountIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { accountId_.push_back(boost::shared_ptr<AccountId>(new AccountId(accountIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountIdNode , address : " << accountIdNode << std::endl;
       #endif
   }

   //accountNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountNameNode = xmlNode->FirstChildElement("accountName");

   if(accountNameNode){accountNameIsNull_ = false;}
   else{accountNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountNameNode , address : " << accountNameNode << std::endl;
   #endif
   if(accountNameNode)
   {
      if(accountNameNode->Attribute("href") || accountNameNode->Attribute("id"))
      {
          if(accountNameNode->Attribute("id"))
          {
             accountNameIDRef_ = accountNameNode->Attribute("id");
             accountName_ = boost::shared_ptr<AccountName>(new AccountName(accountNameNode));
             accountName_->setID(accountNameIDRef_);
             IDManager::instance().setID(accountNameIDRef_,accountName_);
          }
          else if(accountNameNode->Attribute("href")) { accountNameIDRef_ = accountNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accountName_ = boost::shared_ptr<AccountName>(new AccountName(accountNameNode));}
   }

   //accountTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountTypeNode = xmlNode->FirstChildElement("accountType");

   if(accountTypeNode){accountTypeIsNull_ = false;}
   else{accountTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountTypeNode , address : " << accountTypeNode << std::endl;
   #endif
   if(accountTypeNode)
   {
      if(accountTypeNode->Attribute("href") || accountTypeNode->Attribute("id"))
      {
          if(accountTypeNode->Attribute("id"))
          {
             accountTypeIDRef_ = accountTypeNode->Attribute("id");
             accountType_ = boost::shared_ptr<AccountType>(new AccountType(accountTypeNode));
             accountType_->setID(accountTypeIDRef_);
             IDManager::instance().setID(accountTypeIDRef_,accountType_);
          }
          else if(accountTypeNode->Attribute("href")) { accountTypeIDRef_ = accountTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accountType_ = boost::shared_ptr<AccountType>(new AccountType(accountTypeNode));}
   }

   //accountBeneficiaryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountBeneficiaryNode = xmlNode->FirstChildElement("accountBeneficiary");

   if(accountBeneficiaryNode){accountBeneficiaryIsNull_ = false;}
   else{accountBeneficiaryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountBeneficiaryNode , address : " << accountBeneficiaryNode << std::endl;
   #endif
   if(accountBeneficiaryNode)
   {
      if(accountBeneficiaryNode->Attribute("href") || accountBeneficiaryNode->Attribute("id"))
      {
          if(accountBeneficiaryNode->Attribute("id"))
          {
             accountBeneficiaryIDRef_ = accountBeneficiaryNode->Attribute("id");
             accountBeneficiary_ = boost::shared_ptr<PartyReference>(new PartyReference(accountBeneficiaryNode));
             accountBeneficiary_->setID(accountBeneficiaryIDRef_);
             IDManager::instance().setID(accountBeneficiaryIDRef_,accountBeneficiary_);
          }
          else if(accountBeneficiaryNode->Attribute("href")) { accountBeneficiaryIDRef_ = accountBeneficiaryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accountBeneficiary_ = boost::shared_ptr<PartyReference>(new PartyReference(accountBeneficiaryNode));}
   }

   //servicingPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* servicingPartyNode = xmlNode->FirstChildElement("servicingParty");

   if(servicingPartyNode){servicingPartyIsNull_ = false;}
   else{servicingPartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- servicingPartyNode , address : " << servicingPartyNode << std::endl;
   #endif
   if(servicingPartyNode)
   {
      if(servicingPartyNode->Attribute("href") || servicingPartyNode->Attribute("id"))
      {
          if(servicingPartyNode->Attribute("id"))
          {
             servicingPartyIDRef_ = servicingPartyNode->Attribute("id");
             servicingParty_ = boost::shared_ptr<PartyReference>(new PartyReference(servicingPartyNode));
             servicingParty_->setID(servicingPartyIDRef_);
             IDManager::instance().setID(servicingPartyIDRef_,servicingParty_);
          }
          else if(servicingPartyNode->Attribute("href")) { servicingPartyIDRef_ = servicingPartyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { servicingParty_ = boost::shared_ptr<PartyReference>(new PartyReference(servicingPartyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<AccountId>> Account::getAccountId()
{
   if(!this->accountIdIsNull_){
        if(accountIdIDRef_ != ""){
             return this->accountId_;
        }else{
             return this->accountId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AccountId>>();
   }
}
boost::shared_ptr<AccountName> Account::getAccountName()
{
   if(!this->accountNameIsNull_){
        if(accountNameIDRef_ != ""){
             return boost::shared_static_cast<AccountName>(IDManager::instance().getID(accountNameIDRef_));
        }else{
             return this->accountName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountName>();
   }
}
boost::shared_ptr<AccountType> Account::getAccountType()
{
   if(!this->accountTypeIsNull_){
        if(accountTypeIDRef_ != ""){
             return boost::shared_static_cast<AccountType>(IDManager::instance().getID(accountTypeIDRef_));
        }else{
             return this->accountType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountType>();
   }
}
boost::shared_ptr<PartyReference> Account::getAccountBeneficiary()
{
   if(!this->accountBeneficiaryIsNull_){
        if(accountBeneficiaryIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(accountBeneficiaryIDRef_));
        }else{
             return this->accountBeneficiary_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<PartyReference> Account::getServicingParty()
{
   if(!this->servicingPartyIsNull_){
        if(servicingPartyIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(servicingPartyIDRef_));
        }else{
             return this->servicingParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
}

