// EquityPremium.cpp 
#include "EquityPremium.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityPremium::EquityPremium(TiXmlNode* xmlNode)
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

   //premiumTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumTypeNode = xmlNode->FirstChildElement("premiumType");

   if(premiumTypeNode){premiumTypeIsNull_ = false;}
   else{premiumTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumTypeNode , address : " << premiumTypeNode << std::endl;
   #endif
   if(premiumTypeNode)
   {
      if(premiumTypeNode->Attribute("href") || premiumTypeNode->Attribute("id"))
      {
          if(premiumTypeNode->Attribute("id"))
          {
             premiumTypeIDRef_ = premiumTypeNode->Attribute("id");
             premiumType_ = boost::shared_ptr<PremiumTypeEnum>(new PremiumTypeEnum(premiumTypeNode));
             premiumType_->setID(premiumTypeIDRef_);
             IDManager::instance().setID(premiumTypeIDRef_,premiumType_);
          }
          else if(premiumTypeNode->Attribute("href")) { premiumTypeIDRef_ = premiumTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { premiumType_ = boost::shared_ptr<PremiumTypeEnum>(new PremiumTypeEnum(premiumTypeNode));}
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
             paymentDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(paymentDateNode));
             paymentDate_->setID(paymentDateIDRef_);
             IDManager::instance().setID(paymentDateIDRef_,paymentDate_);
          }
          else if(paymentDateNode->Attribute("href")) { paymentDateIDRef_ = paymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(paymentDateNode));}
   }

   //swapPremiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swapPremiumNode = xmlNode->FirstChildElement("swapPremium");

   if(swapPremiumNode){swapPremiumIsNull_ = false;}
   else{swapPremiumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapPremiumNode , address : " << swapPremiumNode << std::endl;
   #endif
   if(swapPremiumNode)
   {
      if(swapPremiumNode->Attribute("href") || swapPremiumNode->Attribute("id"))
      {
          if(swapPremiumNode->Attribute("id"))
          {
             swapPremiumIDRef_ = swapPremiumNode->Attribute("id");
             swapPremium_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(swapPremiumNode));
             swapPremium_->setID(swapPremiumIDRef_);
             IDManager::instance().setID(swapPremiumIDRef_,swapPremium_);
          }
          else if(swapPremiumNode->Attribute("href")) { swapPremiumIDRef_ = swapPremiumNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { swapPremium_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(swapPremiumNode));}
   }

   //pricePerOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricePerOptionNode = xmlNode->FirstChildElement("pricePerOption");

   if(pricePerOptionNode){pricePerOptionIsNull_ = false;}
   else{pricePerOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricePerOptionNode , address : " << pricePerOptionNode << std::endl;
   #endif
   if(pricePerOptionNode)
   {
      if(pricePerOptionNode->Attribute("href") || pricePerOptionNode->Attribute("id"))
      {
          if(pricePerOptionNode->Attribute("id"))
          {
             pricePerOptionIDRef_ = pricePerOptionNode->Attribute("id");
             pricePerOption_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(pricePerOptionNode));
             pricePerOption_->setID(pricePerOptionIDRef_);
             IDManager::instance().setID(pricePerOptionIDRef_,pricePerOption_);
          }
          else if(pricePerOptionNode->Attribute("href")) { pricePerOptionIDRef_ = pricePerOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricePerOption_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(pricePerOptionNode));}
   }

   //percentageOfNotionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* percentageOfNotionalNode = xmlNode->FirstChildElement("percentageOfNotional");

   if(percentageOfNotionalNode){percentageOfNotionalIsNull_ = false;}
   else{percentageOfNotionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- percentageOfNotionalNode , address : " << percentageOfNotionalNode << std::endl;
   #endif
   if(percentageOfNotionalNode)
   {
      if(percentageOfNotionalNode->Attribute("href") || percentageOfNotionalNode->Attribute("id"))
      {
          if(percentageOfNotionalNode->Attribute("id"))
          {
             percentageOfNotionalIDRef_ = percentageOfNotionalNode->Attribute("id");
             percentageOfNotional_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(percentageOfNotionalNode));
             percentageOfNotional_->setID(percentageOfNotionalIDRef_);
             IDManager::instance().setID(percentageOfNotionalIDRef_,percentageOfNotional_);
          }
          else if(percentageOfNotionalNode->Attribute("href")) { percentageOfNotionalIDRef_ = percentageOfNotionalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { percentageOfNotional_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(percentageOfNotionalNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> EquityPremium::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> EquityPremium::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> EquityPremium::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> EquityPremium::getReceiverAccountReference()
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
boost::shared_ptr<PremiumTypeEnum> EquityPremium::getPremiumType()
{
   if(!this->premiumTypeIsNull_){
        if(premiumTypeIDRef_ != ""){
             return boost::shared_static_cast<PremiumTypeEnum>(IDManager::instance().getID(premiumTypeIDRef_));
        }else{
             return this->premiumType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PremiumTypeEnum>();
   }
}
boost::shared_ptr<NonNegativeMoney> EquityPremium::getPaymentAmount()
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
boost::shared_ptr<AdjustableDate> EquityPremium::getPaymentDate()
{
   if(!this->paymentDateIsNull_){
        if(paymentDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(paymentDateIDRef_));
        }else{
             return this->paymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquityPremium::getSwapPremium()
{
   if(!this->swapPremiumIsNull_){
        if(swapPremiumIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(swapPremiumIDRef_));
        }else{
             return this->swapPremium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<NonNegativeMoney> EquityPremium::getPricePerOption()
{
   if(!this->pricePerOptionIsNull_){
        if(pricePerOptionIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(pricePerOptionIDRef_));
        }else{
             return this->pricePerOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<NonNegativeDecimal> EquityPremium::getPercentageOfNotional()
{
   if(!this->percentageOfNotionalIsNull_){
        if(percentageOfNotionalIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(percentageOfNotionalIDRef_));
        }else{
             return this->percentageOfNotional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
}

