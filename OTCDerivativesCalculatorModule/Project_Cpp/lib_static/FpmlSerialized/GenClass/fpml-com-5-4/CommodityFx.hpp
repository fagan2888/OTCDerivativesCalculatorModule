// CommodityFx.hpp 
#ifndef FpmlSerialized_CommodityFx_hpp
#define FpmlSerialized_CommodityFx_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/InformationSource.hpp>
#include <fpml-com-5-4/CommodityFxType.hpp>
#include <fpml-enum-5-4/AveragingMethodEnum.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-enum-5-4/CommodityDayTypeEnum.hpp>
#include <fpml-com-5-4/CommodityFrequencyType.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-enum-5-4/DayOfWeekEnum.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <fpml-com-5-4/Lag.hpp>
#include <fpml-com-5-4/LagReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>

namespace FpmlSerialized {

class CommodityFx : public ISerialized { 
   public: 
       CommodityFx(TiXmlNode* xmlNode);

       bool isPrimaryRateSource(){return this->primaryRateSourceIsNull_;}
       boost::shared_ptr<InformationSource> getPrimaryRateSource();
      std::string getPrimaryRateSourceIDRef(){return primaryRateSourceIDRef_;}

       bool isSecondaryRateSource(){return this->secondaryRateSourceIsNull_;}
       boost::shared_ptr<InformationSource> getSecondaryRateSource();
      std::string getSecondaryRateSourceIDRef(){return secondaryRateSourceIDRef_;}

       bool isFxType(){return this->fxTypeIsNull_;}
       boost::shared_ptr<CommodityFxType> getFxType();
      std::string getFxTypeIDRef(){return fxTypeIDRef_;}

       bool isAveragingMethod(){return this->averagingMethodIsNull_;}
       boost::shared_ptr<AveragingMethodEnum> getAveragingMethod();
      std::string getAveragingMethodIDRef(){return averagingMethodIDRef_;}

