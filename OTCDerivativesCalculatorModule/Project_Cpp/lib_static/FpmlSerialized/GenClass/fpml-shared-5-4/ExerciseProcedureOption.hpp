// ExerciseProcedureOption.hpp 
#ifndef FpmlSerialized_ExerciseProcedureOption_hpp
#define FpmlSerialized_ExerciseProcedureOption_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Empty.hpp>

namespace FpmlSerialized {

class ExerciseProcedureOption : public ISerialized { 
   public: 
       ExerciseProcedureOption(TiXmlNode* xmlNode);

       bool isManualExercise(){return this->manualExerciseIsNull_;}
       boost::shared_ptr<Empty> getManualExercise();
      std::string getManualExerciseIDRef(){return manualExerciseIDRef_;}

       bool isAutomaticExercise(){return this->automaticExerciseIsNull_;}
       boost::shared_ptr<Empty> getAutomaticExercise();
      std::string getAutomaticExerciseIDRef(){return automaticExerciseIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!manualExerciseIsNull_){
                count += 1;
                str = "manualExercise" ;
           }
           if(!automaticExerciseIsNull_){
                count += 1;
                str = "automaticExercise" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<Empty> manualExercise_;     //choice
       std::string manualExerciseIDRef_;
       bool manualExerciseIsNull_;
         boost::shared_ptr<Empty> automaticExercise_;     //choice
       std::string automaticExerciseIDRef_;
       bool automaticExerciseIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

