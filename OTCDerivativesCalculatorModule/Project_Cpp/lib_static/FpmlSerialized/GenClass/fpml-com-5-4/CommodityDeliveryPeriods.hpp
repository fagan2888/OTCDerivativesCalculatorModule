// CommodityDeliveryPeriods.hpp 
#ifndef FpmlSerialized_CommodityDeliveryPeriods_hpp
#define FpmlSerialized_CommodityDeliveryPeriods_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-com-5-4/CommodityCalculationPeriodsSchedule.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>

namespace FpmlSerialized {

class CommodityDeliveryPeriods : public ISerialized { 
   public: 
       CommodityDeliveryPeriods(TiXmlNode* xmlNode);

       bool isPeriods(){return this->periodsIsNull_;}
       boost::shared_ptr<AdjustableDates> getPeriods();
      std::string getPeriodsIDRef(){return periodsIDRef_;}

       bool isPeriodsSchedule(){return this->periodsScheduleIsNull_;}
       boost::shared_ptr<CommodityCalculationPeriodsSchedule> getPeriodsSchedule();
      std::string getPeriodsScheduleIDRef(){return periodsScheduleIDRef_;}

       bool isCalculationPeriodsReference(){return this->calculationPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getCalculationPeriodsReference();
      std::string getCalculationPeriodsReferenceIDRef(){return calculationPeriodsReferenceIDRef_;}

       bool isCalculationPeriodsScheduleReference(){return this->calculationPeriodsScheduleReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsScheduleReference> getCalculationPeriodsScheduleReference();
      std::string getCalculationPeriodsScheduleReferenceIDRef(){return calculationPeriodsScheduleReferenceIDRef_;}

       bool isCalculationPeriodsDatesReference(){return this->calculationPeriodsDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsDatesReference> getCalculationPeriodsDatesReference();
      std::string getCalculationPeriodsDatesReferenceIDRef(){return calculationPeriodsDatesReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!periodsIsNull_){
                count += 1;
                str = "periods" ;
           }
           if(!periodsScheduleIsNull_){
                count += 1;
                str = "periodsSchedule" ;
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
   protected: 
         boost::shared_ptr<AdjustableDates> periods_;     //choice
       std::string periodsIDRef_;
       bool periodsIsNull_;
         boost::shared_ptr<CommodityCalculationPeriodsSchedule> periodsSchedule_;     //choice
       std::string periodsScheduleIDRef_;
       bool periodsScheduleIsNull_;
         boost::shared_ptr<CalculationPeriodsReference> calculationPeriodsReference_;     //choice
       std::string calculationPeriodsReferenceIDRef_;
       bool calculationPeriodsReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsScheduleReference> calculationPeriodsScheduleReference_;     //choice
       std::string calculationPeriodsScheduleReferenceIDRef_;
       bool calculationPeriodsScheduleReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsDatesReference> calculationPeriodsDatesReference_;     //choice
       std::string calculationPeriodsDatesReferenceIDRef_;
       bool calculationPeriodsDatesReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

