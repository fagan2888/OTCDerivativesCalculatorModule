// Party.cpp 
#include "Party.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Party::Party(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partyIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyIdNode = xmlNode->FirstChildElement("partyId");

   if(partyIdNode){partyIdIsNull_ = false;}
   else{partyIdIsNull_ = true;}

   if(partyIdNode)
   {
      for(partyIdNode; partyIdNode; partyIdNode = partyIdNode->NextSiblingElement("partyId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyIdNode , address : " << partyIdNode << std::endl;
          #endif
          if(partyIdNode->Attribute("href") || partyIdNode->Attribute("id"))
          {
              if(partyIdNode->Attribute("id"))
              {
                  partyIdIDRef_ = partyIdNode->Attribute("id");
                  partyId_.push_back(boost::shared_ptr<PartyId>(new PartyId(partyIdNode)));
                  partyId_.back()->setID(partyIdIDRef_);
                  IDManager::instance().setID(partyIdIDRef_, partyId_.back());
              }
              else if(partyIdNode->Attribute("href")) { partyIdIDRef_ = partyIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partyId_.push_back(boost::shared_ptr<PartyId>(new PartyId(partyIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyIdNode , address : " << partyIdNode << std::endl;
       #endif
   }

   //partyNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyNameNode = xmlNode->FirstChildElement("partyName");

   if(partyNameNode){partyNameIsNull_ = false;}
   else{partyNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNameNode , address : " << partyNameNode << std::endl;
   #endif
   if(partyNameNode)
   {
      if(partyNameNode->Attribute("href") || partyNameNode->Attribute("id"))
      {
          if(partyNameNode->Attribute("id"))
          {
             partyNameIDRef_ = partyNameNode->Attribute("id");
             partyName_ = boost::shared_ptr<PartyName>(new PartyName(partyNameNode));
             partyName_->setID(partyNameIDRef_);
             IDManager::instance().setID(partyNameIDRef_,partyName_);
          }
          else if(partyNameNode->Attribute("href")) { partyNameIDRef_ = partyNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyName_ = boost::shared_ptr<PartyName>(new PartyName(partyNameNode));}
   }

   //classificationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* classificationNode = xmlNode->FirstChildElement("classification");

   if(classificationNode){classificationIsNull_ = false;}
   else{classificationIsNull_ = true;}

   if(classificationNode)
   {
      for(classificationNode; classificationNode; classificationNode = classificationNode->NextSiblingElement("classification")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- classificationNode , address : " << classificationNode << std::endl;
          #endif
          if(classificationNode->Attribute("href") || classificationNode->Attribute("id"))
          {
              if(classificationNode->Attribute("id"))
              {
                  classificationIDRef_ = classificationNode->Attribute("id");
                  classification_.push_back(boost::shared_ptr<IndustryClassification>(new IndustryClassification(classificationNode)));
                  classification_.back()->setID(classificationIDRef_);
                  IDManager::instance().setID(classificationIDRef_, classification_.back());
              }
              else if(classificationNode->Attribute("href")) { classificationIDRef_ = classificationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { classification_.push_back(boost::shared_ptr<IndustryClassification>(new IndustryClassification(classificationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- classificationNode , address : " << classificationNode << std::endl;
       #endif
   }

   //creditRatingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditRatingNode = xmlNode->FirstChildElement("creditRating");

   if(creditRatingNode){creditRatingIsNull_ = false;}
   else{creditRatingIsNull_ = true;}

   if(creditRatingNode)
   {
      for(creditRatingNode; creditRatingNode; creditRatingNode = creditRatingNode->NextSiblingElement("creditRating")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditRatingNode , address : " << creditRatingNode << std::endl;
          #endif
          if(creditRatingNode->Attribute("href") || creditRatingNode->Attribute("id"))
          {
              if(creditRatingNode->Attribute("id"))
              {
                  creditRatingIDRef_ = creditRatingNode->Attribute("id");
                  creditRating_.push_back(boost::shared_ptr<CreditRating>(new CreditRating(creditRatingNode)));
                  creditRating_.back()->setID(creditRatingIDRef_);
                  IDManager::instance().setID(creditRatingIDRef_, creditRating_.back());
              }
              else if(creditRatingNode->Attribute("href")) { creditRatingIDRef_ = creditRatingNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { creditRating_.push_back(boost::shared_ptr<CreditRating>(new CreditRating(creditRatingNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditRatingNode , address : " << creditRatingNode << std::endl;
       #endif
   }

   //countryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* countryNode = xmlNode->FirstChildElement("country");

   if(countryNode){countryIsNull_ = false;}
   else{countryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- countryNode , address : " << countryNode << std::endl;
   #endif
   if(countryNode)
   {
      if(countryNode->Attribute("href") || countryNode->Attribute("id"))
      {
          if(countryNode->Attribute("id"))
          {
             countryIDRef_ = countryNode->Attribute("id");
             country_ = boost::shared_ptr<CountryCode>(new CountryCode(countryNode));
             country_->setID(countryIDRef_);
             IDManager::instance().setID(countryIDRef_,country_);
          }
          else if(countryNode->Attribute("href")) { countryIDRef_ = countryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { country_ = boost::shared_ptr<CountryCode>(new CountryCode(countryNode));}
   }

   //jurisdictionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jurisdictionNode = xmlNode->FirstChildElement("jurisdiction");

   if(jurisdictionNode){jurisdictionIsNull_ = false;}
   else{jurisdictionIsNull_ = true;}

   if(jurisdictionNode)
   {
      for(jurisdictionNode; jurisdictionNode; jurisdictionNode = jurisdictionNode->NextSiblingElement("jurisdiction")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jurisdictionNode , address : " << jurisdictionNode << std::endl;
          #endif
          if(jurisdictionNode->Attribute("href") || jurisdictionNode->Attribute("id"))
          {
              if(jurisdictionNode->Attribute("id"))
              {
                  jurisdictionIDRef_ = jurisdictionNode->Attribute("id");
                  jurisdiction_.push_back(boost::shared_ptr<GoverningLaw>(new GoverningLaw(jurisdictionNode)));
                  jurisdiction_.back()->setID(jurisdictionIDRef_);
                  IDManager::instance().setID(jurisdictionIDRef_, jurisdiction_.back());
              }
              else if(jurisdictionNode->Attribute("href")) { jurisdictionIDRef_ = jurisdictionNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { jurisdiction_.push_back(boost::shared_ptr<GoverningLaw>(new GoverningLaw(jurisdictionNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jurisdictionNode , address : " << jurisdictionNode << std::endl;
       #endif
   }

   //organizationTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* organizationTypeNode = xmlNode->FirstChildElement("organizationType");

   if(organizationTypeNode){organizationTypeIsNull_ = false;}
   else{organizationTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- organizationTypeNode , address : " << organizationTypeNode << std::endl;
   #endif
   if(organizationTypeNode)
   {
      if(organizationTypeNode->Attribute("href") || organizationTypeNode->Attribute("id"))
      {
          if(organizationTypeNode->Attribute("id"))
          {
             organizationTypeIDRef_ = organizationTypeNode->Attribute("id");
             organizationType_ = boost::shared_ptr<OrganizationType>(new OrganizationType(organizationTypeNode));
             organizationType_->setID(organizationTypeIDRef_);
             IDManager::instance().setID(organizationTypeIDRef_,organizationType_);
          }
          else if(organizationTypeNode->Attribute("href")) { organizationTypeIDRef_ = organizationTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { organizationType_ = boost::shared_ptr<OrganizationType>(new OrganizationType(organizationTypeNode));}
   }

   //contactInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contactInfoNode = xmlNode->FirstChildElement("contactInfo");

   if(contactInfoNode){contactInfoIsNull_ = false;}
   else{contactInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contactInfoNode , address : " << contactInfoNode << std::endl;
   #endif
   if(contactInfoNode)
   {
      if(contactInfoNode->Attribute("href") || contactInfoNode->Attribute("id"))
      {
          if(contactInfoNode->Attribute("id"))
          {
             contactInfoIDRef_ = contactInfoNode->Attribute("id");
             contactInfo_ = boost::shared_ptr<ContactInformation>(new ContactInformation(contactInfoNode));
             contactInfo_->setID(contactInfoIDRef_);
             IDManager::instance().setID(contactInfoIDRef_,contactInfo_);
          }
          else if(contactInfoNode->Attribute("href")) { contactInfoIDRef_ = contactInfoNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { contactInfo_ = boost::shared_ptr<ContactInformation>(new ContactInformation(contactInfoNode));}
   }

   //businessUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessUnitNode = xmlNode->FirstChildElement("businessUnit");

   if(businessUnitNode){businessUnitIsNull_ = false;}
   else{businessUnitIsNull_ = true;}

   if(businessUnitNode)
   {
      for(businessUnitNode; businessUnitNode; businessUnitNode = businessUnitNode->NextSiblingElement("businessUnit")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessUnitNode , address : " << businessUnitNode << std::endl;
          #endif
          if(businessUnitNode->Attribute("href") || businessUnitNode->Attribute("id"))
          {
              if(businessUnitNode->Attribute("id"))
              {
                  businessUnitIDRef_ = businessUnitNode->Attribute("id");
                  businessUnit_.push_back(boost::shared_ptr<BusinessUnit>(new BusinessUnit(businessUnitNode)));
                  businessUnit_.back()->setID(businessUnitIDRef_);
                  IDManager::instance().setID(businessUnitIDRef_, businessUnit_.back());
              }
              else if(businessUnitNode->Attribute("href")) { businessUnitIDRef_ = businessUnitNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { businessUnit_.push_back(boost::shared_ptr<BusinessUnit>(new BusinessUnit(businessUnitNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessUnitNode , address : " << businessUnitNode << std::endl;
       #endif
   }

   //personNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* personNode = xmlNode->FirstChildElement("person");

   if(personNode){personIsNull_ = false;}
   else{personIsNull_ = true;}

   if(personNode)
   {
      for(personNode; personNode; personNode = personNode->NextSiblingElement("person")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- personNode , address : " << personNode << std::endl;
          #endif
          if(personNode->Attribute("href") || personNode->Attribute("id"))
          {
              if(personNode->Attribute("id"))
              {
                  personIDRef_ = personNode->Attribute("id");
                  person_.push_back(boost::shared_ptr<Person>(new Person(personNode)));
                  person_.back()->setID(personIDRef_);
                  IDManager::instance().setID(personIDRef_, person_.back());
              }
              else if(personNode->Attribute("href")) { personIDRef_ = personNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { person_.push_back(boost::shared_ptr<Person>(new Person(personNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- personNode , address : " << personNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyId>> Party::getPartyId()
{
   if(!this->partyIdIsNull_){
        if(partyIdIDRef_ != ""){
             return this->partyId_;
        }else{
             return this->partyId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyId>>();
   }
}
boost::shared_ptr<PartyName> Party::getPartyName()
{
   if(!this->partyNameIsNull_){
        if(partyNameIDRef_ != ""){
             return boost::shared_static_cast<PartyName>(IDManager::instance().getID(partyNameIDRef_));
        }else{
             return this->partyName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyName>();
   }
}
std::vector<boost::shared_ptr<IndustryClassification>> Party::getClassification()
{
   if(!this->classificationIsNull_){
        if(classificationIDRef_ != ""){
             return this->classification_;
        }else{
             return this->classification_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<IndustryClassification>>();
   }
}
std::vector<boost::shared_ptr<CreditRating>> Party::getCreditRating()
{
   if(!this->creditRatingIsNull_){
        if(creditRatingIDRef_ != ""){
             return this->creditRating_;
        }else{
             return this->creditRating_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CreditRating>>();
   }
}
boost::shared_ptr<CountryCode> Party::getCountry()
{
   if(!this->countryIsNull_){
        if(countryIDRef_ != ""){
             return boost::shared_static_cast<CountryCode>(IDManager::instance().getID(countryIDRef_));
        }else{
             return this->country_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountryCode>();
   }
}
std::vector<boost::shared_ptr<GoverningLaw>> Party::getJurisdiction()
{
   if(!this->jurisdictionIsNull_){
        if(jurisdictionIDRef_ != ""){
             return this->jurisdiction_;
        }else{
             return this->jurisdiction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<GoverningLaw>>();
   }
}
boost::shared_ptr<OrganizationType> Party::getOrganizationType()
{
   if(!this->organizationTypeIsNull_){
        if(organizationTypeIDRef_ != ""){
             return boost::shared_static_cast<OrganizationType>(IDManager::instance().getID(organizationTypeIDRef_));
        }else{
             return this->organizationType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OrganizationType>();
   }
}
boost::shared_ptr<ContactInformation> Party::getContactInfo()
{
   if(!this->contactInfoIsNull_){
        if(contactInfoIDRef_ != ""){
             return boost::shared_static_cast<ContactInformation>(IDManager::instance().getID(contactInfoIDRef_));
        }else{
             return this->contactInfo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ContactInformation>();
   }
}
std::vector<boost::shared_ptr<BusinessUnit>> Party::getBusinessUnit()
{
   if(!this->businessUnitIsNull_){
        if(businessUnitIDRef_ != ""){
             return this->businessUnit_;
        }else{
             return this->businessUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BusinessUnit>>();
   }
}
std::vector<boost::shared_ptr<Person>> Party::getPerson()
{
   if(!this->personIsNull_){
        if(personIDRef_ != ""){
             return this->person_;
        }else{
             return this->person_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Person>>();
   }
}
}

