// TradeChangeAdvice.hpp 
#ifndef FpmlSerialized_TradeChangeAdvice_hpp
#define FpmlSerialized_TradeChangeAdvice_hpp

#include <fpml-msg-5-4/CorrectableRequestMessage.hpp>
#include <fpml-business-events-5-4/TradeChangeContent.hpp>
#include <fpml-asset-5-4/BasicQuotation.hpp>
#include <fpml-shared-5-4/PaymentDetails.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class TradeChangeAdvice : public CorrectableRequestMessage { 
   public: 
       TradeChangeAdvice(TiXmlNode* xmlNode);

       bool isChange(){return this->changeIsNull_;}
       boost::shared_ptr<TradeChangeContent> getChange();
      std::string getChangeIDRef(){return changeIDRef_;}

       bool isQuote(){return this->quoteIsNull_;}
       std::vector<boost::shared_ptr<BasicQuotation>> getQuote();
      std::string getQuoteIDRef(){return quoteIDRef_;}

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
       boost::shared_ptr<TradeChangeContent> change_;
       std::string changeIDRef_;
       bool changeIsNull_;
       std::vector<boost::shared_ptr<BasicQuotation>> quote_;
       std::string quoteIDRef_;
       bool quoteIsNull_;
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

