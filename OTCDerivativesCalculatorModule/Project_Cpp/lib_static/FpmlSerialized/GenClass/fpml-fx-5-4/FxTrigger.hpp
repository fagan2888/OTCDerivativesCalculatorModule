// FxTrigger.hpp 
#ifndef FpmlSerialized_FxTrigger_hpp
#define FpmlSerialized_FxTrigger_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/TriggerConditionEnum.hpp>
#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-shared-5-4/InformationSource.hpp>

namespace FpmlSerialized {

class FxTrigger : public ISerialized { 
   public: 
       FxTrigger(TiXmlNode* xmlNode);

       bool isTriggerCondition(){return this->triggerConditionIsNull_;}
       boost::shared_ptr<TriggerConditionEnum> getTriggerCondition();
      std::string getTriggerConditionIDRef(){return triggerConditionIDRef_;}

       bool isQuotedCurrencyPair(){return this->quotedCurrencyPairIsNull_;}
       boost::shared_ptr<QuotedCurrencyPair> getQuotedCurrencyPair();
      std::string getQuotedCurrencyPairIDRef(){return quotedCurrencyPairIDRef_;}

       bool isTriggerRate(){return this->triggerRateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getTriggerRate();
      std::string getTriggerRateIDRef(){return triggerRateIDRef_;}

       bool isSpotRate(){return this->spotRateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getSpotRate();
      std::string getSpotRateIDRef(){return spotRateIDRef_;}

       bool isInformationSource(){return this->informationSourceIsNull_;}
       std::vector<boost::shared_ptr<InformationSource>> getInformationSource();
      std::string getInformationSourceIDRef(){return informationSourceIDRef_;}

   protected: 
       boost::shared_ptr<TriggerConditionEnum> triggerCondition_;
       std::string triggerConditionIDRef_;
       bool triggerConditionIsNull_;
       boost::shared_ptr<QuotedCurrencyPair> quotedCurrencyPair_;
       std::string quotedCurrencyPairIDRef_;
       bool quotedCurrencyPairIsNull_;
       boost::shared_ptr<PositiveDecimal> triggerRate_;
       std::string triggerRateIDRef_;
       bool triggerRateIsNull_;
       boost::shared_ptr<PositiveDecimal> spotRate_;
       std::string spotRateIDRef_;
       bool spotRateIsNull_;
       std::vector<boost::shared_ptr<InformationSource>> informationSource_;
       std::string informationSourceIDRef_;
       bool informationSourceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

