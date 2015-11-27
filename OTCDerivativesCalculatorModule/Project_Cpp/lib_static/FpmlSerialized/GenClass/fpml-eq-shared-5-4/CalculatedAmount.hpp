// CalculatedAmount.hpp 
#ifndef FpmlSerialized_CalculatedAmount_hpp
#define FpmlSerialized_CalculatedAmount_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableRelativeOrPeriodicDates.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class CalculatedAmount : public ISerialized { 
   public: 
       CalculatedAmount(TiXmlNode* xmlNode);

       bool isCalculationDates(){return this->calculationDatesIsNull_;}
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates> getCalculationDates();
      std::string getCalculationDatesIDRef(){return calculationDatesIDRef_;}

       bool isObservationStartDate(){return this->observationStartDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getObservationStartDate();
      std::string getObservationStartDateIDRef(){return observationStartDateIDRef_;}

       bool isOptionsExchangeDividends(){return this->optionsExchangeDividendsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getOptionsExchangeDividends();
      std::string getOptionsExchangeDividendsIDRef(){return optionsExchangeDividendsIDRef_;}

       bool isAdditionalDividends(){return this->additionalDividendsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAdditionalDividends();
      std::string getAdditionalDividendsIDRef(){return additionalDividendsIDRef_;}

       bool isAllDividends(){return this->allDividendsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAllDividends();
      std::string getAllDividendsIDRef(){return allDividendsIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates> calculationDates_;
       std::string calculationDatesIDRef_;
       bool calculationDatesIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> observationStartDate_;
       std::string observationStartDateIDRef_;
       bool observationStartDateIsNull_;
       boost::shared_ptr<XsdTypeBoolean> optionsExchangeDividends_;
       std::string optionsExchangeDividendsIDRef_;
       bool optionsExchangeDividendsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> additionalDividends_;
       std::string additionalDividendsIDRef_;
       bool additionalDividendsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> allDividends_;
       std::string allDividendsIDRef_;
       bool allDividendsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

