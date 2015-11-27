// FloatingLegCalculation.hpp 
#ifndef FpmlSerialized_FloatingLegCalculation_hpp
#define FpmlSerialized_FloatingLegCalculation_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityPricingDates.hpp>
#include <fpml-enum-5-4/AveragingMethodEnum.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Rounding.hpp>
#include <fpml-com-5-4/CommoditySpread.hpp>
#include <fpml-com-5-4/CommoditySpreadSchedule.hpp>
#include <fpml-com-5-4/CommodityFx.hpp>

namespace FpmlSerialized {

class FloatingLegCalculation : public ISerialized { 
   public: 
       FloatingLegCalculation(TiXmlNode* xmlNode);

       bool isPricingDates(){return this->pricingDatesIsNull_;}
       boost::shared_ptr<CommodityPricingDates> getPricingDates();
      std::string getPricingDatesIDRef(){return pricingDatesIDRef_;}

       bool isAveragingMethod(){return this->averagingMethodIsNull_;}
       boost::shared_ptr<AveragingMethodEnum> getAveragingMethod();
      std::string getAveragingMethodIDRef(){return averagingMethodIDRef_;}

       bool isConversionFactor(){return this->conversionFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getConversionFactor();
      std::string getConversionFactorIDRef(){return conversionFactorIDRef_;}

       bool isRounding(){return this->roundingIsNull_;}
       boost::shared_ptr<Rounding> getRounding();
      std::string getRoundingIDRef(){return roundingIDRef_;}

       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<CommoditySpread> getSpread();
      std::string getSpreadIDRef(){return spreadIDRef_;}

       bool isSpreadSchedule(){return this->spreadScheduleIsNull_;}
       std::vector<boost::shared_ptr<CommoditySpreadSchedule>> getSpreadSchedule();
      std::string getSpreadScheduleIDRef(){return spreadScheduleIDRef_;}

       bool isSpreadPercentage(){return this->spreadPercentageIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getSpreadPercentage();
      std::string getSpreadPercentageIDRef(){return spreadPercentageIDRef_;}

       bool isFx(){return this->fxIsNull_;}
       boost::shared_ptr<CommodityFx> getFx();
      std::string getFxIDRef(){return fxIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!spreadIsNull_){
                count += 1;
                str = "spread" ;
           }
           if(!spreadScheduleIsNull_){
                count += 1;
                str = "spreadSchedule" ;
           }
           if(!spreadPercentageIsNull_){
                count += 1;
                str = "spreadPercentage" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<CommodityPricingDates> pricingDates_;
       std::string pricingDatesIDRef_;
       bool pricingDatesIsNull_;
       boost::shared_ptr<AveragingMethodEnum> averagingMethod_;
       std::string averagingMethodIDRef_;
       bool averagingMethodIsNull_;
       boost::shared_ptr<XsdTypeDecimal> conversionFactor_;
       std::string conversionFactorIDRef_;
       bool conversionFactorIsNull_;
       boost::shared_ptr<Rounding> rounding_;
       std::string roundingIDRef_;
       bool roundingIsNull_;
         boost::shared_ptr<CommoditySpread> spread_;     //choice
       std::string spreadIDRef_;
       bool spreadIsNull_;
         std::vector<boost::shared_ptr<CommoditySpreadSchedule>> spreadSchedule_;     //choice
       std::string spreadScheduleIDRef_;
       bool spreadScheduleIsNull_;
         boost::shared_ptr<XsdTypeDecimal> spreadPercentage_;     //choice
       std::string spreadPercentageIDRef_;
       bool spreadPercentageIsNull_;
       boost::shared_ptr<CommodityFx> fx_;
       std::string fxIDRef_;
       bool fxIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

