// MultiDimensionalPricingData.hpp 
#ifndef FpmlSerialized_MultiDimensionalPricingData_hpp
#define FpmlSerialized_MultiDimensionalPricingData_hpp

#include <ISerialized.hpp>
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
#include <fpml-mktenv-5-4/PricingStructurePoint.hpp>

namespace FpmlSerialized {

class MultiDimensionalPricingData : public ISerialized { 
   public: 
       MultiDimensionalPricingData(TiXmlNode* xmlNode);

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

       bool isPoint(){return this->pointIsNull_;}
       std::vector<boost::shared_ptr<PricingStructurePoint>> getPoint();
      std::string getPointIDRef(){return pointIDRef_;}

       std::string getChoiceStr_0(){
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
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
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
       std::vector<boost::shared_ptr<PricingStructurePoint>> point_;
       std::string pointIDRef_;
       bool pointIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

