using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityForward
    {
        public CommodityForward(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList valueDateNodeList = xmlNode.SelectNodes("valueDate");
            if (valueDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valueDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valueDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(valueDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valueDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valueDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList fixedLegNodeList = xmlNode.SelectNodes("fixedLeg");
            if (fixedLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedLegIDRef = item.Attributes["id"].Name;
                        NonPeriodicFixedPriceLeg ob = NonPeriodicFixedPriceLeg();
                        IDManager.SetID(fixedLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedLeg = new NonPeriodicFixedPriceLeg(item);
                    }
                }
            }
            
        
            XmlNodeList averagePriceLegNodeList = xmlNode.SelectNodes("averagePriceLeg");
            if (averagePriceLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagePriceLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagePriceLegIDRef = item.Attributes["id"].Name;
                        AveragePriceLeg ob = AveragePriceLeg();
                        IDManager.SetID(averagePriceLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagePriceLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagePriceLeg = new AveragePriceLeg(item);
                    }
                }
            }
            
        
            XmlNodeList commodityForwardLegNodeList = xmlNode.SelectNodes("commodityForwardLeg");
            if (commodityForwardLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commodityForwardLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commodityForwardLegIDRef = item.Attributes["id"].Name;
                        CommodityForwardLeg ob = CommodityForwardLeg();
                        IDManager.SetID(commodityForwardLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commodityForwardLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commodityForwardLeg = new CommodityForwardLeg(item);
                    }
                }
            }
            
        
            XmlNodeList bullionPhysicalLegNodeList = xmlNode.SelectNodes("bullionPhysicalLeg");
            if (bullionPhysicalLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bullionPhysicalLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bullionPhysicalLegIDRef = item.Attributes["id"].Name;
                        BullionPhysicalLeg ob = BullionPhysicalLeg();
                        IDManager.SetID(bullionPhysicalLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bullionPhysicalLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bullionPhysicalLeg = new BullionPhysicalLeg(item);
                    }
                }
            }
            
        
            XmlNodeList metalPhysicalLegNodeList = xmlNode.SelectNodes("metalPhysicalLeg");
            if (metalPhysicalLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in metalPhysicalLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        metalPhysicalLegIDRef = item.Attributes["id"].Name;
                        MetalPhysicalLeg ob = MetalPhysicalLeg();
                        IDManager.SetID(metalPhysicalLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        metalPhysicalLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        metalPhysicalLeg = new MetalPhysicalLeg(item);
                    }
                }
            }
            
        
            XmlNodeList commonPricingNodeList = xmlNode.SelectNodes("commonPricing");
            if (commonPricingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commonPricingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commonPricingIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(commonPricingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commonPricingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commonPricing = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList marketDisruptionNodeList = xmlNode.SelectNodes("marketDisruption");
            if (marketDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in marketDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketDisruptionIDRef = item.Attributes["id"].Name;
                        CommodityMarketDisruption ob = CommodityMarketDisruption();
                        IDManager.SetID(marketDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        marketDisruption = new CommodityMarketDisruption(item);
                    }
                }
            }
            
        
            XmlNodeList settlementDisruptionNodeList = xmlNode.SelectNodes("settlementDisruption");
            if (settlementDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementDisruptionIDRef = item.Attributes["id"].Name;
                        CommodityBullionSettlementDisruptionEnum ob = CommodityBullionSettlementDisruptionEnum();
                        IDManager.SetID(settlementDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementDisruption = new CommodityBullionSettlementDisruptionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList roundingNodeList = xmlNode.SelectNodes("rounding");
            if (roundingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in roundingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        roundingIDRef = item.Attributes["id"].Name;
                        Rounding ob = Rounding();
                        IDManager.SetID(roundingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        roundingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rounding = new Rounding(item);
                    }
                }
            }
            
        
        }
        
    
        #region ValueDate
        private AdjustableOrRelativeDate valueDate;
        public AdjustableOrRelativeDate ValueDate
        {
            get
            {
                if (this.valueDate != null)
                {
                    return this.valueDate; 
                }
                else if (this.valueDateIDRef != null)
                {
                    valueDate = IDManager.getID(valueDateIDRef) as AdjustableOrRelativeDate;
                    return this.valueDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valueDate != value)
                {
                    this.valueDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region FixedLeg
        private NonPeriodicFixedPriceLeg fixedLeg;
        public NonPeriodicFixedPriceLeg FixedLeg
        {
            get
            {
                if (this.fixedLeg != null)
                {
                    return this.fixedLeg; 
                }
                else if (this.fixedLegIDRef != null)
                {
                    fixedLeg = IDManager.getID(fixedLegIDRef) as NonPeriodicFixedPriceLeg;
                    return this.fixedLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedLeg != value)
                {
                    this.fixedLeg = value;
                }
            }
        }
        #endregion
        
        public string NonPeriodicFixedPriceLegIDRef { get; set; }
        #region AveragePriceLeg
        private AveragePriceLeg averagePriceLeg;
        public AveragePriceLeg AveragePriceLeg
        {
            get
            {
                if (this.averagePriceLeg != null)
                {
                    return this.averagePriceLeg; 
                }
                else if (this.averagePriceLegIDRef != null)
                {
                    averagePriceLeg = IDManager.getID(averagePriceLegIDRef) as AveragePriceLeg;
                    return this.averagePriceLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagePriceLeg != value)
                {
                    this.averagePriceLeg = value;
                }
            }
        }
        #endregion
        
        public string AveragePriceLegIDRef { get; set; }
        #region CommodityForwardLeg
        private CommodityForwardLeg commodityForwardLeg;
        public CommodityForwardLeg CommodityForwardLeg
        {
            get
            {
                if (this.commodityForwardLeg != null)
                {
                    return this.commodityForwardLeg; 
                }
                else if (this.commodityForwardLegIDRef != null)
                {
                    commodityForwardLeg = IDManager.getID(commodityForwardLegIDRef) as CommodityForwardLeg;
                    return this.commodityForwardLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commodityForwardLeg != value)
                {
                    this.commodityForwardLeg = value;
                }
            }
        }
        #endregion
        
        public string CommodityForwardLegIDRef { get; set; }
        #region BullionPhysicalLeg
        private BullionPhysicalLeg bullionPhysicalLeg;
        public BullionPhysicalLeg BullionPhysicalLeg
        {
            get
            {
                if (this.bullionPhysicalLeg != null)
                {
                    return this.bullionPhysicalLeg; 
                }
                else if (this.bullionPhysicalLegIDRef != null)
                {
                    bullionPhysicalLeg = IDManager.getID(bullionPhysicalLegIDRef) as BullionPhysicalLeg;
                    return this.bullionPhysicalLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bullionPhysicalLeg != value)
                {
                    this.bullionPhysicalLeg = value;
                }
            }
        }
        #endregion
        
        public string BullionPhysicalLegIDRef { get; set; }     // substitude
        #region MetalPhysicalLeg
        private MetalPhysicalLeg metalPhysicalLeg;
        public MetalPhysicalLeg MetalPhysicalLeg
        {
            get
            {
                if (this.metalPhysicalLeg != null)
                {
                    return this.metalPhysicalLeg; 
                }
                else if (this.metalPhysicalLegIDRef != null)
                {
                    metalPhysicalLeg = IDManager.getID(metalPhysicalLegIDRef) as MetalPhysicalLeg;
                    return this.metalPhysicalLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.metalPhysicalLeg != value)
                {
                    this.metalPhysicalLeg = value;
                }
            }
        }
        #endregion
        
        public string MetalPhysicalLegIDRef { get; set; }     // substitude
        #region CommonPricing
        private XsdTypeBoolean commonPricing;
        public XsdTypeBoolean CommonPricing
        {
            get
            {
                if (this.commonPricing != null)
                {
                    return this.commonPricing; 
                }
                else if (this.commonPricingIDRef != null)
                {
                    commonPricing = IDManager.getID(commonPricingIDRef) as XsdTypeBoolean;
                    return this.commonPricing; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commonPricing != value)
                {
                    this.commonPricing = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MarketDisruption
        private CommodityMarketDisruption marketDisruption;
        public CommodityMarketDisruption MarketDisruption
        {
            get
            {
                if (this.marketDisruption != null)
                {
                    return this.marketDisruption; 
                }
                else if (this.marketDisruptionIDRef != null)
                {
                    marketDisruption = IDManager.getID(marketDisruptionIDRef) as CommodityMarketDisruption;
                    return this.marketDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.marketDisruption != value)
                {
                    this.marketDisruption = value;
                }
            }
        }
        #endregion
        
        public string CommodityMarketDisruptionIDRef { get; set; }
        #region SettlementDisruption
        private CommodityBullionSettlementDisruptionEnum settlementDisruption;
        public CommodityBullionSettlementDisruptionEnum SettlementDisruption
        {
            get
            {
                if (this.settlementDisruption != null)
                {
                    return this.settlementDisruption; 
                }
                else if (this.settlementDisruptionIDRef != null)
                {
                    settlementDisruption = IDManager.getID(settlementDisruptionIDRef) as CommodityBullionSettlementDisruptionEnum;
                    return this.settlementDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementDisruption != value)
                {
                    this.settlementDisruption = value;
                }
            }
        }
        #endregion
        
        public string CommodityBullionSettlementDisruptionEnumIDRef { get; set; }
        #region Rounding
        private Rounding rounding;
        public Rounding Rounding
        {
            get
            {
                if (this.rounding != null)
                {
                    return this.rounding; 
                }
                else if (this.roundingIDRef != null)
                {
                    rounding = IDManager.getID(roundingIDRef) as Rounding;
                    return this.rounding; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rounding != value)
                {
                    this.rounding = value;
                }
            }
        }
        #endregion
        
        public string RoundingIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

