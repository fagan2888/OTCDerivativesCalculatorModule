using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommoditySwaption : Product
    {
        public CommoditySwaption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode buyerPartyReferenceNode = xmlNode.SelectSingleNode("buyerPartyReference");
            
            if (buyerPartyReferenceNode != null)
            {
                if (buyerPartyReferenceNode.Attributes["href"] != null || buyerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(buyerPartyReferenceNode);
                        IDManager.SetID(buyerPartyReferenceIDRef_, ob);
                    }
                    else if (buyerPartyReferenceNode.Attributes["href"] != null)
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                    }
                }
                else
                {
                    buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                }
            }
            
        
            XmlNode buyerAccountReferenceNode = xmlNode.SelectSingleNode("buyerAccountReference");
            
            if (buyerAccountReferenceNode != null)
            {
                if (buyerAccountReferenceNode.Attributes["href"] != null || buyerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(buyerAccountReferenceNode);
                        IDManager.SetID(buyerAccountReferenceIDRef_, ob);
                    }
                    else if (buyerAccountReferenceNode.Attributes["href"] != null)
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                    }
                }
                else
                {
                    buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                }
            }
            
        
            XmlNode sellerPartyReferenceNode = xmlNode.SelectSingleNode("sellerPartyReference");
            
            if (sellerPartyReferenceNode != null)
            {
                if (sellerPartyReferenceNode.Attributes["href"] != null || sellerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(sellerPartyReferenceNode);
                        IDManager.SetID(sellerPartyReferenceIDRef_, ob);
                    }
                    else if (sellerPartyReferenceNode.Attributes["href"] != null)
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                    }
                }
                else
                {
                    sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                }
            }
            
        
            XmlNode sellerAccountReferenceNode = xmlNode.SelectSingleNode("sellerAccountReference");
            
            if (sellerAccountReferenceNode != null)
            {
                if (sellerAccountReferenceNode.Attributes["href"] != null || sellerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(sellerAccountReferenceNode);
                        IDManager.SetID(sellerAccountReferenceIDRef_, ob);
                    }
                    else if (sellerAccountReferenceNode.Attributes["href"] != null)
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                    }
                }
                else
                {
                    sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                }
            }
            
        
            XmlNode optionTypeNode = xmlNode.SelectSingleNode("optionType");
            
            if (optionTypeNode != null)
            {
                if (optionTypeNode.Attributes["href"] != null || optionTypeNode.Attributes["id"] != null) 
                {
                    if (optionTypeNode.Attributes["id"] != null) 
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["id"].Value;
                        PutCallEnum ob = new PutCallEnum(optionTypeNode);
                        IDManager.SetID(optionTypeIDRef_, ob);
                    }
                    else if (optionTypeNode.Attributes["href"] != null)
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionType_ = new PutCallEnum(optionTypeNode);
                    }
                }
                else
                {
                    optionType_ = new PutCallEnum(optionTypeNode);
                }
            }
            
        
            XmlNode commoditySwapNode = xmlNode.SelectSingleNode("commoditySwap");
            
            if (commoditySwapNode != null)
            {
                if (commoditySwapNode.Attributes["href"] != null || commoditySwapNode.Attributes["id"] != null) 
                {
                    if (commoditySwapNode.Attributes["id"] != null) 
                    {
                        commoditySwapIDRef_ = commoditySwapNode.Attributes["id"].Value;
                        CommoditySwaptionUnderlying ob = new CommoditySwaptionUnderlying(commoditySwapNode);
                        IDManager.SetID(commoditySwapIDRef_, ob);
                    }
                    else if (commoditySwapNode.Attributes["href"] != null)
                    {
                        commoditySwapIDRef_ = commoditySwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commoditySwap_ = new CommoditySwaptionUnderlying(commoditySwapNode);
                    }
                }
                else
                {
                    commoditySwap_ = new CommoditySwaptionUnderlying(commoditySwapNode);
                }
            }
            
        
            XmlNode physicalExerciseNode = xmlNode.SelectSingleNode("physicalExercise");
            
            if (physicalExerciseNode != null)
            {
                if (physicalExerciseNode.Attributes["href"] != null || physicalExerciseNode.Attributes["id"] != null) 
                {
                    if (physicalExerciseNode.Attributes["id"] != null) 
                    {
                        physicalExerciseIDRef_ = physicalExerciseNode.Attributes["id"].Value;
                        CommodityPhysicalExercise ob = new CommodityPhysicalExercise(physicalExerciseNode);
                        IDManager.SetID(physicalExerciseIDRef_, ob);
                    }
                    else if (physicalExerciseNode.Attributes["href"] != null)
                    {
                        physicalExerciseIDRef_ = physicalExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalExercise_ = new CommodityPhysicalExercise(physicalExerciseNode);
                    }
                }
                else
                {
                    physicalExercise_ = new CommodityPhysicalExercise(physicalExerciseNode);
                }
            }
            
        
            XmlNode premiumNode = xmlNode.SelectSingleNode("premium");
            
            if (premiumNode != null)
            {
                if (premiumNode.Attributes["href"] != null || premiumNode.Attributes["id"] != null) 
                {
                    if (premiumNode.Attributes["id"] != null) 
                    {
                        premiumIDRef_ = premiumNode.Attributes["id"].Value;
                        CommodityPremium ob = new CommodityPremium(premiumNode);
                        IDManager.SetID(premiumIDRef_, ob);
                    }
                    else if (premiumNode.Attributes["href"] != null)
                    {
                        premiumIDRef_ = premiumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premium_ = new CommodityPremium(premiumNode);
                    }
                }
                else
                {
                    premium_ = new CommodityPremium(premiumNode);
                }
            }
            
        
            XmlNode commonPricingNode = xmlNode.SelectSingleNode("commonPricing");
            
            if (commonPricingNode != null)
            {
                if (commonPricingNode.Attributes["href"] != null || commonPricingNode.Attributes["id"] != null) 
                {
                    if (commonPricingNode.Attributes["id"] != null) 
                    {
                        commonPricingIDRef_ = commonPricingNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(commonPricingNode);
                        IDManager.SetID(commonPricingIDRef_, ob);
                    }
                    else if (commonPricingNode.Attributes["href"] != null)
                    {
                        commonPricingIDRef_ = commonPricingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commonPricing_ = new XsdTypeBoolean(commonPricingNode);
                    }
                }
                else
                {
                    commonPricing_ = new XsdTypeBoolean(commonPricingNode);
                }
            }
            
        
            XmlNode marketDisruptionNode = xmlNode.SelectSingleNode("marketDisruption");
            
            if (marketDisruptionNode != null)
            {
                if (marketDisruptionNode.Attributes["href"] != null || marketDisruptionNode.Attributes["id"] != null) 
                {
                    if (marketDisruptionNode.Attributes["id"] != null) 
                    {
                        marketDisruptionIDRef_ = marketDisruptionNode.Attributes["id"].Value;
                        CommodityMarketDisruption ob = new CommodityMarketDisruption(marketDisruptionNode);
                        IDManager.SetID(marketDisruptionIDRef_, ob);
                    }
                    else if (marketDisruptionNode.Attributes["href"] != null)
                    {
                        marketDisruptionIDRef_ = marketDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        marketDisruption_ = new CommodityMarketDisruption(marketDisruptionNode);
                    }
                }
                else
                {
                    marketDisruption_ = new CommodityMarketDisruption(marketDisruptionNode);
                }
            }
            
        
            XmlNode settlementDisruptionNode = xmlNode.SelectSingleNode("settlementDisruption");
            
            if (settlementDisruptionNode != null)
            {
                if (settlementDisruptionNode.Attributes["href"] != null || settlementDisruptionNode.Attributes["id"] != null) 
                {
                    if (settlementDisruptionNode.Attributes["id"] != null) 
                    {
                        settlementDisruptionIDRef_ = settlementDisruptionNode.Attributes["id"].Value;
                        CommodityBullionSettlementDisruptionEnum ob = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                        IDManager.SetID(settlementDisruptionIDRef_, ob);
                    }
                    else if (settlementDisruptionNode.Attributes["href"] != null)
                    {
                        settlementDisruptionIDRef_ = settlementDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDisruption_ = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                    }
                }
                else
                {
                    settlementDisruption_ = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                }
            }
            
        
            XmlNode roundingNode = xmlNode.SelectSingleNode("rounding");
            
            if (roundingNode != null)
            {
                if (roundingNode.Attributes["href"] != null || roundingNode.Attributes["id"] != null) 
                {
                    if (roundingNode.Attributes["id"] != null) 
                    {
                        roundingIDRef_ = roundingNode.Attributes["id"].Value;
                        Rounding ob = new Rounding(roundingNode);
                        IDManager.SetID(roundingIDRef_, ob);
                    }
                    else if (roundingNode.Attributes["href"] != null)
                    {
                        roundingIDRef_ = roundingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rounding_ = new Rounding(roundingNode);
                    }
                }
                else
                {
                    rounding_ = new Rounding(roundingNode);
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference_
        private PartyReference buyerPartyReference_;
        public PartyReference BuyerPartyReference_
        {
            get
            {
                if (this.buyerPartyReference_ != null)
                {
                    return this.buyerPartyReference_; 
                }
                else if (this.buyerPartyReferenceIDRef_ != null)
                {
                    buyerPartyReference_ = IDManager.getID(buyerPartyReferenceIDRef_) as PartyReference;
                    return this.buyerPartyReference_; 
                }
                else
                {
                      return this.buyerPartyReference_; 
                }
            }
            set
            {
                if (this.buyerPartyReference_ != value)
                {
                    this.buyerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerPartyReferenceIDRef_ { get; set; }
        #region BuyerAccountReference_
        private AccountReference buyerAccountReference_;
        public AccountReference BuyerAccountReference_
        {
            get
            {
                if (this.buyerAccountReference_ != null)
                {
                    return this.buyerAccountReference_; 
                }
                else if (this.buyerAccountReferenceIDRef_ != null)
                {
                    buyerAccountReference_ = IDManager.getID(buyerAccountReferenceIDRef_) as AccountReference;
                    return this.buyerAccountReference_; 
                }
                else
                {
                      return this.buyerAccountReference_; 
                }
            }
            set
            {
                if (this.buyerAccountReference_ != value)
                {
                    this.buyerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerAccountReferenceIDRef_ { get; set; }
        #region SellerPartyReference_
        private PartyReference sellerPartyReference_;
        public PartyReference SellerPartyReference_
        {
            get
            {
                if (this.sellerPartyReference_ != null)
                {
                    return this.sellerPartyReference_; 
                }
                else if (this.sellerPartyReferenceIDRef_ != null)
                {
                    sellerPartyReference_ = IDManager.getID(sellerPartyReferenceIDRef_) as PartyReference;
                    return this.sellerPartyReference_; 
                }
                else
                {
                      return this.sellerPartyReference_; 
                }
            }
            set
            {
                if (this.sellerPartyReference_ != value)
                {
                    this.sellerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerPartyReferenceIDRef_ { get; set; }
        #region SellerAccountReference_
        private AccountReference sellerAccountReference_;
        public AccountReference SellerAccountReference_
        {
            get
            {
                if (this.sellerAccountReference_ != null)
                {
                    return this.sellerAccountReference_; 
                }
                else if (this.sellerAccountReferenceIDRef_ != null)
                {
                    sellerAccountReference_ = IDManager.getID(sellerAccountReferenceIDRef_) as AccountReference;
                    return this.sellerAccountReference_; 
                }
                else
                {
                      return this.sellerAccountReference_; 
                }
            }
            set
            {
                if (this.sellerAccountReference_ != value)
                {
                    this.sellerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerAccountReferenceIDRef_ { get; set; }
        #region OptionType_
        private PutCallEnum optionType_;
        public PutCallEnum OptionType_
        {
            get
            {
                if (this.optionType_ != null)
                {
                    return this.optionType_; 
                }
                else if (this.optionTypeIDRef_ != null)
                {
                    optionType_ = IDManager.getID(optionTypeIDRef_) as PutCallEnum;
                    return this.optionType_; 
                }
                else
                {
                      return this.optionType_; 
                }
            }
            set
            {
                if (this.optionType_ != value)
                {
                    this.optionType_ = value;
                }
            }
        }
        #endregion
        
        public string optionTypeIDRef_ { get; set; }
        #region CommoditySwap_
        private CommoditySwaptionUnderlying commoditySwap_;
        public CommoditySwaptionUnderlying CommoditySwap_
        {
            get
            {
                if (this.commoditySwap_ != null)
                {
                    return this.commoditySwap_; 
                }
                else if (this.commoditySwapIDRef_ != null)
                {
                    commoditySwap_ = IDManager.getID(commoditySwapIDRef_) as CommoditySwaptionUnderlying;
                    return this.commoditySwap_; 
                }
                else
                {
                      return this.commoditySwap_; 
                }
            }
            set
            {
                if (this.commoditySwap_ != value)
                {
                    this.commoditySwap_ = value;
                }
            }
        }
        #endregion
        
        public string commoditySwapIDRef_ { get; set; }
        #region PhysicalExercise_
        private CommodityPhysicalExercise physicalExercise_;
        public CommodityPhysicalExercise PhysicalExercise_
        {
            get
            {
                if (this.physicalExercise_ != null)
                {
                    return this.physicalExercise_; 
                }
                else if (this.physicalExerciseIDRef_ != null)
                {
                    physicalExercise_ = IDManager.getID(physicalExerciseIDRef_) as CommodityPhysicalExercise;
                    return this.physicalExercise_; 
                }
                else
                {
                      return this.physicalExercise_; 
                }
            }
            set
            {
                if (this.physicalExercise_ != value)
                {
                    this.physicalExercise_ = value;
                }
            }
        }
        #endregion
        
        public string physicalExerciseIDRef_ { get; set; }
        #region Premium_
        private CommodityPremium premium_;
        public CommodityPremium Premium_
        {
            get
            {
                if (this.premium_ != null)
                {
                    return this.premium_; 
                }
                else if (this.premiumIDRef_ != null)
                {
                    premium_ = IDManager.getID(premiumIDRef_) as CommodityPremium;
                    return this.premium_; 
                }
                else
                {
                      return this.premium_; 
                }
            }
            set
            {
                if (this.premium_ != value)
                {
                    this.premium_ = value;
                }
            }
        }
        #endregion
        
        public string premiumIDRef_ { get; set; }
        #region CommonPricing_
        private XsdTypeBoolean commonPricing_;
        public XsdTypeBoolean CommonPricing_
        {
            get
            {
                if (this.commonPricing_ != null)
                {
                    return this.commonPricing_; 
                }
                else if (this.commonPricingIDRef_ != null)
                {
                    commonPricing_ = IDManager.getID(commonPricingIDRef_) as XsdTypeBoolean;
                    return this.commonPricing_; 
                }
                else
                {
                      return this.commonPricing_; 
                }
            }
            set
            {
                if (this.commonPricing_ != value)
                {
                    this.commonPricing_ = value;
                }
            }
        }
        #endregion
        
        public string commonPricingIDRef_ { get; set; }
        #region MarketDisruption_
        private CommodityMarketDisruption marketDisruption_;
        public CommodityMarketDisruption MarketDisruption_
        {
            get
            {
                if (this.marketDisruption_ != null)
                {
                    return this.marketDisruption_; 
                }
                else if (this.marketDisruptionIDRef_ != null)
                {
                    marketDisruption_ = IDManager.getID(marketDisruptionIDRef_) as CommodityMarketDisruption;
                    return this.marketDisruption_; 
                }
                else
                {
                      return this.marketDisruption_; 
                }
            }
            set
            {
                if (this.marketDisruption_ != value)
                {
                    this.marketDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string marketDisruptionIDRef_ { get; set; }
        #region SettlementDisruption_
        private CommodityBullionSettlementDisruptionEnum settlementDisruption_;
        public CommodityBullionSettlementDisruptionEnum SettlementDisruption_
        {
            get
            {
                if (this.settlementDisruption_ != null)
                {
                    return this.settlementDisruption_; 
                }
                else if (this.settlementDisruptionIDRef_ != null)
                {
                    settlementDisruption_ = IDManager.getID(settlementDisruptionIDRef_) as CommodityBullionSettlementDisruptionEnum;
                    return this.settlementDisruption_; 
                }
                else
                {
                      return this.settlementDisruption_; 
                }
            }
            set
            {
                if (this.settlementDisruption_ != value)
                {
                    this.settlementDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDisruptionIDRef_ { get; set; }
        #region Rounding_
        private Rounding rounding_;
        public Rounding Rounding_
        {
            get
            {
                if (this.rounding_ != null)
                {
                    return this.rounding_; 
                }
                else if (this.roundingIDRef_ != null)
                {
                    rounding_ = IDManager.getID(roundingIDRef_) as Rounding;
                    return this.rounding_; 
                }
                else
                {
                      return this.rounding_; 
                }
            }
            set
            {
                if (this.rounding_ != value)
                {
                    this.rounding_ = value;
                }
            }
        }
        #endregion
        
        public string roundingIDRef_ { get; set; }
        
    
        
    
    }
    
}

