using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Variance : CalculationFromObservation
    {
        public Variance(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode varianceAmountNode = xmlNode.SelectSingleNode("varianceAmount");
            
            if (varianceAmountNode != null)
            {
                if (varianceAmountNode.Attributes["href"] != null || varianceAmountNode.Attributes["id"] != null) 
                {
                    if (varianceAmountNode.Attributes["id"] != null) 
                    {
                        varianceAmountIDRef_ = varianceAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(varianceAmountNode);
                        IDManager.SetID(varianceAmountIDRef_, ob);
                    }
                    else if (varianceAmountNode.Attributes["href"] != null)
                    {
                        varianceAmountIDRef_ = varianceAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varianceAmount_ = new NonNegativeMoney(varianceAmountNode);
                    }
                }
                else
                {
                    varianceAmount_ = new NonNegativeMoney(varianceAmountNode);
                }
            }
            
        
            XmlNode volatilityStrikePriceNode = xmlNode.SelectSingleNode("volatilityStrikePrice");
            
            if (volatilityStrikePriceNode != null)
            {
                if (volatilityStrikePriceNode.Attributes["href"] != null || volatilityStrikePriceNode.Attributes["id"] != null) 
                {
                    if (volatilityStrikePriceNode.Attributes["id"] != null) 
                    {
                        volatilityStrikePriceIDRef_ = volatilityStrikePriceNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(volatilityStrikePriceNode);
                        IDManager.SetID(volatilityStrikePriceIDRef_, ob);
                    }
                    else if (volatilityStrikePriceNode.Attributes["href"] != null)
                    {
                        volatilityStrikePriceIDRef_ = volatilityStrikePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        volatilityStrikePrice_ = new NonNegativeDecimal(volatilityStrikePriceNode);
                    }
                }
                else
                {
                    volatilityStrikePrice_ = new NonNegativeDecimal(volatilityStrikePriceNode);
                }
            }
            
        
            XmlNode varianceStrikePriceNode = xmlNode.SelectSingleNode("varianceStrikePrice");
            
            if (varianceStrikePriceNode != null)
            {
                if (varianceStrikePriceNode.Attributes["href"] != null || varianceStrikePriceNode.Attributes["id"] != null) 
                {
                    if (varianceStrikePriceNode.Attributes["id"] != null) 
                    {
                        varianceStrikePriceIDRef_ = varianceStrikePriceNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(varianceStrikePriceNode);
                        IDManager.SetID(varianceStrikePriceIDRef_, ob);
                    }
                    else if (varianceStrikePriceNode.Attributes["href"] != null)
                    {
                        varianceStrikePriceIDRef_ = varianceStrikePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varianceStrikePrice_ = new NonNegativeDecimal(varianceStrikePriceNode);
                    }
                }
                else
                {
                    varianceStrikePrice_ = new NonNegativeDecimal(varianceStrikePriceNode);
                }
            }
            
        
            XmlNode varianceCapNode = xmlNode.SelectSingleNode("varianceCap");
            
            if (varianceCapNode != null)
            {
                if (varianceCapNode.Attributes["href"] != null || varianceCapNode.Attributes["id"] != null) 
                {
                    if (varianceCapNode.Attributes["id"] != null) 
                    {
                        varianceCapIDRef_ = varianceCapNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(varianceCapNode);
                        IDManager.SetID(varianceCapIDRef_, ob);
                    }
                    else if (varianceCapNode.Attributes["href"] != null)
                    {
                        varianceCapIDRef_ = varianceCapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varianceCap_ = new XsdTypeBoolean(varianceCapNode);
                    }
                }
                else
                {
                    varianceCap_ = new XsdTypeBoolean(varianceCapNode);
                }
            }
            
        
            XmlNode unadjustedVarianceCapNode = xmlNode.SelectSingleNode("unadjustedVarianceCap");
            
            if (unadjustedVarianceCapNode != null)
            {
                if (unadjustedVarianceCapNode.Attributes["href"] != null || unadjustedVarianceCapNode.Attributes["id"] != null) 
                {
                    if (unadjustedVarianceCapNode.Attributes["id"] != null) 
                    {
                        unadjustedVarianceCapIDRef_ = unadjustedVarianceCapNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(unadjustedVarianceCapNode);
                        IDManager.SetID(unadjustedVarianceCapIDRef_, ob);
                    }
                    else if (unadjustedVarianceCapNode.Attributes["href"] != null)
                    {
                        unadjustedVarianceCapIDRef_ = unadjustedVarianceCapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedVarianceCap_ = new PositiveDecimal(unadjustedVarianceCapNode);
                    }
                }
                else
                {
                    unadjustedVarianceCap_ = new PositiveDecimal(unadjustedVarianceCapNode);
                }
            }
            
        
            XmlNode boundedVarianceNode = xmlNode.SelectSingleNode("boundedVariance");
            
            if (boundedVarianceNode != null)
            {
                if (boundedVarianceNode.Attributes["href"] != null || boundedVarianceNode.Attributes["id"] != null) 
                {
                    if (boundedVarianceNode.Attributes["id"] != null) 
                    {
                        boundedVarianceIDRef_ = boundedVarianceNode.Attributes["id"].Value;
                        BoundedVariance ob = new BoundedVariance(boundedVarianceNode);
                        IDManager.SetID(boundedVarianceIDRef_, ob);
                    }
                    else if (boundedVarianceNode.Attributes["href"] != null)
                    {
                        boundedVarianceIDRef_ = boundedVarianceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        boundedVariance_ = new BoundedVariance(boundedVarianceNode);
                    }
                }
                else
                {
                    boundedVariance_ = new BoundedVariance(boundedVarianceNode);
                }
            }
            
        
            XmlNode exchangeTradedContractNearestNode = xmlNode.SelectSingleNode("exchangeTradedContractNearest");
            
            if (exchangeTradedContractNearestNode != null)
            {
                if (exchangeTradedContractNearestNode.Attributes["href"] != null || exchangeTradedContractNearestNode.Attributes["id"] != null) 
                {
                    if (exchangeTradedContractNearestNode.Attributes["id"] != null) 
                    {
                        exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode.Attributes["id"].Value;
                        ExchangeTradedContract ob = new ExchangeTradedContract(exchangeTradedContractNearestNode);
                        IDManager.SetID(exchangeTradedContractNearestIDRef_, ob);
                    }
                    else if (exchangeTradedContractNearestNode.Attributes["href"] != null)
                    {
                        exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeTradedContractNearest_ = new ExchangeTradedContract(exchangeTradedContractNearestNode);
                    }
                }
                else
                {
                    exchangeTradedContractNearest_ = new ExchangeTradedContract(exchangeTradedContractNearestNode);
                }
            }
            
        
            XmlNode vegaNotionalAmountNode = xmlNode.SelectSingleNode("vegaNotionalAmount");
            
            if (vegaNotionalAmountNode != null)
            {
                if (vegaNotionalAmountNode.Attributes["href"] != null || vegaNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (vegaNotionalAmountNode.Attributes["id"] != null) 
                    {
                        vegaNotionalAmountIDRef_ = vegaNotionalAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(vegaNotionalAmountNode);
                        IDManager.SetID(vegaNotionalAmountIDRef_, ob);
                    }
                    else if (vegaNotionalAmountNode.Attributes["href"] != null)
                    {
                        vegaNotionalAmountIDRef_ = vegaNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vegaNotionalAmount_ = new XsdTypeDecimal(vegaNotionalAmountNode);
                    }
                }
                else
                {
                    vegaNotionalAmount_ = new XsdTypeDecimal(vegaNotionalAmountNode);
                }
            }
            
        
        }
        
    
        #region VarianceAmount_
        private NonNegativeMoney varianceAmount_;
        public NonNegativeMoney VarianceAmount_
        {
            get
            {
                if (this.varianceAmount_ != null)
                {
                    return this.varianceAmount_; 
                }
                else if (this.varianceAmountIDRef_ != null)
                {
                    varianceAmount_ = IDManager.getID(varianceAmountIDRef_) as NonNegativeMoney;
                    return this.varianceAmount_; 
                }
                else
                {
                      return this.varianceAmount_; 
                }
            }
            set
            {
                if (this.varianceAmount_ != value)
                {
                    this.varianceAmount_ = value;
                }
            }
        }
        #endregion
        
        public string varianceAmountIDRef_ { get; set; }
        #region VolatilityStrikePrice_
        private NonNegativeDecimal volatilityStrikePrice_;
        public NonNegativeDecimal VolatilityStrikePrice_
        {
            get
            {
                if (this.volatilityStrikePrice_ != null)
                {
                    return this.volatilityStrikePrice_; 
                }
                else if (this.volatilityStrikePriceIDRef_ != null)
                {
                    volatilityStrikePrice_ = IDManager.getID(volatilityStrikePriceIDRef_) as NonNegativeDecimal;
                    return this.volatilityStrikePrice_; 
                }
                else
                {
                      return this.volatilityStrikePrice_; 
                }
            }
            set
            {
                if (this.volatilityStrikePrice_ != value)
                {
                    this.volatilityStrikePrice_ = value;
                }
            }
        }
        #endregion
        
        public string volatilityStrikePriceIDRef_ { get; set; }
        #region VarianceStrikePrice_
        private NonNegativeDecimal varianceStrikePrice_;
        public NonNegativeDecimal VarianceStrikePrice_
        {
            get
            {
                if (this.varianceStrikePrice_ != null)
                {
                    return this.varianceStrikePrice_; 
                }
                else if (this.varianceStrikePriceIDRef_ != null)
                {
                    varianceStrikePrice_ = IDManager.getID(varianceStrikePriceIDRef_) as NonNegativeDecimal;
                    return this.varianceStrikePrice_; 
                }
                else
                {
                      return this.varianceStrikePrice_; 
                }
            }
            set
            {
                if (this.varianceStrikePrice_ != value)
                {
                    this.varianceStrikePrice_ = value;
                }
            }
        }
        #endregion
        
        public string varianceStrikePriceIDRef_ { get; set; }
        #region VarianceCap_
        private XsdTypeBoolean varianceCap_;
        public XsdTypeBoolean VarianceCap_
        {
            get
            {
                if (this.varianceCap_ != null)
                {
                    return this.varianceCap_; 
                }
                else if (this.varianceCapIDRef_ != null)
                {
                    varianceCap_ = IDManager.getID(varianceCapIDRef_) as XsdTypeBoolean;
                    return this.varianceCap_; 
                }
                else
                {
                      return this.varianceCap_; 
                }
            }
            set
            {
                if (this.varianceCap_ != value)
                {
                    this.varianceCap_ = value;
                }
            }
        }
        #endregion
        
        public string varianceCapIDRef_ { get; set; }
        #region UnadjustedVarianceCap_
        private PositiveDecimal unadjustedVarianceCap_;
        public PositiveDecimal UnadjustedVarianceCap_
        {
            get
            {
                if (this.unadjustedVarianceCap_ != null)
                {
                    return this.unadjustedVarianceCap_; 
                }
                else if (this.unadjustedVarianceCapIDRef_ != null)
                {
                    unadjustedVarianceCap_ = IDManager.getID(unadjustedVarianceCapIDRef_) as PositiveDecimal;
                    return this.unadjustedVarianceCap_; 
                }
                else
                {
                      return this.unadjustedVarianceCap_; 
                }
            }
            set
            {
                if (this.unadjustedVarianceCap_ != value)
                {
                    this.unadjustedVarianceCap_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedVarianceCapIDRef_ { get; set; }
        #region BoundedVariance_
        private BoundedVariance boundedVariance_;
        public BoundedVariance BoundedVariance_
        {
            get
            {
                if (this.boundedVariance_ != null)
                {
                    return this.boundedVariance_; 
                }
                else if (this.boundedVarianceIDRef_ != null)
                {
                    boundedVariance_ = IDManager.getID(boundedVarianceIDRef_) as BoundedVariance;
                    return this.boundedVariance_; 
                }
                else
                {
                      return this.boundedVariance_; 
                }
            }
            set
            {
                if (this.boundedVariance_ != value)
                {
                    this.boundedVariance_ = value;
                }
            }
        }
        #endregion
        
        public string boundedVarianceIDRef_ { get; set; }
        #region ExchangeTradedContractNearest_
        private ExchangeTradedContract exchangeTradedContractNearest_;
        public ExchangeTradedContract ExchangeTradedContractNearest_
        {
            get
            {
                if (this.exchangeTradedContractNearest_ != null)
                {
                    return this.exchangeTradedContractNearest_; 
                }
                else if (this.exchangeTradedContractNearestIDRef_ != null)
                {
                    exchangeTradedContractNearest_ = IDManager.getID(exchangeTradedContractNearestIDRef_) as ExchangeTradedContract;
                    return this.exchangeTradedContractNearest_; 
                }
                else
                {
                      return this.exchangeTradedContractNearest_; 
                }
            }
            set
            {
                if (this.exchangeTradedContractNearest_ != value)
                {
                    this.exchangeTradedContractNearest_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeTradedContractNearestIDRef_ { get; set; }
        #region VegaNotionalAmount_
        private XsdTypeDecimal vegaNotionalAmount_;
        public XsdTypeDecimal VegaNotionalAmount_
        {
            get
            {
                if (this.vegaNotionalAmount_ != null)
                {
                    return this.vegaNotionalAmount_; 
                }
                else if (this.vegaNotionalAmountIDRef_ != null)
                {
                    vegaNotionalAmount_ = IDManager.getID(vegaNotionalAmountIDRef_) as XsdTypeDecimal;
                    return this.vegaNotionalAmount_; 
                }
                else
                {
                      return this.vegaNotionalAmount_; 
                }
            }
            set
            {
                if (this.vegaNotionalAmount_ != value)
                {
                    this.vegaNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string vegaNotionalAmountIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

