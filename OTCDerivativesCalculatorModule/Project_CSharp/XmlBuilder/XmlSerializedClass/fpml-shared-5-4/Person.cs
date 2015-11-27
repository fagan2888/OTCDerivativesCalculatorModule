using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Person : ISerialized
    {
        public Person(XmlNode xmlNode)
        {
            XmlNode honorificNode = xmlNode.SelectSingleNode("honorific");
            
            if (honorificNode != null)
            {
                if (honorificNode.Attributes["href"] != null || honorificNode.Attributes["id"] != null) 
                {
                    if (honorificNode.Attributes["id"] != null) 
                    {
                        honorificIDRef_ = honorificNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(honorificNode);
                        IDManager.SetID(honorificIDRef_, ob);
                    }
                    else if (honorificNode.Attributes["href"] != null)
                    {
                        honorificIDRef_ = honorificNode.Attributes["href"].Value;
                    }
                    else
                    {
                        honorific_ = new XsdTypeNormalizedString(honorificNode);
                    }
                }
                else
                {
                    honorific_ = new XsdTypeNormalizedString(honorificNode);
                }
            }
            
        
            XmlNode firstNameNode = xmlNode.SelectSingleNode("firstName");
            
            if (firstNameNode != null)
            {
                if (firstNameNode.Attributes["href"] != null || firstNameNode.Attributes["id"] != null) 
                {
                    if (firstNameNode.Attributes["id"] != null) 
                    {
                        firstNameIDRef_ = firstNameNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(firstNameNode);
                        IDManager.SetID(firstNameIDRef_, ob);
                    }
                    else if (firstNameNode.Attributes["href"] != null)
                    {
                        firstNameIDRef_ = firstNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstName_ = new XsdTypeNormalizedString(firstNameNode);
                    }
                }
                else
                {
                    firstName_ = new XsdTypeNormalizedString(firstNameNode);
                }
            }
            
        
            XmlNodeList middleNameNodeList = xmlNode.SelectNodes("middleName");
            
            if (middleNameNodeList != null)
            {
                this.middleName_ = new List<XsdTypeNormalizedString>();
                foreach (XmlNode item in middleNameNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            middleNameIDRef_ = item.Attributes["id"].Value;
                            middleName_.Add(new XsdTypeNormalizedString(item));
                            IDManager.SetID(middleNameIDRef_, middleName_[middleName_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            middleNameIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        middleName_.Add(new XsdTypeNormalizedString(item));
                        }
                    }
                    else
                    {
                        middleName_.Add(new XsdTypeNormalizedString(item));
                    }
                }
            }
            
        
            XmlNodeList initialNodeList = xmlNode.SelectNodes("initial");
            
            if (initialNodeList != null)
            {
                this.initial_ = new List<Initial>();
                foreach (XmlNode item in initialNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            initialIDRef_ = item.Attributes["id"].Value;
                            initial_.Add(new Initial(item));
                            IDManager.SetID(initialIDRef_, initial_[initial_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            initialIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        initial_.Add(new Initial(item));
                        }
                    }
                    else
                    {
                        initial_.Add(new Initial(item));
                    }
                }
            }
            
        
            XmlNode surnameNode = xmlNode.SelectSingleNode("surname");
            
            if (surnameNode != null)
            {
                if (surnameNode.Attributes["href"] != null || surnameNode.Attributes["id"] != null) 
                {
                    if (surnameNode.Attributes["id"] != null) 
                    {
                        surnameIDRef_ = surnameNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(surnameNode);
                        IDManager.SetID(surnameIDRef_, ob);
                    }
                    else if (surnameNode.Attributes["href"] != null)
                    {
                        surnameIDRef_ = surnameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        surname_ = new XsdTypeNormalizedString(surnameNode);
                    }
                }
                else
                {
                    surname_ = new XsdTypeNormalizedString(surnameNode);
                }
            }
            
        
            XmlNode suffixNode = xmlNode.SelectSingleNode("suffix");
            
            if (suffixNode != null)
            {
                if (suffixNode.Attributes["href"] != null || suffixNode.Attributes["id"] != null) 
                {
                    if (suffixNode.Attributes["id"] != null) 
                    {
                        suffixIDRef_ = suffixNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(suffixNode);
                        IDManager.SetID(suffixIDRef_, ob);
                    }
                    else if (suffixNode.Attributes["href"] != null)
                    {
                        suffixIDRef_ = suffixNode.Attributes["href"].Value;
                    }
                    else
                    {
                        suffix_ = new XsdTypeNormalizedString(suffixNode);
                    }
                }
                else
                {
                    suffix_ = new XsdTypeNormalizedString(suffixNode);
                }
            }
            
        
            XmlNodeList personIdNodeList = xmlNode.SelectNodes("personId");
            
            if (personIdNodeList != null)
            {
                this.personId_ = new List<PersonId>();
                foreach (XmlNode item in personIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            personIdIDRef_ = item.Attributes["id"].Value;
                            personId_.Add(new PersonId(item));
                            IDManager.SetID(personIdIDRef_, personId_[personId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            personIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        personId_.Add(new PersonId(item));
                        }
                    }
                    else
                    {
                        personId_.Add(new PersonId(item));
                    }
                }
            }
            
        
            XmlNode businessUnitReferenceNode = xmlNode.SelectSingleNode("businessUnitReference");
            
            if (businessUnitReferenceNode != null)
            {
                if (businessUnitReferenceNode.Attributes["href"] != null || businessUnitReferenceNode.Attributes["id"] != null) 
                {
                    if (businessUnitReferenceNode.Attributes["id"] != null) 
                    {
                        businessUnitReferenceIDRef_ = businessUnitReferenceNode.Attributes["id"].Value;
                        BusinessUnitReference ob = new BusinessUnitReference(businessUnitReferenceNode);
                        IDManager.SetID(businessUnitReferenceIDRef_, ob);
                    }
                    else if (businessUnitReferenceNode.Attributes["href"] != null)
                    {
                        businessUnitReferenceIDRef_ = businessUnitReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessUnitReference_ = new BusinessUnitReference(businessUnitReferenceNode);
                    }
                }
                else
                {
                    businessUnitReference_ = new BusinessUnitReference(businessUnitReferenceNode);
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
        
    
        #region Honorific_
        private XsdTypeNormalizedString honorific_;
        public XsdTypeNormalizedString Honorific_
        {
            get
            {
                if (this.honorific_ != null)
                {
                    return this.honorific_; 
                }
                else if (this.honorificIDRef_ != null)
                {
                    honorific_ = IDManager.getID(honorificIDRef_) as XsdTypeNormalizedString;
                    return this.honorific_; 
                }
                else
                {
                      return this.honorific_; 
                }
            }
            set
            {
                if (this.honorific_ != value)
                {
                    this.honorific_ = value;
                }
            }
        }
        #endregion
        
        public string honorificIDRef_ { get; set; }
        #region FirstName_
        private XsdTypeNormalizedString firstName_;
        public XsdTypeNormalizedString FirstName_
        {
            get
            {
                if (this.firstName_ != null)
                {
                    return this.firstName_; 
                }
                else if (this.firstNameIDRef_ != null)
                {
                    firstName_ = IDManager.getID(firstNameIDRef_) as XsdTypeNormalizedString;
                    return this.firstName_; 
                }
                else
                {
                      return this.firstName_; 
                }
            }
            set
            {
                if (this.firstName_ != value)
                {
                    this.firstName_ = value;
                }
            }
        }
        #endregion
        
        public string firstNameIDRef_ { get; set; }
        #region MiddleName_
        private List<XsdTypeNormalizedString> middleName_;
        public List<XsdTypeNormalizedString> MiddleName_
        {
            get
            {
                if (this.middleName_ != null)
                {
                    return this.middleName_; 
                }
                else if (this.middleNameIDRef_ != null)
                {
                    return this.middleName_; 
                }
                else
                {
                      return this.middleName_; 
                }
            }
            set
            {
                if (this.middleName_ != value)
                {
                    this.middleName_ = value;
                }
            }
        }
        #endregion
        
        public string middleNameIDRef_ { get; set; }
        #region Initial_
        private List<Initial> initial_;
        public List<Initial> Initial_
        {
            get
            {
                if (this.initial_ != null)
                {
                    return this.initial_; 
                }
                else if (this.initialIDRef_ != null)
                {
                    return this.initial_; 
                }
                else
                {
                      return this.initial_; 
                }
            }
            set
            {
                if (this.initial_ != value)
                {
                    this.initial_ = value;
                }
            }
        }
        #endregion
        
        public string initialIDRef_ { get; set; }
        #region Surname_
        private XsdTypeNormalizedString surname_;
        public XsdTypeNormalizedString Surname_
        {
            get
            {
                if (this.surname_ != null)
                {
                    return this.surname_; 
                }
                else if (this.surnameIDRef_ != null)
                {
                    surname_ = IDManager.getID(surnameIDRef_) as XsdTypeNormalizedString;
                    return this.surname_; 
                }
                else
                {
                      return this.surname_; 
                }
            }
            set
            {
                if (this.surname_ != value)
                {
                    this.surname_ = value;
                }
            }
        }
        #endregion
        
        public string surnameIDRef_ { get; set; }
        #region Suffix_
        private XsdTypeNormalizedString suffix_;
        public XsdTypeNormalizedString Suffix_
        {
            get
            {
                if (this.suffix_ != null)
                {
                    return this.suffix_; 
                }
                else if (this.suffixIDRef_ != null)
                {
                    suffix_ = IDManager.getID(suffixIDRef_) as XsdTypeNormalizedString;
                    return this.suffix_; 
                }
                else
                {
                      return this.suffix_; 
                }
            }
            set
            {
                if (this.suffix_ != value)
                {
                    this.suffix_ = value;
                }
            }
        }
        #endregion
        
        public string suffixIDRef_ { get; set; }
        #region PersonId_
        private List<PersonId> personId_;
        public List<PersonId> PersonId_
        {
            get
            {
                if (this.personId_ != null)
                {
                    return this.personId_; 
                }
                else if (this.personIdIDRef_ != null)
                {
                    return this.personId_; 
                }
                else
                {
                      return this.personId_; 
                }
            }
            set
            {
                if (this.personId_ != value)
                {
                    this.personId_ = value;
                }
            }
        }
        #endregion
        
        public string personIdIDRef_ { get; set; }
        #region BusinessUnitReference_
        private BusinessUnitReference businessUnitReference_;
        public BusinessUnitReference BusinessUnitReference_
        {
            get
            {
                if (this.businessUnitReference_ != null)
                {
                    return this.businessUnitReference_; 
                }
                else if (this.businessUnitReferenceIDRef_ != null)
                {
                    businessUnitReference_ = IDManager.getID(businessUnitReferenceIDRef_) as BusinessUnitReference;
                    return this.businessUnitReference_; 
                }
                else
                {
                      return this.businessUnitReference_; 
                }
            }
            set
            {
                if (this.businessUnitReference_ != value)
                {
                    this.businessUnitReference_ = value;
                }
            }
        }
        #endregion
        
        public string businessUnitReferenceIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

