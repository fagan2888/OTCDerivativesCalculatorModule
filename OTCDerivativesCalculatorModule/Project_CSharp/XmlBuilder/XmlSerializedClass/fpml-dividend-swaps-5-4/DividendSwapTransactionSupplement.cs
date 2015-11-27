using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendSwapTransactionSupplement : Product
    {
        public DividendSwapTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dividendLegNode = xmlNode.SelectSingleNode("dividendLeg");
            
            if (dividendLegNode != null)
            {
                if (dividendLegNode.Attributes["href"] != null || dividendLegNode.Attributes["id"] != null) 
                {
                    if (dividendLegNode.Attributes["id"] != null) 
                    {
                        dividendLegIDRef_ = dividendLegNode.Attributes["id"].Value;
                        DividendLeg ob = new DividendLeg(dividendLegNode);
                        IDManager.SetID(dividendLegIDRef_, ob);
                    }
                    else if (dividendLegNode.Attributes["href"] != null)
                    {
                        dividendLegIDRef_ = dividendLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendLeg_ = new DividendLeg(dividendLegNode);
                    }
                }
                else
                {
                    dividendLeg_ = new DividendLeg(dividendLegNode);
                }
            }
            
        
            XmlNode fixedLegNode = xmlNode.SelectSingleNode("fixedLeg");
            
            if (fixedLegNode != null)
            {
                if (fixedLegNode.Attributes["href"] != null || fixedLegNode.Attributes["id"] != null) 
                {
                    if (fixedLegNode.Attributes["id"] != null) 
                    {
                        fixedLegIDRef_ = fixedLegNode.Attributes["id"].Value;
                        FixedPaymentLeg ob = new FixedPaymentLeg(fixedLegNode);
                        IDManager.SetID(fixedLegIDRef_, ob);
                    }
                    else if (fixedLegNode.Attributes["href"] != null)
                    {
                        fixedLegIDRef_ = fixedLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedLeg_ = new FixedPaymentLeg(fixedLegNode);
                    }
                }
                else
                {
                    fixedLeg_ = new FixedPaymentLeg(fixedLegNode);
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
            
        
        }
        
    
        #region DividendLeg_
        private DividendLeg dividendLeg_;
        public DividendLeg DividendLeg_
        {
            get
            {
                if (this.dividendLeg_ != null)
                {
                    return this.dividendLeg_; 
                }
                else if (this.dividendLegIDRef_ != null)
                {
                    dividendLeg_ = IDManager.getID(dividendLegIDRef_) as DividendLeg;
                    return this.dividendLeg_; 
                }
                else
                {
                      return this.dividendLeg_; 
                }
            }
            set
            {
                if (this.dividendLeg_ != value)
                {
                    this.dividendLeg_ = value;
                }
            }
        }
        #endregion
        
        public string dividendLegIDRef_ { get; set; }
        #region FixedLeg_
        private FixedPaymentLeg fixedLeg_;
        public FixedPaymentLeg FixedLeg_
        {
            get
            {
                if (this.fixedLeg_ != null)
                {
                    return this.fixedLeg_; 
                }
                else if (this.fixedLegIDRef_ != null)
                {
                    fixedLeg_ = IDManager.getID(fixedLegIDRef_) as FixedPaymentLeg;
                    return this.fixedLeg_; 
                }
                else
                {
                      return this.fixedLeg_; 
                }
            }
            set
            {
                if (this.fixedLeg_ != value)
                {
                    this.fixedLeg_ = value;
                }
            }
        }
        #endregion
        
        public string fixedLegIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

