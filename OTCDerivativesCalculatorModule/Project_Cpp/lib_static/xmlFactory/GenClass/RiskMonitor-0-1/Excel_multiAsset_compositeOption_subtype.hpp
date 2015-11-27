// Excel_multiAsset_compositeOption_subtype.hpp 
#ifndef FpmlSerialized_Excel_multiAsset_compositeOption_subtype_hpp
#define FpmlSerialized_Excel_multiAsset_compositeOption_subtype_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_multiAsset_vanillaCallPut.hpp>
#include <RiskMonitor-0-1/Excel_multiAsset_upInOutCall.hpp>
#include <RiskMonitor-0-1/Excel_multiAsset_downInOutPut.hpp>
#include <RiskMonitor-0-1/Excel_multiAsset_digitalCallPut.hpp>

namespace FpmlSerialized {

class Excel_multiAsset_compositeOption_subtype : public ISerialized { 
   public: 
       Excel_multiAsset_compositeOption_subtype(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_multiAsset_vanillaCallPut(){return this->excel_multiAsset_vanillaCallPutIsNull_;}
       boost::shared_ptr<Excel_multiAsset_vanillaCallPut> getExcel_multiAsset_vanillaCallPut();


       bool isExcel_multiAsset_upInOutCall(){return this->excel_multiAsset_upInOutCallIsNull_;}
       boost::shared_ptr<Excel_multiAsset_upInOutCall> getExcel_multiAsset_upInOutCall();


       bool isExcel_multiAsset_downInOutPut(){return this->excel_multiAsset_downInOutPutIsNull_;}
       boost::shared_ptr<Excel_multiAsset_downInOutPut> getExcel_multiAsset_downInOutPut();


       bool isExcel_multiAsset_digitalCallPut(){return this->excel_multiAsset_digitalCallPutIsNull_;}
       boost::shared_ptr<Excel_multiAsset_digitalCallPut> getExcel_multiAsset_digitalCallPut();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_multiAsset_vanillaCallPutIsNull_){
                count += 1;
                str = "excel_multiAsset_vanillaCallPut" ;
           }
           if(!excel_multiAsset_upInOutCallIsNull_){
                count += 1;
                str = "excel_multiAsset_upInOutCall" ;
           }
           if(!excel_multiAsset_downInOutPutIsNull_){
                count += 1;
                str = "excel_multiAsset_downInOutPut" ;
           }
           if(!excel_multiAsset_digitalCallPutIsNull_){
                count += 1;
                str = "excel_multiAsset_digitalCallPut" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_multiAsset_vanillaCallPut> excel_multiAsset_vanillaCallPut_;     //choice
       
       bool excel_multiAsset_vanillaCallPutIsNull_;
         boost::shared_ptr<Excel_multiAsset_upInOutCall> excel_multiAsset_upInOutCall_;     //choice
       
       bool excel_multiAsset_upInOutCallIsNull_;
         boost::shared_ptr<Excel_multiAsset_downInOutPut> excel_multiAsset_downInOutPut_;     //choice
       
       bool excel_multiAsset_downInOutPutIsNull_;
         boost::shared_ptr<Excel_multiAsset_digitalCallPut> excel_multiAsset_digitalCallPut_;     //choice
       
       bool excel_multiAsset_digitalCallPutIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

