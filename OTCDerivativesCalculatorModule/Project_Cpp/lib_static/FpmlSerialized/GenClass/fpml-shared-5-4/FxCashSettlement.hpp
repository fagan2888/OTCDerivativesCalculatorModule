// FxCashSettlement.hpp 
#ifndef FpmlSerialized_FxCashSettlement_hpp
#define FpmlSerialized_FxCashSettlement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-shared-5-4/FxFixing.hpp>

namespace FpmlSerialized {

class FxCashSettlement : public ISerialized { 
   public: 
       FxCashSettlement(TiXmlNode* xmlNode);

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       boost::shared_ptr<Currency> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

       bool isFixing(){return this->fixingIsNull_;}
       std::vector<boost::shared_ptr<FxFixing>> getFixing();
      std::string getFixingIDRef(){return fixingIDRef_;}

   protected: 
       boost::shared_ptr<Currency> settlementCurrency_;
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;
       std::vector<boost::shared_ptr<FxFixing>> fixing_;
       std::string fixingIDRef_;
       bool fixingIsNull_;

};

} //namespaceFpmlSerialized end
#endif

