// Payment.cpp 
#include "Payment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Payment::Payment(TiXmlNode* xmlNode)
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
             paymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(paymentAmountNode));
             paymentAmount_->setID(paymentAmountIDRef_);
             IDManager::instance().setID(paymentAmountIDRef_,paymentAmount_);
          }
          else if(paymentAmountNode->Attribute("href")) { paymentAmountIDRef_ = paymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(paymentAmountNode));}
   }

   //paymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDateNode = xmlNode->FirstChildElement("paymentDate");

   if(paymentDateNode){paymentDateIsNull_ = false;}
   else{paymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDateNode , address : " << paymentDateNode << std::endl;
   #endif
   if(paymentDateNode)
   {
      if(paymentDateNode->Attribute("href") || paymentDateNode->Attribute("id"))
      {
          if(paymentDateNode->Attribute("id"))
          {
             paymentDateIDRef_ = paymentDateNode->Attribute("id");
             paymentDate_ = boost::shared_ptr<AdjustableOrAdjustedDate>(new AdjustableOrAdjustedDate(paymentDateNode));
             paymentDate_->setID(paymentDateIDRef_);
             IDManager::instance().setID(paymentDateIDRef_,paymentDate_);
          }
          else if(paymentDateNode->Attribute("href")) { paymentDateIDRef_ = paymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDate_ = boost::shared_ptr<AdjustableOrAdjustedDate>(new AdjustableOrAdjustedDate(paymentDateNode));}
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

   //settlementInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementInformationNode = xmlNode->FirstChildElement("settlementInformation");

   if(settlementInformationNode){settlementInformationIsNull_ = false;}
   else{settlementInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementInformationNode , address : " << settlementInformationNode << std::endl;
   #endif
   if(settlementInformationNode)
   {
      if(settlementInformationNode->Attribute("href") || settlementInformationNode->Attribute("id"))
      {
          if(settlementInformationNode->Attribute("id"))
          {
             settlementInformationIDRef_ = settlementInformationNode->Attribute("id");
             settlementInformation_ = boost::shared_ptr<SettlementInformation>(new SettlementInformation(settlementInformationNode));
             settlementInformation_->setID(settlementInformationIDRef_);
             IDManager::instance().setID(settlementInformationIDRef_,settlementInformation_);
          }
          else if(settlementInformationNode->Attribute("href")) { settlementInformationIDRef_ = settlementInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementInformation_ = boost::shared_ptr<SettlementInformation>(new SettlementInformation(settlementInformationNode));}
   }

   //discountFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountFactorNode = xmlNode->FirstChildElement("discountFactor");

   if(discountFactorNode){discountFactorIsNull_ = false;}
   else{discountFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountFactorNode , address : " << discountFactorNode << std::endl;
   #endif
   if(discountFactorNode)
   {
      if(discountFactorNode->Attribute("href") || discountFactorNode->Attribute("id"))
      {
          if(discountFactorNode->Attribute("id"))
          {
             discountFactorIDRef_ = discountFactorNode->Attribute("id");
             discountFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(discountFactorNode));
             discountFactor_->setID(discountFactorIDRef_);
             IDManager::instance().setID(discountFactorIDRef_,discountFactor_);
          }
          else if(discountFactorNode->Attribute("href")) { discountFactorIDRef_ = discountFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discountFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(discountFactorNode));}
   }

   //presentValueAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* presentValueAmountNode = xmlNode->FirstChildElement("presentValueAmount");

   if(presentValueAmountNode){presentValueAmountIsNull_ = false;}
   else{presentValueAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- presentValueAmountNode , address : " << presentValueAmountNode << std::endl;
   #endif
   if(presentValueAmountNode)
   {
      if(presentValueAmountNode->Attribute("href") || presentValueAmountNode->Attribute("id"))
      {
          if(presentValueAmountNode->Attribute("id"))
          {
             presentValueAmountIDRef_ = presentValueAmountNode->Attribute("id");
             presentValueAmount_ = boost::shared_ptr<Money>(new Money(presentValueAmountNode));
             presentValueAmount_->setID(presentValueAmountIDRef_);
             IDManager::instance().setID(presentValueAmountIDRef_,presentValueAmount_);
          }
          else if(presentValueAmountNode->Attribute("href")) { presentValueAmountIDRef_ = presentValueAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { presentValueAmount_ = boost::shared_ptr<Money>(new Money(presentValueAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> Payment::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> Payment::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> Payment::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> Payment::getReceiverAccountReference()
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
boost::shared_ptr<NonNegativeMoney> Payment::getPaymentAmount()
{
   if(!this->paymentAmountIsNull_){
        if(paymentAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(paymentAmountIDRef_));
        }else{
             return this->paymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<AdjustableOrAdjustedDate> Payment::getPaymentDate()
{
   if(!this->paymentDateIsNull_){
        if(paymentDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrAdjustedDate>(IDManager::instance().getID(paymentDateIDRef_));
        }else{
             return this->paymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrAdjustedDate>();
   }
}
boost::shared_ptr<PaymentType> Payment::getPaymentType()
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
boost::shared_ptr<SettlementInformation> Payment::getSettlementInformation()
{
   if(!this->settlementInformationIsNull_){
        if(settlementInformationIDRef_ != ""){
             return boost::shared_static_cast<SettlementInformation>(IDManager::instance().getID(settlementInformationIDRef_));
        }else{
             return this->settlementInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementInformation>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Payment::getDiscountFactor()
{
   if(!this->discountFactorIsNull_){
        if(discountFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(discountFactorIDRef_));
        }else{
             return this->discountFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Money> Payment::getPresentValueAmount()
{
   if(!this->presentValueAmountIsNull_){
        if(presentValueAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(presentValueAmountIDRef_));
        }else{
             return this->presentValueAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

