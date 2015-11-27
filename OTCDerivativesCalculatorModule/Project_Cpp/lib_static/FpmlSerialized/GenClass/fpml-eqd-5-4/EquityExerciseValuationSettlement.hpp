// EquityExerciseValuationSettlement.hpp 
#ifndef FpmlSerialized_EquityExerciseValuationSettlement_hpp
#define FpmlSerialized_EquityExerciseValuationSettlement_hpp

#include <ISerialized.hpp>
#include <fpml-eqd-5-4/EquityEuropeanExercise.hpp>
#include <fpml-eqd-5-4/EquityAmericanExercise.hpp>
#include <fpml-eqd-5-4/EquityBermudaExercise.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-eq-shared-5-4/MakeWholeProvisions.hpp>
#include <fpml-eqd-5-4/PrePayment.hpp>
#include <fpml-eq-shared-5-4/EquityValuation.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-shared-5-4/SettlementPriceSource.hpp>
#include <fpml-enum-5-4/SettlementTypeEnum.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/SettlementPriceDefaultElection.hpp>

namespace FpmlSerialized {

class EquityExerciseValuationSettlement : public ISerialized { 
   public: 
       EquityExerciseValuationSettlement(TiXmlNode* xmlNode);

       bool isEquityEuropeanExercise(){return this->equityEuropeanExerciseIsNull_;}
       boost::shared_ptr<EquityEuropeanExercise> getEquityEuropeanExercise();
      std::string getEquityEuropeanExerciseIDRef(){return equityEuropeanExerciseIDRef_;}

       bool isEquityAmericanExercise(){return this->equityAmericanExerciseIsNull_;}
       boost::shared_ptr<EquityAmericanExercise> getEquityAmericanExercise();
      std::string getEquityAmericanExerciseIDRef(){return equityAmericanExerciseIDRef_;}

       bool isEquityBermudaExercise(){return this->equityBermudaExerciseIsNull_;}
       boost::shared_ptr<EquityBermudaExercise> getEquityBermudaExercise();
      std::string getEquityBermudaExerciseIDRef(){return equityBermudaExerciseIDRef_;}

       bool isAutomaticExercise(){return this->automaticExerciseIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAutomaticExercise();
      std::string getAutomaticExerciseIDRef(){return automaticExerciseIDRef_;}

       bool isMakeWholeProvisions(){return this->makeWholeProvisionsIsNull_;}
       boost::shared_ptr<MakeWholeProvisions> getMakeWholeProvisions();
      std::string getMakeWholeProvisionsIDRef(){return makeWholeProvisionsIDRef_;}

       bool isPrePayment(){return this->prePaymentIsNull_;}
       boost::shared_ptr<PrePayment> getPrePayment();
      std::string getPrePaymentIDRef(){return prePaymentIDRef_;}

       bool isEquityValuation(){return this->equityValuationIsNull_;}
       boost::shared_ptr<EquityValuation> getEquityValuation();
      std::string getEquityValuationIDRef(){return equityValuationIDRef_;}

       bool isSettlementDate(){return this->settlementDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getSettlementDate();
      std::string getSettlementDateIDRef(){return settlementDateIDRef_;}

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       boost::shared_ptr<Currency> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

       bool isSettlementPriceSource(){return this->settlementPriceSourceIsNull_;}
       boost::shared_ptr<SettlementPriceSource> getSettlementPriceSource();
      std::string getSettlementPriceSourceIDRef(){return settlementPriceSourceIDRef_;}

       bool isSettlementType(){return this->settlementTypeIsNull_;}
       boost::shared_ptr<SettlementTypeEnum> getSettlementType();
      std::string getSettlementTypeIDRef(){return settlementTypeIDRef_;}

       bool isSettlementMethodElectionDate(){return this->settlementMethodElectionDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getSettlementMethodElectionDate();
      std::string getSettlementMethodElectionDateIDRef(){return settlementMethodElectionDateIDRef_;}

       bool isSettlementMethodElectingPartyReference(){return this->settlementMethodElectingPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getSettlementMethodElectingPartyReference();
      std::string getSettlementMethodElectingPartyReferenceIDRef(){return settlementMethodElectingPartyReferenceIDRef_;}

       bool isSettlementPriceDefaultElection(){return this->settlementPriceDefaultElectionIsNull_;}
       boost::shared_ptr<SettlementPriceDefaultElection> getSettlementPriceDefaultElection();
      std::string getSettlementPriceDefaultElectionIDRef(){return settlementPriceDefaultElectionIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!equityEuropeanExerciseIsNull_){
                count += 1;
                str = "equityEuropeanExercise" ;
           }
           if(!equityAmericanExerciseIsNull_){
                count += 1;
                str = "equityAmericanExercise" ;
           }
           if(!equityBermudaExerciseIsNull_){
                count += 1;
                str = "equityBermudaExercise" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!automaticExerciseIsNull_){
                count += 1;
                str = "automaticExercise" ;
           }
           if(!makeWholeProvisionsIsNull_){
                count += 1;
                str = "makeWholeProvisions" ;
           }
           if(!prePaymentIsNull_){
                count += 1;
                str = "prePayment" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<EquityEuropeanExercise> equityEuropeanExercise_;     //choice
       std::string equityEuropeanExerciseIDRef_;
       bool equityEuropeanExerciseIsNull_;
         boost::shared_ptr<EquityAmericanExercise> equityAmericanExercise_;     //choice
       std::string equityAmericanExerciseIDRef_;
       bool equityAmericanExerciseIsNull_;
         boost::shared_ptr<EquityBermudaExercise> equityBermudaExercise_;     //choice
       std::string equityBermudaExerciseIDRef_;
       bool equityBermudaExerciseIsNull_;
         boost::shared_ptr<XsdTypeBoolean> automaticExercise_;     //choice
       std::string automaticExerciseIDRef_;
       bool automaticExerciseIsNull_;
         boost::shared_ptr<MakeWholeProvisions> makeWholeProvisions_;     //choice
       std::string makeWholeProvisionsIDRef_;
       bool makeWholeProvisionsIsNull_;
         boost::shared_ptr<PrePayment> prePayment_;     //choice
       std::string prePaymentIDRef_;
       bool prePaymentIsNull_;
       boost::shared_ptr<EquityValuation> equityValuation_;
       std::string equityValuationIDRef_;
       bool equityValuationIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> settlementDate_;
       std::string settlementDateIDRef_;
       bool settlementDateIsNull_;
       boost::shared_ptr<Currency> settlementCurrency_;
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;
       boost::shared_ptr<SettlementPriceSource> settlementPriceSource_;
       std::string settlementPriceSourceIDRef_;
       bool settlementPriceSourceIsNull_;
       boost::shared_ptr<SettlementTypeEnum> settlementType_;
       std::string settlementTypeIDRef_;
       bool settlementTypeIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> settlementMethodElectionDate_;
       std::string settlementMethodElectionDateIDRef_;
       bool settlementMethodElectionDateIsNull_;
       boost::shared_ptr<PartyReference> settlementMethodElectingPartyReference_;
       std::string settlementMethodElectingPartyReferenceIDRef_;
       bool settlementMethodElectingPartyReferenceIsNull_;
       boost::shared_ptr<SettlementPriceDefaultElection> settlementPriceDefaultElection_;
       std::string settlementPriceDefaultElectionIDRef_;
       bool settlementPriceDefaultElectionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

