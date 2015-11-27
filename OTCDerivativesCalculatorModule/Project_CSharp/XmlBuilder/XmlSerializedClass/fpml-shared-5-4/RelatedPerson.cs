using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RelatedPerson : ISerialized
    {
        public RelatedPerson(XmlNode xmlNode)
        {
            XmlNode personReferenceNode = xmlNode.SelectSingleNode("personReference");
            
            if (personReferenceNode != null)
            {
                if (personReferenceNode.Attributes["href"] != null || personReferenceNode.Attributes["id"] != null) 
                {
                    if (personReferenceNode.Attributes["id"] != null) 
                    {
                        personReferenceIDRef_ = personReferenceNode.Attributes["id"].Value;
                        PersonReference ob = new PersonReference(personReferenceNode);
                        IDManager.SetID(personReferenceIDRef_, ob);
                    }
                    else if (personReferenceNode.Attributes["href"] != null)
                    {
                        personReferenceIDRef_ = personReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        personReference_ = new PersonReference(personReferenceNode);
                    }
                }
                else
                {
                    personReference_ = new PersonReference(personReferenceNode);
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
                        PersonRole ob = new PersonRole(roleNode);
                        IDManager.SetID(roleIDRef_, ob);
                    }
                    else if (roleNode.Attributes["href"] != null)
                    {
                        roleIDRef_ = roleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        role_ = new PersonRole(roleNode);
                    }
                }
                else
                {
                    role_ = new PersonRole(roleNode);
                }
            }
            
        
        }
        
    
        #region PersonReference_
        private PersonReference personReference_;
        public PersonReference PersonReference_
        {
            get
            {
                if (this.personReference_ != null)
                {
                    return this.personReference_; 
                }
                else if (this.personReferenceIDRef_ != null)
                {
                    personReference_ = IDManager.getID(personReferenceIDRef_) as PersonReference;
                    return this.personReference_; 
                }
                else
                {
                      return this.personReference_; 
                }
            }
            set
            {
                if (this.personReference_ != value)
                {
                    this.personReference_ = value;
                }
            }
        }
        #endregion
        
        public string personReferenceIDRef_ { get; set; }
        #region Role_
        private PersonRole role_;
        public PersonRole Role_
        {
            get
            {
                if (this.role_ != null)
                {
                    return this.role_; 
                }
                else if (this.roleIDRef_ != null)
                {
                    role_ = IDManager.getID(roleIDRef_) as PersonRole;
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

