// OnBehalfOf.hpp 
#ifndef FpmlSerialized_OnBehalfOf_hpp
#define FpmlSerialized_OnBehalfOf_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>

namespace FpmlSerialized {

class OnBehalfOf : public ISerialized { 
   public: 
       OnBehalfOf(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isAccountReference(){return this->accountReferenceIsNull_;}
       std::vector<boost::shared_ptr<AccountReference>> getAccountReference();
      std::string getAccountReferenceIDRef(){return accountReferenceIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
       std::vector<boost::shared_ptr<AccountReference>> accountReference_;
       std::string accountReferenceIDRef_;
       bool accountReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

