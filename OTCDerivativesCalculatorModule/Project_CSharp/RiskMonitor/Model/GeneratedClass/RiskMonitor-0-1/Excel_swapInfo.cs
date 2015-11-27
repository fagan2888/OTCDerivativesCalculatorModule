using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_swapInfo : ISerialized
    {
        public Excel_swapInfo() { }
        public Excel_swapInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode tradeDateNode = xmlNode.SelectSingleNode("tradeDate");
            
            if (tradeDateNode != null)
            {
                if (tradeDateNode.Attributes["href"] != null || tradeDateNode.Attributes["id"] != null) 
                {
                    if (tradeDateNode.Attributes["id"] != null) 
                    {
                        tradeDateIDRef_ = tradeDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(tradeDateNode);
                        IDManager.SetID(tradeDateIDRef_, ob);
                    }
                    else if (tradeDateNode.Attributes["href"] != null)
                    {
                        tradeDateIDRef_ = tradeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeDate_ = new XsdTypeToken(tradeDateNode);
                    }
                }
                else
                {
                    tradeDate_ = new XsdTypeToken(tradeDateNode);
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
                        XsdTypeToken ob = new XsdTypeToken(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new XsdTypeToken(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new XsdTypeToken(effectiveDateNode);
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
                        XsdTypeToken ob = new XsdTypeToken(maturityDateNode);
                        IDManager.SetID(maturityDateIDRef_, ob);
                    }
                    else if (maturityDateNode.Attributes["href"] != null)
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityDate_ = new XsdTypeToken(maturityDateNode);
                    }
                }
                else
                {
                    maturityDate_ = new XsdTypeToken(maturityDateNode);
                }
            }
            
        
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new XsdTypeToken(notionalNode);
                    }
                }
                else
                {
                    notional_ = new XsdTypeToken(notionalNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new XsdTypeToken(currencyNode);
                    }
                }
                else
                {
                    currency_ = new XsdTypeToken(currencyNode);
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
                        XsdTypeToken ob = new XsdTypeToken(premiumNode);
                        IDManager.SetID(premiumIDRef_, ob);
                    }
                    else if (premiumNode.Attributes["href"] != null)
                    {
                        premiumIDRef_ = premiumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premium_ = new XsdTypeToken(premiumNode);
                    }
                }
                else
                {
                    premium_ = new XsdTypeToken(premiumNode);
                }
            }
            
        
        }
        
    
        #region TradeDate_
        private XsdTypeToken tradeDate_;
        public XsdTypeToken TradeDate_
        {
            get
            {
                if (this.tradeDate_ != null)
                {
                    return this.tradeDate_; 
                }
                else if (this.tradeDateIDRef_ != null)
                {
                    tradeDate_ = IDManager.getID(tradeDateIDRef_) as XsdTypeToken;
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
        private XsdTypeToken effectiveDate_;
        public XsdTypeToken EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as XsdTypeToken;
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
        private XsdTypeToken maturityDate_;
        public XsdTypeToken MaturityDate_
        {
            get
            {
                if (this.maturityDate_ != null)
                {
                    return this.maturityDate_; 
                }
                else if (this.maturityDateIDRef_ != null)
                {
                    maturityDate_ = IDManager.getID(maturityDateIDRef_) as XsdTypeToken;
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
        #region Notional_
        private XsdTypeToken notional_;
        public XsdTypeToken Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as XsdTypeToken;
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
        #region Currency_
        private XsdTypeToken currency_;
        public XsdTypeToken Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as XsdTypeToken;
                    return this.currency_; 
                }
                else
                {
                    throw new Exception( "currency_Node no exist!");
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region Premium_
        private XsdTypeToken premium_;
        public XsdTypeToken Premium_
        {
            get
            {
                if (this.premium_ != null)
                {
                    return this.premium_; 
                }
                else if (this.premiumIDRef_ != null)
                {
                    premium_ = IDManager.getID(premiumIDRef_) as XsdTypeToken;
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

