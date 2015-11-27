// InterestLegCalculationPeriodDates.hpp 
#ifndef FpmlSerialized_InterestLegCalculationPeriodDates_hpp
#define FpmlSerialized_InterestLegCalculationPeriodDates_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-eq-shared-5-4/InterestLegResetDates.hpp>
#include <fpml-shared-5-4/AdjustableRelativeOrPeriodicDates2.hpp>

namespace FpmlSerialized {

class InterestLegCalculationPeriodDates : public ISerialized { 
   public: 
       InterestLegCalculationPeriodDates(TiXmlNode* xmlNode);

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isTerminationDate(){return this->terminationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getTerminationDate();
      std::string getTerminationDateIDRef(){return terminationDateIDRef_;}

       bool isInterestLegResetDates(){return this->interestLegResetDatesIsNull_;}
       boost::shared_ptr<InterestLegResetDates> getInterestLegResetDates();
      std::string getInterestLegResetDatesIDRef(){return interestLegResetDatesIDRef_;}

       bool isInterestLegPaymentDates(){return this->interestLegPaymentDatesIsNull_;}
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> getInterestLegPaymentDates();
      std::string getInterestLegPaymentDatesIDRef(){return interestLegPaymentDatesIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> terminationDate_;
       std::string terminationDateIDRef_;
       bool terminationDateIsNull_;
       boost::shared_ptr<InterestLegResetDates> interestLegResetDates_;
       std::string interestLegResetDatesIDRef_;
       bool interestLegResetDatesIsNull_;
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> interestLegPaymentDates_;
       std::string interestLegPaymentDatesIDRef_;
       bool interestLegPaymentDatesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

