// Person.hpp 
#ifndef FpmlSerialized_Person_hpp
#define FpmlSerialized_Person_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <fpml-shared-5-4/Initial.hpp>
#include <fpml-shared-5-4/PersonId.hpp>
#include <fpml-shared-5-4/BusinessUnitReference.hpp>
#include <fpml-shared-5-4/ContactInformation.hpp>
#include <fpml-shared-5-4/CountryCode.hpp>

namespace FpmlSerialized {

class Person : public ISerialized { 
   public: 
       Person(TiXmlNode* xmlNode);

       bool isHonorific(){return this->honorificIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getHonorific();
      std::string getHonorificIDRef(){return honorificIDRef_;}

       bool isFirstName(){return this->firstNameIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getFirstName();
      std::string getFirstNameIDRef(){return firstNameIDRef_;}

       bool isMiddleName(){return this->middleNameIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeNormalizedString>> getMiddleName();
      std::string getMiddleNameIDRef(){return middleNameIDRef_;}

       bool isInitial(){return this->initialIsNull_;}
       std::vector<boost::shared_ptr<Initial>> getInitial();
      std::string getInitialIDRef(){return initialIDRef_;}

       bool isSurname(){return this->surnameIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getSurname();
      std::string getSurnameIDRef(){return surnameIDRef_;}

       bool isSuffix(){return this->suffixIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getSuffix();
      std::string getSuffixIDRef(){return suffixIDRef_;}

       bool isPersonId(){return this->personIdIsNull_;}
       std::vector<boost::shared_ptr<PersonId>> getPersonId();
      std::string getPersonIdIDRef(){return personIdIDRef_;}

       bool isBusinessUnitReference(){return this->businessUnitReferenceIsNull_;}
       boost::shared_ptr<BusinessUnitReference> getBusinessUnitReference();
      std::string getBusinessUnitReferenceIDRef(){return businessUnitReferenceIDRef_;}

       bool isContactInfo(){return this->contactInfoIsNull_;}
       boost::shared_ptr<ContactInformation> getContactInfo();
      std::string getContactInfoIDRef(){return contactInfoIDRef_;}

       bool isCountry(){return this->countryIsNull_;}
       boost::shared_ptr<CountryCode> getCountry();
      std::string getCountryIDRef(){return countryIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!middleNameIsNull_){
                count += 1;
                str = "middleName" ;
           }
           if(!initialIsNull_){
                count += 1;
                str = "initial" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeNormalizedString> honorific_;
       std::string honorificIDRef_;
       bool honorificIsNull_;
       boost::shared_ptr<XsdTypeNormalizedString> firstName_;
       std::string firstNameIDRef_;
       bool firstNameIsNull_;
         std::vector<boost::shared_ptr<XsdTypeNormalizedString>> middleName_;     //choice
       std::string middleNameIDRef_;
       bool middleNameIsNull_;
         std::vector<boost::shared_ptr<Initial>> initial_;     //choice
       std::string initialIDRef_;
       bool initialIsNull_;
       boost::shared_ptr<XsdTypeNormalizedString> surname_;
       std::string surnameIDRef_;
       bool surnameIsNull_;
       boost::shared_ptr<XsdTypeNormalizedString> suffix_;
       std::string suffixIDRef_;
       bool suffixIsNull_;
       std::vector<boost::shared_ptr<PersonId>> personId_;
       std::string personIdIDRef_;
       bool personIdIsNull_;
       boost::shared_ptr<BusinessUnitReference> businessUnitReference_;
       std::string businessUnitReferenceIDRef_;
       bool businessUnitReferenceIsNull_;
       boost::shared_ptr<ContactInformation> contactInfo_;
       std::string contactInfoIDRef_;
       bool contactInfoIsNull_;
       boost::shared_ptr<CountryCode> country_;
       std::string countryIDRef_;
       bool countryIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

