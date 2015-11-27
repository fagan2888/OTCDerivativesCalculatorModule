// PricingParameterDerivative.hpp 
#ifndef FpmlSerialized_PricingParameterDerivative_hpp
#define FpmlSerialized_PricingParameterDerivative_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-riskdef-5-4/AssetOrTermPointOrPricingStructureReference.hpp>
#include <fpml-riskdef-5-4/ValuationReference.hpp>
#include <fpml-riskdef-5-4/DerivativeCalculationProcedure.hpp>

namespace FpmlSerialized {

class PricingParameterDerivative : public ISerialized { 
   public: 
       PricingParameterDerivative(TiXmlNode* xmlNode);

       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeString> getDescription();
      std::string getDescriptionIDRef(){return descriptionIDRef_;}

       bool isParameterReference(){return this->parameterReferenceIsNull_;}
       boost::shared_ptr<AssetOrTermPointOrPricingStructureReference> getParameterReference();
      std::string getParameterReferenceIDRef(){return parameterReferenceIDRef_;}

       bool isInputDateReference(){return this->inputDateReferenceIsNull_;}
       std::vector<boost::shared_ptr<ValuationReference>> getInputDateReference();
      std::string getInputDateReferenceIDRef(){return inputDateReferenceIDRef_;}

       bool isCalculationProcedure(){return this->calculationProcedureIsNull_;}
       boost::shared_ptr<DerivativeCalculationProcedure> getCalculationProcedure();
      std::string getCalculationProcedureIDRef(){return calculationProcedureIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!parameterReferenceIsNull_){
                count += 1;
                str = "parameterReference" ;
           }
           if(!inputDateReferenceIsNull_){
                count += 1;
                str = "inputDateReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeString> description_;
       std::string descriptionIDRef_;
       bool descriptionIsNull_;
         boost::shared_ptr<AssetOrTermPointOrPricingStructureReference> parameterReference_;     //choice
       std::string parameterReferenceIDRef_;
       bool parameterReferenceIsNull_;
         std::vector<boost::shared_ptr<ValuationReference>> inputDateReference_;     //choice
       std::string inputDateReferenceIDRef_;
       bool inputDateReferenceIsNull_;
       boost::shared_ptr<DerivativeCalculationProcedure> calculationProcedure_;
       std::string calculationProcedureIDRef_;
       bool calculationProcedureIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

