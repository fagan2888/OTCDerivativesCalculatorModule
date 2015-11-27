// Excel_simpleCalculation.hpp 
#ifndef FpmlSerialized_Excel_simpleCalculation_hpp
#define FpmlSerialized_Excel_simpleCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_eventCalcInfo.hpp>
#include <RiskMonitor-0-1/Excel_returnCalcInfo.hpp>
#include <RiskMonitor-0-1/Excel_complementReturnCalc.hpp>
#include <RiskMonitor-0-1/Excel_eventCalcInfo_Call.hpp>
#include <RiskMonitor-0-1/Excel_returnCalcInfo_Call.hpp>
#include <RiskMonitor-0-1/Excel_complementReturnCalc_Call.hpp>
#include <RiskMonitor-0-1/Excel_returnCalcInfo_CallableOption.hpp>

namespace FpmlSerialized {

class Excel_simpleCalculation : public ISerialized { 
   public: 
       Excel_simpleCalculation(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDescription();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


       bool isExcel_eventCalcInfo(){return this->excel_eventCalcInfoIsNull_;}
       boost::shared_ptr<Excel_eventCalcInfo> getExcel_eventCalcInfo();


       bool isExcel_returnCalcInfo(){return this->excel_returnCalcInfoIsNull_;}
       boost::shared_ptr<Excel_returnCalcInfo> getExcel_returnCalcInfo();


       bool isExcel_complementReturnCalc(){return this->excel_complementReturnCalcIsNull_;}
       boost::shared_ptr<Excel_complementReturnCalc> getExcel_complementReturnCalc();


       bool isExcel_eventCalcInfo_Call(){return this->excel_eventCalcInfo_CallIsNull_;}
       boost::shared_ptr<Excel_eventCalcInfo_Call> getExcel_eventCalcInfo_Call();


       bool isExcel_returnCalcInfo_Call(){return this->excel_returnCalcInfo_CallIsNull_;}
       boost::shared_ptr<Excel_returnCalcInfo_Call> getExcel_returnCalcInfo_Call();


       bool isExcel_complementReturnCalc_Call(){return this->excel_complementReturnCalc_CallIsNull_;}
       boost::shared_ptr<Excel_complementReturnCalc_Call> getExcel_complementReturnCalc_Call();


       bool isExcel_returnCalcInfo_CallableOption(){return this->excel_returnCalcInfo_CallableOptionIsNull_;}
       boost::shared_ptr<Excel_returnCalcInfo_CallableOption> getExcel_returnCalcInfo_CallableOption();


   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<XsdTypeToken> description_;
       
       bool descriptionIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;
       boost::shared_ptr<Excel_eventCalcInfo> excel_eventCalcInfo_;
       
       bool excel_eventCalcInfoIsNull_;
       boost::shared_ptr<Excel_returnCalcInfo> excel_returnCalcInfo_;
       
       bool excel_returnCalcInfoIsNull_;
       boost::shared_ptr<Excel_complementReturnCalc> excel_complementReturnCalc_;
       
       bool excel_complementReturnCalcIsNull_;
       boost::shared_ptr<Excel_eventCalcInfo_Call> excel_eventCalcInfo_Call_;
       
       bool excel_eventCalcInfo_CallIsNull_;
       boost::shared_ptr<Excel_returnCalcInfo_Call> excel_returnCalcInfo_Call_;
       
       bool excel_returnCalcInfo_CallIsNull_;
       boost::shared_ptr<Excel_complementReturnCalc_Call> excel_complementReturnCalc_Call_;
       
       bool excel_complementReturnCalc_CallIsNull_;
       boost::shared_ptr<Excel_returnCalcInfo_CallableOption> excel_returnCalcInfo_CallableOption_;
       
       bool excel_returnCalcInfo_CallableOptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

