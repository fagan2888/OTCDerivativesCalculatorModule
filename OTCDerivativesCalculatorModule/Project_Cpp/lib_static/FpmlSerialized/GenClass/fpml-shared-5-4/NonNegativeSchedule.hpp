// NonNegativeSchedule.hpp 
#ifndef FpmlSerialized_NonNegativeSchedule_hpp
#define FpmlSerialized_NonNegativeSchedule_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>
#include <fpml-shared-5-4/NonNegativeStep.hpp>

namespace FpmlSerialized {

class NonNegativeSchedule : public ISerialized { 
   public: 
       NonNegativeSchedule(TiXmlNode* xmlNode);

       bool isInitialValue(){return this->initialValueIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getInitialValue();
      std::string getInitialValueIDRef(){return initialValueIDRef_;}

       bool isStep(){return this->stepIsNull_;}
       std::vector<boost::shared_ptr<NonNegativeStep>> getStep();
      std::string getStepIDRef(){return stepIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeDecimal> initialValue_;
       std::string initialValueIDRef_;
       bool initialValueIsNull_;
       std::vector<boost::shared_ptr<NonNegativeStep>> step_;
       std::string stepIDRef_;
       bool stepIsNull_;

};

} //namespaceFpmlSerialized end
#endif

