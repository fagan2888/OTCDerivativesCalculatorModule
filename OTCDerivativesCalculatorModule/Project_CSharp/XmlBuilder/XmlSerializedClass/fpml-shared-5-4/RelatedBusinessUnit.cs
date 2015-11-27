using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RelatedBusinessUnit : ISerialized
    {
        public RelatedBusinessUnit(XmlNode xmlNode)
        {
            XmlNode businessUnitReferenceNode = xmlNode.SelectSingleNode("businessUnitReference");
            
            if (businessUnitReferenceNode != null)
            {
                if (businessUnitReferenceNode.Attributes["href"] != null || businessUnitReferenceNode.Attributes["id"] != null) 
                {
                    if (businessUnitReferenceNode.Attributes["id"] != null) 
                    {
                        businessUnitReferenceIDRef_ = businessUnitReferenceNode.Attributes["id"].Value;
                        BusinessUnitReference ob = new BusinessUnitReference(businessUnitReferenceNode);
                        IDManager.SetID(businessUnitReferenceIDRef_, ob);
                    }
                    else if (businessUnitReferenceNode.Attributes["href"] != null)
                    {
                        businessUnitReferenceIDRef_ = businessUnitReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessUnitReference_ = new BusinessUnitReference(businessUnitReferenceNode);
                    }
                }
                else
                {
                    businessUnitReference_ = new BusinessUnitReference(businessUnitReferenceNode);
                }
            }
            
        
            XmlNode roleNode = xmlNode.SelectSingleNode("role");
            
            if (roleNode != null)
            {
                if (roleNode.Attributes["href"] != null || roleNode.Attributes["id"] != null) 
                {
                    if (roleNode.Attributes["id"] != null) 
                    {
                        roleIDRef_ = roleNode.Attributes["id"].Value;
                        BusinessUnitRole ob = new BusinessUnitRole(roleNode);
                        IDManager.SetID(roleIDRef_, ob);
                    }
                    else if (roleNode.Attributes["href"] != null)
                    {
                        roleIDRef_ = roleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        role_ = new BusinessUnitRole(roleNode);
                    }
                }
                else
                {
                    role_ = new BusinessUnitRole(roleNode);
                }
            }
            
        
        }
        
    
        #region BusinessUnitReference_
        private BusinessUnitReference businessUnitReference_;
        public BusinessUnitReference BusinessUnitReference_
        {
            get
            {
                if (this.businessUnitReference_ != null)
                {
                    return this.businessUnitReference_; 
                }
                else if (this.businessUnitReferenceIDRef_ != null)
                {
                    businessUnitReference_ = IDManager.getID(businessUnitReferenceIDRef_) as BusinessUnitReference;
                    return this.businessUnitReference_; 
                }
                else
                {
                      return this.businessUnitReference_; 
                }
            }
            set
            {
                if (this.businessUnitReference_ != value)
                {
                    this.businessUnitReference_ = value;
                }
            }
        }
        #endregion
        
        public string businessUnitReferenceIDRef_ { get; set; }
        #region Role_
        private BusinessUnitRole role_;
        public BusinessUnitRole Role_
        {
            get
            {
                if (this.role_ != null)
                {
                    return this.role_; 
                }
                else if (this.roleIDRef_ != null)
                {
                    role_ = IDManager.getID(roleIDRef_) as BusinessUnitRole;
                    return this.role_; 
                }
                else
                {
                      return this.role_; 
                }
            }
            set
            {
                if (this.role_ != value)
                {
                    this.role_ = value;
                }
            }
        }
        #endregion
        
        public string roleIDRef_ { get; set; }
        
    
        
    
    }
    
}

