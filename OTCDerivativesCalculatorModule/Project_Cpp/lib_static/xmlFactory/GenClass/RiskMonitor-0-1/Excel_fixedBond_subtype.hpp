// Excel_fixedBond_subtype.hpp 
#ifndef FpmlSerialized_Excel_fixedBond_subtype_hpp
#define FpmlSerialized_Excel_fixedBond_subtype_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_fixedBond_constantRate.hpp>

namespace FpmlSerialized {

class Excel_fixedBond_subtype : public ISerialized { 
   public: 
       Excel_fixedBond_subtype(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_fixedBond_constantRate(){return this->excel_fixedBond_constantRateIsNull_;}
       boost::shared_ptr<Excel_fixedBond_constantRate> getExcel_fixedBond_constantRate();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_fixedBond_constantRateIsNull_){
                count += 1;
                str = "excel_fixedBond_constantRate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_fixedBond_constantRate> excel_fixedBond_constantRate_;     //choice
       
       bool excel_fixedBond_constantRateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

