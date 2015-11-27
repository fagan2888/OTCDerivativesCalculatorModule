// CreditSupportAgreement.hpp 
#ifndef FpmlSerialized_CreditSupportAgreement_hpp
#define FpmlSerialized_CreditSupportAgreement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/CreditSupportAgreementType.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/CreditSupportAgreementIdentifier.hpp>

namespace FpmlSerialized {

class CreditSupportAgreement : public ISerialized { 
   public: 
       CreditSupportAgreement(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<CreditSupportAgreementType> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

       bool isIdentifier(){return this->identifierIsNull_;}
       boost::shared_ptr<CreditSupportAgreementIdentifier> getIdentifier();
      std::string getIdentifierIDRef(){return identifierIDRef_;}

   protected: 
       boost::shared_ptr<CreditSupportAgreementType> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeDate> date_;
       std::string dateIDRef_;
       bool dateIsNull_;
       boost::shared_ptr<CreditSupportAgreementIdentifier> identifier_;
       std::string identifierIDRef_;
       bool identifierIsNull_;

};

} //namespaceFpmlSerialized end
#endif

