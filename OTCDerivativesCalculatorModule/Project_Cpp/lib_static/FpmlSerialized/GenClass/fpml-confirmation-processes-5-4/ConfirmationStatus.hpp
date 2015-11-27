// ConfirmationStatus.hpp 
#ifndef FpmlSerialized_ConfirmationStatus_hpp
#define FpmlSerialized_ConfirmationStatus_hpp

#include <fpml-msg-5-4/ResponseMessage.hpp>
#include <fpml-msg-5-4/EventStatus.hpp>
#include <fpml-business-events-5-4/EventsChoice.hpp>
#include <fpml-business-events-5-4/EventProposedMatch.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class ConfirmationStatus : public ResponseMessage { 
   public: 
       ConfirmationStatus(TiXmlNode* xmlNode);

       bool isStatus(){return this->statusIsNull_;}
       boost::shared_ptr<EventStatus> getStatus();
      std::string getStatusIDRef(){return statusIDRef_;}

       bool isAssertedEvent(){return this->assertedEventIsNull_;}
       boost::shared_ptr<EventsChoice> getAssertedEvent();
      std::string getAssertedEventIDRef(){return assertedEventIDRef_;}

       bool isProposedMatch(){return this->proposedMatchIsNull_;}
       std::vector<boost::shared_ptr<EventProposedMatch>> getProposedMatch();
      std::string getProposedMatchIDRef(){return proposedMatchIDRef_;}

       bool isAllegedEvent(){return this->allegedEventIsNull_;}
       boost::shared_ptr<EventsChoice> getAllegedEvent();
      std::string getAllegedEventIDRef(){return allegedEventIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!assertedEventIsNull_){
                count += 1;
                str = "assertedEvent" ;
           }
           if(!proposedMatchIsNull_){
                count += 1;
                str = "proposedMatch" ;
           }
           if(!allegedEventIsNull_){
                count += 1;
                str = "allegedEvent" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<EventStatus> status_;
       std::string statusIDRef_;
       bool statusIsNull_;
         boost::shared_ptr<EventsChoice> assertedEvent_;     //choice
       std::string assertedEventIDRef_;
       bool assertedEventIsNull_;
         std::vector<boost::shared_ptr<EventProposedMatch>> proposedMatch_;     //choice
       std::string proposedMatchIDRef_;
       bool proposedMatchIsNull_;
         boost::shared_ptr<EventsChoice> allegedEvent_;     //choice
       std::string allegedEventIDRef_;
       bool allegedEventIsNull_;
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

