using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchange
    {
        public PrincipalExchange(XmlNode xmlNode)
        {
            XmlNodeList unadjustedPrincipalExchangeDateNodeList = xmlNode.SelectNodes("unadjustedPrincipalExchangeDate");
            if (unadjustedPrincipalExchangeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedPrincipalExchangeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedPrincipalExchangeDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(unadjustedPrincipalExchangeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedPrincipalExchangeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedPrincipalExchangeDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedPrincipalExchangeDateNodeList = xmlNode.SelectNodes("adjustedPrincipalExchangeDate");
            if (adjustedPrincipalExchangeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedPrincipalExchangeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedPrincipalExchangeDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedPrincipalExchangeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedPrincipalExchangeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedPrincipalExchangeDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList principalExchangeAmountNodeList = xmlNode.SelectNodes("principalExchangeAmount");
            if (principalExchangeAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalExchangeAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalExchangeAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(principalExchangeAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalExchangeAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalExchangeAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList discountFactorNodeList = xmlNode.SelectNodes("discountFactor");
            if (discountFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(discountFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discountFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList presentValuePrincipalExchangeAmountNodeList = xmlNode.SelectNodes("presentValuePrincipalExchangeAmount");
            if (presentValuePrincipalExchangeAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in presentValuePrincipalExchangeAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        presentValuePrincipalExchangeAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(presentValuePrincipalExchangeAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        presentValuePrincipalExchangeAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        presentValuePrincipalExchangeAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region UnadjustedPrincipalExchangeDate
        private XsdTypeDate unadjustedPrincipalExchangeDate;
        public XsdTypeDate UnadjustedPrincipalExchangeDate
        {
            get
            {
                if (this.unadjustedPrincipalExchangeDate != null)
                {
                    return this.unadjustedPrincipalExchangeDate; 
                }
                else if (this.unadjustedPrincipalExchangeDateIDRef != null)
                {
                    unadjustedPrincipalExchangeDate = IDManager.getID(unadjustedPrincipalExchangeDateIDRef) as XsdTypeDate;
                    return this.unadjustedPrincipalExchangeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedPrincipalExchangeDate != value)
                {
                    this.unadjustedPrincipalExchangeDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedPrincipalExchangeDate
        private XsdTypeDate adjustedPrincipalExchangeDate;
        public XsdTypeDate AdjustedPrincipalExchangeDate
        {
            get
            {
                if (this.adjustedPrincipalExchangeDate != null)
                {
                    return this.adjustedPrincipalExchangeDate; 
                }
                else if (this.adjustedPrincipalExchangeDateIDRef != null)
                {
                    adjustedPrincipalExchangeDate = IDManager.getID(adjustedPrincipalExchangeDateIDRef) as XsdTypeDate;
                    return this.adjustedPrincipalExchangeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedPrincipalExchangeDate != value)
                {
                    this.adjustedPrincipalExchangeDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region PrincipalExchangeAmount
        private XsdTypeDecimal principalExchangeAmount;
        public XsdTypeDecimal PrincipalExchangeAmount
        {
            get
            {
                if (this.principalExchangeAmount != null)
                {
                    return this.principalExchangeAmount; 
                }
                else if (this.principalExchangeAmountIDRef != null)
                {
                    principalExchangeAmount = IDManager.getID(principalExchangeAmountIDRef) as XsdTypeDecimal;
                    return this.principalExchangeAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalExchangeAmount != value)
                {
                    this.principalExchangeAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region DiscountFactor
        private XsdTypeDecimal discountFactor;
        public XsdTypeDecimal DiscountFactor
        {
            get
            {
                if (this.discountFactor != null)
                {
                    return this.discountFactor; 
                }
                else if (this.discountFactorIDRef != null)
                {
                    discountFactor = IDManager.getID(discountFactorIDRef) as XsdTypeDecimal;
                    return this.discountFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discountFactor != value)
                {
                    this.discountFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PresentValuePrincipalExchangeAmount
        private Money presentValuePrincipalExchangeAmount;
        public Money PresentValuePrincipalExchangeAmount
        {
            get
            {
                if (this.presentValuePrincipalExchangeAmount != null)
                {
                    return this.presentValuePrincipalExchangeAmount; 
                }
                else if (this.presentValuePrincipalExchangeAmountIDRef != null)
                {
                    presentValuePrincipalExchangeAmount = IDManager.getID(presentValuePrincipalExchangeAmountIDRef) as Money;
                    return this.presentValuePrincipalExchangeAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.presentValuePrincipalExchangeAmount != value)
                {
                    this.presentValuePrincipalExchangeAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}

