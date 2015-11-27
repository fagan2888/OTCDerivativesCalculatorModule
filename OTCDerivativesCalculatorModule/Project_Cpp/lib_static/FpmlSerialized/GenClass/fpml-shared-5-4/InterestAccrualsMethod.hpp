// InterestAccrualsMethod.hpp 
#ifndef FpmlSerialized_InterestAccrualsMethod_hpp
#define FpmlSerialized_InterestAccrualsMethod_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/FloatingRateCalculation.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class InterestAccrualsMethod : public ISerialized { 
   public: 
       InterestAccrualsMethod(TiXmlNode* xmlNode);

       bool isFloatingRateCalculation(){return this->floatingRateCalculationIsNull_;}
       boost::shared_ptr<FloatingRateCalculation> getFloatingRateCalculation();
      std::string getFloatingRateCalculationIDRef(){return floatingRateCalculationIDRef_;}

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getFixedRate();
      std::string getFixedRateIDRef(){return fixedRateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!floatingRateCalculationIsNull_){
                count += 1;
                str = "floatingRateCalculation" ;
           }
           if(!fixedRateIsNull_){
                count += 1;
                str = "fixedRate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<FloatingRateCalculation> floatingRateCalculation_;     //choice
       std::string floatingRateCalculationIDRef_;
       bool floatingRateCalculationIsNull_;
         boost::shared_ptr<XsdTypeDecimal> fixedRate_;     //choice
       std::string fixedRateIDRef_;
       bool fixedRateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

