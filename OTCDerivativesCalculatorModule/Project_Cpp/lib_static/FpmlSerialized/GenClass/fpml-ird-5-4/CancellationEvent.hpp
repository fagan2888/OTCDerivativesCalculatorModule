// CancellationEvent.hpp 
#ifndef FpmlSerialized_CancellationEvent_hpp
#define FpmlSerialized_CancellationEvent_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class CancellationEvent : public ISerialized { 
   public: 
       CancellationEvent(TiXmlNode* xmlNode);

       bool isAdjustedExerciseDate(){return this->adjustedExerciseDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedExerciseDate();
      std::string getAdjustedExerciseDateIDRef(){return adjustedExerciseDateIDRef_;}

       bool isAdjustedEarlyTerminationDate(){return this->adjustedEarlyTerminationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedEarlyTerminationDate();
      std::string getAdjustedEarlyTerminationDateIDRef(){return adjustedEarlyTerminationDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> adjustedExerciseDate_;
       std::string adjustedExerciseDateIDRef_;
       bool adjustedExerciseDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedEarlyTerminationDate_;
       std::string adjustedEarlyTerminationDateIDRef_;
       bool adjustedEarlyTerminationDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

