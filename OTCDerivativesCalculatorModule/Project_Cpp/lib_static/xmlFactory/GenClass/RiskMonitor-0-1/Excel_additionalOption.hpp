// Excel_additionalOption.hpp 
#ifndef FpmlSerialized_Excel_additionalOption_hpp
#define FpmlSerialized_Excel_additionalOption_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_noneOption.hpp>
#include <RiskMonitor-0-1/Excel_callableOption.hpp>
#include <RiskMonitor-0-1/Excel_puttableOption.hpp>

namespace FpmlSerialized {

class Excel_additionalOption : public ISerialized { 
   public: 
       Excel_additionalOption(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_noneOption(){return this->excel_noneOptionIsNull_;}
       boost::shared_ptr<Excel_noneOption> getExcel_noneOption();


       bool isExcel_callableOption(){return this->excel_callableOptionIsNull_;}
       boost::shared_ptr<Excel_callableOption> getExcel_callableOption();


       bool isExcel_puttableOption(){return this->excel_puttableOptionIsNull_;}
       boost::shared_ptr<Excel_puttableOption> getExcel_puttableOption();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_noneOptionIsNull_){
                count += 1;
                str = "excel_noneOption" ;
           }
           if(!excel_callableOptionIsNull_){
                count += 1;
                str = "excel_callableOption" ;
           }
           if(!excel_puttableOptionIsNull_){
                count += 1;
                str = "excel_puttableOption" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_noneOption> excel_noneOption_;     //choice
       
       bool excel_noneOptionIsNull_;
         boost::shared_ptr<Excel_callableOption> excel_callableOption_;     //choice
       
       bool excel_callableOptionIsNull_;
         boost::shared_ptr<Excel_puttableOption> excel_puttableOption_;     //choice
       
       bool excel_puttableOptionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

