// AveragePriceLeg.cpp 
#include "AveragePriceLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AveragePriceLeg::AveragePriceLeg(TiXmlNode* xmlNode)
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

   //calculationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationDatesNode = xmlNode->FirstChildElement("calculationDates");

   if(calculationDatesNode){calculationDatesIsNull_ = false;}
   else{calculationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationDatesNode , address : " << calculationDatesNode << std::endl;
   #endif
   if(calculationDatesNode)
   {
      if(calculationDatesNode->Attribute("href") || calculationDatesNode->Attribute("id"))
      {
          if(calculationDatesNode->Attribute("id"))
          {
             calculationDatesIDRef_ = calculationDatesNode->Attribute("id");
             calculationDates_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(calculationDatesNode));
             calculationDates_->setID(calculationDatesIDRef_);
             IDManager::instance().setID(calculationDatesIDRef_,calculationDates_);
          }
          else if(calculationDatesNode->Attribute("href")) { calculationDatesIDRef_ = calculationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationDates_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(calculationDatesNode));}
   }

   //calculationPeriodsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodsNode = xmlNode->FirstChildElement("calculationPeriods");

   if(calculationPeriodsNode){calculationPeriodsIsNull_ = false;}
   else{calculationPeriodsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodsNode , address : " << calculationPeriodsNode << std::endl;
   #endif
   if(calculationPeriodsNode)
   {
      if(calculationPeriodsNode->Attribute("href") || calculationPeriodsNode->Attribute("id"))
      {
          if(calculationPeriodsNode->Attribute("id"))
          {
             calculationPeriodsIDRef_ = calculationPeriodsNode->Attribute("id");
             calculationPeriods_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(calculationPeriodsNode));
             calculationPeriods_->setID(calculationPeriodsIDRef_);
             IDManager::instance().setID(calculationPeriodsIDRef_,calculationPeriods_);
          }
          else if(calculationPeriodsNode->Attribute("href")) { calculationPeriodsIDRef_ = calculationPeriodsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriods_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(calculationPeriodsNode));}
   }

   //calculationPeriodsScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodsScheduleNode = xmlNode->FirstChildElement("calculationPeriodsSchedule");

   if(calculationPeriodsScheduleNode){calculationPeriodsScheduleIsNull_ = false;}
   else{calculationPeriodsScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodsScheduleNode , address : " << calculationPeriodsScheduleNode << std::endl;
   #endif
   if(calculationPeriodsScheduleNode)
   {
      if(calculationPeriodsScheduleNode->Attribute("href") || calculationPeriodsScheduleNode->Attribute("id"))
      {
          if(calculationPeriodsScheduleNode->Attribute("id"))
          {
             calculationPeriodsScheduleIDRef_ = calculationPeriodsScheduleNode->Attribute("id");
             calculationPeriodsSchedule_ = boost::shared_ptr<CommodityCalculationPeriodsSchedule>(new CommodityCalculationPeriodsSchedule(calculationPeriodsScheduleNode));
             calculationPeriodsSchedule_->setID(calculationPeriodsScheduleIDRef_);
             IDManager::instance().setID(calculationPeriodsScheduleIDRef_,calculationPeriodsSchedule_);
          }
          else if(calculationPeriodsScheduleNode->Attribute("href")) { calculationPeriodsScheduleIDRef_ = calculationPeriodsScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodsSchedule_ = boost::shared_ptr<CommodityCalculationPeriodsSchedule>(new CommodityCalculationPeriodsSchedule(calculationPeriodsScheduleNode));}
   }

   //calculationPeriodsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodsReferenceNode = xmlNode->FirstChildElement("calculationPeriodsReference");

   if(calculationPeriodsReferenceNode){calculationPeriodsReferenceIsNull_ = false;}
   else{calculationPeriodsReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodsReferenceNode , address : " << calculationPeriodsReferenceNode << std::endl;
   #endif
   if(calculationPeriodsReferenceNode)
   {
      if(calculationPeriodsReferenceNode->Attribute("href") || calculationPeriodsReferenceNode->Attribute("id"))
      {
          if(calculationPeriodsReferenceNode->Attribute("id"))
          {
             calculationPeriodsReferenceIDRef_ = calculationPeriodsReferenceNode->Attribute("id");
             calculationPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(calculationPeriodsReferenceNode));
             calculationPeriodsReference_->setID(calculationPeriodsReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodsReferenceIDRef_,calculationPeriodsReference_);
          }
          else if(calculationPeriodsReferenceNode->Attribute("href")) { calculationPeriodsReferenceIDRef_ = calculationPeriodsReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(calculationPeriodsReferenceNode));}
   }

   //calculationPeriodsScheduleReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodsScheduleReferenceNode = xmlNode->FirstChildElement("calculationPeriodsScheduleReference");

   if(calculationPeriodsScheduleReferenceNode){calculationPeriodsScheduleReferenceIsNull_ = false;}
   else{calculationPeriodsScheduleReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodsScheduleReferenceNode , address : " << calculationPeriodsScheduleReferenceNode << std::endl;
   #endif
   if(calculationPeriodsScheduleReferenceNode)
   {
      if(calculationPeriodsScheduleReferenceNode->Attribute("href") || calculationPeriodsScheduleReferenceNode->Attribute("id"))
      {
          if(calculationPeriodsScheduleReferenceNode->Attribute("id"))
          {
             calculationPeriodsScheduleReferenceIDRef_ = calculationPeriodsScheduleReferenceNode->Attribute("id");
             calculationPeriodsScheduleReference_ = boost::shared_ptr<CalculationPeriodsScheduleReference>(new CalculationPeriodsScheduleReference(calculationPeriodsScheduleReferenceNode));
             calculationPeriodsScheduleReference_->setID(calculationPeriodsScheduleReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodsScheduleReferenceIDRef_,calculationPeriodsScheduleReference_);
          }
          else if(calculationPeriodsScheduleReferenceNode->Attribute("href")) { calculationPeriodsScheduleReferenceIDRef_ = calculationPeriodsScheduleReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodsScheduleReference_ = boost::shared_ptr<CalculationPeriodsScheduleReference>(new CalculationPeriodsScheduleReference(calculationPeriodsScheduleReferenceNode));}
   }

   //calculationPeriodsDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodsDatesReferenceNode = xmlNode->FirstChildElement("calculationPeriodsDatesReference");

   if(calculationPeriodsDatesReferenceNode){calculationPeriodsDatesReferenceIsNull_ = false;}
   else{calculationPeriodsDatesReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodsDatesReferenceNode , address : " << calculationPeriodsDatesReferenceNode << std::endl;
   #endif
   if(calculationPeriodsDatesReferenceNode)
   {
      if(calculationPeriodsDatesReferenceNode->Attribute("href") || calculationPeriodsDatesReferenceNode->Attribute("id"))
      {
          if(calculationPeriodsDatesReferenceNode->Attribute("id"))
          {
             calculationPeriodsDatesReferenceIDRef_ = calculationPeriodsDatesReferenceNode->Attribute("id");
             calculationPeriodsDatesReference_ = boost::shared_ptr<CalculationPeriodsDatesReference>(new CalculationPeriodsDatesReference(calculationPeriodsDatesReferenceNode));
             calculationPeriodsDatesReference_->setID(calculationPeriodsDatesReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodsDatesReferenceIDRef_,calculationPeriodsDatesReference_);
          }
          else if(calculationPeriodsDatesReferenceNode->Attribute("href")) { calculationPeriodsDatesReferenceIDRef_ = calculationPeriodsDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodsDatesReference_ = boost::shared_ptr<CalculationPeriodsDatesReference>(new CalculationPeriodsDatesReference(calculationPeriodsDatesReferenceNode));}
   }

   //commodityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityNode = xmlNode->FirstChildElement("commodity");

   if(commodityNode){commodityIsNull_ = false;}
   else{commodityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityNode , address : " << commodityNode << std::endl;
   #endif
   if(commodityNode)
   {
      if(commodityNode->Attribute("href") || commodityNode->Attribute("id"))
      {
          if(commodityNode->Attribute("id"))
          {
             commodityIDRef_ = commodityNode->Attribute("id");
             commodity_ = boost::shared_ptr<Commodity>(new Commodity(commodityNode));
             commodity_->setID(commodityIDRef_);
             IDManager::instance().setID(commodityIDRef_,commodity_);
          }
          else if(commodityNode->Attribute("href")) { commodityIDRef_ = commodityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodity_ = boost::shared_ptr<Commodity>(new Commodity(commodityNode));}
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

   //pricingStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingStartDateNode = xmlNode->FirstChildElement("pricingStartDate");

   if(pricingStartDateNode){pricingStartDateIsNull_ = false;}
   else{pricingStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingStartDateNode , address : " << pricingStartDateNode << std::endl;
   #endif
   if(pricingStartDateNode)
   {
      if(pricingStartDateNode->Attribute("href") || pricingStartDateNode->Attribute("id"))
      {
          if(pricingStartDateNode->Attribute("id"))
          {
             pricingStartDateIDRef_ = pricingStartDateNode->Attribute("id");
             pricingStartDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(pricingStartDateNode));
             pricingStartDate_->setID(pricingStartDateIDRef_);
             IDManager::instance().setID(pricingStartDateIDRef_,pricingStartDate_);
          }
          else if(pricingStartDateNode->Attribute("href")) { pricingStartDateIDRef_ = pricingStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingStartDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(pricingStartDateNode));}
   }

   //calculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationNode = xmlNode->FirstChildElement("calculation");

   if(calculationNode){calculationIsNull_ = false;}
   else{calculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationNode , address : " << calculationNode << std::endl;
   #endif
   if(calculationNode)
   {
      if(calculationNode->Attribute("href") || calculationNode->Attribute("id"))
      {
          if(calculationNode->Attribute("id"))
          {
             calculationIDRef_ = calculationNode->Attribute("id");
             calculation_ = boost::shared_ptr<FloatingLegCalculation>(new FloatingLegCalculation(calculationNode));
             calculation_->setID(calculationIDRef_);
             IDManager::instance().setID(calculationIDRef_,calculation_);
          }
          else if(calculationNode->Attribute("href")) { calculationIDRef_ = calculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculation_ = boost::shared_ptr<FloatingLegCalculation>(new FloatingLegCalculation(calculationNode));}
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
boost::shared_ptr<PartyReference> AveragePriceLeg::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> AveragePriceLeg::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> AveragePriceLeg::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> AveragePriceLeg::getReceiverAccountReference()
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
boost::shared_ptr<AdjustableDates> AveragePriceLeg::getCalculationDates()
{
   if(!this->calculationDatesIsNull_){
        if(calculationDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDates>(IDManager::instance().getID(calculationDatesIDRef_));
        }else{
             return this->calculationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDates>();
   }
}
boost::shared_ptr<AdjustableDates> AveragePriceLeg::getCalculationPeriods()
{
   if(!this->calculationPeriodsIsNull_){
        if(calculationPeriodsIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDates>(IDManager::instance().getID(calculationPeriodsIDRef_));
        }else{
             return this->calculationPeriods_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDates>();
   }
}
boost::shared_ptr<CommodityCalculationPeriodsSchedule> AveragePriceLeg::getCalculationPeriodsSchedule()
{
   if(!this->calculationPeriodsScheduleIsNull_){
        if(calculationPeriodsScheduleIDRef_ != ""){
             return boost::shared_static_cast<CommodityCalculationPeriodsSchedule>(IDManager::instance().getID(calculationPeriodsScheduleIDRef_));
        }else{
             return this->calculationPeriodsSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityCalculationPeriodsSchedule>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> AveragePriceLeg::getCalculationPeriodsReference()
{
   if(!this->calculationPeriodsReferenceIsNull_){
        if(calculationPeriodsReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsReference>(IDManager::instance().getID(calculationPeriodsReferenceIDRef_));
        }else{
             return this->calculationPeriodsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsReference>();
   }
}
boost::shared_ptr<CalculationPeriodsScheduleReference> AveragePriceLeg::getCalculationPeriodsScheduleReference()
{
   if(!this->calculationPeriodsScheduleReferenceIsNull_){
        if(calculationPeriodsScheduleReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsScheduleReference>(IDManager::instance().getID(calculationPeriodsScheduleReferenceIDRef_));
        }else{
             return this->calculationPeriodsScheduleReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsScheduleReference>();
   }
}
boost::shared_ptr<CalculationPeriodsDatesReference> AveragePriceLeg::getCalculationPeriodsDatesReference()
{
   if(!this->calculationPeriodsDatesReferenceIsNull_){
        if(calculationPeriodsDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsDatesReference>(IDManager::instance().getID(calculationPeriodsDatesReferenceIDRef_));
        }else{
             return this->calculationPeriodsDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsDatesReference>();
   }
}
boost::shared_ptr<Commodity> AveragePriceLeg::getCommodity()
{
   if(!this->commodityIsNull_){
        if(commodityIDRef_ != ""){
             return boost::shared_static_cast<Commodity>(IDManager::instance().getID(commodityIDRef_));
        }else{
             return this->commodity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Commodity>();
   }
}
boost::shared_ptr<QuantityReference> AveragePriceLeg::getQuantityReference()
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
boost::shared_ptr<AdjustableDate> AveragePriceLeg::getPricingStartDate()
{
   if(!this->pricingStartDateIsNull_){
        if(pricingStartDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(pricingStartDateIDRef_));
        }else{
             return this->pricingStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<FloatingLegCalculation> AveragePriceLeg::getCalculation()
{
   if(!this->calculationIsNull_){
        if(calculationIDRef_ != ""){
             return boost::shared_static_cast<FloatingLegCalculation>(IDManager::instance().getID(calculationIDRef_));
        }else{
             return this->calculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingLegCalculation>();
   }
}
boost::shared_ptr<CommodityRelativePaymentDates> AveragePriceLeg::getRelativePaymentDates()
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
boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> AveragePriceLeg::getPaymentDates()
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
boost::shared_ptr<XsdTypeBoolean> AveragePriceLeg::getMasterAgreementPaymentDates()
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

