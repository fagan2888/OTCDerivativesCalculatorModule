// TradeNovationContent.hpp 
#ifndef FpmlSerialized_TradeNovationContent_hpp
#define FpmlSerialized_TradeNovationContent_hpp

#include <fpml-business-events-5-4/AbstractEvent.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-doc-5-4/ExecutionDateTime.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-doc-5-4/FirstPeriodStartDate.hpp>
#include <fpml-shared-5-4/Empty.hpp>
#include <fpml-doc-5-4/CreditDerivativesNotices.hpp>
#include <fpml-shared-5-4/ContractualDefinitions.hpp>
#include <fpml-shared-5-4/ContractualTermsSupplement.hpp>
#include <fpml-shared-5-4/Payment.hpp>

namespace FpmlSerialized {

class TradeNovationContent : public AbstractEvent { 
   public: 
       TradeNovationContent(TiXmlNode* xmlNode);

       bool isNewTradeIdentifier(){return this->newTradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getNewTradeIdentifier();
      std::string getNewTradeIdentifierIDRef(){return newTradeIdentifierIDRef_;}

       bool isNewTrade(){return this->newTradeIsNull_;}
       boost::shared_ptr<Trade> getNewTrade();
      std::string getNewTradeIDRef(){return newTradeIDRef_;}

       bool isOldTradeIdentifier(){return this->oldTradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getOldTradeIdentifier();
      std::string getOldTradeIdentifierIDRef(){return oldTradeIdentifierIDRef_;}

       bool isOldTrade(){return this->oldTradeIsNull_;}
       boost::shared_ptr<Trade> getOldTrade();
      std::string getOldTradeIDRef(){return oldTradeIDRef_;}

       bool isFeeTradeIdentifier(){return this->feeTradeIdentifierIsNull_;}
       boost::shared_ptr<PartyTradeIdentifier> getFeeTradeIdentifier();
      std::string getFeeTradeIdentifierIDRef(){return feeTradeIdentifierIDRef_;}

       bool isFeeTrade(){return this->feeTradeIsNull_;}
       boost::shared_ptr<Trade> getFeeTrade();
      std::string getFeeTradeIDRef(){return feeTradeIDRef_;}

       bool isTransferor(){return this->transferorIsNull_;}
       boost::shared_ptr<PartyReference> getTransferor();
      std::string getTransferorIDRef(){return transferorIDRef_;}

       bool isTransferorAccount(){return this->transferorAccountIsNull_;}
       boost::shared_ptr<AccountReference> getTransferorAccount();
      std::string getTransferorAccountIDRef(){return transferorAccountIDRef_;}

       bool isTransferee(){return this->transfereeIsNull_;}
       boost::shared_ptr<PartyReference> getTransferee();
      std::string getTransfereeIDRef(){return transfereeIDRef_;}

       bool isOtherTransferee(){return this->otherTransfereeIsNull_;}
       boost::shared_ptr<PartyReference> getOtherTransferee();
      std::string getOtherTransfereeIDRef(){return otherTransfereeIDRef_;}

       bool isTransfereeAccount(){return this->transfereeAccountIsNull_;}
       boost::shared_ptr<AccountReference> getTransfereeAccount();
      std::string getTransfereeAccountIDRef(){return transfereeAccountIDRef_;}

       bool isOtherTransfereeAccount(){return this->otherTransfereeAccountIsNull_;}
       boost::shared_ptr<AccountReference> getOtherTransfereeAccount();
      std::string getOtherTransfereeAccountIDRef(){return otherTransfereeAccountIDRef_;}

       bool isRemainingParty(){return this->remainingPartyIsNull_;}
       boost::shared_ptr<PartyReference> getRemainingParty();
      std::string getRemainingPartyIDRef(){return remainingPartyIDRef_;}

       bool isRemainingPartyAccount(){return this->remainingPartyAccountIsNull_;}
       boost::shared_ptr<AccountReference> getRemainingPartyAccount();
      std::string getRemainingPartyAccountIDRef(){return remainingPartyAccountIDRef_;}

       bool isOtherRemainingParty(){return this->otherRemainingPartyIsNull_;}
       boost::shared_ptr<PartyReference> getOtherRemainingParty();
      std::string getOtherRemainingPartyIDRef(){return otherRemainingPartyIDRef_;}

       bool isOtherRemainingPartyAccount(){return this->otherRemainingPartyAccountIsNull_;}
       boost::shared_ptr<AccountReference> getOtherRemainingPartyAccount();
      std::string getOtherRemainingPartyAccountIDRef(){return otherRemainingPartyAccountIDRef_;}

       bool isNovationDate(){return this->novationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getNovationDate();
      std::string getNovationDateIDRef(){return novationDateIDRef_;}

       bool isExecutionDateTime(){return this->executionDateTimeIsNull_;}
       boost::shared_ptr<ExecutionDateTime> getExecutionDateTime();
      std::string getExecutionDateTimeIDRef(){return executionDateTimeIDRef_;}

       bool isNovationTradeDate(){return this->novationTradeDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getNovationTradeDate();
      std::string getNovationTradeDateIDRef(){return novationTradeDateIDRef_;}

       bool isNovatedAmount(){return this->novatedAmountIsNull_;}
       std::vector<boost::shared_ptr<Money>> getNovatedAmount();
      std::string getNovatedAmountIDRef(){return novatedAmountIDRef_;}

       bool isRemainingAmount(){return this->remainingAmountIsNull_;}
       std::vector<boost::shared_ptr<Money>> getRemainingAmount();
      std::string getRemainingAmountIDRef(){return remainingAmountIDRef_;}

       bool isNovatedNumberOfOptions(){return this->novatedNumberOfOptionsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNovatedNumberOfOptions();
      std::string getNovatedNumberOfOptionsIDRef(){return novatedNumberOfOptionsIDRef_;}

       bool isRemainingNumberOfOptions(){return this->remainingNumberOfOptionsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getRemainingNumberOfOptions();
      std::string getRemainingNumberOfOptionsIDRef(){return remainingNumberOfOptionsIDRef_;}

       bool isNovatedNumberOfUnits(){return this->novatedNumberOfUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNovatedNumberOfUnits();
      std::string getNovatedNumberOfUnitsIDRef(){return novatedNumberOfUnitsIDRef_;}

       bool isRemainingNumberOfUnits(){return this->remainingNumberOfUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getRemainingNumberOfUnits();
      std::string getRemainingNumberOfUnitsIDRef(){return remainingNumberOfUnitsIDRef_;}

       bool isFullFirstCalculationPeriod(){return this->fullFirstCalculationPeriodIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFullFirstCalculationPeriod();
      std::string getFullFirstCalculationPeriodIDRef(){return fullFirstCalculationPeriodIDRef_;}

       bool isFirstPeriodStartDate(){return this->firstPeriodStartDateIsNull_;}
       std::vector<boost::shared_ptr<FirstPeriodStartDate>> getFirstPeriodStartDate();
      std::string getFirstPeriodStartDateIDRef(){return firstPeriodStartDateIDRef_;}

       bool isNonReliance(){return this->nonRelianceIsNull_;}
       boost::shared_ptr<Empty> getNonReliance();
      std::string getNonRelianceIDRef(){return nonRelianceIDRef_;}

       bool isCreditDerivativesNotices(){return this->creditDerivativesNoticesIsNull_;}
       boost::shared_ptr<CreditDerivativesNotices> getCreditDerivativesNotices();
      std::string getCreditDerivativesNoticesIDRef(){return creditDerivativesNoticesIDRef_;}

       bool isContractualDefinitions(){return this->contractualDefinitionsIsNull_;}
       std::vector<boost::shared_ptr<ContractualDefinitions>> getContractualDefinitions();
      std::string getContractualDefinitionsIDRef(){return contractualDefinitionsIDRef_;}

       bool isContractualTermsSupplement(){return this->contractualTermsSupplementIsNull_;}
       std::vector<boost::shared_ptr<ContractualTermsSupplement>> getContractualTermsSupplement();
      std::string getContractualTermsSupplementIDRef(){return contractualTermsSupplementIDRef_;}

       bool isPayment(){return this->paymentIsNull_;}
       boost::shared_ptr<Payment> getPayment();
      std::string getPaymentIDRef(){return paymentIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!newTradeIdentifierIsNull_){
                count += 1;
                str = "newTradeIdentifier" ;
           }
           if(!newTradeIsNull_){
                count += 1;
                str = "newTrade" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
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
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
       std::string getChoiceStr_3(){
           std::string str;
           int count = 0;
           if(!feeTradeIdentifierIsNull_){
                count += 1;
                str = "feeTradeIdentifier" ;
           }
           if(!feeTradeIsNull_){
                count += 1;
                str = "feeTrade" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_3_ = str ;
           return choiceStr_3_;
       }
       std::string getChoiceStr_4(){
           std::string str;
           int count = 0;
           if(!newTradeIdentifierIsNull_){
                count += 1;
                str = "newTradeIdentifier" ;
           }
           if(!newTradeIsNull_){
                count += 1;
                str = "newTrade" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_4_ = str ;
           return choiceStr_4_;
       }
       std::string getChoiceStr_5(){
           std::string str;
           int count = 0;
           if(!feeTradeIdentifierIsNull_){
                count += 1;
                str = "feeTradeIdentifier" ;
           }
           if(!feeTradeIsNull_){
                count += 1;
                str = "feeTrade" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_5_ = str ;
           return choiceStr_5_;
       }
       std::string getChoiceStr_6(){
           std::string str;
           int count = 0;
           if(!newTradeIdentifierIsNull_){
                count += 1;
                str = "newTradeIdentifier" ;
           }
           if(!newTradeIsNull_){
                count += 1;
                str = "newTrade" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_6_ = str ;
           return choiceStr_6_;
       }
       std::string getChoiceStr_7(){
           std::string str;
           int count = 0;
           if(!novatedAmountIsNull_){
                count += 1;
                str = "novatedAmount" ;
           }
           if(!remainingAmountIsNull_){
                count += 1;
                str = "remainingAmount" ;
           }
           if(!novatedNumberOfOptionsIsNull_){
                count += 1;
                str = "novatedNumberOfOptions" ;
           }
           if(!remainingNumberOfOptionsIsNull_){
                count += 1;
                str = "remainingNumberOfOptions" ;
           }
           if(!novatedNumberOfUnitsIsNull_){
                count += 1;
                str = "novatedNumberOfUnits" ;
           }
           if(!remainingNumberOfUnitsIsNull_){
                count += 1;
                str = "remainingNumberOfUnits" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_7_ = str ;
           return choiceStr_7_;
       }
   protected: 
         std::vector<boost::shared_ptr<PartyTradeIdentifier>> newTradeIdentifier_;     //choice
       std::string newTradeIdentifierIDRef_;
       bool newTradeIdentifierIsNull_;
         boost::shared_ptr<Trade> newTrade_;     //choice
       std::string newTradeIDRef_;
       bool newTradeIsNull_;
         std::vector<boost::shared_ptr<PartyTradeIdentifier>> oldTradeIdentifier_;     //choice
       std::string oldTradeIdentifierIDRef_;
       bool oldTradeIdentifierIsNull_;
         boost::shared_ptr<Trade> oldTrade_;     //choice
       std::string oldTradeIDRef_;
       bool oldTradeIsNull_;
         boost::shared_ptr<PartyTradeIdentifier> feeTradeIdentifier_;     //choice
       std::string feeTradeIdentifierIDRef_;
       bool feeTradeIdentifierIsNull_;
         boost::shared_ptr<Trade> feeTrade_;     //choice
       std::string feeTradeIDRef_;
       bool feeTradeIsNull_;
       boost::shared_ptr<PartyReference> transferor_;
       std::string transferorIDRef_;
       bool transferorIsNull_;
       boost::shared_ptr<AccountReference> transferorAccount_;
       std::string transferorAccountIDRef_;
       bool transferorAccountIsNull_;
       boost::shared_ptr<PartyReference> transferee_;
       std::string transfereeIDRef_;
       bool transfereeIsNull_;
       boost::shared_ptr<PartyReference> otherTransferee_;
       std::string otherTransfereeIDRef_;
       bool otherTransfereeIsNull_;
       boost::shared_ptr<AccountReference> transfereeAccount_;
       std::string transfereeAccountIDRef_;
       bool transfereeAccountIsNull_;
       boost::shared_ptr<AccountReference> otherTransfereeAccount_;
       std::string otherTransfereeAccountIDRef_;
       bool otherTransfereeAccountIsNull_;
       boost::shared_ptr<PartyReference> remainingParty_;
       std::string remainingPartyIDRef_;
       bool remainingPartyIsNull_;
       boost::shared_ptr<AccountReference> remainingPartyAccount_;
       std::string remainingPartyAccountIDRef_;
       bool remainingPartyAccountIsNull_;
       boost::shared_ptr<PartyReference> otherRemainingParty_;
       std::string otherRemainingPartyIDRef_;
       bool otherRemainingPartyIsNull_;
       boost::shared_ptr<AccountReference> otherRemainingPartyAccount_;
       std::string otherRemainingPartyAccountIDRef_;
       bool otherRemainingPartyAccountIsNull_;
       boost::shared_ptr<XsdTypeDate> novationDate_;
       std::string novationDateIDRef_;
       bool novationDateIsNull_;
       boost::shared_ptr<ExecutionDateTime> executionDateTime_;
       std::string executionDateTimeIDRef_;
       bool executionDateTimeIsNull_;
       boost::shared_ptr<XsdTypeDate> novationTradeDate_;
       std::string novationTradeDateIDRef_;
       bool novationTradeDateIsNull_;
         std::vector<boost::shared_ptr<Money>> novatedAmount_;     //choice
       std::string novatedAmountIDRef_;
       bool novatedAmountIsNull_;
         std::vector<boost::shared_ptr<Money>> remainingAmount_;     //choice
       std::string remainingAmountIDRef_;
       bool remainingAmountIsNull_;
         boost::shared_ptr<XsdTypeDecimal> novatedNumberOfOptions_;     //choice
       std::string novatedNumberOfOptionsIDRef_;
       bool novatedNumberOfOptionsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> remainingNumberOfOptions_;     //choice
       std::string remainingNumberOfOptionsIDRef_;
       bool remainingNumberOfOptionsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> novatedNumberOfUnits_;     //choice
       std::string novatedNumberOfUnitsIDRef_;
       bool novatedNumberOfUnitsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> remainingNumberOfUnits_;     //choice
       std::string remainingNumberOfUnitsIDRef_;
       bool remainingNumberOfUnitsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> fullFirstCalculationPeriod_;
       std::string fullFirstCalculationPeriodIDRef_;
       bool fullFirstCalculationPeriodIsNull_;
       std::vector<boost::shared_ptr<FirstPeriodStartDate>> firstPeriodStartDate_;
       std::string firstPeriodStartDateIDRef_;
       bool firstPeriodStartDateIsNull_;
       boost::shared_ptr<Empty> nonReliance_;
       std::string nonRelianceIDRef_;
       bool nonRelianceIsNull_;
       boost::shared_ptr<CreditDerivativesNotices> creditDerivativesNotices_;
       std::string creditDerivativesNoticesIDRef_;
       bool creditDerivativesNoticesIsNull_;
       std::vector<boost::shared_ptr<ContractualDefinitions>> contractualDefinitions_;
       std::string contractualDefinitionsIDRef_;
       bool contractualDefinitionsIsNull_;
       std::vector<boost::shared_ptr<ContractualTermsSupplement>> contractualTermsSupplement_;
       std::string contractualTermsSupplementIDRef_;
       bool contractualTermsSupplementIsNull_;
       boost::shared_ptr<Payment> payment_;
       std::string paymentIDRef_;
       bool paymentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;
       std::string choiceStr_3_;
       std::string choiceStr_4_;
       std::string choiceStr_5_;
       std::string choiceStr_6_;
       std::string choiceStr_7_;

};

} //namespaceFpmlSerialized end
#endif

