// TradeChangeContent.hpp 
#ifndef FpmlSerialized_TradeChangeContent_hpp
#define FpmlSerialized_TradeChangeContent_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-business-events-5-4/ChangeEvent.hpp>
#include <fpml-business-events-5-4/IndexChange.hpp>
#include <fpml-shared-5-4/Payment.hpp>

namespace FpmlSerialized {

class TradeChangeContent : public ISerialized { 
   public: 
       TradeChangeContent(TiXmlNode* xmlNode);

       bool isOldTradeIdentifier(){return this->oldTradeIdentifierIsNull_;}
       boost::shared_ptr<PartyTradeIdentifier> getOldTradeIdentifier();
      std::string getOldTradeIdentifierIDRef(){return oldTradeIdentifierIDRef_;}

       bool isOldTrade(){return this->oldTradeIsNull_;}
       boost::shared_ptr<Trade> getOldTrade();
      std::string getOldTradeIDRef(){return oldTradeIDRef_;}

       bool isTrade(){return this->tradeIsNull_;}
       boost::shared_ptr<Trade> getTrade();
      std::string getTradeIDRef(){return tradeIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isChangeEvent(){return this->changeEventIsNull_;}
       boost::shared_ptr<ChangeEvent> getChangeEvent();
      std::string getChangeEventIDRef(){return changeEventIDRef_;}

       bool isIndexChange(){return this->indexChangeIsNull_;}
       boost::shared_ptr<IndexChange> getIndexChange();
      std::string getIndexChangeIDRef(){return indexChangeIDRef_;}

       bool isPayment(){return this->paymentIsNull_;}
       boost::shared_ptr<Payment> getPayment();
      std::string getPaymentIDRef(){return paymentIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!oldTradeIdentifierIsNull_){
                count += 1;
                str = "oldTradeIdentifier" ;
           }
           if(!oldTradeIsNull_){
                count += 1;
                str = "oldTrade" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<PartyTradeIdentifier> oldTradeIdentifier_;     //choice
       std::string oldTradeIdentifierIDRef_;
       bool oldTradeIdentifierIsNull_;
         boost::shared_ptr<Trade> oldTrade_;     //choice
       std::string oldTradeIDRef_;
       bool oldTradeIsNull_;
       boost::shared_ptr<Trade> trade_;
       std::string tradeIDRef_;
       bool tradeIsNull_;
       boost::shared_ptr<XsdTypeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<ChangeEvent> changeEvent_;
       std::string changeEventIDRef_;
       bool changeEventIsNull_;
       boost::shared_ptr<IndexChange> indexChange_;     //substitude 
       std::string indexChangeIDRef_;
       bool indexChangeIsNull_;
       boost::shared_ptr<Payment> payment_;
       std::string paymentIDRef_;
       bool paymentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

