// CommodityOption.hpp 
#ifndef FpmlSerialized_CommodityOption_hpp
#define FpmlSerialized_CommodityOption_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-enum-5-4/PutCallEnum.hpp>
#include <fpml-asset-5-4/Commodity.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-com-5-4/CommodityCalculationPeriodsSchedule.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-com-5-4/CommodityPricingDates.hpp>
#include <fpml-enum-5-4/AveragingMethodEnum.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantitySchedule.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/CommoditySettlementPeriodsNotionalQuantity.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-com-5-4/QuantityReference.hpp>
#include <fpml-com-5-4/CommodityExercise.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-com-5-4/CommodityStrikeSchedule.hpp>
#include <fpml-com-5-4/FloatingStrikePrice.hpp>
#include <fpml-com-5-4/CommoditySwap.hpp>
#include <fpml-com-5-4/CommodityForward.hpp>
#include <fpml-com-5-4/CommodityPhysicalExercise.hpp>
#include <fpml-com-5-4/WeatherCalculationPeriods.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/WeatherIndex.hpp>
#include <fpml-com-5-4/WeatherLegCalculation.hpp>
#include <fpml-com-5-4/WeatherIndexData.hpp>
#include <fpml-com-5-4/CommodityPremium.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CommodityMarketDisruption.hpp>
#include <fpml-enum-5-4/CommodityBullionSettlementDisruptionEnum.hpp>
#include <fpml-shared-5-4/Rounding.hpp>

namespace FpmlSerialized {

class CommodityOption : public Product { 
   public: 
       CommodityOption(TiXmlNode* xmlNode);

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

       bool isOptionType(){return this->optionTypeIsNull_;}
       boost::shared_ptr<PutCallEnum> getOptionType();
      std::string getOptionTypeIDRef(){return optionTypeIDRef_;}

