// FixedPriceLeg.hpp 
#ifndef FpmlSerialized_FixedPriceLeg_hpp
#define FpmlSerialized_FixedPriceLeg_hpp

#include <fpml-com-5-4/FinancialSwapLeg.hpp>
#include <fpml-shared-5-4/AdjustableDates.hpp>
#include <fpml-com-5-4/CommodityCalculationPeriodsSchedule.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>
#include <fpml-com-5-4/CommodityFixedPriceSchedule.hpp>
#include <fpml-com-5-4/FixedPrice.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-com-5-4/SettlementPeriodsFixedPrice.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantitySchedule.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>
#include <fpml-com-5-4/CommoditySettlementPeriodsNotionalQuantity.hpp>
#include <fpml-com-5-4/QuantityReference.hpp>
#include <fpml-com-5-4/CommodityRelativePaymentDates.hpp>
#include <fpml-shared-5-4/AdjustableDatesOrRelativeDateOffset.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/FlatRateEnum.hpp>

namespace FpmlSerialized {

class FixedPriceLeg : public FinancialSwapLeg { 
   public: 
       FixedPriceLeg(TiXmlNode* xmlNode);

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

       bool isFixedPriceSchedule(){return this->fixedPriceScheduleIsNull_;}
       boost::shared_ptr<CommodityFixedPriceSchedule> getFixedPriceSchedule();
      std::string getFixedPriceScheduleIDRef(){return fixedPriceScheduleIDRef_;}

       bool isFixedPrice(){return this->fixedPriceIsNull_;}
       boost::shared_ptr<FixedPrice> getFixedPrice();
      std::string getFixedPriceIDRef(){return fixedPriceIDRef_;}

       bool isWorldscaleRate(){return this->worldscaleRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getWorldscaleRate();
      std::string getWorldscaleRateIDRef(){return worldscaleRateIDRef_;}

       bool isContractRate(){return this->contractRateIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getContractRate();
      std::string getContractRateIDRef(){return contractRateIDRef_;}

       bool isSettlementPeriodsPrice(){return this->settlementPeriodsPriceIsNull_;}
       std::vector<boost::shared_ptr<SettlementPeriodsFixedPrice>> getSettlementPeriodsPrice();
      std::string getSettlementPeriodsPriceIDRef(){return settlementPeriodsPriceIDRef_;}

       bool isTotalPrice(){return this->totalPriceIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getTotalPrice();
      std::string getTotalPriceIDRef(){return totalPriceIDRef_;}

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
           if(!fixedPriceScheduleIsNull_){
                count += 1;
                str = "fixedPriceSchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
       std::string getChoiceStr_3(){
           std::string str;
           int count = 0;
           if(!fixedPriceIsNull_){
                count += 1;
                str = "fixedPrice" ;
           }
           if(!worldscaleRateIsNull_){
                count += 1;
                str = "worldscaleRate" ;
           }
           if(!contractRateIsNull_){
                count += 1;
                str = "contractRate" ;
           }
           if(!settlementPeriodsPriceIsNull_){
                count += 1;
                str = "settlementPeriodsPrice" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_3_ = str ;
           return choiceStr_3_;
       }
       std::string getChoiceStr_4(){
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
           choiceStr_4_ = str ;
           return choiceStr_4_;
       }
       std::string getChoiceStr_5(){
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
           choiceStr_5_ = str ;
           return choiceStr_5_;
       }
       std::string getChoiceStr_6(){
           std::string str;
           int count = 0;
           if(!relativePaymentDatesIsNull_){
                count += 1;
                str = "relativePaymentDates" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_6_ = str ;
           return choiceStr_6_;
       }
       std::string getChoiceStr_7(){
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
           choiceStr_7_ = str ;
           return choiceStr_7_;
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
         boost::shared_ptr<CommodityFixedPriceSchedule> fixedPriceSchedule_;     //choice
       std::string fixedPriceScheduleIDRef_;
       bool fixedPriceScheduleIsNull_;
         boost::shared_ptr<FixedPrice> fixedPrice_;     //choice
       std::string fixedPriceIDRef_;
       bool fixedPriceIsNull_;
         boost::shared_ptr<XsdTypeDecimal> worldscaleRate_;     //choice
       std::string worldscaleRateIDRef_;
       bool worldscaleRateIsNull_;
         boost::shared_ptr<NonNegativeMoney> contractRate_;     //choice
       std::string contractRateIDRef_;
       bool contractRateIsNull_;
         std::vector<boost::shared_ptr<SettlementPeriodsFixedPrice>> settlementPeriodsPrice_;     //choice
       std::string settlementPeriodsPriceIDRef_;
       bool settlementPeriodsPriceIsNull_;
       boost::shared_ptr<NonNegativeMoney> totalPrice_;
       std::string totalPriceIDRef_;
       bool totalPriceIsNull_;
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
       std::string choiceStr_6_;
       std::string choiceStr_7_;

};

} //namespaceFpmlSerialized end
#endif

