// ExercisePeriod.hpp 
#ifndef FpmlSerialized_ExercisePeriod_hpp
#define FpmlSerialized_ExercisePeriod_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Period.hpp>

namespace FpmlSerialized {

class ExercisePeriod : public ISerialized { 
   public: 
       ExercisePeriod(TiXmlNode* xmlNode);

       bool isEarliestExerciseDateTenor(){return this->earliestExerciseDateTenorIsNull_;}
       boost::shared_ptr<Period> getEarliestExerciseDateTenor();
      std::string getEarliestExerciseDateTenorIDRef(){return earliestExerciseDateTenorIDRef_;}

       bool isExerciseFrequency(){return this->exerciseFrequencyIsNull_;}
       boost::shared_ptr<Period> getExerciseFrequency();
      std::string getExerciseFrequencyIDRef(){return exerciseFrequencyIDRef_;}

   protected: 
       boost::shared_ptr<Period> earliestExerciseDateTenor_;
       std::string earliestExerciseDateTenorIDRef_;
       bool earliestExerciseDateTenorIsNull_;
       boost::shared_ptr<Period> exerciseFrequency_;
       std::string exerciseFrequencyIDRef_;
       bool exerciseFrequencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

