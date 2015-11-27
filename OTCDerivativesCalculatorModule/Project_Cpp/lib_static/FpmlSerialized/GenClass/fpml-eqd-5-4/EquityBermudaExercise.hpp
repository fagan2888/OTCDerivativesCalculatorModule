// EquityBermudaExercise.hpp 
#ifndef FpmlSerialized_EquityBermudaExercise_hpp
#define FpmlSerialized_EquityBermudaExercise_hpp

#include <fpml-shared-5-4/SharedAmericanExercise.hpp>
#include <fpml-shared-5-4/DateList.hpp>
#include <fpml-enum-5-4/TimeTypeEnum.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>
#include <fpml-eqd-5-4/EquityMultipleExercise.hpp>

namespace FpmlSerialized {

class EquityBermudaExercise : public SharedAmericanExercise { 
   public: 
       EquityBermudaExercise(TiXmlNode* xmlNode);

       bool isBermudaExerciseDates(){return this->bermudaExerciseDatesIsNull_;}
       boost::shared_ptr<DateList> getBermudaExerciseDates();
      std::string getBermudaExerciseDatesIDRef(){return bermudaExerciseDatesIDRef_;}

       bool isLatestExerciseTimeType(){return this->latestExerciseTimeTypeIsNull_;}
       boost::shared_ptr<TimeTypeEnum> getLatestExerciseTimeType();
      std::string getLatestExerciseTimeTypeIDRef(){return latestExerciseTimeTypeIDRef_;}

       bool isEquityExpirationTimeType(){return this->equityExpirationTimeTypeIsNull_;}
       boost::shared_ptr<TimeTypeEnum> getEquityExpirationTimeType();
      std::string getEquityExpirationTimeTypeIDRef(){return equityExpirationTimeTypeIDRef_;}

       bool isEquityExpirationTime(){return this->equityExpirationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getEquityExpirationTime();
      std::string getEquityExpirationTimeIDRef(){return equityExpirationTimeIDRef_;}

       bool isExpirationTimeDetermination(){return this->expirationTimeDeterminationIsNull_;}
       boost::shared_ptr<DeterminationMethod> getExpirationTimeDetermination();
      std::string getExpirationTimeDeterminationIDRef(){return expirationTimeDeterminationIDRef_;}

       bool isEquityMultipleExercise(){return this->equityMultipleExerciseIsNull_;}
       boost::shared_ptr<EquityMultipleExercise> getEquityMultipleExercise();
      std::string getEquityMultipleExerciseIDRef(){return equityMultipleExerciseIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!equityExpirationTimeTypeIsNull_){
                count += 1;
                str = "equityExpirationTimeType" ;
           }
           if(!equityExpirationTimeIsNull_){
                count += 1;
                str = "equityExpirationTime" ;
           }
           if(!expirationTimeDeterminationIsNull_){
                count += 1;
                str = "expirationTimeDetermination" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<DateList> bermudaExerciseDates_;
       std::string bermudaExerciseDatesIDRef_;
       bool bermudaExerciseDatesIsNull_;
       boost::shared_ptr<TimeTypeEnum> latestExerciseTimeType_;
       std::string latestExerciseTimeTypeIDRef_;
       bool latestExerciseTimeTypeIsNull_;
         boost::shared_ptr<TimeTypeEnum> equityExpirationTimeType_;     //choice
       std::string equityExpirationTimeTypeIDRef_;
       bool equityExpirationTimeTypeIsNull_;
         boost::shared_ptr<BusinessCenterTime> equityExpirationTime_;     //choice
       std::string equityExpirationTimeIDRef_;
       bool equityExpirationTimeIsNull_;
         boost::shared_ptr<DeterminationMethod> expirationTimeDetermination_;     //choice
       std::string expirationTimeDeterminationIDRef_;
       bool expirationTimeDeterminationIsNull_;
       boost::shared_ptr<EquityMultipleExercise> equityMultipleExercise_;
       std::string equityMultipleExerciseIDRef_;
       bool equityMultipleExerciseIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

