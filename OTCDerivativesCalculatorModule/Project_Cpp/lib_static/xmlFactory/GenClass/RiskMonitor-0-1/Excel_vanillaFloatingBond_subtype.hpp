// Excel_vanillaFloatingBond_subtype.hpp 
#ifndef FpmlSerialized_Excel_vanillaFloatingBond_subtype_hpp
#define FpmlSerialized_Excel_vanillaFloatingBond_subtype_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_vanillaFloatingBond_simple.hpp>

namespace FpmlSerialized {

class Excel_vanillaFloatingBond_subtype : public ISerialized { 
   public: 
       Excel_vanillaFloatingBond_subtype(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_vanillaFloatingBond_simple(){return this->excel_vanillaFloatingBond_simpleIsNull_;}
       boost::shared_ptr<Excel_vanillaFloatingBond_simple> getExcel_vanillaFloatingBond_simple();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_vanillaFloatingBond_simpleIsNull_){
                count += 1;
                str = "excel_vanillaFloatingBond_simple" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_vanillaFloatingBond_simple> excel_vanillaFloatingBond_simple_;     //choice
       
       bool excel_vanillaFloatingBond_simpleIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

