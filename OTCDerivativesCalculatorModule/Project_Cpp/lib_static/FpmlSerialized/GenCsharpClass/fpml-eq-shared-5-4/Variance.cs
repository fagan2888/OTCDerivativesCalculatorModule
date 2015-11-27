using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Variance
    {
        public Variance(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList varianceAmountNodeList = xmlNode.SelectNodes("varianceAmount");
            if (varianceAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varianceAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(varianceAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varianceAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList volatilityStrikePriceNodeList = xmlNode.SelectNodes("volatilityStrikePrice");
            if (volatilityStrikePriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in volatilityStrikePriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        volatilityStrikePriceIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(volatilityStrikePriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        volatilityStrikePriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        volatilityStrikePrice = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList varianceStrikePriceNodeList = xmlNode.SelectNodes("varianceStrikePrice");
            if (varianceStrikePriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varianceStrikePriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceStrikePriceIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(varianceStrikePriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceStrikePriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varianceStrikePrice = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList varianceCapNodeList = xmlNode.SelectNodes("varianceCap");
            if (varianceCapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varianceCapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceCapIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(varianceCapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceCapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varianceCap = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList unadjustedVarianceCapNodeList = xmlNode.SelectNodes("unadjustedVarianceCap");
            if (unadjustedVarianceCapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedVarianceCapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedVarianceCapIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(unadjustedVarianceCapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedVarianceCapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedVarianceCap = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList boundedVarianceNodeList = xmlNode.SelectNodes("boundedVariance");
            if (boundedVarianceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in boundedVarianceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        boundedVarianceIDRef = item.Attributes["id"].Name;
                        BoundedVariance ob = BoundedVariance();
                        IDManager.SetID(boundedVarianceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        boundedVarianceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        boundedVariance = new BoundedVariance(item);
                    }
                }
            }
            
        
            XmlNodeList exchangeTradedContractNearestNodeList = xmlNode.SelectNodes("exchangeTradedContractNearest");
            if (exchangeTradedContractNearestNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeTradedContractNearestNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeTradedContractNearestIDRef = item.Attributes["id"].Name;
                        ExchangeTradedContract ob = ExchangeTradedContract();
                        IDManager.SetID(exchangeTradedContractNearestIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeTradedContractNearestIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeTradedContractNearest = new ExchangeTradedContract(item);
                    }
                }
            }
            
        
            XmlNodeList vegaNotionalAmountNodeList = xmlNode.SelectNodes("vegaNotionalAmount");
            if (vegaNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in vegaNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        vegaNotionalAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(vegaNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        vegaNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        vegaNotionalAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region VarianceAmount
        private NonNegativeMoney varianceAmount;
        public NonNegativeMoney VarianceAmount
        {
            get
            {
                if (this.varianceAmount != null)
                {
                    return this.varianceAmount; 
                }
                else if (this.varianceAmountIDRef != null)
                {
                    varianceAmount = IDManager.getID(varianceAmountIDRef) as NonNegativeMoney;
                    return this.varianceAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varianceAmount != value)
                {
                    this.varianceAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region VolatilityStrikePrice
        private NonNegativeDecimal volatilityStrikePrice;
        public NonNegativeDecimal VolatilityStrikePrice
        {
            get
            {
                if (this.volatilityStrikePrice != null)
                {
                    return this.volatilityStrikePrice; 
                }
                else if (this.volatilityStrikePriceIDRef != null)
                {
                    volatilityStrikePrice = IDManager.getID(volatilityStrikePriceIDRef) as NonNegativeDecimal;
                    return this.volatilityStrikePrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.volatilityStrikePrice != value)
                {
                    this.volatilityStrikePrice = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region VarianceStrikePrice
        private NonNegativeDecimal varianceStrikePrice;
        public NonNegativeDecimal VarianceStrikePrice
        {
            get
            {
                if (this.varianceStrikePrice != null)
                {
                    return this.varianceStrikePrice; 
                }
                else if (this.varianceStrikePriceIDRef != null)
                {
                    varianceStrikePrice = IDManager.getID(varianceStrikePriceIDRef) as NonNegativeDecimal;
                    return this.varianceStrikePrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varianceStrikePrice != value)
                {
                    this.varianceStrikePrice = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region VarianceCap
        private XsdTypeBoolean varianceCap;
        public XsdTypeBoolean VarianceCap
        {
            get
            {
                if (this.varianceCap != null)
                {
                    return this.varianceCap; 
                }
                else if (this.varianceCapIDRef != null)
                {
                    varianceCap = IDManager.getID(varianceCapIDRef) as XsdTypeBoolean;
                    return this.varianceCap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varianceCap != value)
                {
                    this.varianceCap = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region UnadjustedVarianceCap
        private PositiveDecimal unadjustedVarianceCap;
        public PositiveDecimal UnadjustedVarianceCap
        {
            get
            {
                if (this.unadjustedVarianceCap != null)
                {
                    return this.unadjustedVarianceCap; 
                }
                else if (this.unadjustedVarianceCapIDRef != null)
                {
                    unadjustedVarianceCap = IDManager.getID(unadjustedVarianceCapIDRef) as PositiveDecimal;
                    return this.unadjustedVarianceCap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedVarianceCap != value)
                {
                    this.unadjustedVarianceCap = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region BoundedVariance
        private BoundedVariance boundedVariance;
        public BoundedVariance BoundedVariance
        {
            get
            {
                if (this.boundedVariance != null)
                {
                    return this.boundedVariance; 
                }
                else if (this.boundedVarianceIDRef != null)
                {
                    boundedVariance = IDManager.getID(boundedVarianceIDRef) as BoundedVariance;
                    return this.boundedVariance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.boundedVariance != value)
                {
                    this.boundedVariance = value;
                }
            }
        }
        #endregion
        
        public string BoundedVarianceIDRef { get; set; }
        #region ExchangeTradedContractNearest
        private ExchangeTradedContract exchangeTradedContractNearest;
        public ExchangeTradedContract ExchangeTradedContractNearest
        {
            get
            {
                if (this.exchangeTradedContractNearest != null)
                {
                    return this.exchangeTradedContractNearest; 
                }
                else if (this.exchangeTradedContractNearestIDRef != null)
                {
                    exchangeTradedContractNearest = IDManager.getID(exchangeTradedContractNearestIDRef) as ExchangeTradedContract;
                    return this.exchangeTradedContractNearest; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeTradedContractNearest != value)
                {
                    this.exchangeTradedContractNearest = value;
                }
            }
        }
        #endregion
        
        public string ExchangeTradedContractIDRef { get; set; }
        #region VegaNotionalAmount
        private XsdTypeDecimal vegaNotionalAmount;
        public XsdTypeDecimal VegaNotionalAmount
        {
            get
            {
                if (this.vegaNotionalAmount != null)
                {
                    return this.vegaNotionalAmount; 
                }
                else if (this.vegaNotionalAmountIDRef != null)
                {
                    vegaNotionalAmount = IDManager.getID(vegaNotionalAmountIDRef) as XsdTypeDecimal;
                    return this.vegaNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.vegaNotionalAmount != value)
                {
                    this.vegaNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

