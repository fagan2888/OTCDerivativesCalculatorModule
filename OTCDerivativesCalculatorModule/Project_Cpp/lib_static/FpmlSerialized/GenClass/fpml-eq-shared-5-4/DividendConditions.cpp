// DividendConditions.cpp 
#include "DividendConditions.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendConditions::DividendConditions(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dividendReinvestmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendReinvestmentNode = xmlNode->FirstChildElement("dividendReinvestment");

   if(dividendReinvestmentNode){dividendReinvestmentIsNull_ = false;}
   else{dividendReinvestmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendReinvestmentNode , address : " << dividendReinvestmentNode << std::endl;
   #endif
   if(dividendReinvestmentNode)
   {
      if(dividendReinvestmentNode->Attribute("href") || dividendReinvestmentNode->Attribute("id"))
      {
          if(dividendReinvestmentNode->Attribute("id"))
          {
             dividendReinvestmentIDRef_ = dividendReinvestmentNode->Attribute("id");
             dividendReinvestment_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(dividendReinvestmentNode));
             dividendReinvestment_->setID(dividendReinvestmentIDRef_);
             IDManager::instance().setID(dividendReinvestmentIDRef_,dividendReinvestment_);
          }
          else if(dividendReinvestmentNode->Attribute("href")) { dividendReinvestmentIDRef_ = dividendReinvestmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendReinvestment_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(dividendReinvestmentNode));}
   }

   //dividendEntitlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendEntitlementNode = xmlNode->FirstChildElement("dividendEntitlement");

   if(dividendEntitlementNode){dividendEntitlementIsNull_ = false;}
   else{dividendEntitlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendEntitlementNode , address : " << dividendEntitlementNode << std::endl;
   #endif
   if(dividendEntitlementNode)
   {
      if(dividendEntitlementNode->Attribute("href") || dividendEntitlementNode->Attribute("id"))
      {
          if(dividendEntitlementNode->Attribute("id"))
          {
             dividendEntitlementIDRef_ = dividendEntitlementNode->Attribute("id");
             dividendEntitlement_ = boost::shared_ptr<DividendEntitlementEnum>(new DividendEntitlementEnum(dividendEntitlementNode));
             dividendEntitlement_->setID(dividendEntitlementIDRef_);
             IDManager::instance().setID(dividendEntitlementIDRef_,dividendEntitlement_);
          }
          else if(dividendEntitlementNode->Attribute("href")) { dividendEntitlementIDRef_ = dividendEntitlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendEntitlement_ = boost::shared_ptr<DividendEntitlementEnum>(new DividendEntitlementEnum(dividendEntitlementNode));}
   }

   //dividendAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendAmountNode = xmlNode->FirstChildElement("dividendAmount");

   if(dividendAmountNode){dividendAmountIsNull_ = false;}
   else{dividendAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendAmountNode , address : " << dividendAmountNode << std::endl;
   #endif
   if(dividendAmountNode)
   {
      if(dividendAmountNode->Attribute("href") || dividendAmountNode->Attribute("id"))
      {
          if(dividendAmountNode->Attribute("id"))
          {
             dividendAmountIDRef_ = dividendAmountNode->Attribute("id");
             dividendAmount_ = boost::shared_ptr<DividendAmountTypeEnum>(new DividendAmountTypeEnum(dividendAmountNode));
             dividendAmount_->setID(dividendAmountIDRef_);
             IDManager::instance().setID(dividendAmountIDRef_,dividendAmount_);
          }
          else if(dividendAmountNode->Attribute("href")) { dividendAmountIDRef_ = dividendAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendAmount_ = boost::shared_ptr<DividendAmountTypeEnum>(new DividendAmountTypeEnum(dividendAmountNode));}
   }

   //dividendPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPaymentDateNode = xmlNode->FirstChildElement("dividendPaymentDate");

   if(dividendPaymentDateNode){dividendPaymentDateIsNull_ = false;}
   else{dividendPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPaymentDateNode , address : " << dividendPaymentDateNode << std::endl;
   #endif
   if(dividendPaymentDateNode)
   {
      if(dividendPaymentDateNode->Attribute("href") || dividendPaymentDateNode->Attribute("id"))
      {
          if(dividendPaymentDateNode->Attribute("id"))
          {
             dividendPaymentDateIDRef_ = dividendPaymentDateNode->Attribute("id");
             dividendPaymentDate_ = boost::shared_ptr<DividendPaymentDate>(new DividendPaymentDate(dividendPaymentDateNode));
             dividendPaymentDate_->setID(dividendPaymentDateIDRef_);
             IDManager::instance().setID(dividendPaymentDateIDRef_,dividendPaymentDate_);
          }
          else if(dividendPaymentDateNode->Attribute("href")) { dividendPaymentDateIDRef_ = dividendPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendPaymentDate_ = boost::shared_ptr<DividendPaymentDate>(new DividendPaymentDate(dividendPaymentDateNode));}
   }

   //dividendPeriodEffectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPeriodEffectiveDateNode = xmlNode->FirstChildElement("dividendPeriodEffectiveDate");

   if(dividendPeriodEffectiveDateNode){dividendPeriodEffectiveDateIsNull_ = false;}
   else{dividendPeriodEffectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPeriodEffectiveDateNode , address : " << dividendPeriodEffectiveDateNode << std::endl;
   #endif
   if(dividendPeriodEffectiveDateNode)
   {
      if(dividendPeriodEffectiveDateNode->Attribute("href") || dividendPeriodEffectiveDateNode->Attribute("id"))
      {
          if(dividendPeriodEffectiveDateNode->Attribute("id"))
          {
             dividendPeriodEffectiveDateIDRef_ = dividendPeriodEffectiveDateNode->Attribute("id");
             dividendPeriodEffectiveDate_ = boost::shared_ptr<DateReference>(new DateReference(dividendPeriodEffectiveDateNode));
             dividendPeriodEffectiveDate_->setID(dividendPeriodEffectiveDateIDRef_);
             IDManager::instance().setID(dividendPeriodEffectiveDateIDRef_,dividendPeriodEffectiveDate_);
          }
          else if(dividendPeriodEffectiveDateNode->Attribute("href")) { dividendPeriodEffectiveDateIDRef_ = dividendPeriodEffectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendPeriodEffectiveDate_ = boost::shared_ptr<DateReference>(new DateReference(dividendPeriodEffectiveDateNode));}
   }

   //dividendPeriodEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPeriodEndDateNode = xmlNode->FirstChildElement("dividendPeriodEndDate");

   if(dividendPeriodEndDateNode){dividendPeriodEndDateIsNull_ = false;}
   else{dividendPeriodEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPeriodEndDateNode , address : " << dividendPeriodEndDateNode << std::endl;
   #endif
   if(dividendPeriodEndDateNode)
   {
      if(dividendPeriodEndDateNode->Attribute("href") || dividendPeriodEndDateNode->Attribute("id"))
      {
          if(dividendPeriodEndDateNode->Attribute("id"))
          {
             dividendPeriodEndDateIDRef_ = dividendPeriodEndDateNode->Attribute("id");
             dividendPeriodEndDate_ = boost::shared_ptr<DateReference>(new DateReference(dividendPeriodEndDateNode));
             dividendPeriodEndDate_->setID(dividendPeriodEndDateIDRef_);
             IDManager::instance().setID(dividendPeriodEndDateIDRef_,dividendPeriodEndDate_);
          }
          else if(dividendPeriodEndDateNode->Attribute("href")) { dividendPeriodEndDateIDRef_ = dividendPeriodEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendPeriodEndDate_ = boost::shared_ptr<DateReference>(new DateReference(dividendPeriodEndDateNode));}
   }

   //dividendPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPeriodNode = xmlNode->FirstChildElement("dividendPeriod");

   if(dividendPeriodNode){dividendPeriodIsNull_ = false;}
   else{dividendPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPeriodNode , address : " << dividendPeriodNode << std::endl;
   #endif
   if(dividendPeriodNode)
   {
      if(dividendPeriodNode->Attribute("href") || dividendPeriodNode->Attribute("id"))
      {
          if(dividendPeriodNode->Attribute("id"))
          {
             dividendPeriodIDRef_ = dividendPeriodNode->Attribute("id");
             dividendPeriod_ = boost::shared_ptr<DividendPeriodEnum>(new DividendPeriodEnum(dividendPeriodNode));
             dividendPeriod_->setID(dividendPeriodIDRef_);
             IDManager::instance().setID(dividendPeriodIDRef_,dividendPeriod_);
          }
          else if(dividendPeriodNode->Attribute("href")) { dividendPeriodIDRef_ = dividendPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendPeriod_ = boost::shared_ptr<DividendPeriodEnum>(new DividendPeriodEnum(dividendPeriodNode));}
   }

   //extraOrdinaryDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extraOrdinaryDividendsNode = xmlNode->FirstChildElement("extraOrdinaryDividends");

   if(extraOrdinaryDividendsNode){extraOrdinaryDividendsIsNull_ = false;}
   else{extraOrdinaryDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extraOrdinaryDividendsNode , address : " << extraOrdinaryDividendsNode << std::endl;
   #endif
   if(extraOrdinaryDividendsNode)
   {
      if(extraOrdinaryDividendsNode->Attribute("href") || extraOrdinaryDividendsNode->Attribute("id"))
      {
          if(extraOrdinaryDividendsNode->Attribute("id"))
          {
             extraOrdinaryDividendsIDRef_ = extraOrdinaryDividendsNode->Attribute("id");
             extraOrdinaryDividends_ = boost::shared_ptr<PartyReference>(new PartyReference(extraOrdinaryDividendsNode));
             extraOrdinaryDividends_->setID(extraOrdinaryDividendsIDRef_);
             IDManager::instance().setID(extraOrdinaryDividendsIDRef_,extraOrdinaryDividends_);
          }
          else if(extraOrdinaryDividendsNode->Attribute("href")) { extraOrdinaryDividendsIDRef_ = extraOrdinaryDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { extraOrdinaryDividends_ = boost::shared_ptr<PartyReference>(new PartyReference(extraOrdinaryDividendsNode));}
   }

   //excessDividendAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excessDividendAmountNode = xmlNode->FirstChildElement("excessDividendAmount");

   if(excessDividendAmountNode){excessDividendAmountIsNull_ = false;}
   else{excessDividendAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excessDividendAmountNode , address : " << excessDividendAmountNode << std::endl;
   #endif
   if(excessDividendAmountNode)
   {
      if(excessDividendAmountNode->Attribute("href") || excessDividendAmountNode->Attribute("id"))
      {
          if(excessDividendAmountNode->Attribute("id"))
          {
             excessDividendAmountIDRef_ = excessDividendAmountNode->Attribute("id");
             excessDividendAmount_ = boost::shared_ptr<DividendAmountTypeEnum>(new DividendAmountTypeEnum(excessDividendAmountNode));
             excessDividendAmount_->setID(excessDividendAmountIDRef_);
             IDManager::instance().setID(excessDividendAmountIDRef_,excessDividendAmount_);
          }
          else if(excessDividendAmountNode->Attribute("href")) { excessDividendAmountIDRef_ = excessDividendAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { excessDividendAmount_ = boost::shared_ptr<DividendAmountTypeEnum>(new DividendAmountTypeEnum(excessDividendAmountNode));}
   }

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
      if(currencyNode->Attribute("href") || currencyNode->Attribute("id"))
      {
          if(currencyNode->Attribute("id"))
          {
             currencyIDRef_ = currencyNode->Attribute("id");
             currency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(currencyNode));}
   }

   //determinationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* determinationMethodNode = xmlNode->FirstChildElement("determinationMethod");

   if(determinationMethodNode){determinationMethodIsNull_ = false;}
   else{determinationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determinationMethodNode , address : " << determinationMethodNode << std::endl;
   #endif
   if(determinationMethodNode)
   {
      if(determinationMethodNode->Attribute("href") || determinationMethodNode->Attribute("id"))
      {
          if(determinationMethodNode->Attribute("id"))
          {
             determinationMethodIDRef_ = determinationMethodNode->Attribute("id");
             determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));
             determinationMethod_->setID(determinationMethodIDRef_);
             IDManager::instance().setID(determinationMethodIDRef_,determinationMethod_);
          }
          else if(determinationMethodNode->Attribute("href")) { determinationMethodIDRef_ = determinationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));}
   }

   //currencyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyReferenceNode = xmlNode->FirstChildElement("currencyReference");

   if(currencyReferenceNode){currencyReferenceIsNull_ = false;}
   else{currencyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyReferenceNode , address : " << currencyReferenceNode << std::endl;
   #endif
   if(currencyReferenceNode)
   {
      if(currencyReferenceNode->Attribute("href") || currencyReferenceNode->Attribute("id"))
      {
          if(currencyReferenceNode->Attribute("id"))
          {
             currencyReferenceIDRef_ = currencyReferenceNode->Attribute("id");
             currencyReference_ = boost::shared_ptr<IdentifiedCurrencyReference>(new IdentifiedCurrencyReference(currencyReferenceNode));
             currencyReference_->setID(currencyReferenceIDRef_);
             IDManager::instance().setID(currencyReferenceIDRef_,currencyReference_);
          }
          else if(currencyReferenceNode->Attribute("href")) { currencyReferenceIDRef_ = currencyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currencyReference_ = boost::shared_ptr<IdentifiedCurrencyReference>(new IdentifiedCurrencyReference(currencyReferenceNode));}
   }

   //dividendFxTriggerDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendFxTriggerDateNode = xmlNode->FirstChildElement("dividendFxTriggerDate");

   if(dividendFxTriggerDateNode){dividendFxTriggerDateIsNull_ = false;}
   else{dividendFxTriggerDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendFxTriggerDateNode , address : " << dividendFxTriggerDateNode << std::endl;
   #endif
   if(dividendFxTriggerDateNode)
   {
      if(dividendFxTriggerDateNode->Attribute("href") || dividendFxTriggerDateNode->Attribute("id"))
      {
          if(dividendFxTriggerDateNode->Attribute("id"))
          {
             dividendFxTriggerDateIDRef_ = dividendFxTriggerDateNode->Attribute("id");
             dividendFxTriggerDate_ = boost::shared_ptr<DividendPaymentDate>(new DividendPaymentDate(dividendFxTriggerDateNode));
             dividendFxTriggerDate_->setID(dividendFxTriggerDateIDRef_);
             IDManager::instance().setID(dividendFxTriggerDateIDRef_,dividendFxTriggerDate_);
          }
          else if(dividendFxTriggerDateNode->Attribute("href")) { dividendFxTriggerDateIDRef_ = dividendFxTriggerDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendFxTriggerDate_ = boost::shared_ptr<DividendPaymentDate>(new DividendPaymentDate(dividendFxTriggerDateNode));}
   }

   //interestAccrualsMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestAccrualsMethodNode = xmlNode->FirstChildElement("interestAccrualsMethod");

   if(interestAccrualsMethodNode){interestAccrualsMethodIsNull_ = false;}
   else{interestAccrualsMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestAccrualsMethodNode , address : " << interestAccrualsMethodNode << std::endl;
   #endif
   if(interestAccrualsMethodNode)
   {
      if(interestAccrualsMethodNode->Attribute("href") || interestAccrualsMethodNode->Attribute("id"))
      {
          if(interestAccrualsMethodNode->Attribute("id"))
          {
             interestAccrualsMethodIDRef_ = interestAccrualsMethodNode->Attribute("id");
             interestAccrualsMethod_ = boost::shared_ptr<InterestAccrualsCompoundingMethod>(new InterestAccrualsCompoundingMethod(interestAccrualsMethodNode));
             interestAccrualsMethod_->setID(interestAccrualsMethodIDRef_);
             IDManager::instance().setID(interestAccrualsMethodIDRef_,interestAccrualsMethod_);
          }
          else if(interestAccrualsMethodNode->Attribute("href")) { interestAccrualsMethodIDRef_ = interestAccrualsMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestAccrualsMethod_ = boost::shared_ptr<InterestAccrualsCompoundingMethod>(new InterestAccrualsCompoundingMethod(interestAccrualsMethodNode));}
   }

   //numberOfIndexUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberOfIndexUnitsNode = xmlNode->FirstChildElement("numberOfIndexUnits");

   if(numberOfIndexUnitsNode){numberOfIndexUnitsIsNull_ = false;}
   else{numberOfIndexUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberOfIndexUnitsNode , address : " << numberOfIndexUnitsNode << std::endl;
   #endif
   if(numberOfIndexUnitsNode)
   {
      if(numberOfIndexUnitsNode->Attribute("href") || numberOfIndexUnitsNode->Attribute("id"))
      {
          if(numberOfIndexUnitsNode->Attribute("id"))
          {
             numberOfIndexUnitsIDRef_ = numberOfIndexUnitsNode->Attribute("id");
             numberOfIndexUnits_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(numberOfIndexUnitsNode));
             numberOfIndexUnits_->setID(numberOfIndexUnitsIDRef_);
             IDManager::instance().setID(numberOfIndexUnitsIDRef_,numberOfIndexUnits_);
          }
          else if(numberOfIndexUnitsNode->Attribute("href")) { numberOfIndexUnitsIDRef_ = numberOfIndexUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numberOfIndexUnits_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(numberOfIndexUnitsNode));}
   }

   //declaredCashDividendPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* declaredCashDividendPercentageNode = xmlNode->FirstChildElement("declaredCashDividendPercentage");

   if(declaredCashDividendPercentageNode){declaredCashDividendPercentageIsNull_ = false;}
   else{declaredCashDividendPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- declaredCashDividendPercentageNode , address : " << declaredCashDividendPercentageNode << std::endl;
   #endif
   if(declaredCashDividendPercentageNode)
   {
      if(declaredCashDividendPercentageNode->Attribute("href") || declaredCashDividendPercentageNode->Attribute("id"))
      {
          if(declaredCashDividendPercentageNode->Attribute("id"))
          {
             declaredCashDividendPercentageIDRef_ = declaredCashDividendPercentageNode->Attribute("id");
             declaredCashDividendPercentage_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(declaredCashDividendPercentageNode));
             declaredCashDividendPercentage_->setID(declaredCashDividendPercentageIDRef_);
             IDManager::instance().setID(declaredCashDividendPercentageIDRef_,declaredCashDividendPercentage_);
          }
          else if(declaredCashDividendPercentageNode->Attribute("href")) { declaredCashDividendPercentageIDRef_ = declaredCashDividendPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { declaredCashDividendPercentage_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(declaredCashDividendPercentageNode));}
   }

   //declaredCashEquivalentDividendPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* declaredCashEquivalentDividendPercentageNode = xmlNode->FirstChildElement("declaredCashEquivalentDividendPercentage");

   if(declaredCashEquivalentDividendPercentageNode){declaredCashEquivalentDividendPercentageIsNull_ = false;}
   else{declaredCashEquivalentDividendPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- declaredCashEquivalentDividendPercentageNode , address : " << declaredCashEquivalentDividendPercentageNode << std::endl;
   #endif
   if(declaredCashEquivalentDividendPercentageNode)
   {
      if(declaredCashEquivalentDividendPercentageNode->Attribute("href") || declaredCashEquivalentDividendPercentageNode->Attribute("id"))
      {
          if(declaredCashEquivalentDividendPercentageNode->Attribute("id"))
          {
             declaredCashEquivalentDividendPercentageIDRef_ = declaredCashEquivalentDividendPercentageNode->Attribute("id");
             declaredCashEquivalentDividendPercentage_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode));
             declaredCashEquivalentDividendPercentage_->setID(declaredCashEquivalentDividendPercentageIDRef_);
             IDManager::instance().setID(declaredCashEquivalentDividendPercentageIDRef_,declaredCashEquivalentDividendPercentage_);
          }
          else if(declaredCashEquivalentDividendPercentageNode->Attribute("href")) { declaredCashEquivalentDividendPercentageIDRef_ = declaredCashEquivalentDividendPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { declaredCashEquivalentDividendPercentage_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode));}
   }

   //nonCashDividendTreatmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonCashDividendTreatmentNode = xmlNode->FirstChildElement("nonCashDividendTreatment");

   if(nonCashDividendTreatmentNode){nonCashDividendTreatmentIsNull_ = false;}
   else{nonCashDividendTreatmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonCashDividendTreatmentNode , address : " << nonCashDividendTreatmentNode << std::endl;
   #endif
   if(nonCashDividendTreatmentNode)
   {
      if(nonCashDividendTreatmentNode->Attribute("href") || nonCashDividendTreatmentNode->Attribute("id"))
      {
          if(nonCashDividendTreatmentNode->Attribute("id"))
          {
             nonCashDividendTreatmentIDRef_ = nonCashDividendTreatmentNode->Attribute("id");
             nonCashDividendTreatment_ = boost::shared_ptr<NonCashDividendTreatmentEnum>(new NonCashDividendTreatmentEnum(nonCashDividendTreatmentNode));
             nonCashDividendTreatment_->setID(nonCashDividendTreatmentIDRef_);
             IDManager::instance().setID(nonCashDividendTreatmentIDRef_,nonCashDividendTreatment_);
          }
          else if(nonCashDividendTreatmentNode->Attribute("href")) { nonCashDividendTreatmentIDRef_ = nonCashDividendTreatmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonCashDividendTreatment_ = boost::shared_ptr<NonCashDividendTreatmentEnum>(new NonCashDividendTreatmentEnum(nonCashDividendTreatmentNode));}
   }

   //dividendCompositionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendCompositionNode = xmlNode->FirstChildElement("dividendComposition");

   if(dividendCompositionNode){dividendCompositionIsNull_ = false;}
   else{dividendCompositionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendCompositionNode , address : " << dividendCompositionNode << std::endl;
   #endif
   if(dividendCompositionNode)
   {
      if(dividendCompositionNode->Attribute("href") || dividendCompositionNode->Attribute("id"))
      {
          if(dividendCompositionNode->Attribute("id"))
          {
             dividendCompositionIDRef_ = dividendCompositionNode->Attribute("id");
             dividendComposition_ = boost::shared_ptr<DividendCompositionEnum>(new DividendCompositionEnum(dividendCompositionNode));
             dividendComposition_->setID(dividendCompositionIDRef_);
             IDManager::instance().setID(dividendCompositionIDRef_,dividendComposition_);
          }
          else if(dividendCompositionNode->Attribute("href")) { dividendCompositionIDRef_ = dividendCompositionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendComposition_ = boost::shared_ptr<DividendCompositionEnum>(new DividendCompositionEnum(dividendCompositionNode));}
   }

   //specialDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specialDividendsNode = xmlNode->FirstChildElement("specialDividends");

   if(specialDividendsNode){specialDividendsIsNull_ = false;}
   else{specialDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specialDividendsNode , address : " << specialDividendsNode << std::endl;
   #endif
   if(specialDividendsNode)
   {
      if(specialDividendsNode->Attribute("href") || specialDividendsNode->Attribute("id"))
      {
          if(specialDividendsNode->Attribute("id"))
          {
             specialDividendsIDRef_ = specialDividendsNode->Attribute("id");
             specialDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(specialDividendsNode));
             specialDividends_->setID(specialDividendsIDRef_);
             IDManager::instance().setID(specialDividendsIDRef_,specialDividends_);
          }
          else if(specialDividendsNode->Attribute("href")) { specialDividendsIDRef_ = specialDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { specialDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(specialDividendsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> DividendConditions::getDividendReinvestment()
{
   if(!this->dividendReinvestmentIsNull_){
        if(dividendReinvestmentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(dividendReinvestmentIDRef_));
        }else{
             return this->dividendReinvestment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<DividendEntitlementEnum> DividendConditions::getDividendEntitlement()
{
   if(!this->dividendEntitlementIsNull_){
        if(dividendEntitlementIDRef_ != ""){
             return boost::shared_static_cast<DividendEntitlementEnum>(IDManager::instance().getID(dividendEntitlementIDRef_));
        }else{
             return this->dividendEntitlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendEntitlementEnum>();
   }
}
boost::shared_ptr<DividendAmountTypeEnum> DividendConditions::getDividendAmount()
{
   if(!this->dividendAmountIsNull_){
        if(dividendAmountIDRef_ != ""){
             return boost::shared_static_cast<DividendAmountTypeEnum>(IDManager::instance().getID(dividendAmountIDRef_));
        }else{
             return this->dividendAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendAmountTypeEnum>();
   }
}
boost::shared_ptr<DividendPaymentDate> DividendConditions::getDividendPaymentDate()
{
   if(!this->dividendPaymentDateIsNull_){
        if(dividendPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<DividendPaymentDate>(IDManager::instance().getID(dividendPaymentDateIDRef_));
        }else{
             return this->dividendPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendPaymentDate>();
   }
}
boost::shared_ptr<DateReference> DividendConditions::getDividendPeriodEffectiveDate()
{
   if(!this->dividendPeriodEffectiveDateIsNull_){
        if(dividendPeriodEffectiveDateIDRef_ != ""){
             return boost::shared_static_cast<DateReference>(IDManager::instance().getID(dividendPeriodEffectiveDateIDRef_));
        }else{
             return this->dividendPeriodEffectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateReference>();
   }
}
boost::shared_ptr<DateReference> DividendConditions::getDividendPeriodEndDate()
{
   if(!this->dividendPeriodEndDateIsNull_){
        if(dividendPeriodEndDateIDRef_ != ""){
             return boost::shared_static_cast<DateReference>(IDManager::instance().getID(dividendPeriodEndDateIDRef_));
        }else{
             return this->dividendPeriodEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateReference>();
   }
}
boost::shared_ptr<DividendPeriodEnum> DividendConditions::getDividendPeriod()
{
   if(!this->dividendPeriodIsNull_){
        if(dividendPeriodIDRef_ != ""){
             return boost::shared_static_cast<DividendPeriodEnum>(IDManager::instance().getID(dividendPeriodIDRef_));
        }else{
             return this->dividendPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendPeriodEnum>();
   }
}
boost::shared_ptr<PartyReference> DividendConditions::getExtraOrdinaryDividends()
{
   if(!this->extraOrdinaryDividendsIsNull_){
        if(extraOrdinaryDividendsIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(extraOrdinaryDividendsIDRef_));
        }else{
             return this->extraOrdinaryDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<DividendAmountTypeEnum> DividendConditions::getExcessDividendAmount()
{
   if(!this->excessDividendAmountIsNull_){
        if(excessDividendAmountIDRef_ != ""){
             return boost::shared_static_cast<DividendAmountTypeEnum>(IDManager::instance().getID(excessDividendAmountIDRef_));
        }else{
             return this->excessDividendAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendAmountTypeEnum>();
   }
}
boost::shared_ptr<IdentifiedCurrency> DividendConditions::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedCurrency>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedCurrency>();
   }
}
boost::shared_ptr<DeterminationMethod> DividendConditions::getDeterminationMethod()
{
   if(!this->determinationMethodIsNull_){
        if(determinationMethodIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethod>(IDManager::instance().getID(determinationMethodIDRef_));
        }else{
             return this->determinationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethod>();
   }
}
boost::shared_ptr<IdentifiedCurrencyReference> DividendConditions::getCurrencyReference()
{
   if(!this->currencyReferenceIsNull_){
        if(currencyReferenceIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedCurrencyReference>(IDManager::instance().getID(currencyReferenceIDRef_));
        }else{
             return this->currencyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedCurrencyReference>();
   }
}
boost::shared_ptr<DividendPaymentDate> DividendConditions::getDividendFxTriggerDate()
{
   if(!this->dividendFxTriggerDateIsNull_){
        if(dividendFxTriggerDateIDRef_ != ""){
             return boost::shared_static_cast<DividendPaymentDate>(IDManager::instance().getID(dividendFxTriggerDateIDRef_));
        }else{
             return this->dividendFxTriggerDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendPaymentDate>();
   }
}
boost::shared_ptr<InterestAccrualsCompoundingMethod> DividendConditions::getInterestAccrualsMethod()
{
   if(!this->interestAccrualsMethodIsNull_){
        if(interestAccrualsMethodIDRef_ != ""){
             return boost::shared_static_cast<InterestAccrualsCompoundingMethod>(IDManager::instance().getID(interestAccrualsMethodIDRef_));
        }else{
             return this->interestAccrualsMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestAccrualsCompoundingMethod>();
   }
}
boost::shared_ptr<NonNegativeDecimal> DividendConditions::getNumberOfIndexUnits()
{
   if(!this->numberOfIndexUnitsIsNull_){
        if(numberOfIndexUnitsIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(numberOfIndexUnitsIDRef_));
        }else{
             return this->numberOfIndexUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> DividendConditions::getDeclaredCashDividendPercentage()
{
   if(!this->declaredCashDividendPercentageIsNull_){
        if(declaredCashDividendPercentageIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(declaredCashDividendPercentageIDRef_));
        }else{
             return this->declaredCashDividendPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> DividendConditions::getDeclaredCashEquivalentDividendPercentage()
{
   if(!this->declaredCashEquivalentDividendPercentageIsNull_){
        if(declaredCashEquivalentDividendPercentageIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(declaredCashEquivalentDividendPercentageIDRef_));
        }else{
             return this->declaredCashEquivalentDividendPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<NonCashDividendTreatmentEnum> DividendConditions::getNonCashDividendTreatment()
{
   if(!this->nonCashDividendTreatmentIsNull_){
        if(nonCashDividendTreatmentIDRef_ != ""){
             return boost::shared_static_cast<NonCashDividendTreatmentEnum>(IDManager::instance().getID(nonCashDividendTreatmentIDRef_));
        }else{
             return this->nonCashDividendTreatment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonCashDividendTreatmentEnum>();
   }
}
boost::shared_ptr<DividendCompositionEnum> DividendConditions::getDividendComposition()
{
   if(!this->dividendCompositionIsNull_){
        if(dividendCompositionIDRef_ != ""){
             return boost::shared_static_cast<DividendCompositionEnum>(IDManager::instance().getID(dividendCompositionIDRef_));
        }else{
             return this->dividendComposition_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendCompositionEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DividendConditions::getSpecialDividends()
{
   if(!this->specialDividendsIsNull_){
        if(specialDividendsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(specialDividendsIDRef_));
        }else{
             return this->specialDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

