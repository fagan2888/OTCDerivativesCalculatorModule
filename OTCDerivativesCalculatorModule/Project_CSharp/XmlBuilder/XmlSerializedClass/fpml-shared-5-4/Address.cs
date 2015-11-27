using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Address : ISerialized
    {
        public Address(XmlNode xmlNode)
        {
            XmlNode streetAddressNode = xmlNode.SelectSingleNode("streetAddress");
            
            if (streetAddressNode != null)
            {
                if (streetAddressNode.Attributes["href"] != null || streetAddressNode.Attributes["id"] != null) 
                {
                    if (streetAddressNode.Attributes["id"] != null) 
                    {
                        streetAddressIDRef_ = streetAddressNode.Attributes["id"].Value;
                        StreetAddress ob = new StreetAddress(streetAddressNode);
                        IDManager.SetID(streetAddressIDRef_, ob);
                    }
                    else if (streetAddressNode.Attributes["href"] != null)
                    {
                        streetAddressIDRef_ = streetAddressNode.Attributes["href"].Value;
                    }
                    else
                    {
                        streetAddress_ = new StreetAddress(streetAddressNode);
                    }
                }
                else
                {
                    streetAddress_ = new StreetAddress(streetAddressNode);
                }
            }
            
        
            XmlNode cityNode = xmlNode.SelectSingleNode("city");
            
            if (cityNode != null)
            {
                if (cityNode.Attributes["href"] != null || cityNode.Attributes["id"] != null) 
                {
                    if (cityNode.Attributes["id"] != null) 
                    {
                        cityIDRef_ = cityNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(cityNode);
                        IDManager.SetID(cityIDRef_, ob);
                    }
                    else if (cityNode.Attributes["href"] != null)
                    {
                        cityIDRef_ = cityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        city_ = new XsdTypeString(cityNode);
                    }
                }
                else
                {
                    city_ = new XsdTypeString(cityNode);
                }
            }
            
        
            XmlNode stateNode = xmlNode.SelectSingleNode("state");
            
            if (stateNode != null)
            {
                if (stateNode.Attributes["href"] != null || stateNode.Attributes["id"] != null) 
                {
                    if (stateNode.Attributes["id"] != null) 
                    {
                        stateIDRef_ = stateNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(stateNode);
                        IDManager.SetID(stateIDRef_, ob);
                    }
                    else if (stateNode.Attributes["href"] != null)
                    {
                        stateIDRef_ = stateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        state_ = new XsdTypeString(stateNode);
                    }
                }
                else
                {
                    state_ = new XsdTypeString(stateNode);
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
            
        
            XmlNode postalCodeNode = xmlNode.SelectSingleNode("postalCode");
            
            if (postalCodeNode != null)
            {
                if (postalCodeNode.Attributes["href"] != null || postalCodeNode.Attributes["id"] != null) 
                {
                    if (postalCodeNode.Attributes["id"] != null) 
                    {
                        postalCodeIDRef_ = postalCodeNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(postalCodeNode);
                        IDManager.SetID(postalCodeIDRef_, ob);
                    }
                    else if (postalCodeNode.Attributes["href"] != null)
                    {
                        postalCodeIDRef_ = postalCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        postalCode_ = new XsdTypeString(postalCodeNode);
                    }
                }
                else
                {
                    postalCode_ = new XsdTypeString(postalCodeNode);
                }
            }
            
        
        }
        
    
        #region StreetAddress_
        private StreetAddress streetAddress_;
        public StreetAddress StreetAddress_
        {
            get
            {
                if (this.streetAddress_ != null)
                {
                    return this.streetAddress_; 
                }
                else if (this.streetAddressIDRef_ != null)
                {
                    streetAddress_ = IDManager.getID(streetAddressIDRef_) as StreetAddress;
                    return this.streetAddress_; 
                }
                else
                {
                      return this.streetAddress_; 
                }
            }
            set
            {
                if (this.streetAddress_ != value)
                {
                    this.streetAddress_ = value;
                }
            }
        }
        #endregion
        
        public string streetAddressIDRef_ { get; set; }
        #region City_
        private XsdTypeString city_;
        public XsdTypeString City_
        {
            get
            {
                if (this.city_ != null)
                {
                    return this.city_; 
                }
                else if (this.cityIDRef_ != null)
                {
                    city_ = IDManager.getID(cityIDRef_) as XsdTypeString;
                    return this.city_; 
                }
                else
                {
                      return this.city_; 
                }
            }
            set
            {
                if (this.city_ != value)
                {
                    this.city_ = value;
                }
            }
        }
        #endregion
        
        public string cityIDRef_ { get; set; }
        #region State_
        private XsdTypeString state_;
        public XsdTypeString State_
        {
            get
            {
                if (this.state_ != null)
                {
                    return this.state_; 
                }
                else if (this.stateIDRef_ != null)
                {
                    state_ = IDManager.getID(stateIDRef_) as XsdTypeString;
                    return this.state_; 
                }
                else
                {
                      return this.state_; 
                }
            }
            set
            {
                if (this.state_ != value)
                {
                    this.state_ = value;
                }
            }
        }
        #endregion
        
        public string stateIDRef_ { get; set; }
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
        #region PostalCode_
        private XsdTypeString postalCode_;
        public XsdTypeString PostalCode_
        {
            get
            {
                if (this.postalCode_ != null)
                {
                    return this.postalCode_; 
                }
                else if (this.postalCodeIDRef_ != null)
                {
                    postalCode_ = IDManager.getID(postalCodeIDRef_) as XsdTypeString;
                    return this.postalCode_; 
                }
                else
                {
                      return this.postalCode_; 
                }
            }
            set
            {
                if (this.postalCode_ != value)
                {
                    this.postalCode_ = value;
                }
            }
        }
        #endregion
        
        public string postalCodeIDRef_ { get; set; }
        
    
        
    
    }
    
}

