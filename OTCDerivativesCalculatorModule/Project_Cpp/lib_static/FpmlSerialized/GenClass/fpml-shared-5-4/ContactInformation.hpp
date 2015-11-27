// ContactInformation.hpp 
#ifndef FpmlSerialized_ContactInformation_hpp
#define FpmlSerialized_ContactInformation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/TelephoneNumber.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <fpml-shared-5-4/Address.hpp>

namespace FpmlSerialized {

class ContactInformation : public ISerialized { 
   public: 
       ContactInformation(TiXmlNode* xmlNode);

       bool isTelephone(){return this->telephoneIsNull_;}
       std::vector<boost::shared_ptr<TelephoneNumber>> getTelephone();
      std::string getTelephoneIDRef(){return telephoneIDRef_;}

       bool isEmail(){return this->emailIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeNormalizedString>> getEmail();
      std::string getEmailIDRef(){return emailIDRef_;}

       bool isAddress(){return this->addressIsNull_;}
       boost::shared_ptr<Address> getAddress();
      std::string getAddressIDRef(){return addressIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<TelephoneNumber>> telephone_;
       std::string telephoneIDRef_;
       bool telephoneIsNull_;
       std::vector<boost::shared_ptr<XsdTypeNormalizedString>> email_;
       std::string emailIDRef_;
       bool emailIsNull_;
       boost::shared_ptr<Address> address_;
       std::string addressIDRef_;
       bool addressIsNull_;

};

} //namespaceFpmlSerialized end
#endif

