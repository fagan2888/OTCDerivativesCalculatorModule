using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RelatedBusinessUnit
    {
        public RelatedBusinessUnit(XmlNode xmlNode)
        {
            XmlNodeList businessUnitReferenceNodeList = xmlNode.SelectNodes("businessUnitReference");
            if (businessUnitReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessUnitReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessUnitReferenceIDRef = item.Attributes["id"].Name;
                        BusinessUnitReference ob = BusinessUnitReference();
                        IDManager.SetID(businessUnitReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessUnitReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessUnitReference = new BusinessUnitReference(item);
                    }
                }
            }
            
        
            XmlNodeList roleNodeList = xmlNode.SelectNodes("role");
            if (roleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in roleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        roleIDRef = item.Attributes["id"].Name;
                        BusinessUnitRole ob = BusinessUnitRole();
                        IDManager.SetID(roleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        roleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        role = new BusinessUnitRole(item);
                    }
                }
            }
            
        
        }
        
    
        #region BusinessUnitReference
        private BusinessUnitReference businessUnitReference;
        public BusinessUnitReference BusinessUnitReference
        {
            get
            {
                if (this.businessUnitReference != null)
                {
                    return this.businessUnitReference; 
                }
                else if (this.businessUnitReferenceIDRef != null)
                {
                    businessUnitReference = IDManager.getID(businessUnitReferenceIDRef) as BusinessUnitReference;
                    return this.businessUnitReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessUnitReference != value)
                {
                    this.businessUnitReference = value;
                }
            }
        }
        #endregion
        
        public string BusinessUnitReferenceIDRef { get; set; }
        #region Role
        private BusinessUnitRole role;
        public BusinessUnitRole Role
        {
            get
            {
                if (this.role != null)
                {
                    return this.role; 
                }
                else if (this.roleIDRef != null)
                {
                    role = IDManager.getID(roleIDRef) as BusinessUnitRole;
                    return this.role; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.role != value)
                {
                    this.role = value;
                }
            }
        }
        #endregion
        
        public string BusinessUnitRoleIDRef { get; set; }
        
    
        
    
    }
    
}

