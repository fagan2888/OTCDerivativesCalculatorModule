// Excel_kiEventCalculation.hpp 
#ifndef FpmlSerialized_Excel_kiEventCalculation_hpp
#define FpmlSerialized_Excel_kiEventCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_simpleKiEventCalc.hpp>
#include <RiskMonitor-0-1/Excel_dualKiEventCalc.hpp>
#include <RiskMonitor-0-1/Excel_targetKiEventCalc.hpp>

namespace FpmlSerialized {

class Excel_kiEventCalculation : public ISerialized { 
   public: 
       Excel_kiEventCalculation(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_simpleKiEventCalc(){return this->excel_simpleKiEventCalcIsNull_;}
       boost::shared_ptr<Excel_simpleKiEventCalc> getExcel_simpleKiEventCalc();


       bool isExcel_dualKiEventCalc(){return this->excel_dualKiEventCalcIsNull_;}
       boost::shared_ptr<Excel_dualKiEventCalc> getExcel_dualKiEventCalc();


       bool isExcel_targetKiEventCalc(){return this->excel_targetKiEventCalcIsNull_;}
       boost::shared_ptr<Excel_targetKiEventCalc> getExcel_targetKiEventCalc();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_simpleKiEventCalcIsNull_){
                count += 1;
                str = "excel_simpleKiEventCalc" ;
           }
           if(!excel_dualKiEventCalcIsNull_){
                count += 1;
                str = "excel_dualKiEventCalc" ;
           }
           if(!excel_targetKiEventCalcIsNull_){
                count += 1;
                str = "excel_targetKiEventCalc" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_simpleKiEventCalc> excel_simpleKiEventCalc_;     //choice
       
       bool excel_simpleKiEventCalcIsNull_;
         boost::shared_ptr<Excel_dualKiEventCalc> excel_dualKiEventCalc_;     //choice
       
       bool excel_dualKiEventCalcIsNull_;
         boost::shared_ptr<Excel_targetKiEventCalc> excel_targetKiEventCalc_;     //choice
       
       bool excel_targetKiEventCalcIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

