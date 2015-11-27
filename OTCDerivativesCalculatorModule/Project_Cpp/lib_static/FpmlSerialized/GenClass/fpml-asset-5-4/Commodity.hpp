// Commodity.hpp 
#ifndef FpmlSerialized_Commodity_hpp
#define FpmlSerialized_Commodity_hpp

#include <fpml-asset-5-4/IdentifiedAsset.hpp>
#include <fpml-asset-5-4/CommodityBase.hpp>
#include <fpml-asset-5-4/CommodityDetails.hpp>
#include <fpml-asset-5-4/QuantityUnit.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-shared-5-4/ExchangeId.hpp>
#include <fpml-asset-5-4/CommodityInformationSource.hpp>
#include <fpml-enum-5-4/SpecifiedPriceEnum.hpp>
#include <fpml-enum-5-4/DeliveryDatesEnum.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>
#include <built_in_type/XsdTypeGYearMonth.hpp>
#include <fpml-shared-5-4/Offset.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>

namespace FpmlSerialized {

class Commodity : public IdentifiedAsset { 
   public: 
       Commodity(TiXmlNode* xmlNode);

       bool isCommodityBase(){return this->commodityBaseIsNull_;}
       boost::shared_ptr<CommodityBase> getCommodityBase();
      std::string getCommodityBaseIDRef(){return commodityBaseIDRef_;}

       bool isCommodityDetails(){return this->commodityDetailsIsNull_;}
       boost::shared_ptr<CommodityDetails> getCommodityDetails();
      std::string getCommodityDetailsIDRef(){return commodityDetailsIDRef_;}

       bool isUnit(){return this->unitIsNull_;}
       boost::shared_ptr<QuantityUnit> getUnit();
      std::string getUnitIDRef(){return unitIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isExchangeId(){return this->exchangeIdIsNull_;}
       boost::shared_ptr<ExchangeId> getExchangeId();
      std::string getExchangeIdIDRef(){return exchangeIdIDRef_;}

       bool isPublication(){return this->publicationIsNull_;}
       boost::shared_ptr<CommodityInformationSource> getPublication();
      std::string getPublicationIDRef(){return publicationIDRef_;}

       bool isSpecifiedPrice(){return this->specifiedPriceIsNull_;}
       boost::shared_ptr<SpecifiedPriceEnum> getSpecifiedPrice();
      std::string getSpecifiedPriceIDRef(){return specifiedPriceIDRef_;}

       bool isDeliveryDates(){return this->deliveryDatesIsNull_;}
       boost::shared_ptr<DeliveryDatesEnum> getDeliveryDates();
      std::string getDeliveryDatesIDRef(){return deliveryDatesIDRef_;}

       bool isDeliveryDate(){return this->deliveryDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getDeliveryDate();
      std::string getDeliveryDateIDRef(){return deliveryDateIDRef_;}

       bool isDeliveryDateYearMonth(){return this->deliveryDateYearMonthIsNull_;}
       boost::shared_ptr<XsdTypeGYearMonth> getDeliveryDateYearMonth();
      std::string getDeliveryDateYearMonthIDRef(){return deliveryDateYearMonthIDRef_;}

       bool isDeliveryDateRollConvention(){return this->deliveryDateRollConventionIsNull_;}
       boost::shared_ptr<Offset> getDeliveryDateRollConvention();
      std::string getDeliveryDateRollConventionIDRef(){return deliveryDateRollConventionIDRef_;}

       bool isMultiplier(){return this->multiplierIsNull_;}
       boost::shared_ptr<PositiveDecimal> getMultiplier();
      std::string getMultiplierIDRef(){return multiplierIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!exchangeIdIsNull_){
                count += 1;
                str = "exchangeId" ;
           }
           if(!publicationIsNull_){
                count += 1;
                str = "publication" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!deliveryDatesIsNull_){
                count += 1;
                str = "deliveryDates" ;
           }
           if(!deliveryDateIsNull_){
                count += 1;
                str = "deliveryDate" ;
           }
           if(!deliveryDateYearMonthIsNull_){
                count += 1;
                str = "deliveryDateYearMonth" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
       boost::shared_ptr<CommodityBase> commodityBase_;
       std::string commodityBaseIDRef_;
       bool commodityBaseIsNull_;
       boost::shared_ptr<CommodityDetails> commodityDetails_;
       std::string commodityDetailsIDRef_;
       bool commodityDetailsIsNull_;
       boost::shared_ptr<QuantityUnit> unit_;
       std::string unitIDRef_;
       bool unitIsNull_;
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;
         boost::shared_ptr<ExchangeId> exchangeId_;     //choice
       std::string exchangeIdIDRef_;
       bool exchangeIdIsNull_;
         boost::shared_ptr<CommodityInformationSource> publication_;     //choice
       std::string publicationIDRef_;
       bool publicationIsNull_;
       boost::shared_ptr<SpecifiedPriceEnum> specifiedPrice_;
       std::string specifiedPriceIDRef_;
       bool specifiedPriceIsNull_;
         boost::shared_ptr<DeliveryDatesEnum> deliveryDates_;     //choice
       std::string deliveryDatesIDRef_;
       bool deliveryDatesIsNull_;
         boost::shared_ptr<AdjustableDate> deliveryDate_;     //choice
       std::string deliveryDateIDRef_;
       bool deliveryDateIsNull_;
         boost::shared_ptr<XsdTypeGYearMonth> deliveryDateYearMonth_;     //choice
       std::string deliveryDateYearMonthIDRef_;
       bool deliveryDateYearMonthIsNull_;
       boost::shared_ptr<Offset> deliveryDateRollConvention_;
       std::string deliveryDateRollConventionIDRef_;
       bool deliveryDateRollConventionIsNull_;
       boost::shared_ptr<PositiveDecimal> multiplier_;
       std::string multiplierIDRef_;
       bool multiplierIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

