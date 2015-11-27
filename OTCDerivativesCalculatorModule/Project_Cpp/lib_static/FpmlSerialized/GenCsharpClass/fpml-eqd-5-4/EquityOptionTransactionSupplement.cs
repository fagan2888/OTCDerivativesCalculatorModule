using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityOptionTransactionSupplement
    {
        public EquityOptionTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList exchangeLookAlikeNodeList = xmlNode.SelectNodes("exchangeLookAlike");
            if (exchangeLookAlikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeLookAlikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeLookAlikeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(exchangeLookAlikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeLookAlikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeLookAlike = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList exchangeTradedContractNearestNodeList = xmlNode.SelectNodes("exchangeTradedContractNearest");
            if (exchangeTradedContractNearestNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeTradedContractNearestNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeTradedContractNearestIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(exchangeTradedContractNearestIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeTradedContractNearestIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeTradedContractNearest = new XsdTypeBoolean(item);
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
            
        
            XmlNodeList methodOfAdjustmentNodeList = xmlNode.SelectNodes("methodOfAdjustment");
            if (methodOfAdjustmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in methodOfAdjustmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        methodOfAdjustmentIDRef = item.Attributes["id"].Name;
                        MethodOfAdjustmentEnum ob = MethodOfAdjustmentEnum();
                        IDManager.SetID(methodOfAdjustmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        methodOfAdjustmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        methodOfAdjustment = new MethodOfAdjustmentEnum(item);
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
            
        
            XmlNodeList optionEntitlementNodeList = xmlNode.SelectNodes("optionEntitlement");
            if (optionEntitlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionEntitlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionEntitlementIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(optionEntitlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionEntitlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionEntitlement = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList multiplierNodeList = xmlNode.SelectNodes("multiplier");
            if (multiplierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multiplierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multiplierIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(multiplierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multiplierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multiplier = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList extraordinaryEventsNodeList = xmlNode.SelectNodes("extraordinaryEvents");
            if (extraordinaryEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in extraordinaryEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extraordinaryEventsIDRef = item.Attributes["id"].Name;
                        ExtraordinaryEvents ob = ExtraordinaryEvents();
                        IDManager.SetID(extraordinaryEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extraordinaryEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        extraordinaryEvents = new ExtraordinaryEvents(item);
                    }
                }
            }
            
        
        }
        
    
        #region ExchangeLookAlike
        private XsdTypeBoolean exchangeLookAlike;
        public XsdTypeBoolean ExchangeLookAlike
        {
            get
            {
                if (this.exchangeLookAlike != null)
                {
                    return this.exchangeLookAlike; 
                }
                else if (this.exchangeLookAlikeIDRef != null)
                {
                    exchangeLookAlike = IDManager.getID(exchangeLookAlikeIDRef) as XsdTypeBoolean;
                    return this.exchangeLookAlike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeLookAlike != value)
                {
                    this.exchangeLookAlike = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ExchangeTradedContractNearest
        private XsdTypeBoolean exchangeTradedContractNearest;
        public XsdTypeBoolean ExchangeTradedContractNearest
        {
            get
            {
                if (this.exchangeTradedContractNearest != null)
                {
                    return this.exchangeTradedContractNearest; 
                }
                else if (this.exchangeTradedContractNearestIDRef != null)
                {
                    exchangeTradedContractNearest = IDManager.getID(exchangeTradedContractNearestIDRef) as XsdTypeBoolean;
                    return this.exchangeTradedContractNearest; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeTradedContractNearest != value)
                {
                    this.exchangeTradedContractNearest = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
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
        #region MethodOfAdjustment
        private MethodOfAdjustmentEnum methodOfAdjustment;
        public MethodOfAdjustmentEnum MethodOfAdjustment
        {
            get
            {
                if (this.methodOfAdjustment != null)
                {
                    return this.methodOfAdjustment; 
                }
                else if (this.methodOfAdjustmentIDRef != null)
                {
                    methodOfAdjustment = IDManager.getID(methodOfAdjustmentIDRef) as MethodOfAdjustmentEnum;
                    return this.methodOfAdjustment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.methodOfAdjustment != value)
                {
                    this.methodOfAdjustment = value;
                }
            }
        }
        #endregion
        
        public string MethodOfAdjustmentEnumIDRef { get; set; }
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
        #region OptionEntitlement
        private PositiveDecimal optionEntitlement;
        public PositiveDecimal OptionEntitlement
        {
            get
            {
                if (this.optionEntitlement != null)
                {
                    return this.optionEntitlement; 
                }
                else if (this.optionEntitlementIDRef != null)
                {
                    optionEntitlement = IDManager.getID(optionEntitlementIDRef) as PositiveDecimal;
                    return this.optionEntitlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionEntitlement != value)
                {
                    this.optionEntitlement = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region Multiplier
        private PositiveDecimal multiplier;
        public PositiveDecimal Multiplier
        {
            get
            {
                if (this.multiplier != null)
                {
                    return this.multiplier; 
                }
                else if (this.multiplierIDRef != null)
                {
                    multiplier = IDManager.getID(multiplierIDRef) as PositiveDecimal;
                    return this.multiplier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multiplier != value)
                {
                    this.multiplier = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region ExtraordinaryEvents
        private ExtraordinaryEvents extraordinaryEvents;
        public ExtraordinaryEvents ExtraordinaryEvents
        {
            get
            {
                if (this.extraordinaryEvents != null)
                {
                    return this.extraordinaryEvents; 
                }
                else if (this.extraordinaryEventsIDRef != null)
                {
                    extraordinaryEvents = IDManager.getID(extraordinaryEventsIDRef) as ExtraordinaryEvents;
                    return this.extraordinaryEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extraordinaryEvents != value)
                {
                    this.extraordinaryEvents = value;
                }
            }
        }
        #endregion
        
        public string ExtraordinaryEventsIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

