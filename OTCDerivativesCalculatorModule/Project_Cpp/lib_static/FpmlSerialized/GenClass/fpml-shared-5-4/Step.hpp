// Step.hpp 
#ifndef FpmlSerialized_Step_hpp
#define FpmlSerialized_Step_hpp

#include <fpml-shared-5-4/StepBase.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class Step : public StepBase { 
   public: 
       Step(TiXmlNode* xmlNode);

       bool isStepValue(){return this->stepValueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStepValue();
      std::string getStepValueIDRef(){return stepValueIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> stepValue_;
       std::string stepValueIDRef_;
       bool stepValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

