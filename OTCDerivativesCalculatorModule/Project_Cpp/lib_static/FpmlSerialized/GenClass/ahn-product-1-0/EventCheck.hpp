// EventCheck.hpp 
#ifndef FpmlSerialized_EventCheck_hpp
#define FpmlSerialized_EventCheck_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/EventCheckNormal.hpp>
#include <ahn-product-1-0/EventCheckTime.hpp>

namespace FpmlSerialized {

class EventCheck : public ISerialized { 
   public: 
       EventCheck(TiXmlNode* xmlNode);

       bool isEventCheckNormal(){return this->eventCheckNormalIsNull_;}
       boost::shared_ptr<EventCheckNormal> getEventCheckNormal();
      std::string getEventCheckNormalIDRef(){return eventCheckNormalIDRef_;}

       bool isEventCheckTime(){return this->eventCheckTimeIsNull_;}
       boost::shared_ptr<EventCheckTime> getEventCheckTime();
      std::string getEventCheckTimeIDRef(){return eventCheckTimeIDRef_;}

       std::string getChoiceStr_ecType(){
           std::string str;
           int count = 0;
           if(!eventCheckNormalIsNull_){
                count += 1;
                str = "eventCheckNormal" ;
           }
           if(!eventCheckTimeIsNull_){
                count += 1;
                str = "eventCheckTime" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_ecType_ = str ;
           return choiceStr_ecType_;
       }
   protected: 
         boost::shared_ptr<EventCheckNormal> eventCheckNormal_;     //choice
       std::string eventCheckNormalIDRef_;
       bool eventCheckNormalIsNull_;
         boost::shared_ptr<EventCheckTime> eventCheckTime_;     //choice
       std::string eventCheckTimeIDRef_;
       bool eventCheckTimeIsNull_;

       //choiceStr 
       std::string choiceStr_ecType_;

};

} //namespaceFpmlSerialized end
#endif

