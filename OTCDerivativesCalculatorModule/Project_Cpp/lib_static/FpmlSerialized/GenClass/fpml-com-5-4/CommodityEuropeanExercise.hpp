// CommodityEuropeanExercise.hpp 
#ifndef FpmlSerialized_CommodityEuropeanExercise_hpp
#define FpmlSerialized_CommodityEuropeanExercise_hpp

#include <fpml-shared-5-4/Exercise.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/Frequency.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>

namespace FpmlSerialized {

class CommodityEuropeanExercise : public Exercise { 
   public: 
       CommodityEuropeanExercise(TiXmlNode* xmlNode);

       bool isExpirationDate(){return this->expirationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getExpirationDate();
      std::string getExpirationDateIDRef(){return expirationDateIDRef_;}

       bool isExerciseFrequency(){return this->exerciseFrequencyIsNull_;}
       boost::shared_ptr<Frequency> getExerciseFrequency();
      std::string getExerciseFrequencyIDRef(){return exerciseFrequencyIDRef_;}

       bool isExpirationTime(){return this->expirationTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getExpirationTime();
      std::string getExpirationTimeIDRef(){return expirationTimeIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> expirationDate_;
       std::string expirationDateIDRef_;
       bool expirationDateIsNull_;
       boost::shared_ptr<Frequency> exerciseFrequency_;
       std::string exerciseFrequencyIDRef_;
       bool exerciseFrequencyIsNull_;
       boost::shared_ptr<BusinessCenterTime> expirationTime_;
       std::string expirationTimeIDRef_;
       bool expirationTimeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

