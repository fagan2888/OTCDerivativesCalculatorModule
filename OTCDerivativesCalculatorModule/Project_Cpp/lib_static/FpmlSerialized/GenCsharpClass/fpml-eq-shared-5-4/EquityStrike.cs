using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityStrike
    {
        public EquityStrike(XmlNode xmlNode)
        {
            XmlNodeList strikePriceNodeList = xmlNode.SelectNodes("strikePrice");
            if (strikePriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikePriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikePriceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(strikePriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikePriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikePrice = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList strikePercentageNodeList = xmlNode.SelectNodes("strikePercentage");
            if (strikePercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikePercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikePercentageIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(strikePercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikePercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikePercentage = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList strikeDeterminationDateNodeList = xmlNode.SelectNodes("strikeDeterminationDate");
            if (strikeDeterminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeDeterminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeDeterminationDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(strikeDeterminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeDeterminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikeDeterminationDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
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
            
        
        }
        
    
        #region StrikePrice
        private XsdTypeDecimal strikePrice;
        public XsdTypeDecimal StrikePrice
        {
            get
            {
                if (this.strikePrice != null)
                {
                    return this.strikePrice; 
                }
                else if (this.strikePriceIDRef != null)
                {
                    strikePrice = IDManager.getID(strikePriceIDRef) as XsdTypeDecimal;
                    return this.strikePrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikePrice != value)
                {
                    this.strikePrice = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region StrikePercentage
        private XsdTypeDecimal strikePercentage;
        public XsdTypeDecimal StrikePercentage
        {
            get
            {
                if (this.strikePercentage != null)
                {
                    return this.strikePercentage; 
                }
                else if (this.strikePercentageIDRef != null)
                {
                    strikePercentage = IDManager.getID(strikePercentageIDRef) as XsdTypeDecimal;
                    return this.strikePercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikePercentage != value)
                {
                    this.strikePercentage = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region StrikeDeterminationDate
        private AdjustableOrRelativeDate strikeDeterminationDate;
        public AdjustableOrRelativeDate StrikeDeterminationDate
        {
            get
            {
                if (this.strikeDeterminationDate != null)
                {
                    return this.strikeDeterminationDate; 
                }
                else if (this.strikeDeterminationDateIDRef != null)
                {
                    strikeDeterminationDate = IDManager.getID(strikeDeterminationDateIDRef) as AdjustableOrRelativeDate;
                    return this.strikeDeterminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikeDeterminationDate != value)
                {
                    this.strikeDeterminationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

