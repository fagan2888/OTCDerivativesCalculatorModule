// EventCalculation.hpp 
#ifndef FpmlSerialized_EventCalculation_hpp
#define FpmlSerialized_EventCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/PreConditionEvent.hpp>
#include <RiskMonitor-0-1/UpperBarrierEventCal.hpp>
#include <RiskMonitor-0-1/LowerBarrierEventCal.hpp>
#include <RiskMonitor-0-1/DualBarrierEventCal.hpp>
#include <RiskMonitor-0-1/SimpleRangeEventCal.hpp>
#include <RiskMonitor-0-1/ReferenceEventCal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <RiskMonitor-0-1/RefVariable_eventOcc.hpp>

namespace FpmlSerialized {

class EventCalculation : public ISerialized { 
   public: 
       EventCalculation(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isPreConditionEvent(){return this->preConditionEventIsNull_;}
       boost::shared_ptr<PreConditionEvent> getPreConditionEvent();


       bool isUpperBarrierEventCal(){return this->upperBarrierEventCalIsNull_;}
       boost::shared_ptr<UpperBarrierEventCal> getUpperBarrierEventCal();


       bool isLowerBarrierEventCal(){return this->lowerBarrierEventCalIsNull_;}
       boost::shared_ptr<LowerBarrierEventCal> getLowerBarrierEventCal();


       bool isDualBarrierEventCal(){return this->dualBarrierEventCalIsNull_;}
       boost::shared_ptr<DualBarrierEventCal> getDualBarrierEventCal();


       bool isSimpleRangeEventCal(){return this->simpleRangeEventCalIsNull_;}
       boost::shared_ptr<SimpleRangeEventCal> getSimpleRangeEventCal();


       bool isReferenceEventCal(){return this->referenceEventCalIsNull_;}
       boost::shared_ptr<ReferenceEventCal> getReferenceEventCal();


       bool isPastEventOcc(){return this->pastEventOccIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPastEventOcc();


       bool isRefVariable_eventOcc(){return this->refVariable_eventOccIsNull_;}
       boost::shared_ptr<RefVariable_eventOcc> getRefVariable_eventOcc();


       std::string getChoiceStr_eventCalType(){
           std::string str;
           int count = 0;
           if(!upperBarrierEventCalIsNull_){
                count += 1;
                str = "upperBarrierEventCal" ;
           }
           if(!lowerBarrierEventCalIsNull_){
                count += 1;
                str = "lowerBarrierEventCal" ;
           }
           if(!dualBarrierEventCalIsNull_){
                count += 1;
                str = "dualBarrierEventCal" ;
           }
           if(!simpleRangeEventCalIsNull_){
                count += 1;
                str = "simpleRangeEventCal" ;
           }
           if(!referenceEventCalIsNull_){
                count += 1;
                str = "referenceEventCal" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_eventCalType_ = str ;
           return choiceStr_eventCalType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<PreConditionEvent> preConditionEvent_;
       
       bool preConditionEventIsNull_;
         boost::shared_ptr<UpperBarrierEventCal> upperBarrierEventCal_;     //choice
       
       bool upperBarrierEventCalIsNull_;
         boost::shared_ptr<LowerBarrierEventCal> lowerBarrierEventCal_;     //choice
       
       bool lowerBarrierEventCalIsNull_;
         boost::shared_ptr<DualBarrierEventCal> dualBarrierEventCal_;     //choice
       
       bool dualBarrierEventCalIsNull_;
         boost::shared_ptr<SimpleRangeEventCal> simpleRangeEventCal_;     //choice
       
       bool simpleRangeEventCalIsNull_;
         boost::shared_ptr<ReferenceEventCal> referenceEventCal_;     //choice
       
       bool referenceEventCalIsNull_;
       boost::shared_ptr<XsdTypeBoolean> pastEventOcc_;
       
       bool pastEventOccIsNull_;
       boost::shared_ptr<RefVariable_eventOcc> refVariable_eventOcc_;
       
       bool refVariable_eventOccIsNull_;

       //choiceStr 
       std::string choiceStr_eventCalType_;

};

} //namespaceFpmlSerialized end
#endif

