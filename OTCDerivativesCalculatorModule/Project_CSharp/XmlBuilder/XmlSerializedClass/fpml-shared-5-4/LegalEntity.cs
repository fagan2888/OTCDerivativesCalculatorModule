using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class LegalEntity : ISerialized
    {
        public LegalEntity(XmlNode xmlNode)
        {
            XmlNode entityNameNode = xmlNode.SelectSingleNode("entityName");
            
            if (entityNameNode != null)
            {
                if (entityNameNode.Attributes["href"] != null || entityNameNode.Attributes["id"] != null) 
                {
                    if (entityNameNode.Attributes["id"] != null) 
                    {
                        entityNameIDRef_ = entityNameNode.Attributes["id"].Value;
                        EntityName ob = new EntityName(entityNameNode);
                        IDManager.SetID(entityNameIDRef_, ob);
                    }
                    else if (entityNameNode.Attributes["href"] != null)
                    {
                        entityNameIDRef_ = entityNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entityName_ = new EntityName(entityNameNode);
                    }
                }
                else
                {
                    entityName_ = new EntityName(entityNameNode);
                }
            }
            
        
            XmlNodeList entityIdNodeList = xmlNode.SelectNodes("entityId");
            
            if (entityIdNodeList != null)
            {
                this.entityId_ = new List<EntityId>();
                foreach (XmlNode item in entityIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            entityIdIDRef_ = item.Attributes["id"].Value;
                            entityId_.Add(new EntityId(item));
                            IDManager.SetID(entityIdIDRef_, entityId_[entityId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            entityIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        entityId_.Add(new EntityId(item));
                        }
                    }
                    else
                    {
                        entityId_.Add(new EntityId(item));
                    }
                }
            }
            
        
        }
        
    
        #region EntityName_
        private EntityName entityName_;
        public EntityName EntityName_
        {
            get
            {
                if (this.entityName_ != null)
                {
                    return this.entityName_; 
                }
                else if (this.entityNameIDRef_ != null)
                {
                    entityName_ = IDManager.getID(entityNameIDRef_) as EntityName;
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
        private List<EntityId> entityId_;
        public List<EntityId> EntityId_
        {
            get
            {
                if (this.entityId_ != null)
                {
                    return this.entityId_; 
                }
                else if (this.entityIdIDRef_ != null)
                {
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

