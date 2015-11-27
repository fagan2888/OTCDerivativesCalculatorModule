// EquityEuropeanExercise.hpp 
#ifndef FpmlSerialized_EquityEuropeanExercise_hpp
#define FpmlSerialized_EquityEuropeanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-enum-5-4/TimeTypeEnum.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>

namespace FpmlSerialized {

class EquityEuropeanExercise : public Exercise { 
   public: 
       EquityEuropeanExercise(TiXmlNode* xmlNode);

       bool isExpirationDate(){return this->expirationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getExpirationDate();
      std::string getExpirationDateIDRef(){return expirationDateIDRef_;}

       bool isEquityExpirationTimeType(){return this->equityExpirationTimeTypeIsNull_;}
       boost::shared_ptr<TimeTypeEnum> getEquityExpirationTimeType();
      std::string getEquityExpirationTimeTypeIDRef(){return equityExpirationTimeTypeIDRef_;}

       bool isEquityExpirationTime(){return this->equityExpirationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getEquityExpirationTime();
      std::string getEquityExpirationTimeIDRef(){return equityExpirationTimeIDRef_;}

       bool isExpirationTimeDetermination(){return this->expirationTimeDeterminationIsNull_;}
       boost::shared_ptr<DeterminationMethod> getExpirationTimeDetermination();
      std::string getExpirationTimeDeterminationIDRef(){return expirationTimeDeterminationIDRef_;}

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
       boost::shared_ptr<AdjustableOrRelativeDate> expirationDate_;
       std::string expirationDateIDRef_;
       bool expirationDateIsNull_;
         boost::shared_ptr<TimeTypeEnum> equityExpirationTimeType_;     //choice
       std::string equityExpirationTimeTypeIDRef_;
       bool equityExpirationTimeTypeIsNull_;
         boost::shared_ptr<BusinessCenterTime> equityExpirationTime_;     //choice
       std::string equityExpirationTimeIDRef_;
       bool equityExpirationTimeIsNull_;
         boost::shared_ptr<DeterminationMethod> expirationTimeDetermination_;     //choice
       std::string expirationTimeDeterminationIDRef_;
       bool expirationTimeDeterminationIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

