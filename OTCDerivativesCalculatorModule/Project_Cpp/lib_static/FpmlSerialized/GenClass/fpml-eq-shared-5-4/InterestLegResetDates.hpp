// InterestLegResetDates.hpp 
#ifndef FpmlSerialized_InterestLegResetDates_hpp
#define FpmlSerialized_InterestLegResetDates_hpp

#include <ISerialized.hpp>
#include <fpml-eq-shared-5-4/InterestLegCalculationPeriodDatesReference.hpp>
#include <fpml-enum-5-4/ResetRelativeToEnum.hpp>
#include <fpml-shared-5-4/ResetFrequency.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-shared-5-4/AdjustableDatesOrRelativeDateOffset.hpp>

namespace FpmlSerialized {

class InterestLegResetDates : public ISerialized { 
   public: 
       InterestLegResetDates(TiXmlNode* xmlNode);

       bool isCalculationPeriodDatesReference(){return this->calculationPeriodDatesReferenceIsNull_;}
       boost::shared_ptr<InterestLegCalculationPeriodDatesReference> getCalculationPeriodDatesReference();
      std::string getCalculationPeriodDatesReferenceIDRef(){return calculationPeriodDatesReferenceIDRef_;}

       bool isResetRelativeTo(){return this->resetRelativeToIsNull_;}
       boost::shared_ptr<ResetRelativeToEnum> getResetRelativeTo();
      std::string getResetRelativeToIDRef(){return resetRelativeToIDRef_;}

       bool isResetFrequency(){return this->resetFrequencyIsNull_;}
       boost::shared_ptr<ResetFrequency> getResetFrequency();
      std::string getResetFrequencyIDRef(){return resetFrequencyIDRef_;}

       bool isInitialFixingDate(){return this->initialFixingDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getInitialFixingDate();
      std::string getInitialFixingDateIDRef(){return initialFixingDateIDRef_;}

       bool isFixingDates(){return this->fixingDatesIsNull_;}
       boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> getFixingDates();
      std::string getFixingDatesIDRef(){return fixingDatesIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!resetRelativeToIsNull_){
                count += 1;
                str = "resetRelativeTo" ;
           }
           if(!resetFrequencyIsNull_){
                count += 1;
                str = "resetFrequency" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<InterestLegCalculationPeriodDatesReference> calculationPeriodDatesReference_;
       std::string calculationPeriodDatesReferenceIDRef_;
       bool calculationPeriodDatesReferenceIsNull_;
         boost::shared_ptr<ResetRelativeToEnum> resetRelativeTo_;     //choice
       std::string resetRelativeToIDRef_;
       bool resetRelativeToIsNull_;
         boost::shared_ptr<ResetFrequency> resetFrequency_;     //choice
       std::string resetFrequencyIDRef_;
       bool resetFrequencyIsNull_;
       boost::shared_ptr<RelativeDateOffset> initialFixingDate_;
       std::string initialFixingDateIDRef_;
       bool initialFixingDateIsNull_;
       boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> fixingDates_;
       std::string fixingDatesIDRef_;
       bool fixingDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

