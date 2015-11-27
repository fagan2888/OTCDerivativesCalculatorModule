// InterestRateStream.cpp 
#include "InterestRateStream.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestRateStream::InterestRateStream(TiXmlNode* xmlNode)
: Leg(xmlNode)
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

   //calculationPeriodDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodDatesNode = xmlNode->FirstChildElement("calculationPeriodDates");

   if(calculationPeriodDatesNode){calculationPeriodDatesIsNull_ = false;}
   else{calculationPeriodDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodDatesNode , address : " << calculationPeriodDatesNode << std::endl;
   #endif
   if(calculationPeriodDatesNode)
   {
      if(calculationPeriodDatesNode->Attribute("href") || calculationPeriodDatesNode->Attribute("id"))
      {
          if(calculationPeriodDatesNode->Attribute("id"))
          {
             calculationPeriodDatesIDRef_ = calculationPeriodDatesNode->Attribute("id");
             calculationPeriodDates_ = boost::shared_ptr<CalculationPeriodDates>(new CalculationPeriodDates(calculationPeriodDatesNode));
             calculationPeriodDates_->setID(calculationPeriodDatesIDRef_);
             IDManager::instance().setID(calculationPeriodDatesIDRef_,calculationPeriodDates_);
          }
          else if(calculationPeriodDatesNode->Attribute("href")) { calculationPeriodDatesIDRef_ = calculationPeriodDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodDates_ = boost::shared_ptr<CalculationPeriodDates>(new CalculationPeriodDates(calculationPeriodDatesNode));}
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
             paymentDates_ = boost::shared_ptr<PaymentDates>(new PaymentDates(paymentDatesNode));
             paymentDates_->setID(paymentDatesIDRef_);
             IDManager::instance().setID(paymentDatesIDRef_,paymentDates_);
          }
          else if(paymentDatesNode->Attribute("href")) { paymentDatesIDRef_ = paymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDates_ = boost::shared_ptr<PaymentDates>(new PaymentDates(paymentDatesNode));}
   }

   //resetDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resetDatesNode = xmlNode->FirstChildElement("resetDates");

   if(resetDatesNode){resetDatesIsNull_ = false;}
   else{resetDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resetDatesNode , address : " << resetDatesNode << std::endl;
   #endif
   if(resetDatesNode)
   {
      if(resetDatesNode->Attribute("href") || resetDatesNode->Attribute("id"))
      {
          if(resetDatesNode->Attribute("id"))
          {
             resetDatesIDRef_ = resetDatesNode->Attribute("id");
             resetDates_ = boost::shared_ptr<ResetDates>(new ResetDates(resetDatesNode));
             resetDates_->setID(resetDatesIDRef_);
             IDManager::instance().setID(resetDatesIDRef_,resetDates_);
          }
          else if(resetDatesNode->Attribute("href")) { resetDatesIDRef_ = resetDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resetDates_ = boost::shared_ptr<ResetDates>(new ResetDates(resetDatesNode));}
   }

   //calculationPeriodAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodAmountNode = xmlNode->FirstChildElement("calculationPeriodAmount");

   if(calculationPeriodAmountNode){calculationPeriodAmountIsNull_ = false;}
   else{calculationPeriodAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodAmountNode , address : " << calculationPeriodAmountNode << std::endl;
   #endif
   if(calculationPeriodAmountNode)
   {
      if(calculationPeriodAmountNode->Attribute("href") || calculationPeriodAmountNode->Attribute("id"))
      {
          if(calculationPeriodAmountNode->Attribute("id"))
          {
             calculationPeriodAmountIDRef_ = calculationPeriodAmountNode->Attribute("id");
             calculationPeriodAmount_ = boost::shared_ptr<CalculationPeriodAmount>(new CalculationPeriodAmount(calculationPeriodAmountNode));
             calculationPeriodAmount_->setID(calculationPeriodAmountIDRef_);
             IDManager::instance().setID(calculationPeriodAmountIDRef_,calculationPeriodAmount_);
          }
          else if(calculationPeriodAmountNode->Attribute("href")) { calculationPeriodAmountIDRef_ = calculationPeriodAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodAmount_ = boost::shared_ptr<CalculationPeriodAmount>(new CalculationPeriodAmount(calculationPeriodAmountNode));}
   }

   //stubCalculationPeriodAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stubCalculationPeriodAmountNode = xmlNode->FirstChildElement("stubCalculationPeriodAmount");

   if(stubCalculationPeriodAmountNode){stubCalculationPeriodAmountIsNull_ = false;}
   else{stubCalculationPeriodAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stubCalculationPeriodAmountNode , address : " << stubCalculationPeriodAmountNode << std::endl;
   #endif
   if(stubCalculationPeriodAmountNode)
   {
      if(stubCalculationPeriodAmountNode->Attribute("href") || stubCalculationPeriodAmountNode->Attribute("id"))
      {
          if(stubCalculationPeriodAmountNode->Attribute("id"))
          {
             stubCalculationPeriodAmountIDRef_ = stubCalculationPeriodAmountNode->Attribute("id");
             stubCalculationPeriodAmount_ = boost::shared_ptr<StubCalculationPeriodAmount>(new StubCalculationPeriodAmount(stubCalculationPeriodAmountNode));
             stubCalculationPeriodAmount_->setID(stubCalculationPeriodAmountIDRef_);
             IDManager::instance().setID(stubCalculationPeriodAmountIDRef_,stubCalculationPeriodAmount_);
          }
          else if(stubCalculationPeriodAmountNode->Attribute("href")) { stubCalculationPeriodAmountIDRef_ = stubCalculationPeriodAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stubCalculationPeriodAmount_ = boost::shared_ptr<StubCalculationPeriodAmount>(new StubCalculationPeriodAmount(stubCalculationPeriodAmountNode));}
   }

   //principalExchangesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalExchangesNode = xmlNode->FirstChildElement("principalExchanges");

   if(principalExchangesNode){principalExchangesIsNull_ = false;}
   else{principalExchangesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalExchangesNode , address : " << principalExchangesNode << std::endl;
   #endif
   if(principalExchangesNode)
   {
      if(principalExchangesNode->Attribute("href") || principalExchangesNode->Attribute("id"))
      {
          if(principalExchangesNode->Attribute("id"))
          {
             principalExchangesIDRef_ = principalExchangesNode->Attribute("id");
             principalExchanges_ = boost::shared_ptr<PrincipalExchanges>(new PrincipalExchanges(principalExchangesNode));
             principalExchanges_->setID(principalExchangesIDRef_);
             IDManager::instance().setID(principalExchangesIDRef_,principalExchanges_);
          }
          else if(principalExchangesNode->Attribute("href")) { principalExchangesIDRef_ = principalExchangesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principalExchanges_ = boost::shared_ptr<PrincipalExchanges>(new PrincipalExchanges(principalExchangesNode));}
   }

   //cashflowsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashflowsNode = xmlNode->FirstChildElement("cashflows");

   if(cashflowsNode){cashflowsIsNull_ = false;}
   else{cashflowsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashflowsNode , address : " << cashflowsNode << std::endl;
   #endif
   if(cashflowsNode)
   {
      if(cashflowsNode->Attribute("href") || cashflowsNode->Attribute("id"))
      {
          if(cashflowsNode->Attribute("id"))
          {
             cashflowsIDRef_ = cashflowsNode->Attribute("id");
             cashflows_ = boost::shared_ptr<Cashflows>(new Cashflows(cashflowsNode));
             cashflows_->setID(cashflowsIDRef_);
             IDManager::instance().setID(cashflowsIDRef_,cashflows_);
          }
          else if(cashflowsNode->Attribute("href")) { cashflowsIDRef_ = cashflowsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashflows_ = boost::shared_ptr<Cashflows>(new Cashflows(cashflowsNode));}
   }

   //settlementProvisionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementProvisionNode = xmlNode->FirstChildElement("settlementProvision");

   if(settlementProvisionNode){settlementProvisionIsNull_ = false;}
   else{settlementProvisionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementProvisionNode , address : " << settlementProvisionNode << std::endl;
   #endif
   if(settlementProvisionNode)
   {
      if(settlementProvisionNode->Attribute("href") || settlementProvisionNode->Attribute("id"))
      {
          if(settlementProvisionNode->Attribute("id"))
          {
             settlementProvisionIDRef_ = settlementProvisionNode->Attribute("id");
             settlementProvision_ = boost::shared_ptr<SettlementProvision>(new SettlementProvision(settlementProvisionNode));
             settlementProvision_->setID(settlementProvisionIDRef_);
             IDManager::instance().setID(settlementProvisionIDRef_,settlementProvision_);
          }
          else if(settlementProvisionNode->Attribute("href")) { settlementProvisionIDRef_ = settlementProvisionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementProvision_ = boost::shared_ptr<SettlementProvision>(new SettlementProvision(settlementProvisionNode));}
   }

   //formulaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* formulaNode = xmlNode->FirstChildElement("formula");

   if(formulaNode){formulaIsNull_ = false;}
   else{formulaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- formulaNode , address : " << formulaNode << std::endl;
   #endif
   if(formulaNode)
   {
      if(formulaNode->Attribute("href") || formulaNode->Attribute("id"))
      {
          if(formulaNode->Attribute("id"))
          {
             formulaIDRef_ = formulaNode->Attribute("id");
             formula_ = boost::shared_ptr<Formula>(new Formula(formulaNode));
             formula_->setID(formulaIDRef_);
             IDManager::instance().setID(formulaIDRef_,formula_);
          }
          else if(formulaNode->Attribute("href")) { formulaIDRef_ = formulaNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { formula_ = boost::shared_ptr<Formula>(new Formula(formulaNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> InterestRateStream::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> InterestRateStream::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> InterestRateStream::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> InterestRateStream::getReceiverAccountReference()
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
boost::shared_ptr<CalculationPeriodDates> InterestRateStream::getCalculationPeriodDates()
{
   if(!this->calculationPeriodDatesIsNull_){
        if(calculationPeriodDatesIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodDates>(IDManager::instance().getID(calculationPeriodDatesIDRef_));
        }else{
             return this->calculationPeriodDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodDates>();
   }
}
boost::shared_ptr<PaymentDates> InterestRateStream::getPaymentDates()
{
   if(!this->paymentDatesIsNull_){
        if(paymentDatesIDRef_ != ""){
             return boost::shared_static_cast<PaymentDates>(IDManager::instance().getID(paymentDatesIDRef_));
        }else{
             return this->paymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PaymentDates>();
   }
}
boost::shared_ptr<ResetDates> InterestRateStream::getResetDates()
{
   if(!this->resetDatesIsNull_){
        if(resetDatesIDRef_ != ""){
             return boost::shared_static_cast<ResetDates>(IDManager::instance().getID(resetDatesIDRef_));
        }else{
             return this->resetDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ResetDates>();
   }
}
boost::shared_ptr<CalculationPeriodAmount> InterestRateStream::getCalculationPeriodAmount()
{
   if(!this->calculationPeriodAmountIsNull_){
        if(calculationPeriodAmountIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodAmount>(IDManager::instance().getID(calculationPeriodAmountIDRef_));
        }else{
             return this->calculationPeriodAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodAmount>();
   }
}
boost::shared_ptr<StubCalculationPeriodAmount> InterestRateStream::getStubCalculationPeriodAmount()
{
   if(!this->stubCalculationPeriodAmountIsNull_){
        if(stubCalculationPeriodAmountIDRef_ != ""){
             return boost::shared_static_cast<StubCalculationPeriodAmount>(IDManager::instance().getID(stubCalculationPeriodAmountIDRef_));
        }else{
             return this->stubCalculationPeriodAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StubCalculationPeriodAmount>();
   }
}
boost::shared_ptr<PrincipalExchanges> InterestRateStream::getPrincipalExchanges()
{
   if(!this->principalExchangesIsNull_){
        if(principalExchangesIDRef_ != ""){
             return boost::shared_static_cast<PrincipalExchanges>(IDManager::instance().getID(principalExchangesIDRef_));
        }else{
             return this->principalExchanges_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrincipalExchanges>();
   }
}
boost::shared_ptr<Cashflows> InterestRateStream::getCashflows()
{
   if(!this->cashflowsIsNull_){
        if(cashflowsIDRef_ != ""){
             return boost::shared_static_cast<Cashflows>(IDManager::instance().getID(cashflowsIDRef_));
        }else{
             return this->cashflows_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Cashflows>();
   }
}
boost::shared_ptr<SettlementProvision> InterestRateStream::getSettlementProvision()
{
   if(!this->settlementProvisionIsNull_){
        if(settlementProvisionIDRef_ != ""){
             return boost::shared_static_cast<SettlementProvision>(IDManager::instance().getID(settlementProvisionIDRef_));
        }else{
             return this->settlementProvision_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementProvision>();
   }
}
boost::shared_ptr<Formula> InterestRateStream::getFormula()
{
   if(!this->formulaIsNull_){
        if(formulaIDRef_ != ""){
             return boost::shared_static_cast<Formula>(IDManager::instance().getID(formulaIDRef_));
        }else{
             return this->formula_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Formula>();
   }
}
}

