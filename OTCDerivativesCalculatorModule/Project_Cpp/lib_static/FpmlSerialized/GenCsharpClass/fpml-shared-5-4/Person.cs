using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Person
    {
        public Person(XmlNode xmlNode)
        {
            XmlNodeList honorificNodeList = xmlNode.SelectNodes("honorific");
            if (honorificNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in honorificNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        honorificIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(honorificIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        honorificIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        honorific = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList firstNameNodeList = xmlNode.SelectNodes("firstName");
            if (firstNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firstNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstNameIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(firstNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstName = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList middleNameNodeList = xmlNode.SelectNodes("middleName");
            
            foreach (XmlNode item in middleNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        middleNameIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString();
                        ob.Add(new XsdTypeNormalizedString(item));
                        IDManager.SetID(middleNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        middleNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    middleName.Add(new XsdTypeNormalizedString(item));
                    }
                }
            }
            
        
            XmlNodeList initialNodeList = xmlNode.SelectNodes("initial");
            
            foreach (XmlNode item in initialNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialIDRef = item.Attributes["id"].Name;
                        List<Initial> ob = new List<Initial>();
                        ob.Add(new Initial(item));
                        IDManager.SetID(initialIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    initial.Add(new Initial(item));
                    }
                }
            }
            
        
            XmlNodeList surnameNodeList = xmlNode.SelectNodes("surname");
            if (surnameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in surnameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        surnameIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(surnameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        surnameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        surname = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList suffixNodeList = xmlNode.SelectNodes("suffix");
            if (suffixNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in suffixNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        suffixIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(suffixIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        suffixIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        suffix = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList personIdNodeList = xmlNode.SelectNodes("personId");
            
            foreach (XmlNode item in personIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        personIdIDRef = item.Attributes["id"].Name;
                        List<PersonId> ob = new List<PersonId>();
                        ob.Add(new PersonId(item));
                        IDManager.SetID(personIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        personIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    personId.Add(new PersonId(item));
                    }
                }
            }
            
        
            XmlNodeList businessUnitReferenceNodeList = xmlNode.SelectNodes("businessUnitReference");
            if (businessUnitReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessUnitReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessUnitReferenceIDRef = item.Attributes["id"].Name;
                        BusinessUnitReference ob = BusinessUnitReference();
                        IDManager.SetID(businessUnitReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessUnitReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessUnitReference = new BusinessUnitReference(item);
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
        
    
        #region Honorific
        private XsdTypeNormalizedString honorific;
        public XsdTypeNormalizedString Honorific
        {
            get
            {
                if (this.honorific != null)
                {
                    return this.honorific; 
                }
                else if (this.honorificIDRef != null)
                {
                    honorific = IDManager.getID(honorificIDRef) as XsdTypeNormalizedString;
                    return this.honorific; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.honorific != value)
                {
                    this.honorific = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region FirstName
        private XsdTypeNormalizedString firstName;
        public XsdTypeNormalizedString FirstName
        {
            get
            {
                if (this.firstName != null)
                {
                    return this.firstName; 
                }
                else if (this.firstNameIDRef != null)
                {
                    firstName = IDManager.getID(firstNameIDRef) as XsdTypeNormalizedString;
                    return this.firstName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstName != value)
                {
                    this.firstName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region MiddleName
        private XsdTypeNormalizedString middleName;
        public XsdTypeNormalizedString MiddleName
        {
            get
            {
                if (this.middleName != null)
                {
                    return this.middleName; 
                }
                else if (this.middleNameIDRef != null)
                {
                    middleName = IDManager.getID(middleNameIDRef) as XsdTypeNormalizedString;
                    return this.middleName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.middleName != value)
                {
                    this.middleName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region Initial
        private List<Initial> initial;
        public List<Initial> Initial
        {
            get
            {
                if (this.initial != null)
                {
                    return this.initial; 
                }
                else if (this.initialIDRef != null)
                {
                    initial = IDManager.getID(initialIDRef) as List<Initial>;
                    return this.initial; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initial != value)
                {
                    this.initial = value;
                }
            }
        }
        #endregion
        
        public string InitialIDRef { get; set; }
        #region Surname
        private XsdTypeNormalizedString surname;
        public XsdTypeNormalizedString Surname
        {
            get
            {
                if (this.surname != null)
                {
                    return this.surname; 
                }
                else if (this.surnameIDRef != null)
                {
                    surname = IDManager.getID(surnameIDRef) as XsdTypeNormalizedString;
                    return this.surname; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.surname != value)
                {
                    this.surname = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region Suffix
        private XsdTypeNormalizedString suffix;
        public XsdTypeNormalizedString Suffix
        {
            get
            {
                if (this.suffix != null)
                {
                    return this.suffix; 
                }
                else if (this.suffixIDRef != null)
                {
                    suffix = IDManager.getID(suffixIDRef) as XsdTypeNormalizedString;
                    return this.suffix; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.suffix != value)
                {
                    this.suffix = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region PersonId
        private List<PersonId> personId;
        public List<PersonId> PersonId
        {
            get
            {
                if (this.personId != null)
                {
                    return this.personId; 
                }
                else if (this.personIdIDRef != null)
                {
                    personId = IDManager.getID(personIdIDRef) as List<PersonId>;
                    return this.personId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.personId != value)
                {
                    this.personId = value;
                }
            }
        }
        #endregion
        
        public string PersonIdIDRef { get; set; }
        #region BusinessUnitReference
        private BusinessUnitReference businessUnitReference;
        public BusinessUnitReference BusinessUnitReference
        {
            get
            {
                if (this.businessUnitReference != null)
                {
                    return this.businessUnitReference; 
                }
                else if (this.businessUnitReferenceIDRef != null)
                {
                    businessUnitReference = IDManager.getID(businessUnitReferenceIDRef) as BusinessUnitReference;
                    return this.businessUnitReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessUnitReference != value)
                {
                    this.businessUnitReference = value;
                }
            }
        }
        #endregion
        
        public string BusinessUnitReferenceIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

