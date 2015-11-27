// TermDeposit.cpp 
#include "TermDeposit.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TermDeposit::TermDeposit(TiXmlNode* xmlNode)
: Product(xmlNode)
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

   //startDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* startDateNode = xmlNode->FirstChildElement("startDate");

   if(startDateNode){startDateIsNull_ = false;}
   else{startDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- startDateNode , address : " << startDateNode << std::endl;
   #endif
   if(startDateNode)
   {
      if(startDateNode->Attribute("href") || startDateNode->Attribute("id"))
      {
          if(startDateNode->Attribute("id"))
          {
             startDateIDRef_ = startDateNode->Attribute("id");
             startDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(startDateNode));
             startDate_->setID(startDateIDRef_);
             IDManager::instance().setID(startDateIDRef_,startDate_);
          }
          else if(startDateNode->Attribute("href")) { startDateIDRef_ = startDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { startDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(startDateNode));}
   }

   //maturityDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityDateNode = xmlNode->FirstChildElement("maturityDate");

   if(maturityDateNode){maturityDateIsNull_ = false;}
   else{maturityDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityDateNode , address : " << maturityDateNode << std::endl;
   #endif
   if(maturityDateNode)
   {
      if(maturityDateNode->Attribute("href") || maturityDateNode->Attribute("id"))
      {
          if(maturityDateNode->Attribute("id"))
          {
             maturityDateIDRef_ = maturityDateNode->Attribute("id");
             maturityDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(maturityDateNode));
             maturityDate_->setID(maturityDateIDRef_);
             IDManager::instance().setID(maturityDateIDRef_,maturityDate_);
          }
          else if(maturityDateNode->Attribute("href")) { maturityDateIDRef_ = maturityDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maturityDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(maturityDateNode));}
   }

   //tenorNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNameNode = xmlNode->FirstChildElement("tenorName");

   if(tenorNameNode){tenorNameIsNull_ = false;}
   else{tenorNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNameNode , address : " << tenorNameNode << std::endl;
   #endif
   if(tenorNameNode)
   {
      if(tenorNameNode->Attribute("href") || tenorNameNode->Attribute("id"))
      {
          if(tenorNameNode->Attribute("id"))
          {
             tenorNameIDRef_ = tenorNameNode->Attribute("id");
             tenorName_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(tenorNameNode));
             tenorName_->setID(tenorNameIDRef_);
             IDManager::instance().setID(tenorNameIDRef_,tenorName_);
          }
          else if(tenorNameNode->Attribute("href")) { tenorNameIDRef_ = tenorNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tenorName_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(tenorNameNode));}
   }

   //tenorPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorPeriodNode = xmlNode->FirstChildElement("tenorPeriod");

   if(tenorPeriodNode){tenorPeriodIsNull_ = false;}
   else{tenorPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorPeriodNode , address : " << tenorPeriodNode << std::endl;
   #endif
   if(tenorPeriodNode)
   {
      if(tenorPeriodNode->Attribute("href") || tenorPeriodNode->Attribute("id"))
      {
          if(tenorPeriodNode->Attribute("id"))
          {
             tenorPeriodIDRef_ = tenorPeriodNode->Attribute("id");
             tenorPeriod_ = boost::shared_ptr<Period>(new Period(tenorPeriodNode));
             tenorPeriod_->setID(tenorPeriodIDRef_);
             IDManager::instance().setID(tenorPeriodIDRef_,tenorPeriod_);
          }
          else if(tenorPeriodNode->Attribute("href")) { tenorPeriodIDRef_ = tenorPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tenorPeriod_ = boost::shared_ptr<Period>(new Period(tenorPeriodNode));}
   }

   //principalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalNode = xmlNode->FirstChildElement("principal");

   if(principalNode){principalIsNull_ = false;}
   else{principalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalNode , address : " << principalNode << std::endl;
   #endif
   if(principalNode)
   {
      if(principalNode->Attribute("href") || principalNode->Attribute("id"))
      {
          if(principalNode->Attribute("id"))
          {
             principalIDRef_ = principalNode->Attribute("id");
             principal_ = boost::shared_ptr<PositiveMoney>(new PositiveMoney(principalNode));
             principal_->setID(principalIDRef_);
             IDManager::instance().setID(principalIDRef_,principal_);
          }
          else if(principalNode->Attribute("href")) { principalIDRef_ = principalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principal_ = boost::shared_ptr<PositiveMoney>(new PositiveMoney(principalNode));}
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
             fixedRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(fixedRateNode));
             fixedRate_->setID(fixedRateIDRef_);
             IDManager::instance().setID(fixedRateIDRef_,fixedRate_);
          }
          else if(fixedRateNode->Attribute("href")) { fixedRateIDRef_ = fixedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(fixedRateNode));}
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

   //featuresNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* featuresNode = xmlNode->FirstChildElement("features");

   if(featuresNode){featuresIsNull_ = false;}
   else{featuresIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- featuresNode , address : " << featuresNode << std::endl;
   #endif
   if(featuresNode)
   {
      if(featuresNode->Attribute("href") || featuresNode->Attribute("id"))
      {
          if(featuresNode->Attribute("id"))
          {
             featuresIDRef_ = featuresNode->Attribute("id");
             features_ = boost::shared_ptr<TermDepositFeatures>(new TermDepositFeatures(featuresNode));
             features_->setID(featuresIDRef_);
             IDManager::instance().setID(featuresIDRef_,features_);
          }
          else if(featuresNode->Attribute("href")) { featuresIDRef_ = featuresNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { features_ = boost::shared_ptr<TermDepositFeatures>(new TermDepositFeatures(featuresNode));}
   }

   //interestNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestNode = xmlNode->FirstChildElement("interest");

   if(interestNode){interestIsNull_ = false;}
   else{interestIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestNode , address : " << interestNode << std::endl;
   #endif
   if(interestNode)
   {
      if(interestNode->Attribute("href") || interestNode->Attribute("id"))
      {
          if(interestNode->Attribute("id"))
          {
             interestIDRef_ = interestNode->Attribute("id");
             interest_ = boost::shared_ptr<Money>(new Money(interestNode));
             interest_->setID(interestIDRef_);
             IDManager::instance().setID(interestIDRef_,interest_);
          }
          else if(interestNode->Attribute("href")) { interestIDRef_ = interestNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interest_ = boost::shared_ptr<Money>(new Money(interestNode));}
   }

   //paymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentNode = xmlNode->FirstChildElement("payment");

   if(paymentNode){paymentIsNull_ = false;}
   else{paymentIsNull_ = true;}

   if(paymentNode)
   {
      for(paymentNode; paymentNode; paymentNode = paymentNode->NextSiblingElement("payment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentNode , address : " << paymentNode << std::endl;
          #endif
          if(paymentNode->Attribute("href") || paymentNode->Attribute("id"))
          {
              if(paymentNode->Attribute("id"))
              {
                  paymentIDRef_ = paymentNode->Attribute("id");
                  payment_.push_back(boost::shared_ptr<Payment>(new Payment(paymentNode)));
                  payment_.back()->setID(paymentIDRef_);
                  IDManager::instance().setID(paymentIDRef_, payment_.back());
              }
              else if(paymentNode->Attribute("href")) { paymentIDRef_ = paymentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { payment_.push_back(boost::shared_ptr<Payment>(new Payment(paymentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentNode , address : " << paymentNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> TermDeposit::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> TermDeposit::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> TermDeposit::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> TermDeposit::getReceiverAccountReference()
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
boost::shared_ptr<XsdTypeDate> TermDeposit::getStartDate()
{
   if(!this->startDateIsNull_){
        if(startDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(startDateIDRef_));
        }else{
             return this->startDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> TermDeposit::getMaturityDate()
{
   if(!this->maturityDateIsNull_){
        if(maturityDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(maturityDateIDRef_));
        }else{
             return this->maturityDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeBoolean> TermDeposit::getTenorName()
{
   if(!this->tenorNameIsNull_){
        if(tenorNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(tenorNameIDRef_));
        }else{
             return this->tenorName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Period> TermDeposit::getTenorPeriod()
{
   if(!this->tenorPeriodIsNull_){
        if(tenorPeriodIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(tenorPeriodIDRef_));
        }else{
             return this->tenorPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<PositiveMoney> TermDeposit::getPrincipal()
{
   if(!this->principalIsNull_){
        if(principalIDRef_ != ""){
             return boost::shared_static_cast<PositiveMoney>(IDManager::instance().getID(principalIDRef_));
        }else{
             return this->principal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveMoney>();
   }
}
boost::shared_ptr<PositiveDecimal> TermDeposit::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        if(fixedRateIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(fixedRateIDRef_));
        }else{
             return this->fixedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<DayCountFraction> TermDeposit::getDayCountFraction()
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
boost::shared_ptr<TermDepositFeatures> TermDeposit::getFeatures()
{
   if(!this->featuresIsNull_){
        if(featuresIDRef_ != ""){
             return boost::shared_static_cast<TermDepositFeatures>(IDManager::instance().getID(featuresIDRef_));
        }else{
             return this->features_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermDepositFeatures>();
   }
}
boost::shared_ptr<Money> TermDeposit::getInterest()
{
   if(!this->interestIsNull_){
        if(interestIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(interestIDRef_));
        }else{
             return this->interest_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
std::vector<boost::shared_ptr<Payment>> TermDeposit::getPayment()
{
   if(!this->paymentIsNull_){
        if(paymentIDRef_ != ""){
             return this->payment_;
        }else{
             return this->payment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Payment>>();
   }
}
}

