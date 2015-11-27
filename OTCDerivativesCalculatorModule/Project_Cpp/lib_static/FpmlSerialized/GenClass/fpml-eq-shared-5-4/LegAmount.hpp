// LegAmount.hpp 
#ifndef FpmlSerialized_LegAmount_hpp
#define FpmlSerialized_LegAmount_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/IdentifiedCurrency.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>
#include <fpml-shared-5-4/IdentifiedCurrencyReference.hpp>
#include <fpml-shared-5-4/ReferenceAmount.hpp>
#include <fpml-shared-5-4/Formula.hpp>
#include <built_in_type/XsdTypeBase64Binary.hpp>
#include <fpml-shared-5-4/AdjustableRelativeOrPeriodicDates.hpp>

namespace FpmlSerialized {

class LegAmount : public ISerialized { 
   public: 
       LegAmount(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<IdentifiedCurrency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isDeterminationMethod(){return this->determinationMethodIsNull_;}
       boost::shared_ptr<DeterminationMethod> getDeterminationMethod();
      std::string getDeterminationMethodIDRef(){return determinationMethodIDRef_;}

       bool isCurrencyReference(){return this->currencyReferenceIsNull_;}
       boost::shared_ptr<IdentifiedCurrencyReference> getCurrencyReference();
      std::string getCurrencyReferenceIDRef(){return currencyReferenceIDRef_;}

       bool isReferenceAmount(){return this->referenceAmountIsNull_;}
       boost::shared_ptr<ReferenceAmount> getReferenceAmount();
      std::string getReferenceAmountIDRef(){return referenceAmountIDRef_;}

       bool isFormula(){return this->formulaIsNull_;}
       boost::shared_ptr<Formula> getFormula();
      std::string getFormulaIDRef(){return formulaIDRef_;}

       bool isEncodedDescription(){return this->encodedDescriptionIsNull_;}
       boost::shared_ptr<XsdTypeBase64Binary> getEncodedDescription();
      std::string getEncodedDescriptionIDRef(){return encodedDescriptionIDRef_;}

       bool isCalculationDates(){return this->calculationDatesIsNull_;}
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates> getCalculationDates();
      std::string getCalculationDatesIDRef(){return calculationDatesIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!currencyIsNull_){
                count += 1;
                str = "currency" ;
           }
           if(!determinationMethodIsNull_){
                count += 1;
                str = "determinationMethod" ;
           }
           if(!currencyReferenceIsNull_){
                count += 1;
                str = "currencyReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!referenceAmountIsNull_){
                count += 1;
                str = "referenceAmount" ;
           }
           if(!formulaIsNull_){
                count += 1;
                str = "formula" ;
           }
           if(!encodedDescriptionIsNull_){
                count += 1;
                str = "encodedDescription" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<IdentifiedCurrency> currency_;     //choice
       std::string currencyIDRef_;
       bool currencyIsNull_;
         boost::shared_ptr<DeterminationMethod> determinationMethod_;     //choice
       std::string determinationMethodIDRef_;
       bool determinationMethodIsNull_;
         boost::shared_ptr<IdentifiedCurrencyReference> currencyReference_;     //choice
       std::string currencyReferenceIDRef_;
       bool currencyReferenceIsNull_;
         boost::shared_ptr<ReferenceAmount> referenceAmount_;     //choice
       std::string referenceAmountIDRef_;
       bool referenceAmountIsNull_;
         boost::shared_ptr<Formula> formula_;     //choice
       std::string formulaIDRef_;
       bool formulaIsNull_;
         boost::shared_ptr<XsdTypeBase64Binary> encodedDescription_;     //choice
       std::string encodedDescriptionIDRef_;
       bool encodedDescriptionIsNull_;
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates> calculationDates_;
       std::string calculationDatesIDRef_;
       bool calculationDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

