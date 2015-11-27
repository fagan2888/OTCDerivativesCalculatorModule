using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Party : ISerialized
    {
        public Party(XmlNode xmlNode)
        {
            XmlNodeList partyIdNodeList = xmlNode.SelectNodes("partyId");
            
            if (partyIdNodeList != null)
            {
                this.partyId_ = new List<PartyId>();
                foreach (XmlNode item in partyIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyIdIDRef_ = item.Attributes["id"].Value;
                            partyId_.Add(new PartyId(item));
                            IDManager.SetID(partyIdIDRef_, partyId_[partyId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partyId_.Add(new PartyId(item));
                        }
                    }
                    else
                    {
                        partyId_.Add(new PartyId(item));
                    }
                }
            }
            
        
            XmlNode partyNameNode = xmlNode.SelectSingleNode("partyName");
            
            if (partyNameNode != null)
            {
                if (partyNameNode.Attributes["href"] != null || partyNameNode.Attributes["id"] != null) 
                {
                    if (partyNameNode.Attributes["id"] != null) 
                    {
                        partyNameIDRef_ = partyNameNode.Attributes["id"].Value;
                        PartyName ob = new PartyName(partyNameNode);
                        IDManager.SetID(partyNameIDRef_, ob);
                    }
                    else if (partyNameNode.Attributes["href"] != null)
                    {
                        partyNameIDRef_ = partyNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyName_ = new PartyName(partyNameNode);
                    }
                }
                else
                {
                    partyName_ = new PartyName(partyNameNode);
                }
            }
            
        
            XmlNodeList classificationNodeList = xmlNode.SelectNodes("classification");
            
            if (classificationNodeList != null)
            {
                this.classification_ = new List<IndustryClassification>();
                foreach (XmlNode item in classificationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            classificationIDRef_ = item.Attributes["id"].Value;
                            classification_.Add(new IndustryClassification(item));
                            IDManager.SetID(classificationIDRef_, classification_[classification_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            classificationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        classification_.Add(new IndustryClassification(item));
                        }
                    }
                    else
                    {
                        classification_.Add(new IndustryClassification(item));
                    }
                }
            }
            
        
            XmlNodeList creditRatingNodeList = xmlNode.SelectNodes("creditRating");
            
            if (creditRatingNodeList != null)
            {
                this.creditRating_ = new List<CreditRating>();
                foreach (XmlNode item in creditRatingNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            creditRatingIDRef_ = item.Attributes["id"].Value;
                            creditRating_.Add(new CreditRating(item));
                            IDManager.SetID(creditRatingIDRef_, creditRating_[creditRating_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            creditRatingIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        creditRating_.Add(new CreditRating(item));
                        }
                    }
                    else
                    {
                        creditRating_.Add(new CreditRating(item));
                    }
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
            
        
            XmlNodeList jurisdictionNodeList = xmlNode.SelectNodes("jurisdiction");
            
            if (jurisdictionNodeList != null)
            {
                this.jurisdiction_ = new List<GoverningLaw>();
                foreach (XmlNode item in jurisdictionNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            jurisdictionIDRef_ = item.Attributes["id"].Value;
                            jurisdiction_.Add(new GoverningLaw(item));
                            IDManager.SetID(jurisdictionIDRef_, jurisdiction_[jurisdiction_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            jurisdictionIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        jurisdiction_.Add(new GoverningLaw(item));
                        }
                    }
                    else
                    {
                        jurisdiction_.Add(new GoverningLaw(item));
                    }
                }
            }
            
        
            XmlNode organizationTypeNode = xmlNode.SelectSingleNode("organizationType");
            
            if (organizationTypeNode != null)
            {
                if (organizationTypeNode.Attributes["href"] != null || organizationTypeNode.Attributes["id"] != null) 
                {
                    if (organizationTypeNode.Attributes["id"] != null) 
                    {
                        organizationTypeIDRef_ = organizationTypeNode.Attributes["id"].Value;
                        OrganizationType ob = new OrganizationType(organizationTypeNode);
                        IDManager.SetID(organizationTypeIDRef_, ob);
                    }
                    else if (organizationTypeNode.Attributes["href"] != null)
                    {
                        organizationTypeIDRef_ = organizationTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        organizationType_ = new OrganizationType(organizationTypeNode);
                    }
                }
                else
                {
                    organizationType_ = new OrganizationType(organizationTypeNode);
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
            
        
            XmlNodeList businessUnitNodeList = xmlNode.SelectNodes("businessUnit");
            
            if (businessUnitNodeList != null)
            {
                this.businessUnit_ = new List<BusinessUnit>();
                foreach (XmlNode item in businessUnitNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            businessUnitIDRef_ = item.Attributes["id"].Value;
                            businessUnit_.Add(new BusinessUnit(item));
                            IDManager.SetID(businessUnitIDRef_, businessUnit_[businessUnit_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            businessUnitIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        businessUnit_.Add(new BusinessUnit(item));
                        }
                    }
                    else
                    {
                        businessUnit_.Add(new BusinessUnit(item));
                    }
                }
            }
            
        
            XmlNodeList personNodeList = xmlNode.SelectNodes("person");
            
            if (personNodeList != null)
            {
                this.person_ = new List<Person>();
                foreach (XmlNode item in personNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            personIDRef_ = item.Attributes["id"].Value;
                            person_.Add(new Person(item));
                            IDManager.SetID(personIDRef_, person_[person_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            personIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        person_.Add(new Person(item));
                        }
                    }
                    else
                    {
                        person_.Add(new Person(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyId_
        private List<PartyId> partyId_;
        public List<PartyId> PartyId_
        {
            get
            {
                if (this.partyId_ != null)
                {
                    return this.partyId_; 
                }
                else if (this.partyIdIDRef_ != null)
                {
                    return this.partyId_; 
                }
                else
                {
                      return this.partyId_; 
                }
            }
            set
            {
                if (this.partyId_ != value)
                {
                    this.partyId_ = value;
                }
            }
        }
        #endregion
        
        public string partyIdIDRef_ { get; set; }
        #region PartyName_
        private PartyName partyName_;
        public PartyName PartyName_
        {
            get
            {
                if (this.partyName_ != null)
                {
                    return this.partyName_; 
                }
                else if (this.partyNameIDRef_ != null)
                {
                    partyName_ = IDManager.getID(partyNameIDRef_) as PartyName;
                    return this.partyName_; 
                }
                else
                {
                      return this.partyName_; 
                }
            }
            set
            {
                if (this.partyName_ != value)
                {
                    this.partyName_ = value;
                }
            }
        }
        #endregion
        
        public string partyNameIDRef_ { get; set; }
        #region Classification_
        private List<IndustryClassification> classification_;
        public List<IndustryClassification> Classification_
        {
            get
            {
                if (this.classification_ != null)
                {
                    return this.classification_; 
                }
                else if (this.classificationIDRef_ != null)
                {
                    return this.classification_; 
                }
                else
                {
                      return this.classification_; 
                }
            }
            set
            {
                if (this.classification_ != value)
                {
                    this.classification_ = value;
                }
            }
        }
        #endregion
        
        public string classificationIDRef_ { get; set; }
        #region CreditRating_
        private List<CreditRating> creditRating_;
        public List<CreditRating> CreditRating_
        {
            get
            {
                if (this.creditRating_ != null)
                {
                    return this.creditRating_; 
                }
                else if (this.creditRatingIDRef_ != null)
                {
                    return this.creditRating_; 
                }
                else
                {
                      return this.creditRating_; 
                }
            }
            set
            {
                if (this.creditRating_ != value)
                {
                    this.creditRating_ = value;
                }
            }
        }
        #endregion
        
        public string creditRatingIDRef_ { get; set; }
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
        #region Jurisdiction_
        private List<GoverningLaw> jurisdiction_;
        public List<GoverningLaw> Jurisdiction_
        {
            get
            {
                if (this.jurisdiction_ != null)
                {
                    return this.jurisdiction_; 
                }
                else if (this.jurisdictionIDRef_ != null)
                {
                    return this.jurisdiction_; 
                }
                else
                {
                      return this.jurisdiction_; 
                }
            }
            set
            {
                if (this.jurisdiction_ != value)
                {
                    this.jurisdiction_ = value;
                }
            }
        }
        #endregion
        
        public string jurisdictionIDRef_ { get; set; }
        #region OrganizationType_
        private OrganizationType organizationType_;
        public OrganizationType OrganizationType_
        {
            get
            {
                if (this.organizationType_ != null)
                {
                    return this.organizationType_; 
                }
                else if (this.organizationTypeIDRef_ != null)
                {
                    organizationType_ = IDManager.getID(organizationTypeIDRef_) as OrganizationType;
                    return this.organizationType_; 
                }
                else
                {
                      return this.organizationType_; 
                }
            }
            set
            {
                if (this.organizationType_ != value)
                {
                    this.organizationType_ = value;
                }
            }
        }
        #endregion
        
        public string organizationTypeIDRef_ { get; set; }
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
        #region BusinessUnit_
        private List<BusinessUnit> businessUnit_;
        public List<BusinessUnit> BusinessUnit_
        {
            get
            {
                if (this.businessUnit_ != null)
                {
                    return this.businessUnit_; 
                }
                else if (this.businessUnitIDRef_ != null)
                {
                    return this.businessUnit_; 
                }
                else
                {
                      return this.businessUnit_; 
                }
            }
            set
            {
                if (this.businessUnit_ != value)
                {
                    this.businessUnit_ = value;
                }
            }
        }
        #endregion
        
        public string businessUnitIDRef_ { get; set; }
        #region Person_
        private List<Person> person_;
        public List<Person> Person_
        {
            get
            {
                if (this.person_ != null)
                {
                    return this.person_; 
                }
                else if (this.personIDRef_ != null)
                {
                    return this.person_; 
                }
                else
                {
                      return this.person_; 
                }
            }
            set
            {
                if (this.person_ != value)
                {
                    this.person_ = value;
                }
            }
        }
        #endregion
        
        public string personIDRef_ { get; set; }
        
    
        
    
    }
    
}

