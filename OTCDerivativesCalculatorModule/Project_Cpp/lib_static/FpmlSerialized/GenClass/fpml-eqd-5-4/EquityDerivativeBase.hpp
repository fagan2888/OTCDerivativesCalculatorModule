// EquityDerivativeBase.hpp 
#ifndef FpmlSerialized_EquityDerivativeBase_hpp
#define FpmlSerialized_EquityDerivativeBase_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-enum-5-4/EquityOptionTypeEnum.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-asset-5-4/Underlyer.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-eqd-5-4/EquityExerciseValuationSettlement.hpp>
#include <fpml-eq-shared-5-4/OptionFeatures.hpp>
#include <fpml-option-shared-5-4/FxFeature.hpp>
#include <fpml-option-shared-5-4/StrategyFeature.hpp>

namespace FpmlSerialized {

class EquityDerivativeBase : public Product { 
   public: 
       EquityDerivativeBase(TiXmlNode* xmlNode);

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
       boost::shared_ptr<EquityOptionTypeEnum> getOptionType();
      std::string getOptionTypeIDRef(){return optionTypeIDRef_;}

       bool isEquityEffectiveDate(){return this->equityEffectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEquityEffectiveDate();
      std::string getEquityEffectiveDateIDRef(){return equityEffectiveDateIDRef_;}

       bool isUnderlyer(){return this->underlyerIsNull_;}
       boost::shared_ptr<Underlyer> getUnderlyer();
      std::string getUnderlyerIDRef(){return underlyerIDRef_;}

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getNotional();
      std::string getNotionalIDRef(){return notionalIDRef_;}

       bool isEquityExercise(){return this->equityExerciseIsNull_;}
       boost::shared_ptr<EquityExerciseValuationSettlement> getEquityExercise();
      std::string getEquityExerciseIDRef(){return equityExerciseIDRef_;}

       bool isFeature(){return this->featureIsNull_;}
       boost::shared_ptr<OptionFeatures> getFeature();
      std::string getFeatureIDRef(){return featureIDRef_;}

       bool isFxFeature(){return this->fxFeatureIsNull_;}
       boost::shared_ptr<FxFeature> getFxFeature();
      std::string getFxFeatureIDRef(){return fxFeatureIDRef_;}

       bool isStrategyFeature(){return this->strategyFeatureIsNull_;}
       boost::shared_ptr<StrategyFeature> getStrategyFeature();
      std::string getStrategyFeatureIDRef(){return strategyFeatureIDRef_;}

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
       boost::shared_ptr<EquityOptionTypeEnum> optionType_;
       std::string optionTypeIDRef_;
       bool optionTypeIsNull_;
       boost::shared_ptr<XsdTypeDate> equityEffectiveDate_;
       std::string equityEffectiveDateIDRef_;
       bool equityEffectiveDateIsNull_;
       boost::shared_ptr<Underlyer> underlyer_;
       std::string underlyerIDRef_;
       bool underlyerIsNull_;
       boost::shared_ptr<NonNegativeMoney> notional_;
       std::string notionalIDRef_;
       bool notionalIsNull_;
       boost::shared_ptr<EquityExerciseValuationSettlement> equityExercise_;
       std::string equityExerciseIDRef_;
       bool equityExerciseIsNull_;
       boost::shared_ptr<OptionFeatures> feature_;
       std::string featureIDRef_;
       bool featureIsNull_;
       boost::shared_ptr<FxFeature> fxFeature_;
       std::string fxFeatureIDRef_;
       bool fxFeatureIsNull_;
       boost::shared_ptr<StrategyFeature> strategyFeature_;
       std::string strategyFeatureIDRef_;
       bool strategyFeatureIsNull_;

};

} //namespaceFpmlSerialized end
#endif

