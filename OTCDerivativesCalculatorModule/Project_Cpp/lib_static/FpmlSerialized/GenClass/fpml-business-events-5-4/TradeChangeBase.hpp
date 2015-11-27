// TradeChangeBase.hpp 
#ifndef FpmlSerialized_TradeChangeBase_hpp
#define FpmlSerialized_TradeChangeBase_hpp

#include <fpml-business-events-5-4/AbstractEvent.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-doc-5-4/ExecutionDateTime.hpp>
#include <fpml-shared-5-4/Payment.hpp>

namespace FpmlSerialized {

class TradeChangeBase : public AbstractEvent { 
   public: 
       TradeChangeBase(TiXmlNode* xmlNode);

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isOriginalTrade(){return this->originalTradeIsNull_;}
       boost::shared_ptr<Trade> getOriginalTrade();
      std::string getOriginalTradeIDRef(){return originalTradeIDRef_;}

       bool isAgreementDate(){return this->agreementDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAgreementDate();
      std::string getAgreementDateIDRef(){return agreementDateIDRef_;}

       bool isExecutionDateTime(){return this->executionDateTimeIsNull_;}
       boost::shared_ptr<ExecutionDateTime> getExecutionDateTime();
      std::string getExecutionDateTimeIDRef(){return executionDateTimeIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isPayment(){return this->paymentIsNull_;}
       std::vector<boost::shared_ptr<Payment>> getPayment();
      std::string getPaymentIDRef(){return paymentIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!tradeIdentifierIsNull_){
                count += 1;
                str = "tradeIdentifier" ;
           }
           if(!originalTradeIsNull_){
                count += 1;
                str = "originalTrade" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         std::vector<boost::shared_ptr<PartyTradeIdentifier>> tradeIdentifier_;     //choice
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
         boost::shared_ptr<Trade> originalTrade_;     //choice
       std::string originalTradeIDRef_;
       bool originalTradeIsNull_;
       boost::shared_ptr<XsdTypeDate> agreementDate_;
       std::string agreementDateIDRef_;
       bool agreementDateIsNull_;
       boost::shared_ptr<ExecutionDateTime> executionDateTime_;
       std::string executionDateTimeIDRef_;
       bool executionDateTimeIsNull_;
       boost::shared_ptr<XsdTypeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       std::vector<boost::shared_ptr<Payment>> payment_;
       std::string paymentIDRef_;
       bool paymentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

