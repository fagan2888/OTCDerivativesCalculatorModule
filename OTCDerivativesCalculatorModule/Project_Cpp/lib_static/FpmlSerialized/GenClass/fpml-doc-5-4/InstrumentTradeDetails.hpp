// InstrumentTradeDetails.hpp 
#ifndef FpmlSerialized_InstrumentTradeDetails_hpp
#define FpmlSerialized_InstrumentTradeDetails_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-asset-5-4/Asset.hpp>
#include <fpml-asset-5-4/Basket.hpp>
#include <fpml-asset-5-4/Bond.hpp>
#include <fpml-asset-5-4/Cash.hpp>
#include <fpml-asset-5-4/Commodity.hpp>
#include <fpml-asset-5-4/ConvertibleBond.hpp>
#include <fpml-asset-5-4/EquityAsset.hpp>
#include <fpml-asset-5-4/ExchangeTradedFund.hpp>
#include <fpml-asset-5-4/Future.hpp>
#include <fpml-asset-5-4/Index.hpp>
#include <fpml-asset-5-4/Loan.hpp>
#include <fpml-asset-5-4/Mortgage.hpp>
#include <fpml-asset-5-4/MutualFund.hpp>
#include <fpml-doc-5-4/InstrumentTradeQuantity.hpp>
#include <fpml-doc-5-4/InstrumentTradePricing.hpp>
#include <fpml-doc-5-4/InstrumentTradePrincipal.hpp>

namespace FpmlSerialized {

class InstrumentTradeDetails : public Product { 
   public: 
       InstrumentTradeDetails(TiXmlNode* xmlNode);

