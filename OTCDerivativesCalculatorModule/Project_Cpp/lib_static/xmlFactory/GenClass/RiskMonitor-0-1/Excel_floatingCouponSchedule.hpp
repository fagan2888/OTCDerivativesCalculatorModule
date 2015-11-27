// Excel_floatingCouponSchedule.hpp 
#ifndef FpmlSerialized_Excel_floatingCouponSchedule_hpp
#define FpmlSerialized_Excel_floatingCouponSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_returnCalcInfo.hpp>

namespace FpmlSerialized {

class Excel_floatingCouponSchedule : public ISerialized { 
   public: 
       Excel_floatingCouponSchedule(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationStartDate();


       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationEndDate();


       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDescription();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


       bool isGearing(){return this->gearingIsNull_;}
       boost::shared_ptr<XsdTypeToken> getGearing();


       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSpread();


       bool isExcel_returnCalcInfo(){return this->excel_returnCalcInfoIsNull_;}
       boost::shared_ptr<Excel_returnCalcInfo> getExcel_returnCalcInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<XsdTypeToken> calculationStartDate_;
       
       bool calculationStartDateIsNull_;
       boost::shared_ptr<XsdTypeToken> calculationEndDate_;
       
       bool calculationEndDateIsNull_;
       boost::shared_ptr<XsdTypeToken> description_;
       
       bool descriptionIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;
       boost::shared_ptr<XsdTypeToken> gearing_;
       
       bool gearingIsNull_;
       boost::shared_ptr<XsdTypeToken> spread_;
       
       bool spreadIsNull_;
       boost::shared_ptr<Excel_returnCalcInfo> excel_returnCalcInfo_;
       
       bool excel_returnCalcInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

