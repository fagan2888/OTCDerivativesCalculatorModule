using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityForward : Product
    {
        public CommodityForward(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode valueDateNode = xmlNode.SelectSingleNode("valueDate");
            
            if (valueDateNode != null)
            {
                if (valueDateNode.Attributes["href"] != null || valueDateNode.Attributes["id"] != null) 
                {
                    if (valueDateNode.Attributes["id"] != null) 
                    {
                        valueDateIDRef_ = valueDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(valueDateNode);
                        IDManager.SetID(valueDateIDRef_, ob);
                    }
                    else if (valueDateNode.Attributes["href"] != null)
                    {
                        valueDateIDRef_ = valueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valueDate_ = new AdjustableOrRelativeDate(valueDateNode);
                    }
                }
                else
                {
                    valueDate_ = new AdjustableOrRelativeDate(valueDateNode);
                }
            }
            
        
            XmlNode fixedLegNode = xmlNode.SelectSingleNode("fixedLeg");
            
            if (fixedLegNode != null)
            {
                if (fixedLegNode.Attributes["href"] != null || fixedLegNode.Attributes["id"] != null) 
                {
                    if (fixedLegNode.Attributes["id"] != null) 
                    {
                        fixedLegIDRef_ = fixedLegNode.Attributes["id"].Value;
                        NonPeriodicFixedPriceLeg ob = new NonPeriodicFixedPriceLeg(fixedLegNode);
                        IDManager.SetID(fixedLegIDRef_, ob);
                    }
                    else if (fixedLegNode.Attributes["href"] != null)
                    {
                        fixedLegIDRef_ = fixedLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedLeg_ = new NonPeriodicFixedPriceLeg(fixedLegNode);
                    }
                }
                else
                {
                    fixedLeg_ = new NonPeriodicFixedPriceLeg(fixedLegNode);
                }
            }
            
        
            XmlNode averagePriceLegNode = xmlNode.SelectSingleNode("averagePriceLeg");
            
            if (averagePriceLegNode != null)
            {
                if (averagePriceLegNode.Attributes["href"] != null || averagePriceLegNode.Attributes["id"] != null) 
                {
                    if (averagePriceLegNode.Attributes["id"] != null) 
                    {
                        averagePriceLegIDRef_ = averagePriceLegNode.Attributes["id"].Value;
                        AveragePriceLeg ob = new AveragePriceLeg(averagePriceLegNode);
                        IDManager.SetID(averagePriceLegIDRef_, ob);
                    }
                    else if (averagePriceLegNode.Attributes["href"] != null)
                    {
                        averagePriceLegIDRef_ = averagePriceLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagePriceLeg_ = new AveragePriceLeg(averagePriceLegNode);
                    }
                }
                else
                {
                    averagePriceLeg_ = new AveragePriceLeg(averagePriceLegNode);
                }
            }
            
        
            XmlNode commodityForwardLegNode = xmlNode.SelectSingleNode("commodityForwardLeg");
            
            if (commodityForwardLegNode != null)
            {
                if (commodityForwardLegNode.Attributes["href"] != null || commodityForwardLegNode.Attributes["id"] != null) 
                {
                    if (commodityForwardLegNode.Attributes["id"] != null) 
                    {
                        commodityForwardLegIDRef_ = commodityForwardLegNode.Attributes["id"].Value;
                        CommodityForwardLeg ob = new CommodityForwardLeg(commodityForwardLegNode);
                        IDManager.SetID(commodityForwardLegIDRef_, ob);
                    }
                    else if (commodityForwardLegNode.Attributes["href"] != null)
                    {
                        commodityForwardLegIDRef_ = commodityForwardLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodityForwardLeg_ = new CommodityForwardLeg(commodityForwardLegNode);
                    }
                }
                else
                {
                    commodityForwardLeg_ = new CommodityForwardLeg(commodityForwardLegNode);
                }
            }
            
        
            XmlNode bullionPhysicalLegNode = xmlNode.SelectSingleNode("bullionPhysicalLeg");
            
            if (bullionPhysicalLegNode != null)
            {
                if (bullionPhysicalLegNode.Attributes["href"] != null || bullionPhysicalLegNode.Attributes["id"] != null) 
                {
                    if (bullionPhysicalLegNode.Attributes["id"] != null) 
                    {
                        bullionPhysicalLegIDRef_ = bullionPhysicalLegNode.Attributes["id"].Value;
                        BullionPhysicalLeg ob = new BullionPhysicalLeg(bullionPhysicalLegNode);
                        IDManager.SetID(bullionPhysicalLegIDRef_, ob);
                    }
                    else if (bullionPhysicalLegNode.Attributes["href"] != null)
                    {
                        bullionPhysicalLegIDRef_ = bullionPhysicalLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bullionPhysicalLeg_ = new BullionPhysicalLeg(bullionPhysicalLegNode);
                    }
                }
                else
                {
                    bullionPhysicalLeg_ = new BullionPhysicalLeg(bullionPhysicalLegNode);
                }
            }
            
        
            XmlNode metalPhysicalLegNode = xmlNode.SelectSingleNode("metalPhysicalLeg");
            
            if (metalPhysicalLegNode != null)
            {
                if (metalPhysicalLegNode.Attributes["href"] != null || metalPhysicalLegNode.Attributes["id"] != null) 
                {
                    if (metalPhysicalLegNode.Attributes["id"] != null) 
                    {
                        metalPhysicalLegIDRef_ = metalPhysicalLegNode.Attributes["id"].Value;
                        MetalPhysicalLeg ob = new MetalPhysicalLeg(metalPhysicalLegNode);
                        IDManager.SetID(metalPhysicalLegIDRef_, ob);
                    }
                    else if (metalPhysicalLegNode.Attributes["href"] != null)
                    {
                        metalPhysicalLegIDRef_ = metalPhysicalLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        metalPhysicalLeg_ = new MetalPhysicalLeg(metalPhysicalLegNode);
                    }
                }
                else
                {
                    metalPhysicalLeg_ = new MetalPhysicalLeg(metalPhysicalLegNode);
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
        
    
        #region ValueDate_
        private AdjustableOrRelativeDate valueDate_;
        public AdjustableOrRelativeDate ValueDate_
        {
            get
            {
                if (this.valueDate_ != null)
                {
                    return this.valueDate_; 
                }
                else if (this.valueDateIDRef_ != null)
                {
                    valueDate_ = IDManager.getID(valueDateIDRef_) as AdjustableOrRelativeDate;
                    return this.valueDate_; 
                }
                else
                {
                      return this.valueDate_; 
                }
            }
            set
            {
                if (this.valueDate_ != value)
                {
                    this.valueDate_ = value;
                }
            }
        }
        #endregion
        
        public string valueDateIDRef_ { get; set; }
        #region FixedLeg_
        private NonPeriodicFixedPriceLeg fixedLeg_;
        public NonPeriodicFixedPriceLeg FixedLeg_
        {
            get
            {
                if (this.fixedLeg_ != null)
                {
                    return this.fixedLeg_; 
                }
                else if (this.fixedLegIDRef_ != null)
                {
                    fixedLeg_ = IDManager.getID(fixedLegIDRef_) as NonPeriodicFixedPriceLeg;
                    return this.fixedLeg_; 
                }
                else
                {
                      return this.fixedLeg_; 
                }
            }
            set
            {
                if (this.fixedLeg_ != value)
                {
                    this.fixedLeg_ = value;
                }
            }
        }
        #endregion
        
        public string fixedLegIDRef_ { get; set; }
        #region AveragePriceLeg_
        private AveragePriceLeg averagePriceLeg_;
        public AveragePriceLeg AveragePriceLeg_
        {
            get
            {
                if (this.averagePriceLeg_ != null)
                {
                    return this.averagePriceLeg_; 
                }
                else if (this.averagePriceLegIDRef_ != null)
                {
                    averagePriceLeg_ = IDManager.getID(averagePriceLegIDRef_) as AveragePriceLeg;
                    return this.averagePriceLeg_; 
                }
                else
                {
                      return this.averagePriceLeg_; 
                }
            }
            set
            {
                if (this.averagePriceLeg_ != value)
                {
                    this.averagePriceLeg_ = value;
                }
            }
        }
        #endregion
        
        public string averagePriceLegIDRef_ { get; set; }
        #region CommodityForwardLeg_
        private CommodityForwardLeg commodityForwardLeg_;
        public CommodityForwardLeg CommodityForwardLeg_
        {
            get
            {
                if (this.commodityForwardLeg_ != null)
                {
                    return this.commodityForwardLeg_; 
                }
                else if (this.commodityForwardLegIDRef_ != null)
                {
                    commodityForwardLeg_ = IDManager.getID(commodityForwardLegIDRef_) as CommodityForwardLeg;
                    return this.commodityForwardLeg_; 
                }
                else
                {
                      return this.commodityForwardLeg_; 
                }
            }
            set
            {
                if (this.commodityForwardLeg_ != value)
                {
                    this.commodityForwardLeg_ = value;
                }
            }
        }
        #endregion
        
        public string commodityForwardLegIDRef_ { get; set; }
        #region BullionPhysicalLeg_
        private BullionPhysicalLeg bullionPhysicalLeg_;
        public BullionPhysicalLeg BullionPhysicalLeg_
        {
            get
            {
                if (this.bullionPhysicalLeg_ != null)
                {
                    return this.bullionPhysicalLeg_; 
                }
                else if (this.bullionPhysicalLegIDRef_ != null)
                {
                    bullionPhysicalLeg_ = IDManager.getID(bullionPhysicalLegIDRef_) as BullionPhysicalLeg;
                    return this.bullionPhysicalLeg_; 
                }
                else
                {
                      return this.bullionPhysicalLeg_; 
                }
            }
            set
            {
                if (this.bullionPhysicalLeg_ != value)
                {
                    this.bullionPhysicalLeg_ = value;
                }
            }
        }
        #endregion
        
        public string bullionPhysicalLegIDRef_ { get; set; }     // substitude
        #region MetalPhysicalLeg_
        private MetalPhysicalLeg metalPhysicalLeg_;
        public MetalPhysicalLeg MetalPhysicalLeg_
        {
            get
            {
                if (this.metalPhysicalLeg_ != null)
                {
                    return this.metalPhysicalLeg_; 
                }
                else if (this.metalPhysicalLegIDRef_ != null)
                {
                    metalPhysicalLeg_ = IDManager.getID(metalPhysicalLegIDRef_) as MetalPhysicalLeg;
                    return this.metalPhysicalLeg_; 
                }
                else
                {
                      return this.metalPhysicalLeg_; 
                }
            }
            set
            {
                if (this.metalPhysicalLeg_ != value)
                {
                    this.metalPhysicalLeg_ = value;
                }
            }
        }
        #endregion
        
        public string metalPhysicalLegIDRef_ { get; set; }     // substitude
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

