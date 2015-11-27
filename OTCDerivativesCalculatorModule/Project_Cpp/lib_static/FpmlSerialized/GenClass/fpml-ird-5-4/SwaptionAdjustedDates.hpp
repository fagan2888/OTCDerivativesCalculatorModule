// SwaptionAdjustedDates.hpp 
#ifndef FpmlSerialized_SwaptionAdjustedDates_hpp
#define FpmlSerialized_SwaptionAdjustedDates_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/ExerciseEvent.hpp>

namespace FpmlSerialized {

class SwaptionAdjustedDates : public ISerialized { 
   public: 
       SwaptionAdjustedDates(TiXmlNode* xmlNode);

       bool isExerciseEvent(){return this->exerciseEventIsNull_;}
       std::vector<boost::shared_ptr<ExerciseEvent>> getExerciseEvent();
      std::string getExerciseEventIDRef(){return exerciseEventIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ExerciseEvent>> exerciseEvent_;
       std::string exerciseEventIDRef_;
       bool exerciseEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

