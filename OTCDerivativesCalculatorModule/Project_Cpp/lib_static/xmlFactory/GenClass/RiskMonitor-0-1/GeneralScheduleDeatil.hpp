// GeneralScheduleDeatil.hpp 
#ifndef FpmlSerialized_GeneralScheduleDeatil_hpp
#define FpmlSerialized_GeneralScheduleDeatil_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/General_scheduleDetail_fixedCoupon.hpp>
#include <RiskMonitor-0-1/General_scheduleDetail_fixedAmount.hpp>

namespace FpmlSerialized {

class GeneralScheduleDeatil : public ISerialized { 
   public: 
       GeneralScheduleDeatil(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isGeneral_scheduleDetail_fixedCoupon(){return this->general_scheduleDetail_fixedCouponIsNull_;}
       boost::shared_ptr<General_scheduleDetail_fixedCoupon> getGeneral_scheduleDetail_fixedCoupon();


       bool isGeneral_scheduleDetail_fixedAmount(){return this->general_scheduleDetail_fixedAmountIsNull_;}
       boost::shared_ptr<General_scheduleDetail_fixedAmount> getGeneral_scheduleDetail_fixedAmount();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!general_scheduleDetail_fixedCouponIsNull_){
                count += 1;
                str = "general_scheduleDetail_fixedCoupon" ;
           }
           if(!general_scheduleDetail_fixedAmountIsNull_){
                count += 1;
                str = "general_scheduleDetail_fixedAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<General_scheduleDetail_fixedCoupon> general_scheduleDetail_fixedCoupon_;     //choice
       
       bool general_scheduleDetail_fixedCouponIsNull_;
         boost::shared_ptr<General_scheduleDetail_fixedAmount> general_scheduleDetail_fixedAmount_;     //choice
       
       bool general_scheduleDetail_fixedAmountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

