// OptionBaseExtended.hpp 
#ifndef FpmlSerialized_OptionBaseExtended_hpp
#define FpmlSerialized_OptionBaseExtended_hpp

#include <fpml-option-shared-5-4/OptionBase.hpp>
#include <fpml-option-shared-5-4/Premium.hpp>
#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AmericanExercise.hpp>
#include <fpml-shared-5-4/BermudaExercise.hpp>
#include <fpml-shared-5-4/EuropeanExercise.hpp>
#include <fpml-shared-5-4/ExerciseProcedure.hpp>
#include <fpml-option-shared-5-4/OptionFeature.hpp>
#include <fpml-shared-5-4/NotionalAmountReference.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-enum-5-4/SettlementTypeEnum.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class OptionBaseExtended : public OptionBase { 
   public: 
       OptionBaseExtended(TiXmlNode* xmlNode);

       bool isPremium(){return this->premiumIsNull_;}
       boost::shared_ptr<Premium> getPremium();
      std::string getPremiumIDRef(){return premiumIDRef_;}

       bool isExercise(){return this->exerciseIsNull_;}
       boost::shared_ptr<Exercise> getExercise();
      std::string getExerciseIDRef(){return exerciseIDRef_;}

       bool isAmericanExercise(){return this->americanExerciseIsNull_;}
       boost::shared_ptr<AmericanExercise> getAmericanExercise();
      std::string getAmericanExerciseIDRef(){return americanExerciseIDRef_;}

       bool isBermudaExercise(){return this->bermudaExerciseIsNull_;}
       boost::shared_ptr<BermudaExercise> getBermudaExercise();
      std::string getBermudaExerciseIDRef(){return bermudaExerciseIDRef_;}

       bool isEuropeanExercise(){return this->europeanExerciseIsNull_;}
       boost::shared_ptr<EuropeanExercise> getEuropeanExercise();
      std::string getEuropeanExerciseIDRef(){return europeanExerciseIDRef_;}

       bool isExerciseProcedure(){return this->exerciseProcedureIsNull_;}
       boost::shared_ptr<ExerciseProcedure> getExerciseProcedure();
      std::string getExerciseProcedureIDRef(){return exerciseProcedureIDRef_;}

       bool isFeature(){return this->featureIsNull_;}
       boost::shared_ptr<OptionFeature> getFeature();
      std::string getFeatureIDRef(){return featureIDRef_;}

       bool isNotionalReference(){return this->notionalReferenceIsNull_;}
       boost::shared_ptr<NotionalAmountReference> getNotionalReference();
      std::string getNotionalReferenceIDRef(){return notionalReferenceIDRef_;}

       bool isNotionalAmount(){return this->notionalAmountIsNull_;}
       boost::shared_ptr<Money> getNotionalAmount();
      std::string getNotionalAmountIDRef(){return notionalAmountIDRef_;}

       bool isOptionEntitlement(){return this->optionEntitlementIsNull_;}
       boost::shared_ptr<PositiveDecimal> getOptionEntitlement();
      std::string getOptionEntitlementIDRef(){return optionEntitlementIDRef_;}

       bool isEntitlementCurrency(){return this->entitlementCurrencyIsNull_;}
       boost::shared_ptr<Currency> getEntitlementCurrency();
      std::string getEntitlementCurrencyIDRef(){return entitlementCurrencyIDRef_;}

       bool isNumberOfOptions(){return this->numberOfOptionsIsNull_;}
       boost::shared_ptr<PositiveDecimal> getNumberOfOptions();
      std::string getNumberOfOptionsIDRef(){return numberOfOptionsIDRef_;}

       bool isSettlementType(){return this->settlementTypeIsNull_;}
       boost::shared_ptr<SettlementTypeEnum> getSettlementType();
      std::string getSettlementTypeIDRef(){return settlementTypeIDRef_;}

       bool isSettlementDate(){return this->settlementDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getSettlementDate();
      std::string getSettlementDateIDRef(){return settlementDateIDRef_;}

       bool isSettlementAmount(){return this->settlementAmountIsNull_;}
       boost::shared_ptr<Money> getSettlementAmount();
      std::string getSettlementAmountIDRef(){return settlementAmountIDRef_;}

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       boost::shared_ptr<Currency> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!notionalReferenceIsNull_){
                count += 1;
                str = "notionalReference" ;
           }
           if(!notionalAmountIsNull_){
                count += 1;
                str = "notionalAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!settlementAmountIsNull_){
                count += 1;
                str = "settlementAmount" ;
           }
           if(!settlementCurrencyIsNull_){
                count += 1;
                str = "settlementCurrency" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
       boost::shared_ptr<Premium> premium_;
       std::string premiumIDRef_;
       bool premiumIsNull_;
       boost::shared_ptr<Exercise> exercise_;
       std::string exerciseIDRef_;
       bool exerciseIsNull_;
       boost::shared_ptr<AmericanExercise> americanExercise_;     //substitude 
       std::string americanExerciseIDRef_;
       bool americanExerciseIsNull_;
       boost::shared_ptr<BermudaExercise> bermudaExercise_;     //substitude 
       std::string bermudaExerciseIDRef_;
       bool bermudaExerciseIsNull_;
       boost::shared_ptr<EuropeanExercise> europeanExercise_;     //substitude 
       std::string europeanExerciseIDRef_;
       bool europeanExerciseIsNull_;
       boost::shared_ptr<ExerciseProcedure> exerciseProcedure_;
       std::string exerciseProcedureIDRef_;
       bool exerciseProcedureIsNull_;
       boost::shared_ptr<OptionFeature> feature_;
       std::string featureIDRef_;
       bool featureIsNull_;
         boost::shared_ptr<NotionalAmountReference> notionalReference_;     //choice
       std::string notionalReferenceIDRef_;
       bool notionalReferenceIsNull_;
         boost::shared_ptr<Money> notionalAmount_;     //choice
       std::string notionalAmountIDRef_;
       bool notionalAmountIsNull_;
       boost::shared_ptr<PositiveDecimal> optionEntitlement_;
       std::string optionEntitlementIDRef_;
       bool optionEntitlementIsNull_;
       boost::shared_ptr<Currency> entitlementCurrency_;
       std::string entitlementCurrencyIDRef_;
       bool entitlementCurrencyIsNull_;
       boost::shared_ptr<PositiveDecimal> numberOfOptions_;
       std::string numberOfOptionsIDRef_;
       bool numberOfOptionsIsNull_;
       boost::shared_ptr<SettlementTypeEnum> settlementType_;
       std::string settlementTypeIDRef_;
       bool settlementTypeIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> settlementDate_;
       std::string settlementDateIDRef_;
       bool settlementDateIsNull_;
         boost::shared_ptr<Money> settlementAmount_;     //choice
       std::string settlementAmountIDRef_;
       bool settlementAmountIsNull_;
         boost::shared_ptr<Currency> settlementCurrency_;     //choice
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

