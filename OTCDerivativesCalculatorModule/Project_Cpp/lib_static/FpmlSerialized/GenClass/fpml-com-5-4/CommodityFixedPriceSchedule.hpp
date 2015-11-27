// CommodityFixedPriceSchedule.hpp 
#ifndef FpmlSerialized_CommodityFixedPriceSchedule_hpp
#define FpmlSerialized_CommodityFixedPriceSchedule_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/FixedPrice.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-com-5-4/CommoditySettlementPeriodsPriceSchedule.hpp>
#include <fpml-com-5-4/CalculationPeriodsReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsScheduleReference.hpp>
#include <fpml-com-5-4/CalculationPeriodsDatesReference.hpp>

namespace FpmlSerialized {

class CommodityFixedPriceSchedule : public ISerialized { 
   public: 
       CommodityFixedPriceSchedule(TiXmlNode* xmlNode);

       bool isFixedPriceStep(){return this->fixedPriceStepIsNull_;}
       std::vector<boost::shared_ptr<FixedPrice>> getFixedPriceStep();
      std::string getFixedPriceStepIDRef(){return fixedPriceStepIDRef_;}

       bool isWorldscaleRateStep(){return this->worldscaleRateStepIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDecimal>> getWorldscaleRateStep();
      std::string getWorldscaleRateStepIDRef(){return worldscaleRateStepIDRef_;}

       bool isContractRateStep(){return this->contractRateStepIsNull_;}
       std::vector<boost::shared_ptr<NonNegativeMoney>> getContractRateStep();
      std::string getContractRateStepIDRef(){return contractRateStepIDRef_;}

       bool isSettlementPeriodsPriceSchedule(){return this->settlementPeriodsPriceScheduleIsNull_;}
       std::vector<boost::shared_ptr<CommoditySettlementPeriodsPriceSchedule>> getSettlementPeriodsPriceSchedule();
      std::string getSettlementPeriodsPriceScheduleIDRef(){return settlementPeriodsPriceScheduleIDRef_;}

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
           if(!fixedPriceStepIsNull_){
                count += 1;
                str = "fixedPriceStep" ;
           }
           if(!worldscaleRateStepIsNull_){
                count += 1;
                str = "worldscaleRateStep" ;
           }
           if(!contractRateStepIsNull_){
                count += 1;
                str = "contractRateStep" ;
           }
           if(!settlementPeriodsPriceScheduleIsNull_){
                count += 1;
                str = "settlementPeriodsPriceSchedule" ;
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
         std::vector<boost::shared_ptr<FixedPrice>> fixedPriceStep_;     //choice
       std::string fixedPriceStepIDRef_;
       bool fixedPriceStepIsNull_;
         std::vector<boost::shared_ptr<XsdTypeDecimal>> worldscaleRateStep_;     //choice
       std::string worldscaleRateStepIDRef_;
       bool worldscaleRateStepIsNull_;
         std::vector<boost::shared_ptr<NonNegativeMoney>> contractRateStep_;     //choice
       std::string contractRateStepIDRef_;
       bool contractRateStepIsNull_;
         std::vector<boost::shared_ptr<CommoditySettlementPeriodsPriceSchedule>> settlementPeriodsPriceSchedule_;     //choice
       std::string settlementPeriodsPriceScheduleIDRef_;
       bool settlementPeriodsPriceScheduleIsNull_;
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

