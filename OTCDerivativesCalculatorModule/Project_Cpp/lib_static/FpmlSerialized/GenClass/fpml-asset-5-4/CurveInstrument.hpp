// CurveInstrument.hpp 
#ifndef FpmlSerialized_CurveInstrument_hpp
#define FpmlSerialized_CurveInstrument_hpp

#include <fpml-asset-5-4/IdentifiedAsset.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-shared-5-4/ExchangeId.hpp>
#include <fpml-shared-5-4/ClearanceSystem.hpp>
#include <fpml-shared-5-4/ProductReference.hpp>

namespace FpmlSerialized {

class CurveInstrument : public IdentifiedAsset { 
   public: 
       CurveInstrument(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isExchangeId(){return this->exchangeIdIsNull_;}
       boost::shared_ptr<ExchangeId> getExchangeId();
      std::string getExchangeIdIDRef(){return exchangeIdIDRef_;}

       bool isClearanceSystem(){return this->clearanceSystemIsNull_;}
       boost::shared_ptr<ClearanceSystem> getClearanceSystem();
      std::string getClearanceSystemIDRef(){return clearanceSystemIDRef_;}

       bool isDefinition(){return this->definitionIsNull_;}
       boost::shared_ptr<ProductReference> getDefinition();
      std::string getDefinitionIDRef(){return definitionIDRef_;}

   protected: 
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;
       boost::shared_ptr<ExchangeId> exchangeId_;
       std::string exchangeIdIDRef_;
       bool exchangeIdIsNull_;
       boost::shared_ptr<ClearanceSystem> clearanceSystem_;
       std::string clearanceSystemIDRef_;
       bool clearanceSystemIsNull_;
       boost::shared_ptr<ProductReference> definition_;
       std::string definitionIDRef_;
       bool definitionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