       bool isFixingTime(){return this->fixingTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getFixingTime();
      std::string getFixingTimeIDRef(){return fixingTimeIDRef_;}

       bool isFxObservationDates(){return this->fxObservationDatesIsNull_;}
       std::vector<boost::shared_ptr<AdjustableDates>> getFxObservationDates();
      std::string getFxObservationDatesIDRef(){return fxObservationDatesIDRef_;}

       bool isDayType(){return this->dayTypeIsNull_;}
       boost::shared_ptr<CommodityDayTypeEnum> getDayType();
      std::string getDayTypeIDRef(){return dayTypeIDRef_;}

       bool isDayDistribution(){return this->dayDistributionIsNull_;}
       boost::shared_ptr<CommodityFrequencyType> getDayDistribution();
      std::string getDayDistributionIDRef(){return dayDistributionIDRef_;}

       bool isDayCount(){return this->dayCountIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getDayCount();
      std::string getDayCountIDRef(){return dayCountIDRef_;}

       bool isDayOfWeek(){return this->dayOfWeekIsNull_;}
       std::vector<boost::shared_ptr<DayOfWeekEnum>> getDayOfWeek();
      std::string getDayOfWeekIDRef(){return dayOfWeekIDRef_;}

       bool isDayNumber(){return this->dayNumberIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getDayNumber();
      std::string getDayNumberIDRef(){return dayNumberIDRef_;}

       bool isLag(){return this->lagIsNull_;}
       boost::shared_ptr<Lag> getLag();
      std::string getLagIDRef(){return lagIDRef_;}

       bool isLagReference(){return this->lagReferenceIsNull_;}
       boost::shared_ptr<LagReference> getLagReference();
      std::string getLagReferenceIDRef(){return lagReferenceIDRef_;}

       bool isCalculationPeriodsReference(){return this->calculationPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getCalculationPeriodsReference();
      std::string getCalculationPeriodsReferenceIDRef(){return calculationPeriodsReferenceIDRef_;}

       bool isCalculationPeriodsScheduleReference(){return this->calculationPeriodsScheduleReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsScheduleReference> getCalculationPeriodsScheduleReference();
      std::string getCalculationPeriodsScheduleReferenceIDRef(){return calculationPeriodsScheduleReferenceIDRef_;}

       bool isCalculationPeriodsDatesReference(){return this->calculationPeriodsDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsDatesReference> getCalculationPeriodsDatesReference();
      std::string getCalculationPeriodsDatesReferenceIDRef(){return calculationPeriodsDatesReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!fixingTimeIsNull_){
                count += 1;
                str = "fixingTime" ;
           }
           if(!fixingTimeIsNull_){
                count += 1;
                str = "fixingTime" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!fxObservationDatesIsNull_){
                count += 1;
                str = "fxObservationDates" ;
           }
           if(!dayTypeIsNull_){
                count += 1;
                str = "dayType" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!dayDistributionIsNull_){
                count += 1;
                str = "dayDistribution" ;
           }
           if(!dayCountIsNull_){
                count += 1;
                str = "dayCount" ;
           }
           if(!dayOfWeekIsNull_){
                count += 1;
                str = "dayOfWeek" ;
           }
           if(!dayNumberIsNull_){
                count += 1;
                str = "dayNumber" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
       std::string getChoiceStr_3(){
           std::string str;
           int count = 0;
           if(!lagIsNull_){
                count += 1;
                str = "lag" ;
           }
           if(!lagReferenceIsNull_){
                count += 1;
                str = "lagReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_3_ = str ;
           return choiceStr_3_;
       }
       std::string getChoiceStr_4(){
           std::string str;
           int count = 0;
           if(!calculationPeriodsReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsReference" ;
           }
           if(!calculationPeriodsScheduleReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsScheduleReference" ;
           }
           if(!calculationPeriodsDatesReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsDatesReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_4_ = str ;
           return choiceStr_4_;
       }
   protected: 
       boost::shared_ptr<InformationSource> primaryRateSource_;
       std::string primaryRateSourceIDRef_;
       bool primaryRateSourceIsNull_;
       boost::shared_ptr<InformationSource> secondaryRateSource_;
       std::string secondaryRateSourceIDRef_;
       bool secondaryRateSourceIsNull_;
       boost::shared_ptr<CommodityFxType> fxType_;
       std::string fxTypeIDRef_;
       bool fxTypeIsNull_;
       boost::shared_ptr<AveragingMethodEnum> averagingMethod_;
       std::string averagingMethodIDRef_;
       bool averagingMethodIsNull_;
         boost::shared_ptr<BusinessCenterTime> fixingTime_;     //choice
       std::string fixingTimeIDRef_;
       bool fixingTimeIsNull_;
         std::vector<boost::shared_ptr<AdjustableDates>> fxObservationDates_;     //choice
       std::string fxObservationDatesIDRef_;
       bool fxObservationDatesIsNull_;
         boost::shared_ptr<CommodityDayTypeEnum> dayType_;     //choice
       std::string dayTypeIDRef_;
       bool dayTypeIsNull_;
         boost::shared_ptr<CommodityFrequencyType> dayDistribution_;     //choice
       std::string dayDistributionIDRef_;
       bool dayDistributionIsNull_;
         boost::shared_ptr<XsdTypePositiveInteger> dayCount_;     //choice
       std::string dayCountIDRef_;
       bool dayCountIsNull_;
         std::vector<boost::shared_ptr<DayOfWeekEnum>> dayOfWeek_;     //choice
       std::string dayOfWeekIDRef_;
       bool dayOfWeekIsNull_;
         boost::shared_ptr<XsdTypeInteger> dayNumber_;     //choice
       std::string dayNumberIDRef_;
       bool dayNumberIsNull_;
         boost::shared_ptr<Lag> lag_;     //choice
       std::string lagIDRef_;
       bool lagIsNull_;
         boost::shared_ptr<LagReference> lagReference_;     //choice
       std::string lagReferenceIDRef_;
       bool lagReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsReference> calculationPeriodsReference_;     //choice
       std::string calculationPeriodsReferenceIDRef_;
       bool calculationPeriodsReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsScheduleReference> calculationPeriodsScheduleReference_;     //choice
       std::string calculationPeriodsScheduleReferenceIDRef_;
       bool calculationPeriodsScheduleReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsDatesReference> calculationPeriodsDatesReference_;     //choice
       std::string calculationPeriodsDatesReferenceIDRef_;
       bool calculationPeriodsDatesReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;
       std::string choiceStr_3_;
       std::string choiceStr_4_;

};

} //namespaceFpmlSerialized end
#endif

