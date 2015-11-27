// Excel_hifive_subtype.hpp 
#ifndef FpmlSerialized_Excel_hifive_subtype_hpp
#define FpmlSerialized_Excel_hifive_subtype_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_hifive_stepDown_ki.hpp>

namespace FpmlSerialized {

class Excel_hifive_subtype : public ISerialized { 
   public: 
       Excel_hifive_subtype(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_hifive_stepDown_ki(){return this->excel_hifive_stepDown_kiIsNull_;}
       boost::shared_ptr<Excel_hifive_stepDown_ki> getExcel_hifive_stepDown_ki();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_hifive_stepDown_kiIsNull_){
                count += 1;
                str = "excel_hifive_stepDown_ki" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_hifive_stepDown_ki> excel_hifive_stepDown_ki_;     //choice
       
       bool excel_hifive_stepDown_kiIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

