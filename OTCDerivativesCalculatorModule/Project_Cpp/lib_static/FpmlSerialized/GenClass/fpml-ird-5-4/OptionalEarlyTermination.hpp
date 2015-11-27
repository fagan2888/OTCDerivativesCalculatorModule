// OptionalEarlyTermination.hpp 
#ifndef FpmlSerialized_OptionalEarlyTermination_hpp
#define FpmlSerialized_OptionalEarlyTermination_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/SinglePartyOption.hpp>
#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AmericanExercise.hpp>
#include <fpml-shared-5-4/BermudaExercise.hpp>
#include <fpml-shared-5-4/EuropeanExercise.hpp>
#include <fpml-shared-5-4/ExerciseNotice.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/CalculationAgent.hpp>
#include <fpml-ird-5-4/CashSettlement.hpp>
#include <fpml-ird-5-4/OptionalEarlyTerminationAdjustedDates.hpp>

namespace FpmlSerialized {

class OptionalEarlyTermination : public ISerialized { 
   public: 
       OptionalEarlyTermination(TiXmlNode* xmlNode);

       bool isSinglePartyOption(){return this->singlePartyOptionIsNull_;}
       boost::shared_ptr<SinglePartyOption> getSinglePartyOption();
      std::string getSinglePartyOptionIDRef(){return singlePartyOptionIDRef_;}

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

       bool isExerciseNotice(){return this->exerciseNoticeIsNull_;}
       std::vector<boost::shared_ptr<ExerciseNotice>> getExerciseNotice();
      std::string getExerciseNoticeIDRef(){return exerciseNoticeIDRef_;}

       bool isFollowUpConfirmation(){return this->followUpConfirmationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFollowUpConfirmation();
      std::string getFollowUpConfirmationIDRef(){return followUpConfirmationIDRef_;}

       bool isCalculationAgent(){return this->calculationAgentIsNull_;}
       boost::shared_ptr<CalculationAgent> getCalculationAgent();
      std::string getCalculationAgentIDRef(){return calculationAgentIDRef_;}

       bool isCashSettlement(){return this->cashSettlementIsNull_;}
       boost::shared_ptr<CashSettlement> getCashSettlement();
      std::string getCashSettlementIDRef(){return cashSettlementIDRef_;}

       bool isOptionalEarlyTerminationAdjustedDates(){return this->optionalEarlyTerminationAdjustedDatesIsNull_;}
       boost::shared_ptr<OptionalEarlyTerminationAdjustedDates> getOptionalEarlyTerminationAdjustedDates();
      std::string getOptionalEarlyTerminationAdjustedDatesIDRef(){return optionalEarlyTerminationAdjustedDatesIDRef_;}

   protected: 
       boost::shared_ptr<SinglePartyOption> singlePartyOption_;
       std::string singlePartyOptionIDRef_;
       bool singlePartyOptionIsNull_;
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
       std::vector<boost::shared_ptr<ExerciseNotice>> exerciseNotice_;
       std::string exerciseNoticeIDRef_;
       bool exerciseNoticeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> followUpConfirmation_;
       std::string followUpConfirmationIDRef_;
       bool followUpConfirmationIsNull_;
       boost::shared_ptr<CalculationAgent> calculationAgent_;
       std::string calculationAgentIDRef_;
       bool calculationAgentIsNull_;
       boost::shared_ptr<CashSettlement> cashSettlement_;
       std::string cashSettlementIDRef_;
       bool cashSettlementIsNull_;
       boost::shared_ptr<OptionalEarlyTerminationAdjustedDates> optionalEarlyTerminationAdjustedDates_;
       std::string optionalEarlyTerminationAdjustedDatesIDRef_;
       bool optionalEarlyTerminationAdjustedDatesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

