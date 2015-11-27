using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Address
    {
        public Address(XmlNode xmlNode)
        {
            XmlNodeList streetAddressNodeList = xmlNode.SelectNodes("streetAddress");
            if (streetAddressNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in streetAddressNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        streetAddressIDRef = item.Attributes["id"].Name;
                        StreetAddress ob = StreetAddress();
                        IDManager.SetID(streetAddressIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        streetAddressIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        streetAddress = new StreetAddress(item);
                    }
                }
            }
            
        
            XmlNodeList cityNodeList = xmlNode.SelectNodes("city");
            if (cityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cityIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(cityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        city = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList stateNodeList = xmlNode.SelectNodes("state");
            if (stateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stateIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(stateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        state = new XsdTypeString(item);
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
            
        
            XmlNodeList postalCodeNodeList = xmlNode.SelectNodes("postalCode");
            if (postalCodeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in postalCodeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        postalCodeIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(postalCodeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        postalCodeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        postalCode = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region StreetAddress
        private StreetAddress streetAddress;
        public StreetAddress StreetAddress
        {
            get
            {
                if (this.streetAddress != null)
                {
                    return this.streetAddress; 
                }
                else if (this.streetAddressIDRef != null)
                {
                    streetAddress = IDManager.getID(streetAddressIDRef) as StreetAddress;
                    return this.streetAddress; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.streetAddress != value)
                {
                    this.streetAddress = value;
                }
            }
        }
        #endregion
        
        public string StreetAddressIDRef { get; set; }
        #region City
        private XsdTypeString city;
        public XsdTypeString City
        {
            get
            {
                if (this.city != null)
                {
                    return this.city; 
                }
                else if (this.cityIDRef != null)
                {
                    city = IDManager.getID(cityIDRef) as XsdTypeString;
                    return this.city; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.city != value)
                {
                    this.city = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region State
        private XsdTypeString state;
        public XsdTypeString State
        {
            get
            {
                if (this.state != null)
                {
                    return this.state; 
                }
                else if (this.stateIDRef != null)
                {
                    state = IDManager.getID(stateIDRef) as XsdTypeString;
                    return this.state; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.state != value)
                {
                    this.state = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
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
        #region PostalCode
        private XsdTypeString postalCode;
        public XsdTypeString PostalCode
        {
            get
            {
                if (this.postalCode != null)
                {
                    return this.postalCode; 
                }
                else if (this.postalCodeIDRef != null)
                {
                    postalCode = IDManager.getID(postalCodeIDRef) as XsdTypeString;
                    return this.postalCode; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.postalCode != value)
                {
                    this.postalCode = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

