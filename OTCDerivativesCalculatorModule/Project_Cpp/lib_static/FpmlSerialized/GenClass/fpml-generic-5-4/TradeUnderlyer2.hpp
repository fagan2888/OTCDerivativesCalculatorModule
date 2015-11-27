// TradeUnderlyer2.hpp 
#ifndef FpmlSerialized_TradeUnderlyer2_hpp
#define FpmlSerialized_TradeUnderlyer2_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/FloatingRate.hpp>
#include <fpml-shared-5-4/Schedule.hpp>
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
#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>

namespace FpmlSerialized {

class TradeUnderlyer2 : public ISerialized { 
   public: 
       TradeUnderlyer2(TiXmlNode* xmlNode);

       bool isFloatingRate(){return this->floatingRateIsNull_;}
       boost::shared_ptr<FloatingRate> getFloatingRate();
      std::string getFloatingRateIDRef(){return floatingRateIDRef_;}

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<Schedule> getFixedRate();
      std::string getFixedRateIDRef(){return fixedRateIDRef_;}

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

       bool isQuotedCurrencyPair(){return this->quotedCurrencyPairIsNull_;}
       boost::shared_ptr<QuotedCurrencyPair> getQuotedCurrencyPair();
      std::string getQuotedCurrencyPairIDRef(){return quotedCurrencyPairIDRef_;}

       bool isReferenceEntity(){return this->referenceEntityIsNull_;}
       boost::shared_ptr<LegalEntity> getReferenceEntity();
      std::string getReferenceEntityIDRef(){return referenceEntityIDRef_;}

       bool isPayerPartyReference(){return this->payerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPayerPartyReference();
      std::string getPayerPartyReferenceIDRef(){return payerPartyReferenceIDRef_;}

       bool isPayerAccountReference(){return this->payerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getPayerAccountReference();
      std::string getPayerAccountReferenceIDRef(){return payerAccountReferenceIDRef_;}

       bool isReceiverPartyReference(){return this->receiverPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getReceiverPartyReference();
      std::string getReceiverPartyReferenceIDRef(){return receiverPartyReferenceIDRef_;}

       bool isReceiverAccountReference(){return this->receiverAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getReceiverAccountReference();
      std::string getReceiverAccountReferenceIDRef(){return receiverAccountReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!floatingRateIsNull_){
                count += 1;
                str = "floatingRate" ;
           }
           if(!fixedRateIsNull_){
                count += 1;
                str = "fixedRate" ;
           }
           if(!underlyingAssetIsNull_){
                count += 1;
                str = "underlyingAsset" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<FloatingRate> floatingRate_;     //choice
       std::string floatingRateIDRef_;
       bool floatingRateIsNull_;
         boost::shared_ptr<Schedule> fixedRate_;     //choice
       std::string fixedRateIDRef_;
       bool fixedRateIsNull_;
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
       boost::shared_ptr<QuotedCurrencyPair> quotedCurrencyPair_;
       std::string quotedCurrencyPairIDRef_;
       bool quotedCurrencyPairIsNull_;
       boost::shared_ptr<LegalEntity> referenceEntity_;
       std::string referenceEntityIDRef_;
       bool referenceEntityIsNull_;
       boost::shared_ptr<PartyReference> payerPartyReference_;
       std::string payerPartyReferenceIDRef_;
       bool payerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> payerAccountReference_;
       std::string payerAccountReferenceIDRef_;
       bool payerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> receiverPartyReference_;
       std::string receiverPartyReferenceIDRef_;
       bool receiverPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> receiverAccountReference_;
       std::string receiverAccountReferenceIDRef_;
       bool receiverAccountReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

