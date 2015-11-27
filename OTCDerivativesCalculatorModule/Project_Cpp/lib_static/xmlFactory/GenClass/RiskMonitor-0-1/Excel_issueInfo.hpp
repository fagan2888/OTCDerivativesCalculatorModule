// Excel_issueInfo.hpp 
#ifndef FpmlSerialized_Excel_issueInfo_hpp
#define FpmlSerialized_Excel_issueInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_noteInfo.hpp>
#include <RiskMonitor-0-1/Excel_swapInfo.hpp>
#include <RiskMonitor-0-1/Excel_swapLegInfo.hpp>
#include <RiskMonitor-0-1/Excel_emptyInfo.hpp>

namespace FpmlSerialized {

class Excel_issueInfo : public ISerialized { 
   public: 
       Excel_issueInfo(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_noteInfo(){return this->excel_noteInfoIsNull_;}
       boost::shared_ptr<Excel_noteInfo> getExcel_noteInfo();


       bool isExcel_swapInfo(){return this->excel_swapInfoIsNull_;}
       boost::shared_ptr<Excel_swapInfo> getExcel_swapInfo();


       bool isExcel_swapLegInfo(){return this->excel_swapLegInfoIsNull_;}
       boost::shared_ptr<Excel_swapLegInfo> getExcel_swapLegInfo();


       bool isExcel_emptyInfo(){return this->excel_emptyInfoIsNull_;}
       boost::shared_ptr<Excel_emptyInfo> getExcel_emptyInfo();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_noteInfoIsNull_){
                count += 1;
                str = "excel_noteInfo" ;
           }
           if(!excel_swapInfoIsNull_){
                count += 1;
                str = "excel_swapInfo" ;
           }
           if(!excel_swapLegInfoIsNull_){
                count += 1;
                str = "excel_swapLegInfo" ;
           }
           if(!excel_emptyInfoIsNull_){
                count += 1;
                str = "excel_emptyInfo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_noteInfo> excel_noteInfo_;     //choice
       
       bool excel_noteInfoIsNull_;
         boost::shared_ptr<Excel_swapInfo> excel_swapInfo_;     //choice
       
       bool excel_swapInfoIsNull_;
         boost::shared_ptr<Excel_swapLegInfo> excel_swapLegInfo_;     //choice
       
       bool excel_swapLegInfoIsNull_;
         boost::shared_ptr<Excel_emptyInfo> excel_emptyInfo_;     //choice
       
       bool excel_emptyInfoIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

