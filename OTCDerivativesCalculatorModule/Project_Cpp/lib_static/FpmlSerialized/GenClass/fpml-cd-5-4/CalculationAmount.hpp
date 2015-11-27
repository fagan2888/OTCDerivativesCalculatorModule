// CalculationAmount.hpp 
#ifndef FpmlSerialized_CalculationAmount_hpp
#define FpmlSerialized_CalculationAmount_hpp

#include <fpml-shared-5-4/Money.hpp>
#include <fpml-shared-5-4/Step.hpp>

namespace FpmlSerialized {

class CalculationAmount : public Money { 
   public: 
       CalculationAmount(TiXmlNode* xmlNode);

       bool isStep(){return this->stepIsNull_;}
       std::vector<boost::shared_ptr<Step>> getStep();
      std::string getStepIDRef(){return stepIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<Step>> step_;
       std::string stepIDRef_;
       bool stepIsNull_;

};

} //namespaceFpmlSerialized end
#endif

