// Excel_swapLeg.hpp 
#ifndef FpmlSerialized_Excel_swapLeg_hpp
#define FpmlSerialized_Excel_swapLeg_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_fixedRateSwapLeg.hpp>
#include <RiskMonitor-0-1/Excel_vanillaFloatingRateSwapLeg.hpp>
#include <RiskMonitor-0-1/Excel_structuredSwapLeg.hpp>
#include <RiskMonitor-0-1/Excel_creditEventSwapLeg.hpp>
#include <RiskMonitor-0-1/Excel_hifiveSwapLeg.hpp>

namespace FpmlSerialized {

class Excel_swapLeg : public ISerialized { 
   public: 
       Excel_swapLeg(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_fixedRateSwapLeg(){return this->excel_fixedRateSwapLegIsNull_;}
       boost::shared_ptr<Excel_fixedRateSwapLeg> getExcel_fixedRateSwapLeg();


       bool isExcel_vanillaFloatingRateSwapLeg(){return this->excel_vanillaFloatingRateSwapLegIsNull_;}
       boost::shared_ptr<Excel_vanillaFloatingRateSwapLeg> getExcel_vanillaFloatingRateSwapLeg();


       bool isExcel_structuredSwapLeg(){return this->excel_structuredSwapLegIsNull_;}
       boost::shared_ptr<Excel_structuredSwapLeg> getExcel_structuredSwapLeg();


       bool isExcel_creditEventSwapLeg(){return this->excel_creditEventSwapLegIsNull_;}
       boost::shared_ptr<Excel_creditEventSwapLeg> getExcel_creditEventSwapLeg();


       bool isExcel_hifiveSwapLeg(){return this->excel_hifiveSwapLegIsNull_;}
       boost::shared_ptr<Excel_hifiveSwapLeg> getExcel_hifiveSwapLeg();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_fixedRateSwapLegIsNull_){
                count += 1;
                str = "excel_fixedRateSwapLeg" ;
           }
           if(!excel_vanillaFloatingRateSwapLegIsNull_){
                count += 1;
                str = "excel_vanillaFloatingRateSwapLeg" ;
           }
           if(!excel_structuredSwapLegIsNull_){
                count += 1;
                str = "excel_structuredSwapLeg" ;
           }
           if(!excel_creditEventSwapLegIsNull_){
                count += 1;
                str = "excel_creditEventSwapLeg" ;
           }
           if(!excel_hifiveSwapLegIsNull_){
                count += 1;
                str = "excel_hifiveSwapLeg" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_fixedRateSwapLeg> excel_fixedRateSwapLeg_;     //choice
       
       bool excel_fixedRateSwapLegIsNull_;
         boost::shared_ptr<Excel_vanillaFloatingRateSwapLeg> excel_vanillaFloatingRateSwapLeg_;     //choice
       
       bool excel_vanillaFloatingRateSwapLegIsNull_;
         boost::shared_ptr<Excel_structuredSwapLeg> excel_structuredSwapLeg_;     //choice
       
       bool excel_structuredSwapLegIsNull_;
         boost::shared_ptr<Excel_creditEventSwapLeg> excel_creditEventSwapLeg_;     //choice
       
       bool excel_creditEventSwapLegIsNull_;
         boost::shared_ptr<Excel_hifiveSwapLeg> excel_hifiveSwapLeg_;     //choice
       
       bool excel_hifiveSwapLegIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

