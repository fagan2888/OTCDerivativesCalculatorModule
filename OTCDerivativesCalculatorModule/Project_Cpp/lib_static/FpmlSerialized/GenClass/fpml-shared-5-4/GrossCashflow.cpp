// GrossCashflow.cpp 
#include "GrossCashflow.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GrossCashflow::GrossCashflow(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //cashflowIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashflowIdNode = xmlNode->FirstChildElement("cashflowId");

   if(cashflowIdNode){cashflowIdIsNull_ = false;}
   else{cashflowIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashflowIdNode , address : " << cashflowIdNode << std::endl;
   #endif
   if(cashflowIdNode)
   {
      if(cashflowIdNode->Attribute("href") || cashflowIdNode->Attribute("id"))
      {
          if(cashflowIdNode->Attribute("id"))
          {
             cashflowIdIDRef_ = cashflowIdNode->Attribute("id");
             cashflowId_ = boost::shared_ptr<CashflowId>(new CashflowId(cashflowIdNode));
             cashflowId_->setID(cashflowIdIDRef_);
             IDManager::instance().setID(cashflowIdIDRef_,cashflowId_);
          }
          else if(cashflowIdNode->Attribute("href")) { cashflowIdIDRef_ = cashflowIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashflowId_ = boost::shared_ptr<CashflowId>(new CashflowId(cashflowIdNode));}
   }

   //partyTradeIdentifierReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyTradeIdentifierReferenceNode = xmlNode->FirstChildElement("partyTradeIdentifierReference");

   if(partyTradeIdentifierReferenceNode){partyTradeIdentifierReferenceIsNull_ = false;}
   else{partyTradeIdentifierReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeIdentifierReferenceNode , address : " << partyTradeIdentifierReferenceNode << std::endl;
   #endif
   if(partyTradeIdentifierReferenceNode)
   {
      if(partyTradeIdentifierReferenceNode->Attribute("href") || partyTradeIdentifierReferenceNode->Attribute("id"))
      {
          if(partyTradeIdentifierReferenceNode->Attribute("id"))
          {
             partyTradeIdentifierReferenceIDRef_ = partyTradeIdentifierReferenceNode->Attribute("id");
             partyTradeIdentifierReference_ = boost::shared_ptr<PartyTradeIdentifierReference>(new PartyTradeIdentifierReference(partyTradeIdentifierReferenceNode));
             partyTradeIdentifierReference_->setID(partyTradeIdentifierReferenceIDRef_);
             IDManager::instance().setID(partyTradeIdentifierReferenceIDRef_,partyTradeIdentifierReference_);
          }
          else if(partyTradeIdentifierReferenceNode->Attribute("href")) { partyTradeIdentifierReferenceIDRef_ = partyTradeIdentifierReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyTradeIdentifierReference_ = boost::shared_ptr<PartyTradeIdentifierReference>(new PartyTradeIdentifierReference(partyTradeIdentifierReferenceNode));}
   }

   //payerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payerPartyReferenceNode = xmlNode->FirstChildElement("payerPartyReference");

   if(payerPartyReferenceNode){payerPartyReferenceIsNull_ = false;}
   else{payerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payerPartyReferenceNode , address : " << payerPartyReferenceNode << std::endl;
   #endif
   if(payerPartyReferenceNode)
   {
      if(payerPartyReferenceNode->Attribute("href") || payerPartyReferenceNode->Attribute("id"))
      {
          if(payerPartyReferenceNode->Attribute("id"))
          {
             payerPartyReferenceIDRef_ = payerPartyReferenceNode->Attribute("id");
             payerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(payerPartyReferenceNode));
             payerPartyReference_->setID(payerPartyReferenceIDRef_);
             IDManager::instance().setID(payerPartyReferenceIDRef_,payerPartyReference_);
          }
          else if(payerPartyReferenceNode->Attribute("href")) { payerPartyReferenceIDRef_ = payerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(payerPartyReferenceNode));}
   }

   //payerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payerAccountReferenceNode = xmlNode->FirstChildElement("payerAccountReference");

   if(payerAccountReferenceNode){payerAccountReferenceIsNull_ = false;}
   else{payerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payerAccountReferenceNode , address : " << payerAccountReferenceNode << std::endl;
   #endif
   if(payerAccountReferenceNode)
   {
      if(payerAccountReferenceNode->Attribute("href") || payerAccountReferenceNode->Attribute("id"))
      {
          if(payerAccountReferenceNode->Attribute("id"))
          {
             payerAccountReferenceIDRef_ = payerAccountReferenceNode->Attribute("id");
             payerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(payerAccountReferenceNode));
             payerAccountReference_->setID(payerAccountReferenceIDRef_);
             IDManager::instance().setID(payerAccountReferenceIDRef_,payerAccountReference_);
          }
          else if(payerAccountReferenceNode->Attribute("href")) { payerAccountReferenceIDRef_ = payerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(payerAccountReferenceNode));}
   }

   //receiverPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* receiverPartyReferenceNode = xmlNode->FirstChildElement("receiverPartyReference");

   if(receiverPartyReferenceNode){receiverPartyReferenceIsNull_ = false;}
   else{receiverPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- receiverPartyReferenceNode , address : " << receiverPartyReferenceNode << std::endl;
   #endif
   if(receiverPartyReferenceNode)
   {
      if(receiverPartyReferenceNode->Attribute("href") || receiverPartyReferenceNode->Attribute("id"))
      {
          if(receiverPartyReferenceNode->Attribute("id"))
          {
             receiverPartyReferenceIDRef_ = receiverPartyReferenceNode->Attribute("id");
             receiverPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(receiverPartyReferenceNode));
             receiverPartyReference_->setID(receiverPartyReferenceIDRef_);
             IDManager::instance().setID(receiverPartyReferenceIDRef_,receiverPartyReference_);
          }
          else if(receiverPartyReferenceNode->Attribute("href")) { receiverPartyReferenceIDRef_ = receiverPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { receiverPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(receiverPartyReferenceNode));}
   }

   //receiverAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* receiverAccountReferenceNode = xmlNode->FirstChildElement("receiverAccountReference");

   if(receiverAccountReferenceNode){receiverAccountReferenceIsNull_ = false;}
   else{receiverAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- receiverAccountReferenceNode , address : " << receiverAccountReferenceNode << std::endl;
   #endif
   if(receiverAccountReferenceNode)
   {
      if(receiverAccountReferenceNode->Attribute("href") || receiverAccountReferenceNode->Attribute("id"))
      {
          if(receiverAccountReferenceNode->Attribute("id"))
          {
             receiverAccountReferenceIDRef_ = receiverAccountReferenceNode->Attribute("id");
             receiverAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(receiverAccountReferenceNode));
             receiverAccountReference_->setID(receiverAccountReferenceIDRef_);
             IDManager::instance().setID(receiverAccountReferenceIDRef_,receiverAccountReference_);
          }
          else if(receiverAccountReferenceNode->Attribute("href")) { receiverAccountReferenceIDRef_ = receiverAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { receiverAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(receiverAccountReferenceNode));}
   }

   //cashflowAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashflowAmountNode = xmlNode->FirstChildElement("cashflowAmount");

   if(cashflowAmountNode){cashflowAmountIsNull_ = false;}
   else{cashflowAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashflowAmountNode , address : " << cashflowAmountNode << std::endl;
   #endif
   if(cashflowAmountNode)
   {
      if(cashflowAmountNode->Attribute("href") || cashflowAmountNode->Attribute("id"))
      {
          if(cashflowAmountNode->Attribute("id"))
          {
             cashflowAmountIDRef_ = cashflowAmountNode->Attribute("id");
             cashflowAmount_ = boost::shared_ptr<Money>(new Money(cashflowAmountNode));
             cashflowAmount_->setID(cashflowAmountIDRef_);
             IDManager::instance().setID(cashflowAmountIDRef_,cashflowAmount_);
          }
          else if(cashflowAmountNode->Attribute("href")) { cashflowAmountIDRef_ = cashflowAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashflowAmount_ = boost::shared_ptr<Money>(new Money(cashflowAmountNode));}
   }

   //cashflowTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashflowTypeNode = xmlNode->FirstChildElement("cashflowType");

   if(cashflowTypeNode){cashflowTypeIsNull_ = false;}
   else{cashflowTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashflowTypeNode , address : " << cashflowTypeNode << std::endl;
   #endif
   if(cashflowTypeNode)
   {
      if(cashflowTypeNode->Attribute("href") || cashflowTypeNode->Attribute("id"))
      {
          if(cashflowTypeNode->Attribute("id"))
          {
             cashflowTypeIDRef_ = cashflowTypeNode->Attribute("id");
             cashflowType_ = boost::shared_ptr<CashflowType>(new CashflowType(cashflowTypeNode));
             cashflowType_->setID(cashflowTypeIDRef_);
             IDManager::instance().setID(cashflowTypeIDRef_,cashflowType_);
          }
          else if(cashflowTypeNode->Attribute("href")) { cashflowTypeIDRef_ = cashflowTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashflowType_ = boost::shared_ptr<CashflowType>(new CashflowType(cashflowTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CashflowId> GrossCashflow::getCashflowId()
{
   if(!this->cashflowIdIsNull_){
        if(cashflowIdIDRef_ != ""){
             return boost::shared_static_cast<CashflowId>(IDManager::instance().getID(cashflowIdIDRef_));
        }else{
             return this->cashflowId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashflowId>();
   }
}
boost::shared_ptr<PartyTradeIdentifierReference> GrossCashflow::getPartyTradeIdentifierReference()
{
   if(!this->partyTradeIdentifierReferenceIsNull_){
        if(partyTradeIdentifierReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyTradeIdentifierReference>(IDManager::instance().getID(partyTradeIdentifierReferenceIDRef_));
        }else{
             return this->partyTradeIdentifierReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyTradeIdentifierReference>();
   }
}
boost::shared_ptr<PartyReference> GrossCashflow::getPayerPartyReference()
{
   if(!this->payerPartyReferenceIsNull_){
        if(payerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(payerPartyReferenceIDRef_));
        }else{
             return this->payerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> GrossCashflow::getPayerAccountReference()
{
   if(!this->payerAccountReferenceIsNull_){
        if(payerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(payerAccountReferenceIDRef_));
        }else{
             return this->payerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> GrossCashflow::getReceiverPartyReference()
{
   if(!this->receiverPartyReferenceIsNull_){
        if(receiverPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(receiverPartyReferenceIDRef_));
        }else{
             return this->receiverPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> GrossCashflow::getReceiverAccountReference()
{
   if(!this->receiverAccountReferenceIsNull_){
        if(receiverAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(receiverAccountReferenceIDRef_));
        }else{
             return this->receiverAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<Money> GrossCashflow::getCashflowAmount()
{
   if(!this->cashflowAmountIsNull_){
        if(cashflowAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(cashflowAmountIDRef_));
        }else{
             return this->cashflowAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<CashflowType> GrossCashflow::getCashflowType()
{
   if(!this->cashflowTypeIsNull_){
        if(cashflowTypeIDRef_ != ""){
             return boost::shared_static_cast<CashflowType>(IDManager::instance().getID(cashflowTypeIDRef_));
        }else{
             return this->cashflowType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashflowType>();
   }
}
}

