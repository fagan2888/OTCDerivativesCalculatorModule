using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityOptionTransactionSupplement : EquityDerivativeShortFormBase
    {
        public EquityOptionTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode exchangeLookAlikeNode = xmlNode.SelectSingleNode("exchangeLookAlike");
            
            if (exchangeLookAlikeNode != null)
            {
                if (exchangeLookAlikeNode.Attributes["href"] != null || exchangeLookAlikeNode.Attributes["id"] != null) 
                {
                    if (exchangeLookAlikeNode.Attributes["id"] != null) 
                    {
                        exchangeLookAlikeIDRef_ = exchangeLookAlikeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(exchangeLookAlikeNode);
                        IDManager.SetID(exchangeLookAlikeIDRef_, ob);
                    }
                    else if (exchangeLookAlikeNode.Attributes["href"] != null)
                    {
                        exchangeLookAlikeIDRef_ = exchangeLookAlikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeLookAlike_ = new XsdTypeBoolean(exchangeLookAlikeNode);
                    }
                }
                else
                {
                    exchangeLookAlike_ = new XsdTypeBoolean(exchangeLookAlikeNode);
                }
            }
            
        
            XmlNode exchangeTradedContractNearestNode = xmlNode.SelectSingleNode("exchangeTradedContractNearest");
            
            if (exchangeTradedContractNearestNode != null)
            {
                if (exchangeTradedContractNearestNode.Attributes["href"] != null || exchangeTradedContractNearestNode.Attributes["id"] != null) 
                {
                    if (exchangeTradedContractNearestNode.Attributes["id"] != null) 
                    {
                        exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(exchangeTradedContractNearestNode);
                        IDManager.SetID(exchangeTradedContractNearestIDRef_, ob);
                    }
                    else if (exchangeTradedContractNearestNode.Attributes["href"] != null)
                    {
                        exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeTradedContractNearest_ = new XsdTypeBoolean(exchangeTradedContractNearestNode);
                    }
                }
                else
                {
                    exchangeTradedContractNearest_ = new XsdTypeBoolean(exchangeTradedContractNearestNode);
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
            
        
            XmlNode methodOfAdjustmentNode = xmlNode.SelectSingleNode("methodOfAdjustment");
            
            if (methodOfAdjustmentNode != null)
            {
                if (methodOfAdjustmentNode.Attributes["href"] != null || methodOfAdjustmentNode.Attributes["id"] != null) 
                {
                    if (methodOfAdjustmentNode.Attributes["id"] != null) 
                    {
                        methodOfAdjustmentIDRef_ = methodOfAdjustmentNode.Attributes["id"].Value;
                        MethodOfAdjustmentEnum ob = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
                        IDManager.SetID(methodOfAdjustmentIDRef_, ob);
                    }
                    else if (methodOfAdjustmentNode.Attributes["href"] != null)
                    {
                        methodOfAdjustmentIDRef_ = methodOfAdjustmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        methodOfAdjustment_ = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
                    }
                }
                else
                {
                    methodOfAdjustment_ = new MethodOfAdjustmentEnum(methodOfAdjustmentNode);
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
            
        
            XmlNode optionEntitlementNode = xmlNode.SelectSingleNode("optionEntitlement");
            
            if (optionEntitlementNode != null)
            {
                if (optionEntitlementNode.Attributes["href"] != null || optionEntitlementNode.Attributes["id"] != null) 
                {
                    if (optionEntitlementNode.Attributes["id"] != null) 
                    {
                        optionEntitlementIDRef_ = optionEntitlementNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(optionEntitlementNode);
                        IDManager.SetID(optionEntitlementIDRef_, ob);
                    }
                    else if (optionEntitlementNode.Attributes["href"] != null)
                    {
                        optionEntitlementIDRef_ = optionEntitlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionEntitlement_ = new PositiveDecimal(optionEntitlementNode);
                    }
                }
                else
                {
                    optionEntitlement_ = new PositiveDecimal(optionEntitlementNode);
                }
            }
            
        
            XmlNode multiplierNode = xmlNode.SelectSingleNode("multiplier");
            
            if (multiplierNode != null)
            {
                if (multiplierNode.Attributes["href"] != null || multiplierNode.Attributes["id"] != null) 
                {
                    if (multiplierNode.Attributes["id"] != null) 
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(multiplierNode);
                        IDManager.SetID(multiplierIDRef_, ob);
                    }
                    else if (multiplierNode.Attributes["href"] != null)
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multiplier_ = new PositiveDecimal(multiplierNode);
                    }
                }
                else
                {
                    multiplier_ = new PositiveDecimal(multiplierNode);
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
        
    
        #region ExchangeLookAlike_
        private XsdTypeBoolean exchangeLookAlike_;
        public XsdTypeBoolean ExchangeLookAlike_
        {
            get
            {
                if (this.exchangeLookAlike_ != null)
                {
                    return this.exchangeLookAlike_; 
                }
                else if (this.exchangeLookAlikeIDRef_ != null)
                {
                    exchangeLookAlike_ = IDManager.getID(exchangeLookAlikeIDRef_) as XsdTypeBoolean;
                    return this.exchangeLookAlike_; 
                }
                else
                {
                      return this.exchangeLookAlike_; 
                }
            }
            set
            {
                if (this.exchangeLookAlike_ != value)
                {
                    this.exchangeLookAlike_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeLookAlikeIDRef_ { get; set; }
        #region ExchangeTradedContractNearest_
        private XsdTypeBoolean exchangeTradedContractNearest_;
        public XsdTypeBoolean ExchangeTradedContractNearest_
        {
            get
            {
                if (this.exchangeTradedContractNearest_ != null)
                {
                    return this.exchangeTradedContractNearest_; 
                }
                else if (this.exchangeTradedContractNearestIDRef_ != null)
                {
                    exchangeTradedContractNearest_ = IDManager.getID(exchangeTradedContractNearestIDRef_) as XsdTypeBoolean;
                    return this.exchangeTradedContractNearest_; 
                }
                else
                {
                      return this.exchangeTradedContractNearest_; 
                }
            }
            set
            {
                if (this.exchangeTradedContractNearest_ != value)
                {
                    this.exchangeTradedContractNearest_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeTradedContractNearestIDRef_ { get; set; }
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
        #region MethodOfAdjustment_
        private MethodOfAdjustmentEnum methodOfAdjustment_;
        public MethodOfAdjustmentEnum MethodOfAdjustment_
        {
            get
            {
                if (this.methodOfAdjustment_ != null)
                {
                    return this.methodOfAdjustment_; 
                }
                else if (this.methodOfAdjustmentIDRef_ != null)
                {
                    methodOfAdjustment_ = IDManager.getID(methodOfAdjustmentIDRef_) as MethodOfAdjustmentEnum;
                    return this.methodOfAdjustment_; 
                }
                else
                {
                      return this.methodOfAdjustment_; 
                }
            }
            set
            {
                if (this.methodOfAdjustment_ != value)
                {
                    this.methodOfAdjustment_ = value;
                }
            }
        }
        #endregion
        
        public string methodOfAdjustmentIDRef_ { get; set; }
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
        #region OptionEntitlement_
        private PositiveDecimal optionEntitlement_;
        public PositiveDecimal OptionEntitlement_
        {
            get
            {
                if (this.optionEntitlement_ != null)
                {
                    return this.optionEntitlement_; 
                }
                else if (this.optionEntitlementIDRef_ != null)
                {
                    optionEntitlement_ = IDManager.getID(optionEntitlementIDRef_) as PositiveDecimal;
                    return this.optionEntitlement_; 
                }
                else
                {
                      return this.optionEntitlement_; 
                }
            }
            set
            {
                if (this.optionEntitlement_ != value)
                {
                    this.optionEntitlement_ = value;
                }
            }
        }
        #endregion
        
        public string optionEntitlementIDRef_ { get; set; }
        #region Multiplier_
        private PositiveDecimal multiplier_;
        public PositiveDecimal Multiplier_
        {
            get
            {
                if (this.multiplier_ != null)
                {
                    return this.multiplier_; 
                }
                else if (this.multiplierIDRef_ != null)
                {
                    multiplier_ = IDManager.getID(multiplierIDRef_) as PositiveDecimal;
                    return this.multiplier_; 
                }
                else
                {
                      return this.multiplier_; 
                }
            }
            set
            {
                if (this.multiplier_ != value)
                {
                    this.multiplier_ = value;
                }
            }
        }
        #endregion
        
        public string multiplierIDRef_ { get; set; }
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

