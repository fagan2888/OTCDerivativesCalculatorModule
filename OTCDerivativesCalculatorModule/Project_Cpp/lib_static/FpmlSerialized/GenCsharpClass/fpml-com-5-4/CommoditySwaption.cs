using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommoditySwaption
    {
        public CommoditySwaption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList buyerPartyReferenceNodeList = xmlNode.SelectNodes("buyerPartyReference");
            if (buyerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(buyerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList buyerAccountReferenceNodeList = xmlNode.SelectNodes("buyerAccountReference");
            if (buyerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(buyerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerPartyReferenceNodeList = xmlNode.SelectNodes("sellerPartyReference");
            if (sellerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(sellerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerAccountReferenceNodeList = xmlNode.SelectNodes("sellerAccountReference");
            if (sellerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(sellerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList optionTypeNodeList = xmlNode.SelectNodes("optionType");
            if (optionTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionTypeIDRef = item.Attributes["id"].Name;
                        PutCallEnum ob = PutCallEnum();
                        IDManager.SetID(optionTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionType = new PutCallEnum(item);
                    }
                }
            }
            
        
            XmlNodeList commoditySwapNodeList = xmlNode.SelectNodes("commoditySwap");
            if (commoditySwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commoditySwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commoditySwapIDRef = item.Attributes["id"].Name;
                        CommoditySwaptionUnderlying ob = CommoditySwaptionUnderlying();
                        IDManager.SetID(commoditySwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commoditySwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commoditySwap = new CommoditySwaptionUnderlying(item);
                    }
                }
            }
            
        
            XmlNodeList physicalExerciseNodeList = xmlNode.SelectNodes("physicalExercise");
            if (physicalExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalExerciseIDRef = item.Attributes["id"].Name;
                        CommodityPhysicalExercise ob = CommodityPhysicalExercise();
                        IDManager.SetID(physicalExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalExercise = new CommodityPhysicalExercise(item);
                    }
                }
            }
            
        
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            if (premiumNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in premiumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumIDRef = item.Attributes["id"].Name;
                        CommodityPremium ob = CommodityPremium();
                        IDManager.SetID(premiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        premium = new CommodityPremium(item);
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
        
    
        #region BuyerPartyReference
        private PartyReference buyerPartyReference;
        public PartyReference BuyerPartyReference
        {
            get
            {
                if (this.buyerPartyReference != null)
                {
                    return this.buyerPartyReference; 
                }
                else if (this.buyerPartyReferenceIDRef != null)
                {
                    buyerPartyReference = IDManager.getID(buyerPartyReferenceIDRef) as PartyReference;
                    return this.buyerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerPartyReference != value)
                {
                    this.buyerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region BuyerAccountReference
        private AccountReference buyerAccountReference;
        public AccountReference BuyerAccountReference
        {
            get
            {
                if (this.buyerAccountReference != null)
                {
                    return this.buyerAccountReference; 
                }
                else if (this.buyerAccountReferenceIDRef != null)
                {
                    buyerAccountReference = IDManager.getID(buyerAccountReferenceIDRef) as AccountReference;
                    return this.buyerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerAccountReference != value)
                {
                    this.buyerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region SellerPartyReference
        private PartyReference sellerPartyReference;
        public PartyReference SellerPartyReference
        {
            get
            {
                if (this.sellerPartyReference != null)
                {
                    return this.sellerPartyReference; 
                }
                else if (this.sellerPartyReferenceIDRef != null)
                {
                    sellerPartyReference = IDManager.getID(sellerPartyReferenceIDRef) as PartyReference;
                    return this.sellerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerPartyReference != value)
                {
                    this.sellerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region SellerAccountReference
        private AccountReference sellerAccountReference;
        public AccountReference SellerAccountReference
        {
            get
            {
                if (this.sellerAccountReference != null)
                {
                    return this.sellerAccountReference; 
                }
                else if (this.sellerAccountReferenceIDRef != null)
                {
                    sellerAccountReference = IDManager.getID(sellerAccountReferenceIDRef) as AccountReference;
                    return this.sellerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerAccountReference != value)
                {
                    this.sellerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region OptionType
        private PutCallEnum optionType;
        public PutCallEnum OptionType
        {
            get
            {
                if (this.optionType != null)
                {
                    return this.optionType; 
                }
                else if (this.optionTypeIDRef != null)
                {
                    optionType = IDManager.getID(optionTypeIDRef) as PutCallEnum;
                    return this.optionType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionType != value)
                {
                    this.optionType = value;
                }
            }
        }
        #endregion
        
        public string PutCallEnumIDRef { get; set; }
        #region CommoditySwap
        private CommoditySwaptionUnderlying commoditySwap;
        public CommoditySwaptionUnderlying CommoditySwap
        {
            get
            {
                if (this.commoditySwap != null)
                {
                    return this.commoditySwap; 
                }
                else if (this.commoditySwapIDRef != null)
                {
                    commoditySwap = IDManager.getID(commoditySwapIDRef) as CommoditySwaptionUnderlying;
                    return this.commoditySwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commoditySwap != value)
                {
                    this.commoditySwap = value;
                }
            }
        }
        #endregion
        
        public string CommoditySwaptionUnderlyingIDRef { get; set; }
        #region PhysicalExercise
        private CommodityPhysicalExercise physicalExercise;
        public CommodityPhysicalExercise PhysicalExercise
        {
            get
            {
                if (this.physicalExercise != null)
                {
                    return this.physicalExercise; 
                }
                else if (this.physicalExerciseIDRef != null)
                {
                    physicalExercise = IDManager.getID(physicalExerciseIDRef) as CommodityPhysicalExercise;
                    return this.physicalExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalExercise != value)
                {
                    this.physicalExercise = value;
                }
            }
        }
        #endregion
        
        public string CommodityPhysicalExerciseIDRef { get; set; }
        #region Premium
        private CommodityPremium premium;
        public CommodityPremium Premium
        {
            get
            {
                if (this.premium != null)
                {
                    return this.premium; 
                }
                else if (this.premiumIDRef != null)
                {
                    premium = IDManager.getID(premiumIDRef) as CommodityPremium;
                    return this.premium; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.premium != value)
                {
                    this.premium = value;
                }
            }
        }
        #endregion
        
        public string CommodityPremiumIDRef { get; set; }
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
        
    
        
    
    }
    
}

