// EquityMultipleExercise.hpp 
#ifndef FpmlSerialized_EquityMultipleExercise_hpp
#define FpmlSerialized_EquityMultipleExercise_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>

namespace FpmlSerialized {

class EquityMultipleExercise : public ISerialized { 
   public: 
       EquityMultipleExercise(TiXmlNode* xmlNode);

       bool isIntegralMultipleExercise(){return this->integralMultipleExerciseIsNull_;}
       boost::shared_ptr<PositiveDecimal> getIntegralMultipleExercise();
      std::string getIntegralMultipleExerciseIDRef(){return integralMultipleExerciseIDRef_;}

       bool isMinimumNumberOfOptions(){return this->minimumNumberOfOptionsIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getMinimumNumberOfOptions();
      std::string getMinimumNumberOfOptionsIDRef(){return minimumNumberOfOptionsIDRef_;}

       bool isMaximumNumberOfOptions(){return this->maximumNumberOfOptionsIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getMaximumNumberOfOptions();
      std::string getMaximumNumberOfOptionsIDRef(){return maximumNumberOfOptionsIDRef_;}

   protected: 
       boost::shared_ptr<PositiveDecimal> integralMultipleExercise_;
       std::string integralMultipleExerciseIDRef_;
       bool integralMultipleExerciseIsNull_;
       boost::shared_ptr<NonNegativeDecimal> minimumNumberOfOptions_;
       std::string minimumNumberOfOptionsIDRef_;
       bool minimumNumberOfOptionsIsNull_;
       boost::shared_ptr<NonNegativeDecimal> maximumNumberOfOptions_;
       std::string maximumNumberOfOptionsIDRef_;
       bool maximumNumberOfOptionsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

