// NonNegativeStep.hpp 
#ifndef FpmlSerialized_NonNegativeStep_hpp
#define FpmlSerialized_NonNegativeStep_hpp

#include <fpml-shared-5-4/StepBase.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>

namespace FpmlSerialized {

class NonNegativeStep : public StepBase { 
   public: 
       NonNegativeStep(TiXmlNode* xmlNode);

       bool isStepValue(){return this->stepValueIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getStepValue();
      std::string getStepValueIDRef(){return stepValueIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeDecimal> stepValue_;
       std::string stepValueIDRef_;
       bool stepValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

