using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendSwapTransactionSupplement
    {
        public DividendSwapTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList dividendLegNodeList = xmlNode.SelectNodes("dividendLeg");
            if (dividendLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendLegIDRef = item.Attributes["id"].Name;
                        DividendLeg ob = DividendLeg();
                        IDManager.SetID(dividendLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendLeg = new DividendLeg(item);
                    }
                }
            }
            
        
            XmlNodeList fixedLegNodeList = xmlNode.SelectNodes("fixedLeg");
            if (fixedLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedLegIDRef = item.Attributes["id"].Name;
                        FixedPaymentLeg ob = FixedPaymentLeg();
                        IDManager.SetID(fixedLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedLeg = new FixedPaymentLeg(item);
                    }
                }
            }
            
        
            XmlNodeList multipleExchangeIndexAnnexFallbackNodeList = xmlNode.SelectNodes("multipleExchangeIndexAnnexFallback");
            if (multipleExchangeIndexAnnexFallbackNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multipleExchangeIndexAnnexFallbackNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multipleExchangeIndexAnnexFallbackIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(multipleExchangeIndexAnnexFallbackIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multipleExchangeIndexAnnexFallbackIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multipleExchangeIndexAnnexFallback = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList componentSecurityIndexAnnexFallbackNodeList = xmlNode.SelectNodes("componentSecurityIndexAnnexFallback");
            if (componentSecurityIndexAnnexFallbackNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in componentSecurityIndexAnnexFallbackNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        componentSecurityIndexAnnexFallbackIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(componentSecurityIndexAnnexFallbackIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        componentSecurityIndexAnnexFallbackIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        componentSecurityIndexAnnexFallback = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList localJurisdictionNodeList = xmlNode.SelectNodes("localJurisdiction");
            if (localJurisdictionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in localJurisdictionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        localJurisdictionIDRef = item.Attributes["id"].Name;
                        CountryCode ob = CountryCode();
                        IDManager.SetID(localJurisdictionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        localJurisdictionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        localJurisdiction = new CountryCode(item);
                    }
                }
            }
            
        
            XmlNodeList relevantJurisdictionNodeList = xmlNode.SelectNodes("relevantJurisdiction");
            if (relevantJurisdictionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relevantJurisdictionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relevantJurisdictionIDRef = item.Attributes["id"].Name;
                        CountryCode ob = CountryCode();
                        IDManager.SetID(relevantJurisdictionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relevantJurisdictionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relevantJurisdiction = new CountryCode(item);
                    }
                }
            }
            
        
        }
        
    
        #region DividendLeg
        private DividendLeg dividendLeg;
        public DividendLeg DividendLeg
        {
            get
            {
                if (this.dividendLeg != null)
                {
                    return this.dividendLeg; 
                }
                else if (this.dividendLegIDRef != null)
                {
                    dividendLeg = IDManager.getID(dividendLegIDRef) as DividendLeg;
                    return this.dividendLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendLeg != value)
                {
                    this.dividendLeg = value;
                }
            }
        }
        #endregion
        
        public string DividendLegIDRef { get; set; }
        #region FixedLeg
        private FixedPaymentLeg fixedLeg;
        public FixedPaymentLeg FixedLeg
        {
            get
            {
                if (this.fixedLeg != null)
                {
                    return this.fixedLeg; 
                }
                else if (this.fixedLegIDRef != null)
                {
                    fixedLeg = IDManager.getID(fixedLegIDRef) as FixedPaymentLeg;
                    return this.fixedLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedLeg != value)
                {
                    this.fixedLeg = value;
                }
            }
        }
        #endregion
        
        public string FixedPaymentLegIDRef { get; set; }
        #region MultipleExchangeIndexAnnexFallback
        private XsdTypeBoolean multipleExchangeIndexAnnexFallback;
        public XsdTypeBoolean MultipleExchangeIndexAnnexFallback
        {
            get
            {
                if (this.multipleExchangeIndexAnnexFallback != null)
                {
                    return this.multipleExchangeIndexAnnexFallback; 
                }
                else if (this.multipleExchangeIndexAnnexFallbackIDRef != null)
                {
                    multipleExchangeIndexAnnexFallback = IDManager.getID(multipleExchangeIndexAnnexFallbackIDRef) as XsdTypeBoolean;
                    return this.multipleExchangeIndexAnnexFallback; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multipleExchangeIndexAnnexFallback != value)
                {
                    this.multipleExchangeIndexAnnexFallback = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ComponentSecurityIndexAnnexFallback
        private XsdTypeBoolean componentSecurityIndexAnnexFallback;
        public XsdTypeBoolean ComponentSecurityIndexAnnexFallback
        {
            get
            {
                if (this.componentSecurityIndexAnnexFallback != null)
                {
                    return this.componentSecurityIndexAnnexFallback; 
                }
                else if (this.componentSecurityIndexAnnexFallbackIDRef != null)
                {
                    componentSecurityIndexAnnexFallback = IDManager.getID(componentSecurityIndexAnnexFallbackIDRef) as XsdTypeBoolean;
                    return this.componentSecurityIndexAnnexFallback; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.componentSecurityIndexAnnexFallback != value)
                {
                    this.componentSecurityIndexAnnexFallback = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region LocalJurisdiction
        private CountryCode localJurisdiction;
        public CountryCode LocalJurisdiction
        {
            get
            {
                if (this.localJurisdiction != null)
                {
                    return this.localJurisdiction; 
                }
                else if (this.localJurisdictionIDRef != null)
                {
                    localJurisdiction = IDManager.getID(localJurisdictionIDRef) as CountryCode;
                    return this.localJurisdiction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.localJurisdiction != value)
                {
                    this.localJurisdiction = value;
                }
            }
        }
        #endregion
        
        public string CountryCodeIDRef { get; set; }
        #region RelevantJurisdiction
        private CountryCode relevantJurisdiction;
        public CountryCode RelevantJurisdiction
        {
            get
            {
                if (this.relevantJurisdiction != null)
                {
                    return this.relevantJurisdiction; 
                }
                else if (this.relevantJurisdictionIDRef != null)
                {
                    relevantJurisdiction = IDManager.getID(relevantJurisdictionIDRef) as CountryCode;
                    return this.relevantJurisdiction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relevantJurisdiction != value)
                {
                    this.relevantJurisdiction = value;
                }
            }
        }
        #endregion
        
        public string CountryCodeIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

