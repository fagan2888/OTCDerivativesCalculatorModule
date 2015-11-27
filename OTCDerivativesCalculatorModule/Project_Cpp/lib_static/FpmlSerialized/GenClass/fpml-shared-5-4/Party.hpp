// Party.hpp 
#ifndef FpmlSerialized_Party_hpp
#define FpmlSerialized_Party_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyId.hpp>
#include <fpml-shared-5-4/PartyName.hpp>
#include <fpml-shared-5-4/IndustryClassification.hpp>
#include <fpml-shared-5-4/CreditRating.hpp>
#include <fpml-shared-5-4/CountryCode.hpp>
#include <fpml-shared-5-4/GoverningLaw.hpp>
#include <fpml-shared-5-4/OrganizationType.hpp>
#include <fpml-shared-5-4/ContactInformation.hpp>
#include <fpml-shared-5-4/BusinessUnit.hpp>
#include <fpml-shared-5-4/Person.hpp>

namespace FpmlSerialized {

class Party : public ISerialized { 
   public: 
       Party(TiXmlNode* xmlNode);

       bool isPartyId(){return this->partyIdIsNull_;}
       std::vector<boost::shared_ptr<PartyId>> getPartyId();
      std::string getPartyIdIDRef(){return partyIdIDRef_;}

       bool isPartyName(){return this->partyNameIsNull_;}
       boost::shared_ptr<PartyName> getPartyName();
      std::string getPartyNameIDRef(){return partyNameIDRef_;}

       bool isClassification(){return this->classificationIsNull_;}
       std::vector<boost::shared_ptr<IndustryClassification>> getClassification();
      std::string getClassificationIDRef(){return classificationIDRef_;}

       bool isCreditRating(){return this->creditRatingIsNull_;}
       std::vector<boost::shared_ptr<CreditRating>> getCreditRating();
      std::string getCreditRatingIDRef(){return creditRatingIDRef_;}

       bool isCountry(){return this->countryIsNull_;}
       boost::shared_ptr<CountryCode> getCountry();
      std::string getCountryIDRef(){return countryIDRef_;}

       bool isJurisdiction(){return this->jurisdictionIsNull_;}
       std::vector<boost::shared_ptr<GoverningLaw>> getJurisdiction();
      std::string getJurisdictionIDRef(){return jurisdictionIDRef_;}

       bool isOrganizationType(){return this->organizationTypeIsNull_;}
       boost::shared_ptr<OrganizationType> getOrganizationType();
      std::string getOrganizationTypeIDRef(){return organizationTypeIDRef_;}

       bool isContactInfo(){return this->contactInfoIsNull_;}
       boost::shared_ptr<ContactInformation> getContactInfo();
      std::string getContactInfoIDRef(){return contactInfoIDRef_;}

       bool isBusinessUnit(){return this->businessUnitIsNull_;}
       std::vector<boost::shared_ptr<BusinessUnit>> getBusinessUnit();
      std::string getBusinessUnitIDRef(){return businessUnitIDRef_;}

       bool isPerson(){return this->personIsNull_;}
       std::vector<boost::shared_ptr<Person>> getPerson();
      std::string getPersonIDRef(){return personIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyId>> partyId_;
       std::string partyIdIDRef_;
       bool partyIdIsNull_;
       boost::shared_ptr<PartyName> partyName_;
       std::string partyNameIDRef_;
       bool partyNameIsNull_;
       std::vector<boost::shared_ptr<IndustryClassification>> classification_;
       std::string classificationIDRef_;
       bool classificationIsNull_;
       std::vector<boost::shared_ptr<CreditRating>> creditRating_;
       std::string creditRatingIDRef_;
       bool creditRatingIsNull_;
       boost::shared_ptr<CountryCode> country_;
       std::string countryIDRef_;
       bool countryIsNull_;
       std::vector<boost::shared_ptr<GoverningLaw>> jurisdiction_;
       std::string jurisdictionIDRef_;
       bool jurisdictionIsNull_;
       boost::shared_ptr<OrganizationType> organizationType_;
       std::string organizationTypeIDRef_;
       bool organizationTypeIsNull_;
       boost::shared_ptr<ContactInformation> contactInfo_;
       std::string contactInfoIDRef_;
       bool contactInfoIsNull_;
       std::vector<boost::shared_ptr<BusinessUnit>> businessUnit_;
       std::string businessUnitIDRef_;
       bool businessUnitIsNull_;
       std::vector<boost::shared_ptr<Person>> person_;
       std::string personIDRef_;
       bool personIsNull_;

};

} //namespaceFpmlSerialized end
#endif

