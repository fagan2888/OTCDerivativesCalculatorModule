// Excel_stepDownKI_subSchedule.hpp 
#ifndef FpmlSerialized_Excel_stepDownKI_subSchedule_hpp
#define FpmlSerialized_Excel_stepDownKI_subSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_stepDownKI_subSchedule : public ISerialized { 
   public: 
       Excel_stepDownKI_subSchedule(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isTrigger(){return this->triggerIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTrigger();


       bool isCoupon(){return this->couponIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCoupon();


       bool isAverageDays(){return this->averageDaysIsNull_;}
       boost::shared_ptr<XsdTypeToken> getAverageDays();


       bool isUnderCalcType(){return this->underCalcTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderCalcType();


   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> trigger_;
       
       bool triggerIsNull_;
       boost::shared_ptr<XsdTypeToken> coupon_;
       
       bool couponIsNull_;
       boost::shared_ptr<XsdTypeToken> averageDays_;
       
       bool averageDaysIsNull_;
       boost::shared_ptr<XsdTypeToken> underCalcType_;
       
       bool underCalcTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

