using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityDerivativeBase
    {
        public EquityDerivativeBase(XmlNode xmlNode)
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
                        EquityOptionTypeEnum ob = EquityOptionTypeEnum();
                        IDManager.SetID(optionTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionType = new EquityOptionTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList equityEffectiveDateNodeList = xmlNode.SelectNodes("equityEffectiveDate");
            if (equityEffectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityEffectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityEffectiveDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(equityEffectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityEffectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityEffectiveDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList underlyerNodeList = xmlNode.SelectNodes("underlyer");
            if (underlyerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyerIDRef = item.Attributes["id"].Name;
                        Underlyer ob = Underlyer();
                        IDManager.SetID(underlyerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyer = new Underlyer(item);
                    }
                }
            }
            
        
            XmlNodeList notionalNodeList = xmlNode.SelectNodes("notional");
            if (notionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(notionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notional = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList equityExerciseNodeList = xmlNode.SelectNodes("equityExercise");
            if (equityExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityExerciseIDRef = item.Attributes["id"].Name;
                        EquityExerciseValuationSettlement ob = EquityExerciseValuationSettlement();
                        IDManager.SetID(equityExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityExercise = new EquityExerciseValuationSettlement(item);
                    }
                }
            }
            
        
            XmlNodeList featureNodeList = xmlNode.SelectNodes("feature");
            if (featureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in featureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        featureIDRef = item.Attributes["id"].Name;
                        OptionFeatures ob = OptionFeatures();
                        IDManager.SetID(featureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        featureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        feature = new OptionFeatures(item);
                    }
                }
            }
            
        
            XmlNodeList fxFeatureNodeList = xmlNode.SelectNodes("fxFeature");
            if (fxFeatureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxFeatureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxFeatureIDRef = item.Attributes["id"].Name;
                        FxFeature ob = FxFeature();
                        IDManager.SetID(fxFeatureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxFeatureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxFeature = new FxFeature(item);
                    }
                }
            }
            
        
            XmlNodeList strategyFeatureNodeList = xmlNode.SelectNodes("strategyFeature");
            if (strategyFeatureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strategyFeatureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strategyFeatureIDRef = item.Attributes["id"].Name;
                        StrategyFeature ob = StrategyFeature();
                        IDManager.SetID(strategyFeatureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strategyFeatureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strategyFeature = new StrategyFeature(item);
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
        private EquityOptionTypeEnum optionType;
        public EquityOptionTypeEnum OptionType
        {
            get
            {
                if (this.optionType != null)
                {
                    return this.optionType; 
                }
                else if (this.optionTypeIDRef != null)
                {
                    optionType = IDManager.getID(optionTypeIDRef) as EquityOptionTypeEnum;
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
        
        public string EquityOptionTypeEnumIDRef { get; set; }
        #region EquityEffectiveDate
        private XsdTypeDate equityEffectiveDate;
        public XsdTypeDate EquityEffectiveDate
        {
            get
            {
                if (this.equityEffectiveDate != null)
                {
                    return this.equityEffectiveDate; 
                }
                else if (this.equityEffectiveDateIDRef != null)
                {
                    equityEffectiveDate = IDManager.getID(equityEffectiveDateIDRef) as XsdTypeDate;
                    return this.equityEffectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityEffectiveDate != value)
                {
                    this.equityEffectiveDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Underlyer
        private Underlyer underlyer;
        public Underlyer Underlyer
        {
            get
            {
                if (this.underlyer != null)
                {
                    return this.underlyer; 
                }
                else if (this.underlyerIDRef != null)
                {
                    underlyer = IDManager.getID(underlyerIDRef) as Underlyer;
                    return this.underlyer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyer != value)
                {
                    this.underlyer = value;
                }
            }
        }
        #endregion
        
        public string UnderlyerIDRef { get; set; }
        #region Notional
        private NonNegativeMoney notional;
        public NonNegativeMoney Notional
        {
            get
            {
                if (this.notional != null)
                {
                    return this.notional; 
                }
                else if (this.notionalIDRef != null)
                {
                    notional = IDManager.getID(notionalIDRef) as NonNegativeMoney;
                    return this.notional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notional != value)
                {
                    this.notional = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region EquityExercise
        private EquityExerciseValuationSettlement equityExercise;
        public EquityExerciseValuationSettlement EquityExercise
        {
            get
            {
                if (this.equityExercise != null)
                {
                    return this.equityExercise; 
                }
                else if (this.equityExerciseIDRef != null)
                {
                    equityExercise = IDManager.getID(equityExerciseIDRef) as EquityExerciseValuationSettlement;
                    return this.equityExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityExercise != value)
                {
                    this.equityExercise = value;
                }
            }
        }
        #endregion
        
        public string EquityExerciseValuationSettlementIDRef { get; set; }
        #region Feature
        private OptionFeatures feature;
        public OptionFeatures Feature
        {
            get
            {
                if (this.feature != null)
                {
                    return this.feature; 
                }
                else if (this.featureIDRef != null)
                {
                    feature = IDManager.getID(featureIDRef) as OptionFeatures;
                    return this.feature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.feature != value)
                {
                    this.feature = value;
                }
            }
        }
        #endregion
        
        public string OptionFeaturesIDRef { get; set; }
        #region FxFeature
        private FxFeature fxFeature;
        public FxFeature FxFeature
        {
            get
            {
                if (this.fxFeature != null)
                {
                    return this.fxFeature; 
                }
                else if (this.fxFeatureIDRef != null)
                {
                    fxFeature = IDManager.getID(fxFeatureIDRef) as FxFeature;
                    return this.fxFeature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxFeature != value)
                {
                    this.fxFeature = value;
                }
            }
        }
        #endregion
        
        public string FxFeatureIDRef { get; set; }
        #region StrategyFeature
        private StrategyFeature strategyFeature;
        public StrategyFeature StrategyFeature
        {
            get
            {
                if (this.strategyFeature != null)
                {
                    return this.strategyFeature; 
                }
                else if (this.strategyFeatureIDRef != null)
                {
                    strategyFeature = IDManager.getID(strategyFeatureIDRef) as StrategyFeature;
                    return this.strategyFeature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strategyFeature != value)
                {
                    this.strategyFeature = value;
                }
            }
        }
        #endregion
        
        public string StrategyFeatureIDRef { get; set; }
        
    
        
    
    }
    
}

