// CommodityPhysicalEuropeanExercise.hpp 
#ifndef FpmlSerialized_CommodityPhysicalEuropeanExercise_hpp
#define FpmlSerialized_CommodityPhysicalEuropeanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/AdjustableRelativeOrPeriodicDates2.hpp>
#include <fpml-com-5-4/CommodityRelativeExpirationDates.hpp>
#include <fpml-shared-5-4/PrevailingTime.hpp>

namespace FpmlSerialized {

class CommodityPhysicalEuropeanExercise : public Exercise { 
   public: 
       CommodityPhysicalEuropeanExercise(TiXmlNode* xmlNode);

       bool isExpirationDate(){return this->expirationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getExpirationDate();
      std::string getExpirationDateIDRef(){return expirationDateIDRef_;}

       bool isExpirationDates(){return this->expirationDatesIsNull_;}
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> getExpirationDates();
      std::string getExpirationDatesIDRef(){return expirationDatesIDRef_;}

       bool isRelativeExpirationDates(){return this->relativeExpirationDatesIsNull_;}
       boost::shared_ptr<CommodityRelativeExpirationDates> getRelativeExpirationDates();
      std::string getRelativeExpirationDatesIDRef(){return relativeExpirationDatesIDRef_;}

       bool isExpirationTime(){return this->expirationTimeIsNull_;}
       boost::shared_ptr<PrevailingTime> getExpirationTime();
      std::string getExpirationTimeIDRef(){return expirationTimeIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!expirationDateIsNull_){
                count += 1;
                str = "expirationDate" ;
           }
           if(!expirationDatesIsNull_){
                count += 1;
                str = "expirationDates" ;
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
         boost::shared_ptr<AdjustableOrRelativeDate> expirationDate_;     //choice
       std::string expirationDateIDRef_;
       bool expirationDateIsNull_;
         boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> expirationDates_;     //choice
       std::string expirationDatesIDRef_;
       bool expirationDatesIsNull_;
         boost::shared_ptr<CommodityRelativeExpirationDates> relativeExpirationDates_;     //choice
       std::string relativeExpirationDatesIDRef_;
       bool relativeExpirationDatesIsNull_;
       boost::shared_ptr<PrevailingTime> expirationTime_;
       std::string expirationTimeIDRef_;
       bool expirationTimeIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

