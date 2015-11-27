// EventTrigger_A.hpp 
#ifndef FpmlSerialized_EventTrigger_A_hpp
#define FpmlSerialized_EventTrigger_A_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixedRatePayoff_A.hpp>
#include <RiskMonitor-0-1/VanillaFloatingRatePayoff_A.hpp>

namespace FpmlSerialized {

class EventTrigger_A : public ISerialized { 
   public: 
       EventTrigger_A(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isFixedRatePayoff_A(){return this->fixedRatePayoff_AIsNull_;}
       boost::shared_ptr<FixedRatePayoff_A> getFixedRatePayoff_A();


       bool isVanillaFloatingRatePayoff_A(){return this->vanillaFloatingRatePayoff_AIsNull_;}
       boost::shared_ptr<VanillaFloatingRatePayoff_A> getVanillaFloatingRatePayoff_A();


       std::string getChoiceStr_eventTriggerType_A(){
           std::string str;
           int count = 0;
           if(!fixedRatePayoff_AIsNull_){
                count += 1;
                str = "fixedRatePayoff_A" ;
           }
           if(!vanillaFloatingRatePayoff_AIsNull_){
                count += 1;
                str = "vanillaFloatingRatePayoff_A" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_eventTriggerType_A_ = str ;
           return choiceStr_eventTriggerType_A_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<FixedRatePayoff_A> fixedRatePayoff_A_;     //choice
       
       bool fixedRatePayoff_AIsNull_;
         boost::shared_ptr<VanillaFloatingRatePayoff_A> vanillaFloatingRatePayoff_A_;     //choice
       
       bool vanillaFloatingRatePayoff_AIsNull_;

       //choiceStr 
       std::string choiceStr_eventTriggerType_A_;

};

} //namespaceFpmlSerialized end
#endif

