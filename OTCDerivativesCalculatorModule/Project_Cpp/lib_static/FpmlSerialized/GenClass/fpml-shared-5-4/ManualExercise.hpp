// ManualExercise.hpp 
#ifndef FpmlSerialized_ManualExercise_hpp
#define FpmlSerialized_ManualExercise_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/ExerciseNotice.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class ManualExercise : public ISerialized { 
   public: 
       ManualExercise(TiXmlNode* xmlNode);

       bool isExerciseNotice(){return this->exerciseNoticeIsNull_;}
       boost::shared_ptr<ExerciseNotice> getExerciseNotice();
      std::string getExerciseNoticeIDRef(){return exerciseNoticeIDRef_;}

       bool isFallbackExercise(){return this->fallbackExerciseIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFallbackExercise();
      std::string getFallbackExerciseIDRef(){return fallbackExerciseIDRef_;}

   protected: 
       boost::shared_ptr<ExerciseNotice> exerciseNotice_;
       std::string exerciseNoticeIDRef_;
       bool exerciseNoticeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> fallbackExercise_;
       std::string fallbackExerciseIDRef_;
       bool fallbackExerciseIsNull_;

};

} //namespaceFpmlSerialized end
#endif

