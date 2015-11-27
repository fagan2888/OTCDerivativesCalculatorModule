using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CashflowNotional : ISerialized
    {
        public CashflowNotional(XmlNode xmlNode)
        {
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new Currency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new Currency(currencyNode);
                }
            }
            
        
            XmlNode unitsNode = xmlNode.SelectSingleNode("units");
            
            if (unitsNode != null)
            {
                if (unitsNode.Attributes["href"] != null || unitsNode.Attributes["id"] != null) 
                {
                    if (unitsNode.Attributes["id"] != null) 
                    {
                        unitsIDRef_ = unitsNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(unitsNode);
                        IDManager.SetID(unitsIDRef_, ob);
                    }
                    else if (unitsNode.Attributes["href"] != null)
                    {
                        unitsIDRef_ = unitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        units_ = new XsdTypeNormalizedString(unitsNode);
                    }
                }
                else
                {
                    units_ = new XsdTypeNormalizedString(unitsNode);
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
                        XsdTypeDecimal ob = new XsdTypeDecimal(amountNode);
                        IDManager.SetID(amountIDRef_, ob);
                    }
                    else if (amountNode.Attributes["href"] != null)
                    {
                        amountIDRef_ = amountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amount_ = new XsdTypeDecimal(amountNode);
                    }
                }
                else
                {
                    amount_ = new XsdTypeDecimal(amountNode);
                }
            }
            
        
        }
        
    
        #region Currency_
        private Currency currency_;
        public Currency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as Currency;
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
        #region Units_
        private XsdTypeNormalizedString units_;
        public XsdTypeNormalizedString Units_
        {
            get
            {
                if (this.units_ != null)
                {
                    return this.units_; 
                }
                else if (this.unitsIDRef_ != null)
                {
                    units_ = IDManager.getID(unitsIDRef_) as XsdTypeNormalizedString;
                    return this.units_; 
                }
                else
                {
                      return this.units_; 
                }
            }
            set
            {
                if (this.units_ != value)
                {
                    this.units_ = value;
                }
            }
        }
        #endregion
        
        public string unitsIDRef_ { get; set; }
        #region Amount_
        private XsdTypeDecimal amount_;
        public XsdTypeDecimal Amount_
        {
            get
            {
                if (this.amount_ != null)
                {
                    return this.amount_; 
                }
                else if (this.amountIDRef_ != null)
                {
                    amount_ = IDManager.getID(amountIDRef_) as XsdTypeDecimal;
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

