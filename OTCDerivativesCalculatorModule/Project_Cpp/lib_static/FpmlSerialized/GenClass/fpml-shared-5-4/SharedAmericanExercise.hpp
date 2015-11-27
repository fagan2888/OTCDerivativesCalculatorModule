// SharedAmericanExercise.hpp 
#ifndef FpmlSerialized_SharedAmericanExercise_hpp
#define FpmlSerialized_SharedAmericanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>

namespace FpmlSerialized {

class SharedAmericanExercise : public Exercise { 
   public: 
       SharedAmericanExercise(TiXmlNode* xmlNode);

       bool isCommencementDate(){return this->commencementDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getCommencementDate();
      std::string getCommencementDateIDRef(){return commencementDateIDRef_;}

       bool isExpirationDate(){return this->expirationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getExpirationDate();
      std::string getExpirationDateIDRef(){return expirationDateIDRef_;}

       bool isLatestExerciseTime(){return this->latestExerciseTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getLatestExerciseTime();
      std::string getLatestExerciseTimeIDRef(){return latestExerciseTimeIDRef_;}

       bool isLatestExerciseTimeDetermination(){return this->latestExerciseTimeDeterminationIsNull_;}
       boost::shared_ptr<DeterminationMethod> getLatestExerciseTimeDetermination();
      std::string getLatestExerciseTimeDeterminationIDRef(){return latestExerciseTimeDeterminationIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!latestExerciseTimeIsNull_){
                count += 1;
                str = "latestExerciseTime" ;
           }
           if(!latestExerciseTimeDeterminationIsNull_){
                count += 1;
                str = "latestExerciseTimeDetermination" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> commencementDate_;
       std::string commencementDateIDRef_;
       bool commencementDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> expirationDate_;
       std::string expirationDateIDRef_;
       bool expirationDateIsNull_;
         boost::shared_ptr<BusinessCenterTime> latestExerciseTime_;     //choice
       std::string latestExerciseTimeIDRef_;
       bool latestExerciseTimeIsNull_;
         boost::shared_ptr<DeterminationMethod> latestExerciseTimeDetermination_;     //choice
       std::string latestExerciseTimeDeterminationIDRef_;
       bool latestExerciseTimeDeterminationIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

