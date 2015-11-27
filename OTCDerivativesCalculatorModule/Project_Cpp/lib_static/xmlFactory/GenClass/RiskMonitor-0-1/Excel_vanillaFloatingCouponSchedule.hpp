// Excel_vanillaFloatingCouponSchedule.hpp 
#ifndef FpmlSerialized_Excel_vanillaFloatingCouponSchedule_hpp
#define FpmlSerialized_Excel_vanillaFloatingCouponSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcID.hpp>

namespace FpmlSerialized {

class Excel_vanillaFloatingCouponSchedule : public ISerialized { 
   public: 
       Excel_vanillaFloatingCouponSchedule(TiXmlNode* xmlNode);

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


       bool isOutGearing(){return this->outGearingIsNull_;}
       boost::shared_ptr<XsdTypeToken> getOutGearing();


       bool isOutSpread(){return this->outSpreadIsNull_;}
       boost::shared_ptr<XsdTypeToken> getOutSpread();


       bool isCap(){return this->capIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCap();


       bool isFloor(){return this->floorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFloor();


       bool isExcel_underlyingCalcID(){return this->excel_underlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcID> getExcel_underlyingCalcID();


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
       boost::shared_ptr<XsdTypeToken> outGearing_;
       
       bool outGearingIsNull_;
       boost::shared_ptr<XsdTypeToken> outSpread_;
       
       bool outSpreadIsNull_;
       boost::shared_ptr<XsdTypeToken> cap_;
       
       bool capIsNull_;
       boost::shared_ptr<XsdTypeToken> floor_;
       
       bool floorIsNull_;
       boost::shared_ptr<Excel_underlyingCalcID> excel_underlyingCalcID_;
       
       bool excel_underlyingCalcIDIsNull_;

};

} //namespaceFpmlSerialized end
#endif

