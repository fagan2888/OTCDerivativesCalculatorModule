// FloatingPriceLeg.cpp 
#include "FloatingPriceLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FloatingPriceLeg::FloatingPriceLeg(TiXmlNode* xmlNode)
: FinancialSwapLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //notionalQuantityScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalQuantityScheduleNode = xmlNode->FirstChildElement("notionalQuantitySchedule");

   if(notionalQuantityScheduleNode){notionalQuantityScheduleIsNull_ = false;}
   else{notionalQuantityScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalQuantityScheduleNode , address : " << notionalQuantityScheduleNode << std::endl;
   #endif
   if(notionalQuantityScheduleNode)
   {
      if(notionalQuantityScheduleNode->Attribute("href") || notionalQuantityScheduleNode->Attribute("id"))
      {
          if(notionalQuantityScheduleNode->Attribute("id"))
          {
             notionalQuantityScheduleIDRef_ = notionalQuantityScheduleNode->Attribute("id");
             notionalQuantitySchedule_ = boost::shared_ptr<CommodityNotionalQuantitySchedule>(new CommodityNotionalQuantitySchedule(notionalQuantityScheduleNode));
             notionalQuantitySchedule_->setID(notionalQuantityScheduleIDRef_);
             IDManager::instance().setID(notionalQuantityScheduleIDRef_,notionalQuantitySchedule_);
          }
          else if(notionalQuantityScheduleNode->Attribute("href")) { notionalQuantityScheduleIDRef_ = notionalQuantityScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalQuantitySchedule_ = boost::shared_ptr<CommodityNotionalQuantitySchedule>(new CommodityNotionalQuantitySchedule(notionalQuantityScheduleNode));}
   }

   //notionalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalQuantityNode = xmlNode->FirstChildElement("notionalQuantity");

   if(notionalQuantityNode){notionalQuantityIsNull_ = false;}
   else{notionalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalQuantityNode , address : " << notionalQuantityNode << std::endl;
   #endif
   if(notionalQuantityNode)
   {
      if(notionalQuantityNode->Attribute("href") || notionalQuantityNode->Attribute("id"))
      {
          if(notionalQuantityNode->Attribute("id"))
          {
             notionalQuantityIDRef_ = notionalQuantityNode->Attribute("id");
             notionalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(notionalQuantityNode));
             notionalQuantity_->setID(notionalQuantityIDRef_);
             IDManager::instance().setID(notionalQuantityIDRef_,notionalQuantity_);
          }
          else if(notionalQuantityNode->Attribute("href")) { notionalQuantityIDRef_ = notionalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(notionalQuantityNode));}
   }

   //settlementPeriodsNotionalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsNotionalQuantityNode = xmlNode->FirstChildElement("settlementPeriodsNotionalQuantity");

   if(settlementPeriodsNotionalQuantityNode){settlementPeriodsNotionalQuantityIsNull_ = false;}
   else{settlementPeriodsNotionalQuantityIsNull_ = true;}

   if(settlementPeriodsNotionalQuantityNode)
   {
      for(settlementPeriodsNotionalQuantityNode; settlementPeriodsNotionalQuantityNode; settlementPeriodsNotionalQuantityNode = settlementPeriodsNotionalQuantityNode->NextSiblingElement("settlementPeriodsNotionalQuantity")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNotionalQuantityNode , address : " << settlementPeriodsNotionalQuantityNode << std::endl;
          #endif
          if(settlementPeriodsNotionalQuantityNode->Attribute("href") || settlementPeriodsNotionalQuantityNode->Attribute("id"))
          {
              if(settlementPeriodsNotionalQuantityNode->Attribute("id"))
              {
                  settlementPeriodsNotionalQuantityIDRef_ = settlementPeriodsNotionalQuantityNode->Attribute("id");
                  settlementPeriodsNotionalQuantity_.push_back(boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>(new CommoditySettlementPeriodsNotionalQuantity(settlementPeriodsNotionalQuantityNode)));
                  settlementPeriodsNotionalQuantity_.back()->setID(settlementPeriodsNotionalQuantityIDRef_);
                  IDManager::instance().setID(settlementPeriodsNotionalQuantityIDRef_, settlementPeriodsNotionalQuantity_.back());
              }
              else if(settlementPeriodsNotionalQuantityNode->Attribute("href")) { settlementPeriodsNotionalQuantityIDRef_ = settlementPeriodsNotionalQuantityNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsNotionalQuantity_.push_back(boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>(new CommoditySettlementPeriodsNotionalQuantity(settlementPeriodsNotionalQuantityNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNotionalQuantityNode , address : " << settlementPeriodsNotionalQuantityNode << std::endl;
       #endif
   }

   //totalNotionalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* totalNotionalQuantityNode = xmlNode->FirstChildElement("totalNotionalQuantity");

   if(totalNotionalQuantityNode){totalNotionalQuantityIsNull_ = false;}
   else{totalNotionalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- totalNotionalQuantityNode , address : " << totalNotionalQuantityNode << std::endl;
   #endif
   if(totalNotionalQuantityNode)
   {
      if(totalNotionalQuantityNode->Attribute("href") || totalNotionalQuantityNode->Attribute("id"))
      {
          if(totalNotionalQuantityNode->Attribute("id"))
          {
             totalNotionalQuantityIDRef_ = totalNotionalQuantityNode->Attribute("id");
             totalNotionalQuantity_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(totalNotionalQuantityNode));
             totalNotionalQuantity_->setID(totalNotionalQuantityIDRef_);
             IDManager::instance().setID(totalNotionalQuantityIDRef_,totalNotionalQuantity_);
          }
          else if(totalNotionalQuantityNode->Attribute("href")) { totalNotionalQuantityIDRef_ = totalNotionalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { totalNotionalQuantity_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(totalNotionalQuantityNode));}
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

   //flatRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* flatRateNode = xmlNode->FirstChildElement("flatRate");

   if(flatRateNode){flatRateIsNull_ = false;}
   else{flatRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- flatRateNode , address : " << flatRateNode << std::endl;
   #endif
   if(flatRateNode)
   {
      if(flatRateNode->Attribute("href") || flatRateNode->Attribute("id"))
      {
          if(flatRateNode->Attribute("id"))
          {
             flatRateIDRef_ = flatRateNode->Attribute("id");
             flatRate_ = boost::shared_ptr<FlatRateEnum>(new FlatRateEnum(flatRateNode));
             flatRate_->setID(flatRateIDRef_);
             IDManager::instance().setID(flatRateIDRef_,flatRate_);
          }
          else if(flatRateNode->Attribute("href")) { flatRateIDRef_ = flatRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { flatRate_ = boost::shared_ptr<FlatRateEnum>(new FlatRateEnum(flatRateNode));}
   }

   //flatRateAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* flatRateAmountNode = xmlNode->FirstChildElement("flatRateAmount");

   if(flatRateAmountNode){flatRateAmountIsNull_ = false;}
   else{flatRateAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- flatRateAmountNode , address : " << flatRateAmountNode << std::endl;
   #endif
   if(flatRateAmountNode)
   {
      if(flatRateAmountNode->Attribute("href") || flatRateAmountNode->Attribute("id"))
      {
          if(flatRateAmountNode->Attribute("id"))
          {
             flatRateAmountIDRef_ = flatRateAmountNode->Attribute("id");
             flatRateAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(flatRateAmountNode));
             flatRateAmount_->setID(flatRateAmountIDRef_);
             IDManager::instance().setID(flatRateAmountIDRef_,flatRateAmount_);
          }
          else if(flatRateAmountNode->Attribute("href")) { flatRateAmountIDRef_ = flatRateAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { flatRateAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(flatRateAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDates> FloatingPriceLeg::getCalculationDates()
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
boost::shared_ptr<AdjustableDates> FloatingPriceLeg::getCalculationPeriods()
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
boost::shared_ptr<CommodityCalculationPeriodsSchedule> FloatingPriceLeg::getCalculationPeriodsSchedule()
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
boost::shared_ptr<CalculationPeriodsReference> FloatingPriceLeg::getCalculationPeriodsReference()
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
boost::shared_ptr<CalculationPeriodsScheduleReference> FloatingPriceLeg::getCalculationPeriodsScheduleReference()
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
boost::shared_ptr<CalculationPeriodsDatesReference> FloatingPriceLeg::getCalculationPeriodsDatesReference()
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
boost::shared_ptr<Commodity> FloatingPriceLeg::getCommodity()
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
boost::shared_ptr<CommodityNotionalQuantitySchedule> FloatingPriceLeg::getNotionalQuantitySchedule()
{
   if(!this->notionalQuantityScheduleIsNull_){
        if(notionalQuantityScheduleIDRef_ != ""){
             return boost::shared_static_cast<CommodityNotionalQuantitySchedule>(IDManager::instance().getID(notionalQuantityScheduleIDRef_));
        }else{
             return this->notionalQuantitySchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityNotionalQuantitySchedule>();
   }
}
boost::shared_ptr<CommodityNotionalQuantity> FloatingPriceLeg::getNotionalQuantity()
{
   if(!this->notionalQuantityIsNull_){
        if(notionalQuantityIDRef_ != ""){
             return boost::shared_static_cast<CommodityNotionalQuantity>(IDManager::instance().getID(notionalQuantityIDRef_));
        }else{
             return this->notionalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityNotionalQuantity>();
   }
}
std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>> FloatingPriceLeg::getSettlementPeriodsNotionalQuantity()
{
   if(!this->settlementPeriodsNotionalQuantityIsNull_){
        if(settlementPeriodsNotionalQuantityIDRef_ != ""){
             return this->settlementPeriodsNotionalQuantity_;
        }else{
             return this->settlementPeriodsNotionalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FloatingPriceLeg::getTotalNotionalQuantity()
{
   if(!this->totalNotionalQuantityIsNull_){
        if(totalNotionalQuantityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(totalNotionalQuantityIDRef_));
        }else{
             return this->totalNotionalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<QuantityReference> FloatingPriceLeg::getQuantityReference()
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
boost::shared_ptr<FloatingLegCalculation> FloatingPriceLeg::getCalculation()
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
boost::shared_ptr<CommodityRelativePaymentDates> FloatingPriceLeg::getRelativePaymentDates()
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
boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> FloatingPriceLeg::getPaymentDates()
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
boost::shared_ptr<XsdTypeBoolean> FloatingPriceLeg::getMasterAgreementPaymentDates()
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
boost::shared_ptr<FlatRateEnum> FloatingPriceLeg::getFlatRate()
{
   if(!this->flatRateIsNull_){
        if(flatRateIDRef_ != ""){
             return boost::shared_static_cast<FlatRateEnum>(IDManager::instance().getID(flatRateIDRef_));
        }else{
             return this->flatRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FlatRateEnum>();
   }
}
boost::shared_ptr<NonNegativeMoney> FloatingPriceLeg::getFlatRateAmount()
{
   if(!this->flatRateAmountIsNull_){
        if(flatRateAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(flatRateAmountIDRef_));
        }else{
             return this->flatRateAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
}

