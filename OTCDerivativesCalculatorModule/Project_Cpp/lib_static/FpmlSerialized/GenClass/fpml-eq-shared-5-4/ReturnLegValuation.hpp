// ReturnLegValuation.hpp 
#ifndef FpmlSerialized_ReturnLegValuation_hpp
#define FpmlSerialized_ReturnLegValuation_hpp

#include <ISerialized.hpp>
#include <fpml-eq-shared-5-4/ReturnLegValuationPrice.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-eq-shared-5-4/ReturnSwapPaymentDates.hpp>
#include <fpml-asset-5-4/ExchangeTradedContract.hpp>

namespace FpmlSerialized {

class ReturnLegValuation : public ISerialized { 
   public: 
       ReturnLegValuation(TiXmlNode* xmlNode);

       bool isInitialPrice(){return this->initialPriceIsNull_;}
       boost::shared_ptr<ReturnLegValuationPrice> getInitialPrice();
      std::string getInitialPriceIDRef(){return initialPriceIDRef_;}

       bool isNotionalReset(){return this->notionalResetIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotionalReset();
      std::string getNotionalResetIDRef(){return notionalResetIDRef_;}

       bool isValuationPriceInterim(){return this->valuationPriceInterimIsNull_;}
       boost::shared_ptr<ReturnLegValuationPrice> getValuationPriceInterim();
      std::string getValuationPriceInterimIDRef(){return valuationPriceInterimIDRef_;}

       bool isValuationPriceFinal(){return this->valuationPriceFinalIsNull_;}
       boost::shared_ptr<ReturnLegValuationPrice> getValuationPriceFinal();
      std::string getValuationPriceFinalIDRef(){return valuationPriceFinalIDRef_;}

       bool isPaymentDates(){return this->paymentDatesIsNull_;}
       boost::shared_ptr<ReturnSwapPaymentDates> getPaymentDates();
      std::string getPaymentDatesIDRef(){return paymentDatesIDRef_;}

       bool isExchangeTradedContractNearest(){return this->exchangeTradedContractNearestIsNull_;}
       boost::shared_ptr<ExchangeTradedContract> getExchangeTradedContractNearest();
      std::string getExchangeTradedContractNearestIDRef(){return exchangeTradedContractNearestIDRef_;}

   protected: 
       boost::shared_ptr<ReturnLegValuationPrice> initialPrice_;
       std::string initialPriceIDRef_;
       bool initialPriceIsNull_;
       boost::shared_ptr<XsdTypeBoolean> notionalReset_;
       std::string notionalResetIDRef_;
       bool notionalResetIsNull_;
       boost::shared_ptr<ReturnLegValuationPrice> valuationPriceInterim_;
       std::string valuationPriceInterimIDRef_;
       bool valuationPriceInterimIsNull_;
       boost::shared_ptr<ReturnLegValuationPrice> valuationPriceFinal_;
       std::string valuationPriceFinalIDRef_;
       bool valuationPriceFinalIsNull_;
       boost::shared_ptr<ReturnSwapPaymentDates> paymentDates_;
       std::string paymentDatesIDRef_;
       bool paymentDatesIsNull_;
       boost::shared_ptr<ExchangeTradedContract> exchangeTradedContractNearest_;
       std::string exchangeTradedContractNearestIDRef_;
       bool exchangeTradedContractNearestIsNull_;

};

} //namespaceFpmlSerialized end
#endif

