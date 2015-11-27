using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SecuritiesInfo : ISerialized
    {
        public SecuritiesInfo() { }
        public SecuritiesInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new XsdTypeDate(notionalNode);
                    }
                }
                else
                {
                    notional_ = new XsdTypeDate(notionalNode);
                }
            }
            
        
            XmlNode tradeDateNode = xmlNode.SelectSingleNode("tradeDate");
            
            if (tradeDateNode != null)
            {
                if (tradeDateNode.Attributes["href"] != null || tradeDateNode.Attributes["id"] != null) 
                {
                    if (tradeDateNode.Attributes["id"] != null) 
                    {
                        tradeDateIDRef_ = tradeDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(tradeDateNode);
                        IDManager.SetID(tradeDateIDRef_, ob);
                    }
                    else if (tradeDateNode.Attributes["href"] != null)
                    {
                        tradeDateIDRef_ = tradeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeDate_ = new XsdTypeDate(tradeDateNode);
                    }
                }
                else
                {
                    tradeDate_ = new XsdTypeDate(tradeDateNode);
                }
            }
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode maturityDateNode = xmlNode.SelectSingleNode("maturityDate");
            
            if (maturityDateNode != null)
            {
                if (maturityDateNode.Attributes["href"] != null || maturityDateNode.Attributes["id"] != null) 
                {
                    if (maturityDateNode.Attributes["id"] != null) 
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(maturityDateNode);
                        IDManager.SetID(maturityDateIDRef_, ob);
                    }
                    else if (maturityDateNode.Attributes["href"] != null)
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityDate_ = new XsdTypeDate(maturityDateNode);
                    }
                }
                else
                {
                    maturityDate_ = new XsdTypeDate(maturityDateNode);
                }
            }
            
        
            XmlNode calculationAmountNode = xmlNode.SelectSingleNode("calculationAmount");
            
            if (calculationAmountNode != null)
            {
                if (calculationAmountNode.Attributes["href"] != null || calculationAmountNode.Attributes["id"] != null) 
                {
                    if (calculationAmountNode.Attributes["id"] != null) 
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["id"].Value;
                        CalculationAmount ob = new CalculationAmount(calculationAmountNode);
                        IDManager.SetID(calculationAmountIDRef_, ob);
                    }
                    else if (calculationAmountNode.Attributes["href"] != null)
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAmount_ = new CalculationAmount(calculationAmountNode);
                    }
                }
                else
                {
                    calculationAmount_ = new CalculationAmount(calculationAmountNode);
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
                        XsdTypeDouble ob = new XsdTypeDouble(premiumNode);
                        IDManager.SetID(premiumIDRef_, ob);
                    }
                    else if (premiumNode.Attributes["href"] != null)
                    {
                        premiumIDRef_ = premiumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premium_ = new XsdTypeDouble(premiumNode);
                    }
                }
                else
                {
                    premium_ = new XsdTypeDouble(premiumNode);
                }
            }
            
        
        }
        
    
        #region Notional_
        private XsdTypeDate notional_;
        public XsdTypeDate Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as XsdTypeDate;
                    return this.notional_; 
                }
                else
                {
                    throw new Exception( "notional_Node no exist!");
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region TradeDate_
        private XsdTypeDate tradeDate_;
        public XsdTypeDate TradeDate_
        {
            get
            {
                if (this.tradeDate_ != null)
                {
                    return this.tradeDate_; 
                }
                else if (this.tradeDateIDRef_ != null)
                {
                    tradeDate_ = IDManager.getID(tradeDateIDRef_) as XsdTypeDate;
                    return this.tradeDate_; 
                }
                else
                {
                    throw new Exception( "tradeDate_Node no exist!");
                }
            }
            set
            {
                if (this.tradeDate_ != value)
                {
                    this.tradeDate_ = value;
                }
            }
        }
        #endregion
        
        public string tradeDateIDRef_ { get; set; }
        #region EffectiveDate_
        private XsdTypeDate effectiveDate_;
        public XsdTypeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as XsdTypeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                    throw new Exception( "effectiveDate_Node no exist!");
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region MaturityDate_
        private XsdTypeDate maturityDate_;
        public XsdTypeDate MaturityDate_
        {
            get
            {
                if (this.maturityDate_ != null)
                {
                    return this.maturityDate_; 
                }
                else if (this.maturityDateIDRef_ != null)
                {
                    maturityDate_ = IDManager.getID(maturityDateIDRef_) as XsdTypeDate;
                    return this.maturityDate_; 
                }
                else
                {
                    throw new Exception( "maturityDate_Node no exist!");
                }
            }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                }
            }
        }
        #endregion
        
        public string maturityDateIDRef_ { get; set; }
        #region CalculationAmount_
        private CalculationAmount calculationAmount_;
        public CalculationAmount CalculationAmount_
        {
            get
            {
                if (this.calculationAmount_ != null)
                {
                    return this.calculationAmount_; 
                }
                else if (this.calculationAmountIDRef_ != null)
                {
                    calculationAmount_ = IDManager.getID(calculationAmountIDRef_) as CalculationAmount;
                    return this.calculationAmount_; 
                }
                else
                {
                    throw new Exception( "calculationAmount_Node no exist!");
                }
            }
            set
            {
                if (this.calculationAmount_ != value)
                {
                    this.calculationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAmountIDRef_ { get; set; }
        #region Premium_
        private XsdTypeDouble premium_;
        public XsdTypeDouble Premium_
        {
            get
            {
                if (this.premium_ != null)
                {
                    return this.premium_; 
                }
                else if (this.premiumIDRef_ != null)
                {
                    premium_ = IDManager.getID(premiumIDRef_) as XsdTypeDouble;
                    return this.premium_; 
                }
                else
                {
                    throw new Exception( "premium_Node no exist!");
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
        
    
        
    
    }
    
}

