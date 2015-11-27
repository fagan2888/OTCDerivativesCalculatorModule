using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceInformation : ISerialized
    {
        public ReferenceInformation(XmlNode xmlNode)
        {
            XmlNode referenceEntityNode = xmlNode.SelectSingleNode("referenceEntity");
            
            if (referenceEntityNode != null)
            {
                if (referenceEntityNode.Attributes["href"] != null || referenceEntityNode.Attributes["id"] != null) 
                {
                    if (referenceEntityNode.Attributes["id"] != null) 
                    {
                        referenceEntityIDRef_ = referenceEntityNode.Attributes["id"].Value;
                        LegalEntity ob = new LegalEntity(referenceEntityNode);
                        IDManager.SetID(referenceEntityIDRef_, ob);
                    }
                    else if (referenceEntityNode.Attributes["href"] != null)
                    {
                        referenceEntityIDRef_ = referenceEntityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceEntity_ = new LegalEntity(referenceEntityNode);
                    }
                }
                else
                {
                    referenceEntity_ = new LegalEntity(referenceEntityNode);
                }
            }
            
        
            XmlNodeList referenceObligationNodeList = xmlNode.SelectNodes("referenceObligation");
            
            if (referenceObligationNodeList != null)
            {
                this.referenceObligation_ = new List<ReferenceObligation>();
                foreach (XmlNode item in referenceObligationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            referenceObligationIDRef_ = item.Attributes["id"].Value;
                            referenceObligation_.Add(new ReferenceObligation(item));
                            IDManager.SetID(referenceObligationIDRef_, referenceObligation_[referenceObligation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            referenceObligationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        referenceObligation_.Add(new ReferenceObligation(item));
                        }
                    }
                    else
                    {
                        referenceObligation_.Add(new ReferenceObligation(item));
                    }
                }
            }
            
        
            XmlNode noReferenceObligationNode = xmlNode.SelectSingleNode("noReferenceObligation");
            
            if (noReferenceObligationNode != null)
            {
                if (noReferenceObligationNode.Attributes["href"] != null || noReferenceObligationNode.Attributes["id"] != null) 
                {
                    if (noReferenceObligationNode.Attributes["id"] != null) 
                    {
                        noReferenceObligationIDRef_ = noReferenceObligationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(noReferenceObligationNode);
                        IDManager.SetID(noReferenceObligationIDRef_, ob);
                    }
                    else if (noReferenceObligationNode.Attributes["href"] != null)
                    {
                        noReferenceObligationIDRef_ = noReferenceObligationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        noReferenceObligation_ = new XsdTypeBoolean(noReferenceObligationNode);
                    }
                }
                else
                {
                    noReferenceObligation_ = new XsdTypeBoolean(noReferenceObligationNode);
                }
            }
            
        
            XmlNode unknownReferenceObligationNode = xmlNode.SelectSingleNode("unknownReferenceObligation");
            
            if (unknownReferenceObligationNode != null)
            {
                if (unknownReferenceObligationNode.Attributes["href"] != null || unknownReferenceObligationNode.Attributes["id"] != null) 
                {
                    if (unknownReferenceObligationNode.Attributes["id"] != null) 
                    {
                        unknownReferenceObligationIDRef_ = unknownReferenceObligationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(unknownReferenceObligationNode);
                        IDManager.SetID(unknownReferenceObligationIDRef_, ob);
                    }
                    else if (unknownReferenceObligationNode.Attributes["href"] != null)
                    {
                        unknownReferenceObligationIDRef_ = unknownReferenceObligationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unknownReferenceObligation_ = new XsdTypeBoolean(unknownReferenceObligationNode);
                    }
                }
                else
                {
                    unknownReferenceObligation_ = new XsdTypeBoolean(unknownReferenceObligationNode);
                }
            }
            
        
            XmlNode allGuaranteesNode = xmlNode.SelectSingleNode("allGuarantees");
            
            if (allGuaranteesNode != null)
            {
                if (allGuaranteesNode.Attributes["href"] != null || allGuaranteesNode.Attributes["id"] != null) 
                {
                    if (allGuaranteesNode.Attributes["id"] != null) 
                    {
                        allGuaranteesIDRef_ = allGuaranteesNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(allGuaranteesNode);
                        IDManager.SetID(allGuaranteesIDRef_, ob);
                    }
                    else if (allGuaranteesNode.Attributes["href"] != null)
                    {
                        allGuaranteesIDRef_ = allGuaranteesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allGuarantees_ = new XsdTypeBoolean(allGuaranteesNode);
                    }
                }
                else
                {
                    allGuarantees_ = new XsdTypeBoolean(allGuaranteesNode);
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
                        XsdTypeDecimal ob = new XsdTypeDecimal(referencePriceNode);
                        IDManager.SetID(referencePriceIDRef_, ob);
                    }
                    else if (referencePriceNode.Attributes["href"] != null)
                    {
                        referencePriceIDRef_ = referencePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referencePrice_ = new XsdTypeDecimal(referencePriceNode);
                    }
                }
                else
                {
                    referencePrice_ = new XsdTypeDecimal(referencePriceNode);
                }
            }
            
        
            XmlNode referencePolicyNode = xmlNode.SelectSingleNode("referencePolicy");
            
            if (referencePolicyNode != null)
            {
                if (referencePolicyNode.Attributes["href"] != null || referencePolicyNode.Attributes["id"] != null) 
                {
                    if (referencePolicyNode.Attributes["id"] != null) 
                    {
                        referencePolicyIDRef_ = referencePolicyNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(referencePolicyNode);
                        IDManager.SetID(referencePolicyIDRef_, ob);
                    }
                    else if (referencePolicyNode.Attributes["href"] != null)
                    {
                        referencePolicyIDRef_ = referencePolicyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referencePolicy_ = new XsdTypeBoolean(referencePolicyNode);
                    }
                }
                else
                {
                    referencePolicy_ = new XsdTypeBoolean(referencePolicyNode);
                }
            }
            
        
            XmlNode securedListNode = xmlNode.SelectSingleNode("securedList");
            
            if (securedListNode != null)
            {
                if (securedListNode.Attributes["href"] != null || securedListNode.Attributes["id"] != null) 
                {
                    if (securedListNode.Attributes["id"] != null) 
                    {
                        securedListIDRef_ = securedListNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(securedListNode);
                        IDManager.SetID(securedListIDRef_, ob);
                    }
                    else if (securedListNode.Attributes["href"] != null)
                    {
                        securedListIDRef_ = securedListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        securedList_ = new XsdTypeBoolean(securedListNode);
                    }
                }
                else
                {
                    securedList_ = new XsdTypeBoolean(securedListNode);
                }
            }
            
        
        }
        
    
        #region ReferenceEntity_
        private LegalEntity referenceEntity_;
        public LegalEntity ReferenceEntity_
        {
            get
            {
                if (this.referenceEntity_ != null)
                {
                    return this.referenceEntity_; 
                }
                else if (this.referenceEntityIDRef_ != null)
                {
                    referenceEntity_ = IDManager.getID(referenceEntityIDRef_) as LegalEntity;
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
        private List<ReferenceObligation> referenceObligation_;
        public List<ReferenceObligation> ReferenceObligation_
        {
            get
            {
                if (this.referenceObligation_ != null)
                {
                    return this.referenceObligation_; 
                }
                else if (this.referenceObligationIDRef_ != null)
                {
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
        #region NoReferenceObligation_
        private XsdTypeBoolean noReferenceObligation_;
        public XsdTypeBoolean NoReferenceObligation_
        {
            get
            {
                if (this.noReferenceObligation_ != null)
                {
                    return this.noReferenceObligation_; 
                }
                else if (this.noReferenceObligationIDRef_ != null)
                {
                    noReferenceObligation_ = IDManager.getID(noReferenceObligationIDRef_) as XsdTypeBoolean;
                    return this.noReferenceObligation_; 
                }
                else
                {
                      return this.noReferenceObligation_; 
                }
            }
            set
            {
                if (this.noReferenceObligation_ != value)
                {
                    this.noReferenceObligation_ = value;
                }
            }
        }
        #endregion
        
        public string noReferenceObligationIDRef_ { get; set; }
        #region UnknownReferenceObligation_
        private XsdTypeBoolean unknownReferenceObligation_;
        public XsdTypeBoolean UnknownReferenceObligation_
        {
            get
            {
                if (this.unknownReferenceObligation_ != null)
                {
                    return this.unknownReferenceObligation_; 
                }
                else if (this.unknownReferenceObligationIDRef_ != null)
                {
                    unknownReferenceObligation_ = IDManager.getID(unknownReferenceObligationIDRef_) as XsdTypeBoolean;
                    return this.unknownReferenceObligation_; 
                }
                else
                {
                      return this.unknownReferenceObligation_; 
                }
            }
            set
            {
                if (this.unknownReferenceObligation_ != value)
                {
                    this.unknownReferenceObligation_ = value;
                }
            }
        }
        #endregion
        
        public string unknownReferenceObligationIDRef_ { get; set; }
        #region AllGuarantees_
        private XsdTypeBoolean allGuarantees_;
        public XsdTypeBoolean AllGuarantees_
        {
            get
            {
                if (this.allGuarantees_ != null)
                {
                    return this.allGuarantees_; 
                }
                else if (this.allGuaranteesIDRef_ != null)
                {
                    allGuarantees_ = IDManager.getID(allGuaranteesIDRef_) as XsdTypeBoolean;
                    return this.allGuarantees_; 
                }
                else
                {
                      return this.allGuarantees_; 
                }
            }
            set
            {
                if (this.allGuarantees_ != value)
                {
                    this.allGuarantees_ = value;
                }
            }
        }
        #endregion
        
        public string allGuaranteesIDRef_ { get; set; }
        #region ReferencePrice_
        private XsdTypeDecimal referencePrice_;
        public XsdTypeDecimal ReferencePrice_
        {
            get
            {
                if (this.referencePrice_ != null)
                {
                    return this.referencePrice_; 
                }
                else if (this.referencePriceIDRef_ != null)
                {
                    referencePrice_ = IDManager.getID(referencePriceIDRef_) as XsdTypeDecimal;
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
        #region ReferencePolicy_
        private XsdTypeBoolean referencePolicy_;
        public XsdTypeBoolean ReferencePolicy_
        {
            get
            {
                if (this.referencePolicy_ != null)
                {
                    return this.referencePolicy_; 
                }
                else if (this.referencePolicyIDRef_ != null)
                {
                    referencePolicy_ = IDManager.getID(referencePolicyIDRef_) as XsdTypeBoolean;
                    return this.referencePolicy_; 
                }
                else
                {
                      return this.referencePolicy_; 
                }
            }
            set
            {
                if (this.referencePolicy_ != value)
                {
                    this.referencePolicy_ = value;
                }
            }
        }
        #endregion
        
        public string referencePolicyIDRef_ { get; set; }
        #region SecuredList_
        private XsdTypeBoolean securedList_;
        public XsdTypeBoolean SecuredList_
        {
            get
            {
                if (this.securedList_ != null)
                {
                    return this.securedList_; 
                }
                else if (this.securedListIDRef_ != null)
                {
                    securedList_ = IDManager.getID(securedListIDRef_) as XsdTypeBoolean;
                    return this.securedList_; 
                }
                else
                {
                      return this.securedList_; 
                }
            }
            set
            {
                if (this.securedList_ != value)
                {
                    this.securedList_ = value;
                }
            }
        }
        #endregion
        
        public string securedListIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

