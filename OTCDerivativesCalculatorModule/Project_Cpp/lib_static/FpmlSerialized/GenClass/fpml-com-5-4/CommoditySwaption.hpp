// CommoditySwaption.hpp 
#ifndef FpmlSerialized_CommoditySwaption_hpp
#define FpmlSerialized_CommoditySwaption_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-enum-5-4/PutCallEnum.hpp>
#include <fpml-com-5-4/CommoditySwaptionUnderlying.hpp>
#include <fpml-com-5-4/CommodityPhysicalExercise.hpp>
#include <fpml-com-5-4/CommodityPremium.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CommodityMarketDisruption.hpp>
#include <fpml-enum-5-4/CommodityBullionSettlementDisruptionEnum.hpp>
#include <fpml-shared-5-4/Rounding.hpp>

namespace FpmlSerialized {

class CommoditySwaption : public Product { 
   public: 
       CommoditySwaption(TiXmlNode* xmlNode);

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

       bool isCommoditySwap(){return this->commoditySwapIsNull_;}
       boost::shared_ptr<CommoditySwaptionUnderlying> getCommoditySwap();
      std::string getCommoditySwapIDRef(){return commoditySwapIDRef_;}

       bool isPhysicalExercise(){return this->physicalExerciseIsNull_;}
       boost::shared_ptr<CommodityPhysicalExercise> getPhysicalExercise();
      std::string getPhysicalExerciseIDRef(){return physicalExerciseIDRef_;}

       bool isPremium(){return this->premiumIsNull_;}
       boost::shared_ptr<CommodityPremium> getPremium();
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
       boost::shared_ptr<CommoditySwaptionUnderlying> commoditySwap_;
       std::string commoditySwapIDRef_;
       bool commoditySwapIsNull_;
       boost::shared_ptr<CommodityPhysicalExercise> physicalExercise_;
       std::string physicalExerciseIDRef_;
       bool physicalExerciseIsNull_;
       boost::shared_ptr<CommodityPremium> premium_;
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

};

} //namespaceFpmlSerialized end
#endif

