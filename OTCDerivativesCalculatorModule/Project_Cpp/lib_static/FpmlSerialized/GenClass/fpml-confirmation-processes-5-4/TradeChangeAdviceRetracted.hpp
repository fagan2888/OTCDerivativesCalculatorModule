// TradeChangeAdviceRetracted.hpp 
#ifndef FpmlSerialized_TradeChangeAdviceRetracted_hpp
#define FpmlSerialized_TradeChangeAdviceRetracted_hpp

#include <fpml-msg-5-4/NonCorrectableRequestMessage.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <fpml-business-events-5-4/TradeChangeContent.hpp>
#include <fpml-shared-5-4/PaymentDetails.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class TradeChangeAdviceRetracted : public NonCorrectableRequestMessage { 
   public: 
       TradeChangeAdviceRetracted(TiXmlNode* xmlNode);

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isChange(){return this->changeIsNull_;}
       boost::shared_ptr<TradeChangeContent> getChange();
      std::string getChangeIDRef(){return changeIDRef_;}

       bool isPaymentDetails(){return this->paymentDetailsIsNull_;}
       std::vector<boost::shared_ptr<PaymentDetails>> getPaymentDetails();
      std::string getPaymentDetailsIDRef(){return paymentDetailsIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> tradeIdentifier_;
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
       boost::shared_ptr<TradeChangeContent> change_;
       std::string changeIDRef_;
       bool changeIsNull_;
       std::vector<boost::shared_ptr<PaymentDetails>> paymentDetails_;
       std::string paymentDetailsIDRef_;
       bool paymentDetailsIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

