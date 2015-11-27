// CommoditySwaption.cpp 
#include "CommoditySwaption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommoditySwaption::CommoditySwaption(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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
             optionType_ = boost::shared_ptr<PutCallEnum>(new PutCallEnum(optionTypeNode));
             optionType_->setID(optionTypeIDRef_);
             IDManager::instance().setID(optionTypeIDRef_,optionType_);
          }
          else if(optionTypeNode->Attribute("href")) { optionTypeIDRef_ = optionTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionType_ = boost::shared_ptr<PutCallEnum>(new PutCallEnum(optionTypeNode));}
   }

   //commoditySwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commoditySwapNode = xmlNode->FirstChildElement("commoditySwap");

   if(commoditySwapNode){commoditySwapIsNull_ = false;}
   else{commoditySwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commoditySwapNode , address : " << commoditySwapNode << std::endl;
   #endif
   if(commoditySwapNode)
   {
      if(commoditySwapNode->Attribute("href") || commoditySwapNode->Attribute("id"))
      {
          if(commoditySwapNode->Attribute("id"))
          {
             commoditySwapIDRef_ = commoditySwapNode->Attribute("id");
             commoditySwap_ = boost::shared_ptr<CommoditySwaptionUnderlying>(new CommoditySwaptionUnderlying(commoditySwapNode));
             commoditySwap_->setID(commoditySwapIDRef_);
             IDManager::instance().setID(commoditySwapIDRef_,commoditySwap_);
          }
          else if(commoditySwapNode->Attribute("href")) { commoditySwapIDRef_ = commoditySwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commoditySwap_ = boost::shared_ptr<CommoditySwaptionUnderlying>(new CommoditySwaptionUnderlying(commoditySwapNode));}
   }

   //physicalExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalExerciseNode = xmlNode->FirstChildElement("physicalExercise");

   if(physicalExerciseNode){physicalExerciseIsNull_ = false;}
   else{physicalExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalExerciseNode , address : " << physicalExerciseNode << std::endl;
   #endif
   if(physicalExerciseNode)
   {
      if(physicalExerciseNode->Attribute("href") || physicalExerciseNode->Attribute("id"))
      {
          if(physicalExerciseNode->Attribute("id"))
          {
             physicalExerciseIDRef_ = physicalExerciseNode->Attribute("id");
             physicalExercise_ = boost::shared_ptr<CommodityPhysicalExercise>(new CommodityPhysicalExercise(physicalExerciseNode));
             physicalExercise_->setID(physicalExerciseIDRef_);
             IDManager::instance().setID(physicalExerciseIDRef_,physicalExercise_);
          }
          else if(physicalExerciseNode->Attribute("href")) { physicalExerciseIDRef_ = physicalExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalExercise_ = boost::shared_ptr<CommodityPhysicalExercise>(new CommodityPhysicalExercise(physicalExerciseNode));}
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
             premium_ = boost::shared_ptr<CommodityPremium>(new CommodityPremium(premiumNode));
             premium_->setID(premiumIDRef_);
             IDManager::instance().setID(premiumIDRef_,premium_);
          }
          else if(premiumNode->Attribute("href")) { premiumIDRef_ = premiumNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { premium_ = boost::shared_ptr<CommodityPremium>(new CommodityPremium(premiumNode));}
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
boost::shared_ptr<PartyReference> CommoditySwaption::getBuyerPartyReference()
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
boost::shared_ptr<AccountReference> CommoditySwaption::getBuyerAccountReference()
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
boost::shared_ptr<PartyReference> CommoditySwaption::getSellerPartyReference()
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
boost::shared_ptr<AccountReference> CommoditySwaption::getSellerAccountReference()
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
boost::shared_ptr<PutCallEnum> CommoditySwaption::getOptionType()
{
   if(!this->optionTypeIsNull_){
        if(optionTypeIDRef_ != ""){
             return boost::shared_static_cast<PutCallEnum>(IDManager::instance().getID(optionTypeIDRef_));
        }else{
             return this->optionType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PutCallEnum>();
   }
}
boost::shared_ptr<CommoditySwaptionUnderlying> CommoditySwaption::getCommoditySwap()
{
   if(!this->commoditySwapIsNull_){
        if(commoditySwapIDRef_ != ""){
             return boost::shared_static_cast<CommoditySwaptionUnderlying>(IDManager::instance().getID(commoditySwapIDRef_));
        }else{
             return this->commoditySwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommoditySwaptionUnderlying>();
   }
}
boost::shared_ptr<CommodityPhysicalExercise> CommoditySwaption::getPhysicalExercise()
{
   if(!this->physicalExerciseIsNull_){
        if(physicalExerciseIDRef_ != ""){
             return boost::shared_static_cast<CommodityPhysicalExercise>(IDManager::instance().getID(physicalExerciseIDRef_));
        }else{
             return this->physicalExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPhysicalExercise>();
   }
}
boost::shared_ptr<CommodityPremium> CommoditySwaption::getPremium()
{
   if(!this->premiumIsNull_){
        if(premiumIDRef_ != ""){
             return boost::shared_static_cast<CommodityPremium>(IDManager::instance().getID(premiumIDRef_));
        }else{
             return this->premium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPremium>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CommoditySwaption::getCommonPricing()
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
boost::shared_ptr<CommodityMarketDisruption> CommoditySwaption::getMarketDisruption()
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
boost::shared_ptr<CommodityBullionSettlementDisruptionEnum> CommoditySwaption::getSettlementDisruption()
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
boost::shared_ptr<Rounding> CommoditySwaption::getRounding()
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

