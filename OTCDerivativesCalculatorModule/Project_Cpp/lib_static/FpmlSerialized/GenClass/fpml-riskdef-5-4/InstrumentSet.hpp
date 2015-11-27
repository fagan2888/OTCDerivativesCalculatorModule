// InstrumentSet.hpp 
#ifndef FpmlSerialized_InstrumentSet_hpp
#define FpmlSerialized_InstrumentSet_hpp

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
#include <fpml-asset-5-4/Deposit.hpp>
#include <fpml-asset-5-4/FxRateAsset.hpp>
#include <fpml-asset-5-4/RateIndex.hpp>
#include <fpml-asset-5-4/SimpleCreditDefaultSwap.hpp>
#include <fpml-asset-5-4/SimpleFra.hpp>
#include <fpml-asset-5-4/SimpleIRSwap.hpp>

namespace FpmlSerialized {

class InstrumentSet : public ISerialized { 
   public: 
       InstrumentSet(TiXmlNode* xmlNode);

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

       bool isCurveInstrument(){return this->curveInstrumentIsNull_;}
       boost::shared_ptr<Asset> getCurveInstrument();
      std::string getCurveInstrumentIDRef(){return curveInstrumentIDRef_;}

       bool isDeposit(){return this->depositIsNull_;}
       boost::shared_ptr<Deposit> getDeposit();
      std::string getDepositIDRef(){return depositIDRef_;}

       bool isFx(){return this->fxIsNull_;}
       boost::shared_ptr<FxRateAsset> getFx();
      std::string getFxIDRef(){return fxIDRef_;}

       bool isRateIndex(){return this->rateIndexIsNull_;}
       boost::shared_ptr<RateIndex> getRateIndex();
      std::string getRateIndexIDRef(){return rateIndexIDRef_;}

       bool isSimpleCreditDefaultSwap(){return this->simpleCreditDefaultSwapIsNull_;}
       boost::shared_ptr<SimpleCreditDefaultSwap> getSimpleCreditDefaultSwap();
      std::string getSimpleCreditDefaultSwapIDRef(){return simpleCreditDefaultSwapIDRef_;}

       bool isSimpleFra(){return this->simpleFraIsNull_;}
       boost::shared_ptr<SimpleFra> getSimpleFra();
      std::string getSimpleFraIDRef(){return simpleFraIDRef_;}

       bool isSimpleIrSwap(){return this->simpleIrSwapIsNull_;}
       boost::shared_ptr<SimpleIRSwap> getSimpleIrSwap();
      std::string getSimpleIrSwapIDRef(){return simpleIrSwapIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!underlyingAssetIsNull_){
                count += 1;
                str = "underlyingAsset" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<Asset> underlyingAsset_;     //choice
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
       boost::shared_ptr<Asset> curveInstrument_;
       std::string curveInstrumentIDRef_;
       bool curveInstrumentIsNull_;
       boost::shared_ptr<Deposit> deposit_;     //substitude 
       std::string depositIDRef_;
       bool depositIsNull_;
       boost::shared_ptr<FxRateAsset> fx_;     //substitude 
       std::string fxIDRef_;
       bool fxIsNull_;
       boost::shared_ptr<RateIndex> rateIndex_;     //substitude 
       std::string rateIndexIDRef_;
       bool rateIndexIsNull_;
       boost::shared_ptr<SimpleCreditDefaultSwap> simpleCreditDefaultSwap_;     //substitude 
       std::string simpleCreditDefaultSwapIDRef_;
       bool simpleCreditDefaultSwapIsNull_;
       boost::shared_ptr<SimpleFra> simpleFra_;     //substitude 
       std::string simpleFraIDRef_;
       bool simpleFraIsNull_;
       boost::shared_ptr<SimpleIRSwap> simpleIrSwap_;     //substitude 
       std::string simpleIrSwapIDRef_;
       bool simpleIrSwapIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

