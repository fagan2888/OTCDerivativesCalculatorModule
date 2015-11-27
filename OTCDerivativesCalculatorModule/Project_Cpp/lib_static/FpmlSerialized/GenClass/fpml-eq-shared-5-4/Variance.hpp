// Variance.hpp 
#ifndef FpmlSerialized_Variance_hpp
#define FpmlSerialized_Variance_hpp

#include <fpml-eq-shared-5-4/CalculationFromObservation.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-eq-shared-5-4/BoundedVariance.hpp>
#include <fpml-asset-5-4/ExchangeTradedContract.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class Variance : public CalculationFromObservation { 
   public: 
       Variance(TiXmlNode* xmlNode);

       bool isVarianceAmount(){return this->varianceAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getVarianceAmount();
      std::string getVarianceAmountIDRef(){return varianceAmountIDRef_;}

       bool isVolatilityStrikePrice(){return this->volatilityStrikePriceIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getVolatilityStrikePrice();
      std::string getVolatilityStrikePriceIDRef(){return volatilityStrikePriceIDRef_;}

       bool isVarianceStrikePrice(){return this->varianceStrikePriceIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getVarianceStrikePrice();
      std::string getVarianceStrikePriceIDRef(){return varianceStrikePriceIDRef_;}

       bool isVarianceCap(){return this->varianceCapIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getVarianceCap();
      std::string getVarianceCapIDRef(){return varianceCapIDRef_;}

       bool isUnadjustedVarianceCap(){return this->unadjustedVarianceCapIsNull_;}
       boost::shared_ptr<PositiveDecimal> getUnadjustedVarianceCap();
      std::string getUnadjustedVarianceCapIDRef(){return unadjustedVarianceCapIDRef_;}

       bool isBoundedVariance(){return this->boundedVarianceIsNull_;}
       boost::shared_ptr<BoundedVariance> getBoundedVariance();
      std::string getBoundedVarianceIDRef(){return boundedVarianceIDRef_;}

       bool isExchangeTradedContractNearest(){return this->exchangeTradedContractNearestIsNull_;}
       boost::shared_ptr<ExchangeTradedContract> getExchangeTradedContractNearest();
      std::string getExchangeTradedContractNearestIDRef(){return exchangeTradedContractNearestIDRef_;}

       bool isVegaNotionalAmount(){return this->vegaNotionalAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getVegaNotionalAmount();
      std::string getVegaNotionalAmountIDRef(){return vegaNotionalAmountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!volatilityStrikePriceIsNull_){
                count += 1;
                str = "volatilityStrikePrice" ;
           }
           if(!varianceStrikePriceIsNull_){
                count += 1;
                str = "varianceStrikePrice" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<NonNegativeMoney> varianceAmount_;
       std::string varianceAmountIDRef_;
       bool varianceAmountIsNull_;
         boost::shared_ptr<NonNegativeDecimal> volatilityStrikePrice_;     //choice
       std::string volatilityStrikePriceIDRef_;
       bool volatilityStrikePriceIsNull_;
         boost::shared_ptr<NonNegativeDecimal> varianceStrikePrice_;     //choice
       std::string varianceStrikePriceIDRef_;
       bool varianceStrikePriceIsNull_;
       boost::shared_ptr<XsdTypeBoolean> varianceCap_;
       std::string varianceCapIDRef_;
       bool varianceCapIsNull_;
       boost::shared_ptr<PositiveDecimal> unadjustedVarianceCap_;
       std::string unadjustedVarianceCapIDRef_;
       bool unadjustedVarianceCapIsNull_;
       boost::shared_ptr<BoundedVariance> boundedVariance_;
       std::string boundedVarianceIDRef_;
       bool boundedVarianceIsNull_;
       boost::shared_ptr<ExchangeTradedContract> exchangeTradedContractNearest_;
       std::string exchangeTradedContractNearestIDRef_;
       bool exchangeTradedContractNearestIsNull_;
       boost::shared_ptr<XsdTypeDecimal> vegaNotionalAmount_;
       std::string vegaNotionalAmountIDRef_;
       bool vegaNotionalAmountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

