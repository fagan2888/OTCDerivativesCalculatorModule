// SingleUnderlyer.hpp 
#ifndef FpmlSerialized_SingleUnderlyer_hpp
#define FpmlSerialized_SingleUnderlyer_hpp

#include <ISerialized.hpp>
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
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/DividendPayout.hpp>
#include <fpml-asset-5-4/PendingPayment.hpp>
#include <fpml-shared-5-4/AverageDailyTradingVolumeLimit.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class SingleUnderlyer : public ISerialized { 
   public: 
       SingleUnderlyer(TiXmlNode* xmlNode);

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

       bool isOpenUnits(){return this->openUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getOpenUnits();
      std::string getOpenUnitsIDRef(){return openUnitsIDRef_;}

       bool isDividendPayout(){return this->dividendPayoutIsNull_;}
       boost::shared_ptr<DividendPayout> getDividendPayout();
      std::string getDividendPayoutIDRef(){return dividendPayoutIDRef_;}

       bool isCouponPayment(){return this->couponPaymentIsNull_;}
       boost::shared_ptr<PendingPayment> getCouponPayment();
      std::string getCouponPaymentIDRef(){return couponPaymentIDRef_;}

       bool isAverageDailyTradingVolume(){return this->averageDailyTradingVolumeIsNull_;}
       boost::shared_ptr<AverageDailyTradingVolumeLimit> getAverageDailyTradingVolume();
      std::string getAverageDailyTradingVolumeIDRef(){return averageDailyTradingVolumeIDRef_;}

       bool isDepositoryReceipt(){return this->depositoryReceiptIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDepositoryReceipt();
      std::string getDepositoryReceiptIDRef(){return depositoryReceiptIDRef_;}

   protected: 
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
       boost::shared_ptr<XsdTypeDecimal> openUnits_;
       std::string openUnitsIDRef_;
       bool openUnitsIsNull_;
       boost::shared_ptr<DividendPayout> dividendPayout_;
       std::string dividendPayoutIDRef_;
       bool dividendPayoutIsNull_;
       boost::shared_ptr<PendingPayment> couponPayment_;
       std::string couponPaymentIDRef_;
       bool couponPaymentIsNull_;
       boost::shared_ptr<AverageDailyTradingVolumeLimit> averageDailyTradingVolume_;
       std::string averageDailyTradingVolumeIDRef_;
       bool averageDailyTradingVolumeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> depositoryReceipt_;
       std::string depositoryReceiptIDRef_;
       bool depositoryReceiptIsNull_;

};

} //namespaceFpmlSerialized end
#endif

