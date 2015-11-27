// FxAsianFeature.hpp 
#ifndef FpmlSerialized_FxAsianFeature_hpp
#define FpmlSerialized_FxAsianFeature_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/InformationSource.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-fx-5-4/FxAverageRateObservationSchedule.hpp>
#include <fpml-fx-5-4/FxAverageRateObservation.hpp>
#include <fpml-enum-5-4/StrikeQuoteBasisEnum.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>

namespace FpmlSerialized {

class FxAsianFeature : public ISerialized { 
   public: 
       FxAsianFeature(TiXmlNode* xmlNode);

       bool isPrimaryRateSource(){return this->primaryRateSourceIsNull_;}
       boost::shared_ptr<InformationSource> getPrimaryRateSource();
      std::string getPrimaryRateSourceIDRef(){return primaryRateSourceIDRef_;}

       bool isSecondaryRateSource(){return this->secondaryRateSourceIsNull_;}
       boost::shared_ptr<InformationSource> getSecondaryRateSource();
      std::string getSecondaryRateSourceIDRef(){return secondaryRateSourceIDRef_;}

       bool isFixingTime(){return this->fixingTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getFixingTime();
      std::string getFixingTimeIDRef(){return fixingTimeIDRef_;}

       bool isObservationSchedule(){return this->observationScheduleIsNull_;}
       boost::shared_ptr<FxAverageRateObservationSchedule> getObservationSchedule();
      std::string getObservationScheduleIDRef(){return observationScheduleIDRef_;}

       bool isRateObservation(){return this->rateObservationIsNull_;}
       std::vector<boost::shared_ptr<FxAverageRateObservation>> getRateObservation();
      std::string getRateObservationIDRef(){return rateObservationIDRef_;}

       bool isRateObservationQuoteBasis(){return this->rateObservationQuoteBasisIsNull_;}
       boost::shared_ptr<StrikeQuoteBasisEnum> getRateObservationQuoteBasis();
      std::string getRateObservationQuoteBasisIDRef(){return rateObservationQuoteBasisIDRef_;}

       bool isPayoutFormula(){return this->payoutFormulaIsNull_;}
       boost::shared_ptr<XsdTypeString> getPayoutFormula();
      std::string getPayoutFormulaIDRef(){return payoutFormulaIDRef_;}

       bool isPrecision(){return this->precisionIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getPrecision();
      std::string getPrecisionIDRef(){return precisionIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!observationScheduleIsNull_){
                count += 1;
                str = "observationSchedule" ;
           }
           if(!rateObservationIsNull_){
                count += 1;
                str = "rateObservation" ;
           }
           if(!rateObservationQuoteBasisIsNull_){
                count += 1;
                str = "rateObservationQuoteBasis" ;
           }
           if(!rateObservationIsNull_){
                count += 1;
                str = "rateObservation" ;
           }
           if(!rateObservationQuoteBasisIsNull_){
                count += 1;
                str = "rateObservationQuoteBasis" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<InformationSource> primaryRateSource_;
       std::string primaryRateSourceIDRef_;
       bool primaryRateSourceIsNull_;
       boost::shared_ptr<InformationSource> secondaryRateSource_;
       std::string secondaryRateSourceIDRef_;
       bool secondaryRateSourceIsNull_;
       boost::shared_ptr<BusinessCenterTime> fixingTime_;
       std::string fixingTimeIDRef_;
       bool fixingTimeIsNull_;
         boost::shared_ptr<FxAverageRateObservationSchedule> observationSchedule_;     //choice
       std::string observationScheduleIDRef_;
       bool observationScheduleIsNull_;
         std::vector<boost::shared_ptr<FxAverageRateObservation>> rateObservation_;     //choice
       std::string rateObservationIDRef_;
       bool rateObservationIsNull_;
         boost::shared_ptr<StrikeQuoteBasisEnum> rateObservationQuoteBasis_;     //choice
       std::string rateObservationQuoteBasisIDRef_;
       bool rateObservationQuoteBasisIsNull_;
       boost::shared_ptr<XsdTypeString> payoutFormula_;
       std::string payoutFormulaIDRef_;
       bool payoutFormulaIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> precision_;
       std::string precisionIDRef_;
       bool precisionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

