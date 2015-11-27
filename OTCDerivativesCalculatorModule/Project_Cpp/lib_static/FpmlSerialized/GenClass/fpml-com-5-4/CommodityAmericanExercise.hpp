// CommodityAmericanExercise.hpp 
#ifndef FpmlSerialized_CommodityAmericanExercise_hpp
#define FpmlSerialized_CommodityAmericanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-com-5-4/CommodityExercisePeriods.hpp>
#include <fpml-shared-5-4/Frequency.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>
#include <fpml-com-5-4/CommodityMultipleExercise.hpp>

namespace FpmlSerialized {

class CommodityAmericanExercise : public Exercise { 
   public: 
       CommodityAmericanExercise(TiXmlNode* xmlNode);

       bool isExercisePeriod(){return this->exercisePeriodIsNull_;}
       boost::shared_ptr<CommodityExercisePeriods> getExercisePeriod();
      std::string getExercisePeriodIDRef(){return exercisePeriodIDRef_;}

       bool isExerciseFrequency(){return this->exerciseFrequencyIsNull_;}
       boost::shared_ptr<Frequency> getExerciseFrequency();
      std::string getExerciseFrequencyIDRef(){return exerciseFrequencyIDRef_;}

       bool isLatestExerciseTime(){return this->latestExerciseTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getLatestExerciseTime();
      std::string getLatestExerciseTimeIDRef(){return latestExerciseTimeIDRef_;}

       bool isLatestExerciseTimeDetermination(){return this->latestExerciseTimeDeterminationIsNull_;}
       boost::shared_ptr<DeterminationMethod> getLatestExerciseTimeDetermination();
      std::string getLatestExerciseTimeDeterminationIDRef(){return latestExerciseTimeDeterminationIDRef_;}

       bool isExpirationTime(){return this->expirationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getExpirationTime();
      std::string getExpirationTimeIDRef(){return expirationTimeIDRef_;}

       bool isMultipleExercise(){return this->multipleExerciseIsNull_;}
       boost::shared_ptr<CommodityMultipleExercise> getMultipleExercise();
      std::string getMultipleExerciseIDRef(){return multipleExerciseIDRef_;}

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
       boost::shared_ptr<CommodityExercisePeriods> exercisePeriod_;
       std::string exercisePeriodIDRef_;
       bool exercisePeriodIsNull_;
       boost::shared_ptr<Frequency> exerciseFrequency_;
       std::string exerciseFrequencyIDRef_;
       bool exerciseFrequencyIsNull_;
         boost::shared_ptr<BusinessCenterTime> latestExerciseTime_;     //choice
       std::string latestExerciseTimeIDRef_;
       bool latestExerciseTimeIsNull_;
         boost::shared_ptr<DeterminationMethod> latestExerciseTimeDetermination_;     //choice
       std::string latestExerciseTimeDeterminationIDRef_;
       bool latestExerciseTimeDeterminationIsNull_;
       boost::shared_ptr<BusinessCenterTime> expirationTime_;
       std::string expirationTimeIDRef_;
       bool expirationTimeIsNull_;
       boost::shared_ptr<CommodityMultipleExercise> multipleExercise_;
       std::string multipleExerciseIDRef_;
       bool multipleExerciseIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

