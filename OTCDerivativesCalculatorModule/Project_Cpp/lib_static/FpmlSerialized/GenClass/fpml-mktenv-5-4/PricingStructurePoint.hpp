// PricingStructurePoint.hpp 
#ifndef FpmlSerialized_PricingStructurePoint_hpp
#define FpmlSerialized_PricingStructurePoint_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/PricingDataPointCoordinate.hpp>
#include <fpml-riskdef-5-4/PricingDataPointCoordinateReference.hpp>
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
#include <fpml-asset-5-4/AssetReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/AssetMeasureType.hpp>
#include <fpml-asset-5-4/PriceQuoteUnits.hpp>
#include <fpml-enum-5-4/QuotationSideEnum.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-asset-5-4/ReportingCurrencyType.hpp>
#include <fpml-asset-5-4/QuoteTiming.hpp>
#include <fpml-shared-5-4/BusinessCenter.hpp>
#include <fpml-shared-5-4/ExchangeId.hpp>
#include <fpml-shared-5-4/InformationSource.hpp>
#include <fpml-asset-5-4/PricingModel.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/CashflowType.hpp>

namespace FpmlSerialized {

class PricingStructurePoint : public ISerialized { 
   public: 
       PricingStructurePoint(TiXmlNode* xmlNode);

       bool isCoordinate(){return this->coordinateIsNull_;}
       boost::shared_ptr<PricingDataPointCoordinate> getCoordinate();
      std::string getCoordinateIDRef(){return coordinateIDRef_;}

       bool isCoordinateReference(){return this->coordinateReferenceIsNull_;}
       boost::shared_ptr<PricingDataPointCoordinateReference> getCoordinateReference();
      std::string getCoordinateReferenceIDRef(){return coordinateReferenceIDRef_;}

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

       bool isUnderlyingAssetReference(){return this->underlyingAssetReferenceIsNull_;}
       boost::shared_ptr<AssetReference> getUnderlyingAssetReference();
      std::string getUnderlyingAssetReferenceIDRef(){return underlyingAssetReferenceIDRef_;}

       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getValue();
      std::string getValueIDRef(){return valueIDRef_;}

       bool isMeasureType(){return this->measureTypeIsNull_;}
       boost::shared_ptr<AssetMeasureType> getMeasureType();
      std::string getMeasureTypeIDRef(){return measureTypeIDRef_;}

       bool isQuoteUnits(){return this->quoteUnitsIsNull_;}
       boost::shared_ptr<PriceQuoteUnits> getQuoteUnits();
      std::string getQuoteUnitsIDRef(){return quoteUnitsIDRef_;}

       bool isSide(){return this->sideIsNull_;}
       boost::shared_ptr<QuotationSideEnum> getSide();
      std::string getSideIDRef(){return sideIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isCurrencyType(){return this->currencyTypeIsNull_;}
       boost::shared_ptr<ReportingCurrencyType> getCurrencyType();
      std::string getCurrencyTypeIDRef(){return currencyTypeIDRef_;}

       bool isTiming(){return this->timingIsNull_;}
       boost::shared_ptr<QuoteTiming> getTiming();
      std::string getTimingIDRef(){return timingIDRef_;}

       bool isBusinessCenter(){return this->businessCenterIsNull_;}
       boost::shared_ptr<BusinessCenter> getBusinessCenter();
      std::string getBusinessCenterIDRef(){return businessCenterIDRef_;}

       bool isExchangeId(){return this->exchangeIdIsNull_;}
       boost::shared_ptr<ExchangeId> getExchangeId();
      std::string getExchangeIdIDRef(){return exchangeIdIDRef_;}

       bool isInformationSource(){return this->informationSourceIsNull_;}
       std::vector<boost::shared_ptr<InformationSource>> getInformationSource();
      std::string getInformationSourceIDRef(){return informationSourceIDRef_;}

       bool isPricingModel(){return this->pricingModelIsNull_;}
       boost::shared_ptr<PricingModel> getPricingModel();
      std::string getPricingModelIDRef(){return pricingModelIDRef_;}

       bool isTime(){return this->timeIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getTime();
      std::string getTimeIDRef(){return timeIDRef_;}

       bool isValuationDate(){return this->valuationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getValuationDate();
      std::string getValuationDateIDRef(){return valuationDateIDRef_;}

       bool isExpiryTime(){return this->expiryTimeIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getExpiryTime();
      std::string getExpiryTimeIDRef(){return expiryTimeIDRef_;}

       bool isCashflowType(){return this->cashflowTypeIsNull_;}
       boost::shared_ptr<CashflowType> getCashflowType();
      std::string getCashflowTypeIDRef(){return cashflowTypeIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!coordinateIsNull_){
                count += 1;
                str = "coordinate" ;
           }
           if(!coordinateReferenceIsNull_){
                count += 1;
                str = "coordinateReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!underlyingAssetIsNull_){
                count += 1;
                str = "underlyingAsset" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!businessCenterIsNull_){
                count += 1;
                str = "businessCenter" ;
           }
           if(!exchangeIdIsNull_){
                count += 1;
                str = "exchangeId" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
   protected: 
         boost::shared_ptr<PricingDataPointCoordinate> coordinate_;     //choice
       std::string coordinateIDRef_;
       bool coordinateIsNull_;
         boost::shared_ptr<PricingDataPointCoordinateReference> coordinateReference_;     //choice
       std::string coordinateReferenceIDRef_;
       bool coordinateReferenceIsNull_;
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
       boost::shared_ptr<AssetReference> underlyingAssetReference_;
       std::string underlyingAssetReferenceIDRef_;
       bool underlyingAssetReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> value_;
       std::string valueIDRef_;
       bool valueIsNull_;
       boost::shared_ptr<AssetMeasureType> measureType_;
       std::string measureTypeIDRef_;
       bool measureTypeIsNull_;
       boost::shared_ptr<PriceQuoteUnits> quoteUnits_;
       std::string quoteUnitsIDRef_;
       bool quoteUnitsIsNull_;
       boost::shared_ptr<QuotationSideEnum> side_;
       std::string sideIDRef_;
       bool sideIsNull_;
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;
       boost::shared_ptr<ReportingCurrencyType> currencyType_;
       std::string currencyTypeIDRef_;
       bool currencyTypeIsNull_;
       boost::shared_ptr<QuoteTiming> timing_;
       std::string timingIDRef_;
       bool timingIsNull_;
         boost::shared_ptr<BusinessCenter> businessCenter_;     //choice
       std::string businessCenterIDRef_;
       bool businessCenterIsNull_;
         boost::shared_ptr<ExchangeId> exchangeId_;     //choice
       std::string exchangeIdIDRef_;
       bool exchangeIdIsNull_;
       std::vector<boost::shared_ptr<InformationSource>> informationSource_;
       std::string informationSourceIDRef_;
       bool informationSourceIsNull_;
       boost::shared_ptr<PricingModel> pricingModel_;
       std::string pricingModelIDRef_;
       bool pricingModelIsNull_;
       boost::shared_ptr<XsdTypeDateTime> time_;
       std::string timeIDRef_;
       bool timeIsNull_;
       boost::shared_ptr<XsdTypeDate> valuationDate_;
       std::string valuationDateIDRef_;
       bool valuationDateIsNull_;
       boost::shared_ptr<XsdTypeDateTime> expiryTime_;
       std::string expiryTimeIDRef_;
       bool expiryTimeIsNull_;
       boost::shared_ptr<CashflowType> cashflowType_;
       std::string cashflowTypeIDRef_;
       bool cashflowTypeIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;

};

} //namespaceFpmlSerialized end
#endif

