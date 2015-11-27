// AutomaticExercise.hpp 
#ifndef FpmlSerialized_AutomaticExercise_hpp
#define FpmlSerialized_AutomaticExercise_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class AutomaticExercise : public ISerialized { 
   public: 
       AutomaticExercise(TiXmlNode* xmlNode);

       bool isThresholdRate(){return this->thresholdRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getThresholdRate();
      std::string getThresholdRateIDRef(){return thresholdRateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> thresholdRate_;
       std::string thresholdRateIDRef_;
       bool thresholdRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

