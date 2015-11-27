// Excel_structuredBond_subtype.hpp 
#ifndef FpmlSerialized_Excel_structuredBond_subtype_hpp
#define FpmlSerialized_Excel_structuredBond_subtype_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_structuredBond_fixedAccrual.hpp>
#include <RiskMonitor-0-1/Excel_structuredBond_floatingAccrual.hpp>

namespace FpmlSerialized {

class Excel_structuredBond_subtype : public ISerialized { 
   public: 
       Excel_structuredBond_subtype(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_structuredBond_fixedAccrual(){return this->excel_structuredBond_fixedAccrualIsNull_;}
       boost::shared_ptr<Excel_structuredBond_fixedAccrual> getExcel_structuredBond_fixedAccrual();


       bool isExcel_structuredBond_floatingAccrual(){return this->excel_structuredBond_floatingAccrualIsNull_;}
       boost::shared_ptr<Excel_structuredBond_floatingAccrual> getExcel_structuredBond_floatingAccrual();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_structuredBond_fixedAccrualIsNull_){
                count += 1;
                str = "excel_structuredBond_fixedAccrual" ;
           }
           if(!excel_structuredBond_floatingAccrualIsNull_){
                count += 1;
                str = "excel_structuredBond_floatingAccrual" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_structuredBond_fixedAccrual> excel_structuredBond_fixedAccrual_;     //choice
       
       bool excel_structuredBond_fixedAccrualIsNull_;
         boost::shared_ptr<Excel_structuredBond_floatingAccrual> excel_structuredBond_floatingAccrual_;     //choice
       
       bool excel_structuredBond_floatingAccrualIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

