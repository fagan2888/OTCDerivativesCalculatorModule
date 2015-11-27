// FixedPrice.hpp 
#ifndef FpmlSerialized_FixedPrice_hpp
#define FpmlSerialized_FixedPrice_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-asset-5-4/QuantityUnit.hpp>

namespace FpmlSerialized {

class FixedPrice : public ISerialized { 
   public: 
       FixedPrice(TiXmlNode* xmlNode);

       bool isPrice(){return this->priceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPrice();
      std::string getPriceIDRef(){return priceIDRef_;}

       bool isPriceCurrency(){return this->priceCurrencyIsNull_;}
       boost::shared_ptr<Currency> getPriceCurrency();
      std::string getPriceCurrencyIDRef(){return priceCurrencyIDRef_;}

       bool isPriceUnit(){return this->priceUnitIsNull_;}
       boost::shared_ptr<QuantityUnit> getPriceUnit();
      std::string getPriceUnitIDRef(){return priceUnitIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> price_;
       std::string priceIDRef_;
       bool priceIsNull_;
       boost::shared_ptr<Currency> priceCurrency_;
       std::string priceCurrencyIDRef_;
       bool priceCurrencyIsNull_;
       boost::shared_ptr<QuantityUnit> priceUnit_;
       std::string priceUnitIDRef_;
       bool priceUnitIsNull_;

};

} //namespaceFpmlSerialized end
#endif

