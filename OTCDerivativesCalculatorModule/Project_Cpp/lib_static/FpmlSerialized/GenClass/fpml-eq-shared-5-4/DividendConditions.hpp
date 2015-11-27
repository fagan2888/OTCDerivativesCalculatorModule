// DividendConditions.hpp 
#ifndef FpmlSerialized_DividendConditions_hpp
#define FpmlSerialized_DividendConditions_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/DividendEntitlementEnum.hpp>
#include <fpml-enum-5-4/DividendAmountTypeEnum.hpp>
#include <fpml-eq-shared-5-4/DividendPaymentDate.hpp>
#include <fpml-shared-5-4/DateReference.hpp>
#include <fpml-enum-5-4/DividendPeriodEnum.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/IdentifiedCurrency.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>
#include <fpml-shared-5-4/IdentifiedCurrencyReference.hpp>
#include <fpml-shared-5-4/InterestAccrualsCompoundingMethod.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>
#include <fpml-enum-5-4/NonCashDividendTreatmentEnum.hpp>
#include <fpml-enum-5-4/DividendCompositionEnum.hpp>

namespace FpmlSerialized {

class DividendConditions : public ISerialized { 
   public: 
       DividendConditions(TiXmlNode* xmlNode);

       bool isDividendReinvestment(){return this->dividendReinvestmentIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDividendReinvestment();
      std::string getDividendReinvestmentIDRef(){return dividendReinvestmentIDRef_;}

       bool isDividendEntitlement(){return this->dividendEntitlementIsNull_;}
       boost::shared_ptr<DividendEntitlementEnum> getDividendEntitlement();
      std::string getDividendEntitlementIDRef(){return dividendEntitlementIDRef_;}

       bool isDividendAmount(){return this->dividendAmountIsNull_;}
       boost::shared_ptr<DividendAmountTypeEnum> getDividendAmount();
      std::string getDividendAmountIDRef(){return dividendAmountIDRef_;}

       bool isDividendPaymentDate(){return this->dividendPaymentDateIsNull_;}
       boost::shared_ptr<DividendPaymentDate> getDividendPaymentDate();
      std::string getDividendPaymentDateIDRef(){return dividendPaymentDateIDRef_;}

       bool isDividendPeriodEffectiveDate(){return this->dividendPeriodEffectiveDateIsNull_;}
       boost::shared_ptr<DateReference> getDividendPeriodEffectiveDate();
      std::string getDividendPeriodEffectiveDateIDRef(){return dividendPeriodEffectiveDateIDRef_;}

       bool isDividendPeriodEndDate(){return this->dividendPeriodEndDateIsNull_;}
       boost::shared_ptr<DateReference> getDividendPeriodEndDate();
      std::string getDividendPeriodEndDateIDRef(){return dividendPeriodEndDateIDRef_;}

       bool isDividendPeriod(){return this->dividendPeriodIsNull_;}
       boost::shared_ptr<DividendPeriodEnum> getDividendPeriod();
      std::string getDividendPeriodIDRef(){return dividendPeriodIDRef_;}

       bool isExtraOrdinaryDividends(){return this->extraOrdinaryDividendsIsNull_;}
       boost::shared_ptr<PartyReference> getExtraOrdinaryDividends();
      std::string getExtraOrdinaryDividendsIDRef(){return extraOrdinaryDividendsIDRef_;}

       bool isExcessDividendAmount(){return this->excessDividendAmountIsNull_;}
       boost::shared_ptr<DividendAmountTypeEnum> getExcessDividendAmount();
      std::string getExcessDividendAmountIDRef(){return excessDividendAmountIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<IdentifiedCurrency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isDeterminationMethod(){return this->determinationMethodIsNull_;}
       boost::shared_ptr<DeterminationMethod> getDeterminationMethod();
      std::string getDeterminationMethodIDRef(){return determinationMethodIDRef_;}

       bool isCurrencyReference(){return this->currencyReferenceIsNull_;}
       boost::shared_ptr<IdentifiedCurrencyReference> getCurrencyReference();
      std::string getCurrencyReferenceIDRef(){return currencyReferenceIDRef_;}

       bool isDividendFxTriggerDate(){return this->dividendFxTriggerDateIsNull_;}
       boost::shared_ptr<DividendPaymentDate> getDividendFxTriggerDate();
      std::string getDividendFxTriggerDateIDRef(){return dividendFxTriggerDateIDRef_;}

       bool isInterestAccrualsMethod(){return this->interestAccrualsMethodIsNull_;}
       boost::shared_ptr<InterestAccrualsCompoundingMethod> getInterestAccrualsMethod();
      std::string getInterestAccrualsMethodIDRef(){return interestAccrualsMethodIDRef_;}

       bool isNumberOfIndexUnits(){return this->numberOfIndexUnitsIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getNumberOfIndexUnits();
      std::string getNumberOfIndexUnitsIDRef(){return numberOfIndexUnitsIDRef_;}

       bool isDeclaredCashDividendPercentage(){return this->declaredCashDividendPercentageIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getDeclaredCashDividendPercentage();
      std::string getDeclaredCashDividendPercentageIDRef(){return declaredCashDividendPercentageIDRef_;}

       bool isDeclaredCashEquivalentDividendPercentage(){return this->declaredCashEquivalentDividendPercentageIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getDeclaredCashEquivalentDividendPercentage();
      std::string getDeclaredCashEquivalentDividendPercentageIDRef(){return declaredCashEquivalentDividendPercentageIDRef_;}

       bool isNonCashDividendTreatment(){return this->nonCashDividendTreatmentIsNull_;}
       boost::shared_ptr<NonCashDividendTreatmentEnum> getNonCashDividendTreatment();
      std::string getNonCashDividendTreatmentIDRef(){return nonCashDividendTreatmentIDRef_;}

       bool isDividendComposition(){return this->dividendCompositionIsNull_;}
       boost::shared_ptr<DividendCompositionEnum> getDividendComposition();
      std::string getDividendCompositionIDRef(){return dividendCompositionIDRef_;}

       bool isSpecialDividends(){return this->specialDividendsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSpecialDividends();
      std::string getSpecialDividendsIDRef(){return specialDividendsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!dividendPeriodEffectiveDateIsNull_){
                count += 1;
                str = "dividendPeriodEffectiveDate" ;
           }
           if(!dividendPeriodEndDateIsNull_){
                count += 1;
                str = "dividendPeriodEndDate" ;
           }
           if(!dividendPeriodIsNull_){
                count += 1;
                str = "dividendPeriod" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
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
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
       boost::shared_ptr<XsdTypeBoolean> dividendReinvestment_;
       std::string dividendReinvestmentIDRef_;
       bool dividendReinvestmentIsNull_;
       boost::shared_ptr<DividendEntitlementEnum> dividendEntitlement_;
       std::string dividendEntitlementIDRef_;
       bool dividendEntitlementIsNull_;
       boost::shared_ptr<DividendAmountTypeEnum> dividendAmount_;
       std::string dividendAmountIDRef_;
       bool dividendAmountIsNull_;
       boost::shared_ptr<DividendPaymentDate> dividendPaymentDate_;
       std::string dividendPaymentDateIDRef_;
       bool dividendPaymentDateIsNull_;
         boost::shared_ptr<DateReference> dividendPeriodEffectiveDate_;     //choice
       std::string dividendPeriodEffectiveDateIDRef_;
       bool dividendPeriodEffectiveDateIsNull_;
         boost::shared_ptr<DateReference> dividendPeriodEndDate_;     //choice
       std::string dividendPeriodEndDateIDRef_;
       bool dividendPeriodEndDateIsNull_;
         boost::shared_ptr<DividendPeriodEnum> dividendPeriod_;     //choice
       std::string dividendPeriodIDRef_;
       bool dividendPeriodIsNull_;
       boost::shared_ptr<PartyReference> extraOrdinaryDividends_;
       std::string extraOrdinaryDividendsIDRef_;
       bool extraOrdinaryDividendsIsNull_;
       boost::shared_ptr<DividendAmountTypeEnum> excessDividendAmount_;
       std::string excessDividendAmountIDRef_;
       bool excessDividendAmountIsNull_;
         boost::shared_ptr<IdentifiedCurrency> currency_;     //choice
       std::string currencyIDRef_;
       bool currencyIsNull_;
         boost::shared_ptr<DeterminationMethod> determinationMethod_;     //choice
       std::string determinationMethodIDRef_;
       bool determinationMethodIsNull_;
         boost::shared_ptr<IdentifiedCurrencyReference> currencyReference_;     //choice
       std::string currencyReferenceIDRef_;
       bool currencyReferenceIsNull_;
       boost::shared_ptr<DividendPaymentDate> dividendFxTriggerDate_;
       std::string dividendFxTriggerDateIDRef_;
       bool dividendFxTriggerDateIsNull_;
       boost::shared_ptr<InterestAccrualsCompoundingMethod> interestAccrualsMethod_;
       std::string interestAccrualsMethodIDRef_;
       bool interestAccrualsMethodIsNull_;
       boost::shared_ptr<NonNegativeDecimal> numberOfIndexUnits_;
       std::string numberOfIndexUnitsIDRef_;
       bool numberOfIndexUnitsIsNull_;
       boost::shared_ptr<NonNegativeDecimal> declaredCashDividendPercentage_;
       std::string declaredCashDividendPercentageIDRef_;
       bool declaredCashDividendPercentageIsNull_;
       boost::shared_ptr<NonNegativeDecimal> declaredCashEquivalentDividendPercentage_;
       std::string declaredCashEquivalentDividendPercentageIDRef_;
       bool declaredCashEquivalentDividendPercentageIsNull_;
       boost::shared_ptr<NonCashDividendTreatmentEnum> nonCashDividendTreatment_;
       std::string nonCashDividendTreatmentIDRef_;
       bool nonCashDividendTreatmentIsNull_;
       boost::shared_ptr<DividendCompositionEnum> dividendComposition_;
       std::string dividendCompositionIDRef_;
       bool dividendCompositionIsNull_;
       boost::shared_ptr<XsdTypeBoolean> specialDividends_;
       std::string specialDividendsIDRef_;
       bool specialDividendsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

