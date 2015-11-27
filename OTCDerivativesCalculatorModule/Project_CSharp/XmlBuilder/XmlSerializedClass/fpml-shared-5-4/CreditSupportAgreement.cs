using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditSupportAgreement : ISerialized
    {
        public CreditSupportAgreement(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        CreditSupportAgreementType ob = new CreditSupportAgreementType(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new CreditSupportAgreementType(typeNode);
                    }
                }
                else
                {
                    type_ = new CreditSupportAgreementType(typeNode);
                }
            }
            
        
            XmlNode dateNode = xmlNode.SelectSingleNode("date");
            
            if (dateNode != null)
            {
                if (dateNode.Attributes["href"] != null || dateNode.Attributes["id"] != null) 
                {
                    if (dateNode.Attributes["id"] != null) 
                    {
                        dateIDRef_ = dateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(dateNode);
                        IDManager.SetID(dateIDRef_, ob);
                    }
                    else if (dateNode.Attributes["href"] != null)
                    {
                        dateIDRef_ = dateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        date_ = new XsdTypeDate(dateNode);
                    }
                }
                else
                {
                    date_ = new XsdTypeDate(dateNode);
                }
            }
            
        
            XmlNode identifierNode = xmlNode.SelectSingleNode("identifier");
            
            if (identifierNode != null)
            {
                if (identifierNode.Attributes["href"] != null || identifierNode.Attributes["id"] != null) 
                {
                    if (identifierNode.Attributes["id"] != null) 
                    {
                        identifierIDRef_ = identifierNode.Attributes["id"].Value;
                        CreditSupportAgreementIdentifier ob = new CreditSupportAgreementIdentifier(identifierNode);
                        IDManager.SetID(identifierIDRef_, ob);
                    }
                    else if (identifierNode.Attributes["href"] != null)
                    {
                        identifierIDRef_ = identifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        identifier_ = new CreditSupportAgreementIdentifier(identifierNode);
                    }
                }
                else
                {
                    identifier_ = new CreditSupportAgreementIdentifier(identifierNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private CreditSupportAgreementType type_;
        public CreditSupportAgreementType Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as CreditSupportAgreementType;
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
        #region Date_
        private XsdTypeDate date_;
        public XsdTypeDate Date_
        {
            get
            {
                if (this.date_ != null)
                {
                    return this.date_; 
                }
                else if (this.dateIDRef_ != null)
                {
                    date_ = IDManager.getID(dateIDRef_) as XsdTypeDate;
                    return this.date_; 
                }
                else
                {
                      return this.date_; 
                }
            }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                }
            }
        }
        #endregion
        
        public string dateIDRef_ { get; set; }
        #region Identifier_
        private CreditSupportAgreementIdentifier identifier_;
        public CreditSupportAgreementIdentifier Identifier_
        {
            get
            {
                if (this.identifier_ != null)
                {
                    return this.identifier_; 
                }
                else if (this.identifierIDRef_ != null)
                {
                    identifier_ = IDManager.getID(identifierIDRef_) as CreditSupportAgreementIdentifier;
                    return this.identifier_; 
                }
                else
                {
                      return this.identifier_; 
                }
            }
            set
            {
                if (this.identifier_ != value)
                {
                    this.identifier_ = value;
                }
            }
        }
        #endregion
        
        public string identifierIDRef_ { get; set; }
        
    
        
    
    }
    
}

