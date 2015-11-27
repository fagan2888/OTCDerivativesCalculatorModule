// Withdrawal.hpp 
#ifndef FpmlSerialized_Withdrawal_hpp
#define FpmlSerialized_Withdrawal_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-business-events-5-4/RequestedWithdrawalAction.hpp>
#include <fpml-business-events-5-4/WithdrawalReason.hpp>

namespace FpmlSerialized {

class Withdrawal : public ISerialized { 
   public: 
       Withdrawal(TiXmlNode* xmlNode);

       bool isPartyTradeIdentifier(){return this->partyTradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getPartyTradeIdentifier();
      std::string getPartyTradeIdentifierIDRef(){return partyTradeIdentifierIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isRequestedAction(){return this->requestedActionIsNull_;}
       boost::shared_ptr<RequestedWithdrawalAction> getRequestedAction();
      std::string getRequestedActionIDRef(){return requestedActionIDRef_;}

       bool isReason(){return this->reasonIsNull_;}
       std::vector<boost::shared_ptr<WithdrawalReason>> getReason();
      std::string getReasonIDRef(){return reasonIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> partyTradeIdentifier_;
       std::string partyTradeIdentifierIDRef_;
       bool partyTradeIdentifierIsNull_;
       boost::shared_ptr<XsdTypeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<RequestedWithdrawalAction> requestedAction_;
       std::string requestedActionIDRef_;
       bool requestedActionIsNull_;
       std::vector<boost::shared_ptr<WithdrawalReason>> reason_;
       std::string reasonIDRef_;
       bool reasonIsNull_;

};

} //namespaceFpmlSerialized end
#endif

