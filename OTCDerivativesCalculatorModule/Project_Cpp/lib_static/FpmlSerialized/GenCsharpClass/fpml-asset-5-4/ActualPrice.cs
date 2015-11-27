using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ActualPrice
    {
        public ActualPrice(XmlNode xmlNode)
        {
            XmlNodeList currencyNodeList = xmlNode.SelectNodes("currency");
            if (currencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(currencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList amountNodeList = xmlNode.SelectNodes("amount");
            if (amountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(amountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList priceExpressionNodeList = xmlNode.SelectNodes("priceExpression");
            if (priceExpressionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in priceExpressionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        priceExpressionIDRef = item.Attributes["id"].Name;
                        PriceExpressionEnum ob = PriceExpressionEnum();
                        IDManager.SetID(priceExpressionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        priceExpressionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        priceExpression = new PriceExpressionEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region Currency
        private Currency currency;
        public Currency Currency
        {
            get
            {
                if (this.currency != null)
                {
                    return this.currency; 
                }
                else if (this.currencyIDRef != null)
                {
                    currency = IDManager.getID(currencyIDRef) as Currency;
                    return this.currency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency != value)
                {
                    this.currency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region Amount
        private XsdTypeDecimal amount;
        public XsdTypeDecimal Amount
        {
            get
            {
                if (this.amount != null)
                {
                    return this.amount; 
                }
                else if (this.amountIDRef != null)
                {
                    amount = IDManager.getID(amountIDRef) as XsdTypeDecimal;
                    return this.amount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amount != value)
                {
                    this.amount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PriceExpression
        private PriceExpressionEnum priceExpression;
        public PriceExpressionEnum PriceExpression
        {
            get
            {
                if (this.priceExpression != null)
                {
                    return this.priceExpression; 
                }
                else if (this.priceExpressionIDRef != null)
                {
                    priceExpression = IDManager.getID(priceExpressionIDRef) as PriceExpressionEnum;
                    return this.priceExpression; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.priceExpression != value)
                {
                    this.priceExpression = value;
                }
            }
        }
        #endregion
        
        public string PriceExpressionEnumIDRef { get; set; }
        
    
        
    
    }
    
}

