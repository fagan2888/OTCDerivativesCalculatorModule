using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PartyRelationship : ISerialized
    {
        public PartyRelationship(XmlNode xmlNode)
        {
            XmlNode partyReferenceNode = xmlNode.SelectSingleNode("partyReference");
            
            if (partyReferenceNode != null)
            {
                if (partyReferenceNode.Attributes["href"] != null || partyReferenceNode.Attributes["id"] != null) 
                {
                    if (partyReferenceNode.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(partyReferenceNode);
                        IDManager.SetID(partyReferenceIDRef_, ob);
                    }
                    else if (partyReferenceNode.Attributes["href"] != null)
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyReference_ = new PartyReference(partyReferenceNode);
                    }
                }
                else
                {
                    partyReference_ = new PartyReference(partyReferenceNode);
                }
            }
            
        
            XmlNode accountReferenceNode = xmlNode.SelectSingleNode("accountReference");
            
            if (accountReferenceNode != null)
            {
                if (accountReferenceNode.Attributes["href"] != null || accountReferenceNode.Attributes["id"] != null) 
                {
                    if (accountReferenceNode.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(accountReferenceNode);
                        IDManager.SetID(accountReferenceIDRef_, ob);
                    }
                    else if (accountReferenceNode.Attributes["href"] != null)
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accountReference_ = new AccountReference(accountReferenceNode);
                    }
                }
                else
                {
                    accountReference_ = new AccountReference(accountReferenceNode);
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
                        PartyRole ob = new PartyRole(roleNode);
                        IDManager.SetID(roleIDRef_, ob);
                    }
                    else if (roleNode.Attributes["href"] != null)
                    {
                        roleIDRef_ = roleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        role_ = new PartyRole(roleNode);
                    }
                }
                else
                {
                    role_ = new PartyRole(roleNode);
                }
            }
            
        
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        PartyRoleType ob = new PartyRoleType(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new PartyRoleType(typeNode);
                    }
                }
                else
                {
                    type_ = new PartyRoleType(typeNode);
                }
            }
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode terminationDateNode = xmlNode.SelectSingleNode("terminationDate");
            
            if (terminationDateNode != null)
            {
                if (terminationDateNode.Attributes["href"] != null || terminationDateNode.Attributes["id"] != null) 
                {
                    if (terminationDateNode.Attributes["id"] != null) 
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(terminationDateNode);
                        IDManager.SetID(terminationDateIDRef_, ob);
                    }
                    else if (terminationDateNode.Attributes["href"] != null)
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminationDate_ = new XsdTypeDate(terminationDateNode);
                    }
                }
                else
                {
                    terminationDate_ = new XsdTypeDate(terminationDateNode);
                }
            }
            
        
            XmlNode documentationNode = xmlNode.SelectSingleNode("documentation");
            
            if (documentationNode != null)
            {
                if (documentationNode.Attributes["href"] != null || documentationNode.Attributes["id"] != null) 
                {
                    if (documentationNode.Attributes["id"] != null) 
                    {
                        documentationIDRef_ = documentationNode.Attributes["id"].Value;
                        PartyRelationshipDocumentation ob = new PartyRelationshipDocumentation(documentationNode);
                        IDManager.SetID(documentationIDRef_, ob);
                    }
                    else if (documentationNode.Attributes["href"] != null)
                    {
                        documentationIDRef_ = documentationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        documentation_ = new PartyRelationshipDocumentation(documentationNode);
                    }
                }
                else
                {
                    documentation_ = new PartyRelationshipDocumentation(documentationNode);
                }
            }
            
        
        }
        
    
        #region PartyReference_
        private PartyReference partyReference_;
        public PartyReference PartyReference_
        {
            get
            {
                if (this.partyReference_ != null)
                {
                    return this.partyReference_; 
                }
                else if (this.partyReferenceIDRef_ != null)
                {
                    partyReference_ = IDManager.getID(partyReferenceIDRef_) as PartyReference;
                    return this.partyReference_; 
                }
                else
                {
                      return this.partyReference_; 
                }
            }
            set
            {
                if (this.partyReference_ != value)
                {
                    this.partyReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyReferenceIDRef_ { get; set; }
        #region AccountReference_
        private AccountReference accountReference_;
        public AccountReference AccountReference_
        {
            get
            {
                if (this.accountReference_ != null)
                {
                    return this.accountReference_; 
                }
                else if (this.accountReferenceIDRef_ != null)
                {
                    accountReference_ = IDManager.getID(accountReferenceIDRef_) as AccountReference;
                    return this.accountReference_; 
                }
                else
                {
                      return this.accountReference_; 
                }
            }
            set
            {
                if (this.accountReference_ != value)
                {
                    this.accountReference_ = value;
                }
            }
        }
        #endregion
        
        public string accountReferenceIDRef_ { get; set; }
        #region Role_
        private PartyRole role_;
        public PartyRole Role_
        {
            get
            {
                if (this.role_ != null)
                {
                    return this.role_; 
                }
                else if (this.roleIDRef_ != null)
                {
                    role_ = IDManager.getID(roleIDRef_) as PartyRole;
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
        #region Type_
        private PartyRoleType type_;
        public PartyRoleType Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as PartyRoleType;
                    return this.type_; 
                }
                else
                {
                      return this.type_; 
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region EffectiveDate_
        private XsdTypeDate effectiveDate_;
        public XsdTypeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as XsdTypeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region TerminationDate_
        private XsdTypeDate terminationDate_;
        public XsdTypeDate TerminationDate_
        {
            get
            {
                if (this.terminationDate_ != null)
                {
                    return this.terminationDate_; 
                }
                else if (this.terminationDateIDRef_ != null)
                {
                    terminationDate_ = IDManager.getID(terminationDateIDRef_) as XsdTypeDate;
                    return this.terminationDate_; 
                }
                else
                {
                      return this.terminationDate_; 
                }
            }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string terminationDateIDRef_ { get; set; }
        #region Documentation_
        private PartyRelationshipDocumentation documentation_;
        public PartyRelationshipDocumentation Documentation_
        {
            get
            {
                if (this.documentation_ != null)
                {
                    return this.documentation_; 
                }
                else if (this.documentationIDRef_ != null)
                {
                    documentation_ = IDManager.getID(documentationIDRef_) as PartyRelationshipDocumentation;
                    return this.documentation_; 
                }
                else
                {
                      return this.documentation_; 
                }
            }
            set
            {
                if (this.documentation_ != value)
                {
                    this.documentation_ = value;
                }
            }
        }
        #endregion
        
        public string documentationIDRef_ { get; set; }
        
    
        
    
    }
    
}

