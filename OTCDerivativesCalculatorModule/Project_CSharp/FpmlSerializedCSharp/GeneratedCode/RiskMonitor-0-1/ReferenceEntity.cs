using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class ReferenceEntity : ISerialized
    {
        public ReferenceEntity() { }
        public ReferenceEntity(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode entityNameNode = xmlNode.SelectSingleNode("entityName");
            
            if (entityNameNode != null)
            {
                if (entityNameNode.Attributes["href"] != null || entityNameNode.Attributes["id"] != null) 
                {
                    if (entityNameNode.Attributes["id"] != null) 
                    {
                        entityNameIDRef_ = entityNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(entityNameNode);
                        IDManager.SetID(entityNameIDRef_, ob);
                    }
                    else if (entityNameNode.Attributes["href"] != null)
                    {
                        entityNameIDRef_ = entityNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entityName_ = new XsdTypeToken(entityNameNode);
                    }
                }
                else
                {
                    entityName_ = new XsdTypeToken(entityNameNode);
                }
            }
            
        
            XmlNode entityIdNode = xmlNode.SelectSingleNode("entityId");
            
            if (entityIdNode != null)
            {
                if (entityIdNode.Attributes["href"] != null || entityIdNode.Attributes["id"] != null) 
                {
                    if (entityIdNode.Attributes["id"] != null) 
                    {
                        entityIdIDRef_ = entityIdNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(entityIdNode);
                        IDManager.SetID(entityIdIDRef_, ob);
                    }
                    else if (entityIdNode.Attributes["href"] != null)
                    {
                        entityIdIDRef_ = entityIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entityId_ = new XsdTypeToken(entityIdNode);
                    }
                }
                else
                {
                    entityId_ = new XsdTypeToken(entityIdNode);
                }
            }
            
        
        }
        
    
        #region EntityName_
        private XsdTypeToken entityName_;
        public XsdTypeToken EntityName_
        {
            get
            {
                if (this.entityName_ != null)
                {
                    return this.entityName_; 
                }
                else if (this.entityNameIDRef_ != null)
                {
                    entityName_ = IDManager.getID(entityNameIDRef_) as XsdTypeToken;
                    return this.entityName_; 
                }
                else
                {
                      return this.entityName_; 
                }
            }
            set
            {
                if (this.entityName_ != value)
                {
                    this.entityName_ = value;
                }
            }
        }
        #endregion
        
        public string entityNameIDRef_ { get; set; }
        #region EntityId_
        private XsdTypeToken entityId_;
        public XsdTypeToken EntityId_
        {
            get
            {
                if (this.entityId_ != null)
                {
                    return this.entityId_; 
                }
                else if (this.entityIdIDRef_ != null)
                {
                    entityId_ = IDManager.getID(entityIdIDRef_) as XsdTypeToken;
                    return this.entityId_; 
                }
                else
                {
                      return this.entityId_; 
                }
            }
            set
            {
                if (this.entityId_ != value)
                {
                    this.entityId_ = value;
                }
            }
        }
        #endregion
        
        public string entityIdIDRef_ { get; set; }
        
    
        
    
    }
    
}

