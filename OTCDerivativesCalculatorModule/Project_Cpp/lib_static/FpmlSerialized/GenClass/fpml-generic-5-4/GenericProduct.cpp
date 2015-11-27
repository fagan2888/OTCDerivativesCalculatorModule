// GenericProduct.cpp 
#include "GenericProduct.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GenericProduct::GenericProduct(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //multiLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multiLegNode = xmlNode->FirstChildElement("multiLeg");

   if(multiLegNode){multiLegIsNull_ = false;}
   else{multiLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multiLegNode , address : " << multiLegNode << std::endl;
   #endif
   if(multiLegNode)
   {
      if(multiLegNode->Attribute("href") || multiLegNode->Attribute("id"))
      {
          if(multiLegNode->Attribute("id"))
          {
             multiLegIDRef_ = multiLegNode->Attribute("id");
             multiLeg_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multiLegNode));
             multiLeg_->setID(multiLegIDRef_);
             IDManager::instance().setID(multiLegIDRef_,multiLeg_);
          }
          else if(multiLegNode->Attribute("href")) { multiLegIDRef_ = multiLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multiLeg_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multiLegNode));}
   }

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

   //counterpartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* counterpartyReferenceNode = xmlNode->FirstChildElement("counterpartyReference");

   if(counterpartyReferenceNode){counterpartyReferenceIsNull_ = false;}
   else{counterpartyReferenceIsNull_ = true;}

   if(counterpartyReferenceNode)
   {
      for(counterpartyReferenceNode; counterpartyReferenceNode; counterpartyReferenceNode = counterpartyReferenceNode->NextSiblingElement("counterpartyReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- counterpartyReferenceNode , address : " << counterpartyReferenceNode << std::endl;
          #endif
          if(counterpartyReferenceNode->Attribute("href") || counterpartyReferenceNode->Attribute("id"))
          {
              if(counterpartyReferenceNode->Attribute("id"))
              {
                  counterpartyReferenceIDRef_ = counterpartyReferenceNode->Attribute("id");
                  counterpartyReference_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(counterpartyReferenceNode)));
                  counterpartyReference_.back()->setID(counterpartyReferenceIDRef_);
                  IDManager::instance().setID(counterpartyReferenceIDRef_, counterpartyReference_.back());
              }
              else if(counterpartyReferenceNode->Attribute("href")) { counterpartyReferenceIDRef_ = counterpartyReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { counterpartyReference_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(counterpartyReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- counterpartyReferenceNode , address : " << counterpartyReferenceNode << std::endl;
       #endif
   }

   //premiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumNode = xmlNode->FirstChildElement("premium");

   if(premiumNode){premiumIsNull_ = false;}
   else{premiumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
   #endif
   if(premiumNode)
   {
      if(premiumNode->Attribute("href") || premiumNode->Attribute("id"))
      {
          if(premiumNode->Attribute("id"))
          {
             premiumIDRef_ = premiumNode->Attribute("id");
             premium_ = boost::shared_ptr<SimplePayment>(new SimplePayment(premiumNode));
             premium_->setID(premiumIDRef_);
             IDManager::instance().setID(premiumIDRef_,premium_);
          }
          else if(premiumNode->Attribute("href")) { premiumIDRef_ = premiumNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { premium_ = boost::shared_ptr<SimplePayment>(new SimplePayment(premiumNode));}
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
             effectiveDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(effectiveDateNode));}
   }

   //expirationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationDateNode = xmlNode->FirstChildElement("expirationDate");

   if(expirationDateNode){expirationDateIsNull_ = false;}
   else{expirationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationDateNode , address : " << expirationDateNode << std::endl;
   #endif
   if(expirationDateNode)
   {
      if(expirationDateNode->Attribute("href") || expirationDateNode->Attribute("id"))
      {
          if(expirationDateNode->Attribute("id"))
          {
             expirationDateIDRef_ = expirationDateNode->Attribute("id");
             expirationDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(expirationDateNode));
             expirationDate_->setID(expirationDateIDRef_);
             IDManager::instance().setID(expirationDateIDRef_,expirationDate_);
          }
          else if(expirationDateNode->Attribute("href")) { expirationDateIDRef_ = expirationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(expirationDateNode));}
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
             terminationDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(terminationDateNode));
             terminationDate_->setID(terminationDateIDRef_);
             IDManager::instance().setID(terminationDateIDRef_,terminationDate_);
          }
          else if(terminationDateNode->Attribute("href")) { terminationDateIDRef_ = terminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { terminationDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(terminationDateNode));}
   }

   //underlyerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyerNode = xmlNode->FirstChildElement("underlyer");

   if(underlyerNode){underlyerIsNull_ = false;}
   else{underlyerIsNull_ = true;}

   if(underlyerNode)
   {
      for(underlyerNode; underlyerNode; underlyerNode = underlyerNode->NextSiblingElement("underlyer")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyerNode , address : " << underlyerNode << std::endl;
          #endif
          if(underlyerNode->Attribute("href") || underlyerNode->Attribute("id"))
          {
              if(underlyerNode->Attribute("id"))
              {
                  underlyerIDRef_ = underlyerNode->Attribute("id");
                  underlyer_.push_back(boost::shared_ptr<TradeUnderlyer2>(new TradeUnderlyer2(underlyerNode)));
                  underlyer_.back()->setID(underlyerIDRef_);
                  IDManager::instance().setID(underlyerIDRef_, underlyer_.back());
              }
              else if(underlyerNode->Attribute("href")) { underlyerIDRef_ = underlyerNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { underlyer_.push_back(boost::shared_ptr<TradeUnderlyer2>(new TradeUnderlyer2(underlyerNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyerNode , address : " << underlyerNode << std::endl;
       #endif
   }

   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   if(notionalNode)
   {
      for(notionalNode; notionalNode; notionalNode = notionalNode->NextSiblingElement("notional")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
          #endif
          if(notionalNode->Attribute("href") || notionalNode->Attribute("id"))
          {
              if(notionalNode->Attribute("id"))
              {
                  notionalIDRef_ = notionalNode->Attribute("id");
                  notional_.push_back(boost::shared_ptr<CashflowNotional>(new CashflowNotional(notionalNode)));
                  notional_.back()->setID(notionalIDRef_);
                  IDManager::instance().setID(notionalIDRef_, notional_.back());
              }
              else if(notionalNode->Attribute("href")) { notionalIDRef_ = notionalNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { notional_.push_back(boost::shared_ptr<CashflowNotional>(new CashflowNotional(notionalNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
       #endif
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
             optionType_ = boost::shared_ptr<OptionType>(new OptionType(optionTypeNode));
             optionType_->setID(optionTypeIDRef_);
             IDManager::instance().setID(optionTypeIDRef_,optionType_);
          }
          else if(optionTypeNode->Attribute("href")) { optionTypeIDRef_ = optionTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionType_ = boost::shared_ptr<OptionType>(new OptionType(optionTypeNode));}
   }

   //settlementCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementCurrencyNode = xmlNode->FirstChildElement("settlementCurrency");

   if(settlementCurrencyNode){settlementCurrencyIsNull_ = false;}
   else{settlementCurrencyIsNull_ = true;}

   if(settlementCurrencyNode)
   {
      for(settlementCurrencyNode; settlementCurrencyNode; settlementCurrencyNode = settlementCurrencyNode->NextSiblingElement("settlementCurrency")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementCurrencyNode , address : " << settlementCurrencyNode << std::endl;
          #endif
          if(settlementCurrencyNode->Attribute("href") || settlementCurrencyNode->Attribute("id"))
          {
              if(settlementCurrencyNode->Attribute("id"))
              {
                  settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("id");
                  settlementCurrency_.push_back(boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(settlementCurrencyNode)));
                  settlementCurrency_.back()->setID(settlementCurrencyIDRef_);
                  IDManager::instance().setID(settlementCurrencyIDRef_, settlementCurrency_.back());
              }
              else if(settlementCurrencyNode->Attribute("href")) { settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementCurrency_.push_back(boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(settlementCurrencyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementCurrencyNode , address : " << settlementCurrencyNode << std::endl;
       #endif
   }

   //dayCountFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountFractionNode = xmlNode->FirstChildElement("dayCountFraction");

   if(dayCountFractionNode){dayCountFractionIsNull_ = false;}
   else{dayCountFractionIsNull_ = true;}

   if(dayCountFractionNode)
   {
      for(dayCountFractionNode; dayCountFractionNode; dayCountFractionNode = dayCountFractionNode->NextSiblingElement("dayCountFraction")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountFractionNode , address : " << dayCountFractionNode << std::endl;
          #endif
          if(dayCountFractionNode->Attribute("href") || dayCountFractionNode->Attribute("id"))
          {
              if(dayCountFractionNode->Attribute("id"))
              {
                  dayCountFractionIDRef_ = dayCountFractionNode->Attribute("id");
                  dayCountFraction_.push_back(boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode)));
                  dayCountFraction_.back()->setID(dayCountFractionIDRef_);
                  IDManager::instance().setID(dayCountFractionIDRef_, dayCountFraction_.back());
              }
              else if(dayCountFractionNode->Attribute("href")) { dayCountFractionIDRef_ = dayCountFractionNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { dayCountFraction_.push_back(boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountFractionNode , address : " << dayCountFractionNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> GenericProduct::getMultiLeg()
{
   if(!this->multiLegIsNull_){
        if(multiLegIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(multiLegIDRef_));
        }else{
             return this->multiLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<PartyReference> GenericProduct::getBuyerPartyReference()
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
boost::shared_ptr<AccountReference> GenericProduct::getBuyerAccountReference()
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
boost::shared_ptr<PartyReference> GenericProduct::getSellerPartyReference()
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
boost::shared_ptr<AccountReference> GenericProduct::getSellerAccountReference()
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
std::vector<boost::shared_ptr<PartyReference>> GenericProduct::getCounterpartyReference()
{
   if(!this->counterpartyReferenceIsNull_){
        if(counterpartyReferenceIDRef_ != ""){
             return this->counterpartyReference_;
        }else{
             return this->counterpartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyReference>>();
   }
}
boost::shared_ptr<SimplePayment> GenericProduct::getPremium()
{
   if(!this->premiumIsNull_){
        if(premiumIDRef_ != ""){
             return boost::shared_static_cast<SimplePayment>(IDManager::instance().getID(premiumIDRef_));
        }else{
             return this->premium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimplePayment>();
   }
}
boost::shared_ptr<AdjustableDate2> GenericProduct::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate2>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate2>();
   }
}
boost::shared_ptr<AdjustableDate2> GenericProduct::getExpirationDate()
{
   if(!this->expirationDateIsNull_){
        if(expirationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate2>(IDManager::instance().getID(expirationDateIDRef_));
        }else{
             return this->expirationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate2>();
   }
}
boost::shared_ptr<AdjustableDate2> GenericProduct::getTerminationDate()
{
   if(!this->terminationDateIsNull_){
        if(terminationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate2>(IDManager::instance().getID(terminationDateIDRef_));
        }else{
             return this->terminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate2>();
   }
}
std::vector<boost::shared_ptr<TradeUnderlyer2>> GenericProduct::getUnderlyer()
{
   if(!this->underlyerIsNull_){
        if(underlyerIDRef_ != ""){
             return this->underlyer_;
        }else{
             return this->underlyer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeUnderlyer2>>();
   }
}
std::vector<boost::shared_ptr<CashflowNotional>> GenericProduct::getNotional()
{
   if(!this->notionalIsNull_){
        if(notionalIDRef_ != ""){
             return this->notional_;
        }else{
             return this->notional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CashflowNotional>>();
   }
}
boost::shared_ptr<OptionType> GenericProduct::getOptionType()
{
   if(!this->optionTypeIsNull_){
        if(optionTypeIDRef_ != ""){
             return boost::shared_static_cast<OptionType>(IDManager::instance().getID(optionTypeIDRef_));
        }else{
             return this->optionType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionType>();
   }
}
std::vector<boost::shared_ptr<IdentifiedCurrency>> GenericProduct::getSettlementCurrency()
{
   if(!this->settlementCurrencyIsNull_){
        if(settlementCurrencyIDRef_ != ""){
             return this->settlementCurrency_;
        }else{
             return this->settlementCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<IdentifiedCurrency>>();
   }
}
std::vector<boost::shared_ptr<DayCountFraction>> GenericProduct::getDayCountFraction()
{
   if(!this->dayCountFractionIsNull_){
        if(dayCountFractionIDRef_ != ""){
             return this->dayCountFraction_;
        }else{
             return this->dayCountFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DayCountFraction>>();
   }
}
}

