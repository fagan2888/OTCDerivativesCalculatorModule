using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferencePair : ISerialized
    {
        public ReferencePair(XmlNode xmlNode)
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
            
        
            XmlNode entityTypeNode = xmlNode.SelectSingleNode("entityType");
            
            if (entityTypeNode != null)
            {
                if (entityTypeNode.Attributes["href"] != null || entityTypeNode.Attributes["id"] != null) 
                {
                    if (entityTypeNode.Attributes["id"] != null) 
                    {
                        entityTypeIDRef_ = entityTypeNode.Attributes["id"].Value;
                        EntityType ob = new EntityType(entityTypeNode);
                        IDManager.SetID(entityTypeIDRef_, ob);
                    }
                    else if (entityTypeNode.Attributes["href"] != null)
                    {
                        entityTypeIDRef_ = entityTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entityType_ = new EntityType(entityTypeNode);
                    }
                }
                else
                {
                    entityType_ = new EntityType(entityTypeNode);
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
        #region EntityType_
        private EntityType entityType_;
        public EntityType EntityType_
        {
            get
            {
                if (this.entityType_ != null)
                {
                    return this.entityType_; 
                }
                else if (this.entityTypeIDRef_ != null)
                {
                    entityType_ = IDManager.getID(entityTypeIDRef_) as EntityType;
                    return this.entityType_; 
                }
                else
                {
                      return this.entityType_; 
                }
            }
            set
            {
                if (this.entityType_ != value)
                {
                    this.entityType_ = value;
                }
            }
        }
        #endregion
        
        public string entityTypeIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

