// EventTrigger.hpp 
#ifndef FpmlSerialized_EventTrigger_hpp
#define FpmlSerialized_EventTrigger_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <RiskMonitor-0-1/AutoTerminationTrigger.hpp>
#include <RiskMonitor-0-1/PreEventCalculation.hpp>
#include <RiskMonitor-0-1/PreConditionEvent.hpp>
#include <RiskMonitor-0-1/AutoCallConstReturnTrigger.hpp>
#include <RiskMonitor-0-1/SimpleRangeConstReturnTrigger.hpp>
#include <RiskMonitor-0-1/SimpleRangeRateTrigger.hpp>
#include <RiskMonitor-0-1/SimpleRangeAccrualRateTrigger.hpp>
#include <RiskMonitor-0-1/FixedRateTrigger.hpp>
#include <RiskMonitor-0-1/VanillaRateTrigger.hpp>
#include <RiskMonitor-0-1/RedemptionNotionalTrigger.hpp>
#include <RiskMonitor-0-1/AutoCallRangeReturnTrigger.hpp>
#include <RiskMonitor-0-1/VanillaCouponTrigger.hpp>
#include <RiskMonitor-0-1/SimpleEventCouponTrigger.hpp>
#include <RiskMonitor-0-1/PostCalculation.hpp>

