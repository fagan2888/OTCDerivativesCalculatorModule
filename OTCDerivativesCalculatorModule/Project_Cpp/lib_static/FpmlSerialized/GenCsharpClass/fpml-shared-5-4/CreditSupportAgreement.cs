using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditSupportAgreement
    {
        public CreditSupportAgreement(XmlNode xmlNode)
        {
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
                        CreditSupportAgreementType ob = CreditSupportAgreementType();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new CreditSupportAgreementType(item);
                    }
                }
            }
            
        
            XmlNodeList dateNodeList = xmlNode.SelectNodes("date");
            if (dateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(dateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        date = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList identifierNodeList = xmlNode.SelectNodes("identifier");
            if (identifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in identifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        identifierIDRef = item.Attributes["id"].Name;
                        CreditSupportAgreementIdentifier ob = CreditSupportAgreementIdentifier();
                        IDManager.SetID(identifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        identifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        identifier = new CreditSupportAgreementIdentifier(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private CreditSupportAgreementType type;
        public CreditSupportAgreementType Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as CreditSupportAgreementType;
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
        
        public string CreditSupportAgreementTypeIDRef { get; set; }
        #region Date
        private XsdTypeDate date;
        public XsdTypeDate Date
        {
            get
            {
                if (this.date != null)
                {
                    return this.date; 
                }
                else if (this.dateIDRef != null)
                {
                    date = IDManager.getID(dateIDRef) as XsdTypeDate;
                    return this.date; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.date != value)
                {
                    this.date = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Identifier
        private CreditSupportAgreementIdentifier identifier;
        public CreditSupportAgreementIdentifier Identifier
        {
            get
            {
                if (this.identifier != null)
                {
                    return this.identifier; 
                }
                else if (this.identifierIDRef != null)
                {
                    identifier = IDManager.getID(identifierIDRef) as CreditSupportAgreementIdentifier;
                    return this.identifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.identifier != value)
                {
                    this.identifier = value;
                }
            }
        }
        #endregion
        
        public string CreditSupportAgreementIdentifierIDRef { get; set; }
        
    
        
    
    }
    
}

