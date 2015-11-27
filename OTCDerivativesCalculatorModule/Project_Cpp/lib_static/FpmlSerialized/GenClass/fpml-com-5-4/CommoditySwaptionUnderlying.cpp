// CommoditySwaptionUnderlying.cpp 
#include "CommoditySwaptionUnderlying.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommoditySwaptionUnderlying::CommoditySwaptionUnderlying(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //settlementCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementCurrencyNode = xmlNode->FirstChildElement("settlementCurrency");

   if(settlementCurrencyNode){settlementCurrencyIsNull_ = false;}
   else{settlementCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementCurrencyNode , address : " << settlementCurrencyNode << std::endl;
   #endif
   if(settlementCurrencyNode)
   {
      if(settlementCurrencyNode->Attribute("href") || settlementCurrencyNode->Attribute("id"))
      {
          if(settlementCurrencyNode->Attribute("id"))
          {
             settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("id");
             settlementCurrency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(settlementCurrencyNode));
             settlementCurrency_->setID(settlementCurrencyIDRef_);
             IDManager::instance().setID(settlementCurrencyIDRef_,settlementCurrency_);
          }
          else if(settlementCurrencyNode->Attribute("href")) { settlementCurrencyIDRef_ = settlementCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementCurrency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(settlementCurrencyNode));}
   }

   //commoditySwapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commoditySwapLegNode = xmlNode->FirstChildElement("commoditySwapLeg");

   if(commoditySwapLegNode){commoditySwapLegIsNull_ = false;}
   else{commoditySwapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commoditySwapLegNode , address : " << commoditySwapLegNode << std::endl;
   #endif
   if(commoditySwapLegNode)
   {
      if(commoditySwapLegNode->Attribute("href") || commoditySwapLegNode->Attribute("id"))
      {
          if(commoditySwapLegNode->Attribute("id"))
          {
             commoditySwapLegIDRef_ = commoditySwapLegNode->Attribute("id");
             commoditySwapLeg_ = boost::shared_ptr<CommoditySwapLeg>(new CommoditySwapLeg(commoditySwapLegNode));
             commoditySwapLeg_->setID(commoditySwapLegIDRef_);
             IDManager::instance().setID(commoditySwapLegIDRef_,commoditySwapLeg_);
          }
          else if(commoditySwapLegNode->Attribute("href")) { commoditySwapLegIDRef_ = commoditySwapLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commoditySwapLeg_ = boost::shared_ptr<CommoditySwapLeg>(new CommoditySwapLeg(commoditySwapLegNode));}
   }

   //coalPhysicalLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coalPhysicalLegNode = xmlNode->FirstChildElement("coalPhysicalLeg");

   if(coalPhysicalLegNode){coalPhysicalLegIsNull_ = false;}
   else{coalPhysicalLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coalPhysicalLegNode , address : " << coalPhysicalLegNode << std::endl;
   #endif
   if(coalPhysicalLegNode)
   {
      if(coalPhysicalLegNode->Attribute("href") || coalPhysicalLegNode->Attribute("id"))
      {
          if(coalPhysicalLegNode->Attribute("id"))
          {
             coalPhysicalLegIDRef_ = coalPhysicalLegNode->Attribute("id");
             coalPhysicalLeg_ = boost::shared_ptr<CoalPhysicalLeg>(new CoalPhysicalLeg(coalPhysicalLegNode));
             coalPhysicalLeg_->setID(coalPhysicalLegIDRef_);
             IDManager::instance().setID(coalPhysicalLegIDRef_,coalPhysicalLeg_);
          }
          else if(coalPhysicalLegNode->Attribute("href")) { coalPhysicalLegIDRef_ = coalPhysicalLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { coalPhysicalLeg_ = boost::shared_ptr<CoalPhysicalLeg>(new CoalPhysicalLeg(coalPhysicalLegNode));}
   }

   //electricityPhysicalLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* electricityPhysicalLegNode = xmlNode->FirstChildElement("electricityPhysicalLeg");

   if(electricityPhysicalLegNode){electricityPhysicalLegIsNull_ = false;}
   else{electricityPhysicalLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- electricityPhysicalLegNode , address : " << electricityPhysicalLegNode << std::endl;
   #endif
   if(electricityPhysicalLegNode)
   {
      if(electricityPhysicalLegNode->Attribute("href") || electricityPhysicalLegNode->Attribute("id"))
      {
          if(electricityPhysicalLegNode->Attribute("id"))
          {
             electricityPhysicalLegIDRef_ = electricityPhysicalLegNode->Attribute("id");
             electricityPhysicalLeg_ = boost::shared_ptr<ElectricityPhysicalLeg>(new ElectricityPhysicalLeg(electricityPhysicalLegNode));
             electricityPhysicalLeg_->setID(electricityPhysicalLegIDRef_);
             IDManager::instance().setID(electricityPhysicalLegIDRef_,electricityPhysicalLeg_);
          }
          else if(electricityPhysicalLegNode->Attribute("href")) { electricityPhysicalLegIDRef_ = electricityPhysicalLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { electricityPhysicalLeg_ = boost::shared_ptr<ElectricityPhysicalLeg>(new ElectricityPhysicalLeg(electricityPhysicalLegNode));}
   }

   //environmentalPhysicalLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* environmentalPhysicalLegNode = xmlNode->FirstChildElement("environmentalPhysicalLeg");

   if(environmentalPhysicalLegNode){environmentalPhysicalLegIsNull_ = false;}
   else{environmentalPhysicalLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- environmentalPhysicalLegNode , address : " << environmentalPhysicalLegNode << std::endl;
   #endif
   if(environmentalPhysicalLegNode)
   {
      if(environmentalPhysicalLegNode->Attribute("href") || environmentalPhysicalLegNode->Attribute("id"))
      {
          if(environmentalPhysicalLegNode->Attribute("id"))
          {
             environmentalPhysicalLegIDRef_ = environmentalPhysicalLegNode->Attribute("id");
             environmentalPhysicalLeg_ = boost::shared_ptr<EnvironmentalPhysicalLeg>(new EnvironmentalPhysicalLeg(environmentalPhysicalLegNode));
             environmentalPhysicalLeg_->setID(environmentalPhysicalLegIDRef_);
             IDManager::instance().setID(environmentalPhysicalLegIDRef_,environmentalPhysicalLeg_);
          }
          else if(environmentalPhysicalLegNode->Attribute("href")) { environmentalPhysicalLegIDRef_ = environmentalPhysicalLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { environmentalPhysicalLeg_ = boost::shared_ptr<EnvironmentalPhysicalLeg>(new EnvironmentalPhysicalLeg(environmentalPhysicalLegNode));}
   }

   //fixedLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedLegNode = xmlNode->FirstChildElement("fixedLeg");

   if(fixedLegNode){fixedLegIsNull_ = false;}
   else{fixedLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedLegNode , address : " << fixedLegNode << std::endl;
   #endif
   if(fixedLegNode)
   {
      if(fixedLegNode->Attribute("href") || fixedLegNode->Attribute("id"))
      {
          if(fixedLegNode->Attribute("id"))
          {
             fixedLegIDRef_ = fixedLegNode->Attribute("id");
             fixedLeg_ = boost::shared_ptr<FixedPriceLeg>(new FixedPriceLeg(fixedLegNode));
             fixedLeg_->setID(fixedLegIDRef_);
             IDManager::instance().setID(fixedLegIDRef_,fixedLeg_);
          }
          else if(fixedLegNode->Attribute("href")) { fixedLegIDRef_ = fixedLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedLeg_ = boost::shared_ptr<FixedPriceLeg>(new FixedPriceLeg(fixedLegNode));}
   }

   //floatingLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingLegNode = xmlNode->FirstChildElement("floatingLeg");

   if(floatingLegNode){floatingLegIsNull_ = false;}
   else{floatingLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingLegNode , address : " << floatingLegNode << std::endl;
   #endif
   if(floatingLegNode)
   {
      if(floatingLegNode->Attribute("href") || floatingLegNode->Attribute("id"))
      {
          if(floatingLegNode->Attribute("id"))
          {
             floatingLegIDRef_ = floatingLegNode->Attribute("id");
             floatingLeg_ = boost::shared_ptr<FloatingPriceLeg>(new FloatingPriceLeg(floatingLegNode));
             floatingLeg_->setID(floatingLegIDRef_);
             IDManager::instance().setID(floatingLegIDRef_,floatingLeg_);
          }
          else if(floatingLegNode->Attribute("href")) { floatingLegIDRef_ = floatingLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingLeg_ = boost::shared_ptr<FloatingPriceLeg>(new FloatingPriceLeg(floatingLegNode));}
   }

   //gasPhysicalLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gasPhysicalLegNode = xmlNode->FirstChildElement("gasPhysicalLeg");

   if(gasPhysicalLegNode){gasPhysicalLegIsNull_ = false;}
   else{gasPhysicalLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gasPhysicalLegNode , address : " << gasPhysicalLegNode << std::endl;
   #endif
   if(gasPhysicalLegNode)
   {
      if(gasPhysicalLegNode->Attribute("href") || gasPhysicalLegNode->Attribute("id"))
      {
          if(gasPhysicalLegNode->Attribute("id"))
          {
             gasPhysicalLegIDRef_ = gasPhysicalLegNode->Attribute("id");
             gasPhysicalLeg_ = boost::shared_ptr<GasPhysicalLeg>(new GasPhysicalLeg(gasPhysicalLegNode));
             gasPhysicalLeg_->setID(gasPhysicalLegIDRef_);
             IDManager::instance().setID(gasPhysicalLegIDRef_,gasPhysicalLeg_);
          }
          else if(gasPhysicalLegNode->Attribute("href")) { gasPhysicalLegIDRef_ = gasPhysicalLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { gasPhysicalLeg_ = boost::shared_ptr<GasPhysicalLeg>(new GasPhysicalLeg(gasPhysicalLegNode));}
   }

   //oilPhysicalLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* oilPhysicalLegNode = xmlNode->FirstChildElement("oilPhysicalLeg");

   if(oilPhysicalLegNode){oilPhysicalLegIsNull_ = false;}
   else{oilPhysicalLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- oilPhysicalLegNode , address : " << oilPhysicalLegNode << std::endl;
   #endif
   if(oilPhysicalLegNode)
   {
      if(oilPhysicalLegNode->Attribute("href") || oilPhysicalLegNode->Attribute("id"))
      {
          if(oilPhysicalLegNode->Attribute("id"))
          {
             oilPhysicalLegIDRef_ = oilPhysicalLegNode->Attribute("id");
             oilPhysicalLeg_ = boost::shared_ptr<OilPhysicalLeg>(new OilPhysicalLeg(oilPhysicalLegNode));
             oilPhysicalLeg_->setID(oilPhysicalLegIDRef_);
             IDManager::instance().setID(oilPhysicalLegIDRef_,oilPhysicalLeg_);
          }
          else if(oilPhysicalLegNode->Attribute("href")) { oilPhysicalLegIDRef_ = oilPhysicalLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { oilPhysicalLeg_ = boost::shared_ptr<OilPhysicalLeg>(new OilPhysicalLeg(oilPhysicalLegNode));}
   }

   //weatherLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherLegNode = xmlNode->FirstChildElement("weatherLeg");

   if(weatherLegNode){weatherLegIsNull_ = false;}
   else{weatherLegIsNull_ = true;}

   if(weatherLegNode)
   {
      for(weatherLegNode; weatherLegNode; weatherLegNode = weatherLegNode->NextSiblingElement("weatherLeg")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherLegNode , address : " << weatherLegNode << std::endl;
          #endif
          if(weatherLegNode->Attribute("href") || weatherLegNode->Attribute("id"))
          {
              if(weatherLegNode->Attribute("id"))
              {
                  weatherLegIDRef_ = weatherLegNode->Attribute("id");
                  weatherLeg_.push_back(boost::shared_ptr<WeatherLeg>(new WeatherLeg(weatherLegNode)));
                  weatherLeg_.back()->setID(weatherLegIDRef_);
                  IDManager::instance().setID(weatherLegIDRef_, weatherLeg_.back());
              }
              else if(weatherLegNode->Attribute("href")) { weatherLegIDRef_ = weatherLegNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { weatherLeg_.push_back(boost::shared_ptr<WeatherLeg>(new WeatherLeg(weatherLegNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherLegNode , address : " << weatherLegNode << std::endl;
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
boost::shared_ptr<AdjustableOrRelativeDate> CommoditySwaptionUnderlying::getEffectiveDate()
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
boost::shared_ptr<AdjustableOrRelativeDate> CommoditySwaptionUnderlying::getTerminationDate()
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
boost::shared_ptr<IdentifiedCurrency> CommoditySwaptionUnderlying::getSettlementCurrency()
{
   if(!this->settlementCurrencyIsNull_){
        if(settlementCurrencyIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedCurrency>(IDManager::instance().getID(settlementCurrencyIDRef_));
        }else{
             return this->settlementCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedCurrency>();
   }
}
boost::shared_ptr<CommoditySwapLeg> CommoditySwaptionUnderlying::getCommoditySwapLeg()
{
   if(!this->commoditySwapLegIsNull_){
        if(commoditySwapLegIDRef_ != ""){
             return boost::shared_static_cast<CommoditySwapLeg>(IDManager::instance().getID(commoditySwapLegIDRef_));
        }else{
             return this->commoditySwapLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommoditySwapLeg>();
   }
}
boost::shared_ptr<CoalPhysicalLeg> CommoditySwaptionUnderlying::getCoalPhysicalLeg()
{
   if(!this->coalPhysicalLegIsNull_){
        if(coalPhysicalLegIDRef_ != ""){
             return boost::shared_static_cast<CoalPhysicalLeg>(IDManager::instance().getID(coalPhysicalLegIDRef_));
        }else{
             return this->coalPhysicalLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalPhysicalLeg>();
   }
}
boost::shared_ptr<ElectricityPhysicalLeg> CommoditySwaptionUnderlying::getElectricityPhysicalLeg()
{
   if(!this->electricityPhysicalLegIsNull_){
        if(electricityPhysicalLegIDRef_ != ""){
             return boost::shared_static_cast<ElectricityPhysicalLeg>(IDManager::instance().getID(electricityPhysicalLegIDRef_));
        }else{
             return this->electricityPhysicalLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityPhysicalLeg>();
   }
}
boost::shared_ptr<EnvironmentalPhysicalLeg> CommoditySwaptionUnderlying::getEnvironmentalPhysicalLeg()
{
   if(!this->environmentalPhysicalLegIsNull_){
        if(environmentalPhysicalLegIDRef_ != ""){
             return boost::shared_static_cast<EnvironmentalPhysicalLeg>(IDManager::instance().getID(environmentalPhysicalLegIDRef_));
        }else{
             return this->environmentalPhysicalLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EnvironmentalPhysicalLeg>();
   }
}
boost::shared_ptr<FixedPriceLeg> CommoditySwaptionUnderlying::getFixedLeg()
{
   if(!this->fixedLegIsNull_){
        if(fixedLegIDRef_ != ""){
             return boost::shared_static_cast<FixedPriceLeg>(IDManager::instance().getID(fixedLegIDRef_));
        }else{
             return this->fixedLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedPriceLeg>();
   }
}
boost::shared_ptr<FloatingPriceLeg> CommoditySwaptionUnderlying::getFloatingLeg()
{
   if(!this->floatingLegIsNull_){
        if(floatingLegIDRef_ != ""){
             return boost::shared_static_cast<FloatingPriceLeg>(IDManager::instance().getID(floatingLegIDRef_));
        }else{
             return this->floatingLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingPriceLeg>();
   }
}
boost::shared_ptr<GasPhysicalLeg> CommoditySwaptionUnderlying::getGasPhysicalLeg()
{
   if(!this->gasPhysicalLegIsNull_){
        if(gasPhysicalLegIDRef_ != ""){
             return boost::shared_static_cast<GasPhysicalLeg>(IDManager::instance().getID(gasPhysicalLegIDRef_));
        }else{
             return this->gasPhysicalLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GasPhysicalLeg>();
   }
}
boost::shared_ptr<OilPhysicalLeg> CommoditySwaptionUnderlying::getOilPhysicalLeg()
{
   if(!this->oilPhysicalLegIsNull_){
        if(oilPhysicalLegIDRef_ != ""){
             return boost::shared_static_cast<OilPhysicalLeg>(IDManager::instance().getID(oilPhysicalLegIDRef_));
        }else{
             return this->oilPhysicalLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OilPhysicalLeg>();
   }
}
std::vector<boost::shared_ptr<WeatherLeg>> CommoditySwaptionUnderlying::getWeatherLeg()
{
   if(!this->weatherLegIsNull_){
        if(weatherLegIDRef_ != ""){
             return this->weatherLeg_;
        }else{
             return this->weatherLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<WeatherLeg>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CommoditySwaptionUnderlying::getCommonPricing()
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
boost::shared_ptr<CommodityMarketDisruption> CommoditySwaptionUnderlying::getMarketDisruption()
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
boost::shared_ptr<CommodityBullionSettlementDisruptionEnum> CommoditySwaptionUnderlying::getSettlementDisruption()
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
boost::shared_ptr<Rounding> CommoditySwaptionUnderlying::getRounding()
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

