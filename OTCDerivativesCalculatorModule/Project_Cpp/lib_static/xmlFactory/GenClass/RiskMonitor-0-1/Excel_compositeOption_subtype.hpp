// Excel_compositeOption_subtype.hpp 
#ifndef FpmlSerialized_Excel_compositeOption_subtype_hpp
#define FpmlSerialized_Excel_compositeOption_subtype_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_vanillaCallPut.hpp>
#include <RiskMonitor-0-1/Excel_upInOutCall.hpp>
#include <RiskMonitor-0-1/Excel_downInOutPut.hpp>
#include <RiskMonitor-0-1/Excel_digitalCallPut.hpp>

namespace FpmlSerialized {

class Excel_compositeOption_subtype : public ISerialized { 
   public: 
       Excel_compositeOption_subtype(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_vanillaCallPut(){return this->excel_vanillaCallPutIsNull_;}
       boost::shared_ptr<Excel_vanillaCallPut> getExcel_vanillaCallPut();


       bool isExcel_upInOutCall(){return this->excel_upInOutCallIsNull_;}
       boost::shared_ptr<Excel_upInOutCall> getExcel_upInOutCall();


       bool isExcel_downInOutPut(){return this->excel_downInOutPutIsNull_;}
       boost::shared_ptr<Excel_downInOutPut> getExcel_downInOutPut();


       bool isExcel_digitalCallPut(){return this->excel_digitalCallPutIsNull_;}
       boost::shared_ptr<Excel_digitalCallPut> getExcel_digitalCallPut();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_vanillaCallPutIsNull_){
                count += 1;
                str = "excel_vanillaCallPut" ;
           }
           if(!excel_upInOutCallIsNull_){
                count += 1;
                str = "excel_upInOutCall" ;
           }
           if(!excel_downInOutPutIsNull_){
                count += 1;
                str = "excel_downInOutPut" ;
           }
           if(!excel_digitalCallPutIsNull_){
                count += 1;
                str = "excel_digitalCallPut" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_vanillaCallPut> excel_vanillaCallPut_;     //choice
       
       bool excel_vanillaCallPutIsNull_;
         boost::shared_ptr<Excel_upInOutCall> excel_upInOutCall_;     //choice
       
       bool excel_upInOutCallIsNull_;
         boost::shared_ptr<Excel_downInOutPut> excel_downInOutPut_;     //choice
       
       bool excel_downInOutPutIsNull_;
         boost::shared_ptr<Excel_digitalCallPut> excel_digitalCallPut_;     //choice
       
       bool excel_digitalCallPutIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

