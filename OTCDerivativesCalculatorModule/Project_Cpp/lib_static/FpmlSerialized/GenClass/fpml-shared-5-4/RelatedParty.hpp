// RelatedParty.hpp 
#ifndef FpmlSerialized_RelatedParty_hpp
#define FpmlSerialized_RelatedParty_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/PartyRole.hpp>
#include <fpml-shared-5-4/PartyRoleType.hpp>

namespace FpmlSerialized {

class RelatedParty : public ISerialized { 
   public: 
       RelatedParty(TiXmlNode* xmlNode);

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

};

} //namespaceFpmlSerialized end
#endif

