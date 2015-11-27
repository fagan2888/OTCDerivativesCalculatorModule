// TradeIdentifier.hpp 
#ifndef FpmlSerialized_TradeIdentifier_hpp
#define FpmlSerialized_TradeIdentifier_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/IssuerId.hpp>
#include <fpml-doc-5-4/TradeId.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-doc-5-4/VersionedTradeId.hpp>

namespace FpmlSerialized {

class TradeIdentifier : public ISerialized { 
   public: 
       TradeIdentifier(TiXmlNode* xmlNode);

       bool isIssuer(){return this->issuerIsNull_;}
       boost::shared_ptr<IssuerId> getIssuer();
      std::string getIssuerIDRef(){return issuerIDRef_;}

       bool isTradeId(){return this->tradeIdIsNull_;}
       boost::shared_ptr<TradeId> getTradeId();
      std::string getTradeIdIDRef(){return tradeIdIDRef_;}

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isAccountReference(){return this->accountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getAccountReference();
      std::string getAccountReferenceIDRef(){return accountReferenceIDRef_;}

       bool isVersionedTradeId(){return this->versionedTradeIdIsNull_;}
       boost::shared_ptr<VersionedTradeId> getVersionedTradeId();
      std::string getVersionedTradeIdIDRef(){return versionedTradeIdIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!issuerIsNull_){
                count += 1;
                str = "issuer" ;
           }
           if(!tradeIdIsNull_){
                count += 1;
                str = "tradeId" ;
           }
           if(!partyReferenceIsNull_){
                count += 1;
                str = "partyReference" ;
           }
           if(!accountReferenceIsNull_){
                count += 1;
                str = "accountReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!tradeIdIsNull_){
                count += 1;
                str = "tradeId" ;
           }
           if(!versionedTradeIdIsNull_){
                count += 1;
                str = "versionedTradeId" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<IssuerId> issuer_;     //choice
       std::string issuerIDRef_;
       bool issuerIsNull_;
         boost::shared_ptr<TradeId> tradeId_;     //choice
       std::string tradeIdIDRef_;
       bool tradeIdIsNull_;
         boost::shared_ptr<PartyReference> partyReference_;     //choice
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
         boost::shared_ptr<AccountReference> accountReference_;     //choice
       std::string accountReferenceIDRef_;
       bool accountReferenceIsNull_;
         boost::shared_ptr<VersionedTradeId> versionedTradeId_;     //choice
       std::string versionedTradeIdIDRef_;
       bool versionedTradeIdIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

