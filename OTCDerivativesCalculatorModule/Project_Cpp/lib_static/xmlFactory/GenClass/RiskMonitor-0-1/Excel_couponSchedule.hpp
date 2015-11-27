// Excel_couponSchedule.hpp 
#ifndef FpmlSerialized_Excel_couponSchedule_hpp
#define FpmlSerialized_Excel_couponSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_additionalOption.hpp>
#include <RiskMonitor-0-1/Excel_fixedCouponSchedule.hpp>
#include <RiskMonitor-0-1/Excel_vanillaFloatingCouponSchedule.hpp>
#include <RiskMonitor-0-1/Excel_floatingCouponSchedule.hpp>
#include <RiskMonitor-0-1/Excel_condi_structuredCouponSchedule.hpp>
#include <RiskMonitor-0-1/Excel_condi_structuredAccrualCouponSchedule.hpp>
#include <RiskMonitor-0-1/Excel_multiCondi_structuredCouponSchedule.hpp>
#include <RiskMonitor-0-1/Excel_multiCondi_structuredAccrualCouponSchedule.hpp>
#include <RiskMonitor-0-1/Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.hpp>

namespace FpmlSerialized {

class Excel_couponSchedule : public ISerialized { 
   public: 
       Excel_couponSchedule(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isExcel_additionalOption(){return this->excel_additionalOptionIsNull_;}
       boost::shared_ptr<Excel_additionalOption> getExcel_additionalOption();


       bool isExcel_fixedCouponSchedule(){return this->excel_fixedCouponScheduleIsNull_;}
       boost::shared_ptr<Excel_fixedCouponSchedule> getExcel_fixedCouponSchedule();


       bool isExcel_vanillaFloatingCouponSchedule(){return this->excel_vanillaFloatingCouponScheduleIsNull_;}
       boost::shared_ptr<Excel_vanillaFloatingCouponSchedule> getExcel_vanillaFloatingCouponSchedule();


       bool isExcel_floatingCouponSchedule(){return this->excel_floatingCouponScheduleIsNull_;}
       boost::shared_ptr<Excel_floatingCouponSchedule> getExcel_floatingCouponSchedule();


       bool isExcel_condi_structuredCouponSchedule(){return this->excel_condi_structuredCouponScheduleIsNull_;}
       boost::shared_ptr<Excel_condi_structuredCouponSchedule> getExcel_condi_structuredCouponSchedule();


       bool isExcel_condi_structuredAccrualCouponSchedule(){return this->excel_condi_structuredAccrualCouponScheduleIsNull_;}
       boost::shared_ptr<Excel_condi_structuredAccrualCouponSchedule> getExcel_condi_structuredAccrualCouponSchedule();


       bool isExcel_multiCondi_structuredCouponSchedule(){return this->excel_multiCondi_structuredCouponScheduleIsNull_;}
       boost::shared_ptr<Excel_multiCondi_structuredCouponSchedule> getExcel_multiCondi_structuredCouponSchedule();


       bool isExcel_multiCondi_structuredAccrualCouponSchedule(){return this->excel_multiCondi_structuredAccrualCouponScheduleIsNull_;}
       boost::shared_ptr<Excel_multiCondi_structuredAccrualCouponSchedule> getExcel_multiCondi_structuredAccrualCouponSchedule();


       bool isExcel_multiCondi_multiRng_structuredAccrualCouponSchedule(){return this->excel_multiCondi_multiRng_structuredAccrualCouponScheduleIsNull_;}
       boost::shared_ptr<Excel_multiCondi_multiRng_structuredAccrualCouponSchedule> getExcel_multiCondi_multiRng_structuredAccrualCouponSchedule();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!excel_fixedCouponScheduleIsNull_){
                count += 1;
                str = "excel_fixedCouponSchedule" ;
           }
           if(!excel_vanillaFloatingCouponScheduleIsNull_){
                count += 1;
                str = "excel_vanillaFloatingCouponSchedule" ;
           }
           if(!excel_floatingCouponScheduleIsNull_){
                count += 1;
                str = "excel_floatingCouponSchedule" ;
           }
           if(!excel_condi_structuredCouponScheduleIsNull_){
                count += 1;
                str = "excel_condi_structuredCouponSchedule" ;
           }
           if(!excel_condi_structuredAccrualCouponScheduleIsNull_){
                count += 1;
                str = "excel_condi_structuredAccrualCouponSchedule" ;
           }
           if(!excel_multiCondi_structuredCouponScheduleIsNull_){
                count += 1;
                str = "excel_multiCondi_structuredCouponSchedule" ;
           }
           if(!excel_multiCondi_structuredAccrualCouponScheduleIsNull_){
                count += 1;
                str = "excel_multiCondi_structuredAccrualCouponSchedule" ;
           }
           if(!excel_multiCondi_multiRng_structuredAccrualCouponScheduleIsNull_){
                count += 1;
                str = "excel_multiCondi_multiRng_structuredAccrualCouponSchedule" ;
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
         boost::shared_ptr<Excel_fixedCouponSchedule> excel_fixedCouponSchedule_;     //choice
       
       bool excel_fixedCouponScheduleIsNull_;
         boost::shared_ptr<Excel_vanillaFloatingCouponSchedule> excel_vanillaFloatingCouponSchedule_;     //choice
       
       bool excel_vanillaFloatingCouponScheduleIsNull_;
         boost::shared_ptr<Excel_floatingCouponSchedule> excel_floatingCouponSchedule_;     //choice
       
       bool excel_floatingCouponScheduleIsNull_;
         boost::shared_ptr<Excel_condi_structuredCouponSchedule> excel_condi_structuredCouponSchedule_;     //choice
       
       bool excel_condi_structuredCouponScheduleIsNull_;
         boost::shared_ptr<Excel_condi_structuredAccrualCouponSchedule> excel_condi_structuredAccrualCouponSchedule_;     //choice
       
       bool excel_condi_structuredAccrualCouponScheduleIsNull_;
         boost::shared_ptr<Excel_multiCondi_structuredCouponSchedule> excel_multiCondi_structuredCouponSchedule_;     //choice
       
       bool excel_multiCondi_structuredCouponScheduleIsNull_;
         boost::shared_ptr<Excel_multiCondi_structuredAccrualCouponSchedule> excel_multiCondi_structuredAccrualCouponSchedule_;     //choice
       
       bool excel_multiCondi_structuredAccrualCouponScheduleIsNull_;
         boost::shared_ptr<Excel_multiCondi_multiRng_structuredAccrualCouponSchedule> excel_multiCondi_multiRng_structuredAccrualCouponSchedule_;     //choice
       
       bool excel_multiCondi_multiRng_structuredAccrualCouponScheduleIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

