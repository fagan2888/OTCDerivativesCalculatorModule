using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DualCurrencyFeature
    {
        public DualCurrencyFeature(XmlNode xmlNode)
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
            
        
            XmlNodeList fixingDateNodeList = xmlNode.SelectNodes("fixingDate");
            if (fixingDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(fixingDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList fixingTimeNodeList = xmlNode.SelectNodes("fixingTime");
            if (fixingTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(fixingTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList strikeNodeList = xmlNode.SelectNodes("strike");
            if (strikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeIDRef = item.Attributes["id"].Name;
                        DualCurrencyStrikePrice ob = DualCurrencyStrikePrice();
                        IDManager.SetID(strikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strike = new DualCurrencyStrikePrice(item);
                    }
                }
            }
            
        
            XmlNodeList spotRateNodeList = xmlNode.SelectNodes("spotRate");
            if (spotRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spotRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spotRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(spotRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spotRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spotRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList interestAtRiskNodeList = xmlNode.SelectNodes("interestAtRisk");
            if (interestAtRiskNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestAtRiskNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestAtRiskIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(interestAtRiskIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestAtRiskIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestAtRisk = new XsdTypeBoolean(item);
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
        #region FixingDate
        private XsdTypeDate fixingDate;
        public XsdTypeDate FixingDate
        {
            get
            {
                if (this.fixingDate != null)
                {
                    return this.fixingDate; 
                }
                else if (this.fixingDateIDRef != null)
                {
                    fixingDate = IDManager.getID(fixingDateIDRef) as XsdTypeDate;
                    return this.fixingDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingDate != value)
                {
                    this.fixingDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region FixingTime
        private BusinessCenterTime fixingTime;
        public BusinessCenterTime FixingTime
        {
            get
            {
                if (this.fixingTime != null)
                {
                    return this.fixingTime; 
                }
                else if (this.fixingTimeIDRef != null)
                {
                    fixingTime = IDManager.getID(fixingTimeIDRef) as BusinessCenterTime;
                    return this.fixingTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingTime != value)
                {
                    this.fixingTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region Strike
        private DualCurrencyStrikePrice strike;
        public DualCurrencyStrikePrice Strike
        {
            get
            {
                if (this.strike != null)
                {
                    return this.strike; 
                }
                else if (this.strikeIDRef != null)
                {
                    strike = IDManager.getID(strikeIDRef) as DualCurrencyStrikePrice;
                    return this.strike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strike != value)
                {
                    this.strike = value;
                }
            }
        }
        #endregion
        
        public string DualCurrencyStrikePriceIDRef { get; set; }
        #region SpotRate
        private XsdTypeDecimal spotRate;
        public XsdTypeDecimal SpotRate
        {
            get
            {
                if (this.spotRate != null)
                {
                    return this.spotRate; 
                }
                else if (this.spotRateIDRef != null)
                {
                    spotRate = IDManager.getID(spotRateIDRef) as XsdTypeDecimal;
                    return this.spotRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spotRate != value)
                {
                    this.spotRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region InterestAtRisk
        private XsdTypeBoolean interestAtRisk;
        public XsdTypeBoolean InterestAtRisk
        {
            get
            {
                if (this.interestAtRisk != null)
                {
                    return this.interestAtRisk; 
                }
                else if (this.interestAtRiskIDRef != null)
                {
                    interestAtRisk = IDManager.getID(interestAtRiskIDRef) as XsdTypeBoolean;
                    return this.interestAtRisk; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestAtRisk != value)
                {
                    this.interestAtRisk = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

