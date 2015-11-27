// CommodityRelativePaymentDates.hpp 
#ifndef FpmlSerialized_CommodityRelativePaymentDates_hpp
#define FpmlSerialized_CommodityRelativePaymentDates_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/CommodityPayRelativeToEnum.hpp>
#include <fpml-com-5-4/CommodityPayRelativeToEvent.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>
#include <fpml-shared-5-4/DateOffset.hpp>
#include <fpml-shared-5-4/BusinessCentersReference.hpp>
#include <fpml-shared-5-4/BusinessCenters.hpp>

namespace FpmlSerialized {

class CommodityRelativePaymentDates : public ISerialized { 
   public: 
       CommodityRelativePaymentDates(TiXmlNode* xmlNode);

       bool isPayRelativeTo(){return this->payRelativeToIsNull_;}
       boost::shared_ptr<CommodityPayRelativeToEnum> getPayRelativeTo();
      std::string getPayRelativeToIDRef(){return payRelativeToIDRef_;}

       bool isPayRelativeToEvent(){return this->payRelativeToEventIsNull_;}
       boost::shared_ptr<CommodityPayRelativeToEvent> getPayRelativeToEvent();
      std::string getPayRelativeToEventIDRef(){return payRelativeToEventIDRef_;}

       bool isCalculationPeriodsReference(){return this->calculationPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getCalculationPeriodsReference();
      std::string getCalculationPeriodsReferenceIDRef(){return calculationPeriodsReferenceIDRef_;}

       bool isCalculationPeriodsScheduleReference(){return this->calculationPeriodsScheduleReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsScheduleReference> getCalculationPeriodsScheduleReference();
      std::string getCalculationPeriodsScheduleReferenceIDRef(){return calculationPeriodsScheduleReferenceIDRef_;}

       bool isCalculationPeriodsDatesReference(){return this->calculationPeriodsDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsDatesReference> getCalculationPeriodsDatesReference();
      std::string getCalculationPeriodsDatesReferenceIDRef(){return calculationPeriodsDatesReferenceIDRef_;}

       bool isPaymentDaysOffset(){return this->paymentDaysOffsetIsNull_;}
       boost::shared_ptr<DateOffset> getPaymentDaysOffset();
      std::string getPaymentDaysOffsetIDRef(){return paymentDaysOffsetIDRef_;}

       bool isBusinessCentersReference(){return this->businessCentersReferenceIsNull_;}
       boost::shared_ptr<BusinessCentersReference> getBusinessCentersReference();
      std::string getBusinessCentersReferenceIDRef(){return businessCentersReferenceIDRef_;}

       bool isBusinessCenters(){return this->businessCentersIsNull_;}
       boost::shared_ptr<BusinessCenters> getBusinessCenters();
      std::string getBusinessCentersIDRef(){return businessCentersIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!payRelativeToIsNull_){
                count += 1;
                str = "payRelativeTo" ;
           }
           if(!payRelativeToEventIsNull_){
                count += 1;
                str = "payRelativeToEvent" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!calculationPeriodsReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsReference" ;
           }
           if(!calculationPeriodsScheduleReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsScheduleReference" ;
           }
           if(!calculationPeriodsDatesReferenceIsNull_){
                count += 1;
                str = "calculationPeriodsDatesReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!businessCentersReferenceIsNull_){
                count += 1;
                str = "businessCentersReference" ;
           }
           if(!businessCentersIsNull_){
                count += 1;
                str = "businessCenters" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
   protected: 
         boost::shared_ptr<CommodityPayRelativeToEnum> payRelativeTo_;     //choice
       std::string payRelativeToIDRef_;
       bool payRelativeToIsNull_;
         boost::shared_ptr<CommodityPayRelativeToEvent> payRelativeToEvent_;     //choice
       std::string payRelativeToEventIDRef_;
       bool payRelativeToEventIsNull_;
         boost::shared_ptr<CalculationPeriodsReference> calculationPeriodsReference_;     //choice
       std::string calculationPeriodsReferenceIDRef_;
       bool calculationPeriodsReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsScheduleReference> calculationPeriodsScheduleReference_;     //choice
       std::string calculationPeriodsScheduleReferenceIDRef_;
       bool calculationPeriodsScheduleReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsDatesReference> calculationPeriodsDatesReference_;     //choice
       std::string calculationPeriodsDatesReferenceIDRef_;
       bool calculationPeriodsDatesReferenceIsNull_;
       boost::shared_ptr<DateOffset> paymentDaysOffset_;
       std::string paymentDaysOffsetIDRef_;
       bool paymentDaysOffsetIsNull_;
         boost::shared_ptr<BusinessCentersReference> businessCentersReference_;     //choice
       std::string businessCentersReferenceIDRef_;
       bool businessCentersReferenceIsNull_;
         boost::shared_ptr<BusinessCenters> businessCenters_;     //choice
       std::string businessCentersIDRef_;
       bool businessCentersIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;

};

} //namespaceFpmlSerialized end
#endif

