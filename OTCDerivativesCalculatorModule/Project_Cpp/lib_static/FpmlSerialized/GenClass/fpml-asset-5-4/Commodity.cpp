// Commodity.cpp 
#include "Commodity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Commodity::Commodity(TiXmlNode* xmlNode)
: IdentifiedAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //commodityBaseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityBaseNode = xmlNode->FirstChildElement("commodityBase");

   if(commodityBaseNode){commodityBaseIsNull_ = false;}
   else{commodityBaseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityBaseNode , address : " << commodityBaseNode << std::endl;
   #endif
   if(commodityBaseNode)
   {
      if(commodityBaseNode->Attribute("href") || commodityBaseNode->Attribute("id"))
      {
          if(commodityBaseNode->Attribute("id"))
          {
             commodityBaseIDRef_ = commodityBaseNode->Attribute("id");
             commodityBase_ = boost::shared_ptr<CommodityBase>(new CommodityBase(commodityBaseNode));
             commodityBase_->setID(commodityBaseIDRef_);
             IDManager::instance().setID(commodityBaseIDRef_,commodityBase_);
          }
          else if(commodityBaseNode->Attribute("href")) { commodityBaseIDRef_ = commodityBaseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodityBase_ = boost::shared_ptr<CommodityBase>(new CommodityBase(commodityBaseNode));}
   }

   //commodityDetailsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityDetailsNode = xmlNode->FirstChildElement("commodityDetails");

   if(commodityDetailsNode){commodityDetailsIsNull_ = false;}
   else{commodityDetailsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityDetailsNode , address : " << commodityDetailsNode << std::endl;
   #endif
   if(commodityDetailsNode)
   {
      if(commodityDetailsNode->Attribute("href") || commodityDetailsNode->Attribute("id"))
      {
          if(commodityDetailsNode->Attribute("id"))
          {
             commodityDetailsIDRef_ = commodityDetailsNode->Attribute("id");
             commodityDetails_ = boost::shared_ptr<CommodityDetails>(new CommodityDetails(commodityDetailsNode));
             commodityDetails_->setID(commodityDetailsIDRef_);
             IDManager::instance().setID(commodityDetailsIDRef_,commodityDetails_);
          }
          else if(commodityDetailsNode->Attribute("href")) { commodityDetailsIDRef_ = commodityDetailsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodityDetails_ = boost::shared_ptr<CommodityDetails>(new CommodityDetails(commodityDetailsNode));}
   }

   //unitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unitNode = xmlNode->FirstChildElement("unit");

   if(unitNode){unitIsNull_ = false;}
   else{unitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unitNode , address : " << unitNode << std::endl;
   #endif
   if(unitNode)
   {
      if(unitNode->Attribute("href") || unitNode->Attribute("id"))
      {
          if(unitNode->Attribute("id"))
          {
             unitIDRef_ = unitNode->Attribute("id");
             unit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(unitNode));
             unit_->setID(unitIDRef_);
             IDManager::instance().setID(unitIDRef_,unit_);
          }
          else if(unitNode->Attribute("href")) { unitIDRef_ = unitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(unitNode));}
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

   //publicationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* publicationNode = xmlNode->FirstChildElement("publication");

   if(publicationNode){publicationIsNull_ = false;}
   else{publicationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publicationNode , address : " << publicationNode << std::endl;
   #endif
   if(publicationNode)
   {
      if(publicationNode->Attribute("href") || publicationNode->Attribute("id"))
      {
          if(publicationNode->Attribute("id"))
          {
             publicationIDRef_ = publicationNode->Attribute("id");
             publication_ = boost::shared_ptr<CommodityInformationSource>(new CommodityInformationSource(publicationNode));
             publication_->setID(publicationIDRef_);
             IDManager::instance().setID(publicationIDRef_,publication_);
          }
          else if(publicationNode->Attribute("href")) { publicationIDRef_ = publicationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { publication_ = boost::shared_ptr<CommodityInformationSource>(new CommodityInformationSource(publicationNode));}
   }

   //specifiedPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specifiedPriceNode = xmlNode->FirstChildElement("specifiedPrice");

   if(specifiedPriceNode){specifiedPriceIsNull_ = false;}
   else{specifiedPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specifiedPriceNode , address : " << specifiedPriceNode << std::endl;
   #endif
   if(specifiedPriceNode)
   {
      if(specifiedPriceNode->Attribute("href") || specifiedPriceNode->Attribute("id"))
      {
          if(specifiedPriceNode->Attribute("id"))
          {
             specifiedPriceIDRef_ = specifiedPriceNode->Attribute("id");
             specifiedPrice_ = boost::shared_ptr<SpecifiedPriceEnum>(new SpecifiedPriceEnum(specifiedPriceNode));
             specifiedPrice_->setID(specifiedPriceIDRef_);
             IDManager::instance().setID(specifiedPriceIDRef_,specifiedPrice_);
          }
          else if(specifiedPriceNode->Attribute("href")) { specifiedPriceIDRef_ = specifiedPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { specifiedPrice_ = boost::shared_ptr<SpecifiedPriceEnum>(new SpecifiedPriceEnum(specifiedPriceNode));}
   }

   //deliveryDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryDatesNode = xmlNode->FirstChildElement("deliveryDates");

   if(deliveryDatesNode){deliveryDatesIsNull_ = false;}
   else{deliveryDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryDatesNode , address : " << deliveryDatesNode << std::endl;
   #endif
   if(deliveryDatesNode)
   {
      if(deliveryDatesNode->Attribute("href") || deliveryDatesNode->Attribute("id"))
      {
          if(deliveryDatesNode->Attribute("id"))
          {
             deliveryDatesIDRef_ = deliveryDatesNode->Attribute("id");
             deliveryDates_ = boost::shared_ptr<DeliveryDatesEnum>(new DeliveryDatesEnum(deliveryDatesNode));
             deliveryDates_->setID(deliveryDatesIDRef_);
             IDManager::instance().setID(deliveryDatesIDRef_,deliveryDates_);
          }
          else if(deliveryDatesNode->Attribute("href")) { deliveryDatesIDRef_ = deliveryDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryDates_ = boost::shared_ptr<DeliveryDatesEnum>(new DeliveryDatesEnum(deliveryDatesNode));}
   }

   //deliveryDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryDateNode = xmlNode->FirstChildElement("deliveryDate");

   if(deliveryDateNode){deliveryDateIsNull_ = false;}
   else{deliveryDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryDateNode , address : " << deliveryDateNode << std::endl;
   #endif
   if(deliveryDateNode)
   {
      if(deliveryDateNode->Attribute("href") || deliveryDateNode->Attribute("id"))
      {
          if(deliveryDateNode->Attribute("id"))
          {
             deliveryDateIDRef_ = deliveryDateNode->Attribute("id");
             deliveryDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(deliveryDateNode));
             deliveryDate_->setID(deliveryDateIDRef_);
             IDManager::instance().setID(deliveryDateIDRef_,deliveryDate_);
          }
          else if(deliveryDateNode->Attribute("href")) { deliveryDateIDRef_ = deliveryDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(deliveryDateNode));}
   }

   //deliveryDateYearMonthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryDateYearMonthNode = xmlNode->FirstChildElement("deliveryDateYearMonth");

   if(deliveryDateYearMonthNode){deliveryDateYearMonthIsNull_ = false;}
   else{deliveryDateYearMonthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryDateYearMonthNode , address : " << deliveryDateYearMonthNode << std::endl;
   #endif
   if(deliveryDateYearMonthNode)
   {
      if(deliveryDateYearMonthNode->Attribute("href") || deliveryDateYearMonthNode->Attribute("id"))
      {
          if(deliveryDateYearMonthNode->Attribute("id"))
          {
             deliveryDateYearMonthIDRef_ = deliveryDateYearMonthNode->Attribute("id");
             deliveryDateYearMonth_ = boost::shared_ptr<XsdTypeGYearMonth>(new XsdTypeGYearMonth(deliveryDateYearMonthNode));
             deliveryDateYearMonth_->setID(deliveryDateYearMonthIDRef_);
             IDManager::instance().setID(deliveryDateYearMonthIDRef_,deliveryDateYearMonth_);
          }
          else if(deliveryDateYearMonthNode->Attribute("href")) { deliveryDateYearMonthIDRef_ = deliveryDateYearMonthNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryDateYearMonth_ = boost::shared_ptr<XsdTypeGYearMonth>(new XsdTypeGYearMonth(deliveryDateYearMonthNode));}
   }

   //deliveryDateRollConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryDateRollConventionNode = xmlNode->FirstChildElement("deliveryDateRollConvention");

   if(deliveryDateRollConventionNode){deliveryDateRollConventionIsNull_ = false;}
   else{deliveryDateRollConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryDateRollConventionNode , address : " << deliveryDateRollConventionNode << std::endl;
   #endif
   if(deliveryDateRollConventionNode)
   {
      if(deliveryDateRollConventionNode->Attribute("href") || deliveryDateRollConventionNode->Attribute("id"))
      {
          if(deliveryDateRollConventionNode->Attribute("id"))
          {
             deliveryDateRollConventionIDRef_ = deliveryDateRollConventionNode->Attribute("id");
             deliveryDateRollConvention_ = boost::shared_ptr<Offset>(new Offset(deliveryDateRollConventionNode));
             deliveryDateRollConvention_->setID(deliveryDateRollConventionIDRef_);
             IDManager::instance().setID(deliveryDateRollConventionIDRef_,deliveryDateRollConvention_);
          }
          else if(deliveryDateRollConventionNode->Attribute("href")) { deliveryDateRollConventionIDRef_ = deliveryDateRollConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryDateRollConvention_ = boost::shared_ptr<Offset>(new Offset(deliveryDateRollConventionNode));}
   }

   //multiplierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multiplierNode = xmlNode->FirstChildElement("multiplier");

   if(multiplierNode){multiplierIsNull_ = false;}
   else{multiplierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multiplierNode , address : " << multiplierNode << std::endl;
   #endif
   if(multiplierNode)
   {
      if(multiplierNode->Attribute("href") || multiplierNode->Attribute("id"))
      {
          if(multiplierNode->Attribute("id"))
          {
             multiplierIDRef_ = multiplierNode->Attribute("id");
             multiplier_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(multiplierNode));
             multiplier_->setID(multiplierIDRef_);
             IDManager::instance().setID(multiplierIDRef_,multiplier_);
          }
          else if(multiplierNode->Attribute("href")) { multiplierIDRef_ = multiplierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multiplier_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(multiplierNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityBase> Commodity::getCommodityBase()
{
   if(!this->commodityBaseIsNull_){
        if(commodityBaseIDRef_ != ""){
             return boost::shared_static_cast<CommodityBase>(IDManager::instance().getID(commodityBaseIDRef_));
        }else{
             return this->commodityBase_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityBase>();
   }
}
boost::shared_ptr<CommodityDetails> Commodity::getCommodityDetails()
{
   if(!this->commodityDetailsIsNull_){
        if(commodityDetailsIDRef_ != ""){
             return boost::shared_static_cast<CommodityDetails>(IDManager::instance().getID(commodityDetailsIDRef_));
        }else{
             return this->commodityDetails_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDetails>();
   }
}
boost::shared_ptr<QuantityUnit> Commodity::getUnit()
{
   if(!this->unitIsNull_){
        if(unitIDRef_ != ""){
             return boost::shared_static_cast<QuantityUnit>(IDManager::instance().getID(unitIDRef_));
        }else{
             return this->unit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuantityUnit>();
   }
}
boost::shared_ptr<Currency> Commodity::getCurrency()
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
boost::shared_ptr<ExchangeId> Commodity::getExchangeId()
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
boost::shared_ptr<CommodityInformationSource> Commodity::getPublication()
{
   if(!this->publicationIsNull_){
        if(publicationIDRef_ != ""){
             return boost::shared_static_cast<CommodityInformationSource>(IDManager::instance().getID(publicationIDRef_));
        }else{
             return this->publication_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityInformationSource>();
   }
}
boost::shared_ptr<SpecifiedPriceEnum> Commodity::getSpecifiedPrice()
{
   if(!this->specifiedPriceIsNull_){
        if(specifiedPriceIDRef_ != ""){
             return boost::shared_static_cast<SpecifiedPriceEnum>(IDManager::instance().getID(specifiedPriceIDRef_));
        }else{
             return this->specifiedPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SpecifiedPriceEnum>();
   }
}
boost::shared_ptr<DeliveryDatesEnum> Commodity::getDeliveryDates()
{
   if(!this->deliveryDatesIsNull_){
        if(deliveryDatesIDRef_ != ""){
             return boost::shared_static_cast<DeliveryDatesEnum>(IDManager::instance().getID(deliveryDatesIDRef_));
        }else{
             return this->deliveryDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeliveryDatesEnum>();
   }
}
boost::shared_ptr<AdjustableDate> Commodity::getDeliveryDate()
{
   if(!this->deliveryDateIsNull_){
        if(deliveryDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(deliveryDateIDRef_));
        }else{
             return this->deliveryDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<XsdTypeGYearMonth> Commodity::getDeliveryDateYearMonth()
{
   if(!this->deliveryDateYearMonthIsNull_){
        if(deliveryDateYearMonthIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeGYearMonth>(IDManager::instance().getID(deliveryDateYearMonthIDRef_));
        }else{
             return this->deliveryDateYearMonth_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeGYearMonth>();
   }
}
boost::shared_ptr<Offset> Commodity::getDeliveryDateRollConvention()
{
   if(!this->deliveryDateRollConventionIsNull_){
        if(deliveryDateRollConventionIDRef_ != ""){
             return boost::shared_static_cast<Offset>(IDManager::instance().getID(deliveryDateRollConventionIDRef_));
        }else{
             return this->deliveryDateRollConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Offset>();
   }
}
boost::shared_ptr<PositiveDecimal> Commodity::getMultiplier()
{
   if(!this->multiplierIsNull_){
        if(multiplierIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(multiplierIDRef_));
        }else{
             return this->multiplier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
}

