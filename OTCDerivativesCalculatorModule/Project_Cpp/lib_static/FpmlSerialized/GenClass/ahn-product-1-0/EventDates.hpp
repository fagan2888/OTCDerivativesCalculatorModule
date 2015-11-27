// EventDates.hpp 
#ifndef FpmlSerialized_EventDates_hpp
#define FpmlSerialized_EventDates_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/DatesList.hpp>
#include <ahn-product-1-0/DateInterval.hpp>

namespace FpmlSerialized {

class EventDates : public ISerialized { 
   public: 
       EventDates(TiXmlNode* xmlNode);

       bool isDateList(){return this->dateListIsNull_;}
       boost::shared_ptr<DatesList> getDateList();
      std::string getDateListIDRef(){return dateListIDRef_;}

       bool isDateInterval(){return this->dateIntervalIsNull_;}
       boost::shared_ptr<DateInterval> getDateInterval();
      std::string getDateIntervalIDRef(){return dateIntervalIDRef_;}

       std::string getChoiceStr_eventDateType(){
           std::string str;
           int count = 0;
           if(!dateListIsNull_){
                count += 1;
                str = "dateList" ;
           }
           if(!dateIntervalIsNull_){
                count += 1;
                str = "dateInterval" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_eventDateType_ = str ;
           return choiceStr_eventDateType_;
       }
   protected: 
         boost::shared_ptr<DatesList> dateList_;     //choice
       std::string dateListIDRef_;
       bool dateListIsNull_;
         boost::shared_ptr<DateInterval> dateInterval_;     //choice
       std::string dateIntervalIDRef_;
       bool dateIntervalIsNull_;

       //choiceStr 
       std::string choiceStr_eventDateType_;

};

} //namespaceFpmlSerialized end
#endif

