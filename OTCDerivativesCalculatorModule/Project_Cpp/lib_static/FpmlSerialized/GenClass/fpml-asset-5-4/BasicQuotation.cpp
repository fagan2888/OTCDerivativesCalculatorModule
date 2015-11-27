// BasicQuotation.cpp 
#include "BasicQuotation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BasicQuotation::BasicQuotation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
   #endif
   if(valueNode)
   {
      if(valueNode->Attribute("href") || valueNode->Attribute("id"))
      {
          if(valueNode->Attribute("id"))
          {
             valueIDRef_ = valueNode->Attribute("id");
             value_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(valueNode));
             value_->setID(valueIDRef_);
             IDManager::instance().setID(valueIDRef_,value_);
          }
          else if(valueNode->Attribute("href")) { valueIDRef_ = valueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { value_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(valueNode));}
   }

   //measureTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* measureTypeNode = xmlNode->FirstChildElement("measureType");

   if(measureTypeNode){measureTypeIsNull_ = false;}
   else{measureTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- measureTypeNode , address : " << measureTypeNode << std::endl;
   #endif
   if(measureTypeNode)
   {
      if(measureTypeNode->Attribute("href") || measureTypeNode->Attribute("id"))
      {
          if(measureTypeNode->Attribute("id"))
          {
             measureTypeIDRef_ = measureTypeNode->Attribute("id");
             measureType_ = boost::shared_ptr<AssetMeasureType>(new AssetMeasureType(measureTypeNode));
             measureType_->setID(measureTypeIDRef_);
             IDManager::instance().setID(measureTypeIDRef_,measureType_);
          }
          else if(measureTypeNode->Attribute("href")) { measureTypeIDRef_ = measureTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { measureType_ = boost::shared_ptr<AssetMeasureType>(new AssetMeasureType(measureTypeNode));}
   }

   //quoteUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quoteUnitsNode = xmlNode->FirstChildElement("quoteUnits");

   if(quoteUnitsNode){quoteUnitsIsNull_ = false;}
   else{quoteUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteUnitsNode , address : " << quoteUnitsNode << std::endl;
   #endif
   if(quoteUnitsNode)
   {
      if(quoteUnitsNode->Attribute("href") || quoteUnitsNode->Attribute("id"))
      {
          if(quoteUnitsNode->Attribute("id"))
          {
             quoteUnitsIDRef_ = quoteUnitsNode->Attribute("id");
             quoteUnits_ = boost::shared_ptr<PriceQuoteUnits>(new PriceQuoteUnits(quoteUnitsNode));
             quoteUnits_->setID(quoteUnitsIDRef_);
             IDManager::instance().setID(quoteUnitsIDRef_,quoteUnits_);
          }
          else if(quoteUnitsNode->Attribute("href")) { quoteUnitsIDRef_ = quoteUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quoteUnits_ = boost::shared_ptr<PriceQuoteUnits>(new PriceQuoteUnits(quoteUnitsNode));}
   }

   //sideNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sideNode = xmlNode->FirstChildElement("side");

   if(sideNode){sideIsNull_ = false;}
   else{sideIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sideNode , address : " << sideNode << std::endl;
   #endif
   if(sideNode)
   {
      if(sideNode->Attribute("href") || sideNode->Attribute("id"))
      {
          if(sideNode->Attribute("id"))
          {
             sideIDRef_ = sideNode->Attribute("id");
             side_ = boost::shared_ptr<QuotationSideEnum>(new QuotationSideEnum(sideNode));
             side_->setID(sideIDRef_);
             IDManager::instance().setID(sideIDRef_,side_);
          }
          else if(sideNode->Attribute("href")) { sideIDRef_ = sideNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { side_ = boost::shared_ptr<QuotationSideEnum>(new QuotationSideEnum(sideNode));}
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
             currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));}
   }

   //currencyTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyTypeNode = xmlNode->FirstChildElement("currencyType");

   if(currencyTypeNode){currencyTypeIsNull_ = false;}
   else{currencyTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyTypeNode , address : " << currencyTypeNode << std::endl;
   #endif
   if(currencyTypeNode)
   {
      if(currencyTypeNode->Attribute("href") || currencyTypeNode->Attribute("id"))
      {
          if(currencyTypeNode->Attribute("id"))
          {
             currencyTypeIDRef_ = currencyTypeNode->Attribute("id");
             currencyType_ = boost::shared_ptr<ReportingCurrencyType>(new ReportingCurrencyType(currencyTypeNode));
             currencyType_->setID(currencyTypeIDRef_);
             IDManager::instance().setID(currencyTypeIDRef_,currencyType_);
          }
          else if(currencyTypeNode->Attribute("href")) { currencyTypeIDRef_ = currencyTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currencyType_ = boost::shared_ptr<ReportingCurrencyType>(new ReportingCurrencyType(currencyTypeNode));}
   }

   //timingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timingNode = xmlNode->FirstChildElement("timing");

   if(timingNode){timingIsNull_ = false;}
   else{timingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timingNode , address : " << timingNode << std::endl;
   #endif
   if(timingNode)
   {
      if(timingNode->Attribute("href") || timingNode->Attribute("id"))
      {
          if(timingNode->Attribute("id"))
          {
             timingIDRef_ = timingNode->Attribute("id");
             timing_ = boost::shared_ptr<QuoteTiming>(new QuoteTiming(timingNode));
             timing_->setID(timingIDRef_);
             IDManager::instance().setID(timingIDRef_,timing_);
          }
          else if(timingNode->Attribute("href")) { timingIDRef_ = timingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { timing_ = boost::shared_ptr<QuoteTiming>(new QuoteTiming(timingNode));}
   }

   //businessCenterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCenterNode = xmlNode->FirstChildElement("businessCenter");

   if(businessCenterNode){businessCenterIsNull_ = false;}
   else{businessCenterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCenterNode , address : " << businessCenterNode << std::endl;
   #endif
   if(businessCenterNode)
   {
      if(businessCenterNode->Attribute("href") || businessCenterNode->Attribute("id"))
      {
          if(businessCenterNode->Attribute("id"))
          {
             businessCenterIDRef_ = businessCenterNode->Attribute("id");
             businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));
             businessCenter_->setID(businessCenterIDRef_);
             IDManager::instance().setID(businessCenterIDRef_,businessCenter_);
          }
          else if(businessCenterNode->Attribute("href")) { businessCenterIDRef_ = businessCenterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));}
   }

   //exchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeIdNode = xmlNode->FirstChildElement("exchangeId");

   if(exchangeIdNode){exchangeIdIsNull_ = false;}
   else{exchangeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeIdNode , address : " << exchangeIdNode << std::endl;
   #endif
   if(exchangeIdNode)
   {
      if(exchangeIdNode->Attribute("href") || exchangeIdNode->Attribute("id"))
      {
          if(exchangeIdNode->Attribute("id"))
          {
             exchangeIdIDRef_ = exchangeIdNode->Attribute("id");
             exchangeId_ = boost::shared_ptr<ExchangeId>(new ExchangeId(exchangeIdNode));
             exchangeId_->setID(exchangeIdIDRef_);
             IDManager::instance().setID(exchangeIdIDRef_,exchangeId_);
          }
          else if(exchangeIdNode->Attribute("href")) { exchangeIdIDRef_ = exchangeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeId_ = boost::shared_ptr<ExchangeId>(new ExchangeId(exchangeIdNode));}
   }

   //informationSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* informationSourceNode = xmlNode->FirstChildElement("informationSource");

   if(informationSourceNode){informationSourceIsNull_ = false;}
   else{informationSourceIsNull_ = true;}

   if(informationSourceNode)
   {
      for(informationSourceNode; informationSourceNode; informationSourceNode = informationSourceNode->NextSiblingElement("informationSource")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
          #endif
          if(informationSourceNode->Attribute("href") || informationSourceNode->Attribute("id"))
          {
              if(informationSourceNode->Attribute("id"))
              {
                  informationSourceIDRef_ = informationSourceNode->Attribute("id");
                  informationSource_.push_back(boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode)));
                  informationSource_.back()->setID(informationSourceIDRef_);
                  IDManager::instance().setID(informationSourceIDRef_, informationSource_.back());
              }
              else if(informationSourceNode->Attribute("href")) { informationSourceIDRef_ = informationSourceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { informationSource_.push_back(boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
       #endif
   }

   //pricingModelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingModelNode = xmlNode->FirstChildElement("pricingModel");

   if(pricingModelNode){pricingModelIsNull_ = false;}
   else{pricingModelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingModelNode , address : " << pricingModelNode << std::endl;
   #endif
   if(pricingModelNode)
   {
      if(pricingModelNode->Attribute("href") || pricingModelNode->Attribute("id"))
      {
          if(pricingModelNode->Attribute("id"))
          {
             pricingModelIDRef_ = pricingModelNode->Attribute("id");
             pricingModel_ = boost::shared_ptr<PricingModel>(new PricingModel(pricingModelNode));
             pricingModel_->setID(pricingModelIDRef_);
             IDManager::instance().setID(pricingModelIDRef_,pricingModel_);
          }
          else if(pricingModelNode->Attribute("href")) { pricingModelIDRef_ = pricingModelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingModel_ = boost::shared_ptr<PricingModel>(new PricingModel(pricingModelNode));}
   }

   //timeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timeNode = xmlNode->FirstChildElement("time");

   if(timeNode){timeIsNull_ = false;}
   else{timeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timeNode , address : " << timeNode << std::endl;
   #endif
   if(timeNode)
   {
      if(timeNode->Attribute("href") || timeNode->Attribute("id"))
      {
          if(timeNode->Attribute("id"))
          {
             timeIDRef_ = timeNode->Attribute("id");
             time_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(timeNode));
             time_->setID(timeIDRef_);
             IDManager::instance().setID(timeIDRef_,time_);
          }
          else if(timeNode->Attribute("href")) { timeIDRef_ = timeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { time_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(timeNode));}
   }

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
             valuationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(valuationDateNode));
             valuationDate_->setID(valuationDateIDRef_);
             IDManager::instance().setID(valuationDateIDRef_,valuationDate_);
          }
          else if(valuationDateNode->Attribute("href")) { valuationDateIDRef_ = valuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(valuationDateNode));}
   }

   //expiryTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expiryTimeNode = xmlNode->FirstChildElement("expiryTime");

   if(expiryTimeNode){expiryTimeIsNull_ = false;}
   else{expiryTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expiryTimeNode , address : " << expiryTimeNode << std::endl;
   #endif
   if(expiryTimeNode)
   {
      if(expiryTimeNode->Attribute("href") || expiryTimeNode->Attribute("id"))
      {
          if(expiryTimeNode->Attribute("id"))
          {
             expiryTimeIDRef_ = expiryTimeNode->Attribute("id");
             expiryTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(expiryTimeNode));
             expiryTime_->setID(expiryTimeIDRef_);
             IDManager::instance().setID(expiryTimeIDRef_,expiryTime_);
          }
          else if(expiryTimeNode->Attribute("href")) { expiryTimeIDRef_ = expiryTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expiryTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(expiryTimeNode));}
   }

   //cashflowTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashflowTypeNode = xmlNode->FirstChildElement("cashflowType");

   if(cashflowTypeNode){cashflowTypeIsNull_ = false;}
   else{cashflowTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashflowTypeNode , address : " << cashflowTypeNode << std::endl;
   #endif
   if(cashflowTypeNode)
   {
      if(cashflowTypeNode->Attribute("href") || cashflowTypeNode->Attribute("id"))
      {
          if(cashflowTypeNode->Attribute("id"))
          {
             cashflowTypeIDRef_ = cashflowTypeNode->Attribute("id");
             cashflowType_ = boost::shared_ptr<CashflowType>(new CashflowType(cashflowTypeNode));
             cashflowType_->setID(cashflowTypeIDRef_);
             IDManager::instance().setID(cashflowTypeIDRef_,cashflowType_);
          }
          else if(cashflowTypeNode->Attribute("href")) { cashflowTypeIDRef_ = cashflowTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashflowType_ = boost::shared_ptr<CashflowType>(new CashflowType(cashflowTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> BasicQuotation::getValue()
{
   if(!this->valueIsNull_){
        if(valueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(valueIDRef_));
        }else{
             return this->value_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<AssetMeasureType> BasicQuotation::getMeasureType()
{
   if(!this->measureTypeIsNull_){
        if(measureTypeIDRef_ != ""){
             return boost::shared_static_cast<AssetMeasureType>(IDManager::instance().getID(measureTypeIDRef_));
        }else{
             return this->measureType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetMeasureType>();
   }
}
boost::shared_ptr<PriceQuoteUnits> BasicQuotation::getQuoteUnits()
{
   if(!this->quoteUnitsIsNull_){
        if(quoteUnitsIDRef_ != ""){
             return boost::shared_static_cast<PriceQuoteUnits>(IDManager::instance().getID(quoteUnitsIDRef_));
        }else{
             return this->quoteUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PriceQuoteUnits>();
   }
}
boost::shared_ptr<QuotationSideEnum> BasicQuotation::getSide()
{
   if(!this->sideIsNull_){
        if(sideIDRef_ != ""){
             return boost::shared_static_cast<QuotationSideEnum>(IDManager::instance().getID(sideIDRef_));
        }else{
             return this->side_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationSideEnum>();
   }
}
boost::shared_ptr<Currency> BasicQuotation::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<ReportingCurrencyType> BasicQuotation::getCurrencyType()
{
   if(!this->currencyTypeIsNull_){
        if(currencyTypeIDRef_ != ""){
             return boost::shared_static_cast<ReportingCurrencyType>(IDManager::instance().getID(currencyTypeIDRef_));
        }else{
             return this->currencyType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReportingCurrencyType>();
   }
}
boost::shared_ptr<QuoteTiming> BasicQuotation::getTiming()
{
   if(!this->timingIsNull_){
        if(timingIDRef_ != ""){
             return boost::shared_static_cast<QuoteTiming>(IDManager::instance().getID(timingIDRef_));
        }else{
             return this->timing_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuoteTiming>();
   }
}
boost::shared_ptr<BusinessCenter> BasicQuotation::getBusinessCenter()
{
   if(!this->businessCenterIsNull_){
        if(businessCenterIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenter>(IDManager::instance().getID(businessCenterIDRef_));
        }else{
             return this->businessCenter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenter>();
   }
}
boost::shared_ptr<ExchangeId> BasicQuotation::getExchangeId()
{
   if(!this->exchangeIdIsNull_){
        if(exchangeIdIDRef_ != ""){
             return boost::shared_static_cast<ExchangeId>(IDManager::instance().getID(exchangeIdIDRef_));
        }else{
             return this->exchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExchangeId>();
   }
}
std::vector<boost::shared_ptr<InformationSource>> BasicQuotation::getInformationSource()
{
   if(!this->informationSourceIsNull_){
        if(informationSourceIDRef_ != ""){
             return this->informationSource_;
        }else{
             return this->informationSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<InformationSource>>();
   }
}
boost::shared_ptr<PricingModel> BasicQuotation::getPricingModel()
{
   if(!this->pricingModelIsNull_){
        if(pricingModelIDRef_ != ""){
             return boost::shared_static_cast<PricingModel>(IDManager::instance().getID(pricingModelIDRef_));
        }else{
             return this->pricingModel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingModel>();
   }
}
boost::shared_ptr<XsdTypeDateTime> BasicQuotation::getTime()
{
   if(!this->timeIsNull_){
        if(timeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(timeIDRef_));
        }else{
             return this->time_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDate> BasicQuotation::getValuationDate()
{
   if(!this->valuationDateIsNull_){
        if(valuationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(valuationDateIDRef_));
        }else{
             return this->valuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDateTime> BasicQuotation::getExpiryTime()
{
   if(!this->expiryTimeIsNull_){
        if(expiryTimeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(expiryTimeIDRef_));
        }else{
             return this->expiryTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<CashflowType> BasicQuotation::getCashflowType()
{
   if(!this->cashflowTypeIsNull_){
        if(cashflowTypeIDRef_ != ""){
             return boost::shared_static_cast<CashflowType>(IDManager::instance().getID(cashflowTypeIDRef_));
        }else{
             return this->cashflowType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashflowType>();
   }
}
}

