using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class VarianceSwapTransactionSupplement
    {
        public VarianceSwapTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList varianceLegNodeList = xmlNode.SelectNodes("varianceLeg");
            
            foreach (XmlNode item in varianceLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceLegIDRef = item.Attributes["id"].Name;
                        List<VarianceLeg> ob = new List<VarianceLeg>();
                        ob.Add(new VarianceLeg(item));
                        IDManager.SetID(varianceLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    varianceLeg.Add(new VarianceLeg(item));
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
        
    
        #region VarianceLeg
        private List<VarianceLeg> varianceLeg;
        public List<VarianceLeg> VarianceLeg
        {
            get
            {
                if (this.varianceLeg != null)
                {
                    return this.varianceLeg; 
                }
                else if (this.varianceLegIDRef != null)
                {
                    varianceLeg = IDManager.getID(varianceLegIDRef) as List<VarianceLeg>;
                    return this.varianceLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varianceLeg != value)
                {
                    this.varianceLeg = value;
                }
            }
        }
        #endregion
        
        public string VarianceLegIDRef { get; set; }
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

