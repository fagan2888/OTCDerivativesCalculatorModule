// Trigger.hpp 
#ifndef FpmlSerialized_Trigger_hpp
#define FpmlSerialized_Trigger_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-option-shared-5-4/CreditEvents.hpp>
#include <fpml-option-shared-5-4/CreditEventsReference.hpp>
#include <fpml-enum-5-4/TriggerTypeEnum.hpp>
#include <fpml-enum-5-4/TriggerTimeTypeEnum.hpp>

namespace FpmlSerialized {

class Trigger : public ISerialized { 
   public: 
       Trigger(TiXmlNode* xmlNode);

       bool isLevel(){return this->levelIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getLevel();
      std::string getLevelIDRef(){return levelIDRef_;}

       bool isLevelPercentage(){return this->levelPercentageIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getLevelPercentage();
      std::string getLevelPercentageIDRef(){return levelPercentageIDRef_;}

       bool isCreditEvents(){return this->creditEventsIsNull_;}
       boost::shared_ptr<CreditEvents> getCreditEvents();
      std::string getCreditEventsIDRef(){return creditEventsIDRef_;}

       bool isCreditEventsReference(){return this->creditEventsReferenceIsNull_;}
       boost::shared_ptr<CreditEventsReference> getCreditEventsReference();
      std::string getCreditEventsReferenceIDRef(){return creditEventsReferenceIDRef_;}

       bool isTriggerType(){return this->triggerTypeIsNull_;}
       boost::shared_ptr<TriggerTypeEnum> getTriggerType();
      std::string getTriggerTypeIDRef(){return triggerTypeIDRef_;}

       bool isTriggerTimeType(){return this->triggerTimeTypeIsNull_;}
       boost::shared_ptr<TriggerTimeTypeEnum> getTriggerTimeType();
      std::string getTriggerTimeTypeIDRef(){return triggerTimeTypeIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!levelIsNull_){
                count += 1;
                str = "level" ;
           }
           if(!levelPercentageIsNull_){
                count += 1;
                str = "levelPercentage" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!creditEventsIsNull_){
                count += 1;
                str = "creditEvents" ;
           }
           if(!creditEventsReferenceIsNull_){
                count += 1;
                str = "creditEventsReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> level_;     //choice
       std::string levelIDRef_;
       bool levelIsNull_;
         boost::shared_ptr<XsdTypeDecimal> levelPercentage_;     //choice
       std::string levelPercentageIDRef_;
       bool levelPercentageIsNull_;
         boost::shared_ptr<CreditEvents> creditEvents_;     //choice
       std::string creditEventsIDRef_;
       bool creditEventsIsNull_;
         boost::shared_ptr<CreditEventsReference> creditEventsReference_;     //choice
       std::string creditEventsReferenceIDRef_;
       bool creditEventsReferenceIsNull_;
       boost::shared_ptr<TriggerTypeEnum> triggerType_;
       std::string triggerTypeIDRef_;
       bool triggerTypeIsNull_;
       boost::shared_ptr<TriggerTimeTypeEnum> triggerTimeType_;
       std::string triggerTimeTypeIDRef_;
       bool triggerTimeTypeIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

