// ReturnSwapAdditionalPayment.cpp 
#include "ReturnSwapAdditionalPayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnSwapAdditionalPayment::ReturnSwapAdditionalPayment(TiXmlNode* xmlNode)
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

   //additionalPaymentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalPaymentAmountNode = xmlNode->FirstChildElement("additionalPaymentAmount");

   if(additionalPaymentAmountNode){additionalPaymentAmountIsNull_ = false;}
   else{additionalPaymentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalPaymentAmountNode , address : " << additionalPaymentAmountNode << std::endl;
   #endif
   if(additionalPaymentAmountNode)
   {
      if(additionalPaymentAmountNode->Attribute("href") || additionalPaymentAmountNode->Attribute("id"))
      {
          if(additionalPaymentAmountNode->Attribute("id"))
          {
             additionalPaymentAmountIDRef_ = additionalPaymentAmountNode->Attribute("id");
             additionalPaymentAmount_ = boost::shared_ptr<AdditionalPaymentAmount>(new AdditionalPaymentAmount(additionalPaymentAmountNode));
             additionalPaymentAmount_->setID(additionalPaymentAmountIDRef_);
             IDManager::instance().setID(additionalPaymentAmountIDRef_,additionalPaymentAmount_);
          }
          else if(additionalPaymentAmountNode->Attribute("href")) { additionalPaymentAmountIDRef_ = additionalPaymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalPaymentAmount_ = boost::shared_ptr<AdditionalPaymentAmount>(new AdditionalPaymentAmount(additionalPaymentAmountNode));}
   }

   //additionalPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalPaymentDateNode = xmlNode->FirstChildElement("additionalPaymentDate");

   if(additionalPaymentDateNode){additionalPaymentDateIsNull_ = false;}
   else{additionalPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalPaymentDateNode , address : " << additionalPaymentDateNode << std::endl;
   #endif
   if(additionalPaymentDateNode)
   {
      if(additionalPaymentDateNode->Attribute("href") || additionalPaymentDateNode->Attribute("id"))
      {
          if(additionalPaymentDateNode->Attribute("id"))
          {
             additionalPaymentDateIDRef_ = additionalPaymentDateNode->Attribute("id");
             additionalPaymentDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(additionalPaymentDateNode));
             additionalPaymentDate_->setID(additionalPaymentDateIDRef_);
             IDManager::instance().setID(additionalPaymentDateIDRef_,additionalPaymentDate_);
          }
          else if(additionalPaymentDateNode->Attribute("href")) { additionalPaymentDateIDRef_ = additionalPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalPaymentDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(additionalPaymentDateNode));}
   }

   //paymentTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentTypeNode = xmlNode->FirstChildElement("paymentType");

   if(paymentTypeNode){paymentTypeIsNull_ = false;}
   else{paymentTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentTypeNode , address : " << paymentTypeNode << std::endl;
   #endif
   if(paymentTypeNode)
   {
      if(paymentTypeNode->Attribute("href") || paymentTypeNode->Attribute("id"))
      {
          if(paymentTypeNode->Attribute("id"))
          {
             paymentTypeIDRef_ = paymentTypeNode->Attribute("id");
             paymentType_ = boost::shared_ptr<PaymentType>(new PaymentType(paymentTypeNode));
             paymentType_->setID(paymentTypeIDRef_);
             IDManager::instance().setID(paymentTypeIDRef_,paymentType_);
          }
          else if(paymentTypeNode->Attribute("href")) { paymentTypeIDRef_ = paymentTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentType_ = boost::shared_ptr<PaymentType>(new PaymentType(paymentTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ReturnSwapAdditionalPayment::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> ReturnSwapAdditionalPayment::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> ReturnSwapAdditionalPayment::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> ReturnSwapAdditionalPayment::getReceiverAccountReference()
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
boost::shared_ptr<AdditionalPaymentAmount> ReturnSwapAdditionalPayment::getAdditionalPaymentAmount()
{
   if(!this->additionalPaymentAmountIsNull_){
        if(additionalPaymentAmountIDRef_ != ""){
             return boost::shared_static_cast<AdditionalPaymentAmount>(IDManager::instance().getID(additionalPaymentAmountIDRef_));
        }else{
             return this->additionalPaymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdditionalPaymentAmount>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> ReturnSwapAdditionalPayment::getAdditionalPaymentDate()
{
   if(!this->additionalPaymentDateIsNull_){
        if(additionalPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(additionalPaymentDateIDRef_));
        }else{
             return this->additionalPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<PaymentType> ReturnSwapAdditionalPayment::getPaymentType()
{
   if(!this->paymentTypeIsNull_){
        if(paymentTypeIDRef_ != ""){
             return boost::shared_static_cast<PaymentType>(IDManager::instance().getID(paymentTypeIDRef_));
        }else{
             return this->paymentType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PaymentType>();
   }
}
}

