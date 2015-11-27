// GrossCashflow.hpp 
#ifndef FpmlSerialized_GrossCashflow_hpp
#define FpmlSerialized_GrossCashflow_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/CashflowId.hpp>
#include <fpml-shared-5-4/PartyTradeIdentifierReference.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-shared-5-4/CashflowType.hpp>

namespace FpmlSerialized {

class GrossCashflow : public ISerialized { 
   public: 
       GrossCashflow(TiXmlNode* xmlNode);

       bool isCashflowId(){return this->cashflowIdIsNull_;}
       boost::shared_ptr<CashflowId> getCashflowId();
      std::string getCashflowIdIDRef(){return cashflowIdIDRef_;}

       bool isPartyTradeIdentifierReference(){return this->partyTradeIdentifierReferenceIsNull_;}
       boost::shared_ptr<PartyTradeIdentifierReference> getPartyTradeIdentifierReference();
      std::string getPartyTradeIdentifierReferenceIDRef(){return partyTradeIdentifierReferenceIDRef_;}

       bool isPayerPartyReference(){return this->payerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPayerPartyReference();
      std::string getPayerPartyReferenceIDRef(){return payerPartyReferenceIDRef_;}

       bool isPayerAccountReference(){return this->payerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getPayerAccountReference();
      std::string getPayerAccountReferenceIDRef(){return payerAccountReferenceIDRef_;}

       bool isReceiverPartyReference(){return this->receiverPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getReceiverPartyReference();
      std::string getReceiverPartyReferenceIDRef(){return receiverPartyReferenceIDRef_;}

       bool isReceiverAccountReference(){return this->receiverAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getReceiverAccountReference();
      std::string getReceiverAccountReferenceIDRef(){return receiverAccountReferenceIDRef_;}

       bool isCashflowAmount(){return this->cashflowAmountIsNull_;}
       boost::shared_ptr<Money> getCashflowAmount();
      std::string getCashflowAmountIDRef(){return cashflowAmountIDRef_;}

       bool isCashflowType(){return this->cashflowTypeIsNull_;}
       boost::shared_ptr<CashflowType> getCashflowType();
      std::string getCashflowTypeIDRef(){return cashflowTypeIDRef_;}

   protected: 
       boost::shared_ptr<CashflowId> cashflowId_;
       std::string cashflowIdIDRef_;
       bool cashflowIdIsNull_;
       boost::shared_ptr<PartyTradeIdentifierReference> partyTradeIdentifierReference_;
       std::string partyTradeIdentifierReferenceIDRef_;
       bool partyTradeIdentifierReferenceIsNull_;
       boost::shared_ptr<PartyReference> payerPartyReference_;
       std::string payerPartyReferenceIDRef_;
       bool payerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> payerAccountReference_;
       std::string payerAccountReferenceIDRef_;
       bool payerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> receiverPartyReference_;
       std::string receiverPartyReferenceIDRef_;
       bool receiverPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> receiverAccountReference_;
       std::string receiverAccountReferenceIDRef_;
       bool receiverAccountReferenceIsNull_;
       boost::shared_ptr<Money> cashflowAmount_;
       std::string cashflowAmountIDRef_;
       bool cashflowAmountIsNull_;
       boost::shared_ptr<CashflowType> cashflowType_;
       std::string cashflowTypeIDRef_;
       bool cashflowTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

