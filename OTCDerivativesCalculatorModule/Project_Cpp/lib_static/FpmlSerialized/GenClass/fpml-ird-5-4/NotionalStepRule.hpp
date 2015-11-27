// NotionalStepRule.hpp 
#ifndef FpmlSerialized_NotionalStepRule_hpp
#define FpmlSerialized_NotionalStepRule_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/CalculationPeriodDatesReference.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-enum-5-4/StepRelativeToEnum.hpp>

namespace FpmlSerialized {

class NotionalStepRule : public ISerialized { 
   public: 
       NotionalStepRule(TiXmlNode* xmlNode);

       bool isCalculationPeriodDatesReference(){return this->calculationPeriodDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodDatesReference> getCalculationPeriodDatesReference();
      std::string getCalculationPeriodDatesReferenceIDRef(){return calculationPeriodDatesReferenceIDRef_;}

       bool isStepFrequency(){return this->stepFrequencyIsNull_;}
       boost::shared_ptr<Period> getStepFrequency();
      std::string getStepFrequencyIDRef(){return stepFrequencyIDRef_;}

       bool isFirstNotionalStepDate(){return this->firstNotionalStepDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFirstNotionalStepDate();
      std::string getFirstNotionalStepDateIDRef(){return firstNotionalStepDateIDRef_;}

       bool isLastNotionalStepDate(){return this->lastNotionalStepDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getLastNotionalStepDate();
      std::string getLastNotionalStepDateIDRef(){return lastNotionalStepDateIDRef_;}

       bool isNotionalStepAmount(){return this->notionalStepAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNotionalStepAmount();
      std::string getNotionalStepAmountIDRef(){return notionalStepAmountIDRef_;}

       bool isNotionalStepRate(){return this->notionalStepRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNotionalStepRate();
      std::string getNotionalStepRateIDRef(){return notionalStepRateIDRef_;}

       bool isStepRelativeTo(){return this->stepRelativeToIsNull_;}
       boost::shared_ptr<StepRelativeToEnum> getStepRelativeTo();
      std::string getStepRelativeToIDRef(){return stepRelativeToIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!notionalStepAmountIsNull_){
                count += 1;
                str = "notionalStepAmount" ;
           }
           if(!notionalStepRateIsNull_){
                count += 1;
                str = "notionalStepRate" ;
           }
           if(!stepRelativeToIsNull_){
                count += 1;
                str = "stepRelativeTo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference_;
       std::string calculationPeriodDatesReferenceIDRef_;
       bool calculationPeriodDatesReferenceIsNull_;
       boost::shared_ptr<Period> stepFrequency_;
       std::string stepFrequencyIDRef_;
       bool stepFrequencyIsNull_;
       boost::shared_ptr<XsdTypeDate> firstNotionalStepDate_;
       std::string firstNotionalStepDateIDRef_;
       bool firstNotionalStepDateIsNull_;
       boost::shared_ptr<XsdTypeDate> lastNotionalStepDate_;
       std::string lastNotionalStepDateIDRef_;
       bool lastNotionalStepDateIsNull_;
         boost::shared_ptr<XsdTypeDecimal> notionalStepAmount_;     //choice
       std::string notionalStepAmountIDRef_;
       bool notionalStepAmountIsNull_;
         boost::shared_ptr<XsdTypeDecimal> notionalStepRate_;     //choice
       std::string notionalStepRateIDRef_;
       bool notionalStepRateIsNull_;
         boost::shared_ptr<StepRelativeToEnum> stepRelativeTo_;     //choice
       std::string stepRelativeToIDRef_;
       bool stepRelativeToIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

