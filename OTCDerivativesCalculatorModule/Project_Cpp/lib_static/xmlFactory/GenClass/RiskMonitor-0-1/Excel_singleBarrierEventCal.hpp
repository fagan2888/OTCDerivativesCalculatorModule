// Excel_singleBarrierEventCal.hpp 
#ifndef FpmlSerialized_Excel_singleBarrierEventCal_hpp
#define FpmlSerialized_Excel_singleBarrierEventCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcID.hpp>

namespace FpmlSerialized {

class Excel_singleBarrierEventCal : public ISerialized { 
   public: 
       Excel_singleBarrierEventCal(TiXmlNode* xmlNode);

       bool isLowerTrigger(){return this->lowerTriggerIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLowerTrigger();


       bool isUpperTrigger(){return this->upperTriggerIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUpperTrigger();


       bool isExcel_underlyingCalcID(){return this->excel_underlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcID> getExcel_underlyingCalcID();


       bool isObservationStartDate(){return this->observationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getObservationStartDate();


       bool isObservationEndDate(){return this->observationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getObservationEndDate();


   protected: 
       boost::shared_ptr<XsdTypeToken> lowerTrigger_;
       
       bool lowerTriggerIsNull_;
       boost::shared_ptr<XsdTypeToken> upperTrigger_;
       
       bool upperTriggerIsNull_;
       boost::shared_ptr<Excel_underlyingCalcID> excel_underlyingCalcID_;
       
       bool excel_underlyingCalcIDIsNull_;
       boost::shared_ptr<XsdTypeToken> observationStartDate_;
       
       bool observationStartDateIsNull_;
       boost::shared_ptr<XsdTypeToken> observationEndDate_;
       
       bool observationEndDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

