// Excel_underlyingModel_para.hpp 
#ifndef FpmlSerialized_Excel_underlyingModel_para_hpp
#define FpmlSerialized_Excel_underlyingModel_para_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_geometricBM.hpp>
#include <RiskMonitor-0-1/Excel_hullWhiteOneFactor.hpp>
#include <RiskMonitor-0-1/Excel_hullWhiteTwoFactor.hpp>
#include <RiskMonitor-0-1/Excel_forwardModel.hpp>
#include <RiskMonitor-0-1/Excel_hestonModel.hpp>
#include <RiskMonitor-0-1/Excel_geometricBM_LocalVol.hpp>

namespace FpmlSerialized {

class Excel_underlyingModel_para : public ISerialized { 
   public: 
       Excel_underlyingModel_para(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_geometricBM(){return this->excel_geometricBMIsNull_;}
       boost::shared_ptr<Excel_geometricBM> getExcel_geometricBM();


       bool isExcel_hullWhiteOneFactor(){return this->excel_hullWhiteOneFactorIsNull_;}
       boost::shared_ptr<Excel_hullWhiteOneFactor> getExcel_hullWhiteOneFactor();


       bool isExcel_hullWhiteTwoFactor(){return this->excel_hullWhiteTwoFactorIsNull_;}
       boost::shared_ptr<Excel_hullWhiteTwoFactor> getExcel_hullWhiteTwoFactor();


       bool isExcel_forwardModel(){return this->excel_forwardModelIsNull_;}
       boost::shared_ptr<Excel_forwardModel> getExcel_forwardModel();


       bool isExcel_hestonModel(){return this->excel_hestonModelIsNull_;}
       boost::shared_ptr<Excel_hestonModel> getExcel_hestonModel();


       bool isExcel_geometricBM_LocalVol(){return this->excel_geometricBM_LocalVolIsNull_;}
       boost::shared_ptr<Excel_geometricBM_LocalVol> getExcel_geometricBM_LocalVol();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_geometricBMIsNull_){
                count += 1;
                str = "excel_geometricBM" ;
           }
           if(!excel_hullWhiteOneFactorIsNull_){
                count += 1;
                str = "excel_hullWhiteOneFactor" ;
           }
           if(!excel_hullWhiteTwoFactorIsNull_){
                count += 1;
                str = "excel_hullWhiteTwoFactor" ;
           }
           if(!excel_forwardModelIsNull_){
                count += 1;
                str = "excel_forwardModel" ;
           }
           if(!excel_hestonModelIsNull_){
                count += 1;
                str = "excel_hestonModel" ;
           }
           if(!excel_geometricBM_LocalVolIsNull_){
                count += 1;
                str = "excel_geometricBM_LocalVol" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
         boost::shared_ptr<Excel_geometricBM> excel_geometricBM_;     //choice
       
       bool excel_geometricBMIsNull_;
         boost::shared_ptr<Excel_hullWhiteOneFactor> excel_hullWhiteOneFactor_;     //choice
       
       bool excel_hullWhiteOneFactorIsNull_;
         boost::shared_ptr<Excel_hullWhiteTwoFactor> excel_hullWhiteTwoFactor_;     //choice
       
       bool excel_hullWhiteTwoFactorIsNull_;
         boost::shared_ptr<Excel_forwardModel> excel_forwardModel_;     //choice
       
       bool excel_forwardModelIsNull_;
         boost::shared_ptr<Excel_hestonModel> excel_hestonModel_;     //choice
       
       bool excel_hestonModelIsNull_;
         boost::shared_ptr<Excel_geometricBM_LocalVol> excel_geometricBM_LocalVol_;     //choice
       
       bool excel_geometricBM_LocalVolIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

