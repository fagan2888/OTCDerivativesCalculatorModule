using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PartyRelationship
    {
        public PartyRelationship(XmlNode xmlNode)
        {
            XmlNodeList partyReferenceNodeList = xmlNode.SelectNodes("partyReference");
            if (partyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(partyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList accountReferenceNodeList = xmlNode.SelectNodes("accountReference");
            if (accountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(accountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accountReference = new AccountReference(item);
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
                        PartyRole ob = PartyRole();
                        IDManager.SetID(roleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        roleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        role = new PartyRole(item);
                    }
                }
            }
            
        
            XmlNodeList typeNodeList = xmlNode.SelectNodes("type");
            if (typeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in typeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        typeIDRef = item.Attributes["id"].Name;
                        PartyRoleType ob = PartyRoleType();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new PartyRoleType(item);
                    }
                }
            }
            
        
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList terminationDateNodeList = xmlNode.SelectNodes("terminationDate");
            if (terminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in terminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        terminationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(terminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        terminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        terminationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList documentationNodeList = xmlNode.SelectNodes("documentation");
            if (documentationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in documentationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        documentationIDRef = item.Attributes["id"].Name;
                        PartyRelationshipDocumentation ob = PartyRelationshipDocumentation();
                        IDManager.SetID(documentationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        documentationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        documentation = new PartyRelationshipDocumentation(item);
                    }
                }
            }
            
        
        }
        
    
        #region PartyReference
        private PartyReference partyReference;
        public PartyReference PartyReference
        {
            get
            {
                if (this.partyReference != null)
                {
                    return this.partyReference; 
                }
                else if (this.partyReferenceIDRef != null)
                {
                    partyReference = IDManager.getID(partyReferenceIDRef) as PartyReference;
                    return this.partyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyReference != value)
                {
                    this.partyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region AccountReference
        private AccountReference accountReference;
        public AccountReference AccountReference
        {
            get
            {
                if (this.accountReference != null)
                {
                    return this.accountReference; 
                }
                else if (this.accountReferenceIDRef != null)
                {
                    accountReference = IDManager.getID(accountReferenceIDRef) as AccountReference;
                    return this.accountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountReference != value)
                {
                    this.accountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region Role
        private PartyRole role;
        public PartyRole Role
        {
            get
            {
                if (this.role != null)
                {
                    return this.role; 
                }
                else if (this.roleIDRef != null)
                {
                    role = IDManager.getID(roleIDRef) as PartyRole;
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
        
        public string PartyRoleIDRef { get; set; }
        #region Type
        private PartyRoleType type;
        public PartyRoleType Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as PartyRoleType;
                    return this.type; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                }
            }
        }
        #endregion
        
        public string PartyRoleTypeIDRef { get; set; }
        #region EffectiveDate
        private XsdTypeDate effectiveDate;
        public XsdTypeDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as XsdTypeDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region TerminationDate
        private XsdTypeDate terminationDate;
        public XsdTypeDate TerminationDate
        {
            get
            {
                if (this.terminationDate != null)
                {
                    return this.terminationDate; 
                }
                else if (this.terminationDateIDRef != null)
                {
                    terminationDate = IDManager.getID(terminationDateIDRef) as XsdTypeDate;
                    return this.terminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.terminationDate != value)
                {
                    this.terminationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Documentation
        private PartyRelationshipDocumentation documentation;
        public PartyRelationshipDocumentation Documentation
        {
            get
            {
                if (this.documentation != null)
                {
                    return this.documentation; 
                }
                else if (this.documentationIDRef != null)
                {
                    documentation = IDManager.getID(documentationIDRef) as PartyRelationshipDocumentation;
                    return this.documentation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.documentation != value)
                {
                    this.documentation = value;
                }
            }
        }
        #endregion
        
        public string PartyRelationshipDocumentationIDRef { get; set; }
        
    
        
    
    }
    
}

