// CommodityForward.cpp 
#include "CommodityForward.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityForward::CommodityForward(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valueDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueDateNode = xmlNode->FirstChildElement("valueDate");

   if(valueDateNode){valueDateIsNull_ = false;}
   else{valueDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueDateNode , address : " << valueDateNode << std::endl;
   #endif
   if(valueDateNode)
   {
      if(valueDateNode->Attribute("href") || valueDateNode->Attribute("id"))
      {
          if(valueDateNode->Attribute("id"))
          {
             valueDateIDRef_ = valueDateNode->Attribute("id");
             valueDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(valueDateNode));
             valueDate_->setID(valueDateIDRef_);
             IDManager::instance().setID(valueDateIDRef_,valueDate_);
          }
          else if(valueDateNode->Attribute("href")) { valueDateIDRef_ = valueDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valueDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(valueDateNode));}
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
             fixedLeg_ = boost::shared_ptr<NonPeriodicFixedPriceLeg>(new NonPeriodicFixedPriceLeg(fixedLegNode));
             fixedLeg_->setID(fixedLegIDRef_);
             IDManager::instance().setID(fixedLegIDRef_,fixedLeg_);
          }
          else if(fixedLegNode->Attribute("href")) { fixedLegIDRef_ = fixedLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedLeg_ = boost::shared_ptr<NonPeriodicFixedPriceLeg>(new NonPeriodicFixedPriceLeg(fixedLegNode));}
   }

   //averagePriceLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagePriceLegNode = xmlNode->FirstChildElement("averagePriceLeg");

   if(averagePriceLegNode){averagePriceLegIsNull_ = false;}
   else{averagePriceLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagePriceLegNode , address : " << averagePriceLegNode << std::endl;
   #endif
   if(averagePriceLegNode)
   {
      if(averagePriceLegNode->Attribute("href") || averagePriceLegNode->Attribute("id"))
      {
          if(averagePriceLegNode->Attribute("id"))
          {
             averagePriceLegIDRef_ = averagePriceLegNode->Attribute("id");
             averagePriceLeg_ = boost::shared_ptr<AveragePriceLeg>(new AveragePriceLeg(averagePriceLegNode));
             averagePriceLeg_->setID(averagePriceLegIDRef_);
             IDManager::instance().setID(averagePriceLegIDRef_,averagePriceLeg_);
          }
          else if(averagePriceLegNode->Attribute("href")) { averagePriceLegIDRef_ = averagePriceLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagePriceLeg_ = boost::shared_ptr<AveragePriceLeg>(new AveragePriceLeg(averagePriceLegNode));}
   }

   //commodityForwardLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityForwardLegNode = xmlNode->FirstChildElement("commodityForwardLeg");

   if(commodityForwardLegNode){commodityForwardLegIsNull_ = false;}
   else{commodityForwardLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityForwardLegNode , address : " << commodityForwardLegNode << std::endl;
   #endif
   if(commodityForwardLegNode)
   {
      if(commodityForwardLegNode->Attribute("href") || commodityForwardLegNode->Attribute("id"))
      {
          if(commodityForwardLegNode->Attribute("id"))
          {
             commodityForwardLegIDRef_ = commodityForwardLegNode->Attribute("id");
             commodityForwardLeg_ = boost::shared_ptr<CommodityForwardLeg>(new CommodityForwardLeg(commodityForwardLegNode));
             commodityForwardLeg_->setID(commodityForwardLegIDRef_);
             IDManager::instance().setID(commodityForwardLegIDRef_,commodityForwardLeg_);
          }
          else if(commodityForwardLegNode->Attribute("href")) { commodityForwardLegIDRef_ = commodityForwardLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodityForwardLeg_ = boost::shared_ptr<CommodityForwardLeg>(new CommodityForwardLeg(commodityForwardLegNode));}
   }

   //bullionPhysicalLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bullionPhysicalLegNode = xmlNode->FirstChildElement("bullionPhysicalLeg");

   if(bullionPhysicalLegNode){bullionPhysicalLegIsNull_ = false;}
   else{bullionPhysicalLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bullionPhysicalLegNode , address : " << bullionPhysicalLegNode << std::endl;
   #endif
   if(bullionPhysicalLegNode)
   {
      if(bullionPhysicalLegNode->Attribute("href") || bullionPhysicalLegNode->Attribute("id"))
      {
          if(bullionPhysicalLegNode->Attribute("id"))
          {
             bullionPhysicalLegIDRef_ = bullionPhysicalLegNode->Attribute("id");
             bullionPhysicalLeg_ = boost::shared_ptr<BullionPhysicalLeg>(new BullionPhysicalLeg(bullionPhysicalLegNode));
             bullionPhysicalLeg_->setID(bullionPhysicalLegIDRef_);
             IDManager::instance().setID(bullionPhysicalLegIDRef_,bullionPhysicalLeg_);
          }
          else if(bullionPhysicalLegNode->Attribute("href")) { bullionPhysicalLegIDRef_ = bullionPhysicalLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bullionPhysicalLeg_ = boost::shared_ptr<BullionPhysicalLeg>(new BullionPhysicalLeg(bullionPhysicalLegNode));}
   }

   //metalPhysicalLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* metalPhysicalLegNode = xmlNode->FirstChildElement("metalPhysicalLeg");

   if(metalPhysicalLegNode){metalPhysicalLegIsNull_ = false;}
   else{metalPhysicalLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- metalPhysicalLegNode , address : " << metalPhysicalLegNode << std::endl;
   #endif
   if(metalPhysicalLegNode)
   {
      if(metalPhysicalLegNode->Attribute("href") || metalPhysicalLegNode->Attribute("id"))
      {
          if(metalPhysicalLegNode->Attribute("id"))
          {
             metalPhysicalLegIDRef_ = metalPhysicalLegNode->Attribute("id");
             metalPhysicalLeg_ = boost::shared_ptr<MetalPhysicalLeg>(new MetalPhysicalLeg(metalPhysicalLegNode));
             metalPhysicalLeg_->setID(metalPhysicalLegIDRef_);
             IDManager::instance().setID(metalPhysicalLegIDRef_,metalPhysicalLeg_);
          }
          else if(metalPhysicalLegNode->Attribute("href")) { metalPhysicalLegIDRef_ = metalPhysicalLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { metalPhysicalLeg_ = boost::shared_ptr<MetalPhysicalLeg>(new MetalPhysicalLeg(metalPhysicalLegNode));}
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
boost::shared_ptr<AdjustableOrRelativeDate> CommodityForward::getValueDate()
{
   if(!this->valueDateIsNull_){
        if(valueDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(valueDateIDRef_));
        }else{
             return this->valueDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<NonPeriodicFixedPriceLeg> CommodityForward::getFixedLeg()
{
   if(!this->fixedLegIsNull_){
        if(fixedLegIDRef_ != ""){
             return boost::shared_static_cast<NonPeriodicFixedPriceLeg>(IDManager::instance().getID(fixedLegIDRef_));
        }else{
             return this->fixedLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonPeriodicFixedPriceLeg>();
   }
}
boost::shared_ptr<AveragePriceLeg> CommodityForward::getAveragePriceLeg()
{
   if(!this->averagePriceLegIsNull_){
        if(averagePriceLegIDRef_ != ""){
             return boost::shared_static_cast<AveragePriceLeg>(IDManager::instance().getID(averagePriceLegIDRef_));
        }else{
             return this->averagePriceLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AveragePriceLeg>();
   }
}
boost::shared_ptr<CommodityForwardLeg> CommodityForward::getCommodityForwardLeg()
{
   if(!this->commodityForwardLegIsNull_){
        if(commodityForwardLegIDRef_ != ""){
             return boost::shared_static_cast<CommodityForwardLeg>(IDManager::instance().getID(commodityForwardLegIDRef_));
        }else{
             return this->commodityForwardLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityForwardLeg>();
   }
}
boost::shared_ptr<BullionPhysicalLeg> CommodityForward::getBullionPhysicalLeg()
{
   if(!this->bullionPhysicalLegIsNull_){
        if(bullionPhysicalLegIDRef_ != ""){
             return boost::shared_static_cast<BullionPhysicalLeg>(IDManager::instance().getID(bullionPhysicalLegIDRef_));
        }else{
             return this->bullionPhysicalLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BullionPhysicalLeg>();
   }
}
boost::shared_ptr<MetalPhysicalLeg> CommodityForward::getMetalPhysicalLeg()
{
   if(!this->metalPhysicalLegIsNull_){
        if(metalPhysicalLegIDRef_ != ""){
             return boost::shared_static_cast<MetalPhysicalLeg>(IDManager::instance().getID(metalPhysicalLegIDRef_));
        }else{
             return this->metalPhysicalLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MetalPhysicalLeg>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CommodityForward::getCommonPricing()
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
boost::shared_ptr<CommodityMarketDisruption> CommodityForward::getMarketDisruption()
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
boost::shared_ptr<CommodityBullionSettlementDisruptionEnum> CommodityForward::getSettlementDisruption()
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
boost::shared_ptr<Rounding> CommodityForward::getRounding()
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

