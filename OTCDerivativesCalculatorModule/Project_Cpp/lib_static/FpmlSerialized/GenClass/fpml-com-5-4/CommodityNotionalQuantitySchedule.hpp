// CommodityNotionalQuantitySchedule.hpp 
#ifndef FpmlSerialized_CommodityNotionalQuantitySchedule_hpp
#define FpmlSerialized_CommodityNotionalQuantitySchedule_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/CommoditySettlementPeriodsNotionalQuantitySchedule.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>

namespace FpmlSerialized {

class CommodityNotionalQuantitySchedule : public ISerialized { 
   public: 
       CommodityNotionalQuantitySchedule(TiXmlNode* xmlNode);

       bool isNotionalStep(){return this->notionalStepIsNull_;}
       std::vector<boost::shared_ptr<CommodityNotionalQuantity>> getNotionalStep();
      std::string getNotionalStepIDRef(){return notionalStepIDRef_;}

       bool isSettlementPeriodsNotionalQuantitySchedule(){return this->settlementPeriodsNotionalQuantityScheduleIsNull_;}
       std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantitySchedule>> getSettlementPeriodsNotionalQuantitySchedule();
      std::string getSettlementPeriodsNotionalQuantityScheduleIDRef(){return settlementPeriodsNotionalQuantityScheduleIDRef_;}

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
           if(!notionalStepIsNull_){
                count += 1;
                str = "notionalStep" ;
           }
           if(!settlementPeriodsNotionalQuantityScheduleIsNull_){
                count += 1;
                str = "settlementPeriodsNotionalQuantitySchedule" ;
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
         std::vector<boost::shared_ptr<CommodityNotionalQuantity>> notionalStep_;     //choice
       std::string notionalStepIDRef_;
       bool notionalStepIsNull_;
         std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantitySchedule>> settlementPeriodsNotionalQuantitySchedule_;     //choice
       std::string settlementPeriodsNotionalQuantityScheduleIDRef_;
       bool settlementPeriodsNotionalQuantityScheduleIsNull_;
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

