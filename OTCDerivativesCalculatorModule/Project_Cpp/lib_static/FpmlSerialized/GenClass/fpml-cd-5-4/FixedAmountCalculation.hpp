// FixedAmountCalculation.hpp 
#ifndef FpmlSerialized_FixedAmountCalculation_hpp
#define FpmlSerialized_FixedAmountCalculation_hpp

#include <ISerialized.hpp>
#include <fpml-cd-5-4/CalculationAmount.hpp>
#include <fpml-cd-5-4/FixedRate.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>

namespace FpmlSerialized {

class FixedAmountCalculation : public ISerialized { 
   public: 
       FixedAmountCalculation(TiXmlNode* xmlNode);

       bool isCalculationAmount(){return this->calculationAmountIsNull_;}
       boost::shared_ptr<CalculationAmount> getCalculationAmount();
      std::string getCalculationAmountIDRef(){return calculationAmountIDRef_;}

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<FixedRate> getFixedRate();
      std::string getFixedRateIDRef(){return fixedRateIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

   protected: 
       boost::shared_ptr<CalculationAmount> calculationAmount_;
       std::string calculationAmountIDRef_;
       bool calculationAmountIsNull_;
       boost::shared_ptr<FixedRate> fixedRate_;
       std::string fixedRateIDRef_;
       bool fixedRateIsNull_;
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

