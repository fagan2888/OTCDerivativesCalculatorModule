// CommodityPricingDates.hpp 
#ifndef FpmlSerialized_CommodityPricingDates_hpp
#define FpmlSerialized_CommodityPricingDates_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>
#include <fpml-com-5-4/Lag.hpp>
#include <fpml-enum-5-4/CommodityDayTypeEnum.hpp>
#include <fpml-com-5-4/CommodityFrequencyType.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-enum-5-4/DayOfWeekEnum.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <fpml-asset-5-4/CommodityBusinessCalendar.hpp>
#include <fpml-enum-5-4/CalendarSourceEnum.hpp>
#include <fpml-com-5-4/SettlementPeriods.hpp>
#include <fpml-com-5-4/SettlementPeriodsReference.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>

namespace FpmlSerialized {

class CommodityPricingDates : public ISerialized { 
   public: 
       CommodityPricingDates(TiXmlNode* xmlNode);

       bool isCalculationPeriodsReference(){return this->calculationPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getCalculationPeriodsReference();
      std::string getCalculationPeriodsReferenceIDRef(){return calculationPeriodsReferenceIDRef_;}

       bool isCalculationPeriodsScheduleReference(){return this->calculationPeriodsScheduleReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsScheduleReference> getCalculationPeriodsScheduleReference();
      std::string getCalculationPeriodsScheduleReferenceIDRef(){return calculationPeriodsScheduleReferenceIDRef_;}

       bool isCalculationPeriodsDatesReference(){return this->calculationPeriodsDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsDatesReference> getCalculationPeriodsDatesReference();
      std::string getCalculationPeriodsDatesReferenceIDRef(){return calculationPeriodsDatesReferenceIDRef_;}

       bool isLag(){return this->lagIsNull_;}
       boost::shared_ptr<Lag> getLag();
      std::string getLagIDRef(){return lagIDRef_;}

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

       bool isBusinessCalendar(){return this->businessCalendarIsNull_;}
       boost::shared_ptr<CommodityBusinessCalendar> getBusinessCalendar();
      std::string getBusinessCalendarIDRef(){return businessCalendarIDRef_;}

       bool isCalendarSource(){return this->calendarSourceIsNull_;}
       boost::shared_ptr<CalendarSourceEnum> getCalendarSource();
      std::string getCalendarSourceIDRef(){return calendarSourceIDRef_;}

       bool isSettlementPeriods(){return this->settlementPeriodsIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriods>> getSettlementPeriods();
      std::string getSettlementPeriodsIDRef(){return settlementPeriodsIDRef_;}

       bool isSettlementPeriodsReference(){return this->settlementPeriodsReferenceIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriodsReference>> getSettlementPeriodsReference();
      std::string getSettlementPeriodsReferenceIDRef(){return settlementPeriodsReferenceIDRef_;}

       bool isPricingDates(){return this->pricingDatesIsNull_;}
       std::vector<boost::shared_ptr<AdjustableDates>> getPricingDates();
      std::string getPricingDatesIDRef(){return pricingDatesIDRef_;}

       std::string getChoiceStr_0(){
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
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!lagIsNull_){
                count += 1;
                str = "lag" ;
           }
           if(!pricingDatesIsNull_){
                count += 1;
                str = "pricingDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!dayTypeIsNull_){
                count += 1;
                str = "dayType" ;
           }
           if(!businessCalendarIsNull_){
                count += 1;
                str = "businessCalendar" ;
           }
           if(!calendarSourceIsNull_){
                count += 1;
                str = "calendarSource" ;
           }
           if(!settlementPeriodsIsNull_){
                count += 1;
                str = "settlementPeriods" ;
           }
           if(!settlementPeriodsReferenceIsNull_){
                count += 1;
                str = "settlementPeriodsReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
       std::string getChoiceStr_3(){
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
           choiceStr_3_ = str ;
           return choiceStr_3_;
       }
   protected: 
         boost::shared_ptr<CalculationPeriodsReference> calculationPeriodsReference_;     //choice
       std::string calculationPeriodsReferenceIDRef_;
       bool calculationPeriodsReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsScheduleReference> calculationPeriodsScheduleReference_;     //choice
       std::string calculationPeriodsScheduleReferenceIDRef_;
       bool calculationPeriodsScheduleReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsDatesReference> calculationPeriodsDatesReference_;     //choice
       std::string calculationPeriodsDatesReferenceIDRef_;
       bool calculationPeriodsDatesReferenceIsNull_;
         boost::shared_ptr<Lag> lag_;     //choice
       std::string lagIDRef_;
       bool lagIsNull_;
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
         boost::shared_ptr<CommodityBusinessCalendar> businessCalendar_;     //choice
       std::string businessCalendarIDRef_;
       bool businessCalendarIsNull_;
         boost::shared_ptr<CalendarSourceEnum> calendarSource_;     //choice
       std::string calendarSourceIDRef_;
       bool calendarSourceIsNull_;
         std::vector<boost::shared_ptr<SettlementPeriods>> settlementPeriods_;     //choice
       std::string settlementPeriodsIDRef_;
       bool settlementPeriodsIsNull_;
         std::vector<boost::shared_ptr<SettlementPeriodsReference>> settlementPeriodsReference_;     //choice
       std::string settlementPeriodsReferenceIDRef_;
       bool settlementPeriodsReferenceIsNull_;
         std::vector<boost::shared_ptr<AdjustableDates>> pricingDates_;     //choice
       std::string pricingDatesIDRef_;
       bool pricingDatesIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;
       std::string choiceStr_3_;

};

} //namespaceFpmlSerialized end
#endif

