// RequestCollateralAllocation.cpp 
#include "RequestCollateralAllocation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RequestCollateralAllocation::RequestCollateralAllocation(TiXmlNode* xmlNode)
: CorrectableRequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //serviceNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* serviceNameNode = xmlNode->FirstChildElement("serviceName");

   if(serviceNameNode){serviceNameIsNull_ = false;}
   else{serviceNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- serviceNameNode , address : " << serviceNameNode << std::endl;
   #endif
   if(serviceNameNode)
   {
      if(serviceNameNode->Attribute("href") || serviceNameNode->Attribute("id"))
      {
          if(serviceNameNode->Attribute("id"))
          {
             serviceNameIDRef_ = serviceNameNode->Attribute("id");
             serviceName_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(serviceNameNode));
             serviceName_->setID(serviceNameIDRef_);
             IDManager::instance().setID(serviceNameIDRef_,serviceName_);
          }
          else if(serviceNameNode->Attribute("href")) { serviceNameIDRef_ = serviceNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { serviceName_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(serviceNameNode));}
   }

   //collateralGiverPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* collateralGiverPartyReferenceNode = xmlNode->FirstChildElement("collateralGiverPartyReference");

   if(collateralGiverPartyReferenceNode){collateralGiverPartyReferenceIsNull_ = false;}
   else{collateralGiverPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- collateralGiverPartyReferenceNode , address : " << collateralGiverPartyReferenceNode << std::endl;
   #endif
   if(collateralGiverPartyReferenceNode)
   {
      if(collateralGiverPartyReferenceNode->Attribute("href") || collateralGiverPartyReferenceNode->Attribute("id"))
      {
          if(collateralGiverPartyReferenceNode->Attribute("id"))
          {
             collateralGiverPartyReferenceIDRef_ = collateralGiverPartyReferenceNode->Attribute("id");
             collateralGiverPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(collateralGiverPartyReferenceNode));
             collateralGiverPartyReference_->setID(collateralGiverPartyReferenceIDRef_);
             IDManager::instance().setID(collateralGiverPartyReferenceIDRef_,collateralGiverPartyReference_);
          }
          else if(collateralGiverPartyReferenceNode->Attribute("href")) { collateralGiverPartyReferenceIDRef_ = collateralGiverPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { collateralGiverPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(collateralGiverPartyReferenceNode));}
   }

   //collateralAllocationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* collateralAllocationNode = xmlNode->FirstChildElement("collateralAllocation");

   if(collateralAllocationNode){collateralAllocationIsNull_ = false;}
   else{collateralAllocationIsNull_ = true;}

   if(collateralAllocationNode)
   {
      for(collateralAllocationNode; collateralAllocationNode; collateralAllocationNode = collateralAllocationNode->NextSiblingElement("collateralAllocation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- collateralAllocationNode , address : " << collateralAllocationNode << std::endl;
          #endif
          if(collateralAllocationNode->Attribute("href") || collateralAllocationNode->Attribute("id"))
          {
              if(collateralAllocationNode->Attribute("id"))
              {
                  collateralAllocationIDRef_ = collateralAllocationNode->Attribute("id");
                  collateralAllocation_.push_back(boost::shared_ptr<ProposedCollateralAllocation>(new ProposedCollateralAllocation(collateralAllocationNode)));
                  collateralAllocation_.back()->setID(collateralAllocationIDRef_);
                  IDManager::instance().setID(collateralAllocationIDRef_, collateralAllocation_.back());
              }
              else if(collateralAllocationNode->Attribute("href")) { collateralAllocationIDRef_ = collateralAllocationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { collateralAllocation_.push_back(boost::shared_ptr<ProposedCollateralAllocation>(new ProposedCollateralAllocation(collateralAllocationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- collateralAllocationNode , address : " << collateralAllocationNode << std::endl;
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
boost::shared_ptr<XsdTypeNormalizedString> RequestCollateralAllocation::getServiceName()
{
   if(!this->serviceNameIsNull_){
        if(serviceNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(serviceNameIDRef_));
        }else{
             return this->serviceName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<PartyReference> RequestCollateralAllocation::getCollateralGiverPartyReference()
{
   if(!this->collateralGiverPartyReferenceIsNull_){
        if(collateralGiverPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(collateralGiverPartyReferenceIDRef_));
        }else{
             return this->collateralGiverPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
std::vector<boost::shared_ptr<ProposedCollateralAllocation>> RequestCollateralAllocation::getCollateralAllocation()
{
   if(!this->collateralAllocationIsNull_){
        if(collateralAllocationIDRef_ != ""){
             return this->collateralAllocation_;
        }else{
             return this->collateralAllocation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ProposedCollateralAllocation>>();
   }
}
std::vector<boost::shared_ptr<Party>> RequestCollateralAllocation::getParty()
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
std::vector<boost::shared_ptr<Account>> RequestCollateralAllocation::getAccount()
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

