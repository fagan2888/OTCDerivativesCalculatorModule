// Excel_swapInterface.hpp 
#ifndef FpmlSerialized_Excel_swapInterface_hpp
#define FpmlSerialized_Excel_swapInterface_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_irs.hpp>
#include <RiskMonitor-0-1/Excel_crs.hpp>
#include <RiskMonitor-0-1/Excel_cds.hpp>
#include <RiskMonitor-0-1/Excel_structuredSwap.hpp>

namespace FpmlSerialized {

class Excel_swapInterface : public ISerialized { 
   public: 
       Excel_swapInterface(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_irs(){return this->excel_irsIsNull_;}
       boost::shared_ptr<Excel_irs> getExcel_irs();


       bool isExcel_crs(){return this->excel_crsIsNull_;}
       boost::shared_ptr<Excel_crs> getExcel_crs();


       bool isExcel_cds(){return this->excel_cdsIsNull_;}
       boost::shared_ptr<Excel_cds> getExcel_cds();


       bool isExcel_structuredSwap(){return this->excel_structuredSwapIsNull_;}
       boost::shared_ptr<Excel_structuredSwap> getExcel_structuredSwap();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_irsIsNull_){
                count += 1;
                str = "excel_irs" ;
           }
           if(!excel_crsIsNull_){
                count += 1;
                str = "excel_crs" ;
           }
           if(!excel_cdsIsNull_){
                count += 1;
                str = "excel_cds" ;
           }
           if(!excel_structuredSwapIsNull_){
                count += 1;
                str = "excel_structuredSwap" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_irs> excel_irs_;     //choice
       
       bool excel_irsIsNull_;
         boost::shared_ptr<Excel_crs> excel_crs_;     //choice
       
       bool excel_crsIsNull_;
         boost::shared_ptr<Excel_cds> excel_cds_;     //choice
       
       bool excel_cdsIsNull_;
         boost::shared_ptr<Excel_structuredSwap> excel_structuredSwap_;     //choice
       
       bool excel_structuredSwapIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

