using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class CalculationAmount : ISerialized
    {
        public CalculationAmount() { }
        public CalculationAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode amountNode = xmlNode.SelectSingleNode("amount");
            
            if (amountNode != null)
            {
                if (amountNode.Attributes["href"] != null || amountNode.Attributes["id"] != null) 
                {
                    if (amountNode.Attributes["id"] != null) 
                    {
                        amountIDRef_ = amountNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(amountNode);
                        IDManager.SetID(amountIDRef_, ob);
                    }
                    else if (amountNode.Attributes["href"] != null)
                    {
                        amountIDRef_ = amountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amount_ = new XsdTypeDouble(amountNode);
                    }
                }
                else
                {
                    amount_ = new XsdTypeDouble(amountNode);
                }
            }
            
        
        }
        
    
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
                      return this.currency_; 
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
        #region Amount_
        private XsdTypeDouble amount_;
        public XsdTypeDouble Amount_
        {
            get
            {
                if (this.amount_ != null)
                {
                    return this.amount_; 
                }
                else if (this.amountIDRef_ != null)
                {
                    amount_ = IDManager.getID(amountIDRef_) as XsdTypeDouble;
                    return this.amount_; 
                }
                else
                {
                      return this.amount_; 
                }
            }
            set
            {
                if (this.amount_ != value)
                {
                    this.amount_ = value;
                }
            }
        }
        #endregion
        
        public string amountIDRef_ { get; set; }
        
    
        
    
    }
    
}

