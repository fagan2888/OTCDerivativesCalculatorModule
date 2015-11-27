// CalculationPeriodDates.hpp 
#ifndef FpmlSerialized_CalculationPeriodDates_hpp
#define FpmlSerialized_CalculationPeriodDates_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>
#include <fpml-shared-5-4/AdjustedRelativeDateOffset.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-enum-5-4/StubPeriodTypeEnum.hpp>
#include <fpml-shared-5-4/CalculationPeriodFrequency.hpp>

namespace FpmlSerialized {

class CalculationPeriodDates : public ISerialized { 
   public: 
       CalculationPeriodDates(TiXmlNode* xmlNode);

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isRelativeEffectiveDate(){return this->relativeEffectiveDateIsNull_;}
       boost::shared_ptr<AdjustedRelativeDateOffset> getRelativeEffectiveDate();
      std::string getRelativeEffectiveDateIDRef(){return relativeEffectiveDateIDRef_;}

       bool isTerminationDate(){return this->terminationDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getTerminationDate();
      std::string getTerminationDateIDRef(){return terminationDateIDRef_;}

       bool isRelativeTerminationDate(){return this->relativeTerminationDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getRelativeTerminationDate();
      std::string getRelativeTerminationDateIDRef(){return relativeTerminationDateIDRef_;}

       bool isCalculationPeriodDatesAdjustments(){return this->calculationPeriodDatesAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getCalculationPeriodDatesAdjustments();
      std::string getCalculationPeriodDatesAdjustmentsIDRef(){return calculationPeriodDatesAdjustmentsIDRef_;}

       bool isFirstPeriodStartDate(){return this->firstPeriodStartDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getFirstPeriodStartDate();
      std::string getFirstPeriodStartDateIDRef(){return firstPeriodStartDateIDRef_;}

       bool isFirstRegularPeriodStartDate(){return this->firstRegularPeriodStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFirstRegularPeriodStartDate();
      std::string getFirstRegularPeriodStartDateIDRef(){return firstRegularPeriodStartDateIDRef_;}

       bool isFirstCompoundingPeriodEndDate(){return this->firstCompoundingPeriodEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFirstCompoundingPeriodEndDate();
      std::string getFirstCompoundingPeriodEndDateIDRef(){return firstCompoundingPeriodEndDateIDRef_;}

       bool isLastRegularPeriodEndDate(){return this->lastRegularPeriodEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getLastRegularPeriodEndDate();
      std::string getLastRegularPeriodEndDateIDRef(){return lastRegularPeriodEndDateIDRef_;}

       bool isStubPeriodType(){return this->stubPeriodTypeIsNull_;}
       boost::shared_ptr<StubPeriodTypeEnum> getStubPeriodType();
      std::string getStubPeriodTypeIDRef(){return stubPeriodTypeIDRef_;}

       bool isCalculationPeriodFrequency(){return this->calculationPeriodFrequencyIsNull_;}
       boost::shared_ptr<CalculationPeriodFrequency> getCalculationPeriodFrequency();
      std::string getCalculationPeriodFrequencyIDRef(){return calculationPeriodFrequencyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!effectiveDateIsNull_){
                count += 1;
                str = "effectiveDate" ;
           }
           if(!relativeEffectiveDateIsNull_){
                count += 1;
                str = "relativeEffectiveDate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!terminationDateIsNull_){
                count += 1;
                str = "terminationDate" ;
           }
           if(!relativeTerminationDateIsNull_){
                count += 1;
                str = "relativeTerminationDate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<AdjustableDate> effectiveDate_;     //choice
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
         boost::shared_ptr<AdjustedRelativeDateOffset> relativeEffectiveDate_;     //choice
       std::string relativeEffectiveDateIDRef_;
       bool relativeEffectiveDateIsNull_;
         boost::shared_ptr<AdjustableDate> terminationDate_;     //choice
       std::string terminationDateIDRef_;
       bool terminationDateIsNull_;
         boost::shared_ptr<RelativeDateOffset> relativeTerminationDate_;     //choice
       std::string relativeTerminationDateIDRef_;
       bool relativeTerminationDateIsNull_;
       boost::shared_ptr<BusinessDayAdjustments> calculationPeriodDatesAdjustments_;
       std::string calculationPeriodDatesAdjustmentsIDRef_;
       bool calculationPeriodDatesAdjustmentsIsNull_;
       boost::shared_ptr<AdjustableDate> firstPeriodStartDate_;
       std::string firstPeriodStartDateIDRef_;
       bool firstPeriodStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> firstRegularPeriodStartDate_;
       std::string firstRegularPeriodStartDateIDRef_;
       bool firstRegularPeriodStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> firstCompoundingPeriodEndDate_;
       std::string firstCompoundingPeriodEndDateIDRef_;
       bool firstCompoundingPeriodEndDateIsNull_;
       boost::shared_ptr<XsdTypeDate> lastRegularPeriodEndDate_;
       std::string lastRegularPeriodEndDateIDRef_;
       bool lastRegularPeriodEndDateIsNull_;
       boost::shared_ptr<StubPeriodTypeEnum> stubPeriodType_;
       std::string stubPeriodTypeIDRef_;
       bool stubPeriodTypeIsNull_;
       boost::shared_ptr<CalculationPeriodFrequency> calculationPeriodFrequency_;
       std::string calculationPeriodFrequencyIDRef_;
       bool calculationPeriodFrequencyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

