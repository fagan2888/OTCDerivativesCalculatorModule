// Fra.cpp 
#include "Fra.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Fra::Fra(TiXmlNode* xmlNode)
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

   //adjustedEffectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedEffectiveDateNode = xmlNode->FirstChildElement("adjustedEffectiveDate");

   if(adjustedEffectiveDateNode){adjustedEffectiveDateIsNull_ = false;}
   else{adjustedEffectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedEffectiveDateNode , address : " << adjustedEffectiveDateNode << std::endl;
   #endif
   if(adjustedEffectiveDateNode)
   {
      if(adjustedEffectiveDateNode->Attribute("href") || adjustedEffectiveDateNode->Attribute("id"))
      {
          if(adjustedEffectiveDateNode->Attribute("id"))
          {
             adjustedEffectiveDateIDRef_ = adjustedEffectiveDateNode->Attribute("id");
             adjustedEffectiveDate_ = boost::shared_ptr<RequiredIdentifierDate>(new RequiredIdentifierDate(adjustedEffectiveDateNode));
             adjustedEffectiveDate_->setID(adjustedEffectiveDateIDRef_);
             IDManager::instance().setID(adjustedEffectiveDateIDRef_,adjustedEffectiveDate_);
          }
          else if(adjustedEffectiveDateNode->Attribute("href")) { adjustedEffectiveDateIDRef_ = adjustedEffectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedEffectiveDate_ = boost::shared_ptr<RequiredIdentifierDate>(new RequiredIdentifierDate(adjustedEffectiveDateNode));}
   }

   //adjustedTerminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedTerminationDateNode = xmlNode->FirstChildElement("adjustedTerminationDate");

   if(adjustedTerminationDateNode){adjustedTerminationDateIsNull_ = false;}
   else{adjustedTerminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedTerminationDateNode , address : " << adjustedTerminationDateNode << std::endl;
   #endif
   if(adjustedTerminationDateNode)
   {
      if(adjustedTerminationDateNode->Attribute("href") || adjustedTerminationDateNode->Attribute("id"))
      {
          if(adjustedTerminationDateNode->Attribute("id"))
          {
             adjustedTerminationDateIDRef_ = adjustedTerminationDateNode->Attribute("id");
             adjustedTerminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedTerminationDateNode));
             adjustedTerminationDate_->setID(adjustedTerminationDateIDRef_);
             IDManager::instance().setID(adjustedTerminationDateIDRef_,adjustedTerminationDate_);
          }
          else if(adjustedTerminationDateNode->Attribute("href")) { adjustedTerminationDateIDRef_ = adjustedTerminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedTerminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedTerminationDateNode));}
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

   //fixingDateOffsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDateOffsetNode = xmlNode->FirstChildElement("fixingDateOffset");

   if(fixingDateOffsetNode){fixingDateOffsetIsNull_ = false;}
   else{fixingDateOffsetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDateOffsetNode , address : " << fixingDateOffsetNode << std::endl;
   #endif
   if(fixingDateOffsetNode)
   {
      if(fixingDateOffsetNode->Attribute("href") || fixingDateOffsetNode->Attribute("id"))
      {
          if(fixingDateOffsetNode->Attribute("id"))
          {
             fixingDateOffsetIDRef_ = fixingDateOffsetNode->Attribute("id");
             fixingDateOffset_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(fixingDateOffsetNode));
             fixingDateOffset_->setID(fixingDateOffsetIDRef_);
             IDManager::instance().setID(fixingDateOffsetIDRef_,fixingDateOffset_);
          }
          else if(fixingDateOffsetNode->Attribute("href")) { fixingDateOffsetIDRef_ = fixingDateOffsetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingDateOffset_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(fixingDateOffsetNode));}
   }

   //dayCountFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountFractionNode = xmlNode->FirstChildElement("dayCountFraction");

   if(dayCountFractionNode){dayCountFractionIsNull_ = false;}
   else{dayCountFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountFractionNode , address : " << dayCountFractionNode << std::endl;
   #endif
   if(dayCountFractionNode)
   {
      if(dayCountFractionNode->Attribute("href") || dayCountFractionNode->Attribute("id"))
      {
          if(dayCountFractionNode->Attribute("id"))
          {
             dayCountFractionIDRef_ = dayCountFractionNode->Attribute("id");
             dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));
             dayCountFraction_->setID(dayCountFractionIDRef_);
             IDManager::instance().setID(dayCountFractionIDRef_,dayCountFraction_);
          }
          else if(dayCountFractionNode->Attribute("href")) { dayCountFractionIDRef_ = dayCountFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));}
   }

   //calculationPeriodNumberOfDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodNumberOfDaysNode = xmlNode->FirstChildElement("calculationPeriodNumberOfDays");

   if(calculationPeriodNumberOfDaysNode){calculationPeriodNumberOfDaysIsNull_ = false;}
   else{calculationPeriodNumberOfDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodNumberOfDaysNode , address : " << calculationPeriodNumberOfDaysNode << std::endl;
   #endif
   if(calculationPeriodNumberOfDaysNode)
   {
      if(calculationPeriodNumberOfDaysNode->Attribute("href") || calculationPeriodNumberOfDaysNode->Attribute("id"))
      {
          if(calculationPeriodNumberOfDaysNode->Attribute("id"))
          {
             calculationPeriodNumberOfDaysIDRef_ = calculationPeriodNumberOfDaysNode->Attribute("id");
             calculationPeriodNumberOfDays_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode));
             calculationPeriodNumberOfDays_->setID(calculationPeriodNumberOfDaysIDRef_);
             IDManager::instance().setID(calculationPeriodNumberOfDaysIDRef_,calculationPeriodNumberOfDays_);
          }
          else if(calculationPeriodNumberOfDaysNode->Attribute("href")) { calculationPeriodNumberOfDaysIDRef_ = calculationPeriodNumberOfDaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodNumberOfDays_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode));}
   }

   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
   #endif
   if(notionalNode)
   {
      if(notionalNode->Attribute("href") || notionalNode->Attribute("id"))
      {
          if(notionalNode->Attribute("id"))
          {
             notionalIDRef_ = notionalNode->Attribute("id");
             notional_ = boost::shared_ptr<Money>(new Money(notionalNode));
             notional_->setID(notionalIDRef_);
             IDManager::instance().setID(notionalIDRef_,notional_);
          }
          else if(notionalNode->Attribute("href")) { notionalIDRef_ = notionalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notional_ = boost::shared_ptr<Money>(new Money(notionalNode));}
   }

   //fixedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateNode = xmlNode->FirstChildElement("fixedRate");

   if(fixedRateNode){fixedRateIsNull_ = false;}
   else{fixedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateNode , address : " << fixedRateNode << std::endl;
   #endif
   if(fixedRateNode)
   {
      if(fixedRateNode->Attribute("href") || fixedRateNode->Attribute("id"))
      {
          if(fixedRateNode->Attribute("id"))
          {
             fixedRateIDRef_ = fixedRateNode->Attribute("id");
             fixedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(fixedRateNode));
             fixedRate_->setID(fixedRateIDRef_);
             IDManager::instance().setID(fixedRateIDRef_,fixedRate_);
          }
          else if(fixedRateNode->Attribute("href")) { fixedRateIDRef_ = fixedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(fixedRateNode));}
   }

   //floatingRateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateIndexNode = xmlNode->FirstChildElement("floatingRateIndex");

   if(floatingRateIndexNode){floatingRateIndexIsNull_ = false;}
   else{floatingRateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateIndexNode , address : " << floatingRateIndexNode << std::endl;
   #endif
   if(floatingRateIndexNode)
   {
      if(floatingRateIndexNode->Attribute("href") || floatingRateIndexNode->Attribute("id"))
      {
          if(floatingRateIndexNode->Attribute("id"))
          {
             floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("id");
             floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));
             floatingRateIndex_->setID(floatingRateIndexIDRef_);
             IDManager::instance().setID(floatingRateIndexIDRef_,floatingRateIndex_);
          }
          else if(floatingRateIndexNode->Attribute("href")) { floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));}
   }

   //indexTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexTenorNode = xmlNode->FirstChildElement("indexTenor");

   if(indexTenorNode){indexTenorIsNull_ = false;}
   else{indexTenorIsNull_ = true;}

   if(indexTenorNode)
   {
      for(indexTenorNode; indexTenorNode; indexTenorNode = indexTenorNode->NextSiblingElement("indexTenor")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTenorNode , address : " << indexTenorNode << std::endl;
          #endif
          if(indexTenorNode->Attribute("href") || indexTenorNode->Attribute("id"))
          {
              if(indexTenorNode->Attribute("id"))
              {
                  indexTenorIDRef_ = indexTenorNode->Attribute("id");
                  indexTenor_.push_back(boost::shared_ptr<Period>(new Period(indexTenorNode)));
                  indexTenor_.back()->setID(indexTenorIDRef_);
                  IDManager::instance().setID(indexTenorIDRef_, indexTenor_.back());
              }
              else if(indexTenorNode->Attribute("href")) { indexTenorIDRef_ = indexTenorNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { indexTenor_.push_back(boost::shared_ptr<Period>(new Period(indexTenorNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTenorNode , address : " << indexTenorNode << std::endl;
       #endif
   }

   //fraDiscountingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fraDiscountingNode = xmlNode->FirstChildElement("fraDiscounting");

   if(fraDiscountingNode){fraDiscountingIsNull_ = false;}
   else{fraDiscountingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fraDiscountingNode , address : " << fraDiscountingNode << std::endl;
   #endif
   if(fraDiscountingNode)
   {
      if(fraDiscountingNode->Attribute("href") || fraDiscountingNode->Attribute("id"))
      {
          if(fraDiscountingNode->Attribute("id"))
          {
             fraDiscountingIDRef_ = fraDiscountingNode->Attribute("id");
             fraDiscounting_ = boost::shared_ptr<FraDiscountingEnum>(new FraDiscountingEnum(fraDiscountingNode));
             fraDiscounting_->setID(fraDiscountingIDRef_);
             IDManager::instance().setID(fraDiscountingIDRef_,fraDiscounting_);
          }
          else if(fraDiscountingNode->Attribute("href")) { fraDiscountingIDRef_ = fraDiscountingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fraDiscounting_ = boost::shared_ptr<FraDiscountingEnum>(new FraDiscountingEnum(fraDiscountingNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> Fra::getBuyerPartyReference()
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
boost::shared_ptr<AccountReference> Fra::getBuyerAccountReference()
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
boost::shared_ptr<PartyReference> Fra::getSellerPartyReference()
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
boost::shared_ptr<AccountReference> Fra::getSellerAccountReference()
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
boost::shared_ptr<RequiredIdentifierDate> Fra::getAdjustedEffectiveDate()
{
   if(!this->adjustedEffectiveDateIsNull_){
        if(adjustedEffectiveDateIDRef_ != ""){
             return boost::shared_static_cast<RequiredIdentifierDate>(IDManager::instance().getID(adjustedEffectiveDateIDRef_));
        }else{
             return this->adjustedEffectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RequiredIdentifierDate>();
   }
}
boost::shared_ptr<XsdTypeDate> Fra::getAdjustedTerminationDate()
{
   if(!this->adjustedTerminationDateIsNull_){
        if(adjustedTerminationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedTerminationDateIDRef_));
        }else{
             return this->adjustedTerminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<AdjustableDate> Fra::getPaymentDate()
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
boost::shared_ptr<RelativeDateOffset> Fra::getFixingDateOffset()
{
   if(!this->fixingDateOffsetIsNull_){
        if(fixingDateOffsetIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(fixingDateOffsetIDRef_));
        }else{
             return this->fixingDateOffset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
boost::shared_ptr<DayCountFraction> Fra::getDayCountFraction()
{
   if(!this->dayCountFractionIsNull_){
        if(dayCountFractionIDRef_ != ""){
             return boost::shared_static_cast<DayCountFraction>(IDManager::instance().getID(dayCountFractionIDRef_));
        }else{
             return this->dayCountFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DayCountFraction>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> Fra::getCalculationPeriodNumberOfDays()
{
   if(!this->calculationPeriodNumberOfDaysIsNull_){
        if(calculationPeriodNumberOfDaysIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(calculationPeriodNumberOfDaysIDRef_));
        }else{
             return this->calculationPeriodNumberOfDays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<Money> Fra::getNotional()
{
   if(!this->notionalIsNull_){
        if(notionalIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(notionalIDRef_));
        }else{
             return this->notional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Fra::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        if(fixedRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(fixedRateIDRef_));
        }else{
             return this->fixedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<FloatingRateIndex> Fra::getFloatingRateIndex()
{
   if(!this->floatingRateIndexIsNull_){
        if(floatingRateIndexIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateIndex>(IDManager::instance().getID(floatingRateIndexIDRef_));
        }else{
             return this->floatingRateIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateIndex>();
   }
}
std::vector<boost::shared_ptr<Period>> Fra::getIndexTenor()
{
   if(!this->indexTenorIsNull_){
        if(indexTenorIDRef_ != ""){
             return this->indexTenor_;
        }else{
             return this->indexTenor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Period>>();
   }
}
boost::shared_ptr<FraDiscountingEnum> Fra::getFraDiscounting()
{
   if(!this->fraDiscountingIsNull_){
        if(fraDiscountingIDRef_ != ""){
             return boost::shared_static_cast<FraDiscountingEnum>(IDManager::instance().getID(fraDiscountingIDRef_));
        }else{
             return this->fraDiscounting_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FraDiscountingEnum>();
   }
}
}

