// FloatingPriceLeg.hpp 
#ifndef FpmlSerialized_FloatingPriceLeg_hpp
#define FpmlSerialized_FloatingPriceLeg_hpp

#include <fpml-com-5-4/FinancialSwapLeg.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-com-5-4/CommodityCalculationPeriodsSchedule.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>
#include <fpml-asset-5-4/Commodity.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantitySchedule.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/CommoditySettlementPeriodsNotionalQuantity.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-com-5-4/QuantityReference.hpp>
#include <fpml-com-5-4/FloatingLegCalculation.hpp>
#include <fpml-com-5-4/CommodityRelativePaymentDates.hpp>
#include <fpml-shared-5-4/AdjustableDatesOrRelativeDateOffset.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/FlatRateEnum.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>

namespace FpmlSerialized {

class FloatingPriceLeg : public FinancialSwapLeg { 
   public: 
       FloatingPriceLeg(TiXmlNode* xmlNode);

       bool isCalculationDates(){return this->calculationDatesIsNull_;}
       boost::shared_ptr<AdjustableDates> getCalculationDates();
      std::string getCalculationDatesIDRef(){return calculationDatesIDRef_;}

       bool isCalculationPeriods(){return this->calculationPeriodsIsNull_;}
       boost::shared_ptr<AdjustableDates> getCalculationPeriods();
      std::string getCalculationPeriodsIDRef(){return calculationPeriodsIDRef_;}

       bool isCalculationPeriodsSchedule(){return this->calculationPeriodsScheduleIsNull_;}
       boost::shared_ptr<CommodityCalculationPeriodsSchedule> getCalculationPeriodsSchedule();
      std::string getCalculationPeriodsScheduleIDRef(){return calculationPeriodsScheduleIDRef_;}

