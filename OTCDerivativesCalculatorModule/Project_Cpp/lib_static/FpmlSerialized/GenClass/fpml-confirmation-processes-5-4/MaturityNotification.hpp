// MaturityNotification.hpp 
#ifndef FpmlSerialized_MaturityNotification_hpp
#define FpmlSerialized_MaturityNotification_hpp

#include <fpml-msg-5-4/CorrectableRequestMessage.hpp>
#include <fpml-business-events-5-4/OptionExpiryBase.hpp>
#include <fpml-business-events-5-4/TradeMaturity.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class MaturityNotification : public CorrectableRequestMessage { 
   public: 
       MaturityNotification(TiXmlNode* xmlNode);

       bool isOptionExpiry(){return this->optionExpiryIsNull_;}
       boost::shared_ptr<OptionExpiryBase> getOptionExpiry();
      std::string getOptionExpiryIDRef(){return optionExpiryIDRef_;}

       bool isTradeMaturity(){return this->tradeMaturityIsNull_;}
       boost::shared_ptr<TradeMaturity> getTradeMaturity();
      std::string getTradeMaturityIDRef(){return tradeMaturityIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!optionExpiryIsNull_){
                count += 1;
                str = "optionExpiry" ;
           }
           if(!tradeMaturityIsNull_){
                count += 1;
                str = "tradeMaturity" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<OptionExpiryBase> optionExpiry_;     //choice
       std::string optionExpiryIDRef_;
       bool optionExpiryIsNull_;
         boost::shared_ptr<TradeMaturity> tradeMaturity_;     //choice
       std::string tradeMaturityIDRef_;
       bool tradeMaturityIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

