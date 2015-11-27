// DirectionalLegUnderlyer.hpp 
#ifndef FpmlSerialized_DirectionalLegUnderlyer_hpp
#define FpmlSerialized_DirectionalLegUnderlyer_hpp

#include <fpml-eq-shared-5-4/DirectionalLeg.hpp>
#include <fpml-asset-5-4/Underlyer.hpp>
#include <fpml-enum-5-4/SettlementTypeEnum.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-option-shared-5-4/FxFeature.hpp>

namespace FpmlSerialized {

class DirectionalLegUnderlyer : public DirectionalLeg { 
   public: 
       DirectionalLegUnderlyer(TiXmlNode* xmlNode);

       bool isUnderlyer(){return this->underlyerIsNull_;}
       boost::shared_ptr<Underlyer> getUnderlyer();
      std::string getUnderlyerIDRef(){return underlyerIDRef_;}

       bool isSettlementType(){return this->settlementTypeIsNull_;}
       boost::shared_ptr<SettlementTypeEnum> getSettlementType();
      std::string getSettlementTypeIDRef(){return settlementTypeIDRef_;}

       bool isSettlementDate(){return this->settlementDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getSettlementDate();
      std::string getSettlementDateIDRef(){return settlementDateIDRef_;}

       bool isSettlementAmount(){return this->settlementAmountIsNull_;}
       boost::shared_ptr<Money> getSettlementAmount();
      std::string getSettlementAmountIDRef(){return settlementAmountIDRef_;}

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       boost::shared_ptr<Currency> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

       bool isFxFeature(){return this->fxFeatureIsNull_;}
       boost::shared_ptr<FxFeature> getFxFeature();
      std::string getFxFeatureIDRef(){return fxFeatureIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!settlementAmountIsNull_){
                count += 1;
                str = "settlementAmount" ;
           }
           if(!settlementCurrencyIsNull_){
                count += 1;
                str = "settlementCurrency" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<Underlyer> underlyer_;
       std::string underlyerIDRef_;
       bool underlyerIsNull_;
       boost::shared_ptr<SettlementTypeEnum> settlementType_;
       std::string settlementTypeIDRef_;
       bool settlementTypeIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> settlementDate_;
       std::string settlementDateIDRef_;
       bool settlementDateIsNull_;
         boost::shared_ptr<Money> settlementAmount_;     //choice
       std::string settlementAmountIDRef_;
       bool settlementAmountIsNull_;
         boost::shared_ptr<Currency> settlementCurrency_;     //choice
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;
       boost::shared_ptr<FxFeature> fxFeature_;
       std::string fxFeatureIDRef_;
       bool fxFeatureIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

