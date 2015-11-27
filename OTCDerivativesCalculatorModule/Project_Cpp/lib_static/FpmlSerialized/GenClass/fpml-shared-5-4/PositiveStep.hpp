// PositiveStep.hpp 
#ifndef FpmlSerialized_PositiveStep_hpp
#define FpmlSerialized_PositiveStep_hpp

#include <fpml-shared-5-4/StepBase.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>

namespace FpmlSerialized {

class PositiveStep : public StepBase { 
   public: 
       PositiveStep(TiXmlNode* xmlNode);

       bool isStepValue(){return this->stepValueIsNull_;}
       boost::shared_ptr<PositiveDecimal> getStepValue();
      std::string getStepValueIDRef(){return stepValueIDRef_;}

   protected: 
       boost::shared_ptr<PositiveDecimal> stepValue_;
       std::string stepValueIDRef_;
       bool stepValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

