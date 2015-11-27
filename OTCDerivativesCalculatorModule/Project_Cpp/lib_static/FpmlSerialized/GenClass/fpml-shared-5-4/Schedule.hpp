// Schedule.hpp 
#ifndef FpmlSerialized_Schedule_hpp
#define FpmlSerialized_Schedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Step.hpp>

namespace FpmlSerialized {

class Schedule : public ISerialized { 
   public: 
       Schedule(TiXmlNode* xmlNode);

       bool isInitialValue(){return this->initialValueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getInitialValue();
      std::string getInitialValueIDRef(){return initialValueIDRef_;}

       bool isStep(){return this->stepIsNull_;}
       std::vector<boost::shared_ptr<Step>> getStep();
      std::string getStepIDRef(){return stepIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> initialValue_;
       std::string initialValueIDRef_;
       bool initialValueIsNull_;
       std::vector<boost::shared_ptr<Step>> step_;
       std::string stepIDRef_;
       bool stepIsNull_;

};

} //namespaceFpmlSerialized end
#endif

