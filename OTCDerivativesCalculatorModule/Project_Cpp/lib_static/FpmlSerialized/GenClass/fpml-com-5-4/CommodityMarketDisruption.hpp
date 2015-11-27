// CommodityMarketDisruption.hpp 
#ifndef FpmlSerialized_CommodityMarketDisruption_hpp
#define FpmlSerialized_CommodityMarketDisruption_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/MarketDisruptionEventsEnum.hpp>
#include <fpml-com-5-4/MarketDisruptionEvent.hpp>
#include <fpml-enum-5-4/DisruptionFallbacksEnum.hpp>
#include <fpml-com-5-4/SequencedDisruptionFallback.hpp>
#include <fpml-asset-5-4/Underlyer.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class CommodityMarketDisruption : public ISerialized { 
   public: 
       CommodityMarketDisruption(TiXmlNode* xmlNode);

       bool isMarketDisruptionEvents(){return this->marketDisruptionEventsIsNull_;}
       boost::shared_ptr<MarketDisruptionEventsEnum> getMarketDisruptionEvents();
      std::string getMarketDisruptionEventsIDRef(){return marketDisruptionEventsIDRef_;}

       bool isAdditionalMarketDisruptionEvent(){return this->additionalMarketDisruptionEventIsNull_;}
       std::vector<boost::shared_ptr<MarketDisruptionEvent>> getAdditionalMarketDisruptionEvent();
      std::string getAdditionalMarketDisruptionEventIDRef(){return additionalMarketDisruptionEventIDRef_;}

       bool isMarketDisruptionEvent(){return this->marketDisruptionEventIsNull_;}
       std::vector<boost::shared_ptr<MarketDisruptionEvent>> getMarketDisruptionEvent();
      std::string getMarketDisruptionEventIDRef(){return marketDisruptionEventIDRef_;}

       bool isDisruptionFallbacks(){return this->disruptionFallbacksIsNull_;}
       boost::shared_ptr<DisruptionFallbacksEnum> getDisruptionFallbacks();
      std::string getDisruptionFallbacksIDRef(){return disruptionFallbacksIDRef_;}

       bool isDisruptionFallback(){return this->disruptionFallbackIsNull_;}
       std::vector<boost::shared_ptr<SequencedDisruptionFallback>> getDisruptionFallback();
      std::string getDisruptionFallbackIDRef(){return disruptionFallbackIDRef_;}

       bool isFallbackReferencePrice(){return this->fallbackReferencePriceIsNull_;}
       boost::shared_ptr<Underlyer> getFallbackReferencePrice();
      std::string getFallbackReferencePriceIDRef(){return fallbackReferencePriceIDRef_;}

       bool isMaximumNumberOfDaysOfDisruption(){return this->maximumNumberOfDaysOfDisruptionIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getMaximumNumberOfDaysOfDisruption();
      std::string getMaximumNumberOfDaysOfDisruptionIDRef(){return maximumNumberOfDaysOfDisruptionIDRef_;}

       bool isPriceMaterialityPercentage(){return this->priceMaterialityPercentageIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPriceMaterialityPercentage();
      std::string getPriceMaterialityPercentageIDRef(){return priceMaterialityPercentageIDRef_;}

       bool isMinimumFuturesContracts(){return this->minimumFuturesContractsIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getMinimumFuturesContracts();
      std::string getMinimumFuturesContractsIDRef(){return minimumFuturesContractsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!marketDisruptionEventsIsNull_){
                count += 1;
                str = "marketDisruptionEvents" ;
           }
           if(!additionalMarketDisruptionEventIsNull_){
                count += 1;
                str = "additionalMarketDisruptionEvent" ;
           }
           if(!marketDisruptionEventIsNull_){
                count += 1;
                str = "marketDisruptionEvent" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!disruptionFallbacksIsNull_){
                count += 1;
                str = "disruptionFallbacks" ;
           }
           if(!disruptionFallbackIsNull_){
                count += 1;
                str = "disruptionFallback" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<MarketDisruptionEventsEnum> marketDisruptionEvents_;     //choice
       std::string marketDisruptionEventsIDRef_;
       bool marketDisruptionEventsIsNull_;
         std::vector<boost::shared_ptr<MarketDisruptionEvent>> additionalMarketDisruptionEvent_;     //choice
       std::string additionalMarketDisruptionEventIDRef_;
       bool additionalMarketDisruptionEventIsNull_;
         std::vector<boost::shared_ptr<MarketDisruptionEvent>> marketDisruptionEvent_;     //choice
       std::string marketDisruptionEventIDRef_;
       bool marketDisruptionEventIsNull_;
         boost::shared_ptr<DisruptionFallbacksEnum> disruptionFallbacks_;     //choice
       std::string disruptionFallbacksIDRef_;
       bool disruptionFallbacksIsNull_;
         std::vector<boost::shared_ptr<SequencedDisruptionFallback>> disruptionFallback_;     //choice
       std::string disruptionFallbackIDRef_;
       bool disruptionFallbackIsNull_;
       boost::shared_ptr<Underlyer> fallbackReferencePrice_;
       std::string fallbackReferencePriceIDRef_;
       bool fallbackReferencePriceIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> maximumNumberOfDaysOfDisruption_;
       std::string maximumNumberOfDaysOfDisruptionIDRef_;
       bool maximumNumberOfDaysOfDisruptionIsNull_;
       boost::shared_ptr<XsdTypeDecimal> priceMaterialityPercentage_;
       std::string priceMaterialityPercentageIDRef_;
       bool priceMaterialityPercentageIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> minimumFuturesContracts_;
       std::string minimumFuturesContractsIDRef_;
       bool minimumFuturesContractsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

