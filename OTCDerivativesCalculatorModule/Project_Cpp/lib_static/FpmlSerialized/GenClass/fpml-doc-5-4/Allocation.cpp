// Allocation.cpp 
#include "Allocation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Allocation::Allocation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //allocationTradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationTradeIdNode = xmlNode->FirstChildElement("allocationTradeId");

   if(allocationTradeIdNode){allocationTradeIdIsNull_ = false;}
   else{allocationTradeIdIsNull_ = true;}

   if(allocationTradeIdNode)
   {
      for(allocationTradeIdNode; allocationTradeIdNode; allocationTradeIdNode = allocationTradeIdNode->NextSiblingElement("allocationTradeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationTradeIdNode , address : " << allocationTradeIdNode << std::endl;
          #endif
          if(allocationTradeIdNode->Attribute("href") || allocationTradeIdNode->Attribute("id"))
          {
              if(allocationTradeIdNode->Attribute("id"))
              {
                  allocationTradeIdIDRef_ = allocationTradeIdNode->Attribute("id");
                  allocationTradeId_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(allocationTradeIdNode)));
                  allocationTradeId_.back()->setID(allocationTradeIdIDRef_);
                  IDManager::instance().setID(allocationTradeIdIDRef_, allocationTradeId_.back());
              }
              else if(allocationTradeIdNode->Attribute("href")) { allocationTradeIdIDRef_ = allocationTradeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { allocationTradeId_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(allocationTradeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationTradeIdNode , address : " << allocationTradeIdNode << std::endl;
       #endif
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

   //allocatedFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocatedFractionNode = xmlNode->FirstChildElement("allocatedFraction");

   if(allocatedFractionNode){allocatedFractionIsNull_ = false;}
   else{allocatedFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocatedFractionNode , address : " << allocatedFractionNode << std::endl;
   #endif
   if(allocatedFractionNode)
   {
      if(allocatedFractionNode->Attribute("href") || allocatedFractionNode->Attribute("id"))
      {
          if(allocatedFractionNode->Attribute("id"))
          {
             allocatedFractionIDRef_ = allocatedFractionNode->Attribute("id");
             allocatedFraction_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(allocatedFractionNode));
             allocatedFraction_->setID(allocatedFractionIDRef_);
             IDManager::instance().setID(allocatedFractionIDRef_,allocatedFraction_);
          }
          else if(allocatedFractionNode->Attribute("href")) { allocatedFractionIDRef_ = allocatedFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocatedFraction_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(allocatedFractionNode));}
   }

   //allocatedNotionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocatedNotionalNode = xmlNode->FirstChildElement("allocatedNotional");

   if(allocatedNotionalNode){allocatedNotionalIsNull_ = false;}
   else{allocatedNotionalIsNull_ = true;}

   if(allocatedNotionalNode)
   {
      for(allocatedNotionalNode; allocatedNotionalNode; allocatedNotionalNode = allocatedNotionalNode->NextSiblingElement("allocatedNotional")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocatedNotionalNode , address : " << allocatedNotionalNode << std::endl;
          #endif
          if(allocatedNotionalNode->Attribute("href") || allocatedNotionalNode->Attribute("id"))
          {
              if(allocatedNotionalNode->Attribute("id"))
              {
                  allocatedNotionalIDRef_ = allocatedNotionalNode->Attribute("id");
                  allocatedNotional_.push_back(boost::shared_ptr<Money>(new Money(allocatedNotionalNode)));
                  allocatedNotional_.back()->setID(allocatedNotionalIDRef_);
                  IDManager::instance().setID(allocatedNotionalIDRef_, allocatedNotional_.back());
              }
              else if(allocatedNotionalNode->Attribute("href")) { allocatedNotionalIDRef_ = allocatedNotionalNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { allocatedNotional_.push_back(boost::shared_ptr<Money>(new Money(allocatedNotionalNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocatedNotionalNode , address : " << allocatedNotionalNode << std::endl;
       #endif
   }

   //collateralNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* collateralNode = xmlNode->FirstChildElement("collateral");

   if(collateralNode){collateralIsNull_ = false;}
   else{collateralIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- collateralNode , address : " << collateralNode << std::endl;
   #endif
   if(collateralNode)
   {
      if(collateralNode->Attribute("href") || collateralNode->Attribute("id"))
      {
          if(collateralNode->Attribute("id"))
          {
             collateralIDRef_ = collateralNode->Attribute("id");
             collateral_ = boost::shared_ptr<Collateral>(new Collateral(collateralNode));
             collateral_->setID(collateralIDRef_);
             IDManager::instance().setID(collateralIDRef_,collateral_);
          }
          else if(collateralNode->Attribute("href")) { collateralIDRef_ = collateralNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { collateral_ = boost::shared_ptr<Collateral>(new Collateral(collateralNode));}
   }

   //creditChargeAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditChargeAmountNode = xmlNode->FirstChildElement("creditChargeAmount");

   if(creditChargeAmountNode){creditChargeAmountIsNull_ = false;}
   else{creditChargeAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditChargeAmountNode , address : " << creditChargeAmountNode << std::endl;
   #endif
   if(creditChargeAmountNode)
   {
      if(creditChargeAmountNode->Attribute("href") || creditChargeAmountNode->Attribute("id"))
      {
          if(creditChargeAmountNode->Attribute("id"))
          {
             creditChargeAmountIDRef_ = creditChargeAmountNode->Attribute("id");
             creditChargeAmount_ = boost::shared_ptr<Money>(new Money(creditChargeAmountNode));
             creditChargeAmount_->setID(creditChargeAmountIDRef_);
             IDManager::instance().setID(creditChargeAmountIDRef_,creditChargeAmount_);
          }
          else if(creditChargeAmountNode->Attribute("href")) { creditChargeAmountIDRef_ = creditChargeAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditChargeAmount_ = boost::shared_ptr<Money>(new Money(creditChargeAmountNode));}
   }

   //approvalsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* approvalsNode = xmlNode->FirstChildElement("approvals");

   if(approvalsNode){approvalsIsNull_ = false;}
   else{approvalsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- approvalsNode , address : " << approvalsNode << std::endl;
   #endif
   if(approvalsNode)
   {
      if(approvalsNode->Attribute("href") || approvalsNode->Attribute("id"))
      {
          if(approvalsNode->Attribute("id"))
          {
             approvalsIDRef_ = approvalsNode->Attribute("id");
             approvals_ = boost::shared_ptr<Approvals>(new Approvals(approvalsNode));
             approvals_->setID(approvalsIDRef_);
             IDManager::instance().setID(approvalsIDRef_,approvals_);
          }
          else if(approvalsNode->Attribute("href")) { approvalsIDRef_ = approvalsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { approvals_ = boost::shared_ptr<Approvals>(new Approvals(approvalsNode));}
   }

   //masterConfirmationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterConfirmationDateNode = xmlNode->FirstChildElement("masterConfirmationDate");

   if(masterConfirmationDateNode){masterConfirmationDateIsNull_ = false;}
   else{masterConfirmationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterConfirmationDateNode , address : " << masterConfirmationDateNode << std::endl;
   #endif
   if(masterConfirmationDateNode)
   {
      if(masterConfirmationDateNode->Attribute("href") || masterConfirmationDateNode->Attribute("id"))
      {
          if(masterConfirmationDateNode->Attribute("id"))
          {
             masterConfirmationDateIDRef_ = masterConfirmationDateNode->Attribute("id");
             masterConfirmationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(masterConfirmationDateNode));
             masterConfirmationDate_->setID(masterConfirmationDateIDRef_);
             IDManager::instance().setID(masterConfirmationDateIDRef_,masterConfirmationDate_);
          }
          else if(masterConfirmationDateNode->Attribute("href")) { masterConfirmationDateIDRef_ = masterConfirmationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterConfirmationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(masterConfirmationDateNode));}
   }

   //relatedPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relatedPartyNode = xmlNode->FirstChildElement("relatedParty");

   if(relatedPartyNode){relatedPartyIsNull_ = false;}
   else{relatedPartyIsNull_ = true;}

   if(relatedPartyNode)
   {
      for(relatedPartyNode; relatedPartyNode; relatedPartyNode = relatedPartyNode->NextSiblingElement("relatedParty")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedPartyNode , address : " << relatedPartyNode << std::endl;
          #endif
          if(relatedPartyNode->Attribute("href") || relatedPartyNode->Attribute("id"))
          {
              if(relatedPartyNode->Attribute("id"))
              {
                  relatedPartyIDRef_ = relatedPartyNode->Attribute("id");
                  relatedParty_.push_back(boost::shared_ptr<RelatedParty>(new RelatedParty(relatedPartyNode)));
                  relatedParty_.back()->setID(relatedPartyIDRef_);
                  IDManager::instance().setID(relatedPartyIDRef_, relatedParty_.back());
              }
              else if(relatedPartyNode->Attribute("href")) { relatedPartyIDRef_ = relatedPartyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { relatedParty_.push_back(boost::shared_ptr<RelatedParty>(new RelatedParty(relatedPartyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedPartyNode , address : " << relatedPartyNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<TradeIdentifier>> Allocation::getAllocationTradeId()
{
   if(!this->allocationTradeIdIsNull_){
        if(allocationTradeIdIDRef_ != ""){
             return this->allocationTradeId_;
        }else{
             return this->allocationTradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeIdentifier>>();
   }
}
boost::shared_ptr<PartyReference> Allocation::getPartyReference()
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
boost::shared_ptr<AccountReference> Allocation::getAccountReference()
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
boost::shared_ptr<XsdTypeDecimal> Allocation::getAllocatedFraction()
{
   if(!this->allocatedFractionIsNull_){
        if(allocatedFractionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(allocatedFractionIDRef_));
        }else{
             return this->allocatedFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
std::vector<boost::shared_ptr<Money>> Allocation::getAllocatedNotional()
{
   if(!this->allocatedNotionalIsNull_){
        if(allocatedNotionalIDRef_ != ""){
             return this->allocatedNotional_;
        }else{
             return this->allocatedNotional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Money>>();
   }
}
boost::shared_ptr<Collateral> Allocation::getCollateral()
{
   if(!this->collateralIsNull_){
        if(collateralIDRef_ != ""){
             return boost::shared_static_cast<Collateral>(IDManager::instance().getID(collateralIDRef_));
        }else{
             return this->collateral_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Collateral>();
   }
}
boost::shared_ptr<Money> Allocation::getCreditChargeAmount()
{
   if(!this->creditChargeAmountIsNull_){
        if(creditChargeAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(creditChargeAmountIDRef_));
        }else{
             return this->creditChargeAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<Approvals> Allocation::getApprovals()
{
   if(!this->approvalsIsNull_){
        if(approvalsIDRef_ != ""){
             return boost::shared_static_cast<Approvals>(IDManager::instance().getID(approvalsIDRef_));
        }else{
             return this->approvals_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Approvals>();
   }
}
boost::shared_ptr<XsdTypeDate> Allocation::getMasterConfirmationDate()
{
   if(!this->masterConfirmationDateIsNull_){
        if(masterConfirmationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(masterConfirmationDateIDRef_));
        }else{
             return this->masterConfirmationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
std::vector<boost::shared_ptr<RelatedParty>> Allocation::getRelatedParty()
{
   if(!this->relatedPartyIsNull_){
        if(relatedPartyIDRef_ != ""){
             return this->relatedParty_;
        }else{
             return this->relatedParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RelatedParty>>();
   }
}
}

