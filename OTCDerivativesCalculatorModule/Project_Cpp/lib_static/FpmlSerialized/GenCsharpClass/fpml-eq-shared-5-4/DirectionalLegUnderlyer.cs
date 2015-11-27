using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DirectionalLegUnderlyer
    {
        public DirectionalLegUnderlyer(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNodeList settlementTypeNodeList = xmlNode.SelectNodes("settlementType");
            if (settlementTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementTypeIDRef = item.Attributes["id"].Name;
                        SettlementTypeEnum ob = SettlementTypeEnum();
                        IDManager.SetID(settlementTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementType = new SettlementTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList settlementDateNodeList = xmlNode.SelectNodes("settlementDate");
            if (settlementDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(settlementDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList settlementAmountNodeList = xmlNode.SelectNodes("settlementAmount");
            if (settlementAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(settlementAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList settlementCurrencyNodeList = xmlNode.SelectNodes("settlementCurrency");
            if (settlementCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(settlementCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementCurrency = new Currency(item);
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
            
        
        }
        
    
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
        #region SettlementType
        private SettlementTypeEnum settlementType;
        public SettlementTypeEnum SettlementType
        {
            get
            {
                if (this.settlementType != null)
                {
                    return this.settlementType; 
                }
                else if (this.settlementTypeIDRef != null)
                {
                    settlementType = IDManager.getID(settlementTypeIDRef) as SettlementTypeEnum;
                    return this.settlementType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementType != value)
                {
                    this.settlementType = value;
                }
            }
        }
        #endregion
        
        public string SettlementTypeEnumIDRef { get; set; }
        #region SettlementDate
        private AdjustableOrRelativeDate settlementDate;
        public AdjustableOrRelativeDate SettlementDate
        {
            get
            {
                if (this.settlementDate != null)
                {
                    return this.settlementDate; 
                }
                else if (this.settlementDateIDRef != null)
                {
                    settlementDate = IDManager.getID(settlementDateIDRef) as AdjustableOrRelativeDate;
                    return this.settlementDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementDate != value)
                {
                    this.settlementDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region SettlementAmount
        private Money settlementAmount;
        public Money SettlementAmount
        {
            get
            {
                if (this.settlementAmount != null)
                {
                    return this.settlementAmount; 
                }
                else if (this.settlementAmountIDRef != null)
                {
                    settlementAmount = IDManager.getID(settlementAmountIDRef) as Money;
                    return this.settlementAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementAmount != value)
                {
                    this.settlementAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region SettlementCurrency
        private Currency settlementCurrency;
        public Currency SettlementCurrency
        {
            get
            {
                if (this.settlementCurrency != null)
                {
                    return this.settlementCurrency; 
                }
                else if (this.settlementCurrencyIDRef != null)
                {
                    settlementCurrency = IDManager.getID(settlementCurrencyIDRef) as Currency;
                    return this.settlementCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementCurrency != value)
                {
                    this.settlementCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

