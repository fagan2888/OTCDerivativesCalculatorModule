// ReturnLeg.hpp 
#ifndef FpmlSerialized_ReturnLeg_hpp
#define FpmlSerialized_ReturnLeg_hpp

#include <fpml-eq-shared-5-4/ReturnSwapLegUnderlyer.hpp>
#include <fpml-eq-shared-5-4/ReturnLegValuation.hpp>
#include <fpml-eq-shared-5-4/ReturnSwapNotional.hpp>
#include <fpml-eq-shared-5-4/ReturnSwapAmount.hpp>
#include <fpml-eq-shared-5-4/Return.hpp>
#include <fpml-enum-5-4/NotionalAdjustmentEnum.hpp>
#include <fpml-option-shared-5-4/FxFeature.hpp>
#include <fpml-option-shared-5-4/AveragingPeriod.hpp>

namespace FpmlSerialized {

class ReturnLeg : public ReturnSwapLegUnderlyer { 
   public: 
       ReturnLeg(TiXmlNode* xmlNode);

       bool isRateOfReturn(){return this->rateOfReturnIsNull_;}
       boost::shared_ptr<ReturnLegValuation> getRateOfReturn();
      std::string getRateOfReturnIDRef(){return rateOfReturnIDRef_;}

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<ReturnSwapNotional> getNotional();
      std::string getNotionalIDRef(){return notionalIDRef_;}

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<ReturnSwapAmount> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

       bool isReturn(){return this->returnIsNull_;}
       boost::shared_ptr<Return> getReturn();
      std::string getReturnIDRef(){return returnIDRef_;}

       bool isNotionalAdjustments(){return this->notionalAdjustmentsIsNull_;}
       boost::shared_ptr<NotionalAdjustmentEnum> getNotionalAdjustments();
      std::string getNotionalAdjustmentsIDRef(){return notionalAdjustmentsIDRef_;}

       bool isFxFeature(){return this->fxFeatureIsNull_;}
       boost::shared_ptr<FxFeature> getFxFeature();
      std::string getFxFeatureIDRef(){return fxFeatureIDRef_;}

       bool isAveragingDates(){return this->averagingDatesIsNull_;}
       boost::shared_ptr<AveragingPeriod> getAveragingDates();
      std::string getAveragingDatesIDRef(){return averagingDatesIDRef_;}

   protected: 
       boost::shared_ptr<ReturnLegValuation> rateOfReturn_;
       std::string rateOfReturnIDRef_;
       bool rateOfReturnIsNull_;
       boost::shared_ptr<ReturnSwapNotional> notional_;
       std::string notionalIDRef_;
       bool notionalIsNull_;
       boost::shared_ptr<ReturnSwapAmount> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;
       boost::shared_ptr<Return> return_;
       std::string returnIDRef_;
       bool returnIsNull_;
       boost::shared_ptr<NotionalAdjustmentEnum> notionalAdjustments_;
       std::string notionalAdjustmentsIDRef_;
       bool notionalAdjustmentsIsNull_;
       boost::shared_ptr<FxFeature> fxFeature_;
       std::string fxFeatureIDRef_;
       bool fxFeatureIsNull_;
       boost::shared_ptr<AveragingPeriod> averagingDates_;
       std::string averagingDatesIDRef_;
       bool averagingDatesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