       bool isBuyerPartyReference(){return this->buyerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getBuyerPartyReference();
      std::string getBuyerPartyReferenceIDRef(){return buyerPartyReferenceIDRef_;}

       bool isBuyerAccountReference(){return this->buyerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getBuyerAccountReference();
      std::string getBuyerAccountReferenceIDRef(){return buyerAccountReferenceIDRef_;}

       bool isSellerPartyReference(){return this->sellerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getSellerPartyReference();
      std::string getSellerPartyReferenceIDRef(){return sellerPartyReferenceIDRef_;}

       bool isSellerAccountReference(){return this->sellerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getSellerAccountReference();
      std::string getSellerAccountReferenceIDRef(){return sellerAccountReferenceIDRef_;}

       bool isUnderlyingAsset(){return this->underlyingAssetIsNull_;}
       boost::shared_ptr<Asset> getUnderlyingAsset();
      std::string getUnderlyingAssetIDRef(){return underlyingAssetIDRef_;}

       bool isBasket(){return this->basketIsNull_;}
       boost::shared_ptr<Basket> getBasket();
      std::string getBasketIDRef(){return basketIDRef_;}

       bool isBond(){return this->bondIsNull_;}
       boost::shared_ptr<Bond> getBond();
      std::string getBondIDRef(){return bondIDRef_;}

       bool isCash(){return this->cashIsNull_;}
       boost::shared_ptr<Cash> getCash();
      std::string getCashIDRef(){return cashIDRef_;}

       bool isCommodity(){return this->commodityIsNull_;}
       boost::shared_ptr<Commodity> getCommodity();
      std::string getCommodityIDRef(){return commodityIDRef_;}

       bool isConvertibleBond(){return this->convertibleBondIsNull_;}
       boost::shared_ptr<ConvertibleBond> getConvertibleBond();
      std::string getConvertibleBondIDRef(){return convertibleBondIDRef_;}

       bool isEquity(){return this->equityIsNull_;}
       boost::shared_ptr<EquityAsset> getEquity();
      std::string getEquityIDRef(){return equityIDRef_;}

       bool isExchangeTradedFund(){return this->exchangeTradedFundIsNull_;}
       boost::shared_ptr<ExchangeTradedFund> getExchangeTradedFund();
      std::string getExchangeTradedFundIDRef(){return exchangeTradedFundIDRef_;}

       bool isFuture(){return this->futureIsNull_;}
       boost::shared_ptr<Future> getFuture();
      std::string getFutureIDRef(){return futureIDRef_;}

       bool isIndex(){return this->indexIsNull_;}
       boost::shared_ptr<Index> getIndex();
      std::string getIndexIDRef(){return indexIDRef_;}

       bool isLoan(){return this->loanIsNull_;}
       boost::shared_ptr<Loan> getLoan();
      std::string getLoanIDRef(){return loanIDRef_;}

       bool isMortgage(){return this->mortgageIsNull_;}
       boost::shared_ptr<Mortgage> getMortgage();
      std::string getMortgageIDRef(){return mortgageIDRef_;}

       bool isMutualFund(){return this->mutualFundIsNull_;}
       boost::shared_ptr<MutualFund> getMutualFund();
      std::string getMutualFundIDRef(){return mutualFundIDRef_;}

       bool isQuantity(){return this->quantityIsNull_;}
       boost::shared_ptr<InstrumentTradeQuantity> getQuantity();
      std::string getQuantityIDRef(){return quantityIDRef_;}

       bool isPricing(){return this->pricingIsNull_;}
       boost::shared_ptr<InstrumentTradePricing> getPricing();
      std::string getPricingIDRef(){return pricingIDRef_;}

       bool isPrincipal(){return this->principalIsNull_;}
       boost::shared_ptr<InstrumentTradePrincipal> getPrincipal();
      std::string getPrincipalIDRef(){return principalIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> buyerPartyReference_;
       std::string buyerPartyReferenceIDRef_;
       bool buyerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> buyerAccountReference_;
       std::string buyerAccountReferenceIDRef_;
       bool buyerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> sellerPartyReference_;
       std::string sellerPartyReferenceIDRef_;
       bool sellerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> sellerAccountReference_;
       std::string sellerAccountReferenceIDRef_;
       bool sellerAccountReferenceIsNull_;
       boost::shared_ptr<Asset> underlyingAsset_;
       std::string underlyingAssetIDRef_;
       bool underlyingAssetIsNull_;
       boost::shared_ptr<Basket> basket_;     //substitude 
       std::string basketIDRef_;
       bool basketIsNull_;
       boost::shared_ptr<Bond> bond_;     //substitude 
       std::string bondIDRef_;
       bool bondIsNull_;
       boost::shared_ptr<Cash> cash_;     //substitude 
       std::string cashIDRef_;
       bool cashIsNull_;
       boost::shared_ptr<Commodity> commodity_;     //substitude 
       std::string commodityIDRef_;
       bool commodityIsNull_;
       boost::shared_ptr<ConvertibleBond> convertibleBond_;     //substitude 
       std::string convertibleBondIDRef_;
       bool convertibleBondIsNull_;
       boost::shared_ptr<EquityAsset> equity_;     //substitude 
       std::string equityIDRef_;
       bool equityIsNull_;
       boost::shared_ptr<ExchangeTradedFund> exchangeTradedFund_;     //substitude 
       std::string exchangeTradedFundIDRef_;
       bool exchangeTradedFundIsNull_;
       boost::shared_ptr<Future> future_;     //substitude 
       std::string futureIDRef_;
       bool futureIsNull_;
       boost::shared_ptr<Index> index_;     //substitude 
       std::string indexIDRef_;
       bool indexIsNull_;
       boost::shared_ptr<Loan> loan_;     //substitude 
       std::string loanIDRef_;
       bool loanIsNull_;
       boost::shared_ptr<Mortgage> mortgage_;     //substitude 
       std::string mortgageIDRef_;
       bool mortgageIsNull_;
       boost::shared_ptr<MutualFund> mutualFund_;     //substitude 
       std::string mutualFundIDRef_;
       bool mutualFundIsNull_;
       boost::shared_ptr<InstrumentTradeQuantity> quantity_;
       std::string quantityIDRef_;
       bool quantityIsNull_;
       boost::shared_ptr<InstrumentTradePricing> pricing_;
       std::string pricingIDRef_;
       bool pricingIsNull_;
       boost::shared_ptr<InstrumentTradePrincipal> principal_;
       std::string principalIDRef_;
       bool principalIsNull_;

};

} //namespaceFpmlSerialized end
#endif

