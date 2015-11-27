// FixedPriceLeg.cpp 
#include "FixedPriceLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixedPriceLeg::FixedPriceLeg(TiXmlNode* xmlNode)
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

   //fixedPriceScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedPriceScheduleNode = xmlNode->FirstChildElement("fixedPriceSchedule");

   if(fixedPriceScheduleNode){fixedPriceScheduleIsNull_ = false;}
   else{fixedPriceScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedPriceScheduleNode , address : " << fixedPriceScheduleNode << std::endl;
   #endif
   if(fixedPriceScheduleNode)
   {
      if(fixedPriceScheduleNode->Attribute("href") || fixedPriceScheduleNode->Attribute("id"))
      {
          if(fixedPriceScheduleNode->Attribute("id"))
          {
             fixedPriceScheduleIDRef_ = fixedPriceScheduleNode->Attribute("id");
             fixedPriceSchedule_ = boost::shared_ptr<CommodityFixedPriceSchedule>(new CommodityFixedPriceSchedule(fixedPriceScheduleNode));
             fixedPriceSchedule_->setID(fixedPriceScheduleIDRef_);
             IDManager::instance().setID(fixedPriceScheduleIDRef_,fixedPriceSchedule_);
          }
          else if(fixedPriceScheduleNode->Attribute("href")) { fixedPriceScheduleIDRef_ = fixedPriceScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedPriceSchedule_ = boost::shared_ptr<CommodityFixedPriceSchedule>(new CommodityFixedPriceSchedule(fixedPriceScheduleNode));}
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

   //worldscaleRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* worldscaleRateNode = xmlNode->FirstChildElement("worldscaleRate");

   if(worldscaleRateNode){worldscaleRateIsNull_ = false;}
   else{worldscaleRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- worldscaleRateNode , address : " << worldscaleRateNode << std::endl;
   #endif
   if(worldscaleRateNode)
   {
      if(worldscaleRateNode->Attribute("href") || worldscaleRateNode->Attribute("id"))
      {
          if(worldscaleRateNode->Attribute("id"))
          {
             worldscaleRateIDRef_ = worldscaleRateNode->Attribute("id");
             worldscaleRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(worldscaleRateNode));
             worldscaleRate_->setID(worldscaleRateIDRef_);
             IDManager::instance().setID(worldscaleRateIDRef_,worldscaleRate_);
          }
          else if(worldscaleRateNode->Attribute("href")) { worldscaleRateIDRef_ = worldscaleRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { worldscaleRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(worldscaleRateNode));}
   }

   //contractRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractRateNode = xmlNode->FirstChildElement("contractRate");

   if(contractRateNode){contractRateIsNull_ = false;}
   else{contractRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractRateNode , address : " << contractRateNode << std::endl;
   #endif
   if(contractRateNode)
   {
      if(contractRateNode->Attribute("href") || contractRateNode->Attribute("id"))
      {
          if(contractRateNode->Attribute("id"))
          {
             contractRateIDRef_ = contractRateNode->Attribute("id");
             contractRate_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(contractRateNode));
             contractRate_->setID(contractRateIDRef_);
             IDManager::instance().setID(contractRateIDRef_,contractRate_);
          }
          else if(contractRateNode->Attribute("href")) { contractRateIDRef_ = contractRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { contractRate_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(contractRateNode));}
   }

   //settlementPeriodsPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsPriceNode = xmlNode->FirstChildElement("settlementPeriodsPrice");

   if(settlementPeriodsPriceNode){settlementPeriodsPriceIsNull_ = false;}
   else{settlementPeriodsPriceIsNull_ = true;}

   if(settlementPeriodsPriceNode)
   {
      for(settlementPeriodsPriceNode; settlementPeriodsPriceNode; settlementPeriodsPriceNode = settlementPeriodsPriceNode->NextSiblingElement("settlementPeriodsPrice")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsPriceNode , address : " << settlementPeriodsPriceNode << std::endl;
          #endif
          if(settlementPeriodsPriceNode->Attribute("href") || settlementPeriodsPriceNode->Attribute("id"))
          {
              if(settlementPeriodsPriceNode->Attribute("id"))
              {
                  settlementPeriodsPriceIDRef_ = settlementPeriodsPriceNode->Attribute("id");
                  settlementPeriodsPrice_.push_back(boost::shared_ptr<SettlementPeriodsFixedPrice>(new SettlementPeriodsFixedPrice(settlementPeriodsPriceNode)));
                  settlementPeriodsPrice_.back()->setID(settlementPeriodsPriceIDRef_);
                  IDManager::instance().setID(settlementPeriodsPriceIDRef_, settlementPeriodsPrice_.back());
              }
              else if(settlementPeriodsPriceNode->Attribute("href")) { settlementPeriodsPriceIDRef_ = settlementPeriodsPriceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsPrice_.push_back(boost::shared_ptr<SettlementPeriodsFixedPrice>(new SettlementPeriodsFixedPrice(settlementPeriodsPriceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsPriceNode , address : " << settlementPeriodsPriceNode << std::endl;
       #endif
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
boost::shared_ptr<AdjustableDates> FixedPriceLeg::getCalculationDates()
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
boost::shared_ptr<AdjustableDates> FixedPriceLeg::getCalculationPeriods()
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
boost::shared_ptr<CommodityCalculationPeriodsSchedule> FixedPriceLeg::getCalculationPeriodsSchedule()
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
boost::shared_ptr<CalculationPeriodsReference> FixedPriceLeg::getCalculationPeriodsReference()
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
boost::shared_ptr<CalculationPeriodsScheduleReference> FixedPriceLeg::getCalculationPeriodsScheduleReference()
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
boost::shared_ptr<CalculationPeriodsDatesReference> FixedPriceLeg::getCalculationPeriodsDatesReference()
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
boost::shared_ptr<CommodityFixedPriceSchedule> FixedPriceLeg::getFixedPriceSchedule()
{
   if(!this->fixedPriceScheduleIsNull_){
        if(fixedPriceScheduleIDRef_ != ""){
             return boost::shared_static_cast<CommodityFixedPriceSchedule>(IDManager::instance().getID(fixedPriceScheduleIDRef_));
        }else{
             return this->fixedPriceSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityFixedPriceSchedule>();
   }
}
boost::shared_ptr<FixedPrice> FixedPriceLeg::getFixedPrice()
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
boost::shared_ptr<XsdTypeDecimal> FixedPriceLeg::getWorldscaleRate()
{
   if(!this->worldscaleRateIsNull_){
        if(worldscaleRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(worldscaleRateIDRef_));
        }else{
             return this->worldscaleRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<NonNegativeMoney> FixedPriceLeg::getContractRate()
{
   if(!this->contractRateIsNull_){
        if(contractRateIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(contractRateIDRef_));
        }else{
             return this->contractRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
std::vector<boost::shared_ptr<SettlementPeriodsFixedPrice>> FixedPriceLeg::getSettlementPeriodsPrice()
{
   if(!this->settlementPeriodsPriceIsNull_){
        if(settlementPeriodsPriceIDRef_ != ""){
             return this->settlementPeriodsPrice_;
        }else{
             return this->settlementPeriodsPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementPeriodsFixedPrice>>();
   }
}
boost::shared_ptr<NonNegativeMoney> FixedPriceLeg::getTotalPrice()
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
boost::shared_ptr<CommodityNotionalQuantitySchedule> FixedPriceLeg::getNotionalQuantitySchedule()
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
boost::shared_ptr<CommodityNotionalQuantity> FixedPriceLeg::getNotionalQuantity()
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
std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>> FixedPriceLeg::getSettlementPeriodsNotionalQuantity()
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
boost::shared_ptr<XsdTypeDecimal> FixedPriceLeg::getTotalNotionalQuantity()
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
boost::shared_ptr<QuantityReference> FixedPriceLeg::getQuantityReference()
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
boost::shared_ptr<CommodityRelativePaymentDates> FixedPriceLeg::getRelativePaymentDates()
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
boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> FixedPriceLeg::getPaymentDates()
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
boost::shared_ptr<XsdTypeBoolean> FixedPriceLeg::getMasterAgreementPaymentDates()
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
boost::shared_ptr<FlatRateEnum> FixedPriceLeg::getFlatRate()
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
boost::shared_ptr<NonNegativeMoney> FixedPriceLeg::getFlatRateAmount()
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

