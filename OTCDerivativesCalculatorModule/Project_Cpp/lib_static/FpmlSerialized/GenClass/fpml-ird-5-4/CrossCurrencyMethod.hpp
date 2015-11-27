// CrossCurrencyMethod.hpp 
#ifndef FpmlSerialized_CrossCurrencyMethod_hpp
#define FpmlSerialized_CrossCurrencyMethod_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/CashSettlementReferenceBanks.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-enum-5-4/QuotationRateTypeEnum.hpp>

namespace FpmlSerialized {

class CrossCurrencyMethod : public ISerialized { 
   public: 
       CrossCurrencyMethod(TiXmlNode* xmlNode);

       bool isCashSettlementReferenceBanks(){return this->cashSettlementReferenceBanksIsNull_;}
       boost::shared_ptr<CashSettlementReferenceBanks> getCashSettlementReferenceBanks();
      std::string getCashSettlementReferenceBanksIDRef(){return cashSettlementReferenceBanksIDRef_;}

       bool isCashSettlementCurrency(){return this->cashSettlementCurrencyIsNull_;}
       std::vector<boost::shared_ptr<Currency>> getCashSettlementCurrency();
      std::string getCashSettlementCurrencyIDRef(){return cashSettlementCurrencyIDRef_;}

       bool isQuotationRateType(){return this->quotationRateTypeIsNull_;}
       boost::shared_ptr<QuotationRateTypeEnum> getQuotationRateType();
      std::string getQuotationRateTypeIDRef(){return quotationRateTypeIDRef_;}

   protected: 
       boost::shared_ptr<CashSettlementReferenceBanks> cashSettlementReferenceBanks_;
       std::string cashSettlementReferenceBanksIDRef_;
       bool cashSettlementReferenceBanksIsNull_;
       std::vector<boost::shared_ptr<Currency>> cashSettlementCurrency_;
       std::string cashSettlementCurrencyIDRef_;
       bool cashSettlementCurrencyIsNull_;
       boost::shared_ptr<QuotationRateTypeEnum> quotationRateType_;
       std::string quotationRateTypeIDRef_;
       bool quotationRateTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

