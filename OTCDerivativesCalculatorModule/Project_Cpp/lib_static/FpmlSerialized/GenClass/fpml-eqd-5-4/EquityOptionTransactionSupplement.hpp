// EquityOptionTransactionSupplement.hpp 
#ifndef FpmlSerialized_EquityOptionTransactionSupplement_hpp
#define FpmlSerialized_EquityOptionTransactionSupplement_hpp

#include <fpml-eqd-5-4/EquityDerivativeShortFormBase.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/MethodOfAdjustmentEnum.hpp>
#include <fpml-shared-5-4/CountryCode.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-eq-shared-5-4/ExtraordinaryEvents.hpp>

namespace FpmlSerialized {

class EquityOptionTransactionSupplement : public EquityDerivativeShortFormBase { 
   public: 
       EquityOptionTransactionSupplement(TiXmlNode* xmlNode);

       bool isExchangeLookAlike(){return this->exchangeLookAlikeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getExchangeLookAlike();
      std::string getExchangeLookAlikeIDRef(){return exchangeLookAlikeIDRef_;}

       bool isExchangeTradedContractNearest(){return this->exchangeTradedContractNearestIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getExchangeTradedContractNearest();
      std::string getExchangeTradedContractNearestIDRef(){return exchangeTradedContractNearestIDRef_;}

       bool isMultipleExchangeIndexAnnexFallback(){return this->multipleExchangeIndexAnnexFallbackIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMultipleExchangeIndexAnnexFallback();
      std::string getMultipleExchangeIndexAnnexFallbackIDRef(){return multipleExchangeIndexAnnexFallbackIDRef_;}

       bool isComponentSecurityIndexAnnexFallback(){return this->componentSecurityIndexAnnexFallbackIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getComponentSecurityIndexAnnexFallback();
      std::string getComponentSecurityIndexAnnexFallbackIDRef(){return componentSecurityIndexAnnexFallbackIDRef_;}

       bool isMethodOfAdjustment(){return this->methodOfAdjustmentIsNull_;}
       boost::shared_ptr<MethodOfAdjustmentEnum> getMethodOfAdjustment();
      std::string getMethodOfAdjustmentIDRef(){return methodOfAdjustmentIDRef_;}

       bool isLocalJurisdiction(){return this->localJurisdictionIsNull_;}
       boost::shared_ptr<CountryCode> getLocalJurisdiction();
      std::string getLocalJurisdictionIDRef(){return localJurisdictionIDRef_;}

       bool isOptionEntitlement(){return this->optionEntitlementIsNull_;}
       boost::shared_ptr<PositiveDecimal> getOptionEntitlement();
      std::string getOptionEntitlementIDRef(){return optionEntitlementIDRef_;}

       bool isMultiplier(){return this->multiplierIsNull_;}
       boost::shared_ptr<PositiveDecimal> getMultiplier();
      std::string getMultiplierIDRef(){return multiplierIDRef_;}

       bool isExtraordinaryEvents(){return this->extraordinaryEventsIsNull_;}
       boost::shared_ptr<ExtraordinaryEvents> getExtraordinaryEvents();
      std::string getExtraordinaryEventsIDRef(){return extraordinaryEventsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!multipleExchangeIndexAnnexFallbackIsNull_){
                count += 1;
                str = "multipleExchangeIndexAnnexFallback" ;
           }
           if(!componentSecurityIndexAnnexFallbackIsNull_){
                count += 1;
                str = "componentSecurityIndexAnnexFallback" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!optionEntitlementIsNull_){
                count += 1;
                str = "optionEntitlement" ;
           }
           if(!multiplierIsNull_){
                count += 1;
                str = "multiplier" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
       boost::shared_ptr<XsdTypeBoolean> exchangeLookAlike_;
       std::string exchangeLookAlikeIDRef_;
       bool exchangeLookAlikeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> exchangeTradedContractNearest_;
       std::string exchangeTradedContractNearestIDRef_;
       bool exchangeTradedContractNearestIsNull_;
         boost::shared_ptr<XsdTypeBoolean> multipleExchangeIndexAnnexFallback_;     //choice
       std::string multipleExchangeIndexAnnexFallbackIDRef_;
       bool multipleExchangeIndexAnnexFallbackIsNull_;
         boost::shared_ptr<XsdTypeBoolean> componentSecurityIndexAnnexFallback_;     //choice
       std::string componentSecurityIndexAnnexFallbackIDRef_;
       bool componentSecurityIndexAnnexFallbackIsNull_;
       boost::shared_ptr<MethodOfAdjustmentEnum> methodOfAdjustment_;
       std::string methodOfAdjustmentIDRef_;
       bool methodOfAdjustmentIsNull_;
       boost::shared_ptr<CountryCode> localJurisdiction_;
       std::string localJurisdictionIDRef_;
       bool localJurisdictionIsNull_;
         boost::shared_ptr<PositiveDecimal> optionEntitlement_;     //choice
       std::string optionEntitlementIDRef_;
       bool optionEntitlementIsNull_;
         boost::shared_ptr<PositiveDecimal> multiplier_;     //choice
       std::string multiplierIDRef_;
       bool multiplierIsNull_;
       boost::shared_ptr<ExtraordinaryEvents> extraordinaryEvents_;
       std::string extraordinaryEventsIDRef_;
       bool extraordinaryEventsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

