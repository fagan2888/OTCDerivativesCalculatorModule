// Address.hpp 
#ifndef FpmlSerialized_Address_hpp
#define FpmlSerialized_Address_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/StreetAddress.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/CountryCode.hpp>

namespace FpmlSerialized {

class Address : public ISerialized { 
   public: 
       Address(TiXmlNode* xmlNode);

       bool isStreetAddress(){return this->streetAddressIsNull_;}
       boost::shared_ptr<StreetAddress> getStreetAddress();
      std::string getStreetAddressIDRef(){return streetAddressIDRef_;}

       bool isCity(){return this->cityIsNull_;}
       boost::shared_ptr<XsdTypeString> getCity();
      std::string getCityIDRef(){return cityIDRef_;}

       bool isState(){return this->stateIsNull_;}
       boost::shared_ptr<XsdTypeString> getState();
      std::string getStateIDRef(){return stateIDRef_;}

       bool isCountry(){return this->countryIsNull_;}
       boost::shared_ptr<CountryCode> getCountry();
      std::string getCountryIDRef(){return countryIDRef_;}

       bool isPostalCode(){return this->postalCodeIsNull_;}
       boost::shared_ptr<XsdTypeString> getPostalCode();
      std::string getPostalCodeIDRef(){return postalCodeIDRef_;}

   protected: 
       boost::shared_ptr<StreetAddress> streetAddress_;
       std::string streetAddressIDRef_;
       bool streetAddressIsNull_;
       boost::shared_ptr<XsdTypeString> city_;
       std::string cityIDRef_;
       bool cityIsNull_;
       boost::shared_ptr<XsdTypeString> state_;
       std::string stateIDRef_;
       bool stateIsNull_;
       boost::shared_ptr<CountryCode> country_;
       std::string countryIDRef_;
       bool countryIsNull_;
       boost::shared_ptr<XsdTypeString> postalCode_;
       std::string postalCodeIDRef_;
       bool postalCodeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

