using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Party
    {
        public Party(XmlNode xmlNode)
        {
            XmlNodeList partyIdNodeList = xmlNode.SelectNodes("partyId");
            
            foreach (XmlNode item in partyIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyIdIDRef = item.Attributes["id"].Name;
                        List<PartyId> ob = new List<PartyId>();
                        ob.Add(new PartyId(item));
                        IDManager.SetID(partyIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    partyId.Add(new PartyId(item));
                    }
                }
            }
            
        
            XmlNodeList partyNameNodeList = xmlNode.SelectNodes("partyName");
            if (partyNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyNameIDRef = item.Attributes["id"].Name;
                        PartyName ob = PartyName();
                        IDManager.SetID(partyNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyName = new PartyName(item);
                    }
                }
            }
            
        
            XmlNodeList classificationNodeList = xmlNode.SelectNodes("classification");
            
            foreach (XmlNode item in classificationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        classificationIDRef = item.Attributes["id"].Name;
                        List<IndustryClassification> ob = new List<IndustryClassification>();
                        ob.Add(new IndustryClassification(item));
                        IDManager.SetID(classificationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        classificationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    classification.Add(new IndustryClassification(item));
                    }
                }
            }
            
        
            XmlNodeList creditRatingNodeList = xmlNode.SelectNodes("creditRating");
            
            foreach (XmlNode item in creditRatingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditRatingIDRef = item.Attributes["id"].Name;
                        List<CreditRating> ob = new List<CreditRating>();
                        ob.Add(new CreditRating(item));
                        IDManager.SetID(creditRatingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditRatingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    creditRating.Add(new CreditRating(item));
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
            
        
            XmlNodeList jurisdictionNodeList = xmlNode.SelectNodes("jurisdiction");
            
            foreach (XmlNode item in jurisdictionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        jurisdictionIDRef = item.Attributes["id"].Name;
                        List<GoverningLaw> ob = new List<GoverningLaw>();
                        ob.Add(new GoverningLaw(item));
                        IDManager.SetID(jurisdictionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        jurisdictionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    jurisdiction.Add(new GoverningLaw(item));
                    }
                }
            }
            
        
            XmlNodeList organizationTypeNodeList = xmlNode.SelectNodes("organizationType");
            if (organizationTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in organizationTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        organizationTypeIDRef = item.Attributes["id"].Name;
                        OrganizationType ob = OrganizationType();
                        IDManager.SetID(organizationTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        organizationTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        organizationType = new OrganizationType(item);
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
            
        
            XmlNodeList businessUnitNodeList = xmlNode.SelectNodes("businessUnit");
            
            foreach (XmlNode item in businessUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessUnitIDRef = item.Attributes["id"].Name;
                        List<BusinessUnit> ob = new List<BusinessUnit>();
                        ob.Add(new BusinessUnit(item));
                        IDManager.SetID(businessUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    businessUnit.Add(new BusinessUnit(item));
                    }
                }
            }
            
        
            XmlNodeList personNodeList = xmlNode.SelectNodes("person");
            
            foreach (XmlNode item in personNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        personIDRef = item.Attributes["id"].Name;
                        List<Person> ob = new List<Person>();
                        ob.Add(new Person(item));
                        IDManager.SetID(personIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        personIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    person.Add(new Person(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyId
        private List<PartyId> partyId;
        public List<PartyId> PartyId
        {
            get
            {
                if (this.partyId != null)
                {
                    return this.partyId; 
                }
                else if (this.partyIdIDRef != null)
                {
                    partyId = IDManager.getID(partyIdIDRef) as List<PartyId>;
                    return this.partyId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyId != value)
                {
                    this.partyId = value;
                }
            }
        }
        #endregion
        
        public string PartyIdIDRef { get; set; }
        #region PartyName
        private PartyName partyName;
        public PartyName PartyName
        {
            get
            {
                if (this.partyName != null)
                {
                    return this.partyName; 
                }
                else if (this.partyNameIDRef != null)
                {
                    partyName = IDManager.getID(partyNameIDRef) as PartyName;
                    return this.partyName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyName != value)
                {
                    this.partyName = value;
                }
            }
        }
        #endregion
        
        public string PartyNameIDRef { get; set; }
        #region Classification
        private List<IndustryClassification> classification;
        public List<IndustryClassification> Classification
        {
            get
            {
                if (this.classification != null)
                {
                    return this.classification; 
                }
                else if (this.classificationIDRef != null)
                {
                    classification = IDManager.getID(classificationIDRef) as List<IndustryClassification>;
                    return this.classification; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.classification != value)
                {
                    this.classification = value;
                }
            }
        }
        #endregion
        
        public string IndustryClassificationIDRef { get; set; }
        #region CreditRating
        private List<CreditRating> creditRating;
        public List<CreditRating> CreditRating
        {
            get
            {
                if (this.creditRating != null)
                {
                    return this.creditRating; 
                }
                else if (this.creditRatingIDRef != null)
                {
                    creditRating = IDManager.getID(creditRatingIDRef) as List<CreditRating>;
                    return this.creditRating; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditRating != value)
                {
                    this.creditRating = value;
                }
            }
        }
        #endregion
        
        public string CreditRatingIDRef { get; set; }
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
        #region Jurisdiction
        private List<GoverningLaw> jurisdiction;
        public List<GoverningLaw> Jurisdiction
        {
            get
            {
                if (this.jurisdiction != null)
                {
                    return this.jurisdiction; 
                }
                else if (this.jurisdictionIDRef != null)
                {
                    jurisdiction = IDManager.getID(jurisdictionIDRef) as List<GoverningLaw>;
                    return this.jurisdiction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.jurisdiction != value)
                {
                    this.jurisdiction = value;
                }
            }
        }
        #endregion
        
        public string GoverningLawIDRef { get; set; }
        #region OrganizationType
        private OrganizationType organizationType;
        public OrganizationType OrganizationType
        {
            get
            {
                if (this.organizationType != null)
                {
                    return this.organizationType; 
                }
                else if (this.organizationTypeIDRef != null)
                {
                    organizationType = IDManager.getID(organizationTypeIDRef) as OrganizationType;
                    return this.organizationType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.organizationType != value)
                {
                    this.organizationType = value;
                }
            }
        }
        #endregion
        
        public string OrganizationTypeIDRef { get; set; }
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
        #region BusinessUnit
        private List<BusinessUnit> businessUnit;
        public List<BusinessUnit> BusinessUnit
        {
            get
            {
                if (this.businessUnit != null)
                {
                    return this.businessUnit; 
                }
                else if (this.businessUnitIDRef != null)
                {
                    businessUnit = IDManager.getID(businessUnitIDRef) as List<BusinessUnit>;
                    return this.businessUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessUnit != value)
                {
                    this.businessUnit = value;
                }
            }
        }
        #endregion
        
        public string BusinessUnitIDRef { get; set; }
        #region Person
        private List<Person> person;
        public List<Person> Person
        {
            get
            {
                if (this.person != null)
                {
                    return this.person; 
                }
                else if (this.personIDRef != null)
                {
                    person = IDManager.getID(personIDRef) as List<Person>;
                    return this.person; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.person != value)
                {
                    this.person = value;
                }
            }
        }
        #endregion
        
        public string PersonIDRef { get; set; }
        
    
        
    
    }
    
}

