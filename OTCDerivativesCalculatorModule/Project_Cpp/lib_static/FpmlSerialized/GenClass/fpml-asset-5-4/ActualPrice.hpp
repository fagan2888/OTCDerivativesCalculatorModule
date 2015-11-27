// ActualPrice.hpp 
#ifndef FpmlSerialized_ActualPrice_hpp
#define FpmlSerialized_ActualPrice_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-enum-5-4/PriceExpressionEnum.hpp>

namespace FpmlSerialized {

class ActualPrice : public ISerialized { 
   public: 
       ActualPrice(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

       bool isPriceExpression(){return this->priceExpressionIsNull_;}
       boost::shared_ptr<PriceExpressionEnum> getPriceExpression();
      std::string getPriceExpressionIDRef(){return priceExpressionIDRef_;}

   protected: 
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeDecimal> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;
       boost::shared_ptr<PriceExpressionEnum> priceExpression_;
       std::string priceExpressionIDRef_;
       bool priceExpressionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

