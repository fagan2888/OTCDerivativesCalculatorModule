// CashSettlementTerms.cpp 
#include "CashSettlementTerms.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CashSettlementTerms::CashSettlementTerms(TiXmlNode* xmlNode)
: SettlementTerms(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valuationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationDateNode = xmlNode->FirstChildElement("valuationDate");

   if(valuationDateNode){valuationDateIsNull_ = false;}
   else{valuationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationDateNode , address : " << valuationDateNode << std::endl;
   #endif
   if(valuationDateNode)
   {
      if(valuationDateNode->Attribute("href") || valuationDateNode->Attribute("id"))
      {
          if(valuationDateNode->Attribute("id"))
          {
             valuationDateIDRef_ = valuationDateNode->Attribute("id");
             valuationDate_ = boost::shared_ptr<ValuationDate>(new ValuationDate(valuationDateNode));
             valuationDate_->setID(valuationDateIDRef_);
             IDManager::instance().setID(valuationDateIDRef_,valuationDate_);
          }
          else if(valuationDateNode->Attribute("href")) { valuationDateIDRef_ = valuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationDate_ = boost::shared_ptr<ValuationDate>(new ValuationDate(valuationDateNode));}
   }

   //valuationTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationTimeNode = xmlNode->FirstChildElement("valuationTime");

   if(valuationTimeNode){valuationTimeIsNull_ = false;}
   else{valuationTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationTimeNode , address : " << valuationTimeNode << std::endl;
   #endif
   if(valuationTimeNode)
   {
      if(valuationTimeNode->Attribute("href") || valuationTimeNode->Attribute("id"))
      {
          if(valuationTimeNode->Attribute("id"))
          {
             valuationTimeIDRef_ = valuationTimeNode->Attribute("id");
             valuationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(valuationTimeNode));
             valuationTime_->setID(valuationTimeIDRef_);
             IDManager::instance().setID(valuationTimeIDRef_,valuationTime_);
          }
          else if(valuationTimeNode->Attribute("href")) { valuationTimeIDRef_ = valuationTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(valuationTimeNode));}
   }

   //quotationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotationMethodNode = xmlNode->FirstChildElement("quotationMethod");

   if(quotationMethodNode){quotationMethodIsNull_ = false;}
   else{quotationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotationMethodNode , address : " << quotationMethodNode << std::endl;
   #endif
   if(quotationMethodNode)
   {
      if(quotationMethodNode->Attribute("href") || quotationMethodNode->Attribute("id"))
      {
          if(quotationMethodNode->Attribute("id"))
          {
             quotationMethodIDRef_ = quotationMethodNode->Attribute("id");
             quotationMethod_ = boost::shared_ptr<QuotationRateTypeEnum>(new QuotationRateTypeEnum(quotationMethodNode));
             quotationMethod_->setID(quotationMethodIDRef_);
             IDManager::instance().setID(quotationMethodIDRef_,quotationMethod_);
          }
          else if(quotationMethodNode->Attribute("href")) { quotationMethodIDRef_ = quotationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotationMethod_ = boost::shared_ptr<QuotationRateTypeEnum>(new QuotationRateTypeEnum(quotationMethodNode));}
   }

   //quotationAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotationAmountNode = xmlNode->FirstChildElement("quotationAmount");

   if(quotationAmountNode){quotationAmountIsNull_ = false;}
   else{quotationAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotationAmountNode , address : " << quotationAmountNode << std::endl;
   #endif
   if(quotationAmountNode)
   {
      if(quotationAmountNode->Attribute("href") || quotationAmountNode->Attribute("id"))
      {
          if(quotationAmountNode->Attribute("id"))
          {
             quotationAmountIDRef_ = quotationAmountNode->Attribute("id");
             quotationAmount_ = boost::shared_ptr<Money>(new Money(quotationAmountNode));
             quotationAmount_->setID(quotationAmountIDRef_);
             IDManager::instance().setID(quotationAmountIDRef_,quotationAmount_);
          }
          else if(quotationAmountNode->Attribute("href")) { quotationAmountIDRef_ = quotationAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotationAmount_ = boost::shared_ptr<Money>(new Money(quotationAmountNode));}
   }

   //minimumQuotationAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumQuotationAmountNode = xmlNode->FirstChildElement("minimumQuotationAmount");

   if(minimumQuotationAmountNode){minimumQuotationAmountIsNull_ = false;}
   else{minimumQuotationAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumQuotationAmountNode , address : " << minimumQuotationAmountNode << std::endl;
   #endif
   if(minimumQuotationAmountNode)
   {
      if(minimumQuotationAmountNode->Attribute("href") || minimumQuotationAmountNode->Attribute("id"))
      {
          if(minimumQuotationAmountNode->Attribute("id"))
          {
             minimumQuotationAmountIDRef_ = minimumQuotationAmountNode->Attribute("id");
             minimumQuotationAmount_ = boost::shared_ptr<Money>(new Money(minimumQuotationAmountNode));
             minimumQuotationAmount_->setID(minimumQuotationAmountIDRef_);
             IDManager::instance().setID(minimumQuotationAmountIDRef_,minimumQuotationAmount_);
          }
          else if(minimumQuotationAmountNode->Attribute("href")) { minimumQuotationAmountIDRef_ = minimumQuotationAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumQuotationAmount_ = boost::shared_ptr<Money>(new Money(minimumQuotationAmountNode));}
   }

   //dealerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dealerNode = xmlNode->FirstChildElement("dealer");

   if(dealerNode){dealerIsNull_ = false;}
   else{dealerIsNull_ = true;}

   if(dealerNode)
   {
      for(dealerNode; dealerNode; dealerNode = dealerNode->NextSiblingElement("dealer")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dealerNode , address : " << dealerNode << std::endl;
          #endif
          if(dealerNode->Attribute("href") || dealerNode->Attribute("id"))
          {
              if(dealerNode->Attribute("id"))
              {
                  dealerIDRef_ = dealerNode->Attribute("id");
                  dealer_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(dealerNode)));
                  dealer_.back()->setID(dealerIDRef_);
                  IDManager::instance().setID(dealerIDRef_, dealer_.back());
              }
              else if(dealerNode->Attribute("href")) { dealerIDRef_ = dealerNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { dealer_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(dealerNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dealerNode , address : " << dealerNode << std::endl;
       #endif
   }

   //cashSettlementBusinessDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementBusinessDaysNode = xmlNode->FirstChildElement("cashSettlementBusinessDays");

   if(cashSettlementBusinessDaysNode){cashSettlementBusinessDaysIsNull_ = false;}
   else{cashSettlementBusinessDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementBusinessDaysNode , address : " << cashSettlementBusinessDaysNode << std::endl;
   #endif
   if(cashSettlementBusinessDaysNode)
   {
      if(cashSettlementBusinessDaysNode->Attribute("href") || cashSettlementBusinessDaysNode->Attribute("id"))
      {
          if(cashSettlementBusinessDaysNode->Attribute("id"))
          {
             cashSettlementBusinessDaysIDRef_ = cashSettlementBusinessDaysNode->Attribute("id");
             cashSettlementBusinessDays_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(cashSettlementBusinessDaysNode));
             cashSettlementBusinessDays_->setID(cashSettlementBusinessDaysIDRef_);
             IDManager::instance().setID(cashSettlementBusinessDaysIDRef_,cashSettlementBusinessDays_);
          }
          else if(cashSettlementBusinessDaysNode->Attribute("href")) { cashSettlementBusinessDaysIDRef_ = cashSettlementBusinessDaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementBusinessDays_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(cashSettlementBusinessDaysNode));}
   }

   //cashSettlementAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementAmountNode = xmlNode->FirstChildElement("cashSettlementAmount");

   if(cashSettlementAmountNode){cashSettlementAmountIsNull_ = false;}
   else{cashSettlementAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementAmountNode , address : " << cashSettlementAmountNode << std::endl;
   #endif
   if(cashSettlementAmountNode)
   {
      if(cashSettlementAmountNode->Attribute("href") || cashSettlementAmountNode->Attribute("id"))
      {
          if(cashSettlementAmountNode->Attribute("id"))
          {
             cashSettlementAmountIDRef_ = cashSettlementAmountNode->Attribute("id");
             cashSettlementAmount_ = boost::shared_ptr<Money>(new Money(cashSettlementAmountNode));
             cashSettlementAmount_->setID(cashSettlementAmountIDRef_);
             IDManager::instance().setID(cashSettlementAmountIDRef_,cashSettlementAmount_);
          }
          else if(cashSettlementAmountNode->Attribute("href")) { cashSettlementAmountIDRef_ = cashSettlementAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementAmount_ = boost::shared_ptr<Money>(new Money(cashSettlementAmountNode));}
   }

   //recoveryFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* recoveryFactorNode = xmlNode->FirstChildElement("recoveryFactor");

   if(recoveryFactorNode){recoveryFactorIsNull_ = false;}
   else{recoveryFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- recoveryFactorNode , address : " << recoveryFactorNode << std::endl;
   #endif
   if(recoveryFactorNode)
   {
      if(recoveryFactorNode->Attribute("href") || recoveryFactorNode->Attribute("id"))
      {
          if(recoveryFactorNode->Attribute("id"))
          {
             recoveryFactorIDRef_ = recoveryFactorNode->Attribute("id");
             recoveryFactor_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(recoveryFactorNode));
             recoveryFactor_->setID(recoveryFactorIDRef_);
             IDManager::instance().setID(recoveryFactorIDRef_,recoveryFactor_);
          }
          else if(recoveryFactorNode->Attribute("href")) { recoveryFactorIDRef_ = recoveryFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { recoveryFactor_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(recoveryFactorNode));}
   }

   //fixedSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedSettlementNode = xmlNode->FirstChildElement("fixedSettlement");

   if(fixedSettlementNode){fixedSettlementIsNull_ = false;}
   else{fixedSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedSettlementNode , address : " << fixedSettlementNode << std::endl;
   #endif
   if(fixedSettlementNode)
   {
      if(fixedSettlementNode->Attribute("href") || fixedSettlementNode->Attribute("id"))
      {
          if(fixedSettlementNode->Attribute("id"))
          {
             fixedSettlementIDRef_ = fixedSettlementNode->Attribute("id");
             fixedSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fixedSettlementNode));
             fixedSettlement_->setID(fixedSettlementIDRef_);
             IDManager::instance().setID(fixedSettlementIDRef_,fixedSettlement_);
          }
          else if(fixedSettlementNode->Attribute("href")) { fixedSettlementIDRef_ = fixedSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fixedSettlementNode));}
   }

   //accruedInterestNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accruedInterestNode = xmlNode->FirstChildElement("accruedInterest");

   if(accruedInterestNode){accruedInterestIsNull_ = false;}
   else{accruedInterestIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accruedInterestNode , address : " << accruedInterestNode << std::endl;
   #endif
   if(accruedInterestNode)
   {
      if(accruedInterestNode->Attribute("href") || accruedInterestNode->Attribute("id"))
      {
          if(accruedInterestNode->Attribute("id"))
          {
             accruedInterestIDRef_ = accruedInterestNode->Attribute("id");
             accruedInterest_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(accruedInterestNode));
             accruedInterest_->setID(accruedInterestIDRef_);
             IDManager::instance().setID(accruedInterestIDRef_,accruedInterest_);
          }
          else if(accruedInterestNode->Attribute("href")) { accruedInterestIDRef_ = accruedInterestNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accruedInterest_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(accruedInterestNode));}
   }

   //valuationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationMethodNode = xmlNode->FirstChildElement("valuationMethod");

   if(valuationMethodNode){valuationMethodIsNull_ = false;}
   else{valuationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationMethodNode , address : " << valuationMethodNode << std::endl;
   #endif
   if(valuationMethodNode)
   {
      if(valuationMethodNode->Attribute("href") || valuationMethodNode->Attribute("id"))
      {
          if(valuationMethodNode->Attribute("id"))
          {
             valuationMethodIDRef_ = valuationMethodNode->Attribute("id");
             valuationMethod_ = boost::shared_ptr<ValuationMethodEnum>(new ValuationMethodEnum(valuationMethodNode));
             valuationMethod_->setID(valuationMethodIDRef_);
             IDManager::instance().setID(valuationMethodIDRef_,valuationMethod_);
          }
          else if(valuationMethodNode->Attribute("href")) { valuationMethodIDRef_ = valuationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationMethod_ = boost::shared_ptr<ValuationMethodEnum>(new ValuationMethodEnum(valuationMethodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ValuationDate> CashSettlementTerms::getValuationDate()
{
   if(!this->valuationDateIsNull_){
        if(valuationDateIDRef_ != ""){
             return boost::shared_static_cast<ValuationDate>(IDManager::instance().getID(valuationDateIDRef_));
        }else{
             return this->valuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationDate>();
   }
}
boost::shared_ptr<BusinessCenterTime> CashSettlementTerms::getValuationTime()
{
   if(!this->valuationTimeIsNull_){
        if(valuationTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(valuationTimeIDRef_));
        }else{
             return this->valuationTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<QuotationRateTypeEnum> CashSettlementTerms::getQuotationMethod()
{
   if(!this->quotationMethodIsNull_){
        if(quotationMethodIDRef_ != ""){
             return boost::shared_static_cast<QuotationRateTypeEnum>(IDManager::instance().getID(quotationMethodIDRef_));
        }else{
             return this->quotationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationRateTypeEnum>();
   }
}
boost::shared_ptr<Money> CashSettlementTerms::getQuotationAmount()
{
   if(!this->quotationAmountIsNull_){
        if(quotationAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(quotationAmountIDRef_));
        }else{
             return this->quotationAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<Money> CashSettlementTerms::getMinimumQuotationAmount()
{
   if(!this->minimumQuotationAmountIsNull_){
        if(minimumQuotationAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(minimumQuotationAmountIDRef_));
        }else{
             return this->minimumQuotationAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
std::vector<boost::shared_ptr<XsdTypeString>> CashSettlementTerms::getDealer()
{
   if(!this->dealerIsNull_){
        if(dealerIDRef_ != ""){
             return this->dealer_;
        }else{
             return this->dealer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeString>>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> CashSettlementTerms::getCashSettlementBusinessDays()
{
   if(!this->cashSettlementBusinessDaysIsNull_){
        if(cashSettlementBusinessDaysIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(cashSettlementBusinessDaysIDRef_));
        }else{
             return this->cashSettlementBusinessDays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
boost::shared_ptr<Money> CashSettlementTerms::getCashSettlementAmount()
{
   if(!this->cashSettlementAmountIsNull_){
        if(cashSettlementAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(cashSettlementAmountIDRef_));
        }else{
             return this->cashSettlementAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<RestrictedPercentage> CashSettlementTerms::getRecoveryFactor()
{
   if(!this->recoveryFactorIsNull_){
        if(recoveryFactorIDRef_ != ""){
             return boost::shared_static_cast<RestrictedPercentage>(IDManager::instance().getID(recoveryFactorIDRef_));
        }else{
             return this->recoveryFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestrictedPercentage>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CashSettlementTerms::getFixedSettlement()
{
   if(!this->fixedSettlementIsNull_){
        if(fixedSettlementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(fixedSettlementIDRef_));
        }else{
             return this->fixedSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CashSettlementTerms::getAccruedInterest()
{
   if(!this->accruedInterestIsNull_){
        if(accruedInterestIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(accruedInterestIDRef_));
        }else{
             return this->accruedInterest_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<ValuationMethodEnum> CashSettlementTerms::getValuationMethod()
{
   if(!this->valuationMethodIsNull_){
        if(valuationMethodIDRef_ != ""){
             return boost::shared_static_cast<ValuationMethodEnum>(IDManager::instance().getID(valuationMethodIDRef_));
        }else{
             return this->valuationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationMethodEnum>();
   }
}
}

