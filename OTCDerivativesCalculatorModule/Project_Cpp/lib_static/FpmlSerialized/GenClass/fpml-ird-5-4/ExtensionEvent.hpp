// ExtensionEvent.hpp 
#ifndef FpmlSerialized_ExtensionEvent_hpp
#define FpmlSerialized_ExtensionEvent_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class ExtensionEvent : public ISerialized { 
   public: 
       ExtensionEvent(TiXmlNode* xmlNode);

       bool isAdjustedExerciseDate(){return this->adjustedExerciseDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedExerciseDate();
      std::string getAdjustedExerciseDateIDRef(){return adjustedExerciseDateIDRef_;}

       bool isAdjustedExtendedTerminationDate(){return this->adjustedExtendedTerminationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedExtendedTerminationDate();
      std::string getAdjustedExtendedTerminationDateIDRef(){return adjustedExtendedTerminationDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> adjustedExerciseDate_;
       std::string adjustedExerciseDateIDRef_;
       bool adjustedExerciseDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedExtendedTerminationDate_;
       std::string adjustedExtendedTerminationDateIDRef_;
       bool adjustedExtendedTerminationDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

