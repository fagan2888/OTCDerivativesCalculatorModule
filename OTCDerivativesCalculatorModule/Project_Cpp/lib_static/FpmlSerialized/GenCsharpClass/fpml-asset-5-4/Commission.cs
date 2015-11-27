using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Commission
    {
        public Commission(XmlNode xmlNode)
        {
            XmlNodeList commissionDenominationNodeList = xmlNode.SelectNodes("commissionDenomination");
            if (commissionDenominationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commissionDenominationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commissionDenominationIDRef = item.Attributes["id"].Name;
                        CommissionDenominationEnum ob = CommissionDenominationEnum();
                        IDManager.SetID(commissionDenominationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commissionDenominationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commissionDenomination = new CommissionDenominationEnum(item);
                    }
                }
            }
            
        
            XmlNodeList commissionAmountNodeList = xmlNode.SelectNodes("commissionAmount");
            if (commissionAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commissionAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commissionAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(commissionAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commissionAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commissionAmount = new XsdTypeDecimal(item);
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
            
        
            XmlNodeList commissionPerTradeNodeList = xmlNode.SelectNodes("commissionPerTrade");
            if (commissionPerTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commissionPerTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commissionPerTradeIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(commissionPerTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commissionPerTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commissionPerTrade = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList fxRateNodeList = xmlNode.SelectNodes("fxRate");
            
            foreach (XmlNode item in fxRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxRateIDRef = item.Attributes["id"].Name;
                        List<FxRate> ob = new List<FxRate>();
                        ob.Add(new FxRate(item));
                        IDManager.SetID(fxRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    fxRate.Add(new FxRate(item));
                    }
                }
            }
            
        
        }
        
    
        #region CommissionDenomination
        private CommissionDenominationEnum commissionDenomination;
        public CommissionDenominationEnum CommissionDenomination
        {
            get
            {
                if (this.commissionDenomination != null)
                {
                    return this.commissionDenomination; 
                }
                else if (this.commissionDenominationIDRef != null)
                {
                    commissionDenomination = IDManager.getID(commissionDenominationIDRef) as CommissionDenominationEnum;
                    return this.commissionDenomination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commissionDenomination != value)
                {
                    this.commissionDenomination = value;
                }
            }
        }
        #endregion
        
        public string CommissionDenominationEnumIDRef { get; set; }
        #region CommissionAmount
        private XsdTypeDecimal commissionAmount;
        public XsdTypeDecimal CommissionAmount
        {
            get
            {
                if (this.commissionAmount != null)
                {
                    return this.commissionAmount; 
                }
                else if (this.commissionAmountIDRef != null)
                {
                    commissionAmount = IDManager.getID(commissionAmountIDRef) as XsdTypeDecimal;
                    return this.commissionAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commissionAmount != value)
                {
                    this.commissionAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
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
        #region CommissionPerTrade
        private XsdTypeDecimal commissionPerTrade;
        public XsdTypeDecimal CommissionPerTrade
        {
            get
            {
                if (this.commissionPerTrade != null)
                {
                    return this.commissionPerTrade; 
                }
                else if (this.commissionPerTradeIDRef != null)
                {
                    commissionPerTrade = IDManager.getID(commissionPerTradeIDRef) as XsdTypeDecimal;
                    return this.commissionPerTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commissionPerTrade != value)
                {
                    this.commissionPerTrade = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FxRate
        private List<FxRate> fxRate;
        public List<FxRate> FxRate
        {
            get
            {
                if (this.fxRate != null)
                {
                    return this.fxRate; 
                }
                else if (this.fxRateIDRef != null)
                {
                    fxRate = IDManager.getID(fxRateIDRef) as List<FxRate>;
                    return this.fxRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxRate != value)
                {
                    this.fxRate = value;
                }
            }
        }
        #endregion
        
        public string FxRateIDRef { get; set; }
        
    
        
    
    }
    
}

