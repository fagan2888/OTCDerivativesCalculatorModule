// AveragingPeriod.hpp 
#ifndef FpmlSerialized_AveragingPeriod_hpp
#define FpmlSerialized_AveragingPeriod_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/AveragingSchedule.hpp>
#include <fpml-shared-5-4/DateTimeList.hpp>
#include <fpml-option-shared-5-4/AveragingObservationList.hpp>
#include <fpml-option-shared-5-4/MarketDisruption.hpp>

namespace FpmlSerialized {

class AveragingPeriod : public ISerialized { 
   public: 
       AveragingPeriod(TiXmlNode* xmlNode);

       bool isSchedule(){return this->scheduleIsNull_;}
       std::vector<boost::shared_ptr<AveragingSchedule>> getSchedule();
      std::string getScheduleIDRef(){return scheduleIDRef_;}

       bool isAveragingDateTimes(){return this->averagingDateTimesIsNull_;}
       boost::shared_ptr<DateTimeList> getAveragingDateTimes();
      std::string getAveragingDateTimesIDRef(){return averagingDateTimesIDRef_;}

       bool isAveragingObservations(){return this->averagingObservationsIsNull_;}
       boost::shared_ptr<AveragingObservationList> getAveragingObservations();
      std::string getAveragingObservationsIDRef(){return averagingObservationsIDRef_;}

       bool isMarketDisruption(){return this->marketDisruptionIsNull_;}
       boost::shared_ptr<MarketDisruption> getMarketDisruption();
      std::string getMarketDisruptionIDRef(){return marketDisruptionIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!averagingDateTimesIsNull_){
                count += 1;
                str = "averagingDateTimes" ;
           }
           if(!averagingObservationsIsNull_){
                count += 1;
                str = "averagingObservations" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       std::vector<boost::shared_ptr<AveragingSchedule>> schedule_;
       std::string scheduleIDRef_;
       bool scheduleIsNull_;
         boost::shared_ptr<DateTimeList> averagingDateTimes_;     //choice
       std::string averagingDateTimesIDRef_;
       bool averagingDateTimesIsNull_;
         boost::shared_ptr<AveragingObservationList> averagingObservations_;     //choice
       std::string averagingObservationsIDRef_;
       bool averagingObservationsIsNull_;
       boost::shared_ptr<MarketDisruption> marketDisruption_;
       std::string marketDisruptionIDRef_;
       bool marketDisruptionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

