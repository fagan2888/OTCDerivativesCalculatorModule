using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VarianceSwapTransactionSupplement : Product
    {
        public VarianceSwapTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList varianceLegNodeList = xmlNode.SelectNodes("varianceLeg");
            
            if (varianceLegNodeList != null)
            {
                this.varianceLeg_ = new List<VarianceLeg>();
                foreach (XmlNode item in varianceLegNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            varianceLegIDRef_ = item.Attributes["id"].Value;
                            varianceLeg_.Add(new VarianceLeg(item));
                            IDManager.SetID(varianceLegIDRef_, varianceLeg_[varianceLeg_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            varianceLegIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        varianceLeg_.Add(new VarianceLeg(item));
                        }
                    }
                    else
                    {
                        varianceLeg_.Add(new VarianceLeg(item));
                    }
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
        
    
        #region VarianceLeg_
        private List<VarianceLeg> varianceLeg_;
        public List<VarianceLeg> VarianceLeg_
        {
            get
            {
                if (this.varianceLeg_ != null)
                {
                    return this.varianceLeg_; 
                }
                else if (this.varianceLegIDRef_ != null)
                {
                    return this.varianceLeg_; 
                }
                else
                {
                      return this.varianceLeg_; 
                }
            }
            set
            {
                if (this.varianceLeg_ != value)
                {
                    this.varianceLeg_ = value;
                }
            }
        }
        #endregion
        
        public string varianceLegIDRef_ { get; set; }
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

