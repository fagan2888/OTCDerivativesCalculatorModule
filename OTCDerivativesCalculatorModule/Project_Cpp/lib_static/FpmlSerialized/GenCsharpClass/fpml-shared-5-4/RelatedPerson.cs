using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RelatedPerson
    {
        public RelatedPerson(XmlNode xmlNode)
        {
            XmlNodeList personReferenceNodeList = xmlNode.SelectNodes("personReference");
            if (personReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in personReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        personReferenceIDRef = item.Attributes["id"].Name;
                        PersonReference ob = PersonReference();
                        IDManager.SetID(personReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        personReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        personReference = new PersonReference(item);
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
                        PersonRole ob = PersonRole();
                        IDManager.SetID(roleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        roleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        role = new PersonRole(item);
                    }
                }
            }
            
        
        }
        
    
        #region PersonReference
        private PersonReference personReference;
        public PersonReference PersonReference
        {
            get
            {
                if (this.personReference != null)
                {
                    return this.personReference; 
                }
                else if (this.personReferenceIDRef != null)
                {
                    personReference = IDManager.getID(personReferenceIDRef) as PersonReference;
                    return this.personReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.personReference != value)
                {
                    this.personReference = value;
                }
            }
        }
        #endregion
        
        public string PersonReferenceIDRef { get; set; }
        #region Role
        private PersonRole role;
        public PersonRole Role
        {
            get
            {
                if (this.role != null)
                {
                    return this.role; 
                }
                else if (this.roleIDRef != null)
                {
                    role = IDManager.getID(roleIDRef) as PersonRole;
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
        
        public string PersonRoleIDRef { get; set; }
        
    
        
    
    }
    
}

