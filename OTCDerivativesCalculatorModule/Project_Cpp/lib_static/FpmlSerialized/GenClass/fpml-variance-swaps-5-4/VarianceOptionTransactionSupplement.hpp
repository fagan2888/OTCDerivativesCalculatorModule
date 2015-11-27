// VarianceOptionTransactionSupplement.hpp 
#ifndef FpmlSerialized_VarianceOptionTransactionSupplement_hpp
#define FpmlSerialized_VarianceOptionTransactionSupplement_hpp

#include <fpml-option-shared-5-4/OptionBase.hpp>
#include <fpml-eq-shared-5-4/EquityPremium.hpp>
#include <fpml-eqd-5-4/EquityExerciseValuationSettlement.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/MethodOfAdjustmentEnum.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-variance-swaps-5-4/VarianceSwapTransactionSupplement.hpp>

namespace FpmlSerialized {

class VarianceOptionTransactionSupplement : public OptionBase { 
   public: 
       VarianceOptionTransactionSupplement(TiXmlNode* xmlNode);

       bool isEquityPremium(){return this->equityPremiumIsNull_;}
       boost::shared_ptr<EquityPremium> getEquityPremium();
      std::string getEquityPremiumIDRef(){return equityPremiumIDRef_;}

       bool isEquityExercise(){return this->equityExerciseIsNull_;}
       boost::shared_ptr<EquityExerciseValuationSettlement> getEquityExercise();
      std::string getEquityExerciseIDRef(){return equityExerciseIDRef_;}

       bool isExchangeLookAlike(){return this->exchangeLookAlikeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getExchangeLookAlike();
      std::string getExchangeLookAlikeIDRef(){return exchangeLookAlikeIDRef_;}

       bool isMethodOfAdjustment(){return this->methodOfAdjustmentIsNull_;}
       boost::shared_ptr<MethodOfAdjustmentEnum> getMethodOfAdjustment();
      std::string getMethodOfAdjustmentIDRef(){return methodOfAdjustmentIDRef_;}

       bool isOptionEntitlement(){return this->optionEntitlementIsNull_;}
       boost::shared_ptr<PositiveDecimal> getOptionEntitlement();
      std::string getOptionEntitlementIDRef(){return optionEntitlementIDRef_;}

       bool isMultiplier(){return this->multiplierIsNull_;}
       boost::shared_ptr<PositiveDecimal> getMultiplier();
      std::string getMultiplierIDRef(){return multiplierIDRef_;}

       bool isVarianceSwapTransactionSupplement(){return this->varianceSwapTransactionSupplementIsNull_;}
       boost::shared_ptr<VarianceSwapTransactionSupplement> getVarianceSwapTransactionSupplement();
      std::string getVarianceSwapTransactionSupplementIDRef(){return varianceSwapTransactionSupplementIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!optionEntitlementIsNull_){
                count += 1;
                str = "optionEntitlement" ;
           }
           if(!multiplierIsNull_){
                count += 1;
                str = "multiplier" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<EquityPremium> equityPremium_;
       std::string equityPremiumIDRef_;
       bool equityPremiumIsNull_;
       boost::shared_ptr<EquityExerciseValuationSettlement> equityExercise_;
       std::string equityExerciseIDRef_;
       bool equityExerciseIsNull_;
       boost::shared_ptr<XsdTypeBoolean> exchangeLookAlike_;
       std::string exchangeLookAlikeIDRef_;
       bool exchangeLookAlikeIsNull_;
       boost::shared_ptr<MethodOfAdjustmentEnum> methodOfAdjustment_;
       std::string methodOfAdjustmentIDRef_;
       bool methodOfAdjustmentIsNull_;
         boost::shared_ptr<PositiveDecimal> optionEntitlement_;     //choice
       std::string optionEntitlementIDRef_;
       bool optionEntitlementIsNull_;
         boost::shared_ptr<PositiveDecimal> multiplier_;     //choice
       std::string multiplierIDRef_;
       bool multiplierIsNull_;
       boost::shared_ptr<VarianceSwapTransactionSupplement> varianceSwapTransactionSupplement_;
       std::string varianceSwapTransactionSupplementIDRef_;
       bool varianceSwapTransactionSupplementIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

