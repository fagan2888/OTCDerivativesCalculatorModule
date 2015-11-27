// CommodityOption.cpp 
#include "CommodityOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityOption::CommodityOption(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //buyerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerPartyReferenceNode = xmlNode->FirstChildElement("buyerPartyReference");

   if(buyerPartyReferenceNode){buyerPartyReferenceIsNull_ = false;}
   else{buyerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerPartyReferenceNode , address : " << buyerPartyReferenceNode << std::endl;
   #endif
   if(buyerPartyReferenceNode)
   {
      if(buyerPartyReferenceNode->Attribute("href") || buyerPartyReferenceNode->Attribute("id"))
      {
          if(buyerPartyReferenceNode->Attribute("id"))
          {
             buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("id");
             buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));
             buyerPartyReference_->setID(buyerPartyReferenceIDRef_);
             IDManager::instance().setID(buyerPartyReferenceIDRef_,buyerPartyReference_);
          }
          else if(buyerPartyReferenceNode->Attribute("href")) { buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));}
   }

   //buyerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerAccountReferenceNode = xmlNode->FirstChildElement("buyerAccountReference");

   if(buyerAccountReferenceNode){buyerAccountReferenceIsNull_ = false;}
   else{buyerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerAccountReferenceNode , address : " << buyerAccountReferenceNode << std::endl;
   #endif
   if(buyerAccountReferenceNode)
   {
      if(buyerAccountReferenceNode->Attribute("href") || buyerAccountReferenceNode->Attribute("id"))
      {
          if(buyerAccountReferenceNode->Attribute("id"))
          {
             buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("id");
             buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));
             buyerAccountReference_->setID(buyerAccountReferenceIDRef_);
             IDManager::instance().setID(buyerAccountReferenceIDRef_,buyerAccountReference_);
          }
          else if(buyerAccountReferenceNode->Attribute("href")) { buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));}
   }

   //sellerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerPartyReferenceNode = xmlNode->FirstChildElement("sellerPartyReference");

   if(sellerPartyReferenceNode){sellerPartyReferenceIsNull_ = false;}
   else{sellerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerPartyReferenceNode , address : " << sellerPartyReferenceNode << std::endl;
   #endif
   if(sellerPartyReferenceNode)
   {
      if(sellerPartyReferenceNode->Attribute("href") || sellerPartyReferenceNode->Attribute("id"))
      {
          if(sellerPartyReferenceNode->Attribute("id"))
          {
             sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("id");
             sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));
             sellerPartyReference_->setID(sellerPartyReferenceIDRef_);
             IDManager::instance().setID(sellerPartyReferenceIDRef_,sellerPartyReference_);
          }
          else if(sellerPartyReferenceNode->Attribute("href")) { sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));}
   }

   //sellerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerAccountReferenceNode = xmlNode->FirstChildElement("sellerAccountReference");

   if(sellerAccountReferenceNode){sellerAccountReferenceIsNull_ = false;}
   else{sellerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerAccountReferenceNode , address : " << sellerAccountReferenceNode << std::endl;
   #endif
   if(sellerAccountReferenceNode)
   {
      if(sellerAccountReferenceNode->Attribute("href") || sellerAccountReferenceNode->Attribute("id"))
      {
          if(sellerAccountReferenceNode->Attribute("id"))
          {
             sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("id");
             sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));
             sellerAccountReference_->setID(sellerAccountReferenceIDRef_);
             IDManager::instance().setID(sellerAccountReferenceIDRef_,sellerAccountReference_);
          }
          else if(sellerAccountReferenceNode->Attribute("href")) { sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));}
   }

   //optionTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionTypeNode = xmlNode->FirstChildElement("optionType");

   if(optionTypeNode){optionTypeIsNull_ = false;}
   else{optionTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionTypeNode , address : " << optionTypeNode << std::endl;
   #endif
   if(optionTypeNode)
   {
      if(optionTypeNode->Attribute("href") || optionTypeNode->Attribute("id"))
      {
          if(optionTypeNode->Attribute("id"))
          {
             optionTypeIDRef_ = optionTypeNode->Attribute("id");
             optionType_ = boost::shared_ptr<PutCallEnum>(new PutCallEnum(optionTypeNode));
             optionType_->setID(optionTypeIDRef_);
             IDManager::instance().setID(optionTypeIDRef_,optionType_);
          }
          else if(optionTypeNode->Attribute("href")) { optionTypeIDRef_ = optionTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionType_ = boost::shared_ptr<PutCallEnum>(new PutCallEnum(optionTypeNode));}
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

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(effectiveDateNode));}
   }

   //terminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* terminationDateNode = xmlNode->FirstChildElement("terminationDate");

   if(terminationDateNode){terminationDateIsNull_ = false;}
   else{terminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- terminationDateNode , address : " << terminationDateNode << std::endl;
   #endif
   if(terminationDateNode)
   {
      if(terminationDateNode->Attribute("href") || terminationDateNode->Attribute("id"))
      {
          if(terminationDateNode->Attribute("id"))
          {
             terminationDateIDRef_ = terminationDateNode->Attribute("id");
             terminationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(terminationDateNode));
             terminationDate_->setID(terminationDateIDRef_);
             IDManager::instance().setID(terminationDateIDRef_,terminationDate_);
          }
          else if(terminationDateNode->Attribute("href")) { terminationDateIDRef_ = terminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { terminationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(terminationDateNode));}
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

   //pricingDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingDatesNode = xmlNode->FirstChildElement("pricingDates");

   if(pricingDatesNode){pricingDatesIsNull_ = false;}
   else{pricingDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingDatesNode , address : " << pricingDatesNode << std::endl;
   #endif
   if(pricingDatesNode)
   {
      if(pricingDatesNode->Attribute("href") || pricingDatesNode->Attribute("id"))
      {
          if(pricingDatesNode->Attribute("id"))
          {
             pricingDatesIDRef_ = pricingDatesNode->Attribute("id");
             pricingDates_ = boost::shared_ptr<CommodityPricingDates>(new CommodityPricingDates(pricingDatesNode));
             pricingDates_->setID(pricingDatesIDRef_);
             IDManager::instance().setID(pricingDatesIDRef_,pricingDates_);
          }
          else if(pricingDatesNode->Attribute("href")) { pricingDatesIDRef_ = pricingDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingDates_ = boost::shared_ptr<CommodityPricingDates>(new CommodityPricingDates(pricingDatesNode));}
   }

   //averagingMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingMethodNode = xmlNode->FirstChildElement("averagingMethod");

   if(averagingMethodNode){averagingMethodIsNull_ = false;}
   else{averagingMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingMethodNode , address : " << averagingMethodNode << std::endl;
   #endif
   if(averagingMethodNode)
   {
      if(averagingMethodNode->Attribute("href") || averagingMethodNode->Attribute("id"))
      {
          if(averagingMethodNode->Attribute("id"))
          {
             averagingMethodIDRef_ = averagingMethodNode->Attribute("id");
             averagingMethod_ = boost::shared_ptr<AveragingMethodEnum>(new AveragingMethodEnum(averagingMethodNode));
             averagingMethod_->setID(averagingMethodIDRef_);
             IDManager::instance().setID(averagingMethodIDRef_,averagingMethod_);
          }
          else if(averagingMethodNode->Attribute("href")) { averagingMethodIDRef_ = averagingMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingMethod_ = boost::shared_ptr<AveragingMethodEnum>(new AveragingMethodEnum(averagingMethodNode));}
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

   //exerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseNode = xmlNode->FirstChildElement("exercise");

   if(exerciseNode){exerciseIsNull_ = false;}
   else{exerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseNode , address : " << exerciseNode << std::endl;
   #endif
   if(exerciseNode)
   {
      if(exerciseNode->Attribute("href") || exerciseNode->Attribute("id"))
      {
          if(exerciseNode->Attribute("id"))
          {
             exerciseIDRef_ = exerciseNode->Attribute("id");
             exercise_ = boost::shared_ptr<CommodityExercise>(new CommodityExercise(exerciseNode));
             exercise_->setID(exerciseIDRef_);
             IDManager::instance().setID(exerciseIDRef_,exercise_);
          }
          else if(exerciseNode->Attribute("href")) { exerciseIDRef_ = exerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exercise_ = boost::shared_ptr<CommodityExercise>(new CommodityExercise(exerciseNode));}
   }

   //strikePricePerUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikePricePerUnitNode = xmlNode->FirstChildElement("strikePricePerUnit");

   if(strikePricePerUnitNode){strikePricePerUnitIsNull_ = false;}
   else{strikePricePerUnitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikePricePerUnitNode , address : " << strikePricePerUnitNode << std::endl;
   #endif
   if(strikePricePerUnitNode)
   {
      if(strikePricePerUnitNode->Attribute("href") || strikePricePerUnitNode->Attribute("id"))
      {
          if(strikePricePerUnitNode->Attribute("id"))
          {
             strikePricePerUnitIDRef_ = strikePricePerUnitNode->Attribute("id");
             strikePricePerUnit_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(strikePricePerUnitNode));
             strikePricePerUnit_->setID(strikePricePerUnitIDRef_);
             IDManager::instance().setID(strikePricePerUnitIDRef_,strikePricePerUnit_);
          }
          else if(strikePricePerUnitNode->Attribute("href")) { strikePricePerUnitIDRef_ = strikePricePerUnitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikePricePerUnit_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(strikePricePerUnitNode));}
   }

   //strikePricePerUnitScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikePricePerUnitScheduleNode = xmlNode->FirstChildElement("strikePricePerUnitSchedule");

   if(strikePricePerUnitScheduleNode){strikePricePerUnitScheduleIsNull_ = false;}
   else{strikePricePerUnitScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikePricePerUnitScheduleNode , address : " << strikePricePerUnitScheduleNode << std::endl;
   #endif
   if(strikePricePerUnitScheduleNode)
   {
      if(strikePricePerUnitScheduleNode->Attribute("href") || strikePricePerUnitScheduleNode->Attribute("id"))
      {
          if(strikePricePerUnitScheduleNode->Attribute("id"))
          {
             strikePricePerUnitScheduleIDRef_ = strikePricePerUnitScheduleNode->Attribute("id");
             strikePricePerUnitSchedule_ = boost::shared_ptr<CommodityStrikeSchedule>(new CommodityStrikeSchedule(strikePricePerUnitScheduleNode));
             strikePricePerUnitSchedule_->setID(strikePricePerUnitScheduleIDRef_);
             IDManager::instance().setID(strikePricePerUnitScheduleIDRef_,strikePricePerUnitSchedule_);
          }
          else if(strikePricePerUnitScheduleNode->Attribute("href")) { strikePricePerUnitScheduleIDRef_ = strikePricePerUnitScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikePricePerUnitSchedule_ = boost::shared_ptr<CommodityStrikeSchedule>(new CommodityStrikeSchedule(strikePricePerUnitScheduleNode));}
   }

   //floatingStrikePricePerUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingStrikePricePerUnitNode = xmlNode->FirstChildElement("floatingStrikePricePerUnit");

   if(floatingStrikePricePerUnitNode){floatingStrikePricePerUnitIsNull_ = false;}
   else{floatingStrikePricePerUnitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingStrikePricePerUnitNode , address : " << floatingStrikePricePerUnitNode << std::endl;
   #endif
   if(floatingStrikePricePerUnitNode)
   {
      if(floatingStrikePricePerUnitNode->Attribute("href") || floatingStrikePricePerUnitNode->Attribute("id"))
      {
          if(floatingStrikePricePerUnitNode->Attribute("id"))
          {
             floatingStrikePricePerUnitIDRef_ = floatingStrikePricePerUnitNode->Attribute("id");
             floatingStrikePricePerUnit_ = boost::shared_ptr<FloatingStrikePrice>(new FloatingStrikePrice(floatingStrikePricePerUnitNode));
             floatingStrikePricePerUnit_->setID(floatingStrikePricePerUnitIDRef_);
             IDManager::instance().setID(floatingStrikePricePerUnitIDRef_,floatingStrikePricePerUnit_);
          }
          else if(floatingStrikePricePerUnitNode->Attribute("href")) { floatingStrikePricePerUnitIDRef_ = floatingStrikePricePerUnitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingStrikePricePerUnit_ = boost::shared_ptr<FloatingStrikePrice>(new FloatingStrikePrice(floatingStrikePricePerUnitNode));}
   }

   //floatingStrikePricePerUnitScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingStrikePricePerUnitScheduleNode = xmlNode->FirstChildElement("floatingStrikePricePerUnitSchedule");

   if(floatingStrikePricePerUnitScheduleNode){floatingStrikePricePerUnitScheduleIsNull_ = false;}
   else{floatingStrikePricePerUnitScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingStrikePricePerUnitScheduleNode , address : " << floatingStrikePricePerUnitScheduleNode << std::endl;
   #endif
   if(floatingStrikePricePerUnitScheduleNode)
   {
      if(floatingStrikePricePerUnitScheduleNode->Attribute("href") || floatingStrikePricePerUnitScheduleNode->Attribute("id"))
      {
          if(floatingStrikePricePerUnitScheduleNode->Attribute("id"))
          {
             floatingStrikePricePerUnitScheduleIDRef_ = floatingStrikePricePerUnitScheduleNode->Attribute("id");
             floatingStrikePricePerUnitSchedule_ = boost::shared_ptr<CommodityCalculationPeriodsSchedule>(new CommodityCalculationPeriodsSchedule(floatingStrikePricePerUnitScheduleNode));
             floatingStrikePricePerUnitSchedule_->setID(floatingStrikePricePerUnitScheduleIDRef_);
             IDManager::instance().setID(floatingStrikePricePerUnitScheduleIDRef_,floatingStrikePricePerUnitSchedule_);
          }
          else if(floatingStrikePricePerUnitScheduleNode->Attribute("href")) { floatingStrikePricePerUnitScheduleIDRef_ = floatingStrikePricePerUnitScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingStrikePricePerUnitSchedule_ = boost::shared_ptr<CommodityCalculationPeriodsSchedule>(new CommodityCalculationPeriodsSchedule(floatingStrikePricePerUnitScheduleNode));}
   }

   //commoditySwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commoditySwapNode = xmlNode->FirstChildElement("commoditySwap");

   if(commoditySwapNode){commoditySwapIsNull_ = false;}
   else{commoditySwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commoditySwapNode , address : " << commoditySwapNode << std::endl;
   #endif
   if(commoditySwapNode)
   {
      if(commoditySwapNode->Attribute("href") || commoditySwapNode->Attribute("id"))
      {
          if(commoditySwapNode->Attribute("id"))
          {
             commoditySwapIDRef_ = commoditySwapNode->Attribute("id");
             commoditySwap_ = boost::shared_ptr<CommoditySwap>(new CommoditySwap(commoditySwapNode));
             commoditySwap_->setID(commoditySwapIDRef_);
             IDManager::instance().setID(commoditySwapIDRef_,commoditySwap_);
          }
          else if(commoditySwapNode->Attribute("href")) { commoditySwapIDRef_ = commoditySwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commoditySwap_ = boost::shared_ptr<CommoditySwap>(new CommoditySwap(commoditySwapNode));}
   }

   //commodityForwardNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityForwardNode = xmlNode->FirstChildElement("commodityForward");

   if(commodityForwardNode){commodityForwardIsNull_ = false;}
   else{commodityForwardIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityForwardNode , address : " << commodityForwardNode << std::endl;
   #endif
   if(commodityForwardNode)
   {
      if(commodityForwardNode->Attribute("href") || commodityForwardNode->Attribute("id"))
      {
          if(commodityForwardNode->Attribute("id"))
          {
             commodityForwardIDRef_ = commodityForwardNode->Attribute("id");
             commodityForward_ = boost::shared_ptr<CommodityForward>(new CommodityForward(commodityForwardNode));
             commodityForward_->setID(commodityForwardIDRef_);
             IDManager::instance().setID(commodityForwardIDRef_,commodityForward_);
          }
          else if(commodityForwardNode->Attribute("href")) { commodityForwardIDRef_ = commodityForwardNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodityForward_ = boost::shared_ptr<CommodityForward>(new CommodityForward(commodityForwardNode));}
   }

   //physicalExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalExerciseNode = xmlNode->FirstChildElement("physicalExercise");

   if(physicalExerciseNode){physicalExerciseIsNull_ = false;}
   else{physicalExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalExerciseNode , address : " << physicalExerciseNode << std::endl;
   #endif
   if(physicalExerciseNode)
   {
      if(physicalExerciseNode->Attribute("href") || physicalExerciseNode->Attribute("id"))
      {
          if(physicalExerciseNode->Attribute("id"))
          {
             physicalExerciseIDRef_ = physicalExerciseNode->Attribute("id");
             physicalExercise_ = boost::shared_ptr<CommodityPhysicalExercise>(new CommodityPhysicalExercise(physicalExerciseNode));
             physicalExercise_->setID(physicalExerciseIDRef_);
             IDManager::instance().setID(physicalExerciseIDRef_,physicalExercise_);
          }
          else if(physicalExerciseNode->Attribute("href")) { physicalExerciseIDRef_ = physicalExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalExercise_ = boost::shared_ptr<CommodityPhysicalExercise>(new CommodityPhysicalExercise(physicalExerciseNode));}
   }

   //weatherCalculationPeriodsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherCalculationPeriodsNode = xmlNode->FirstChildElement("weatherCalculationPeriods");

   if(weatherCalculationPeriodsNode){weatherCalculationPeriodsIsNull_ = false;}
   else{weatherCalculationPeriodsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherCalculationPeriodsNode , address : " << weatherCalculationPeriodsNode << std::endl;
   #endif
   if(weatherCalculationPeriodsNode)
   {
      if(weatherCalculationPeriodsNode->Attribute("href") || weatherCalculationPeriodsNode->Attribute("id"))
      {
          if(weatherCalculationPeriodsNode->Attribute("id"))
          {
             weatherCalculationPeriodsIDRef_ = weatherCalculationPeriodsNode->Attribute("id");
             weatherCalculationPeriods_ = boost::shared_ptr<WeatherCalculationPeriods>(new WeatherCalculationPeriods(weatherCalculationPeriodsNode));
             weatherCalculationPeriods_->setID(weatherCalculationPeriodsIDRef_);
             IDManager::instance().setID(weatherCalculationPeriodsIDRef_,weatherCalculationPeriods_);
          }
          else if(weatherCalculationPeriodsNode->Attribute("href")) { weatherCalculationPeriodsIDRef_ = weatherCalculationPeriodsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherCalculationPeriods_ = boost::shared_ptr<WeatherCalculationPeriods>(new WeatherCalculationPeriods(weatherCalculationPeriodsNode));}
   }

   //weatherCalculationPeriodsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherCalculationPeriodsReferenceNode = xmlNode->FirstChildElement("weatherCalculationPeriodsReference");

   if(weatherCalculationPeriodsReferenceNode){weatherCalculationPeriodsReferenceIsNull_ = false;}
   else{weatherCalculationPeriodsReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherCalculationPeriodsReferenceNode , address : " << weatherCalculationPeriodsReferenceNode << std::endl;
   #endif
   if(weatherCalculationPeriodsReferenceNode)
   {
      if(weatherCalculationPeriodsReferenceNode->Attribute("href") || weatherCalculationPeriodsReferenceNode->Attribute("id"))
      {
          if(weatherCalculationPeriodsReferenceNode->Attribute("id"))
          {
             weatherCalculationPeriodsReferenceIDRef_ = weatherCalculationPeriodsReferenceNode->Attribute("id");
             weatherCalculationPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode));
             weatherCalculationPeriodsReference_->setID(weatherCalculationPeriodsReferenceIDRef_);
             IDManager::instance().setID(weatherCalculationPeriodsReferenceIDRef_,weatherCalculationPeriodsReference_);
          }
          else if(weatherCalculationPeriodsReferenceNode->Attribute("href")) { weatherCalculationPeriodsReferenceIDRef_ = weatherCalculationPeriodsReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherCalculationPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode));}
   }

   //weatherNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherNotionalAmountNode = xmlNode->FirstChildElement("weatherNotionalAmount");

   if(weatherNotionalAmountNode){weatherNotionalAmountIsNull_ = false;}
   else{weatherNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherNotionalAmountNode , address : " << weatherNotionalAmountNode << std::endl;
   #endif
   if(weatherNotionalAmountNode)
   {
      if(weatherNotionalAmountNode->Attribute("href") || weatherNotionalAmountNode->Attribute("id"))
      {
          if(weatherNotionalAmountNode->Attribute("id"))
          {
             weatherNotionalAmountIDRef_ = weatherNotionalAmountNode->Attribute("id");
             weatherNotionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(weatherNotionalAmountNode));
             weatherNotionalAmount_->setID(weatherNotionalAmountIDRef_);
             IDManager::instance().setID(weatherNotionalAmountIDRef_,weatherNotionalAmount_);
          }
          else if(weatherNotionalAmountNode->Attribute("href")) { weatherNotionalAmountIDRef_ = weatherNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherNotionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(weatherNotionalAmountNode));}
   }

   //weatherIndexStrikeLevelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherIndexStrikeLevelNode = xmlNode->FirstChildElement("weatherIndexStrikeLevel");

   if(weatherIndexStrikeLevelNode){weatherIndexStrikeLevelIsNull_ = false;}
   else{weatherIndexStrikeLevelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherIndexStrikeLevelNode , address : " << weatherIndexStrikeLevelNode << std::endl;
   #endif
   if(weatherIndexStrikeLevelNode)
   {
      if(weatherIndexStrikeLevelNode->Attribute("href") || weatherIndexStrikeLevelNode->Attribute("id"))
      {
          if(weatherIndexStrikeLevelNode->Attribute("id"))
          {
             weatherIndexStrikeLevelIDRef_ = weatherIndexStrikeLevelNode->Attribute("id");
             weatherIndexStrikeLevel_ = boost::shared_ptr<WeatherIndex>(new WeatherIndex(weatherIndexStrikeLevelNode));
             weatherIndexStrikeLevel_->setID(weatherIndexStrikeLevelIDRef_);
             IDManager::instance().setID(weatherIndexStrikeLevelIDRef_,weatherIndexStrikeLevel_);
          }
          else if(weatherIndexStrikeLevelNode->Attribute("href")) { weatherIndexStrikeLevelIDRef_ = weatherIndexStrikeLevelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherIndexStrikeLevel_ = boost::shared_ptr<WeatherIndex>(new WeatherIndex(weatherIndexStrikeLevelNode));}
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
             calculation_ = boost::shared_ptr<WeatherLegCalculation>(new WeatherLegCalculation(calculationNode));
             calculation_->setID(calculationIDRef_);
             IDManager::instance().setID(calculationIDRef_,calculation_);
          }
          else if(calculationNode->Attribute("href")) { calculationIDRef_ = calculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculation_ = boost::shared_ptr<WeatherLegCalculation>(new WeatherLegCalculation(calculationNode));}
   }

   //weatherIndexDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherIndexDataNode = xmlNode->FirstChildElement("weatherIndexData");

   if(weatherIndexDataNode){weatherIndexDataIsNull_ = false;}
   else{weatherIndexDataIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherIndexDataNode , address : " << weatherIndexDataNode << std::endl;
   #endif
   if(weatherIndexDataNode)
   {
      if(weatherIndexDataNode->Attribute("href") || weatherIndexDataNode->Attribute("id"))
      {
          if(weatherIndexDataNode->Attribute("id"))
          {
             weatherIndexDataIDRef_ = weatherIndexDataNode->Attribute("id");
             weatherIndexData_ = boost::shared_ptr<WeatherIndexData>(new WeatherIndexData(weatherIndexDataNode));
             weatherIndexData_->setID(weatherIndexDataIDRef_);
             IDManager::instance().setID(weatherIndexDataIDRef_,weatherIndexData_);
          }
          else if(weatherIndexDataNode->Attribute("href")) { weatherIndexDataIDRef_ = weatherIndexDataNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherIndexData_ = boost::shared_ptr<WeatherIndexData>(new WeatherIndexData(weatherIndexDataNode));}
   }

   //premiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumNode = xmlNode->FirstChildElement("premium");

   if(premiumNode){premiumIsNull_ = false;}
   else{premiumIsNull_ = true;}

   if(premiumNode)
   {
      for(premiumNode; premiumNode; premiumNode = premiumNode->NextSiblingElement("premium")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
          #endif
          if(premiumNode->Attribute("href") || premiumNode->Attribute("id"))
          {
              if(premiumNode->Attribute("id"))
              {
                  premiumIDRef_ = premiumNode->Attribute("id");
                  premium_.push_back(boost::shared_ptr<CommodityPremium>(new CommodityPremium(premiumNode)));
                  premium_.back()->setID(premiumIDRef_);
                  IDManager::instance().setID(premiumIDRef_, premium_.back());
              }
              else if(premiumNode->Attribute("href")) { premiumIDRef_ = premiumNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { premium_.push_back(boost::shared_ptr<CommodityPremium>(new CommodityPremium(premiumNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
       #endif
   }

   //commonPricingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commonPricingNode = xmlNode->FirstChildElement("commonPricing");

   if(commonPricingNode){commonPricingIsNull_ = false;}
   else{commonPricingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commonPricingNode , address : " << commonPricingNode << std::endl;
   #endif
   if(commonPricingNode)
   {
      if(commonPricingNode->Attribute("href") || commonPricingNode->Attribute("id"))
      {
          if(commonPricingNode->Attribute("id"))
          {
             commonPricingIDRef_ = commonPricingNode->Attribute("id");
             commonPricing_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(commonPricingNode));
             commonPricing_->setID(commonPricingIDRef_);
             IDManager::instance().setID(commonPricingIDRef_,commonPricing_);
          }
          else if(commonPricingNode->Attribute("href")) { commonPricingIDRef_ = commonPricingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commonPricing_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(commonPricingNode));}
   }

   //marketDisruptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* marketDisruptionNode = xmlNode->FirstChildElement("marketDisruption");

   if(marketDisruptionNode){marketDisruptionIsNull_ = false;}
   else{marketDisruptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketDisruptionNode , address : " << marketDisruptionNode << std::endl;
   #endif
   if(marketDisruptionNode)
   {
      if(marketDisruptionNode->Attribute("href") || marketDisruptionNode->Attribute("id"))
      {
          if(marketDisruptionNode->Attribute("id"))
          {
             marketDisruptionIDRef_ = marketDisruptionNode->Attribute("id");
             marketDisruption_ = boost::shared_ptr<CommodityMarketDisruption>(new CommodityMarketDisruption(marketDisruptionNode));
             marketDisruption_->setID(marketDisruptionIDRef_);
             IDManager::instance().setID(marketDisruptionIDRef_,marketDisruption_);
          }
          else if(marketDisruptionNode->Attribute("href")) { marketDisruptionIDRef_ = marketDisruptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { marketDisruption_ = boost::shared_ptr<CommodityMarketDisruption>(new CommodityMarketDisruption(marketDisruptionNode));}
   }

   //settlementDisruptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementDisruptionNode = xmlNode->FirstChildElement("settlementDisruption");

   if(settlementDisruptionNode){settlementDisruptionIsNull_ = false;}
   else{settlementDisruptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementDisruptionNode , address : " << settlementDisruptionNode << std::endl;
   #endif
   if(settlementDisruptionNode)
   {
      if(settlementDisruptionNode->Attribute("href") || settlementDisruptionNode->Attribute("id"))
      {
          if(settlementDisruptionNode->Attribute("id"))
          {
             settlementDisruptionIDRef_ = settlementDisruptionNode->Attribute("id");
             settlementDisruption_ = boost::shared_ptr<CommodityBullionSettlementDisruptionEnum>(new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode));
             settlementDisruption_->setID(settlementDisruptionIDRef_);
             IDManager::instance().setID(settlementDisruptionIDRef_,settlementDisruption_);
          }
          else if(settlementDisruptionNode->Attribute("href")) { settlementDisruptionIDRef_ = settlementDisruptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementDisruption_ = boost::shared_ptr<CommodityBullionSettlementDisruptionEnum>(new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode));}
   }

   //roundingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* roundingNode = xmlNode->FirstChildElement("rounding");

   if(roundingNode){roundingIsNull_ = false;}
   else{roundingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- roundingNode , address : " << roundingNode << std::endl;
   #endif
   if(roundingNode)
   {
      if(roundingNode->Attribute("href") || roundingNode->Attribute("id"))
      {
          if(roundingNode->Attribute("id"))
          {
             roundingIDRef_ = roundingNode->Attribute("id");
             rounding_ = boost::shared_ptr<Rounding>(new Rounding(roundingNode));
             rounding_->setID(roundingIDRef_);
             IDManager::instance().setID(roundingIDRef_,rounding_);
          }
          else if(roundingNode->Attribute("href")) { roundingIDRef_ = roundingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rounding_ = boost::shared_ptr<Rounding>(new Rounding(roundingNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> CommodityOption::getBuyerPartyReference()
{
   if(!this->buyerPartyReferenceIsNull_){
        if(buyerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(buyerPartyReferenceIDRef_));
        }else{
             return this->buyerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> CommodityOption::getBuyerAccountReference()
{
   if(!this->buyerAccountReferenceIsNull_){
        if(buyerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(buyerAccountReferenceIDRef_));
        }else{
             return this->buyerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> CommodityOption::getSellerPartyReference()
{
   if(!this->sellerPartyReferenceIsNull_){
        if(sellerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(sellerPartyReferenceIDRef_));
        }else{
             return this->sellerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> CommodityOption::getSellerAccountReference()
{
   if(!this->sellerAccountReferenceIsNull_){
        if(sellerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(sellerAccountReferenceIDRef_));
        }else{
             return this->sellerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PutCallEnum> CommodityOption::getOptionType()
{
   if(!this->optionTypeIsNull_){
        if(optionTypeIDRef_ != ""){
             return boost::shared_static_cast<PutCallEnum>(IDManager::instance().getID(optionTypeIDRef_));
        }else{
             return this->optionType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PutCallEnum>();
   }
}
boost::shared_ptr<Commodity> CommodityOption::getCommodity()
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
boost::shared_ptr<AdjustableOrRelativeDate> CommodityOption::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> CommodityOption::getTerminationDate()
{
   if(!this->terminationDateIsNull_){
        if(terminationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(terminationDateIDRef_));
        }else{
             return this->terminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<CommodityCalculationPeriodsSchedule> CommodityOption::getCalculationPeriodsSchedule()
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
boost::shared_ptr<AdjustableDates> CommodityOption::getCalculationPeriods()
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
boost::shared_ptr<CommodityPricingDates> CommodityOption::getPricingDates()
{
   if(!this->pricingDatesIsNull_){
        if(pricingDatesIDRef_ != ""){
             return boost::shared_static_cast<CommodityPricingDates>(IDManager::instance().getID(pricingDatesIDRef_));
        }else{
             return this->pricingDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPricingDates>();
   }
}
boost::shared_ptr<AveragingMethodEnum> CommodityOption::getAveragingMethod()
{
   if(!this->averagingMethodIsNull_){
        if(averagingMethodIDRef_ != ""){
             return boost::shared_static_cast<AveragingMethodEnum>(IDManager::instance().getID(averagingMethodIDRef_));
        }else{
             return this->averagingMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AveragingMethodEnum>();
   }
}
boost::shared_ptr<CommodityNotionalQuantitySchedule> CommodityOption::getNotionalQuantitySchedule()
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
boost::shared_ptr<CommodityNotionalQuantity> CommodityOption::getNotionalQuantity()
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
std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>> CommodityOption::getSettlementPeriodsNotionalQuantity()
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
boost::shared_ptr<XsdTypeDecimal> CommodityOption::getTotalNotionalQuantity()
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
boost::shared_ptr<QuantityReference> CommodityOption::getQuantityReference()
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
boost::shared_ptr<CommodityExercise> CommodityOption::getExercise()
{
   if(!this->exerciseIsNull_){
        if(exerciseIDRef_ != ""){
             return boost::shared_static_cast<CommodityExercise>(IDManager::instance().getID(exerciseIDRef_));
        }else{
             return this->exercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityExercise>();
   }
}
boost::shared_ptr<NonNegativeMoney> CommodityOption::getStrikePricePerUnit()
{
   if(!this->strikePricePerUnitIsNull_){
        if(strikePricePerUnitIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(strikePricePerUnitIDRef_));
        }else{
             return this->strikePricePerUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<CommodityStrikeSchedule> CommodityOption::getStrikePricePerUnitSchedule()
{
   if(!this->strikePricePerUnitScheduleIsNull_){
        if(strikePricePerUnitScheduleIDRef_ != ""){
             return boost::shared_static_cast<CommodityStrikeSchedule>(IDManager::instance().getID(strikePricePerUnitScheduleIDRef_));
        }else{
             return this->strikePricePerUnitSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityStrikeSchedule>();
   }
}
boost::shared_ptr<FloatingStrikePrice> CommodityOption::getFloatingStrikePricePerUnit()
{
   if(!this->floatingStrikePricePerUnitIsNull_){
        if(floatingStrikePricePerUnitIDRef_ != ""){
             return boost::shared_static_cast<FloatingStrikePrice>(IDManager::instance().getID(floatingStrikePricePerUnitIDRef_));
        }else{
             return this->floatingStrikePricePerUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingStrikePrice>();
   }
}
boost::shared_ptr<CommodityCalculationPeriodsSchedule> CommodityOption::getFloatingStrikePricePerUnitSchedule()
{
   if(!this->floatingStrikePricePerUnitScheduleIsNull_){
        if(floatingStrikePricePerUnitScheduleIDRef_ != ""){
             return boost::shared_static_cast<CommodityCalculationPeriodsSchedule>(IDManager::instance().getID(floatingStrikePricePerUnitScheduleIDRef_));
        }else{
             return this->floatingStrikePricePerUnitSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityCalculationPeriodsSchedule>();
   }
}
boost::shared_ptr<CommoditySwap> CommodityOption::getCommoditySwap()
{
   if(!this->commoditySwapIsNull_){
        if(commoditySwapIDRef_ != ""){
             return boost::shared_static_cast<CommoditySwap>(IDManager::instance().getID(commoditySwapIDRef_));
        }else{
             return this->commoditySwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommoditySwap>();
   }
}
boost::shared_ptr<CommodityForward> CommodityOption::getCommodityForward()
{
   if(!this->commodityForwardIsNull_){
        if(commodityForwardIDRef_ != ""){
             return boost::shared_static_cast<CommodityForward>(IDManager::instance().getID(commodityForwardIDRef_));
        }else{
             return this->commodityForward_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityForward>();
   }
}
boost::shared_ptr<CommodityPhysicalExercise> CommodityOption::getPhysicalExercise()
{
   if(!this->physicalExerciseIsNull_){
        if(physicalExerciseIDRef_ != ""){
             return boost::shared_static_cast<CommodityPhysicalExercise>(IDManager::instance().getID(physicalExerciseIDRef_));
        }else{
             return this->physicalExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPhysicalExercise>();
   }
}
boost::shared_ptr<WeatherCalculationPeriods> CommodityOption::getWeatherCalculationPeriods()
{
   if(!this->weatherCalculationPeriodsIsNull_){
        if(weatherCalculationPeriodsIDRef_ != ""){
             return boost::shared_static_cast<WeatherCalculationPeriods>(IDManager::instance().getID(weatherCalculationPeriodsIDRef_));
        }else{
             return this->weatherCalculationPeriods_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherCalculationPeriods>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> CommodityOption::getWeatherCalculationPeriodsReference()
{
   if(!this->weatherCalculationPeriodsReferenceIsNull_){
        if(weatherCalculationPeriodsReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsReference>(IDManager::instance().getID(weatherCalculationPeriodsReferenceIDRef_));
        }else{
             return this->weatherCalculationPeriodsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsReference>();
   }
}
boost::shared_ptr<NonNegativeMoney> CommodityOption::getWeatherNotionalAmount()
{
   if(!this->weatherNotionalAmountIsNull_){
        if(weatherNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(weatherNotionalAmountIDRef_));
        }else{
             return this->weatherNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<WeatherIndex> CommodityOption::getWeatherIndexStrikeLevel()
{
   if(!this->weatherIndexStrikeLevelIsNull_){
        if(weatherIndexStrikeLevelIDRef_ != ""){
             return boost::shared_static_cast<WeatherIndex>(IDManager::instance().getID(weatherIndexStrikeLevelIDRef_));
        }else{
             return this->weatherIndexStrikeLevel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherIndex>();
   }
}
boost::shared_ptr<WeatherLegCalculation> CommodityOption::getCalculation()
{
   if(!this->calculationIsNull_){
        if(calculationIDRef_ != ""){
             return boost::shared_static_cast<WeatherLegCalculation>(IDManager::instance().getID(calculationIDRef_));
        }else{
             return this->calculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherLegCalculation>();
   }
}
boost::shared_ptr<WeatherIndexData> CommodityOption::getWeatherIndexData()
{
   if(!this->weatherIndexDataIsNull_){
        if(weatherIndexDataIDRef_ != ""){
             return boost::shared_static_cast<WeatherIndexData>(IDManager::instance().getID(weatherIndexDataIDRef_));
        }else{
             return this->weatherIndexData_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherIndexData>();
   }
}
std::vector<boost::shared_ptr<CommodityPremium>> CommodityOption::getPremium()
{
   if(!this->premiumIsNull_){
        if(premiumIDRef_ != ""){
             return this->premium_;
        }else{
             return this->premium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityPremium>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CommodityOption::getCommonPricing()
{
   if(!this->commonPricingIsNull_){
        if(commonPricingIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(commonPricingIDRef_));
        }else{
             return this->commonPricing_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CommodityMarketDisruption> CommodityOption::getMarketDisruption()
{
   if(!this->marketDisruptionIsNull_){
        if(marketDisruptionIDRef_ != ""){
             return boost::shared_static_cast<CommodityMarketDisruption>(IDManager::instance().getID(marketDisruptionIDRef_));
        }else{
             return this->marketDisruption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityMarketDisruption>();
   }
}
boost::shared_ptr<CommodityBullionSettlementDisruptionEnum> CommodityOption::getSettlementDisruption()
{
   if(!this->settlementDisruptionIsNull_){
        if(settlementDisruptionIDRef_ != ""){
             return boost::shared_static_cast<CommodityBullionSettlementDisruptionEnum>(IDManager::instance().getID(settlementDisruptionIDRef_));
        }else{
             return this->settlementDisruption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityBullionSettlementDisruptionEnum>();
   }
}
boost::shared_ptr<Rounding> CommodityOption::getRounding()
{
   if(!this->roundingIsNull_){
        if(roundingIDRef_ != ""){
             return boost::shared_static_cast<Rounding>(IDManager::instance().getID(roundingIDRef_));
        }else{
             return this->rounding_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Rounding>();
   }
}
}

