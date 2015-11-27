// DateRelativeToCalculationPeriodDates.hpp 
#ifndef FpmlSerialized_DateRelativeToCalculationPeriodDates_hpp
#define FpmlSerialized_DateRelativeToCalculationPeriodDates_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/CalculationPeriodDatesReference.hpp>

namespace FpmlSerialized {

class DateRelativeToCalculationPeriodDates : public ISerialized { 
   public: 
       DateRelativeToCalculationPeriodDates(TiXmlNode* xmlNode);

       bool isCalculationPeriodDatesReference(){return this->calculationPeriodDatesReferenceIsNull_;}
       std::vector<boost::shared_ptr<CalculationPeriodDatesReference>> getCalculationPeriodDatesReference();
      std::string getCalculationPeriodDatesReferenceIDRef(){return calculationPeriodDatesReferenceIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<CalculationPeriodDatesReference>> calculationPeriodDatesReference_;
       std::string calculationPeriodDatesReferenceIDRef_;
       bool calculationPeriodDatesReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

