// FxBarrierFeature.hpp 
#ifndef FpmlSerialized_FxBarrierFeature_hpp
#define FpmlSerialized_FxBarrierFeature_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/FxBarrierTypeEnum.hpp>
#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-shared-5-4/InformationSource.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class FxBarrierFeature : public ISerialized { 
   public: 
       FxBarrierFeature(TiXmlNode* xmlNode);

       bool isBarrierType(){return this->barrierTypeIsNull_;}
       boost::shared_ptr<FxBarrierTypeEnum> getBarrierType();
      std::string getBarrierTypeIDRef(){return barrierTypeIDRef_;}

       bool isQuotedCurrencyPair(){return this->quotedCurrencyPairIsNull_;}
       boost::shared_ptr<QuotedCurrencyPair> getQuotedCurrencyPair();
      std::string getQuotedCurrencyPairIDRef(){return quotedCurrencyPairIDRef_;}

       bool isTriggerRate(){return this->triggerRateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getTriggerRate();
      std::string getTriggerRateIDRef(){return triggerRateIDRef_;}

       bool isInformationSource(){return this->informationSourceIsNull_;}
       std::vector<boost::shared_ptr<InformationSource>> getInformationSource();
      std::string getInformationSourceIDRef(){return informationSourceIDRef_;}

       bool isObservationStartDate(){return this->observationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getObservationStartDate();
      std::string getObservationStartDateIDRef(){return observationStartDateIDRef_;}

       bool isObservationEndDate(){return this->observationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getObservationEndDate();
      std::string getObservationEndDateIDRef(){return observationEndDateIDRef_;}

   protected: 
       boost::shared_ptr<FxBarrierTypeEnum> barrierType_;
       std::string barrierTypeIDRef_;
       bool barrierTypeIsNull_;
       boost::shared_ptr<QuotedCurrencyPair> quotedCurrencyPair_;
       std::string quotedCurrencyPairIDRef_;
       bool quotedCurrencyPairIsNull_;
       boost::shared_ptr<PositiveDecimal> triggerRate_;
       std::string triggerRateIDRef_;
       bool triggerRateIsNull_;
       std::vector<boost::shared_ptr<InformationSource>> informationSource_;
       std::string informationSourceIDRef_;
       bool informationSourceIsNull_;
       boost::shared_ptr<XsdTypeDate> observationStartDate_;
       std::string observationStartDateIDRef_;
       bool observationStartDateIsNull_;
       boost::shared_ptr<XsdTypeDate> observationEndDate_;
       std::string observationEndDateIDRef_;
       bool observationEndDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

