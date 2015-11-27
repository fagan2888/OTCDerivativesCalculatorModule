// BusinessUnit.hpp 
#ifndef FpmlSerialized_BusinessUnit_hpp
#define FpmlSerialized_BusinessUnit_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/Unit.hpp>
#include <fpml-shared-5-4/ContactInformation.hpp>
#include <fpml-shared-5-4/CountryCode.hpp>

namespace FpmlSerialized {

class BusinessUnit : public ISerialized { 
   public: 
       BusinessUnit(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isBusinessUnitId(){return this->businessUnitIdIsNull_;}
       boost::shared_ptr<Unit> getBusinessUnitId();
      std::string getBusinessUnitIdIDRef(){return businessUnitIdIDRef_;}

       bool isContactInfo(){return this->contactInfoIsNull_;}
       boost::shared_ptr<ContactInformation> getContactInfo();
      std::string getContactInfoIDRef(){return contactInfoIDRef_;}

       bool isCountry(){return this->countryIsNull_;}
       boost::shared_ptr<CountryCode> getCountry();
      std::string getCountryIDRef(){return countryIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<Unit> businessUnitId_;
       std::string businessUnitIdIDRef_;
       bool businessUnitIdIsNull_;
       boost::shared_ptr<ContactInformation> contactInfo_;
       std::string contactInfoIDRef_;
       bool contactInfoIsNull_;
       boost::shared_ptr<CountryCode> country_;
       std::string countryIDRef_;
       bool countryIsNull_;

};

} //namespaceFpmlSerialized end
#endif

