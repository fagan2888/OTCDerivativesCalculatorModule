// JointEventCalculation.hpp 
#ifndef FpmlSerialized_JointEventCalculation_hpp
#define FpmlSerialized_JointEventCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/AndEventCal.hpp>
#include <RiskMonitor-0-1/OrEventCal.hpp>
#include <RiskMonitor-0-1/AtLeastEventCal.hpp>
#include <RiskMonitor-0-1/AtMostEventCal.hpp>
#include <RiskMonitor-0-1/CountEventCal.hpp>

namespace FpmlSerialized {

class JointEventCalculation : public ISerialized { 
   public: 
       JointEventCalculation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isAndEventCal(){return this->andEventCalIsNull_;}
       boost::shared_ptr<AndEventCal> getAndEventCal();


       bool isOrEventCal(){return this->orEventCalIsNull_;}
       boost::shared_ptr<OrEventCal> getOrEventCal();


       bool isAtLeastEventCal(){return this->atLeastEventCalIsNull_;}
       boost::shared_ptr<AtLeastEventCal> getAtLeastEventCal();


       bool isAtMostEventCal(){return this->atMostEventCalIsNull_;}
       boost::shared_ptr<AtMostEventCal> getAtMostEventCal();


       bool isCountEventCal(){return this->countEventCalIsNull_;}
       boost::shared_ptr<CountEventCal> getCountEventCal();


       std::string getChoiceStr_jointEventType(){
           std::string str;
           int count = 0;
           if(!andEventCalIsNull_){
                count += 1;
                str = "andEventCal" ;
           }
           if(!orEventCalIsNull_){
                count += 1;
                str = "orEventCal" ;
           }
           if(!atLeastEventCalIsNull_){
                count += 1;
                str = "atLeastEventCal" ;
           }
           if(!atMostEventCalIsNull_){
                count += 1;
                str = "atMostEventCal" ;
           }
           if(!countEventCalIsNull_){
                count += 1;
                str = "countEventCal" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_jointEventType_ = str ;
           return choiceStr_jointEventType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<AndEventCal> andEventCal_;     //choice
       
       bool andEventCalIsNull_;
         boost::shared_ptr<OrEventCal> orEventCal_;     //choice
       
       bool orEventCalIsNull_;
         boost::shared_ptr<AtLeastEventCal> atLeastEventCal_;     //choice
       
       bool atLeastEventCalIsNull_;
         boost::shared_ptr<AtMostEventCal> atMostEventCal_;     //choice
       
       bool atMostEventCalIsNull_;
         boost::shared_ptr<CountEventCal> countEventCal_;     //choice
       
       bool countEventCalIsNull_;

       //choiceStr 
       std::string choiceStr_jointEventType_;

};

} //namespaceFpmlSerialized end
#endif

