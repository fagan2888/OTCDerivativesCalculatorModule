// DateInformation.hpp 
#ifndef FpmlSerialized_DateInformation_hpp
#define FpmlSerialized_DateInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/DailyInterval.hpp>
#include <RiskMonitor-0-1/DateList.hpp>

namespace FpmlSerialized {

class DateInformation : public ISerialized { 
   public: 
       DateInformation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isDailyInterval(){return this->dailyIntervalIsNull_;}
       boost::shared_ptr<DailyInterval> getDailyInterval();


       bool isDateList(){return this->dateListIsNull_;}
       boost::shared_ptr<DateList> getDateList();


       std::string getChoiceStr_barrierDateType(){
           std::string str;
           int count = 0;
           if(!dailyIntervalIsNull_){
                count += 1;
                str = "dailyInterval" ;
           }
           if(!dateListIsNull_){
                count += 1;
                str = "dateList" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_barrierDateType_ = str ;
           return choiceStr_barrierDateType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<DailyInterval> dailyInterval_;     //choice
       
       bool dailyIntervalIsNull_;
         boost::shared_ptr<DateList> dateList_;     //choice
       
       bool dateListIsNull_;

       //choiceStr 
       std::string choiceStr_barrierDateType_;

};

} //namespaceFpmlSerialized end
#endif

