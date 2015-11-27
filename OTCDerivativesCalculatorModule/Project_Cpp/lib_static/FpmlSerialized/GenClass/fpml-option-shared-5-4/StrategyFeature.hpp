// StrategyFeature.hpp 
#ifndef FpmlSerialized_StrategyFeature_hpp
#define FpmlSerialized_StrategyFeature_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/StrikeSpread.hpp>
#include <fpml-option-shared-5-4/CalendarSpread.hpp>

namespace FpmlSerialized {

class StrategyFeature : public ISerialized { 
   public: 
       StrategyFeature(TiXmlNode* xmlNode);

       bool isStrikeSpread(){return this->strikeSpreadIsNull_;}
       boost::shared_ptr<StrikeSpread> getStrikeSpread();
      std::string getStrikeSpreadIDRef(){return strikeSpreadIDRef_;}

       bool isCalendarSpread(){return this->calendarSpreadIsNull_;}
       boost::shared_ptr<CalendarSpread> getCalendarSpread();
      std::string getCalendarSpreadIDRef(){return calendarSpreadIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!strikeSpreadIsNull_){
                count += 1;
                str = "strikeSpread" ;
           }
           if(!calendarSpreadIsNull_){
                count += 1;
                str = "calendarSpread" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<StrikeSpread> strikeSpread_;     //choice
       std::string strikeSpreadIDRef_;
       bool strikeSpreadIsNull_;
         boost::shared_ptr<CalendarSpread> calendarSpread_;     //choice
       std::string calendarSpreadIDRef_;
       bool calendarSpreadIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

