// Acknowledgement.hpp 
#ifndef FpmlSerialized_Acknowledgement_hpp
#define FpmlSerialized_Acknowledgement_hpp

#include <fpml-msg-5-4/ResponseMessage.hpp>
#include <fpml-msg-5-4/UnprocessedElementWrapper.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class Acknowledgement : public ResponseMessage { 
   public: 
       Acknowledgement(TiXmlNode* xmlNode);

       bool isOriginalMessage(){return this->originalMessageIsNull_;}
       boost::shared_ptr<UnprocessedElementWrapper> getOriginalMessage();
      std::string getOriginalMessageIDRef(){return originalMessageIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       boost::shared_ptr<UnprocessedElementWrapper> originalMessage_;
       std::string originalMessageIDRef_;
       bool originalMessageIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

