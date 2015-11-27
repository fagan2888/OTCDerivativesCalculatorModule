using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquitySwapTransactionSupplement : ReturnSwapBase
    {
        public EquitySwapTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode mutualEarlyTerminationNode = xmlNode.SelectSingleNode("mutualEarlyTermination");
            
            if (mutualEarlyTerminationNode != null)
            {
                if (mutualEarlyTerminationNode.Attributes["href"] != null || mutualEarlyTerminationNode.Attributes["id"] != null) 
                {
                    if (mutualEarlyTerminationNode.Attributes["id"] != null) 
                    {
                        mutualEarlyTerminationIDRef_ = mutualEarlyTerminationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(mutualEarlyTerminationNode);
                        IDManager.SetID(mutualEarlyTerminationIDRef_, ob);
                    }
                    else if (mutualEarlyTerminationNode.Attributes["href"] != null)
                    {
                        mutualEarlyTerminationIDRef_ = mutualEarlyTerminationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mutualEarlyTermination_ = new XsdTypeBoolean(mutualEarlyTerminationNode);
                    }
                }
                else
                {
                    mutualEarlyTermination_ = new XsdTypeBoolean(mutualEarlyTerminationNode);
                }
            }
            
        
            XmlNode optionalEarlyTerminationNode = xmlNode.SelectSingleNode("optionalEarlyTermination");
            
            if (optionalEarlyTerminationNode != null)
            {
                if (optionalEarlyTerminationNode.Attributes["href"] != null || optionalEarlyTerminationNode.Attributes["id"] != null) 
                {
                    if (optionalEarlyTerminationNode.Attributes["id"] != null) 
                    {
                        optionalEarlyTerminationIDRef_ = optionalEarlyTerminationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(optionalEarlyTerminationNode);
                        IDManager.SetID(optionalEarlyTerminationIDRef_, ob);
                    }
                    else if (optionalEarlyTerminationNode.Attributes["href"] != null)
                    {
                        optionalEarlyTerminationIDRef_ = optionalEarlyTerminationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionalEarlyTermination_ = new XsdTypeBoolean(optionalEarlyTerminationNode);
                    }
                }
                else
                {
                    optionalEarlyTermination_ = new XsdTypeBoolean(optionalEarlyTerminationNode);
                }
            }
            
        
            XmlNode breakFundingRecoveryNode = xmlNode.SelectSingleNode("breakFundingRecovery");
            
            if (breakFundingRecoveryNode != null)
            {
                if (breakFundingRecoveryNode.Attributes["href"] != null || breakFundingRecoveryNode.Attributes["id"] != null) 
                {
                    if (breakFundingRecoveryNode.Attributes["id"] != null) 
                    {
                        breakFundingRecoveryIDRef_ = breakFundingRecoveryNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(breakFundingRecoveryNode);
                        IDManager.SetID(breakFundingRecoveryIDRef_, ob);
                    }
                    else if (breakFundingRecoveryNode.Attributes["href"] != null)
                    {
                        breakFundingRecoveryIDRef_ = breakFundingRecoveryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        breakFundingRecovery_ = new XsdTypeBoolean(breakFundingRecoveryNode);
                    }
                }
                else
                {
                    breakFundingRecovery_ = new XsdTypeBoolean(breakFundingRecoveryNode);
                }
            }
            
        
            XmlNode breakFeeElectionNode = xmlNode.SelectSingleNode("breakFeeElection");
            
            if (breakFeeElectionNode != null)
            {
                if (breakFeeElectionNode.Attributes["href"] != null || breakFeeElectionNode.Attributes["id"] != null) 
                {
                    if (breakFeeElectionNode.Attributes["id"] != null) 
                    {
                        breakFeeElectionIDRef_ = breakFeeElectionNode.Attributes["id"].Value;
                        FeeElectionEnum ob = new FeeElectionEnum(breakFeeElectionNode);
                        IDManager.SetID(breakFeeElectionIDRef_, ob);
                    }
                    else if (breakFeeElectionNode.Attributes["href"] != null)
                    {
                        breakFeeElectionIDRef_ = breakFeeElectionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        breakFeeElection_ = new FeeElectionEnum(breakFeeElectionNode);
                    }
                }
                else
                {
                    breakFeeElection_ = new FeeElectionEnum(breakFeeElectionNode);
                }
            }
            
        
            XmlNode breakFeeRateNode = xmlNode.SelectSingleNode("breakFeeRate");
            
            if (breakFeeRateNode != null)
            {
                if (breakFeeRateNode.Attributes["href"] != null || breakFeeRateNode.Attributes["id"] != null) 
                {
                    if (breakFeeRateNode.Attributes["id"] != null) 
                    {
                        breakFeeRateIDRef_ = breakFeeRateNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(breakFeeRateNode);
                        IDManager.SetID(breakFeeRateIDRef_, ob);
                    }
                    else if (breakFeeRateNode.Attributes["href"] != null)
                    {
                        breakFeeRateIDRef_ = breakFeeRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        breakFeeRate_ = new NonNegativeDecimal(breakFeeRateNode);
                    }
                }
                else
                {
                    breakFeeRate_ = new NonNegativeDecimal(breakFeeRateNode);
                }
            }
            
        
            XmlNode multipleExchangeIndexAnnexFallbackNode = xmlNode.SelectSingleNode("multipleExchangeIndexAnnexFallback");
            
            if (multipleExchangeIndexAnnexFallbackNode != null)
            {
                if (multipleExchangeIndexAnnexFallbackNode.Attributes["href"] != null || multipleExchangeIndexAnnexFallbackNode.Attributes["id"] != null) 
                {
                    if (multipleExchangeIndexAnnexFallbackNode.Attributes["id"] != null) 
                    {
                        multipleExchangeIndexAnnexFallbackIDRef_ = multipleExchangeIndexAnnexFallbackNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode);
                        IDManager.SetID(multipleExchangeIndexAnnexFallbackIDRef_, ob);
                    }
                    else if (multipleExchangeIndexAnnexFallbackNode.Attributes["href"] != null)
                    {
                        multipleExchangeIndexAnnexFallbackIDRef_ = multipleExchangeIndexAnnexFallbackNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleExchangeIndexAnnexFallback_ = new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode);
                    }
                }
                else
                {
                    multipleExchangeIndexAnnexFallback_ = new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode);
                }
            }
            
        
            XmlNode componentSecurityIndexAnnexFallbackNode = xmlNode.SelectSingleNode("componentSecurityIndexAnnexFallback");
            
            if (componentSecurityIndexAnnexFallbackNode != null)
            {
                if (componentSecurityIndexAnnexFallbackNode.Attributes["href"] != null || componentSecurityIndexAnnexFallbackNode.Attributes["id"] != null) 
                {
                    if (componentSecurityIndexAnnexFallbackNode.Attributes["id"] != null) 
                    {
                        componentSecurityIndexAnnexFallbackIDRef_ = componentSecurityIndexAnnexFallbackNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode);
                        IDManager.SetID(componentSecurityIndexAnnexFallbackIDRef_, ob);
                    }
                    else if (componentSecurityIndexAnnexFallbackNode.Attributes["href"] != null)
                    {
                        componentSecurityIndexAnnexFallbackIDRef_ = componentSecurityIndexAnnexFallbackNode.Attributes["href"].Value;
                    }
                    else
                    {
                        componentSecurityIndexAnnexFallback_ = new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode);
                    }
                }
                else
                {
                    componentSecurityIndexAnnexFallback_ = new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode);
                }
            }
            
        
            XmlNode localJurisdictionNode = xmlNode.SelectSingleNode("localJurisdiction");
            
            if (localJurisdictionNode != null)
            {
                if (localJurisdictionNode.Attributes["href"] != null || localJurisdictionNode.Attributes["id"] != null) 
                {
                    if (localJurisdictionNode.Attributes["id"] != null) 
                    {
                        localJurisdictionIDRef_ = localJurisdictionNode.Attributes["id"].Value;
                        CountryCode ob = new CountryCode(localJurisdictionNode);
                        IDManager.SetID(localJurisdictionIDRef_, ob);
                    }
                    else if (localJurisdictionNode.Attributes["href"] != null)
                    {
                        localJurisdictionIDRef_ = localJurisdictionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        localJurisdiction_ = new CountryCode(localJurisdictionNode);
                    }
                }
                else
                {
                    localJurisdiction_ = new CountryCode(localJurisdictionNode);
                }
            }
            
        
            XmlNode relevantJurisdictionNode = xmlNode.SelectSingleNode("relevantJurisdiction");
            
            if (relevantJurisdictionNode != null)
            {
                if (relevantJurisdictionNode.Attributes["href"] != null || relevantJurisdictionNode.Attributes["id"] != null) 
                {
                    if (relevantJurisdictionNode.Attributes["id"] != null) 
                    {
                        relevantJurisdictionIDRef_ = relevantJurisdictionNode.Attributes["id"].Value;
                        CountryCode ob = new CountryCode(relevantJurisdictionNode);
                        IDManager.SetID(relevantJurisdictionIDRef_, ob);
                    }
                    else if (relevantJurisdictionNode.Attributes["href"] != null)
                    {
                        relevantJurisdictionIDRef_ = relevantJurisdictionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relevantJurisdiction_ = new CountryCode(relevantJurisdictionNode);
                    }
                }
                else
                {
                    relevantJurisdiction_ = new CountryCode(relevantJurisdictionNode);
                }
            }
            
        
            XmlNode extraordinaryEventsNode = xmlNode.SelectSingleNode("extraordinaryEvents");
            
            if (extraordinaryEventsNode != null)
            {
                if (extraordinaryEventsNode.Attributes["href"] != null || extraordinaryEventsNode.Attributes["id"] != null) 
                {
                    if (extraordinaryEventsNode.Attributes["id"] != null) 
                    {
                        extraordinaryEventsIDRef_ = extraordinaryEventsNode.Attributes["id"].Value;
                        ExtraordinaryEvents ob = new ExtraordinaryEvents(extraordinaryEventsNode);
                        IDManager.SetID(extraordinaryEventsIDRef_, ob);
                    }
                    else if (extraordinaryEventsNode.Attributes["href"] != null)
                    {
                        extraordinaryEventsIDRef_ = extraordinaryEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        extraordinaryEvents_ = new ExtraordinaryEvents(extraordinaryEventsNode);
                    }
                }
                else
                {
                    extraordinaryEvents_ = new ExtraordinaryEvents(extraordinaryEventsNode);
                }
            }
            
        
        }
        
    
        #region MutualEarlyTermination_
        private XsdTypeBoolean mutualEarlyTermination_;
        public XsdTypeBoolean MutualEarlyTermination_
        {
            get
            {
                if (this.mutualEarlyTermination_ != null)
                {
                    return this.mutualEarlyTermination_; 
                }
                else if (this.mutualEarlyTerminationIDRef_ != null)
                {
                    mutualEarlyTermination_ = IDManager.getID(mutualEarlyTerminationIDRef_) as XsdTypeBoolean;
                    return this.mutualEarlyTermination_; 
                }
                else
                {
                      return this.mutualEarlyTermination_; 
                }
            }
            set
            {
                if (this.mutualEarlyTermination_ != value)
                {
                    this.mutualEarlyTermination_ = value;
                }
            }
        }
        #endregion
        
        public string mutualEarlyTerminationIDRef_ { get; set; }
        #region OptionalEarlyTermination_
        private XsdTypeBoolean optionalEarlyTermination_;
        public XsdTypeBoolean OptionalEarlyTermination_
        {
            get
            {
                if (this.optionalEarlyTermination_ != null)
                {
                    return this.optionalEarlyTermination_; 
                }
                else if (this.optionalEarlyTerminationIDRef_ != null)
                {
                    optionalEarlyTermination_ = IDManager.getID(optionalEarlyTerminationIDRef_) as XsdTypeBoolean;
                    return this.optionalEarlyTermination_; 
                }
                else
                {
                      return this.optionalEarlyTermination_; 
                }
            }
            set
            {
                if (this.optionalEarlyTermination_ != value)
                {
                    this.optionalEarlyTermination_ = value;
                }
            }
        }
        #endregion
        
        public string optionalEarlyTerminationIDRef_ { get; set; }
        #region BreakFundingRecovery_
        private XsdTypeBoolean breakFundingRecovery_;
        public XsdTypeBoolean BreakFundingRecovery_
        {
            get
            {
                if (this.breakFundingRecovery_ != null)
                {
                    return this.breakFundingRecovery_; 
                }
                else if (this.breakFundingRecoveryIDRef_ != null)
                {
                    breakFundingRecovery_ = IDManager.getID(breakFundingRecoveryIDRef_) as XsdTypeBoolean;
                    return this.breakFundingRecovery_; 
                }
                else
                {
                      return this.breakFundingRecovery_; 
                }
            }
            set
            {
                if (this.breakFundingRecovery_ != value)
                {
                    this.breakFundingRecovery_ = value;
                }
            }
        }
        #endregion
        
        public string breakFundingRecoveryIDRef_ { get; set; }
        #region BreakFeeElection_
        private FeeElectionEnum breakFeeElection_;
        public FeeElectionEnum BreakFeeElection_
        {
            get
            {
                if (this.breakFeeElection_ != null)
                {
                    return this.breakFeeElection_; 
                }
                else if (this.breakFeeElectionIDRef_ != null)
                {
                    breakFeeElection_ = IDManager.getID(breakFeeElectionIDRef_) as FeeElectionEnum;
                    return this.breakFeeElection_; 
                }
                else
                {
                      return this.breakFeeElection_; 
                }
            }
            set
            {
                if (this.breakFeeElection_ != value)
                {
                    this.breakFeeElection_ = value;
                }
            }
        }
        #endregion
        
        public string breakFeeElectionIDRef_ { get; set; }
        #region BreakFeeRate_
        private NonNegativeDecimal breakFeeRate_;
        public NonNegativeDecimal BreakFeeRate_
        {
            get
            {
                if (this.breakFeeRate_ != null)
                {
                    return this.breakFeeRate_; 
                }
                else if (this.breakFeeRateIDRef_ != null)
                {
                    breakFeeRate_ = IDManager.getID(breakFeeRateIDRef_) as NonNegativeDecimal;
                    return this.breakFeeRate_; 
                }
                else
                {
                      return this.breakFeeRate_; 
                }
            }
            set
            {
                if (this.breakFeeRate_ != value)
                {
                    this.breakFeeRate_ = value;
                }
            }
        }
        #endregion
        
        public string breakFeeRateIDRef_ { get; set; }
        #region MultipleExchangeIndexAnnexFallback_
        private XsdTypeBoolean multipleExchangeIndexAnnexFallback_;
        public XsdTypeBoolean MultipleExchangeIndexAnnexFallback_
        {
            get
            {
                if (this.multipleExchangeIndexAnnexFallback_ != null)
                {
                    return this.multipleExchangeIndexAnnexFallback_; 
                }
                else if (this.multipleExchangeIndexAnnexFallbackIDRef_ != null)
                {
                    multipleExchangeIndexAnnexFallback_ = IDManager.getID(multipleExchangeIndexAnnexFallbackIDRef_) as XsdTypeBoolean;
                    return this.multipleExchangeIndexAnnexFallback_; 
                }
                else
                {
                      return this.multipleExchangeIndexAnnexFallback_; 
                }
            }
            set
            {
                if (this.multipleExchangeIndexAnnexFallback_ != value)
                {
                    this.multipleExchangeIndexAnnexFallback_ = value;
                }
            }
        }
        #endregion
        
        public string multipleExchangeIndexAnnexFallbackIDRef_ { get; set; }
        #region ComponentSecurityIndexAnnexFallback_
        private XsdTypeBoolean componentSecurityIndexAnnexFallback_;
        public XsdTypeBoolean ComponentSecurityIndexAnnexFallback_
        {
            get
            {
                if (this.componentSecurityIndexAnnexFallback_ != null)
                {
                    return this.componentSecurityIndexAnnexFallback_; 
                }
                else if (this.componentSecurityIndexAnnexFallbackIDRef_ != null)
                {
                    componentSecurityIndexAnnexFallback_ = IDManager.getID(componentSecurityIndexAnnexFallbackIDRef_) as XsdTypeBoolean;
                    return this.componentSecurityIndexAnnexFallback_; 
                }
                else
                {
                      return this.componentSecurityIndexAnnexFallback_; 
                }
            }
            set
            {
                if (this.componentSecurityIndexAnnexFallback_ != value)
                {
                    this.componentSecurityIndexAnnexFallback_ = value;
                }
            }
        }
        #endregion
        
        public string componentSecurityIndexAnnexFallbackIDRef_ { get; set; }
        #region LocalJurisdiction_
        private CountryCode localJurisdiction_;
        public CountryCode LocalJurisdiction_
        {
            get
            {
                if (this.localJurisdiction_ != null)
                {
                    return this.localJurisdiction_; 
                }
                else if (this.localJurisdictionIDRef_ != null)
                {
                    localJurisdiction_ = IDManager.getID(localJurisdictionIDRef_) as CountryCode;
                    return this.localJurisdiction_; 
                }
                else
                {
                      return this.localJurisdiction_; 
                }
            }
            set
            {
                if (this.localJurisdiction_ != value)
                {
                    this.localJurisdiction_ = value;
                }
            }
        }
        #endregion
        
        public string localJurisdictionIDRef_ { get; set; }
        #region RelevantJurisdiction_
        private CountryCode relevantJurisdiction_;
        public CountryCode RelevantJurisdiction_
        {
            get
            {
                if (this.relevantJurisdiction_ != null)
                {
                    return this.relevantJurisdiction_; 
                }
                else if (this.relevantJurisdictionIDRef_ != null)
                {
                    relevantJurisdiction_ = IDManager.getID(relevantJurisdictionIDRef_) as CountryCode;
                    return this.relevantJurisdiction_; 
                }
                else
                {
                      return this.relevantJurisdiction_; 
                }
            }
            set
            {
                if (this.relevantJurisdiction_ != value)
                {
                    this.relevantJurisdiction_ = value;
                }
            }
        }
        #endregion
        
        public string relevantJurisdictionIDRef_ { get; set; }
        #region ExtraordinaryEvents_
        private ExtraordinaryEvents extraordinaryEvents_;
        public ExtraordinaryEvents ExtraordinaryEvents_
        {
            get
            {
                if (this.extraordinaryEvents_ != null)
                {
                    return this.extraordinaryEvents_; 
                }
                else if (this.extraordinaryEventsIDRef_ != null)
                {
                    extraordinaryEvents_ = IDManager.getID(extraordinaryEventsIDRef_) as ExtraordinaryEvents;
                    return this.extraordinaryEvents_; 
                }
                else
                {
                      return this.extraordinaryEvents_; 
                }
            }
            set
            {
                if (this.extraordinaryEvents_ != value)
                {
                    this.extraordinaryEvents_ = value;
                }
            }
        }
        #endregion
        
        public string extraordinaryEventsIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

