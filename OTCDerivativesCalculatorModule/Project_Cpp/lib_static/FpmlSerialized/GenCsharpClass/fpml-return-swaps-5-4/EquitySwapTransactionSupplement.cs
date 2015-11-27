using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquitySwapTransactionSupplement
    {
        public EquitySwapTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList mutualEarlyTerminationNodeList = xmlNode.SelectNodes("mutualEarlyTermination");
            if (mutualEarlyTerminationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mutualEarlyTerminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mutualEarlyTerminationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(mutualEarlyTerminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mutualEarlyTerminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mutualEarlyTermination = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList optionalEarlyTerminationNodeList = xmlNode.SelectNodes("optionalEarlyTermination");
            if (optionalEarlyTerminationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionalEarlyTerminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionalEarlyTerminationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(optionalEarlyTerminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionalEarlyTerminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionalEarlyTermination = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList breakFundingRecoveryNodeList = xmlNode.SelectNodes("breakFundingRecovery");
            if (breakFundingRecoveryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in breakFundingRecoveryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        breakFundingRecoveryIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(breakFundingRecoveryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        breakFundingRecoveryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        breakFundingRecovery = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList breakFeeElectionNodeList = xmlNode.SelectNodes("breakFeeElection");
            if (breakFeeElectionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in breakFeeElectionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        breakFeeElectionIDRef = item.Attributes["id"].Name;
                        FeeElectionEnum ob = FeeElectionEnum();
                        IDManager.SetID(breakFeeElectionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        breakFeeElectionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        breakFeeElection = new FeeElectionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList breakFeeRateNodeList = xmlNode.SelectNodes("breakFeeRate");
            if (breakFeeRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in breakFeeRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        breakFeeRateIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(breakFeeRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        breakFeeRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        breakFeeRate = new NonNegativeDecimal(item);
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
        
    
        #region MutualEarlyTermination
        private XsdTypeBoolean mutualEarlyTermination;
        public XsdTypeBoolean MutualEarlyTermination
        {
            get
            {
                if (this.mutualEarlyTermination != null)
                {
                    return this.mutualEarlyTermination; 
                }
                else if (this.mutualEarlyTerminationIDRef != null)
                {
                    mutualEarlyTermination = IDManager.getID(mutualEarlyTerminationIDRef) as XsdTypeBoolean;
                    return this.mutualEarlyTermination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mutualEarlyTermination != value)
                {
                    this.mutualEarlyTermination = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region OptionalEarlyTermination
        private XsdTypeBoolean optionalEarlyTermination;
        public XsdTypeBoolean OptionalEarlyTermination
        {
            get
            {
                if (this.optionalEarlyTermination != null)
                {
                    return this.optionalEarlyTermination; 
                }
                else if (this.optionalEarlyTerminationIDRef != null)
                {
                    optionalEarlyTermination = IDManager.getID(optionalEarlyTerminationIDRef) as XsdTypeBoolean;
                    return this.optionalEarlyTermination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionalEarlyTermination != value)
                {
                    this.optionalEarlyTermination = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region BreakFundingRecovery
        private XsdTypeBoolean breakFundingRecovery;
        public XsdTypeBoolean BreakFundingRecovery
        {
            get
            {
                if (this.breakFundingRecovery != null)
                {
                    return this.breakFundingRecovery; 
                }
                else if (this.breakFundingRecoveryIDRef != null)
                {
                    breakFundingRecovery = IDManager.getID(breakFundingRecoveryIDRef) as XsdTypeBoolean;
                    return this.breakFundingRecovery; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.breakFundingRecovery != value)
                {
                    this.breakFundingRecovery = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region BreakFeeElection
        private FeeElectionEnum breakFeeElection;
        public FeeElectionEnum BreakFeeElection
        {
            get
            {
                if (this.breakFeeElection != null)
                {
                    return this.breakFeeElection; 
                }
                else if (this.breakFeeElectionIDRef != null)
                {
                    breakFeeElection = IDManager.getID(breakFeeElectionIDRef) as FeeElectionEnum;
                    return this.breakFeeElection; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.breakFeeElection != value)
                {
                    this.breakFeeElection = value;
                }
            }
        }
        #endregion
        
        public string FeeElectionEnumIDRef { get; set; }
        #region BreakFeeRate
        private NonNegativeDecimal breakFeeRate;
        public NonNegativeDecimal BreakFeeRate
        {
            get
            {
                if (this.breakFeeRate != null)
                {
                    return this.breakFeeRate; 
                }
                else if (this.breakFeeRateIDRef != null)
                {
                    breakFeeRate = IDManager.getID(breakFeeRateIDRef) as NonNegativeDecimal;
                    return this.breakFeeRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.breakFeeRate != value)
                {
                    this.breakFeeRate = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
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

