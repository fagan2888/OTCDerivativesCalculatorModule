// ExtraordinaryEvents.hpp 
#ifndef FpmlSerialized_ExtraordinaryEvents_hpp
#define FpmlSerialized_ExtraordinaryEvents_hpp

#include <ISerialized.hpp>
#include <fpml-eq-shared-5-4/EquityCorporateEvents.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-eq-shared-5-4/IndexAdjustmentEvents.hpp>
#include <fpml-eq-shared-5-4/AdditionalDisruptionEvents.hpp>
#include <fpml-eq-shared-5-4/Representations.hpp>
#include <fpml-enum-5-4/NationalisationOrInsolvencyOrDelistingEventEnum.hpp>
#include <fpml-shared-5-4/ExchangeId.hpp>

namespace FpmlSerialized {

class ExtraordinaryEvents : public ISerialized { 
   public: 
       ExtraordinaryEvents(TiXmlNode* xmlNode);

       bool isMergerEvents(){return this->mergerEventsIsNull_;}
       boost::shared_ptr<EquityCorporateEvents> getMergerEvents();
      std::string getMergerEventsIDRef(){return mergerEventsIDRef_;}

       bool isTenderOffer(){return this->tenderOfferIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getTenderOffer();
      std::string getTenderOfferIDRef(){return tenderOfferIDRef_;}

       bool isTenderOfferEvents(){return this->tenderOfferEventsIsNull_;}
       boost::shared_ptr<EquityCorporateEvents> getTenderOfferEvents();
      std::string getTenderOfferEventsIDRef(){return tenderOfferEventsIDRef_;}

       bool isCompositionOfCombinedConsideration(){return this->compositionOfCombinedConsiderationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getCompositionOfCombinedConsideration();
      std::string getCompositionOfCombinedConsiderationIDRef(){return compositionOfCombinedConsiderationIDRef_;}

       bool isIndexAdjustmentEvents(){return this->indexAdjustmentEventsIsNull_;}
       boost::shared_ptr<IndexAdjustmentEvents> getIndexAdjustmentEvents();
      std::string getIndexAdjustmentEventsIDRef(){return indexAdjustmentEventsIDRef_;}

       bool isAdditionalDisruptionEvents(){return this->additionalDisruptionEventsIsNull_;}
       boost::shared_ptr<AdditionalDisruptionEvents> getAdditionalDisruptionEvents();
      std::string getAdditionalDisruptionEventsIDRef(){return additionalDisruptionEventsIDRef_;}

       bool isFailureToDeliver(){return this->failureToDeliverIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFailureToDeliver();
      std::string getFailureToDeliverIDRef(){return failureToDeliverIDRef_;}

       bool isRepresentations(){return this->representationsIsNull_;}
       boost::shared_ptr<Representations> getRepresentations();
      std::string getRepresentationsIDRef(){return representationsIDRef_;}

       bool isNationalisationOrInsolvency(){return this->nationalisationOrInsolvencyIsNull_;}
       boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum> getNationalisationOrInsolvency();
      std::string getNationalisationOrInsolvencyIDRef(){return nationalisationOrInsolvencyIDRef_;}

       bool isDelisting(){return this->delistingIsNull_;}
       boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum> getDelisting();
      std::string getDelistingIDRef(){return delistingIDRef_;}

       bool isRelatedExchangeId(){return this->relatedExchangeIdIsNull_;}
       std::vector<boost::shared_ptr<ExchangeId>> getRelatedExchangeId();
      std::string getRelatedExchangeIdIDRef(){return relatedExchangeIdIDRef_;}

       bool isOptionsExchangeId(){return this->optionsExchangeIdIsNull_;}
       std::vector<boost::shared_ptr<ExchangeId>> getOptionsExchangeId();
      std::string getOptionsExchangeIdIDRef(){return optionsExchangeIdIDRef_;}

       bool isSpecifiedExchangeId(){return this->specifiedExchangeIdIsNull_;}
       std::vector<boost::shared_ptr<ExchangeId>> getSpecifiedExchangeId();
      std::string getSpecifiedExchangeIdIDRef(){return specifiedExchangeIdIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!additionalDisruptionEventsIsNull_){
                count += 1;
                str = "additionalDisruptionEvents" ;
           }
           if(!failureToDeliverIsNull_){
                count += 1;
                str = "failureToDeliver" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<EquityCorporateEvents> mergerEvents_;
       std::string mergerEventsIDRef_;
       bool mergerEventsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> tenderOffer_;
       std::string tenderOfferIDRef_;
       bool tenderOfferIsNull_;
       boost::shared_ptr<EquityCorporateEvents> tenderOfferEvents_;
       std::string tenderOfferEventsIDRef_;
       bool tenderOfferEventsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> compositionOfCombinedConsideration_;
       std::string compositionOfCombinedConsiderationIDRef_;
       bool compositionOfCombinedConsiderationIsNull_;
       boost::shared_ptr<IndexAdjustmentEvents> indexAdjustmentEvents_;
       std::string indexAdjustmentEventsIDRef_;
       bool indexAdjustmentEventsIsNull_;
         boost::shared_ptr<AdditionalDisruptionEvents> additionalDisruptionEvents_;     //choice
       std::string additionalDisruptionEventsIDRef_;
       bool additionalDisruptionEventsIsNull_;
         boost::shared_ptr<XsdTypeBoolean> failureToDeliver_;     //choice
       std::string failureToDeliverIDRef_;
       bool failureToDeliverIsNull_;
       boost::shared_ptr<Representations> representations_;
       std::string representationsIDRef_;
       bool representationsIsNull_;
       boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum> nationalisationOrInsolvency_;
       std::string nationalisationOrInsolvencyIDRef_;
       bool nationalisationOrInsolvencyIsNull_;
       boost::shared_ptr<NationalisationOrInsolvencyOrDelistingEventEnum> delisting_;
       std::string delistingIDRef_;
       bool delistingIsNull_;
       std::vector<boost::shared_ptr<ExchangeId>> relatedExchangeId_;
       std::string relatedExchangeIdIDRef_;
       bool relatedExchangeIdIsNull_;
       std::vector<boost::shared_ptr<ExchangeId>> optionsExchangeId_;
       std::string optionsExchangeIdIDRef_;
       bool optionsExchangeIdIsNull_;
       std::vector<boost::shared_ptr<ExchangeId>> specifiedExchangeId_;
       std::string specifiedExchangeIdIDRef_;
       bool specifiedExchangeIdIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

