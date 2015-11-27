// NonPeriodicFixedPriceLeg.cpp 
#include "NonPeriodicFixedPriceLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NonPeriodicFixedPriceLeg::NonPeriodicFixedPriceLeg(TiXmlNode* xmlNode)
: CommoditySwapLeg(xmlNode)
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

   //fixedPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedPriceNode = xmlNode->FirstChildElement("fixedPrice");

   if(fixedPriceNode){fixedPriceIsNull_ = false;}
   else{fixedPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedPriceNode , address : " << fixedPriceNode << std::endl;
   #endif
   if(fixedPriceNode)
   {
      if(fixedPriceNode->Attribute("href") || fixedPriceNode->Attribute("id"))
      {
          if(fixedPriceNode->Attribute("id"))
          {
             fixedPriceIDRef_ = fixedPriceNode->Attribute("id");
             fixedPrice_ = boost::shared_ptr<FixedPrice>(new FixedPrice(fixedPriceNode));
             fixedPrice_->setID(fixedPriceIDRef_);
             IDManager::instance().setID(fixedPriceIDRef_,fixedPrice_);
          }
          else if(fixedPriceNode->Attribute("href")) { fixedPriceIDRef_ = fixedPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedPrice_ = boost::shared_ptr<FixedPrice>(new FixedPrice(fixedPriceNode));}
   }

   //totalPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* totalPriceNode = xmlNode->FirstChildElement("totalPrice");

   if(totalPriceNode){totalPriceIsNull_ = false;}
   else{totalPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- totalPriceNode , address : " << totalPriceNode << std::endl;
   #endif
   if(totalPriceNode)
   {
      if(totalPriceNode->Attribute("href") || totalPriceNode->Attribute("id"))
      {
          if(totalPriceNode->Attribute("id"))
          {
             totalPriceIDRef_ = totalPriceNode->Attribute("id");
             totalPrice_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(totalPriceNode));
             totalPrice_->setID(totalPriceIDRef_);
             IDManager::instance().setID(totalPriceIDRef_,totalPrice_);
          }
          else if(totalPriceNode->Attribute("href")) { totalPriceIDRef_ = totalPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { totalPrice_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(totalPriceNode));}
   }

   //quantityReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quantityReferenceNode = xmlNode->FirstChildElement("quantityReference");

   if(quantityReferenceNode){quantityReferenceIsNull_ = false;}
   else{quantityReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quantityReferenceNode , address : " << quantityReferenceNode << std::endl;
   #endif
   if(quantityReferenceNode)
   {
      if(quantityReferenceNode->Attribute("href") || quantityReferenceNode->Attribute("id"))
      {
          if(quantityReferenceNode->Attribute("id"))
          {
             quantityReferenceIDRef_ = quantityReferenceNode->Attribute("id");
             quantityReference_ = boost::shared_ptr<QuantityReference>(new QuantityReference(quantityReferenceNode));
             quantityReference_->setID(quantityReferenceIDRef_);
             IDManager::instance().setID(quantityReferenceIDRef_,quantityReference_);
          }
          else if(quantityReferenceNode->Attribute("href")) { quantityReferenceIDRef_ = quantityReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quantityReference_ = boost::shared_ptr<QuantityReference>(new QuantityReference(quantityReferenceNode));}
   }

   //relativePaymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativePaymentDatesNode = xmlNode->FirstChildElement("relativePaymentDates");

   if(relativePaymentDatesNode){relativePaymentDatesIsNull_ = false;}
   else{relativePaymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativePaymentDatesNode , address : " << relativePaymentDatesNode << std::endl;
   #endif
   if(relativePaymentDatesNode)
   {
      if(relativePaymentDatesNode->Attribute("href") || relativePaymentDatesNode->Attribute("id"))
      {
          if(relativePaymentDatesNode->Attribute("id"))
          {
             relativePaymentDatesIDRef_ = relativePaymentDatesNode->Attribute("id");
             relativePaymentDates_ = boost::shared_ptr<CommodityRelativePaymentDates>(new CommodityRelativePaymentDates(relativePaymentDatesNode));
             relativePaymentDates_->setID(relativePaymentDatesIDRef_);
             IDManager::instance().setID(relativePaymentDatesIDRef_,relativePaymentDates_);
          }
          else if(relativePaymentDatesNode->Attribute("href")) { relativePaymentDatesIDRef_ = relativePaymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativePaymentDates_ = boost::shared_ptr<CommodityRelativePaymentDates>(new CommodityRelativePaymentDates(relativePaymentDatesNode));}
   }

   //paymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDatesNode = xmlNode->FirstChildElement("paymentDates");

   if(paymentDatesNode){paymentDatesIsNull_ = false;}
   else{paymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDatesNode , address : " << paymentDatesNode << std::endl;
   #endif
   if(paymentDatesNode)
   {
      if(paymentDatesNode->Attribute("href") || paymentDatesNode->Attribute("id"))
      {
          if(paymentDatesNode->Attribute("id"))
          {
             paymentDatesIDRef_ = paymentDatesNode->Attribute("id");
             paymentDates_ = boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>(new AdjustableDatesOrRelativeDateOffset(paymentDatesNode));
             paymentDates_->setID(paymentDatesIDRef_);
             IDManager::instance().setID(paymentDatesIDRef_,paymentDates_);
          }
          else if(paymentDatesNode->Attribute("href")) { paymentDatesIDRef_ = paymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDates_ = boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>(new AdjustableDatesOrRelativeDateOffset(paymentDatesNode));}
   }

   //masterAgreementPaymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterAgreementPaymentDatesNode = xmlNode->FirstChildElement("masterAgreementPaymentDates");

   if(masterAgreementPaymentDatesNode){masterAgreementPaymentDatesIsNull_ = false;}
   else{masterAgreementPaymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterAgreementPaymentDatesNode , address : " << masterAgreementPaymentDatesNode << std::endl;
   #endif
   if(masterAgreementPaymentDatesNode)
   {
      if(masterAgreementPaymentDatesNode->Attribute("href") || masterAgreementPaymentDatesNode->Attribute("id"))
      {
          if(masterAgreementPaymentDatesNode->Attribute("id"))
          {
             masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode->Attribute("id");
             masterAgreementPaymentDates_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(masterAgreementPaymentDatesNode));
             masterAgreementPaymentDates_->setID(masterAgreementPaymentDatesIDRef_);
             IDManager::instance().setID(masterAgreementPaymentDatesIDRef_,masterAgreementPaymentDates_);
          }
          else if(masterAgreementPaymentDatesNode->Attribute("href")) { masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterAgreementPaymentDates_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(masterAgreementPaymentDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> NonPeriodicFixedPriceLeg::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> NonPeriodicFixedPriceLeg::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> NonPeriodicFixedPriceLeg::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> NonPeriodicFixedPriceLeg::getReceiverAccountReference()
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
boost::shared_ptr<FixedPrice> NonPeriodicFixedPriceLeg::getFixedPrice()
{
   if(!this->fixedPriceIsNull_){
        if(fixedPriceIDRef_ != ""){
             return boost::shared_static_cast<FixedPrice>(IDManager::instance().getID(fixedPriceIDRef_));
        }else{
             return this->fixedPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedPrice>();
   }
}
boost::shared_ptr<NonNegativeMoney> NonPeriodicFixedPriceLeg::getTotalPrice()
{
   if(!this->totalPriceIsNull_){
        if(totalPriceIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(totalPriceIDRef_));
        }else{
             return this->totalPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<QuantityReference> NonPeriodicFixedPriceLeg::getQuantityReference()
{
   if(!this->quantityReferenceIsNull_){
        if(quantityReferenceIDRef_ != ""){
             return boost::shared_static_cast<QuantityReference>(IDManager::instance().getID(quantityReferenceIDRef_));
        }else{
             return this->quantityReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuantityReference>();
   }
}
boost::shared_ptr<CommodityRelativePaymentDates> NonPeriodicFixedPriceLeg::getRelativePaymentDates()
{
   if(!this->relativePaymentDatesIsNull_){
        if(relativePaymentDatesIDRef_ != ""){
             return boost::shared_static_cast<CommodityRelativePaymentDates>(IDManager::instance().getID(relativePaymentDatesIDRef_));
        }else{
             return this->relativePaymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityRelativePaymentDates>();
   }
}
boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> NonPeriodicFixedPriceLeg::getPaymentDates()
{
   if(!this->paymentDatesIsNull_){
        if(paymentDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDatesOrRelativeDateOffset>(IDManager::instance().getID(paymentDatesIDRef_));
        }else{
             return this->paymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>();
   }
}
boost::shared_ptr<XsdTypeBoolean> NonPeriodicFixedPriceLeg::getMasterAgreementPaymentDates()
{
   if(!this->masterAgreementPaymentDatesIsNull_){
        if(masterAgreementPaymentDatesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(masterAgreementPaymentDatesIDRef_));
        }else{
             return this->masterAgreementPaymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

