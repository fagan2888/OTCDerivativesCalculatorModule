// ResetDates.hpp 
#ifndef FpmlSerialized_ResetDates_hpp
#define FpmlSerialized_ResetDates_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/CalculationPeriodDatesReference.hpp>
#include <fpml-enum-5-4/ResetRelativeToEnum.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-shared-5-4/Offset.hpp>
#include <fpml-shared-5-4/ResetFrequency.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>

namespace FpmlSerialized {

class ResetDates : public ISerialized { 
   public: 
       ResetDates(TiXmlNode* xmlNode);

       bool isCalculationPeriodDatesReference(){return this->calculationPeriodDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodDatesReference> getCalculationPeriodDatesReference();
      std::string getCalculationPeriodDatesReferenceIDRef(){return calculationPeriodDatesReferenceIDRef_;}

       bool isResetRelativeTo(){return this->resetRelativeToIsNull_;}
       boost::shared_ptr<ResetRelativeToEnum> getResetRelativeTo();
      std::string getResetRelativeToIDRef(){return resetRelativeToIDRef_;}

       bool isInitialFixingDate(){return this->initialFixingDateIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getInitialFixingDate();
      std::string getInitialFixingDateIDRef(){return initialFixingDateIDRef_;}

       bool isFixingDates(){return this->fixingDatesIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getFixingDates();
      std::string getFixingDatesIDRef(){return fixingDatesIDRef_;}

       bool isRateCutOffDaysOffset(){return this->rateCutOffDaysOffsetIsNull_;}
       boost::shared_ptr<Offset> getRateCutOffDaysOffset();
      std::string getRateCutOffDaysOffsetIDRef(){return rateCutOffDaysOffsetIDRef_;}

       bool isResetFrequency(){return this->resetFrequencyIsNull_;}
       boost::shared_ptr<ResetFrequency> getResetFrequency();
      std::string getResetFrequencyIDRef(){return resetFrequencyIDRef_;}

       bool isResetDatesAdjustments(){return this->resetDatesAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getResetDatesAdjustments();
      std::string getResetDatesAdjustmentsIDRef(){return resetDatesAdjustmentsIDRef_;}

   protected: 
       boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference_;
       std::string calculationPeriodDatesReferenceIDRef_;
       bool calculationPeriodDatesReferenceIsNull_;
       boost::shared_ptr<ResetRelativeToEnum> resetRelativeTo_;
       std::string resetRelativeToIDRef_;
       bool resetRelativeToIsNull_;
       boost::shared_ptr<RelativeDateOffset> initialFixingDate_;
       std::string initialFixingDateIDRef_;
       bool initialFixingDateIsNull_;
       boost::shared_ptr<RelativeDateOffset> fixingDates_;
       std::string fixingDatesIDRef_;
       bool fixingDatesIsNull_;
       boost::shared_ptr<Offset> rateCutOffDaysOffset_;
       std::string rateCutOffDaysOffsetIDRef_;
       bool rateCutOffDaysOffsetIsNull_;
       boost::shared_ptr<ResetFrequency> resetFrequency_;
       std::string resetFrequencyIDRef_;
       bool resetFrequencyIsNull_;
       boost::shared_ptr<BusinessDayAdjustments> resetDatesAdjustments_;
       std::string resetDatesAdjustmentsIDRef_;
       bool resetDatesAdjustmentsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

