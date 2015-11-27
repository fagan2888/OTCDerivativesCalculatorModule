// PositiveSchedule.hpp 
#ifndef FpmlSerialized_PositiveSchedule_hpp
#define FpmlSerialized_PositiveSchedule_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-shared-5-4/PositiveStep.hpp>

namespace FpmlSerialized {

class PositiveSchedule : public ISerialized { 
   public: 
       PositiveSchedule(TiXmlNode* xmlNode);

       bool isInitialValue(){return this->initialValueIsNull_;}
       boost::shared_ptr<PositiveDecimal> getInitialValue();
      std::string getInitialValueIDRef(){return initialValueIDRef_;}

       bool isStep(){return this->stepIsNull_;}
       std::vector<boost::shared_ptr<PositiveStep>> getStep();
      std::string getStepIDRef(){return stepIDRef_;}

   protected: 
       boost::shared_ptr<PositiveDecimal> initialValue_;
       std::string initialValueIDRef_;
       bool initialValueIsNull_;
       std::vector<boost::shared_ptr<PositiveStep>> step_;
       std::string stepIDRef_;
       bool stepIsNull_;

};

} //namespaceFpmlSerialized end
#endif

