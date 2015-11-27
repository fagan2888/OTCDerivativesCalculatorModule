// DerivativeCalculationProcedure.hpp 
#ifndef FpmlSerialized_DerivativeCalculationProcedure_hpp
#define FpmlSerialized_DerivativeCalculationProcedure_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/DerivativeCalculationMethod.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-riskdef-5-4/PerturbationType.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/PricingStructureReference.hpp>

namespace FpmlSerialized {

class DerivativeCalculationProcedure : public ISerialized { 
   public: 
       DerivativeCalculationProcedure(TiXmlNode* xmlNode);

       bool isMethod(){return this->methodIsNull_;}
       boost::shared_ptr<DerivativeCalculationMethod> getMethod();
      std::string getMethodIDRef(){return methodIDRef_;}

       bool isPerturbationAmount(){return this->perturbationAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPerturbationAmount();
      std::string getPerturbationAmountIDRef(){return perturbationAmountIDRef_;}

       bool isAveraged(){return this->averagedIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAveraged();
      std::string getAveragedIDRef(){return averagedIDRef_;}

       bool isPerturbationType(){return this->perturbationTypeIsNull_;}
       boost::shared_ptr<PerturbationType> getPerturbationType();
      std::string getPerturbationTypeIDRef(){return perturbationTypeIDRef_;}

       bool isDerivativeFormula(){return this->derivativeFormulaIsNull_;}
       boost::shared_ptr<XsdTypeString> getDerivativeFormula();
      std::string getDerivativeFormulaIDRef(){return derivativeFormulaIDRef_;}

       bool isReplacementMarketInput(){return this->replacementMarketInputIsNull_;}
       boost::shared_ptr<PricingStructureReference> getReplacementMarketInput();
      std::string getReplacementMarketInputIDRef(){return replacementMarketInputIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!perturbationAmountIsNull_){
                count += 1;
                str = "perturbationAmount" ;
           }
           if(!averagedIsNull_){
                count += 1;
                str = "averaged" ;
           }
           if(!perturbationTypeIsNull_){
                count += 1;
                str = "perturbationType" ;
           }
           if(!derivativeFormulaIsNull_){
                count += 1;
                str = "derivativeFormula" ;
           }
           if(!replacementMarketInputIsNull_){
                count += 1;
                str = "replacementMarketInput" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<DerivativeCalculationMethod> method_;
       std::string methodIDRef_;
       bool methodIsNull_;
         boost::shared_ptr<XsdTypeDecimal> perturbationAmount_;     //choice
       std::string perturbationAmountIDRef_;
       bool perturbationAmountIsNull_;
         boost::shared_ptr<XsdTypeBoolean> averaged_;     //choice
       std::string averagedIDRef_;
       bool averagedIsNull_;
         boost::shared_ptr<PerturbationType> perturbationType_;     //choice
       std::string perturbationTypeIDRef_;
       bool perturbationTypeIsNull_;
         boost::shared_ptr<XsdTypeString> derivativeFormula_;     //choice
       std::string derivativeFormulaIDRef_;
       bool derivativeFormulaIsNull_;
         boost::shared_ptr<PricingStructureReference> replacementMarketInput_;     //choice
       std::string replacementMarketInputIDRef_;
       bool replacementMarketInputIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

