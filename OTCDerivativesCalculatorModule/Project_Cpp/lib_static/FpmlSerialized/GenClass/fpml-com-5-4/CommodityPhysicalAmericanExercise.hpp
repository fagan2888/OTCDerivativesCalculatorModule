// CommodityPhysicalAmericanExercise.hpp 
#ifndef FpmlSerialized_CommodityPhysicalAmericanExercise_hpp
#define FpmlSerialized_CommodityPhysicalAmericanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDates.hpp>
#include <fpml-com-5-4/CommodityRelativeExpirationDates.hpp>
#include <fpml-shared-5-4/PrevailingTime.hpp>

namespace FpmlSerialized {

class CommodityPhysicalAmericanExercise : public Exercise { 
   public: 
       CommodityPhysicalAmericanExercise(TiXmlNode* xmlNode);

       bool isCommencementDates(){return this->commencementDatesIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDates> getCommencementDates();
      std::string getCommencementDatesIDRef(){return commencementDatesIDRef_;}

       bool isExpirationDates(){return this->expirationDatesIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDates> getExpirationDates();
      std::string getExpirationDatesIDRef(){return expirationDatesIDRef_;}

       bool isRelativeCommencementDates(){return this->relativeCommencementDatesIsNull_;}
       boost::shared_ptr<CommodityRelativeExpirationDates> getRelativeCommencementDates();
      std::string getRelativeCommencementDatesIDRef(){return relativeCommencementDatesIDRef_;}

       bool isRelativeExpirationDates(){return this->relativeExpirationDatesIsNull_;}
       boost::shared_ptr<CommodityRelativeExpirationDates> getRelativeExpirationDates();
      std::string getRelativeExpirationDatesIDRef(){return relativeExpirationDatesIDRef_;}

       bool isLatestExerciseTime(){return this->latestExerciseTimeIsNull_;}
       boost::shared_ptr<PrevailingTime> getLatestExerciseTime();
      std::string getLatestExerciseTimeIDRef(){return latestExerciseTimeIDRef_;}

       bool isExpirationTime(){return this->expirationTimeIsNull_;}
       boost::shared_ptr<PrevailingTime> getExpirationTime();
      std::string getExpirationTimeIDRef(){return expirationTimeIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!commencementDatesIsNull_){
                count += 1;
                str = "commencementDates" ;
           }
           if(!expirationDatesIsNull_){
                count += 1;
                str = "expirationDates" ;
           }
           if(!relativeCommencementDatesIsNull_){
                count += 1;
                str = "relativeCommencementDates" ;
           }
           if(!relativeExpirationDatesIsNull_){
                count += 1;
                str = "relativeExpirationDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AdjustableOrRelativeDates> commencementDates_;     //choice
       std::string commencementDatesIDRef_;
       bool commencementDatesIsNull_;
         boost::shared_ptr<AdjustableOrRelativeDates> expirationDates_;     //choice
       std::string expirationDatesIDRef_;
       bool expirationDatesIsNull_;
         boost::shared_ptr<CommodityRelativeExpirationDates> relativeCommencementDates_;     //choice
       std::string relativeCommencementDatesIDRef_;
       bool relativeCommencementDatesIsNull_;
         boost::shared_ptr<CommodityRelativeExpirationDates> relativeExpirationDates_;     //choice
       std::string relativeExpirationDatesIDRef_;
       bool relativeExpirationDatesIsNull_;
       boost::shared_ptr<PrevailingTime> latestExerciseTime_;
       std::string latestExerciseTimeIDRef_;
       bool latestExerciseTimeIsNull_;
       boost::shared_ptr<PrevailingTime> expirationTime_;
       std::string expirationTimeIDRef_;
       bool expirationTimeIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

