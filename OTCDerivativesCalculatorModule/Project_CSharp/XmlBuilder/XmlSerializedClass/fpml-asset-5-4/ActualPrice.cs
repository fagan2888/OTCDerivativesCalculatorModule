using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ActualPrice : ISerialized
    {
        public ActualPrice(XmlNode xmlNode)
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
            
        
            XmlNode priceExpressionNode = xmlNode.SelectSingleNode("priceExpression");
            
            if (priceExpressionNode != null)
            {
                if (priceExpressionNode.Attributes["href"] != null || priceExpressionNode.Attributes["id"] != null) 
                {
                    if (priceExpressionNode.Attributes["id"] != null) 
                    {
                        priceExpressionIDRef_ = priceExpressionNode.Attributes["id"].Value;
                        PriceExpressionEnum ob = new PriceExpressionEnum(priceExpressionNode);
                        IDManager.SetID(priceExpressionIDRef_, ob);
                    }
                    else if (priceExpressionNode.Attributes["href"] != null)
                    {
                        priceExpressionIDRef_ = priceExpressionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        priceExpression_ = new PriceExpressionEnum(priceExpressionNode);
                    }
                }
                else
                {
                    priceExpression_ = new PriceExpressionEnum(priceExpressionNode);
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
        #region PriceExpression_
        private PriceExpressionEnum priceExpression_;
        public PriceExpressionEnum PriceExpression_
        {
            get
            {
                if (this.priceExpression_ != null)
                {
                    return this.priceExpression_; 
                }
                else if (this.priceExpressionIDRef_ != null)
                {
                    priceExpression_ = IDManager.getID(priceExpressionIDRef_) as PriceExpressionEnum;
                    return this.priceExpression_; 
                }
                else
                {
                      return this.priceExpression_; 
                }
            }
            set
            {
                if (this.priceExpression_ != value)
                {
                    this.priceExpression_ = value;
                }
            }
        }
        #endregion
        
        public string priceExpressionIDRef_ { get; set; }
        
    
        
    
    }
    
}

