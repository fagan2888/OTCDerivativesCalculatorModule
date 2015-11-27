// WeatherLegCalculation.hpp 
#ifndef FpmlSerialized_WeatherLegCalculation_hpp
#define FpmlSerialized_WeatherLegCalculation_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/WeatherSettlementLevelEnum.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-shared-5-4/BusinessCenter.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/Rounding.hpp>

namespace FpmlSerialized {

class WeatherLegCalculation : public ISerialized { 
   public: 
       WeatherLegCalculation(TiXmlNode* xmlNode);

       bool isSettlementLevel(){return this->settlementLevelIsNull_;}
       boost::shared_ptr<WeatherSettlementLevelEnum> getSettlementLevel();
      std::string getSettlementLevelIDRef(){return settlementLevelIDRef_;}

       bool isReferenceLevelEqualsZero(){return this->referenceLevelEqualsZeroIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getReferenceLevelEqualsZero();
      std::string getReferenceLevelEqualsZeroIDRef(){return referenceLevelEqualsZeroIDRef_;}

       bool isCalculationDate(){return this->calculationDateIsNull_;}
       boost::shared_ptr<Period> getCalculationDate();
      std::string getCalculationDateIDRef(){return calculationDateIDRef_;}

       bool isBusinessDays(){return this->businessDaysIsNull_;}
       boost::shared_ptr<BusinessCenter> getBusinessDays();
      std::string getBusinessDaysIDRef(){return businessDaysIDRef_;}

       bool isDataCorrection(){return this->dataCorrectionIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDataCorrection();
      std::string getDataCorrectionIDRef(){return dataCorrectionIDRef_;}

       bool isCorrectionPeriod(){return this->correctionPeriodIsNull_;}
       boost::shared_ptr<Period> getCorrectionPeriod();
      std::string getCorrectionPeriodIDRef(){return correctionPeriodIDRef_;}

       bool isMaximumPaymentAmount(){return this->maximumPaymentAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getMaximumPaymentAmount();
      std::string getMaximumPaymentAmountIDRef(){return maximumPaymentAmountIDRef_;}

       bool isMaximumTransactionPaymentAmount(){return this->maximumTransactionPaymentAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getMaximumTransactionPaymentAmount();
      std::string getMaximumTransactionPaymentAmountIDRef(){return maximumTransactionPaymentAmountIDRef_;}

       bool isRounding(){return this->roundingIsNull_;}
       boost::shared_ptr<Rounding> getRounding();
      std::string getRoundingIDRef(){return roundingIDRef_;}

   protected: 
       boost::shared_ptr<WeatherSettlementLevelEnum> settlementLevel_;
       std::string settlementLevelIDRef_;
       bool settlementLevelIsNull_;
       boost::shared_ptr<XsdTypeBoolean> referenceLevelEqualsZero_;
       std::string referenceLevelEqualsZeroIDRef_;
       bool referenceLevelEqualsZeroIsNull_;
       boost::shared_ptr<Period> calculationDate_;
       std::string calculationDateIDRef_;
       bool calculationDateIsNull_;
       boost::shared_ptr<BusinessCenter> businessDays_;
       std::string businessDaysIDRef_;
       bool businessDaysIsNull_;
       boost::shared_ptr<XsdTypeBoolean> dataCorrection_;
       std::string dataCorrectionIDRef_;
       bool dataCorrectionIsNull_;
       boost::shared_ptr<Period> correctionPeriod_;
       std::string correctionPeriodIDRef_;
       bool correctionPeriodIsNull_;
       boost::shared_ptr<NonNegativeMoney> maximumPaymentAmount_;
       std::string maximumPaymentAmountIDRef_;
       bool maximumPaymentAmountIsNull_;
       boost::shared_ptr<NonNegativeMoney> maximumTransactionPaymentAmount_;
       std::string maximumTransactionPaymentAmountIDRef_;
       bool maximumTransactionPaymentAmountIsNull_;
       boost::shared_ptr<Rounding> rounding_;
       std::string roundingIDRef_;
       bool roundingIsNull_;

};

} //namespaceFpmlSerialized end
#endif

