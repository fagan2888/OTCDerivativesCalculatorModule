// EventRequestAcknowledgement.hpp 
#ifndef FpmlSerialized_EventRequestAcknowledgement_hpp
#define FpmlSerialized_EventRequestAcknowledgement_hpp

#include <fpml-msg-5-4/ResponseMessage.hpp>
#include <fpml-msg-5-4/UnprocessedElementWrapper.hpp>
#include <fpml-business-events-5-4/TradeReferenceInformation.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class EventRequestAcknowledgement : public ResponseMessage { 
   public: 
       EventRequestAcknowledgement(TiXmlNode* xmlNode);

       bool isOriginalMessage(){return this->originalMessageIsNull_;}
       boost::shared_ptr<UnprocessedElementWrapper> getOriginalMessage();
      std::string getOriginalMessageIDRef(){return originalMessageIDRef_;}

       bool isTradeReferenceInformation(){return this->tradeReferenceInformationIsNull_;}
       boost::shared_ptr<TradeReferenceInformation> getTradeReferenceInformation();
      std::string getTradeReferenceInformationIDRef(){return tradeReferenceInformationIDRef_;}

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
       boost::shared_ptr<TradeReferenceInformation> tradeReferenceInformation_;
       std::string tradeReferenceInformationIDRef_;
       bool tradeReferenceInformationIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

