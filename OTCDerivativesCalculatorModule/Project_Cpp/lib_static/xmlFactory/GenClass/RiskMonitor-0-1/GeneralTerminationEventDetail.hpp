// GeneralTerminationEventDetail.hpp 
#ifndef FpmlSerialized_GeneralTerminationEventDetail_hpp
#define FpmlSerialized_GeneralTerminationEventDetail_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/General_TerminationEventDetail_credit.hpp>
#include <RiskMonitor-0-1/General_TerminationEventDetail_target.hpp>

namespace FpmlSerialized {

class GeneralTerminationEventDetail : public ISerialized { 
   public: 
       GeneralTerminationEventDetail(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isGeneral_TerminationEventDetail_credit(){return this->general_TerminationEventDetail_creditIsNull_;}
       boost::shared_ptr<General_TerminationEventDetail_credit> getGeneral_TerminationEventDetail_credit();


       bool isGeneral_TerminationEventDetail_target(){return this->general_TerminationEventDetail_targetIsNull_;}
       boost::shared_ptr<General_TerminationEventDetail_target> getGeneral_TerminationEventDetail_target();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!general_TerminationEventDetail_creditIsNull_){
                count += 1;
                str = "general_TerminationEventDetail_credit" ;
           }
           if(!general_TerminationEventDetail_targetIsNull_){
                count += 1;
                str = "general_TerminationEventDetail_target" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<General_TerminationEventDetail_credit> general_TerminationEventDetail_credit_;     //choice
       
       bool general_TerminationEventDetail_creditIsNull_;
         boost::shared_ptr<General_TerminationEventDetail_target> general_TerminationEventDetail_target_;     //choice
       
       bool general_TerminationEventDetail_targetIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

