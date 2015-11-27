using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BusinessUnit : ISerialized
    {
        public BusinessUnit(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeString(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeString(nameNode);
                }
            }
            
        
            XmlNode businessUnitIdNode = xmlNode.SelectSingleNode("businessUnitId");
            
            if (businessUnitIdNode != null)
            {
                if (businessUnitIdNode.Attributes["href"] != null || businessUnitIdNode.Attributes["id"] != null) 
                {
                    if (businessUnitIdNode.Attributes["id"] != null) 
                    {
                        businessUnitIdIDRef_ = businessUnitIdNode.Attributes["id"].Value;
                        Unit ob = new Unit(businessUnitIdNode);
                        IDManager.SetID(businessUnitIdIDRef_, ob);
                    }
                    else if (businessUnitIdNode.Attributes["href"] != null)
                    {
                        businessUnitIdIDRef_ = businessUnitIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessUnitId_ = new Unit(businessUnitIdNode);
                    }
                }
                else
                {
                    businessUnitId_ = new Unit(businessUnitIdNode);
                }
            }
            
        
            XmlNode contactInfoNode = xmlNode.SelectSingleNode("contactInfo");
            
            if (contactInfoNode != null)
            {
                if (contactInfoNode.Attributes["href"] != null || contactInfoNode.Attributes["id"] != null) 
                {
                    if (contactInfoNode.Attributes["id"] != null) 
                    {
                        contactInfoIDRef_ = contactInfoNode.Attributes["id"].Value;
                        ContactInformation ob = new ContactInformation(contactInfoNode);
                        IDManager.SetID(contactInfoIDRef_, ob);
                    }
                    else if (contactInfoNode.Attributes["href"] != null)
                    {
                        contactInfoIDRef_ = contactInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        contactInfo_ = new ContactInformation(contactInfoNode);
                    }
                }
                else
                {
                    contactInfo_ = new ContactInformation(contactInfoNode);
                }
            }
            
        
            XmlNode countryNode = xmlNode.SelectSingleNode("country");
            
            if (countryNode != null)
            {
                if (countryNode.Attributes["href"] != null || countryNode.Attributes["id"] != null) 
                {
                    if (countryNode.Attributes["id"] != null) 
                    {
                        countryIDRef_ = countryNode.Attributes["id"].Value;
                        CountryCode ob = new CountryCode(countryNode);
                        IDManager.SetID(countryIDRef_, ob);
                    }
                    else if (countryNode.Attributes["href"] != null)
                    {
                        countryIDRef_ = countryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        country_ = new CountryCode(countryNode);
                    }
                }
                else
                {
                    country_ = new CountryCode(countryNode);
                }
            }
            
        
        }
        
    
        #region Name_
        private XsdTypeString name_;
        public XsdTypeString Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeString;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region BusinessUnitId_
        private Unit businessUnitId_;
        public Unit BusinessUnitId_
        {
            get
            {
                if (this.businessUnitId_ != null)
                {
                    return this.businessUnitId_; 
                }
                else if (this.businessUnitIdIDRef_ != null)
                {
                    businessUnitId_ = IDManager.getID(businessUnitIdIDRef_) as Unit;
                    return this.businessUnitId_; 
                }
                else
                {
                      return this.businessUnitId_; 
                }
            }
            set
            {
                if (this.businessUnitId_ != value)
                {
                    this.businessUnitId_ = value;
                }
            }
        }
        #endregion
        
        public string businessUnitIdIDRef_ { get; set; }
        #region ContactInfo_
        private ContactInformation contactInfo_;
        public ContactInformation ContactInfo_
        {
            get
            {
                if (this.contactInfo_ != null)
                {
                    return this.contactInfo_; 
                }
                else if (this.contactInfoIDRef_ != null)
                {
                    contactInfo_ = IDManager.getID(contactInfoIDRef_) as ContactInformation;
                    return this.contactInfo_; 
                }
                else
                {
                      return this.contactInfo_; 
                }
            }
            set
            {
                if (this.contactInfo_ != value)
                {
                    this.contactInfo_ = value;
                }
            }
        }
        #endregion
        
        public string contactInfoIDRef_ { get; set; }
        #region Country_
        private CountryCode country_;
        public CountryCode Country_
        {
            get
            {
                if (this.country_ != null)
                {
                    return this.country_; 
                }
                else if (this.countryIDRef_ != null)
                {
                    country_ = IDManager.getID(countryIDRef_) as CountryCode;
                    return this.country_; 
                }
                else
                {
                      return this.country_; 
                }
            }
            set
            {
                if (this.country_ != value)
                {
                    this.country_ = value;
                }
            }
        }
        #endregion
        
        public string countryIDRef_ { get; set; }
        
    
        
    
    }
    
}

