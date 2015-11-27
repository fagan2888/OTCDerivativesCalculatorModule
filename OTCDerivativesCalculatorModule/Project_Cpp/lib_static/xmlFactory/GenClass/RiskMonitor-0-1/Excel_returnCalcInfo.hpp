// Excel_returnCalcInfo.hpp 
#ifndef FpmlSerialized_Excel_returnCalcInfo_hpp
#define FpmlSerialized_Excel_returnCalcInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_constReturnCal.hpp>
#include <RiskMonitor-0-1/Excel_vanillaReturnCal.hpp>

namespace FpmlSerialized {

class Excel_returnCalcInfo : public ISerialized { 
   public: 
       Excel_returnCalcInfo(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_constReturnCal(){return this->excel_constReturnCalIsNull_;}
       boost::shared_ptr<Excel_constReturnCal> getExcel_constReturnCal();


       bool isExcel_vanillaReturnCal(){return this->excel_vanillaReturnCalIsNull_;}
       boost::shared_ptr<Excel_vanillaReturnCal> getExcel_vanillaReturnCal();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_constReturnCalIsNull_){
                count += 1;
                str = "excel_constReturnCal" ;
           }
           if(!excel_vanillaReturnCalIsNull_){
                count += 1;
                str = "excel_vanillaReturnCal" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_constReturnCal> excel_constReturnCal_;     //choice
       
       bool excel_constReturnCalIsNull_;
         boost::shared_ptr<Excel_vanillaReturnCal> excel_vanillaReturnCal_;     //choice
       
       bool excel_vanillaReturnCalIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

