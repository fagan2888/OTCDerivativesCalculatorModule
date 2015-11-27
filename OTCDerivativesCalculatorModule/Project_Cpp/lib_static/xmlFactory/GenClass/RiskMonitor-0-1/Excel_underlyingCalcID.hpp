// Excel_underlyingCalcID.hpp 
#ifndef FpmlSerialized_Excel_underlyingCalcID_hpp
#define FpmlSerialized_Excel_underlyingCalcID_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_choiceUnderlyingCalcID.hpp>
#include <RiskMonitor-0-1/Excel_maximumUnderlyingCalcID.hpp>
#include <RiskMonitor-0-1/Excel_minimumUnderlyingCalcID.hpp>
#include <RiskMonitor-0-1/Excel_averageUnderlyingCalcID.hpp>
#include <RiskMonitor-0-1/Excel_orderUnderlyingCalcID.hpp>

namespace FpmlSerialized {

class Excel_underlyingCalcID : public ISerialized { 
   public: 
       Excel_underlyingCalcID(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isCalcID(){return this->calcIDIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalcID();


       bool isExcel_choiceUnderlyingCalcID(){return this->excel_choiceUnderlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_choiceUnderlyingCalcID> getExcel_choiceUnderlyingCalcID();


       bool isExcel_maximumUnderlyingCalcID(){return this->excel_maximumUnderlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_maximumUnderlyingCalcID> getExcel_maximumUnderlyingCalcID();


       bool isExcel_minimumUnderlyingCalcID(){return this->excel_minimumUnderlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_minimumUnderlyingCalcID> getExcel_minimumUnderlyingCalcID();


       bool isExcel_averageUnderlyingCalcID(){return this->excel_averageUnderlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_averageUnderlyingCalcID> getExcel_averageUnderlyingCalcID();


       bool isExcel_orderUnderlyingCalcID(){return this->excel_orderUnderlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_orderUnderlyingCalcID> getExcel_orderUnderlyingCalcID();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_choiceUnderlyingCalcIDIsNull_){
                count += 1;
                str = "excel_choiceUnderlyingCalcID" ;
           }
           if(!excel_maximumUnderlyingCalcIDIsNull_){
                count += 1;
                str = "excel_maximumUnderlyingCalcID" ;
           }
           if(!excel_minimumUnderlyingCalcIDIsNull_){
                count += 1;
                str = "excel_minimumUnderlyingCalcID" ;
           }
           if(!excel_averageUnderlyingCalcIDIsNull_){
                count += 1;
                str = "excel_averageUnderlyingCalcID" ;
           }
           if(!excel_orderUnderlyingCalcIDIsNull_){
                count += 1;
                str = "excel_orderUnderlyingCalcID" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
       boost::shared_ptr<XsdTypeToken> calcID_;
       
       bool calcIDIsNull_;
         boost::shared_ptr<Excel_choiceUnderlyingCalcID> excel_choiceUnderlyingCalcID_;     //choice
       
       bool excel_choiceUnderlyingCalcIDIsNull_;
         boost::shared_ptr<Excel_maximumUnderlyingCalcID> excel_maximumUnderlyingCalcID_;     //choice
       
       bool excel_maximumUnderlyingCalcIDIsNull_;
         boost::shared_ptr<Excel_minimumUnderlyingCalcID> excel_minimumUnderlyingCalcID_;     //choice
       
       bool excel_minimumUnderlyingCalcIDIsNull_;
         boost::shared_ptr<Excel_averageUnderlyingCalcID> excel_averageUnderlyingCalcID_;     //choice
       
       bool excel_averageUnderlyingCalcIDIsNull_;
         boost::shared_ptr<Excel_orderUnderlyingCalcID> excel_orderUnderlyingCalcID_;     //choice
       
       bool excel_orderUnderlyingCalcIDIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

