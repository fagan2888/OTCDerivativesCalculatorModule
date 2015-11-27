using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BusinessUnit
    {
        public BusinessUnit(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList businessUnitIdNodeList = xmlNode.SelectNodes("businessUnitId");
            if (businessUnitIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessUnitIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessUnitIdIDRef = item.Attributes["id"].Name;
                        Unit ob = Unit();
                        IDManager.SetID(businessUnitIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessUnitIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessUnitId = new Unit(item);
                    }
                }
            }
            
        
            XmlNodeList contactInfoNodeList = xmlNode.SelectNodes("contactInfo");
            if (contactInfoNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in contactInfoNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contactInfoIDRef = item.Attributes["id"].Name;
                        ContactInformation ob = ContactInformation();
                        IDManager.SetID(contactInfoIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contactInfoIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        contactInfo = new ContactInformation(item);
                    }
                }
            }
            
        
            XmlNodeList countryNodeList = xmlNode.SelectNodes("country");
            if (countryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in countryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        countryIDRef = item.Attributes["id"].Name;
                        CountryCode ob = CountryCode();
                        IDManager.SetID(countryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        countryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        country = new CountryCode(item);
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeString name;
        public XsdTypeString Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeString;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region BusinessUnitId
        private Unit businessUnitId;
        public Unit BusinessUnitId
        {
            get
            {
                if (this.businessUnitId != null)
                {
                    return this.businessUnitId; 
                }
                else if (this.businessUnitIdIDRef != null)
                {
                    businessUnitId = IDManager.getID(businessUnitIdIDRef) as Unit;
                    return this.businessUnitId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessUnitId != value)
                {
                    this.businessUnitId = value;
                }
            }
        }
        #endregion
        
        public string UnitIDRef { get; set; }
        #region ContactInfo
        private ContactInformation contactInfo;
        public ContactInformation ContactInfo
        {
            get
            {
                if (this.contactInfo != null)
                {
                    return this.contactInfo; 
                }
                else if (this.contactInfoIDRef != null)
                {
                    contactInfo = IDManager.getID(contactInfoIDRef) as ContactInformation;
                    return this.contactInfo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contactInfo != value)
                {
                    this.contactInfo = value;
                }
            }
        }
        #endregion
        
        public string ContactInformationIDRef { get; set; }
        #region Country
        private CountryCode country;
        public CountryCode Country
        {
            get
            {
                if (this.country != null)
                {
                    return this.country; 
                }
                else if (this.countryIDRef != null)
                {
                    country = IDManager.getID(countryIDRef) as CountryCode;
                    return this.country; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.country != value)
                {
                    this.country = value;
                }
            }
        }
        #endregion
        
        public string CountryCodeIDRef { get; set; }
        
    
        
    
    }
    
}

