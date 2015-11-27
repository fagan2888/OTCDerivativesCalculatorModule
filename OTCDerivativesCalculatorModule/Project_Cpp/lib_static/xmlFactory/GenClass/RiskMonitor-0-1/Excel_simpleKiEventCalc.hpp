// Excel_simpleKiEventCalc.hpp 
#ifndef FpmlSerialized_Excel_simpleKiEventCalc_hpp
#define FpmlSerialized_Excel_simpleKiEventCalc_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_eventCalcInfo.hpp>
#include <RiskMonitor-0-1/Excel_occReturnCalcInfo.hpp>
#include <RiskMonitor-0-1/Excel_noOccReturnCalcInfo.hpp>

namespace FpmlSerialized {

class Excel_simpleKiEventCalc : public ISerialized { 
   public: 
       Excel_simpleKiEventCalc(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


       bool isExcel_eventCalcInfo(){return this->excel_eventCalcInfoIsNull_;}
       boost::shared_ptr<Excel_eventCalcInfo> getExcel_eventCalcInfo();


       bool isExcel_occReturnCalcInfo(){return this->excel_occReturnCalcInfoIsNull_;}
       boost::shared_ptr<Excel_occReturnCalcInfo> getExcel_occReturnCalcInfo();


       bool isExcel_noOccReturnCalcInfo(){return this->excel_noOccReturnCalcInfoIsNull_;}
       boost::shared_ptr<Excel_noOccReturnCalcInfo> getExcel_noOccReturnCalcInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;
       boost::shared_ptr<Excel_eventCalcInfo> excel_eventCalcInfo_;
       
       bool excel_eventCalcInfoIsNull_;
       boost::shared_ptr<Excel_occReturnCalcInfo> excel_occReturnCalcInfo_;
       
       bool excel_occReturnCalcInfoIsNull_;
       boost::shared_ptr<Excel_noOccReturnCalcInfo> excel_noOccReturnCalcInfo_;
       
       bool excel_noOccReturnCalcInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