       bool isCalculationPeriodsReference(){return this->calculationPeriodsReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsReference> getCalculationPeriodsReference();
      std::string getCalculationPeriodsReferenceIDRef(){return calculationPeriodsReferenceIDRef_;}

       bool isCalculationPeriodsScheduleReference(){return this->calculationPeriodsScheduleReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsScheduleReference> getCalculationPeriodsScheduleReference();
      std::string getCalculationPeriodsScheduleReferenceIDRef(){return calculationPeriodsScheduleReferenceIDRef_;}

       bool isCalculationPeriodsDatesReference(){return this->calculationPeriodsDatesReferenceIsNull_;}
       boost::shared_ptr<CalculationPeriodsDatesReference> getCalculationPeriodsDatesReference();
      std::string getCalculationPeriodsDatesReferenceIDRef(){return calculationPeriodsDatesReferenceIDRef_;}

       bool isCommodity(){return this->commodityIsNull_;}
       boost::shared_ptr<Commodity> getCommodity();
      std::string getCommodityIDRef(){return commodityIDRef_;}

       bool isNotionalQuantitySchedule(){return this->notionalQuantityScheduleIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantitySchedule> getNotionalQuantitySchedule();
      std::string getNotionalQuantityScheduleIDRef(){return notionalQuantityScheduleIDRef_;}

       bool isNotionalQuantity(){return this->notionalQuantityIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantity> getNotionalQuantity();
      std::string getNotionalQuantityIDRef(){return notionalQuantityIDRef_;}

       bool isSettlementPeriodsNotionalQuantity(){return this->settlementPeriodsNotionalQuantityIsNull_;}
       std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>> getSettlementPeriodsNotionalQuantity();
      std::string getSettlementPeriodsNotionalQuantityIDRef(){return settlementPeriodsNotionalQuantityIDRef_;}

       bool isTotalNotionalQuantity(){return this->totalNotionalQuantityIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getTotalNotionalQuantity();
      std::string getTotalNotionalQuantityIDRef(){return totalNotionalQuantityIDRef_;}

       bool isQuantityReference(){return this->quantityReferenceIsNull_;}
       boost::shared_ptr<QuantityReference> getQuantityReference();
      std::string getQuantityReferenceIDRef(){return quantityReferenceIDRef_;}

       bool isCalculation(){return this->calculationIsNull_;}
       boost::shared_ptr<FloatingLegCalculation> getCalculation();
      std::string getCalculationIDRef(){return calculationIDRef_;}

       bool isRelativePaymentDates(){return this->relativePaymentDatesIsNull_;}
       boost::shared_ptr<CommodityRelativePaymentDates> getRelativePaymentDates();
      std::string getRelativePaymentDatesIDRef(){return relativePaymentDatesIDRef_;}

       bool isPaymentDates(){return this->paymentDatesIsNull_;}
       boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> getPaymentDates();
      std::string getPaymentDatesIDRef(){return paymentDatesIDRef_;}

       bool isMasterAgreementPaymentDates(){return this->masterAgreementPaymentDatesIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMasterAgreementPaymentDates();
      std::string getMasterAgreementPaymentDatesIDRef(){return masterAgreementPaymentDatesIDRef_;}

       bool isFlatRate(){return this->flatRateIsNull_;}
       boost::shared_ptr<FlatRateEnum> getFlatRate();
      std::string getFlatRateIDRef(){return flatRateIDRef_;}

       bool isFlatRateAmount(){return this->flatRateAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getFlatRateAmount();
      std::string getFlatRateAmountIDRef(){return flatRateAmountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!calculationDatesIsNull_){
                count += 1;
                str = "calculationDates" ;
           }
           if(!calculationPeriodsIsNull_){
                count += 1;
                str = "calculationPeriods" ;
           }
           if(!calculationPeriodsScheduleIsNull_){
                count += 1;
                str = "calculationPeriodsSchedule" ;
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
           if(!totalNotionalQuantityIsNull_){
                count += 1;
                str = "totalNotionalQuantity" ;
           }
           if(!quantityReferenceIsNull_){
                count += 1;
                str = "quantityReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
       std::string getChoiceStr_3(){
           std::string str;
           int count = 0;
           if(!notionalQuantityScheduleIsNull_){
                count += 1;
                str = "notionalQuantitySchedule" ;
           }
           if(!notionalQuantityIsNull_){
                count += 1;
                str = "notionalQuantity" ;
           }
           if(!settlementPeriodsNotionalQuantityIsNull_){
                count += 1;
                str = "settlementPeriodsNotionalQuantity" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_3_ = str ;
           return choiceStr_3_;
       }
       std::string getChoiceStr_4(){
           std::string str;
           int count = 0;
           if(!relativePaymentDatesIsNull_){
                count += 1;
                str = "relativePaymentDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_4_ = str ;
           return choiceStr_4_;
       }
       std::string getChoiceStr_5(){
           std::string str;
           int count = 0;
           if(!paymentDatesIsNull_){
                count += 1;
                str = "paymentDates" ;
           }
           if(!masterAgreementPaymentDatesIsNull_){
                count += 1;
                str = "masterAgreementPaymentDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_5_ = str ;
           return choiceStr_5_;
       }
   protected: 
         boost::shared_ptr<AdjustableDates> calculationDates_;     //choice
       std::string calculationDatesIDRef_;
       bool calculationDatesIsNull_;
         boost::shared_ptr<AdjustableDates> calculationPeriods_;     //choice
       std::string calculationPeriodsIDRef_;
       bool calculationPeriodsIsNull_;
         boost::shared_ptr<CommodityCalculationPeriodsSchedule> calculationPeriodsSchedule_;     //choice
       std::string calculationPeriodsScheduleIDRef_;
       bool calculationPeriodsScheduleIsNull_;
         boost::shared_ptr<CalculationPeriodsReference> calculationPeriodsReference_;     //choice
       std::string calculationPeriodsReferenceIDRef_;
       bool calculationPeriodsReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsScheduleReference> calculationPeriodsScheduleReference_;     //choice
       std::string calculationPeriodsScheduleReferenceIDRef_;
       bool calculationPeriodsScheduleReferenceIsNull_;
         boost::shared_ptr<CalculationPeriodsDatesReference> calculationPeriodsDatesReference_;     //choice
       std::string calculationPeriodsDatesReferenceIDRef_;
       bool calculationPeriodsDatesReferenceIsNull_;
       boost::shared_ptr<Commodity> commodity_;
       std::string commodityIDRef_;
       bool commodityIsNull_;
         boost::shared_ptr<CommodityNotionalQuantitySchedule> notionalQuantitySchedule_;     //choice
       std::string notionalQuantityScheduleIDRef_;
       bool notionalQuantityScheduleIsNull_;
         boost::shared_ptr<CommodityNotionalQuantity> notionalQuantity_;     //choice
       std::string notionalQuantityIDRef_;
       bool notionalQuantityIsNull_;
         std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantity>> settlementPeriodsNotionalQuantity_;     //choice
       std::string settlementPeriodsNotionalQuantityIDRef_;
       bool settlementPeriodsNotionalQuantityIsNull_;
         boost::shared_ptr<XsdTypeDecimal> totalNotionalQuantity_;     //choice
       std::string totalNotionalQuantityIDRef_;
       bool totalNotionalQuantityIsNull_;
         boost::shared_ptr<QuantityReference> quantityReference_;     //choice
       std::string quantityReferenceIDRef_;
       bool quantityReferenceIsNull_;
       boost::shared_ptr<FloatingLegCalculation> calculation_;
       std::string calculationIDRef_;
       bool calculationIsNull_;
         boost::shared_ptr<CommodityRelativePaymentDates> relativePaymentDates_;     //choice
       std::string relativePaymentDatesIDRef_;
       bool relativePaymentDatesIsNull_;
         boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> paymentDates_;     //choice
       std::string paymentDatesIDRef_;
       bool paymentDatesIsNull_;
         boost::shared_ptr<XsdTypeBoolean> masterAgreementPaymentDates_;     //choice
       std::string masterAgreementPaymentDatesIDRef_;
       bool masterAgreementPaymentDatesIsNull_;
       boost::shared_ptr<FlatRateEnum> flatRate_;
       std::string flatRateIDRef_;
       bool flatRateIsNull_;
       boost::shared_ptr<NonNegativeMoney> flatRateAmount_;
       std::string flatRateAmountIDRef_;
       bool flatRateAmountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;
       std::string choiceStr_3_;
       std::string choiceStr_4_;
       std::string choiceStr_5_;

};

} //namespaceFpmlSerialized end
#endif

