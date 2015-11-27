// Correlation.hpp 
#ifndef FpmlSerialized_Correlation_hpp
#define FpmlSerialized_Correlation_hpp

#include <fpml-eq-shared-5-4/CalculationFromObservation.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/CorrelationValue.hpp>
#include <fpml-eq-shared-5-4/BoundedCorrelation.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class Correlation : public CalculationFromObservation { 
   public: 
       Correlation(TiXmlNode* xmlNode);

       bool isNotionalAmount(){return this->notionalAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getNotionalAmount();
      std::string getNotionalAmountIDRef(){return notionalAmountIDRef_;}

       bool isCorrelationStrikePrice(){return this->correlationStrikePriceIsNull_;}
       boost::shared_ptr<CorrelationValue> getCorrelationStrikePrice();
      std::string getCorrelationStrikePriceIDRef(){return correlationStrikePriceIDRef_;}

       bool isBoundedCorrelation(){return this->boundedCorrelationIsNull_;}
       boost::shared_ptr<BoundedCorrelation> getBoundedCorrelation();
      std::string getBoundedCorrelationIDRef(){return boundedCorrelationIDRef_;}

       bool isNumberOfDataSeries(){return this->numberOfDataSeriesIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getNumberOfDataSeries();
      std::string getNumberOfDataSeriesIDRef(){return numberOfDataSeriesIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeMoney> notionalAmount_;
       std::string notionalAmountIDRef_;
       bool notionalAmountIsNull_;
       boost::shared_ptr<CorrelationValue> correlationStrikePrice_;
       std::string correlationStrikePriceIDRef_;
       bool correlationStrikePriceIsNull_;
       boost::shared_ptr<BoundedCorrelation> boundedCorrelation_;
       std::string boundedCorrelationIDRef_;
       bool boundedCorrelationIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> numberOfDataSeries_;
       std::string numberOfDataSeriesIDRef_;
       bool numberOfDataSeriesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

