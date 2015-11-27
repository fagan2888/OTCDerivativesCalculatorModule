// CashPriceMethod.cpp 
#include "CashPriceMethod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CashPriceMethod::CashPriceMethod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //cashSettlementReferenceBanksNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementReferenceBanksNode = xmlNode->FirstChildElement("cashSettlementReferenceBanks");

   if(cashSettlementReferenceBanksNode){cashSettlementReferenceBanksIsNull_ = false;}
   else{cashSettlementReferenceBanksIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementReferenceBanksNode , address : " << cashSettlementReferenceBanksNode << std::endl;
   #endif
   if(cashSettlementReferenceBanksNode)
   {
      if(cashSettlementReferenceBanksNode->Attribute("href") || cashSettlementReferenceBanksNode->Attribute("id"))
      {
          if(cashSettlementReferenceBanksNode->Attribute("id"))
          {
             cashSettlementReferenceBanksIDRef_ = cashSettlementReferenceBanksNode->Attribute("id");
             cashSettlementReferenceBanks_ = boost::shared_ptr<CashSettlementReferenceBanks>(new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode));
             cashSettlementReferenceBanks_->setID(cashSettlementReferenceBanksIDRef_);
             IDManager::instance().setID(cashSettlementReferenceBanksIDRef_,cashSettlementReferenceBanks_);
          }
          else if(cashSettlementReferenceBanksNode->Attribute("href")) { cashSettlementReferenceBanksIDRef_ = cashSettlementReferenceBanksNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementReferenceBanks_ = boost::shared_ptr<CashSettlementReferenceBanks>(new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode));}
   }

   //cashSettlementCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementCurrencyNode = xmlNode->FirstChildElement("cashSettlementCurrency");

   if(cashSettlementCurrencyNode){cashSettlementCurrencyIsNull_ = false;}
   else{cashSettlementCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementCurrencyNode , address : " << cashSettlementCurrencyNode << std::endl;
   #endif
   if(cashSettlementCurrencyNode)
   {
      if(cashSettlementCurrencyNode->Attribute("href") || cashSettlementCurrencyNode->Attribute("id"))
      {
          if(cashSettlementCurrencyNode->Attribute("id"))
          {
             cashSettlementCurrencyIDRef_ = cashSettlementCurrencyNode->Attribute("id");
             cashSettlementCurrency_ = boost::shared_ptr<Currency>(new Currency(cashSettlementCurrencyNode));
             cashSettlementCurrency_->setID(cashSettlementCurrencyIDRef_);
             IDManager::instance().setID(cashSettlementCurrencyIDRef_,cashSettlementCurrency_);
          }
          else if(cashSettlementCurrencyNode->Attribute("href")) { cashSettlementCurrencyIDRef_ = cashSettlementCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementCurrency_ = boost::shared_ptr<Currency>(new Currency(cashSettlementCurrencyNode));}
   }

   //quotationRateTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotationRateTypeNode = xmlNode->FirstChildElement("quotationRateType");

   if(quotationRateTypeNode){quotationRateTypeIsNull_ = false;}
   else{quotationRateTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotationRateTypeNode , address : " << quotationRateTypeNode << std::endl;
   #endif
   if(quotationRateTypeNode)
   {
      if(quotationRateTypeNode->Attribute("href") || quotationRateTypeNode->Attribute("id"))
      {
          if(quotationRateTypeNode->Attribute("id"))
          {
             quotationRateTypeIDRef_ = quotationRateTypeNode->Attribute("id");
             quotationRateType_ = boost::shared_ptr<QuotationRateTypeEnum>(new QuotationRateTypeEnum(quotationRateTypeNode));
             quotationRateType_->setID(quotationRateTypeIDRef_);
             IDManager::instance().setID(quotationRateTypeIDRef_,quotationRateType_);
          }
          else if(quotationRateTypeNode->Attribute("href")) { quotationRateTypeIDRef_ = quotationRateTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotationRateType_ = boost::shared_ptr<QuotationRateTypeEnum>(new QuotationRateTypeEnum(quotationRateTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CashSettlementReferenceBanks> CashPriceMethod::getCashSettlementReferenceBanks()
{
   if(!this->cashSettlementReferenceBanksIsNull_){
        if(cashSettlementReferenceBanksIDRef_ != ""){
             return boost::shared_static_cast<CashSettlementReferenceBanks>(IDManager::instance().getID(cashSettlementReferenceBanksIDRef_));
        }else{
             return this->cashSettlementReferenceBanks_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashSettlementReferenceBanks>();
   }
}
boost::shared_ptr<Currency> CashPriceMethod::getCashSettlementCurrency()
{
   if(!this->cashSettlementCurrencyIsNull_){
        if(cashSettlementCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(cashSettlementCurrencyIDRef_));
        }else{
             return this->cashSettlementCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<QuotationRateTypeEnum> CashPriceMethod::getQuotationRateType()
{
   if(!this->quotationRateTypeIsNull_){
        if(quotationRateTypeIDRef_ != ""){
             return boost::shared_static_cast<QuotationRateTypeEnum>(IDManager::instance().getID(quotationRateTypeIDRef_));
        }else{
             return this->quotationRateType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationRateTypeEnum>();
   }
}
}

