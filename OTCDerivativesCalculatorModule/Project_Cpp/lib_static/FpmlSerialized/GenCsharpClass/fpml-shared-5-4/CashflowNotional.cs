using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CashflowNotional
    {
        public CashflowNotional(XmlNode xmlNode)
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
            
        
            XmlNodeList unitsNodeList = xmlNode.SelectNodes("units");
            if (unitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unitsIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(unitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        units = new XsdTypeNormalizedString(item);
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
        #region Units
        private XsdTypeNormalizedString units;
        public XsdTypeNormalizedString Units
        {
            get
            {
                if (this.units != null)
                {
                    return this.units; 
                }
                else if (this.unitsIDRef != null)
                {
                    units = IDManager.getID(unitsIDRef) as XsdTypeNormalizedString;
                    return this.units; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.units != value)
                {
                    this.units = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

