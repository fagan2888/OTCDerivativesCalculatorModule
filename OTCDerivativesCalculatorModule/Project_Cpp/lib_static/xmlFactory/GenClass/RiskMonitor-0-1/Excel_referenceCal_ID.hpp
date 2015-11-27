// Excel_referenceCal_ID.hpp 
#ifndef FpmlSerialized_Excel_referenceCal_ID_hpp
#define FpmlSerialized_Excel_referenceCal_ID_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_referSimpleCalculation.hpp>

namespace FpmlSerialized {

class Excel_referenceCal_ID : public ISerialized { 
   public: 
       Excel_referenceCal_ID(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_referSimpleCalculation(){return this->excel_referSimpleCalculationIsNull_;}
       boost::shared_ptr<Excel_referSimpleCalculation> getExcel_referSimpleCalculation();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_referSimpleCalculationIsNull_){
                count += 1;
                str = "excel_referSimpleCalculation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_referSimpleCalculation> excel_referSimpleCalculation_;     //choice
       
       bool excel_referSimpleCalculationIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

