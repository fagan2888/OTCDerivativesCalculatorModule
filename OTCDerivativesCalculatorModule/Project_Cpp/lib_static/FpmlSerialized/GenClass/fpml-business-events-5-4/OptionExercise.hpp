// OptionExercise.hpp 
#ifndef FpmlSerialized_OptionExercise_hpp
#define FpmlSerialized_OptionExercise_hpp

#include <fpml-business-events-5-4/AbstractEvent.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeTime.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-enum-5-4/SettlementTypeEnum.hpp>
#include <fpml-shared-5-4/SimplePayment.hpp>
#include <fpml-business-events-5-4/PhysicalSettlement.hpp>
#include <fpml-shared-5-4/NonNegativePayment.hpp>

namespace FpmlSerialized {

class OptionExercise : public AbstractEvent { 
   public: 
       OptionExercise(TiXmlNode* xmlNode);

       bool isOptionSeller(){return this->optionSellerIsNull_;}
       boost::shared_ptr<PartyReference> getOptionSeller();
      std::string getOptionSellerIDRef(){return optionSellerIDRef_;}

       bool isOptionBuyer(){return this->optionBuyerIsNull_;}
       boost::shared_ptr<PartyReference> getOptionBuyer();
      std::string getOptionBuyerIDRef(){return optionBuyerIDRef_;}

