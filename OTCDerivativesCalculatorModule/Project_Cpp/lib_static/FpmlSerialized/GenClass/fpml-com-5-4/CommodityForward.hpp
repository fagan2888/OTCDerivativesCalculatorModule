// CommodityForward.hpp 
#ifndef FpmlSerialized_CommodityForward_hpp
#define FpmlSerialized_CommodityForward_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-com-5-4/NonPeriodicFixedPriceLeg.hpp>
#include <fpml-com-5-4/AveragePriceLeg.hpp>
#include <fpml-com-5-4/CommodityForwardLeg.hpp>
#include <fpml-com-5-4/BullionPhysicalLeg.hpp>
#include <fpml-com-5-4/MetalPhysicalLeg.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CommodityMarketDisruption.hpp>
#include <fpml-enum-5-4/CommodityBullionSettlementDisruptionEnum.hpp>
#include <fpml-shared-5-4/Rounding.hpp>

namespace FpmlSerialized {

class CommodityForward : public Product { 
   public: 
       CommodityForward(TiXmlNode* xmlNode);

       bool isValueDate(){return this->valueDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getValueDate();
      std::string getValueDateIDRef(){return valueDateIDRef_;}

       bool isFixedLeg(){return this->fixedLegIsNull_;}
       boost::shared_ptr<NonPeriodicFixedPriceLeg> getFixedLeg();
      std::string getFixedLegIDRef(){return fixedLegIDRef_;}

       bool isAveragePriceLeg(){return this->averagePriceLegIsNull_;}
       boost::shared_ptr<AveragePriceLeg> getAveragePriceLeg();
      std::string getAveragePriceLegIDRef(){return averagePriceLegIDRef_;}

       bool isCommodityForwardLeg(){return this->commodityForwardLegIsNull_;}
       boost::shared_ptr<CommodityForwardLeg> getCommodityForwardLeg();
      std::string getCommodityForwardLegIDRef(){return commodityForwardLegIDRef_;}

       bool isBullionPhysicalLeg(){return this->bullionPhysicalLegIsNull_;}
       boost::shared_ptr<BullionPhysicalLeg> getBullionPhysicalLeg();
      std::string getBullionPhysicalLegIDRef(){return bullionPhysicalLegIDRef_;}

       bool isMetalPhysicalLeg(){return this->metalPhysicalLegIsNull_;}
       boost::shared_ptr<MetalPhysicalLeg> getMetalPhysicalLeg();
      std::string getMetalPhysicalLegIDRef(){return metalPhysicalLegIDRef_;}

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
           if(!fixedLegIsNull_){
                count += 1;
                str = "fixedLeg" ;
           }
           if(!averagePriceLegIsNull_){
                count += 1;
                str = "averagePriceLeg" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> valueDate_;
       std::string valueDateIDRef_;
       bool valueDateIsNull_;
         boost::shared_ptr<NonPeriodicFixedPriceLeg> fixedLeg_;     //choice
       std::string fixedLegIDRef_;
       bool fixedLegIsNull_;
         boost::shared_ptr<AveragePriceLeg> averagePriceLeg_;     //choice
       std::string averagePriceLegIDRef_;
       bool averagePriceLegIsNull_;
       boost::shared_ptr<CommodityForwardLeg> commodityForwardLeg_;
       std::string commodityForwardLegIDRef_;
       bool commodityForwardLegIsNull_;
       boost::shared_ptr<BullionPhysicalLeg> bullionPhysicalLeg_;     //substitude 
       std::string bullionPhysicalLegIDRef_;
       bool bullionPhysicalLegIsNull_;
       boost::shared_ptr<MetalPhysicalLeg> metalPhysicalLeg_;     //substitude 
       std::string metalPhysicalLegIDRef_;
       bool metalPhysicalLegIsNull_;
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

