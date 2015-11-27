// SettlementProvision.hpp 
#ifndef FpmlSerialized_SettlementProvision_hpp
#define FpmlSerialized_SettlementProvision_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-ird-5-4/NonDeliverableSettlement.hpp>

namespace FpmlSerialized {

class SettlementProvision : public ISerialized { 
   public: 
       SettlementProvision(TiXmlNode* xmlNode);

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       boost::shared_ptr<Currency> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

       bool isNonDeliverableSettlement(){return this->nonDeliverableSettlementIsNull_;}
       boost::shared_ptr<NonDeliverableSettlement> getNonDeliverableSettlement();
      std::string getNonDeliverableSettlementIDRef(){return nonDeliverableSettlementIDRef_;}

   protected: 
       boost::shared_ptr<Currency> settlementCurrency_;
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;
       boost::shared_ptr<NonDeliverableSettlement> nonDeliverableSettlement_;
       std::string nonDeliverableSettlementIDRef_;
       bool nonDeliverableSettlementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