       bool isOriginalTrade(){return this->originalTradeIsNull_;}
       boost::shared_ptr<Trade> getOriginalTrade();
      std::string getOriginalTradeIDRef(){return originalTradeIDRef_;}

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isExerciseDate(){return this->exerciseDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getExerciseDate();
      std::string getExerciseDateIDRef(){return exerciseDateIDRef_;}

       bool isExerciseTime(){return this->exerciseTimeIsNull_;}
       boost::shared_ptr<XsdTypeTime> getExerciseTime();
      std::string getExerciseTimeIDRef(){return exerciseTimeIDRef_;}

       bool isExpiry(){return this->expiryIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getExpiry();
      std::string getExpiryIDRef(){return expiryIDRef_;}

       bool isFullExercise(){return this->fullExerciseIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFullExercise();
      std::string getFullExerciseIDRef(){return fullExerciseIDRef_;}

       bool isExerciseInNotionalAmount(){return this->exerciseInNotionalAmountIsNull_;}
       boost::shared_ptr<Money> getExerciseInNotionalAmount();
      std::string getExerciseInNotionalAmountIDRef(){return exerciseInNotionalAmountIDRef_;}

       bool isOutstandingNotionalAmount(){return this->outstandingNotionalAmountIsNull_;}
       boost::shared_ptr<Money> getOutstandingNotionalAmount();
      std::string getOutstandingNotionalAmountIDRef(){return outstandingNotionalAmountIDRef_;}

       bool isExerciseInNumberOfOptions(){return this->exerciseInNumberOfOptionsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getExerciseInNumberOfOptions();
      std::string getExerciseInNumberOfOptionsIDRef(){return exerciseInNumberOfOptionsIDRef_;}

       bool isOutstandingNumberOfOptions(){return this->outstandingNumberOfOptionsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getOutstandingNumberOfOptions();
      std::string getOutstandingNumberOfOptionsIDRef(){return outstandingNumberOfOptionsIDRef_;}

       bool isExerciseInNumberOfUnits(){return this->exerciseInNumberOfUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getExerciseInNumberOfUnits();
      std::string getExerciseInNumberOfUnitsIDRef(){return exerciseInNumberOfUnitsIDRef_;}

       bool isOutstandingNumberOfUnits(){return this->outstandingNumberOfUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getOutstandingNumberOfUnits();
      std::string getOutstandingNumberOfUnitsIDRef(){return outstandingNumberOfUnitsIDRef_;}

       bool isSettlementType(){return this->settlementTypeIsNull_;}
       boost::shared_ptr<SettlementTypeEnum> getSettlementType();
      std::string getSettlementTypeIDRef(){return settlementTypeIDRef_;}

       bool isCashSettlement(){return this->cashSettlementIsNull_;}
       boost::shared_ptr<SimplePayment> getCashSettlement();
      std::string getCashSettlementIDRef(){return cashSettlementIDRef_;}

       bool isPhysicalSettlement(){return this->physicalSettlementIsNull_;}
       boost::shared_ptr<PhysicalSettlement> getPhysicalSettlement();
      std::string getPhysicalSettlementIDRef(){return physicalSettlementIDRef_;}

       bool isPayment(){return this->paymentIsNull_;}
       boost::shared_ptr<NonNegativePayment> getPayment();
      std::string getPaymentIDRef(){return paymentIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!originalTradeIsNull_){
                count += 1;
                str = "originalTrade" ;
           }
           if(!tradeIdentifierIsNull_){
                count += 1;
                str = "tradeIdentifier" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!expiryIsNull_){
                count += 1;
                str = "expiry" ;
           }
           if(!fullExerciseIsNull_){
                count += 1;
                str = "fullExercise" ;
           }
           if(!exerciseInNotionalAmountIsNull_){
                count += 1;
                str = "exerciseInNotionalAmount" ;
           }
           if(!outstandingNotionalAmountIsNull_){
                count += 1;
                str = "outstandingNotionalAmount" ;
           }
           if(!exerciseInNumberOfOptionsIsNull_){
                count += 1;
                str = "exerciseInNumberOfOptions" ;
           }
           if(!outstandingNumberOfOptionsIsNull_){
                count += 1;
                str = "outstandingNumberOfOptions" ;
           }
           if(!exerciseInNumberOfUnitsIsNull_){
                count += 1;
                str = "exerciseInNumberOfUnits" ;
           }
           if(!outstandingNumberOfUnitsIsNull_){
                count += 1;
                str = "outstandingNumberOfUnits" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!settlementTypeIsNull_){
                count += 1;
                str = "settlementType" ;
           }
           if(!cashSettlementIsNull_){
                count += 1;
                str = "cashSettlement" ;
           }
           if(!physicalSettlementIsNull_){
                count += 1;
                str = "physicalSettlement" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
   protected: 
       boost::shared_ptr<PartyReference> optionSeller_;
       std::string optionSellerIDRef_;
       bool optionSellerIsNull_;
       boost::shared_ptr<PartyReference> optionBuyer_;
       std::string optionBuyerIDRef_;
       bool optionBuyerIsNull_;
         boost::shared_ptr<Trade> originalTrade_;     //choice
       std::string originalTradeIDRef_;
       bool originalTradeIsNull_;
         std::vector<boost::shared_ptr<PartyTradeIdentifier>> tradeIdentifier_;     //choice
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
       boost::shared_ptr<XsdTypeDate> exerciseDate_;
       std::string exerciseDateIDRef_;
       bool exerciseDateIsNull_;
       boost::shared_ptr<XsdTypeTime> exerciseTime_;
       std::string exerciseTimeIDRef_;
       bool exerciseTimeIsNull_;
         boost::shared_ptr<XsdTypeBoolean> expiry_;     //choice
       std::string expiryIDRef_;
       bool expiryIsNull_;
         boost::shared_ptr<XsdTypeBoolean> fullExercise_;     //choice
       std::string fullExerciseIDRef_;
       bool fullExerciseIsNull_;
         boost::shared_ptr<Money> exerciseInNotionalAmount_;     //choice
       std::string exerciseInNotionalAmountIDRef_;
       bool exerciseInNotionalAmountIsNull_;
         boost::shared_ptr<Money> outstandingNotionalAmount_;     //choice
       std::string outstandingNotionalAmountIDRef_;
       bool outstandingNotionalAmountIsNull_;
         boost::shared_ptr<XsdTypeDecimal> exerciseInNumberOfOptions_;     //choice
       std::string exerciseInNumberOfOptionsIDRef_;
       bool exerciseInNumberOfOptionsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> outstandingNumberOfOptions_;     //choice
       std::string outstandingNumberOfOptionsIDRef_;
       bool outstandingNumberOfOptionsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> exerciseInNumberOfUnits_;     //choice
       std::string exerciseInNumberOfUnitsIDRef_;
       bool exerciseInNumberOfUnitsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> outstandingNumberOfUnits_;     //choice
       std::string outstandingNumberOfUnitsIDRef_;
       bool outstandingNumberOfUnitsIsNull_;
         boost::shared_ptr<SettlementTypeEnum> settlementType_;     //choice
       std::string settlementTypeIDRef_;
       bool settlementTypeIsNull_;
         boost::shared_ptr<SimplePayment> cashSettlement_;     //choice
       std::string cashSettlementIDRef_;
       bool cashSettlementIsNull_;
         boost::shared_ptr<PhysicalSettlement> physicalSettlement_;     //choice
       std::string physicalSettlementIDRef_;
       bool physicalSettlementIsNull_;
       boost::shared_ptr<NonNegativePayment> payment_;
       std::string paymentIDRef_;
       bool paymentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;

};

} //namespaceFpmlSerialized end
#endif

