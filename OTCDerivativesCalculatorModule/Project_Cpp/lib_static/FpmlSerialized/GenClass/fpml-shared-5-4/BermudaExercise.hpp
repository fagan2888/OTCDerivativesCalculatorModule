// BermudaExercise.hpp 
#ifndef FpmlSerialized_BermudaExercise_hpp
#define FpmlSerialized_BermudaExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDates.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-shared-5-4/MultipleExercise.hpp>
#include <fpml-shared-5-4/ExerciseFeeSchedule.hpp>

namespace FpmlSerialized {

class BermudaExercise : public Exercise { 
   public: 
       BermudaExercise(TiXmlNode* xmlNode);

       bool isBermudaExerciseDates(){return this->bermudaExerciseDatesIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDates> getBermudaExerciseDates();
      std::string getBermudaExerciseDatesIDRef(){return bermudaExerciseDatesIDRef_;}

       bool isRelevantUnderlyingDate(){return this->relevantUnderlyingDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDates> getRelevantUnderlyingDate();
      std::string getRelevantUnderlyingDateIDRef(){return relevantUnderlyingDateIDRef_;}

       bool isEarliestExerciseTime(){return this->earliestExerciseTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getEarliestExerciseTime();
      std::string getEarliestExerciseTimeIDRef(){return earliestExerciseTimeIDRef_;}

       bool isLatestExerciseTime(){return this->latestExerciseTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getLatestExerciseTime();
      std::string getLatestExerciseTimeIDRef(){return latestExerciseTimeIDRef_;}

       bool isExpirationTime(){return this->expirationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getExpirationTime();
      std::string getExpirationTimeIDRef(){return expirationTimeIDRef_;}

       bool isMultipleExercise(){return this->multipleExerciseIsNull_;}
       boost::shared_ptr<MultipleExercise> getMultipleExercise();
      std::string getMultipleExerciseIDRef(){return multipleExerciseIDRef_;}

       bool isExerciseFeeSchedule(){return this->exerciseFeeScheduleIsNull_;}
       boost::shared_ptr<ExerciseFeeSchedule> getExerciseFeeSchedule();
      std::string getExerciseFeeScheduleIDRef(){return exerciseFeeScheduleIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDates> bermudaExerciseDates_;
       std::string bermudaExerciseDatesIDRef_;
       bool bermudaExerciseDatesIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDates> relevantUnderlyingDate_;
       std::string relevantUnderlyingDateIDRef_;
       bool relevantUnderlyingDateIsNull_;
       boost::shared_ptr<BusinessCenterTime> earliestExerciseTime_;
       std::string earliestExerciseTimeIDRef_;
       bool earliestExerciseTimeIsNull_;
       boost::shared_ptr<BusinessCenterTime> latestExerciseTime_;
       std::string latestExerciseTimeIDRef_;
       bool latestExerciseTimeIsNull_;
       boost::shared_ptr<BusinessCenterTime> expirationTime_;
       std::string expirationTimeIDRef_;
       bool expirationTimeIsNull_;
       boost::shared_ptr<MultipleExercise> multipleExercise_;
       std::string multipleExerciseIDRef_;
       bool multipleExerciseIsNull_;
       boost::shared_ptr<ExerciseFeeSchedule> exerciseFeeSchedule_;
       std::string exerciseFeeScheduleIDRef_;
       bool exerciseFeeScheduleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

