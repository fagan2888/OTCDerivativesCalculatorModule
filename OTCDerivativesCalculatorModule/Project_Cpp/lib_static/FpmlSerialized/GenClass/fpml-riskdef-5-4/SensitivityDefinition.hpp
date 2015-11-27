// SensitivityDefinition.hpp 
#ifndef FpmlSerialized_SensitivityDefinition_hpp
#define FpmlSerialized_SensitivityDefinition_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-riskdef-5-4/ValuationScenarioReference.hpp>
#include <fpml-riskdef-5-4/PricingParameterDerivative.hpp>
#include <fpml-riskdef-5-4/DerivativeFormula.hpp>
#include <fpml-riskdef-5-4/TimeDimension.hpp>
#include <fpml-riskdef-5-4/PricingDataPointCoordinate.hpp>
#include <fpml-riskdef-5-4/PricingDataPointCoordinateReference.hpp>

namespace FpmlSerialized {

class SensitivityDefinition : public ISerialized { 
   public: 
       SensitivityDefinition(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isValuationScenarioReference(){return this->valuationScenarioReferenceIsNull_;}
       boost::shared_ptr<ValuationScenarioReference> getValuationScenarioReference();
      std::string getValuationScenarioReferenceIDRef(){return valuationScenarioReferenceIDRef_;}

       bool isPartialDerivative(){return this->partialDerivativeIsNull_;}
       std::vector<boost::shared_ptr<PricingParameterDerivative>> getPartialDerivative();
      std::string getPartialDerivativeIDRef(){return partialDerivativeIDRef_;}

       bool isFormula(){return this->formulaIsNull_;}
       boost::shared_ptr<DerivativeFormula> getFormula();
      std::string getFormulaIDRef(){return formulaIDRef_;}

       bool isTerm(){return this->termIsNull_;}
       boost::shared_ptr<TimeDimension> getTerm();
      std::string getTermIDRef(){return termIDRef_;}

       bool isCoordinate(){return this->coordinateIsNull_;}
       boost::shared_ptr<PricingDataPointCoordinate> getCoordinate();
      std::string getCoordinateIDRef(){return coordinateIDRef_;}

       bool isCoordinateReference(){return this->coordinateReferenceIsNull_;}
       boost::shared_ptr<PricingDataPointCoordinateReference> getCoordinateReference();
      std::string getCoordinateReferenceIDRef(){return coordinateReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!partialDerivativeIsNull_){
                count += 1;
                str = "partialDerivative" ;
           }
           if(!formulaIsNull_){
                count += 1;
                str = "formula" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!termIsNull_){
                count += 1;
                str = "term" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!coordinateIsNull_){
                count += 1;
                str = "coordinate" ;
           }
           if(!coordinateReferenceIsNull_){
                count += 1;
                str = "coordinateReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
   protected: 
       boost::shared_ptr<XsdTypeString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<ValuationScenarioReference> valuationScenarioReference_;
       std::string valuationScenarioReferenceIDRef_;
       bool valuationScenarioReferenceIsNull_;
         std::vector<boost::shared_ptr<PricingParameterDerivative>> partialDerivative_;     //choice
       std::string partialDerivativeIDRef_;
       bool partialDerivativeIsNull_;
         boost::shared_ptr<DerivativeFormula> formula_;     //choice
       std::string formulaIDRef_;
       bool formulaIsNull_;
         boost::shared_ptr<TimeDimension> term_;     //choice
       std::string termIDRef_;
       bool termIsNull_;
         boost::shared_ptr<PricingDataPointCoordinate> coordinate_;     //choice
       std::string coordinateIDRef_;
       bool coordinateIsNull_;
         boost::shared_ptr<PricingDataPointCoordinateReference> coordinateReference_;     //choice
       std::string coordinateReferenceIDRef_;
       bool coordinateReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;

};

} //namespaceFpmlSerialized end
#endif

