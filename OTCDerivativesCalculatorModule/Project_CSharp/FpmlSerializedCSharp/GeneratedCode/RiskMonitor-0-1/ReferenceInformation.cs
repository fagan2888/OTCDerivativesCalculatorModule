using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class ReferenceInformation : ISerialized
    {
        public ReferenceInformation() { }
        public ReferenceInformation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode referenceEntityNode = xmlNode.SelectSingleNode("referenceEntity");
            
            if (referenceEntityNode != null)
            {
                if (referenceEntityNode.Attributes["href"] != null || referenceEntityNode.Attributes["id"] != null) 
                {
                    if (referenceEntityNode.Attributes["id"] != null) 
                    {
                        referenceEntityIDRef_ = referenceEntityNode.Attributes["id"].Value;
                        ReferenceEntity ob = new ReferenceEntity(referenceEntityNode);
                        IDManager.SetID(referenceEntityIDRef_, ob);
                    }
                    else if (referenceEntityNode.Attributes["href"] != null)
                    {
                        referenceEntityIDRef_ = referenceEntityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceEntity_ = new ReferenceEntity(referenceEntityNode);
                    }
                }
                else
                {
                    referenceEntity_ = new ReferenceEntity(referenceEntityNode);
                }
            }
            
        
            XmlNode referenceObligationNode = xmlNode.SelectSingleNode("referenceObligation");
            
            if (referenceObligationNode != null)
            {
                if (referenceObligationNode.Attributes["href"] != null || referenceObligationNode.Attributes["id"] != null) 
                {
                    if (referenceObligationNode.Attributes["id"] != null) 
                    {
                        referenceObligationIDRef_ = referenceObligationNode.Attributes["id"].Value;
                        ReferenceObligation ob = new ReferenceObligation(referenceObligationNode);
                        IDManager.SetID(referenceObligationIDRef_, ob);
                    }
                    else if (referenceObligationNode.Attributes["href"] != null)
                    {
                        referenceObligationIDRef_ = referenceObligationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceObligation_ = new ReferenceObligation(referenceObligationNode);
                    }
                }
                else
                {
                    referenceObligation_ = new ReferenceObligation(referenceObligationNode);
                }
            }
            
        
            XmlNode referencePriceNode = xmlNode.SelectSingleNode("referencePrice");
            
            if (referencePriceNode != null)
            {
                if (referencePriceNode.Attributes["href"] != null || referencePriceNode.Attributes["id"] != null) 
                {
                    if (referencePriceNode.Attributes["id"] != null) 
                    {
                        referencePriceIDRef_ = referencePriceNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(referencePriceNode);
                        IDManager.SetID(referencePriceIDRef_, ob);
                    }
                    else if (referencePriceNode.Attributes["href"] != null)
                    {
                        referencePriceIDRef_ = referencePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referencePrice_ = new XsdTypeDouble(referencePriceNode);
                    }
                }
                else
                {
                    referencePrice_ = new XsdTypeDouble(referencePriceNode);
                }
            }
            
        
        }
        
    
        #region ReferenceEntity_
        private ReferenceEntity referenceEntity_;
        public ReferenceEntity ReferenceEntity_
        {
            get
            {
                if (this.referenceEntity_ != null)
                {
                    return this.referenceEntity_; 
                }
                else if (this.referenceEntityIDRef_ != null)
                {
                    referenceEntity_ = IDManager.getID(referenceEntityIDRef_) as ReferenceEntity;
                    return this.referenceEntity_; 
                }
                else
                {
                      return this.referenceEntity_; 
                }
            }
            set
            {
                if (this.referenceEntity_ != value)
                {
                    this.referenceEntity_ = value;
                }
            }
        }
        #endregion
        
        public string referenceEntityIDRef_ { get; set; }
        #region ReferenceObligation_
        private ReferenceObligation referenceObligation_;
        public ReferenceObligation ReferenceObligation_
        {
            get
            {
                if (this.referenceObligation_ != null)
                {
                    return this.referenceObligation_; 
                }
                else if (this.referenceObligationIDRef_ != null)
                {
                    referenceObligation_ = IDManager.getID(referenceObligationIDRef_) as ReferenceObligation;
                    return this.referenceObligation_; 
                }
                else
                {
                      return this.referenceObligation_; 
                }
            }
            set
            {
                if (this.referenceObligation_ != value)
                {
                    this.referenceObligation_ = value;
                }
            }
        }
        #endregion
        
        public string referenceObligationIDRef_ { get; set; }
        #region ReferencePrice_
        private XsdTypeDouble referencePrice_;
        public XsdTypeDouble ReferencePrice_
        {
            get
            {
                if (this.referencePrice_ != null)
                {
                    return this.referencePrice_; 
                }
                else if (this.referencePriceIDRef_ != null)
                {
                    referencePrice_ = IDManager.getID(referencePriceIDRef_) as XsdTypeDouble;
                    return this.referencePrice_; 
                }
                else
                {
                      return this.referencePrice_; 
                }
            }
            set
            {
                if (this.referencePrice_ != value)
                {
                    this.referencePrice_ = value;
                }
            }
        }
        #endregion
        
        public string referencePriceIDRef_ { get; set; }
        
    
        
    
    }
    
}

