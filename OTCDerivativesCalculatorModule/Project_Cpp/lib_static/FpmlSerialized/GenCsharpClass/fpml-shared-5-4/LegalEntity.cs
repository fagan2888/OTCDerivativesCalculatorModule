using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class LegalEntity
    {
        public LegalEntity(XmlNode xmlNode)
        {
            XmlNodeList entityNameNodeList = xmlNode.SelectNodes("entityName");
            if (entityNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in entityNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        entityNameIDRef = item.Attributes["id"].Name;
                        EntityName ob = EntityName();
                        IDManager.SetID(entityNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        entityNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        entityName = new EntityName(item);
                    }
                }
            }
            
        
            XmlNodeList entityIdNodeList = xmlNode.SelectNodes("entityId");
            
            foreach (XmlNode item in entityIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        entityIdIDRef = item.Attributes["id"].Name;
                        List<EntityId> ob = new List<EntityId>();
                        ob.Add(new EntityId(item));
                        IDManager.SetID(entityIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        entityIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    entityId.Add(new EntityId(item));
                    }
                }
            }
            
        
        }
        
    
        #region EntityName
        private EntityName entityName;
        public EntityName EntityName
        {
            get
            {
                if (this.entityName != null)
                {
                    return this.entityName; 
                }
                else if (this.entityNameIDRef != null)
                {
                    entityName = IDManager.getID(entityNameIDRef) as EntityName;
                    return this.entityName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.entityName != value)
                {
                    this.entityName = value;
                }
            }
        }
        #endregion
        
        public string EntityNameIDRef { get; set; }
        #region EntityId
        private List<EntityId> entityId;
        public List<EntityId> EntityId
        {
            get
            {
                if (this.entityId != null)
                {
                    return this.entityId; 
                }
                else if (this.entityIdIDRef != null)
                {
                    entityId = IDManager.getID(entityIdIDRef) as List<EntityId>;
                    return this.entityId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.entityId != value)
                {
                    this.entityId = value;
                }
            }
        }
        #endregion
        
        public string EntityIdIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

