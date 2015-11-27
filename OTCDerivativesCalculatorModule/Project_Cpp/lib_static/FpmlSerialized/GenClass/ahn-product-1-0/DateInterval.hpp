// DateInterval.hpp 
#ifndef FpmlSerialized_DateInterval_hpp
#define FpmlSerialized_DateInterval_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class DateInterval : public ISerialized { 
   public: 
       DateInterval(TiXmlNode* xmlNode);

       bool isFirstDate(){return this->firstDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFirstDate();
      std::string getFirstDateIDRef(){return firstDateIDRef_;}

       bool isLastDate(){return this->lastDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getLastDate();
      std::string getLastDateIDRef(){return lastDateIDRef_;}

       bool isDateForMonthly(){return this->dateForMonthlyIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDateForMonthly();
      std::string getDateForMonthlyIDRef(){return dateForMonthlyIDRef_;}

       bool isDayOfWeekForWeekly(){return this->dayOfWeekForWeeklyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayOfWeekForWeekly();
      std::string getDayOfWeekForWeeklyIDRef(){return dayOfWeekForWeeklyIDRef_;}

       std::string getChoiceStr_timeType(){
           std::string str;
           int count = 0;
           if(!dateForMonthlyIsNull_){
                count += 1;
                str = "dateForMonthly" ;
           }
           if(!dayOfWeekForWeeklyIsNull_){
                count += 1;
                str = "dayOfWeekForWeekly" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_timeType_ = str ;
           return choiceStr_timeType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeDate> firstDate_;
       std::string firstDateIDRef_;
       bool firstDateIsNull_;
       boost::shared_ptr<XsdTypeDate> lastDate_;
       std::string lastDateIDRef_;
       bool lastDateIsNull_;
         boost::shared_ptr<XsdTypeDate> dateForMonthly_;     //choice
       std::string dateForMonthlyIDRef_;
       bool dateForMonthlyIsNull_;
         boost::shared_ptr<XsdTypeToken> dayOfWeekForWeekly_;     //choice
       std::string dayOfWeekForWeeklyIDRef_;
       bool dayOfWeekForWeeklyIsNull_;

       //choiceStr 
       std::string choiceStr_timeType_;

};

} //namespaceFpmlSerialized end
#endif

