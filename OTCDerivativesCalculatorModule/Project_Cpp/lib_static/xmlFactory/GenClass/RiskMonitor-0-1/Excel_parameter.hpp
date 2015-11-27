// Excel_parameter.hpp 
#ifndef FpmlSerialized_Excel_parameter_hpp
#define FpmlSerialized_Excel_parameter_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_result.hpp>
#include <RiskMonitor-0-1/Excel_standardPara.hpp>
#include <RiskMonitor-0-1/Excel_standardSwapPara.hpp>
#include <RiskMonitor-0-1/Excel_standardHifivePara.hpp>
#include <RiskMonitor-0-1/Excel_standardCreditPara.hpp>

namespace FpmlSerialized {

class Excel_parameter : public ISerialized { 
   public: 
       Excel_parameter(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_result(){return this->excel_resultIsNull_;}
       boost::shared_ptr<Excel_result> getExcel_result();


       bool isExcel_standardPara(){return this->excel_standardParaIsNull_;}
       boost::shared_ptr<Excel_standardPara> getExcel_standardPara();


       bool isExcel_standardSwapPara(){return this->excel_standardSwapParaIsNull_;}
       boost::shared_ptr<Excel_standardSwapPara> getExcel_standardSwapPara();


       bool isExcel_standardHifivePara(){return this->excel_standardHifiveParaIsNull_;}
       boost::shared_ptr<Excel_standardHifivePara> getExcel_standardHifivePara();


       bool isExcel_standardCreditPara(){return this->excel_standardCreditParaIsNull_;}
       boost::shared_ptr<Excel_standardCreditPara> getExcel_standardCreditPara();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_standardParaIsNull_){
                count += 1;
                str = "excel_standardPara" ;
           }
           if(!excel_standardSwapParaIsNull_){
                count += 1;
                str = "excel_standardSwapPara" ;
           }
           if(!excel_standardHifiveParaIsNull_){
                count += 1;
                str = "excel_standardHifivePara" ;
           }
           if(!excel_standardCreditParaIsNull_){
                count += 1;
                str = "excel_standardCreditPara" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
       boost::shared_ptr<Excel_result> excel_result_;
       
       bool excel_resultIsNull_;
         boost::shared_ptr<Excel_standardPara> excel_standardPara_;     //choice
       
       bool excel_standardParaIsNull_;
         boost::shared_ptr<Excel_standardSwapPara> excel_standardSwapPara_;     //choice
       
       bool excel_standardSwapParaIsNull_;
         boost::shared_ptr<Excel_standardHifivePara> excel_standardHifivePara_;     //choice
       
       bool excel_standardHifiveParaIsNull_;
         boost::shared_ptr<Excel_standardCreditPara> excel_standardCreditPara_;     //choice
       
       bool excel_standardCreditParaIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

