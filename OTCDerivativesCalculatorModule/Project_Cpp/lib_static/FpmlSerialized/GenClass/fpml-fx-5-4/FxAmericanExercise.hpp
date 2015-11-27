// FxAmericanExercise.hpp 
#ifndef FpmlSerialized_FxAmericanExercise_hpp
#define FpmlSerialized_FxAmericanExercise_hpp

#include <fpml-fx-5-4/FxDigitalAmericanExercise.hpp>
#include <fpml-fx-5-4/FxMultipleExercise.hpp>

namespace FpmlSerialized {

class FxAmericanExercise : public FxDigitalAmericanExercise { 
   public: 
       FxAmericanExercise(TiXmlNode* xmlNode);

       bool isMultipleExercise(){return this->multipleExerciseIsNull_;}
       boost::shared_ptr<FxMultipleExercise> getMultipleExercise();
      std::string getMultipleExerciseIDRef(){return multipleExerciseIDRef_;}

   protected: 
       boost::shared_ptr<FxMultipleExercise> multipleExercise_;
       std::string multipleExerciseIDRef_;
       bool multipleExerciseIsNull_;

};

} //namespaceFpmlSerialized end
#endif

