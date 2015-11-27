using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ContactInformation : ISerialized
    {
        public ContactInformation(XmlNode xmlNode)
        {
            XmlNodeList telephoneNodeList = xmlNode.SelectNodes("telephone");
            
            if (telephoneNodeList != null)
            {
                this.telephone_ = new List<TelephoneNumber>();
                foreach (XmlNode item in telephoneNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            telephoneIDRef_ = item.Attributes["id"].Value;
                            telephone_.Add(new TelephoneNumber(item));
                            IDManager.SetID(telephoneIDRef_, telephone_[telephone_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            telephoneIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        telephone_.Add(new TelephoneNumber(item));
                        }
                    }
                    else
                    {
                        telephone_.Add(new TelephoneNumber(item));
                    }
                }
            }
            
        
            XmlNodeList emailNodeList = xmlNode.SelectNodes("email");
            
            if (emailNodeList != null)
            {
                this.email_ = new List<XsdTypeNormalizedString>();
                foreach (XmlNode item in emailNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            emailIDRef_ = item.Attributes["id"].Value;
                            email_.Add(new XsdTypeNormalizedString(item));
                            IDManager.SetID(emailIDRef_, email_[email_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            emailIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        email_.Add(new XsdTypeNormalizedString(item));
                        }
                    }
                    else
                    {
                        email_.Add(new XsdTypeNormalizedString(item));
                    }
                }
            }
            
        
            XmlNode addressNode = xmlNode.SelectSingleNode("address");
            
            if (addressNode != null)
            {
                if (addressNode.Attributes["href"] != null || addressNode.Attributes["id"] != null) 
                {
                    if (addressNode.Attributes["id"] != null) 
                    {
                        addressIDRef_ = addressNode.Attributes["id"].Value;
                        Address ob = new Address(addressNode);
                        IDManager.SetID(addressIDRef_, ob);
                    }
                    else if (addressNode.Attributes["href"] != null)
                    {
                        addressIDRef_ = addressNode.Attributes["href"].Value;
                    }
                    else
                    {
                        address_ = new Address(addressNode);
                    }
                }
                else
                {
                    address_ = new Address(addressNode);
                }
            }
            
        
        }
        
    
        #region Telephone_
        private List<TelephoneNumber> telephone_;
        public List<TelephoneNumber> Telephone_
        {
            get
            {
                if (this.telephone_ != null)
                {
                    return this.telephone_; 
                }
                else if (this.telephoneIDRef_ != null)
                {
                    return this.telephone_; 
                }
                else
                {
                      return this.telephone_; 
                }
            }
            set
            {
                if (this.telephone_ != value)
                {
                    this.telephone_ = value;
                }
            }
        }
        #endregion
        
        public string telephoneIDRef_ { get; set; }
        #region Email_
        private List<XsdTypeNormalizedString> email_;
        public List<XsdTypeNormalizedString> Email_
        {
            get
            {
                if (this.email_ != null)
                {
                    return this.email_; 
                }
                else if (this.emailIDRef_ != null)
                {
                    return this.email_; 
                }
                else
                {
                      return this.email_; 
                }
            }
            set
            {
                if (this.email_ != value)
                {
                    this.email_ = value;
                }
            }
        }
        #endregion
        
        public string emailIDRef_ { get; set; }
        #region Address_
        private Address address_;
        public Address Address_
        {
            get
            {
                if (this.address_ != null)
                {
                    return this.address_; 
                }
                else if (this.addressIDRef_ != null)
                {
                    address_ = IDManager.getID(addressIDRef_) as Address;
                    return this.address_; 
                }
                else
                {
                      return this.address_; 
                }
            }
            set
            {
                if (this.address_ != value)
                {
                    this.address_ = value;
                }
            }
        }
        #endregion
        
        public string addressIDRef_ { get; set; }
        
    
        
    
    }
    
}

