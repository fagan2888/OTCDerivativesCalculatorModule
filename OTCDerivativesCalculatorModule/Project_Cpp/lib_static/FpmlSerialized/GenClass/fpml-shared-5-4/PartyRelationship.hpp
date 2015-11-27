// PartyRelationship.hpp 
#ifndef FpmlSerialized_PartyRelationship_hpp
#define FpmlSerialized_PartyRelationship_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/PartyRole.hpp>
#include <fpml-shared-5-4/PartyRoleType.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/PartyRelationshipDocumentation.hpp>

namespace FpmlSerialized {

class PartyRelationship : public ISerialized { 
   public: 
       PartyRelationship(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isAccountReference(){return this->accountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getAccountReference();
      std::string getAccountReferenceIDRef(){return accountReferenceIDRef_;}

       bool isRole(){return this->roleIsNull_;}
       boost::shared_ptr<PartyRole> getRole();
      std::string getRoleIDRef(){return roleIDRef_;}

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<PartyRoleType> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isTerminationDate(){return this->terminationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getTerminationDate();
      std::string getTerminationDateIDRef(){return terminationDateIDRef_;}

       bool isDocumentation(){return this->documentationIsNull_;}
       boost::shared_ptr<PartyRelationshipDocumentation> getDocumentation();
      std::string getDocumentationIDRef(){return documentationIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       boost::shared_ptr<AccountReference> accountReference_;
       std::string accountReferenceIDRef_;
       bool accountReferenceIsNull_;
       boost::shared_ptr<PartyRole> role_;
       std::string roleIDRef_;
       bool roleIsNull_;
       boost::shared_ptr<PartyRoleType> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<XsdTypeDate> terminationDate_;
       std::string terminationDateIDRef_;
       bool terminationDateIsNull_;
       boost::shared_ptr<PartyRelationshipDocumentation> documentation_;
       std::string documentationIDRef_;
       bool documentationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

