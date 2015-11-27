// EuropeanExercise.hpp 
#ifndef FpmlSerialized_EuropeanExercise_hpp
#define FpmlSerialized_EuropeanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDates.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-shared-5-4/PartialExercise.hpp>
#include <fpml-shared-5-4/ExerciseFee.hpp>

namespace FpmlSerialized {

class EuropeanExercise : public Exercise { 
   public: 
       EuropeanExercise(TiXmlNode* xmlNode);

       bool isExpirationDate(){return this->expirationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getExpirationDate();
      std::string getExpirationDateIDRef(){return expirationDateIDRef_;}

       bool isRelevantUnderlyingDate(){return this->relevantUnderlyingDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDates> getRelevantUnderlyingDate();
      std::string getRelevantUnderlyingDateIDRef(){return relevantUnderlyingDateIDRef_;}

       bool isEarliestExerciseTime(){return this->earliestExerciseTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getEarliestExerciseTime();
      std::string getEarliestExerciseTimeIDRef(){return earliestExerciseTimeIDRef_;}

       bool isExpirationTime(){return this->expirationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getExpirationTime();
      std::string getExpirationTimeIDRef(){return expirationTimeIDRef_;}

       bool isPartialExercise(){return this->partialExerciseIsNull_;}
       boost::shared_ptr<PartialExercise> getPartialExercise();
      std::string getPartialExerciseIDRef(){return partialExerciseIDRef_;}

       bool isExerciseFee(){return this->exerciseFeeIsNull_;}
       boost::shared_ptr<ExerciseFee> getExerciseFee();
      std::string getExerciseFeeIDRef(){return exerciseFeeIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> expirationDate_;
       std::string expirationDateIDRef_;
       bool expirationDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDates> relevantUnderlyingDate_;
       std::string relevantUnderlyingDateIDRef_;
       bool relevantUnderlyingDateIsNull_;
       boost::shared_ptr<BusinessCenterTime> earliestExerciseTime_;
       std::string earliestExerciseTimeIDRef_;
       bool earliestExerciseTimeIsNull_;
       boost::shared_ptr<BusinessCenterTime> expirationTime_;
       std::string expirationTimeIDRef_;
       bool expirationTimeIsNull_;
       boost::shared_ptr<PartialExercise> partialExercise_;
       std::string partialExerciseIDRef_;
       bool partialExerciseIsNull_;
       boost::shared_ptr<ExerciseFee> exerciseFee_;
       std::string exerciseFeeIDRef_;
       bool exerciseFeeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