namespace FpmlSerialized {

class EventTrigger : public ISerialized { 
   public: 
       EventTrigger(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEventDate();


       bool isAutoTerminationTrigger(){return this->autoTerminationTriggerIsNull_;}
       boost::shared_ptr<AutoTerminationTrigger> getAutoTerminationTrigger();


       bool isPreEventCalculation(){return this->preEventCalculationIsNull_;}
       boost::shared_ptr<PreEventCalculation> getPreEventCalculation();


       bool isPreConditionEvent(){return this->preConditionEventIsNull_;}
       boost::shared_ptr<PreConditionEvent> getPreConditionEvent();


       bool isAutoCallConstReturnTrigger(){return this->autoCallConstReturnTriggerIsNull_;}
       boost::shared_ptr<AutoCallConstReturnTrigger> getAutoCallConstReturnTrigger();


       bool isSimpleRangeConstReturnTrigger(){return this->simpleRangeConstReturnTriggerIsNull_;}
       boost::shared_ptr<SimpleRangeConstReturnTrigger> getSimpleRangeConstReturnTrigger();


       bool isSimpleRangeRateTrigger(){return this->simpleRangeRateTriggerIsNull_;}
       boost::shared_ptr<SimpleRangeRateTrigger> getSimpleRangeRateTrigger();


       bool isSimpleRangeAccrualRateTrigger(){return this->simpleRangeAccrualRateTriggerIsNull_;}
       boost::shared_ptr<SimpleRangeAccrualRateTrigger> getSimpleRangeAccrualRateTrigger();


       bool isFixedRateTrigger(){return this->fixedRateTriggerIsNull_;}
       boost::shared_ptr<FixedRateTrigger> getFixedRateTrigger();


       bool isVanillaRateTrigger(){return this->vanillaRateTriggerIsNull_;}
       boost::shared_ptr<VanillaRateTrigger> getVanillaRateTrigger();


       bool isRedemptionNotionalTrigger(){return this->redemptionNotionalTriggerIsNull_;}
       boost::shared_ptr<RedemptionNotionalTrigger> getRedemptionNotionalTrigger();


       bool isAutoCallRangeReturnTrigger(){return this->autoCallRangeReturnTriggerIsNull_;}
       boost::shared_ptr<AutoCallRangeReturnTrigger> getAutoCallRangeReturnTrigger();


       bool isVanillaCouponTrigger(){return this->vanillaCouponTriggerIsNull_;}
       boost::shared_ptr<VanillaCouponTrigger> getVanillaCouponTrigger();


       bool isSimpleEventCouponTrigger(){return this->simpleEventCouponTriggerIsNull_;}
       boost::shared_ptr<SimpleEventCouponTrigger> getSimpleEventCouponTrigger();


       bool isPostCalculation(){return this->postCalculationIsNull_;}
       boost::shared_ptr<PostCalculation> getPostCalculation();


       std::string getChoiceStr_eventTriggerType(){
           std::string str;
           int count = 0;
           if(!autoCallConstReturnTriggerIsNull_){
                count += 1;
                str = "autoCallConstReturnTrigger" ;
           }
           if(!simpleRangeConstReturnTriggerIsNull_){
                count += 1;
                str = "simpleRangeConstReturnTrigger" ;
           }
           if(!simpleRangeRateTriggerIsNull_){
                count += 1;
                str = "simpleRangeRateTrigger" ;
           }
           if(!simpleRangeAccrualRateTriggerIsNull_){
                count += 1;
                str = "simpleRangeAccrualRateTrigger" ;
           }
           if(!fixedRateTriggerIsNull_){
                count += 1;
                str = "fixedRateTrigger" ;
           }
           if(!vanillaRateTriggerIsNull_){
                count += 1;
                str = "vanillaRateTrigger" ;
           }
           if(!redemptionNotionalTriggerIsNull_){
                count += 1;
                str = "redemptionNotionalTrigger" ;
           }
           if(!autoCallRangeReturnTriggerIsNull_){
                count += 1;
                str = "autoCallRangeReturnTrigger" ;
           }
           if(!vanillaCouponTriggerIsNull_){
                count += 1;
                str = "vanillaCouponTrigger" ;
           }
           if(!simpleEventCouponTriggerIsNull_){
                count += 1;
                str = "simpleEventCouponTrigger" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_eventTriggerType_ = str ;
           return choiceStr_eventTriggerType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeDate> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<AutoTerminationTrigger> autoTerminationTrigger_;
       
       bool autoTerminationTriggerIsNull_;
       boost::shared_ptr<PreEventCalculation> preEventCalculation_;
       
       bool preEventCalculationIsNull_;
       boost::shared_ptr<PreConditionEvent> preConditionEvent_;
       
       bool preConditionEventIsNull_;
         boost::shared_ptr<AutoCallConstReturnTrigger> autoCallConstReturnTrigger_;     //choice
       
       bool autoCallConstReturnTriggerIsNull_;
         boost::shared_ptr<SimpleRangeConstReturnTrigger> simpleRangeConstReturnTrigger_;     //choice
       
       bool simpleRangeConstReturnTriggerIsNull_;
         boost::shared_ptr<SimpleRangeRateTrigger> simpleRangeRateTrigger_;     //choice
       
       bool simpleRangeRateTriggerIsNull_;
         boost::shared_ptr<SimpleRangeAccrualRateTrigger> simpleRangeAccrualRateTrigger_;     //choice
       
       bool simpleRangeAccrualRateTriggerIsNull_;
         boost::shared_ptr<FixedRateTrigger> fixedRateTrigger_;     //choice
       
       bool fixedRateTriggerIsNull_;
         boost::shared_ptr<VanillaRateTrigger> vanillaRateTrigger_;     //choice
       
       bool vanillaRateTriggerIsNull_;
         boost::shared_ptr<RedemptionNotionalTrigger> redemptionNotionalTrigger_;     //choice
       
       bool redemptionNotionalTriggerIsNull_;
         boost::shared_ptr<AutoCallRangeReturnTrigger> autoCallRangeReturnTrigger_;     //choice
       
       bool autoCallRangeReturnTriggerIsNull_;
         boost::shared_ptr<VanillaCouponTrigger> vanillaCouponTrigger_;     //choice
       
       bool vanillaCouponTriggerIsNull_;
         boost::shared_ptr<SimpleEventCouponTrigger> simpleEventCouponTrigger_;     //choice
       
       bool simpleEventCouponTriggerIsNull_;
       boost::shared_ptr<PostCalculation> postCalculation_;
       
       bool postCalculationIsNull_;

       //choiceStr 
       std::string choiceStr_eventTriggerType_;

};

} //namespaceFpmlSerialized end
#endif

