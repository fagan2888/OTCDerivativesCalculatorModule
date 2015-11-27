// FxOption.hpp 
#ifndef FpmlSerialized_FxOption_hpp
#define FpmlSerialized_FxOption_hpp

#include <fpml-option-shared-5-4/Option.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-fx-5-4/FxAmericanExercise.hpp>
#include <fpml-fx-5-4/FxEuropeanExercise.hpp>
#include <fpml-shared-5-4/ExerciseProcedure.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-enum-5-4/PutCallEnum.hpp>
#include <fpml-fx-5-4/FxStrikePrice.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-fx-5-4/FxOptionFeatures.hpp>
#include <fpml-fx-5-4/FxOptionPremium.hpp>
#include <fpml-shared-5-4/FxCashSettlement.hpp>

namespace FpmlSerialized {

class FxOption : public Option { 
   public: 
       FxOption(TiXmlNode* xmlNode);

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isTenorPeriod(){return this->tenorPeriodIsNull_;}
       boost::shared_ptr<Period> getTenorPeriod();
      std::string getTenorPeriodIDRef(){return tenorPeriodIDRef_;}

       bool isAmericanExercise(){return this->americanExerciseIsNull_;}
       boost::shared_ptr<FxAmericanExercise> getAmericanExercise();
      std::string getAmericanExerciseIDRef(){return americanExerciseIDRef_;}

       bool isEuropeanExercise(){return this->europeanExerciseIsNull_;}
       boost::shared_ptr<FxEuropeanExercise> getEuropeanExercise();
      std::string getEuropeanExerciseIDRef(){return europeanExerciseIDRef_;}

       bool isExerciseProcedure(){return this->exerciseProcedureIsNull_;}
       boost::shared_ptr<ExerciseProcedure> getExerciseProcedure();
      std::string getExerciseProcedureIDRef(){return exerciseProcedureIDRef_;}

       bool isPutCurrencyAmount(){return this->putCurrencyAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getPutCurrencyAmount();
      std::string getPutCurrencyAmountIDRef(){return putCurrencyAmountIDRef_;}

       bool isCallCurrencyAmount(){return this->callCurrencyAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getCallCurrencyAmount();
      std::string getCallCurrencyAmountIDRef(){return callCurrencyAmountIDRef_;}

       bool isSoldAs(){return this->soldAsIsNull_;}
       boost::shared_ptr<PutCallEnum> getSoldAs();
      std::string getSoldAsIDRef(){return soldAsIDRef_;}

       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<FxStrikePrice> getStrike();
      std::string getStrikeIDRef(){return strikeIDRef_;}

       bool isSpotRate(){return this->spotRateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getSpotRate();
      std::string getSpotRateIDRef(){return spotRateIDRef_;}

       bool isFeatures(){return this->featuresIsNull_;}
       boost::shared_ptr<FxOptionFeatures> getFeatures();
      std::string getFeaturesIDRef(){return featuresIDRef_;}

       bool isPremium(){return this->premiumIsNull_;}
       std::vector<boost::shared_ptr<FxOptionPremium>> getPremium();
      std::string getPremiumIDRef(){return premiumIDRef_;}

       bool isCashSettlement(){return this->cashSettlementIsNull_;}
       boost::shared_ptr<FxCashSettlement> getCashSettlement();
      std::string getCashSettlementIDRef(){return cashSettlementIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!americanExerciseIsNull_){
                count += 1;
                str = "americanExercise" ;
           }
           if(!europeanExerciseIsNull_){
                count += 1;
                str = "europeanExercise" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<Period> tenorPeriod_;
       std::string tenorPeriodIDRef_;
       bool tenorPeriodIsNull_;
         boost::shared_ptr<FxAmericanExercise> americanExercise_;     //choice
       std::string americanExerciseIDRef_;
       bool americanExerciseIsNull_;
         boost::shared_ptr<FxEuropeanExercise> europeanExercise_;     //choice
       std::string europeanExerciseIDRef_;
       bool europeanExerciseIsNull_;
       boost::shared_ptr<ExerciseProcedure> exerciseProcedure_;
       std::string exerciseProcedureIDRef_;
       bool exerciseProcedureIsNull_;
       boost::shared_ptr<NonNegativeMoney> putCurrencyAmount_;
       std::string putCurrencyAmountIDRef_;
       bool putCurrencyAmountIsNull_;
       boost::shared_ptr<NonNegativeMoney> callCurrencyAmount_;
       std::string callCurrencyAmountIDRef_;
       bool callCurrencyAmountIsNull_;
       boost::shared_ptr<PutCallEnum> soldAs_;
       std::string soldAsIDRef_;
       bool soldAsIsNull_;
       boost::shared_ptr<FxStrikePrice> strike_;
       std::string strikeIDRef_;
       bool strikeIsNull_;
       boost::shared_ptr<PositiveDecimal> spotRate_;
       std::string spotRateIDRef_;
       bool spotRateIsNull_;
       boost::shared_ptr<FxOptionFeatures> features_;
       std::string featuresIDRef_;
       bool featuresIsNull_;
       std::vector<boost::shared_ptr<FxOptionPremium>> premium_;
       std::string premiumIDRef_;
       bool premiumIsNull_;
       boost::shared_ptr<FxCashSettlement> cashSettlement_;
       std::string cashSettlementIDRef_;
       bool cashSettlementIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

