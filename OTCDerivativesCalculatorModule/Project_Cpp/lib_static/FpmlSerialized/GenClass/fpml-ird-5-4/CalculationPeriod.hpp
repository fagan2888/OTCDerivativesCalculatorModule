// CalculationPeriod.hpp 
#ifndef FpmlSerialized_CalculationPeriod_hpp
#define FpmlSerialized_CalculationPeriod_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-ird-5-4/FxLinkedNotionalAmount.hpp>
#include <fpml-ird-5-4/FloatingRateDefinition.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class CalculationPeriod : public ISerialized { 
   public: 
       CalculationPeriod(TiXmlNode* xmlNode);

       bool isUnadjustedStartDate(){return this->unadjustedStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getUnadjustedStartDate();
      std::string getUnadjustedStartDateIDRef(){return unadjustedStartDateIDRef_;}

       bool isUnadjustedEndDate(){return this->unadjustedEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getUnadjustedEndDate();
      std::string getUnadjustedEndDateIDRef(){return unadjustedEndDateIDRef_;}

       bool isAdjustedStartDate(){return this->adjustedStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedStartDate();
      std::string getAdjustedStartDateIDRef(){return adjustedStartDateIDRef_;}

       bool isAdjustedEndDate(){return this->adjustedEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedEndDate();
      std::string getAdjustedEndDateIDRef(){return adjustedEndDateIDRef_;}

       bool isCalculationPeriodNumberOfDays(){return this->calculationPeriodNumberOfDaysIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getCalculationPeriodNumberOfDays();
      std::string getCalculationPeriodNumberOfDaysIDRef(){return calculationPeriodNumberOfDaysIDRef_;}

       bool isNotionalAmount(){return this->notionalAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNotionalAmount();
      std::string getNotionalAmountIDRef(){return notionalAmountIDRef_;}

       bool isFxLinkedNotionalAmount(){return this->fxLinkedNotionalAmountIsNull_;}
       boost::shared_ptr<FxLinkedNotionalAmount> getFxLinkedNotionalAmount();
      std::string getFxLinkedNotionalAmountIDRef(){return fxLinkedNotionalAmountIDRef_;}

       bool isFloatingRateDefinition(){return this->floatingRateDefinitionIsNull_;}
       boost::shared_ptr<FloatingRateDefinition> getFloatingRateDefinition();
      std::string getFloatingRateDefinitionIDRef(){return floatingRateDefinitionIDRef_;}

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getFixedRate();
      std::string getFixedRateIDRef(){return fixedRateIDRef_;}

       bool isDayCountYearFraction(){return this->dayCountYearFractionIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getDayCountYearFraction();
      std::string getDayCountYearFractionIDRef(){return dayCountYearFractionIDRef_;}

       bool isForecastAmount(){return this->forecastAmountIsNull_;}
       boost::shared_ptr<Money> getForecastAmount();
      std::string getForecastAmountIDRef(){return forecastAmountIDRef_;}

       bool isForecastRate(){return this->forecastRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getForecastRate();
      std::string getForecastRateIDRef(){return forecastRateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!notionalAmountIsNull_){
                count += 1;
                str = "notionalAmount" ;
           }
           if(!fxLinkedNotionalAmountIsNull_){
                count += 1;
                str = "fxLinkedNotionalAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!floatingRateDefinitionIsNull_){
                count += 1;
                str = "floatingRateDefinition" ;
           }
           if(!fixedRateIsNull_){
                count += 1;
                str = "fixedRate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
       boost::shared_ptr<XsdTypeDate> unadjustedStartDate_;
       std::string unadjustedStartDateIDRef_;
       bool unadjustedStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> unadjustedEndDate_;
       std::string unadjustedEndDateIDRef_;
       bool unadjustedEndDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedStartDate_;
       std::string adjustedStartDateIDRef_;
       bool adjustedStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedEndDate_;
       std::string adjustedEndDateIDRef_;
       bool adjustedEndDateIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> calculationPeriodNumberOfDays_;
       std::string calculationPeriodNumberOfDaysIDRef_;
       bool calculationPeriodNumberOfDaysIsNull_;
         boost::shared_ptr<XsdTypeDecimal> notionalAmount_;     //choice
       std::string notionalAmountIDRef_;
       bool notionalAmountIsNull_;
         boost::shared_ptr<FxLinkedNotionalAmount> fxLinkedNotionalAmount_;     //choice
       std::string fxLinkedNotionalAmountIDRef_;
       bool fxLinkedNotionalAmountIsNull_;
         boost::shared_ptr<FloatingRateDefinition> floatingRateDefinition_;     //choice
       std::string floatingRateDefinitionIDRef_;
       bool floatingRateDefinitionIsNull_;
         boost::shared_ptr<XsdTypeDecimal> fixedRate_;     //choice
       std::string fixedRateIDRef_;
       bool fixedRateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> dayCountYearFraction_;
       std::string dayCountYearFractionIDRef_;
       bool dayCountYearFractionIsNull_;
       boost::shared_ptr<Money> forecastAmount_;
       std::string forecastAmountIDRef_;
       bool forecastAmountIsNull_;
       boost::shared_ptr<XsdTypeDecimal> forecastRate_;
       std::string forecastRateIDRef_;
       bool forecastRateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