       bool isCommodity(){return this->commodityIsNull_;}
       boost::shared_ptr<Commodity> getCommodity();
      std::string getCommodityIDRef(){return commodityIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isTerminationDate(){return this->terminationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getTerminationDate();
      std::string getTerminationDateIDRef(){return terminationDateIDRef_;}

       bool isCalculationPeriodsSchedule(){return this->calculationPeriodsScheduleIsNull_;}
       boost::shared_ptr<CommodityCalculationPeriodsSchedule> getCalculationPeriodsSchedule();
      std::string getCalculationPeriodsScheduleIDRef(){return calculationPeriodsScheduleIDRef_;}

       bool isCalculationPeriods(){return this->calculationPeriodsIsNull_;}
       boost::shared_ptr<AdjustableDates> getCalculationPeriods();
      std::string getCalculationPeriodsIDRef(){return calculationPeriodsIDRef_;}

       bool isPricingDates(){return this->pricingDatesIsNull_;}
       boost::shared_ptr<CommodityPricingDates> getPricingDates();
      std::string getPricingDatesIDRef(){return pricingDatesIDRef_;}

       bool isAveragingMethod(){return this->averagingMethodIsNull_;}
       boost::shared_ptr<AveragingMethodEnum> getAveragingMethod();
      std::string getAveragingMethodIDRef(){return averagingMethodIDRef_;}

       bool isNotionalQuantitySchedule(){return this->notionalQuantityScheduleIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantitySchedule> getNotionalQuantitySchedule();
      std::string getNotionalQuantityScheduleIDRef(){return notionalQuantityScheduleIDRef_;}

       bool isNotionalQuantity(){return this->notionalQuantityIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantity> getNotionalQuantity();
      std::string getNotionalQuantityIDRef(){return notionalQuantityIDRef_;}

       bool isSettlementPeriodsNotionalQuantity(){return this->settlementPeriodsNotionalQuantityIsNull_;}
       std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>> getSettlementPeriodsNotionalQuantity();
      std::string getSettlementPeriodsNotionalQuantityIDRef(){return settlementPeriodsNotionalQuantityIDRef_;}

       bool isTotalNotionalQuantity(){return this->totalNotionalQuantityIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getTotalNotionalQuantity();
      std::string getTotalNotionalQuantityIDRef(){return totalNotionalQuantityIDRef_;}

       bool isQuantityReference(){return this->quantityReferenceIsNull_;}
       boost::shared_ptr<QuantityReference> getQuantityReference();
      std::string getQuantityReferenceIDRef(){return quantityReferenceIDRef_;}

       bool isExercise(){return this->exerciseIsNull_;}
       boost::shared_ptr<CommodityExercise> getExercise();
      std::string getExerciseIDRef(){return exerciseIDRef_;}

       bool isStrikePricePerUnit(){return this->strikePricePerUnitIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getStrikePricePerUnit();
      std::string getStrikePricePerUnitIDRef(){return strikePricePerUnitIDRef_;}

       bool isStrikePricePerUnitSchedule(){return this->strikePricePerUnitScheduleIsNull_;}
       boost::shared_ptr<CommodityStrikeSchedule> getStrikePricePerUnitSchedule();
      std::string getStrikePricePerUnitScheduleIDRef(){return strikePricePerUnitScheduleIDRef_;}

       bool isFloatingStrikePricePerUnit(){return this->floatingStrikePricePerUnitIsNull_;}
       boost::shared_ptr<FloatingStrikePrice> getFloatingStrikePricePerUnit();
      std::string getFloatingStrikePricePerUnitIDRef(){return floatingStrikePricePerUnitIDRef_;}

       bool isFloatingStrikePricePerUnitSchedule(){return this->floatingStrikePricePerUnitScheduleIsNull_;}
       boost::shared_ptr<CommodityCalculationPeriodsSchedule> getFloatingStrikePricePerUnitSchedule();
      std::string getFloatingStrikePricePerUnitScheduleIDRef(){return floatingStrikePricePerUnitScheduleIDRef_;}

       bool isCommoditySwap(){return this->commoditySwapIsNull_;}
       boost::shared_ptr<CommoditySwap> getCommoditySwap();
      std::string getCommoditySwapIDRef(){return commoditySwapIDRef_;}

       bool isCommodityForward(){return this->commodityForwardIsNull_;}
       boost::shared_ptr<CommodityForward> getCommodityForward();
      std::string getCommodityForwardIDRef(){return commodityForwardIDRef_;}

       bool isPhysicalExercise(){return this->physicalExerciseIsNull_;}
       boost::shared_ptr<CommodityPhysicalExercise> getPhysicalExercise();
      std::string getPhysicalExerciseIDRef(){return physicalExerciseIDRef_;}

       bool isWeatherCalculationPeriods(){return this->weatherCalculationPeriodsIsNull_;}
       boost::shared_ptr<WeatherCalculationPeriods> getWeatherCalculationPeriods();
      std::string getWeatherCalculationPeriodsIDRef(){return weatherCalculationPeriodsIDRef_;}

       bool isWeatherCalculationPeriodsReference(){return this->weatherCalculationPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getWeatherCalculationPeriodsReference();
      std::string getWeatherCalculationPeriodsReferenceIDRef(){return weatherCalculationPeriodsReferenceIDRef_;}

       bool isWeatherNotionalAmount(){return this->weatherNotionalAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getWeatherNotionalAmount();
      std::string getWeatherNotionalAmountIDRef(){return weatherNotionalAmountIDRef_;}

       bool isWeatherIndexStrikeLevel(){return this->weatherIndexStrikeLevelIsNull_;}
       boost::shared_ptr<WeatherIndex> getWeatherIndexStrikeLevel();
      std::string getWeatherIndexStrikeLevelIDRef(){return weatherIndexStrikeLevelIDRef_;}

       bool isCalculation(){return this->calculationIsNull_;}
       boost::shared_ptr<WeatherLegCalculation> getCalculation();
      std::string getCalculationIDRef(){return calculationIDRef_;}

       bool isWeatherIndexData(){return this->weatherIndexDataIsNull_;}
       boost::shared_ptr<WeatherIndexData> getWeatherIndexData();
      std::string getWeatherIndexDataIDRef(){return weatherIndexDataIDRef_;}

       bool isPremium(){return this->premiumIsNull_;}
       std::vector<boost::shared_ptr<CommodityPremium>> getPremium();
      std::string getPremiumIDRef(){return premiumIDRef_;}

       bool isCommonPricing(){return this->commonPricingIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getCommonPricing();
      std::string getCommonPricingIDRef(){return commonPricingIDRef_;}

       bool isMarketDisruption(){return this->marketDisruptionIsNull_;}
       boost::shared_ptr<CommodityMarketDisruption> getMarketDisruption();
      std::string getMarketDisruptionIDRef(){return marketDisruptionIDRef_;}

       bool isSettlementDisruption(){return this->settlementDisruptionIsNull_;}
       boost::shared_ptr<CommodityBullionSettlementDisruptionEnum> getSettlementDisruption();
      std::string getSettlementDisruptionIDRef(){return settlementDisruptionIDRef_;}

       bool isRounding(){return this->roundingIsNull_;}
       boost::shared_ptr<Rounding> getRounding();
      std::string getRoundingIDRef(){return roundingIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!commodityIsNull_){
                count += 1;
                str = "commodity" ;
           }
           if(!effectiveDateIsNull_){
                count += 1;
                str = "effectiveDate" ;
           }
           if(!terminationDateIsNull_){
                count += 1;
                str = "terminationDate" ;
           }
           if(!pricingDatesIsNull_){
                count += 1;
                str = "pricingDates" ;
           }
           if(!averagingMethodIsNull_){
                count += 1;
                str = "averagingMethod" ;
           }
           if(!exerciseIsNull_){
                count += 1;
                str = "exercise" ;
           }
           if(!physicalExerciseIsNull_){
                count += 1;
                str = "physicalExercise" ;
           }
           if(!effectiveDateIsNull_){
                count += 1;
                str = "effectiveDate" ;
           }
           if(!weatherNotionalAmountIsNull_){
                count += 1;
                str = "weatherNotionalAmount" ;
           }
           if(!exerciseIsNull_){
                count += 1;
                str = "exercise" ;
           }
           if(!weatherIndexStrikeLevelIsNull_){
                count += 1;
                str = "weatherIndexStrikeLevel" ;
           }
           if(!calculationIsNull_){
                count += 1;
                str = "calculation" ;
           }
           if(!weatherIndexDataIsNull_){
                count += 1;
                str = "weatherIndexData" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!calculationPeriodsScheduleIsNull_){
                count += 1;
                str = "calculationPeriodsSchedule" ;
           }
           if(!calculationPeriodsIsNull_){
                count += 1;
                str = "calculationPeriods" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!totalNotionalQuantityIsNull_){
                count += 1;
                str = "totalNotionalQuantity" ;
           }
           if(!quantityReferenceIsNull_){
                count += 1;
                str = "quantityReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
       std::string getChoiceStr_3(){
           std::string str;
           int count = 0;
           if(!notionalQuantityScheduleIsNull_){
                count += 1;
                str = "notionalQuantitySchedule" ;
           }
           if(!notionalQuantityIsNull_){
                count += 1;
                str = "notionalQuantity" ;
           }
           if(!settlementPeriodsNotionalQuantityIsNull_){
                count += 1;
                str = "settlementPeriodsNotionalQuantity" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_3_ = str ;
           return choiceStr_3_;
       }
       std::string getChoiceStr_4(){
           std::string str;
           int count = 0;
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_4_ = str ;
           return choiceStr_4_;
       }
       std::string getChoiceStr_5(){
           std::string str;
           int count = 0;
           if(!strikePricePerUnitIsNull_){
                count += 1;
                str = "strikePricePerUnit" ;
           }
           if(!strikePricePerUnitScheduleIsNull_){
                count += 1;
                str = "strikePricePerUnitSchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_5_ = str ;
           return choiceStr_5_;
       }
       std::string getChoiceStr_6(){
           std::string str;
           int count = 0;
           if(!floatingStrikePricePerUnitIsNull_){
                count += 1;
                str = "floatingStrikePricePerUnit" ;
           }
           if(!floatingStrikePricePerUnitScheduleIsNull_){
                count += 1;
                str = "floatingStrikePricePerUnitSchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_6_ = str ;
           return choiceStr_6_;
       }
       std::string getChoiceStr_7(){
           std::string str;
           int count = 0;
           if(!commoditySwapIsNull_){
                count += 1;
                str = "commoditySwap" ;
           }
           if(!commodityForwardIsNull_){
                count += 1;
                str = "commodityForward" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_7_ = str ;
           return choiceStr_7_;
       }
       std::string getChoiceStr_8(){
           std::string str;
           int count = 0;
           if(!weatherCalculationPeriodsIsNull_){
                count += 1;
                str = "weatherCalculationPeriods" ;
           }
           if(!weatherCalculationPeriodsReferenceIsNull_){
                count += 1;
                str = "weatherCalculationPeriodsReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_8_ = str ;
           return choiceStr_8_;
       }
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
       boost::shared_ptr<PutCallEnum> optionType_;
       std::string optionTypeIDRef_;
       bool optionTypeIsNull_;
         boost::shared_ptr<Commodity> commodity_;     //choice
       std::string commodityIDRef_;
       bool commodityIsNull_;
         boost::shared_ptr<AdjustableOrRelativeDate> effectiveDate_;     //choice
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
         boost::shared_ptr<AdjustableOrRelativeDate> terminationDate_;     //choice
       std::string terminationDateIDRef_;
       bool terminationDateIsNull_;
         boost::shared_ptr<CommodityCalculationPeriodsSchedule> calculationPeriodsSchedule_;     //choice
       std::string calculationPeriodsScheduleIDRef_;
       bool calculationPeriodsScheduleIsNull_;
         boost::shared_ptr<AdjustableDates> calculationPeriods_;     //choice
       std::string calculationPeriodsIDRef_;
       bool calculationPeriodsIsNull_;
         boost::shared_ptr<CommodityPricingDates> pricingDates_;     //choice
       std::string pricingDatesIDRef_;
       bool pricingDatesIsNull_;
         boost::shared_ptr<AveragingMethodEnum> averagingMethod_;     //choice
       std::string averagingMethodIDRef_;
       bool averagingMethodIsNull_;
         boost::shared_ptr<CommodityNotionalQuantitySchedule> notionalQuantitySchedule_;     //choice
       std::string notionalQuantityScheduleIDRef_;
       bool notionalQuantityScheduleIsNull_;
         boost::shared_ptr<CommodityNotionalQuantity> notionalQuantity_;     //choice
       std::string notionalQuantityIDRef_;
       bool notionalQuantityIsNull_;
         std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>> settlementPeriodsNotionalQuantity_;     //choice
       std::string settlementPeriodsNotionalQuantityIDRef_;
       bool settlementPeriodsNotionalQuantityIsNull_;
         boost::shared_ptr<XsdTypeDecimal> totalNotionalQuantity_;     //choice
       std::string totalNotionalQuantityIDRef_;
       bool totalNotionalQuantityIsNull_;
         boost::shared_ptr<QuantityReference> quantityReference_;     //choice
       std::string quantityReferenceIDRef_;
       bool quantityReferenceIsNull_;
         boost::shared_ptr<CommodityExercise> exercise_;     //choice
       std::string exerciseIDRef_;
       bool exerciseIsNull_;
         boost::shared_ptr<NonNegativeMoney> strikePricePerUnit_;     //choice
       std::string strikePricePerUnitIDRef_;
       bool strikePricePerUnitIsNull_;
         boost::shared_ptr<CommodityStrikeSchedule> strikePricePerUnitSchedule_;     //choice
       std::string strikePricePerUnitScheduleIDRef_;
       bool strikePricePerUnitScheduleIsNull_;
         boost::shared_ptr<FloatingStrikePrice> floatingStrikePricePerUnit_;     //choice
       std::string floatingStrikePricePerUnitIDRef_;
       bool floatingStrikePricePerUnitIsNull_;
         boost::shared_ptr<CommodityCalculationPeriodsSchedule> floatingStrikePricePerUnitSchedule_;     //choice
       std::string floatingStrikePricePerUnitScheduleIDRef_;
       bool floatingStrikePricePerUnitScheduleIsNull_;
         boost::shared_ptr<CommoditySwap> commoditySwap_;     //choice
       std::string commoditySwapIDRef_;
       bool commoditySwapIsNull_;
         boost::shared_ptr<CommodityForward> commodityForward_;     //choice
       std::string commodityForwardIDRef_;
       bool commodityForwardIsNull_;
         boost::shared_ptr<CommodityPhysicalExercise> physicalExercise_;     //choice
       std::string physicalExerciseIDRef_;
       bool physicalExerciseIsNull_;
         boost::shared_ptr<WeatherCalculationPeriods> weatherCalculationPeriods_;     //choice
       std::string weatherCalculationPeriodsIDRef_;
       bool weatherCalculationPeriodsIsNull_;
         boost::shared_ptr<CalculationPeriodsReference> weatherCalculationPeriodsReference_;     //choice
       std::string weatherCalculationPeriodsReferenceIDRef_;
       bool weatherCalculationPeriodsReferenceIsNull_;
         boost::shared_ptr<NonNegativeMoney> weatherNotionalAmount_;     //choice
       std::string weatherNotionalAmountIDRef_;
       bool weatherNotionalAmountIsNull_;
         boost::shared_ptr<WeatherIndex> weatherIndexStrikeLevel_;     //choice
       std::string weatherIndexStrikeLevelIDRef_;
       bool weatherIndexStrikeLevelIsNull_;
         boost::shared_ptr<WeatherLegCalculation> calculation_;     //choice
       std::string calculationIDRef_;
       bool calculationIsNull_;
         boost::shared_ptr<WeatherIndexData> weatherIndexData_;     //choice
       std::string weatherIndexDataIDRef_;
       bool weatherIndexDataIsNull_;
       std::vector<boost::shared_ptr<CommodityPremium>> premium_;
       std::string premiumIDRef_;
       bool premiumIsNull_;
       boost::shared_ptr<XsdTypeBoolean> commonPricing_;
       std::string commonPricingIDRef_;
       bool commonPricingIsNull_;
       boost::shared_ptr<CommodityMarketDisruption> marketDisruption_;
       std::string marketDisruptionIDRef_;
       bool marketDisruptionIsNull_;
       boost::shared_ptr<CommodityBullionSettlementDisruptionEnum> settlementDisruption_;
       std::string settlementDisruptionIDRef_;
       bool settlementDisruptionIsNull_;
       boost::shared_ptr<Rounding> rounding_;
       std::string roundingIDRef_;
       bool roundingIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;
       std::string choiceStr_3_;
       std::string choiceStr_4_;
       std::string choiceStr_5_;
       std::string choiceStr_6_;
       std::string choiceStr_7_;
       std::string choiceStr_8_;

};

} //namespaceFpmlSerialized end
#endif

