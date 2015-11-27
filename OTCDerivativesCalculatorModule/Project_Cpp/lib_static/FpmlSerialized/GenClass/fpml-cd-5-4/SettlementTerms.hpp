// SettlementTerms.hpp 
#ifndef FpmlSerialized_SettlementTerms_hpp
#define FpmlSerialized_SettlementTerms_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class SettlementTerms : public ISerialized { 
   public: 
       SettlementTerms(TiXmlNode* xmlNode);

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       boost::shared_ptr<Currency> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

   protected: 
       boost::shared_ptr<Currency> settlementCurrency_;
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

