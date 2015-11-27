// SettlementPeriods.hpp 
#ifndef FpmlSerialized_SettlementPeriods_hpp
#define FpmlSerialized_SettlementPeriods_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/SettlementPeriodDurationEnum.hpp>
#include <fpml-enum-5-4/DayOfWeekEnum.hpp>
#include <fpml-shared-5-4/OffsetPrevailingTime.hpp>
#include <fpml-asset-5-4/CommodityBusinessCalendar.hpp>

namespace FpmlSerialized {

class SettlementPeriods : public ISerialized { 
   public: 
       SettlementPeriods(TiXmlNode* xmlNode);

       bool isDuration(){return this->durationIsNull_;}
       boost::shared_ptr<SettlementPeriodDurationEnum> getDuration();
      std::string getDurationIDRef(){return durationIDRef_;}

       bool isApplicableDay(){return this->applicableDayIsNull_;}
       std::vector<boost::shared_ptr<DayOfWeekEnum>> getApplicableDay();
      std::string getApplicableDayIDRef(){return applicableDayIDRef_;}

       bool isStartTime(){return this->startTimeIsNull_;}
       boost::shared_ptr<OffsetPrevailingTime> getStartTime();
      std::string getStartTimeIDRef(){return startTimeIDRef_;}

       bool isEndTime(){return this->endTimeIsNull_;}
       boost::shared_ptr<OffsetPrevailingTime> getEndTime();
      std::string getEndTimeIDRef(){return endTimeIDRef_;}

       bool isExcludeHolidays(){return this->excludeHolidaysIsNull_;}
       boost::shared_ptr<CommodityBusinessCalendar> getExcludeHolidays();
      std::string getExcludeHolidaysIDRef(){return excludeHolidaysIDRef_;}

       bool isIncludeHolidays(){return this->includeHolidaysIsNull_;}
       boost::shared_ptr<CommodityBusinessCalendar> getIncludeHolidays();
      std::string getIncludeHolidaysIDRef(){return includeHolidaysIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excludeHolidaysIsNull_){
                count += 1;
                str = "excludeHolidays" ;
           }
           if(!includeHolidaysIsNull_){
                count += 1;
                str = "includeHolidays" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<SettlementPeriodDurationEnum> duration_;
       std::string durationIDRef_;
       bool durationIsNull_;
       std::vector<boost::shared_ptr<DayOfWeekEnum>> applicableDay_;
       std::string applicableDayIDRef_;
       bool applicableDayIsNull_;
       boost::shared_ptr<OffsetPrevailingTime> startTime_;
       std::string startTimeIDRef_;
       bool startTimeIsNull_;
       boost::shared_ptr<OffsetPrevailingTime> endTime_;
       std::string endTimeIDRef_;
       bool endTimeIsNull_;
         boost::shared_ptr<CommodityBusinessCalendar> excludeHolidays_;     //choice
       std::string excludeHolidaysIDRef_;
       bool excludeHolidaysIsNull_;
         boost::shared_ptr<CommodityBusinessCalendar> includeHolidays_;     //choice
       std::string includeHolidaysIDRef_;
       bool includeHolidaysIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

