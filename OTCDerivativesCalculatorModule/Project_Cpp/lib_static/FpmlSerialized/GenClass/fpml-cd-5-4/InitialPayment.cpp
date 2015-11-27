// InitialPayment.cpp 
#include "InitialPayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InitialPayment::InitialPayment(TiXmlNode* xmlNode)
: PaymentBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //adjustablePaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustablePaymentDateNode = xmlNode->FirstChildElement("adjustablePaymentDate");

   if(adjustablePaymentDateNode){adjustablePaymentDateIsNull_ = false;}
   else{adjustablePaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustablePaymentDateNode , address : " << adjustablePaymentDateNode << std::endl;
   #endif
   if(adjustablePaymentDateNode)
   {
      if(adjustablePaymentDateNode->Attribute("href") || adjustablePaymentDateNode->Attribute("id"))
      {
          if(adjustablePaymentDateNode->Attribute("id"))
          {
             adjustablePaymentDateIDRef_ = adjustablePaymentDateNode->Attribute("id");
             adjustablePaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustablePaymentDateNode));
             adjustablePaymentDate_->setID(adjustablePaymentDateIDRef_);
             IDManager::instance().setID(adjustablePaymentDateIDRef_,adjustablePaymentDate_);
          }
          else if(adjustablePaymentDateNode->Attribute("href")) { adjustablePaymentDateIDRef_ = adjustablePaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustablePaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustablePaymentDateNode));}
   }

   //adjustedPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedPaymentDateNode = xmlNode->FirstChildElement("adjustedPaymentDate");

   if(adjustedPaymentDateNode){adjustedPaymentDateIsNull_ = false;}
   else{adjustedPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedPaymentDateNode , address : " << adjustedPaymentDateNode << std::endl;
   #endif
   if(adjustedPaymentDateNode)
   {
      if(adjustedPaymentDateNode->Attribute("href") || adjustedPaymentDateNode->Attribute("id"))
      {
          if(adjustedPaymentDateNode->Attribute("id"))
          {
             adjustedPaymentDateIDRef_ = adjustedPaymentDateNode->Attribute("id");
             adjustedPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedPaymentDateNode));
             adjustedPaymentDate_->setID(adjustedPaymentDateIDRef_);
             IDManager::instance().setID(adjustedPaymentDateIDRef_,adjustedPaymentDate_);
          }
          else if(adjustedPaymentDateNode->Attribute("href")) { adjustedPaymentDateIDRef_ = adjustedPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedPaymentDateNode));}
   }

   //paymentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentAmountNode = xmlNode->FirstChildElement("paymentAmount");

   if(paymentAmountNode){paymentAmountIsNull_ = false;}
   else{paymentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentAmountNode , address : " << paymentAmountNode << std::endl;
   #endif
   if(paymentAmountNode)
   {
      if(paymentAmountNode->Attribute("href") || paymentAmountNode->Attribute("id"))
      {
          if(paymentAmountNode->Attribute("id"))
          {
             paymentAmountIDRef_ = paymentAmountNode->Attribute("id");
             paymentAmount_ = boost::shared_ptr<Money>(new Money(paymentAmountNode));
             paymentAmount_->setID(paymentAmountIDRef_);
             IDManager::instance().setID(paymentAmountIDRef_,paymentAmount_);
          }
          else if(paymentAmountNode->Attribute("href")) { paymentAmountIDRef_ = paymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentAmount_ = boost::shared_ptr<Money>(new Money(paymentAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> InitialPayment::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> InitialPayment::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> InitialPayment::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> InitialPayment::getReceiverAccountReference()
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
boost::shared_ptr<XsdTypeDate> InitialPayment::getAdjustablePaymentDate()
{
   if(!this->adjustablePaymentDateIsNull_){
        if(adjustablePaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustablePaymentDateIDRef_));
        }else{
             return this->adjustablePaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> InitialPayment::getAdjustedPaymentDate()
{
   if(!this->adjustedPaymentDateIsNull_){
        if(adjustedPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedPaymentDateIDRef_));
        }else{
             return this->adjustedPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<Money> InitialPayment::getPaymentAmount()
{
   if(!this->paymentAmountIsNull_){
        if(paymentAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(paymentAmountIDRef_));
        }else{
             return this->paymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

