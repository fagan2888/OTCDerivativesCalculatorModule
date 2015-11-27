using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReferencePair
    {
        public ReferencePair(XmlNode xmlNode)
        {
            XmlNodeList referenceEntityNodeList = xmlNode.SelectNodes("referenceEntity");
            if (referenceEntityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceEntityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceEntityIDRef = item.Attributes["id"].Name;
                        LegalEntity ob = LegalEntity();
                        IDManager.SetID(referenceEntityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceEntityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceEntity = new LegalEntity(item);
                    }
                }
            }
            
        
            XmlNodeList referenceObligationNodeList = xmlNode.SelectNodes("referenceObligation");
            if (referenceObligationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceObligationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceObligationIDRef = item.Attributes["id"].Name;
                        ReferenceObligation ob = ReferenceObligation();
                        IDManager.SetID(referenceObligationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceObligationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceObligation = new ReferenceObligation(item);
                    }
                }
            }
            
        
            XmlNodeList noReferenceObligationNodeList = xmlNode.SelectNodes("noReferenceObligation");
            if (noReferenceObligationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in noReferenceObligationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        noReferenceObligationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(noReferenceObligationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        noReferenceObligationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        noReferenceObligation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList entityTypeNodeList = xmlNode.SelectNodes("entityType");
            if (entityTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in entityTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        entityTypeIDRef = item.Attributes["id"].Name;
                        EntityType ob = EntityType();
                        IDManager.SetID(entityTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        entityTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        entityType = new EntityType(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceEntity
        private LegalEntity referenceEntity;
        public LegalEntity ReferenceEntity
        {
            get
            {
                if (this.referenceEntity != null)
                {
                    return this.referenceEntity; 
                }
                else if (this.referenceEntityIDRef != null)
                {
                    referenceEntity = IDManager.getID(referenceEntityIDRef) as LegalEntity;
                    return this.referenceEntity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceEntity != value)
                {
                    this.referenceEntity = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region ReferenceObligation
        private ReferenceObligation referenceObligation;
        public ReferenceObligation ReferenceObligation
        {
            get
            {
                if (this.referenceObligation != null)
                {
                    return this.referenceObligation; 
                }
                else if (this.referenceObligationIDRef != null)
                {
                    referenceObligation = IDManager.getID(referenceObligationIDRef) as ReferenceObligation;
                    return this.referenceObligation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceObligation != value)
                {
                    this.referenceObligation = value;
                }
            }
        }
        #endregion
        
        public string ReferenceObligationIDRef { get; set; }
        #region NoReferenceObligation
        private XsdTypeBoolean noReferenceObligation;
        public XsdTypeBoolean NoReferenceObligation
        {
            get
            {
                if (this.noReferenceObligation != null)
                {
                    return this.noReferenceObligation; 
                }
                else if (this.noReferenceObligationIDRef != null)
                {
                    noReferenceObligation = IDManager.getID(noReferenceObligationIDRef) as XsdTypeBoolean;
                    return this.noReferenceObligation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.noReferenceObligation != value)
                {
                    this.noReferenceObligation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region EntityType
        private EntityType entityType;
        public EntityType EntityType
        {
            get
            {
                if (this.entityType != null)
                {
                    return this.entityType; 
                }
                else if (this.entityTypeIDRef != null)
                {
                    entityType = IDManager.getID(entityTypeIDRef) as EntityType;
                    return this.entityType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.entityType != value)
                {
                    this.entityType = value;
                }
            }
        }
        #endregion
        
        public string EntityTypeIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

