// Excel_interface.hpp 
#ifndef FpmlSerialized_Excel_interface_hpp
#define FpmlSerialized_Excel_interface_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_hifive.hpp>
#include <RiskMonitor-0-1/Excel_stepDownKICustom.hpp>
#include <RiskMonitor-0-1/Excel_compositeOption.hpp>
#include <RiskMonitor-0-1/Excel_general.hpp>
#include <RiskMonitor-0-1/Excel_fixedBond.hpp>
#include <RiskMonitor-0-1/Excel_vanillaFloatingBond.hpp>
#include <RiskMonitor-0-1/Excel_structuredBond.hpp>
#include <RiskMonitor-0-1/Excel_fxForward.hpp>
#include <RiskMonitor-0-1/Excel_fxSwap.hpp>
#include <RiskMonitor-0-1/Excel_multiAssetCompositeOption.hpp>

namespace FpmlSerialized {

class Excel_interface : public ISerialized { 
   public: 
       Excel_interface(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_hifive(){return this->excel_hifiveIsNull_;}
       boost::shared_ptr<Excel_hifive> getExcel_hifive();


       bool isExcel_stepDownKICustom(){return this->excel_stepDownKICustomIsNull_;}
       boost::shared_ptr<Excel_stepDownKICustom> getExcel_stepDownKICustom();


       bool isExcel_compositeOption(){return this->excel_compositeOptionIsNull_;}
       boost::shared_ptr<Excel_compositeOption> getExcel_compositeOption();


       bool isExcel_general(){return this->excel_generalIsNull_;}
       boost::shared_ptr<Excel_general> getExcel_general();


       bool isExcel_fixedBond(){return this->excel_fixedBondIsNull_;}
       boost::shared_ptr<Excel_fixedBond> getExcel_fixedBond();


       bool isExcel_vanillaFloatingBond(){return this->excel_vanillaFloatingBondIsNull_;}
       boost::shared_ptr<Excel_vanillaFloatingBond> getExcel_vanillaFloatingBond();


       bool isExcel_structuredBond(){return this->excel_structuredBondIsNull_;}
       boost::shared_ptr<Excel_structuredBond> getExcel_structuredBond();


       bool isExcel_fxForward(){return this->excel_fxForwardIsNull_;}
       boost::shared_ptr<Excel_fxForward> getExcel_fxForward();


       bool isExcel_fxSwap(){return this->excel_fxSwapIsNull_;}
       boost::shared_ptr<Excel_fxSwap> getExcel_fxSwap();


       bool isExcel_multiAssetCompositeOption(){return this->excel_multiAssetCompositeOptionIsNull_;}
       boost::shared_ptr<Excel_multiAssetCompositeOption> getExcel_multiAssetCompositeOption();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_hifiveIsNull_){
                count += 1;
                str = "excel_hifive" ;
           }
           if(!excel_stepDownKICustomIsNull_){
                count += 1;
                str = "excel_stepDownKICustom" ;
           }
           if(!excel_compositeOptionIsNull_){
                count += 1;
                str = "excel_compositeOption" ;
           }
           if(!excel_generalIsNull_){
                count += 1;
                str = "excel_general" ;
           }
           if(!excel_fixedBondIsNull_){
                count += 1;
                str = "excel_fixedBond" ;
           }
           if(!excel_vanillaFloatingBondIsNull_){
                count += 1;
                str = "excel_vanillaFloatingBond" ;
           }
           if(!excel_structuredBondIsNull_){
                count += 1;
                str = "excel_structuredBond" ;
           }
           if(!excel_fxForwardIsNull_){
                count += 1;
                str = "excel_fxForward" ;
           }
           if(!excel_fxSwapIsNull_){
                count += 1;
                str = "excel_fxSwap" ;
           }
           if(!excel_multiAssetCompositeOptionIsNull_){
                count += 1;
                str = "excel_multiAssetCompositeOption" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_hifive> excel_hifive_;     //choice
       
       bool excel_hifiveIsNull_;
         boost::shared_ptr<Excel_stepDownKICustom> excel_stepDownKICustom_;     //choice
       
       bool excel_stepDownKICustomIsNull_;
         boost::shared_ptr<Excel_compositeOption> excel_compositeOption_;     //choice
       
       bool excel_compositeOptionIsNull_;
         boost::shared_ptr<Excel_general> excel_general_;     //choice
       
       bool excel_generalIsNull_;
         boost::shared_ptr<Excel_fixedBond> excel_fixedBond_;     //choice
       
       bool excel_fixedBondIsNull_;
         boost::shared_ptr<Excel_vanillaFloatingBond> excel_vanillaFloatingBond_;     //choice
       
       bool excel_vanillaFloatingBondIsNull_;
         boost::shared_ptr<Excel_structuredBond> excel_structuredBond_;     //choice
       
       bool excel_structuredBondIsNull_;
         boost::shared_ptr<Excel_fxForward> excel_fxForward_;     //choice
       
       bool excel_fxForwardIsNull_;
         boost::shared_ptr<Excel_fxSwap> excel_fxSwap_;     //choice
       
       bool excel_fxSwapIsNull_;
         boost::shared_ptr<Excel_multiAssetCompositeOption> excel_multiAssetCompositeOption_;     //choice
       
       bool excel_multiAssetCompositeOptionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

