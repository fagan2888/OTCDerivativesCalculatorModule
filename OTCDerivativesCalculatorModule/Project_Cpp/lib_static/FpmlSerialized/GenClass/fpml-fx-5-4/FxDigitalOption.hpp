// FxDigitalOption.hpp 
#ifndef FpmlSerialized_FxDigitalOption_hpp
#define FpmlSerialized_FxDigitalOption_hpp

#include <fpml-option-shared-5-4/Option.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-fx-5-4/FxDigitalAmericanExercise.hpp>
#include <fpml-fx-5-4/FxTouch.hpp>
#include <fpml-fx-5-4/FxEuropeanExercise.hpp>
#include <fpml-fx-5-4/FxTrigger.hpp>
#include <fpml-shared-5-4/ExerciseProcedure.hpp>
#include <fpml-fx-5-4/FxOptionPayout.hpp>
#include <fpml-fx-5-4/FxOptionPremium.hpp>

namespace FpmlSerialized {

class FxDigitalOption : public Option { 
   public: 
       FxDigitalOption(TiXmlNode* xmlNode);

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isTenorPeriod(){return this->tenorPeriodIsNull_;}
       boost::shared_ptr<Period> getTenorPeriod();
      std::string getTenorPeriodIDRef(){return tenorPeriodIDRef_;}

       bool isAmericanExercise(){return this->americanExerciseIsNull_;}
       boost::shared_ptr<FxDigitalAmericanExercise> getAmericanExercise();
      std::string getAmericanExerciseIDRef(){return americanExerciseIDRef_;}

       bool isTouch(){return this->touchIsNull_;}
       std::vector<boost::shared_ptr<FxTouch>> getTouch();
      std::string getTouchIDRef(){return touchIDRef_;}

       bool isEuropeanExercise(){return this->europeanExerciseIsNull_;}
       boost::shared_ptr<FxEuropeanExercise> getEuropeanExercise();
      std::string getEuropeanExerciseIDRef(){return europeanExerciseIDRef_;}

       bool isTrigger(){return this->triggerIsNull_;}
       std::vector<boost::shared_ptr<FxTrigger>> getTrigger();
      std::string getTriggerIDRef(){return triggerIDRef_;}

       bool isExerciseProcedure(){return this->exerciseProcedureIsNull_;}
       boost::shared_ptr<ExerciseProcedure> getExerciseProcedure();
      std::string getExerciseProcedureIDRef(){return exerciseProcedureIDRef_;}

       bool isPayout(){return this->payoutIsNull_;}
       boost::shared_ptr<FxOptionPayout> getPayout();
      std::string getPayoutIDRef(){return payoutIDRef_;}

       bool isPremium(){return this->premiumIsNull_;}
       std::vector<boost::shared_ptr<FxOptionPremium>> getPremium();
      std::string getPremiumIDRef(){return premiumIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!americanExerciseIsNull_){
                count += 1;
                str = "americanExercise" ;
           }
           if(!touchIsNull_){
                count += 1;
                str = "touch" ;
           }
           if(!europeanExerciseIsNull_){
                count += 1;
                str = "europeanExercise" ;
           }
           if(!triggerIsNull_){
                count += 1;
                str = "trigger" ;
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
         boost::shared_ptr<FxDigitalAmericanExercise> americanExercise_;     //choice
       std::string americanExerciseIDRef_;
       bool americanExerciseIsNull_;
         std::vector<boost::shared_ptr<FxTouch>> touch_;     //choice
       std::string touchIDRef_;
       bool touchIsNull_;
         boost::shared_ptr<FxEuropeanExercise> europeanExercise_;     //choice
       std::string europeanExerciseIDRef_;
       bool europeanExerciseIsNull_;
         std::vector<boost::shared_ptr<FxTrigger>> trigger_;     //choice
       std::string triggerIDRef_;
       bool triggerIsNull_;
       boost::shared_ptr<ExerciseProcedure> exerciseProcedure_;
       std::string exerciseProcedureIDRef_;
       bool exerciseProcedureIsNull_;
       boost::shared_ptr<FxOptionPayout> payout_;
       std::string payoutIDRef_;
       bool payoutIsNull_;
       std::vector<boost::shared_ptr<FxOptionPremium>> premium_;
       std::string premiumIDRef_;
       bool premiumIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

