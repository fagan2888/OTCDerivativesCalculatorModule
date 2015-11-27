using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ContactInformation
    {
        public ContactInformation(XmlNode xmlNode)
        {
            XmlNodeList telephoneNodeList = xmlNode.SelectNodes("telephone");
            
            foreach (XmlNode item in telephoneNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        telephoneIDRef = item.Attributes["id"].Name;
                        List<TelephoneNumber> ob = new List<TelephoneNumber>();
                        ob.Add(new TelephoneNumber(item));
                        IDManager.SetID(telephoneIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        telephoneIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    telephone.Add(new TelephoneNumber(item));
                    }
                }
            }
            
        
            XmlNodeList emailNodeList = xmlNode.SelectNodes("email");
            
            foreach (XmlNode item in emailNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        emailIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString();
                        ob.Add(new XsdTypeNormalizedString(item));
                        IDManager.SetID(emailIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        emailIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    email.Add(new XsdTypeNormalizedString(item));
                    }
                }
            }
            
        
            XmlNodeList addressNodeList = xmlNode.SelectNodes("address");
            if (addressNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in addressNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        addressIDRef = item.Attributes["id"].Name;
                        Address ob = Address();
                        IDManager.SetID(addressIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        addressIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        address = new Address(item);
                    }
                }
            }
            
        
        }
        
    
        #region Telephone
        private List<TelephoneNumber> telephone;
        public List<TelephoneNumber> Telephone
        {
            get
            {
                if (this.telephone != null)
                {
                    return this.telephone; 
                }
                else if (this.telephoneIDRef != null)
                {
                    telephone = IDManager.getID(telephoneIDRef) as List<TelephoneNumber>;
                    return this.telephone; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.telephone != value)
                {
                    this.telephone = value;
                }
            }
        }
        #endregion
        
        public string TelephoneNumberIDRef { get; set; }
        #region Email
        private XsdTypeNormalizedString email;
        public XsdTypeNormalizedString Email
        {
            get
            {
                if (this.email != null)
                {
                    return this.email; 
                }
                else if (this.emailIDRef != null)
                {
                    email = IDManager.getID(emailIDRef) as XsdTypeNormalizedString;
                    return this.email; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.email != value)
                {
                    this.email = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region Address
        private Address address;
        public Address Address
        {
            get
            {
                if (this.address != null)
                {
                    return this.address; 
                }
                else if (this.addressIDRef != null)
                {
                    address = IDManager.getID(addressIDRef) as Address;
                    return this.address; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.address != value)
                {
                    this.address = value;
                }
            }
        }
        #endregion
        
        public string AddressIDRef { get; set; }
        
    
        
    
    }
    
}

