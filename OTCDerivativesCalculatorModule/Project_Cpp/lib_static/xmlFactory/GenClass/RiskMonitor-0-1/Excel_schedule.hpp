// Excel_schedule.hpp 
#ifndef FpmlSerialized_Excel_schedule_hpp
#define FpmlSerialized_Excel_schedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_additionalOption.hpp>
#include <RiskMonitor-0-1/Excel_simpleCalculation.hpp>
#include <RiskMonitor-0-1/Excel_choiceReturnCalculation.hpp>

namespace FpmlSerialized {

class Excel_schedule : public ISerialized { 
   public: 
       Excel_schedule(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_additionalOption(){return this->excel_additionalOptionIsNull_;}
       boost::shared_ptr<Excel_additionalOption> getExcel_additionalOption();


       bool isExcel_simpleCalculation(){return this->excel_simpleCalculationIsNull_;}
       boost::shared_ptr<Excel_simpleCalculation> getExcel_simpleCalculation();


       bool isExcel_choiceReturnCalculation(){return this->excel_choiceReturnCalculationIsNull_;}
       boost::shared_ptr<Excel_choiceReturnCalculation> getExcel_choiceReturnCalculation();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_simpleCalculationIsNull_){
                count += 1;
                str = "excel_simpleCalculation" ;
           }
           if(!excel_choiceReturnCalculationIsNull_){
                count += 1;
                str = "excel_choiceReturnCalculation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
       boost::shared_ptr<Excel_additionalOption> excel_additionalOption_;
       
       bool excel_additionalOptionIsNull_;
         boost::shared_ptr<Excel_simpleCalculation> excel_simpleCalculation_;     //choice
       
       bool excel_simpleCalculationIsNull_;
         boost::shared_ptr<Excel_choiceReturnCalculation> excel_choiceReturnCalculation_;     //choice
       
       bool excel_choiceReturnCalculationIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

