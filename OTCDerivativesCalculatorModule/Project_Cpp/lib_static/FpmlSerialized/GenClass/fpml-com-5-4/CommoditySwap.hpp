// CommoditySwap.hpp 
#ifndef FpmlSerialized_CommoditySwap_hpp
#define FpmlSerialized_CommoditySwap_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/IdentifiedCurrency.hpp>
#include <fpml-com-5-4/CommoditySwapLeg.hpp>
#include <fpml-com-5-4/CoalPhysicalLeg.hpp>
#include <fpml-com-5-4/ElectricityPhysicalLeg.hpp>
#include <fpml-com-5-4/EnvironmentalPhysicalLeg.hpp>
#include <fpml-com-5-4/FixedPriceLeg.hpp>
#include <fpml-com-5-4/FloatingPriceLeg.hpp>
#include <fpml-com-5-4/GasPhysicalLeg.hpp>
#include <fpml-com-5-4/OilPhysicalLeg.hpp>
#include <fpml-com-5-4/WeatherLeg.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CommodityMarketDisruption.hpp>
#include <fpml-enum-5-4/CommodityBullionSettlementDisruptionEnum.hpp>
#include <fpml-shared-5-4/Rounding.hpp>

namespace FpmlSerialized {

class CommoditySwap : public Product { 
   public: 
       CommoditySwap(TiXmlNode* xmlNode);

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isTerminationDate(){return this->terminationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getTerminationDate();
      std::string getTerminationDateIDRef(){return terminationDateIDRef_;}

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       boost::shared_ptr<IdentifiedCurrency> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

       bool isCommoditySwapLeg(){return this->commoditySwapLegIsNull_;}
       boost::shared_ptr<CommoditySwapLeg> getCommoditySwapLeg();
      std::string getCommoditySwapLegIDRef(){return commoditySwapLegIDRef_;}

       bool isCoalPhysicalLeg(){return this->coalPhysicalLegIsNull_;}
       boost::shared_ptr<CoalPhysicalLeg> getCoalPhysicalLeg();
      std::string getCoalPhysicalLegIDRef(){return coalPhysicalLegIDRef_;}

       bool isElectricityPhysicalLeg(){return this->electricityPhysicalLegIsNull_;}
       boost::shared_ptr<ElectricityPhysicalLeg> getElectricityPhysicalLeg();
      std::string getElectricityPhysicalLegIDRef(){return electricityPhysicalLegIDRef_;}

       bool isEnvironmentalPhysicalLeg(){return this->environmentalPhysicalLegIsNull_;}
       boost::shared_ptr<EnvironmentalPhysicalLeg> getEnvironmentalPhysicalLeg();
      std::string getEnvironmentalPhysicalLegIDRef(){return environmentalPhysicalLegIDRef_;}

       bool isFixedLeg(){return this->fixedLegIsNull_;}
       boost::shared_ptr<FixedPriceLeg> getFixedLeg();
      std::string getFixedLegIDRef(){return fixedLegIDRef_;}

       bool isFloatingLeg(){return this->floatingLegIsNull_;}
       boost::shared_ptr<FloatingPriceLeg> getFloatingLeg();
      std::string getFloatingLegIDRef(){return floatingLegIDRef_;}

       bool isGasPhysicalLeg(){return this->gasPhysicalLegIsNull_;}
       boost::shared_ptr<GasPhysicalLeg> getGasPhysicalLeg();
      std::string getGasPhysicalLegIDRef(){return gasPhysicalLegIDRef_;}

       bool isOilPhysicalLeg(){return this->oilPhysicalLegIsNull_;}
       boost::shared_ptr<OilPhysicalLeg> getOilPhysicalLeg();
      std::string getOilPhysicalLegIDRef(){return oilPhysicalLegIDRef_;}

       bool isWeatherLeg(){return this->weatherLegIsNull_;}
       std::vector<boost::shared_ptr<WeatherLeg>> getWeatherLeg();
      std::string getWeatherLegIDRef(){return weatherLegIDRef_;}

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
           if(!commoditySwapLegIsNull_){
                count += 1;
                str = "commoditySwapLeg" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> terminationDate_;
       std::string terminationDateIDRef_;
       bool terminationDateIsNull_;
       boost::shared_ptr<IdentifiedCurrency> settlementCurrency_;
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;
         boost::shared_ptr<CommoditySwapLeg> commoditySwapLeg_;     //choice
       std::string commoditySwapLegIDRef_;
       bool commoditySwapLegIsNull_;
       boost::shared_ptr<CoalPhysicalLeg> coalPhysicalLeg_;     //substitude 
       std::string coalPhysicalLegIDRef_;
       bool coalPhysicalLegIsNull_;
       boost::shared_ptr<ElectricityPhysicalLeg> electricityPhysicalLeg_;     //substitude 
       std::string electricityPhysicalLegIDRef_;
       bool electricityPhysicalLegIsNull_;
       boost::shared_ptr<EnvironmentalPhysicalLeg> environmentalPhysicalLeg_;     //substitude 
       std::string environmentalPhysicalLegIDRef_;
       bool environmentalPhysicalLegIsNull_;
       boost::shared_ptr<FixedPriceLeg> fixedLeg_;     //substitude 
       std::string fixedLegIDRef_;
       bool fixedLegIsNull_;
       boost::shared_ptr<FloatingPriceLeg> floatingLeg_;     //substitude 
       std::string floatingLegIDRef_;
       bool floatingLegIsNull_;
       boost::shared_ptr<GasPhysicalLeg> gasPhysicalLeg_;     //substitude 
       std::string gasPhysicalLegIDRef_;
       bool gasPhysicalLegIsNull_;
       boost::shared_ptr<OilPhysicalLeg> oilPhysicalLeg_;     //substitude 
       std::string oilPhysicalLegIDRef_;
       bool oilPhysicalLegIsNull_;
       std::vector<boost::shared_ptr<WeatherLeg>> weatherLeg_;
       std::string weatherLegIDRef_;
       bool weatherLegIsNull_;
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

};

} //namespaceFpmlSerialized end
#endif

