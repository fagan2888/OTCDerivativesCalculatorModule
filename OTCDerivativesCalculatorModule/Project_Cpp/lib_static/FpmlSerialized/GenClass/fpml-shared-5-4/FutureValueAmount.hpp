// FutureValueAmount.hpp 
#ifndef FpmlSerialized_FutureValueAmount_hpp
#define FpmlSerialized_FutureValueAmount_hpp

#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class FutureValueAmount : public NonNegativeMoney { 
   public: 
       FutureValueAmount(TiXmlNode* xmlNode);

       bool isCalculationPeriodNumberOfDays(){return this->calculationPeriodNumberOfDaysIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getCalculationPeriodNumberOfDays();
      std::string getCalculationPeriodNumberOfDaysIDRef(){return calculationPeriodNumberOfDaysIDRef_;}

       bool isValueDate(){return this->valueDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getValueDate();
      std::string getValueDateIDRef(){return valueDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> calculationPeriodNumberOfDays_;
       std::string calculationPeriodNumberOfDaysIDRef_;
       bool calculationPeriodNumberOfDaysIsNull_;
       boost::shared_ptr<XsdTypeDate> valueDate_;
       std::string valueDateIDRef_;
       bool valueDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

