// Excel_eventCalcInfo.hpp 
#ifndef FpmlSerialized_Excel_eventCalcInfo_hpp
#define FpmlSerialized_Excel_eventCalcInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_singleRangeEventCal.hpp>
#include <RiskMonitor-0-1/Excel_dualRangeEventCal.hpp>
#include <RiskMonitor-0-1/Excel_singleBarrierEventCal.hpp>
#include <RiskMonitor-0-1/Excel_dualBarrierEventCal.hpp>
#include <RiskMonitor-0-1/Excel_identityEventCal.hpp>

namespace FpmlSerialized {

class Excel_eventCalcInfo : public ISerialized { 
   public: 
       Excel_eventCalcInfo(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_singleRangeEventCal(){return this->excel_singleRangeEventCalIsNull_;}
       boost::shared_ptr<Excel_singleRangeEventCal> getExcel_singleRangeEventCal();


       bool isExcel_dualRangeEventCal(){return this->excel_dualRangeEventCalIsNull_;}
       boost::shared_ptr<Excel_dualRangeEventCal> getExcel_dualRangeEventCal();


       bool isExcel_singleBarrierEventCal(){return this->excel_singleBarrierEventCalIsNull_;}
       boost::shared_ptr<Excel_singleBarrierEventCal> getExcel_singleBarrierEventCal();


       bool isExcel_dualBarrierEventCal(){return this->excel_dualBarrierEventCalIsNull_;}
       boost::shared_ptr<Excel_dualBarrierEventCal> getExcel_dualBarrierEventCal();


       bool isExcel_identityEventCal(){return this->excel_identityEventCalIsNull_;}
       boost::shared_ptr<Excel_identityEventCal> getExcel_identityEventCal();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_singleRangeEventCalIsNull_){
                count += 1;
                str = "excel_singleRangeEventCal" ;
           }
           if(!excel_dualRangeEventCalIsNull_){
                count += 1;
                str = "excel_dualRangeEventCal" ;
           }
           if(!excel_singleBarrierEventCalIsNull_){
                count += 1;
                str = "excel_singleBarrierEventCal" ;
           }
           if(!excel_dualBarrierEventCalIsNull_){
                count += 1;
                str = "excel_dualBarrierEventCal" ;
           }
           if(!excel_identityEventCalIsNull_){
                count += 1;
                str = "excel_identityEventCal" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_singleRangeEventCal> excel_singleRangeEventCal_;     //choice
       
       bool excel_singleRangeEventCalIsNull_;
         boost::shared_ptr<Excel_dualRangeEventCal> excel_dualRangeEventCal_;     //choice
       
       bool excel_dualRangeEventCalIsNull_;
         boost::shared_ptr<Excel_singleBarrierEventCal> excel_singleBarrierEventCal_;     //choice
       
       bool excel_singleBarrierEventCalIsNull_;
         boost::shared_ptr<Excel_dualBarrierEventCal> excel_dualBarrierEventCal_;     //choice
       
       bool excel_dualBarrierEventCalIsNull_;
         boost::shared_ptr<Excel_identityEventCal> excel_identityEventCal_;     //choice
       
       bool excel_identityEventCalIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

